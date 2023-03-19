<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lblLogin))
        Me.lblhead = New System.Windows.Forms.Label()
        Me.pbLogin = New System.Windows.Forms.PictureBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblCAA = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblhead
        '
        Me.lblhead.AutoSize = True
        Me.lblhead.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblhead.ForeColor = System.Drawing.Color.Blue
        Me.lblhead.Location = New System.Drawing.Point(132, 41)
        Me.lblhead.Name = "lblhead"
        Me.lblhead.Size = New System.Drawing.Size(478, 35)
        Me.lblhead.TabIndex = 1
        Me.lblhead.Text = "Car Rental  Management System"
        '
        'pbLogin
        '
        Me.pbLogin.Image = CType(resources.GetObject("pbLogin.Image"), System.Drawing.Image)
        Me.pbLogin.Location = New System.Drawing.Point(69, 151)
        Me.pbLogin.Name = "pbLogin"
        Me.pbLogin.Size = New System.Drawing.Size(143, 143)
        Me.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogin.TabIndex = 3
        Me.pbLogin.TabStop = False
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUser.ForeColor = System.Drawing.Color.Blue
        Me.txtUser.Location = New System.Drawing.Point(393, 173)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(232, 32)
        Me.txtUser.TabIndex = 4
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPass.ForeColor = System.Drawing.Color.Blue
        Me.txtPass.Location = New System.Drawing.Point(393, 231)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(232, 32)
        Me.txtPass.TabIndex = 5
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUser.ForeColor = System.Drawing.Color.Blue
        Me.lblUser.Location = New System.Drawing.Point(245, 182)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(115, 23)
        Me.lblUser.TabIndex = 6
        Me.lblUser.Text = "User Name"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPass.ForeColor = System.Drawing.Color.Blue
        Me.lblPass.Location = New System.Drawing.Point(245, 240)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(98, 23)
        Me.lblPass.TabIndex = 7
        Me.lblPass.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Blue
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(297, 313)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(120, 40)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblCAA
        '
        Me.lblCAA.AutoSize = True
        Me.lblCAA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblCAA.ForeColor = System.Drawing.Color.Blue
        Me.lblCAA.Location = New System.Drawing.Point(275, 387)
        Me.lblCAA.Name = "lblCAA"
        Me.lblCAA.Size = New System.Drawing.Size(196, 23)
        Me.lblCAA.TabIndex = 9
        Me.lblCAA.Text = "Continue As Admin"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblClose.ForeColor = System.Drawing.Color.Blue
        Me.lblClose.Location = New System.Drawing.Point(706, 39)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(37, 37)
        Me.lblClose.TabIndex = 10
        Me.lblClose.Text = "X"
        '
        'lblLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(755, 450)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblCAA)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.pbLogin)
        Me.Controls.Add(Me.lblhead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "lblLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblhead As Label
    Friend WithEvents pbLogin As PictureBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblCAA As Label
    Friend WithEvents lblClose As Label
End Class
