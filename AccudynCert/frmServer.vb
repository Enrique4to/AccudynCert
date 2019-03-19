Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmServer

    Private Sub cmbServer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbServer.SelectedIndexChanged

        lblPath.Text = "Data Source=" & cmbServer.Text & ” ;Integrated Security=True;Initial Catalog=Certificaciones”

    End Sub
    Private Sub frmServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Visible = False
        If ConfigurationManager.ConnectionStrings.Count = 0 Then

            Dim servidores As SqlDataSourceEnumerator
            Dim tablaServidores As DataTable
            servidores = SqlDataSourceEnumerator.Instance
            tablaServidores = New DataTable()
            tablaServidores = servidores.GetDataSources()
            Dim rowServidor As DataRow
            For Each rowServidor In tablaServidores.Rows
                If String.IsNullOrEmpty(rowServidor(“InstanceName”).ToString()) Then
                    cmbServer.Items.Add(rowServidor(“ServerName”).ToString())
                Else
                    cmbServer.Items.Add(rowServidor(“ServerName”) & “\” & rowServidor(“InstanceName”))
                End If
            Next
        Else
            MsgBox(ConnectionStringSettingsCollection())
            frmHome.Show()
            Me.Close()
        End If
    End Sub
    Private Sub btnLoadDB_Click(sender As Object, e As EventArgs) Handles btnLoadDB.Click
        lblPath.Text = "Creando la base de datos..."
        lblPath.Refresh()

        ' La conexión a usar, indicando la base master
        Dim cnn As New SqlConnection(
                        "Server=" & cmbServer.Text & "; " &
                        "database=master; integrated security=yes")
        ' La orden T-SQL para crear la tabla
        Dim s As String = "CREATE DATABASE Certificaciones"
        Dim cmd As New SqlCommand(s, cnn)

        Try
            ' Abrimos la conexión y ejecutamos el comando
            cnn.Open()
            cmd.ExecuteNonQuery()
            '
            lblPath.Text = "Base de datos creada correctamente"

        Catch ex As Exception
            lblPath.Text = "Error al crear la base de datos"
            MessageBox.Show(ex.Message,
                            "Error al crear la base",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Por si se produce un error,
            ' comprobar si la conexión está abierta
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
        lblPath.Refresh()
    End Sub
End Class