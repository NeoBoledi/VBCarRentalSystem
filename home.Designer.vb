<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.ProgBar = New System.Windows.Forms.ProgressBar()
        Me.PBHome = New System.Windows.Forms.PictureBox()
        Me.lblhead = New System.Windows.Forms.Label()
        CType(Me.PBHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(179, 329)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(450, 10)
        Me.ProgBar.Step = 1
        Me.ProgBar.TabIndex = 1
        '
        'PBHome
        '
        Me.PBHome.Image = CType(resources.GetObject("PBHome.Image"), System.Drawing.Image)
        Me.PBHome.Location = New System.Drawing.Point(309, 136)
        Me.PBHome.Name = "PBHome"
        Me.PBHome.Size = New System.Drawing.Size(143, 143)
        Me.PBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBHome.TabIndex = 2
        Me.PBHome.TabStop = False
        '
        'lblhead
        '
        Me.lblhead.AutoSize = True
        Me.lblhead.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblhead.ForeColor = System.Drawing.Color.Blue
        Me.lblhead.Location = New System.Drawing.Point(151, 47)
        Me.lblhead.Name = "lblhead"
        Me.lblhead.Size = New System.Drawing.Size(478, 35)
        Me.lblhead.TabIndex = 3
        Me.lblhead.Text = "Car Rental  Management System"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 444)
        Me.Controls.Add(Me.lblhead)
        Me.Controls.Add(Me.PBHome)
        Me.Controls.Add(Me.ProgBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "home"
        CType(Me.PBHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgBar As ProgressBar
    Friend WithEvents PBHome As PictureBox
    Friend WithEvents lblhead As Label
End Class
