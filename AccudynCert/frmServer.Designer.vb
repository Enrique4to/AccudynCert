<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbServer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLoadDB = New System.Windows.Forms.Button()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.pgbLoadDB = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'cmbServer
        '
        Me.cmbServer.FormattingEnabled = True
        Me.cmbServer.Location = New System.Drawing.Point(64, 34)
        Me.cmbServer.Name = "cmbServer"
        Me.cmbServer.Size = New System.Drawing.Size(257, 21)
        Me.cmbServer.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Servidor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Conexión a la base de datos"
        '
        'btnLoadDB
        '
        Me.btnLoadDB.Location = New System.Drawing.Point(246, 61)
        Me.btnLoadDB.Name = "btnLoadDB"
        Me.btnLoadDB.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadDB.TabIndex = 6
        Me.btnLoadDB.Text = "Cargar"
        Me.btnLoadDB.UseVisualStyleBackColor = True
        '
        'lblPath
        '
        Me.lblPath.Location = New System.Drawing.Point(12, 58)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(228, 63)
        Me.lblPath.TabIndex = 7
        Me.lblPath.Text = "Servidor"
        '
        'pgbLoadDB
        '
        Me.pgbLoadDB.Location = New System.Drawing.Point(15, 124)
        Me.pgbLoadDB.Name = "pgbLoadDB"
        Me.pgbLoadDB.Size = New System.Drawing.Size(306, 12)
        Me.pgbLoadDB.TabIndex = 8
        '
        'frmServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 148)
        Me.Controls.Add(Me.pgbLoadDB)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.btnLoadDB)
        Me.Controls.Add(Me.cmbServer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmServer"
        Me.Text = "frmServer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbServer As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLoadDB As Button
    Friend WithEvents lblPath As Label
    Friend WithEvents pgbLoadDB As ProgressBar
End Class
