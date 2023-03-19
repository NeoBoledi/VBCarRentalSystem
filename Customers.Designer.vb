<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customers))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pCustomers = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pSubhead = New System.Windows.Forms.Panel()
        Me.mtbAddress = New System.Windows.Forms.MaskedTextBox()
        Me.mtbPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblCustomerList = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.mtbCustomerName = New System.Windows.Forms.MaskedTextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblhead = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.pHead = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvCustomerList = New System.Windows.Forms.DataGridView()
        Me.pbReturn = New System.Windows.Forms.PictureBox()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.pbCars = New System.Windows.Forms.PictureBox()
        Me.pbCustomers = New System.Windows.Forms.PictureBox()
        Me.pbRent = New System.Windows.Forms.PictureBox()
        Me.pSubhead.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHead.SuspendLayout()
        CType(Me.dgvCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(1020, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 23)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Return"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(813, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Rent"
        '
        'pCustomers
        '
        Me.pCustomers.BackColor = System.Drawing.Color.Blue
        Me.pCustomers.Location = New System.Drawing.Point(455, 60)
        Me.pCustomers.Name = "pCustomers"
        Me.pCustomers.Size = New System.Drawing.Size(188, 10)
        Me.pCustomers.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(533, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Customers"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(319, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cars"
        '
        'pSubhead
        '
        Me.pSubhead.Controls.Add(Me.pbRent)
        Me.pSubhead.Controls.Add(Me.pbCustomers)
        Me.pSubhead.Controls.Add(Me.pbCars)
        Me.pSubhead.Controls.Add(Me.Label4)
        Me.pSubhead.Controls.Add(Me.pbReturn)
        Me.pSubhead.Controls.Add(Me.Label3)
        Me.pSubhead.Controls.Add(Me.pCustomers)
        Me.pSubhead.Controls.Add(Me.Label2)
        Me.pSubhead.Controls.Add(Me.Label1)
        Me.pSubhead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pSubhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pSubhead.Location = New System.Drawing.Point(0, 69)
        Me.pSubhead.Name = "pSubhead"
        Me.pSubhead.Size = New System.Drawing.Size(1467, 79)
        Me.pSubhead.TabIndex = 32
        '
        'mtbAddress
        '
        Me.mtbAddress.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbAddress.ForeColor = System.Drawing.Color.Red
        Me.mtbAddress.Location = New System.Drawing.Point(574, 221)
        Me.mtbAddress.Name = "mtbAddress"
        Me.mtbAddress.Size = New System.Drawing.Size(211, 32)
        Me.mtbAddress.TabIndex = 27
        '
        'mtbPhone
        '
        Me.mtbPhone.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbPhone.ForeColor = System.Drawing.Color.Red
        Me.mtbPhone.Location = New System.Drawing.Point(942, 221)
        Me.mtbPhone.Name = "mtbPhone"
        Me.mtbPhone.Size = New System.Drawing.Size(211, 32)
        Me.mtbPhone.TabIndex = 26
        '
        'lblCustomerList
        '
        Me.lblCustomerList.AutoSize = True
        Me.lblCustomerList.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerList.ForeColor = System.Drawing.Color.Red
        Me.lblCustomerList.Location = New System.Drawing.Point(615, 374)
        Me.lblCustomerList.Name = "lblCustomerList"
        Me.lblCustomerList.Size = New System.Drawing.Size(192, 34)
        Me.lblCustomerList.TabIndex = 25
        Me.lblCustomerList.Text = "Customer List"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAddress.ForeColor = System.Drawing.Color.Red
        Me.lblAddress.Location = New System.Drawing.Point(574, 183)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(88, 23)
        Me.lblAddress.TabIndex = 23
        Me.lblAddress.Text = "Address"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPhone.ForeColor = System.Drawing.Color.Red
        Me.lblPhone.Location = New System.Drawing.Point(942, 183)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(71, 23)
        Me.lblPhone.TabIndex = 21
        Me.lblPhone.Text = "Phone"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerName.ForeColor = System.Drawing.Color.Red
        Me.lblCustomerName.Location = New System.Drawing.Point(200, 183)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(170, 23)
        Me.lblCustomerName.TabIndex = 20
        Me.lblCustomerName.Text = "Customer Name"
        '
        'mtbCustomerName
        '
        Me.mtbCustomerName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbCustomerName.ForeColor = System.Drawing.Color.Red
        Me.mtbCustomerName.Location = New System.Drawing.Point(200, 221)
        Me.mtbCustomerName.Name = "mtbCustomerName"
        Me.mtbCustomerName.Size = New System.Drawing.Size(211, 32)
        Me.mtbCustomerName.TabIndex = 19
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUser.ForeColor = System.Drawing.Color.Red
        Me.lblUser.Location = New System.Drawing.Point(1166, 37)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(111, 23)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "UserName"
        '
        'lblhead
        '
        Me.lblhead.AutoSize = True
        Me.lblhead.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblhead.ForeColor = System.Drawing.Color.Blue
        Me.lblhead.Location = New System.Drawing.Point(145, 25)
        Me.lblhead.Name = "lblhead"
        Me.lblhead.Size = New System.Drawing.Size(478, 35)
        Me.lblhead.TabIndex = 2
        Me.lblhead.Text = "Car Rental  Management System"
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(48, 4)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(91, 62)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 4
        Me.pbLogo.TabStop = False
        '
        'pHead
        '
        Me.pHead.Controls.Add(Me.pbUser)
        Me.pHead.Controls.Add(Me.lblUser)
        Me.pHead.Controls.Add(Me.lblhead)
        Me.pHead.Controls.Add(Me.pbLogo)
        Me.pHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHead.Location = New System.Drawing.Point(0, 0)
        Me.pHead.Name = "pHead"
        Me.pHead.Size = New System.Drawing.Size(1467, 69)
        Me.pHead.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Blue
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(448, 297)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 40)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Blue
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(598, 297)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 40)
        Me.btnEdit.TabIndex = 36
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Blue
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(873, 297)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 40)
        Me.btnClear.TabIndex = 35
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Blue
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(737, 297)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 40)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dgvCustomerList
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dgvCustomerList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCustomerList.BackgroundColor = System.Drawing.Color.White
        Me.dgvCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCustomerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCustomerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomerList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomerList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCustomerList.Location = New System.Drawing.Point(227, 430)
        Me.dgvCustomerList.MinimumSize = New System.Drawing.Size(0, 26)
        Me.dgvCustomerList.Name = "dgvCustomerList"
        Me.dgvCustomerList.RowHeadersWidth = 51
        Me.dgvCustomerList.RowTemplate.Height = 26
        Me.dgvCustomerList.Size = New System.Drawing.Size(1087, 233)
        Me.dgvCustomerList.TabIndex = 38
        '
        'pbReturn
        '
        Me.pbReturn.Image = CType(resources.GetObject("pbReturn.Image"), System.Drawing.Image)
        Me.pbReturn.Location = New System.Drawing.Point(941, 6)
        Me.pbReturn.Name = "pbReturn"
        Me.pbReturn.Size = New System.Drawing.Size(72, 54)
        Me.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbReturn.TabIndex = 24
        Me.pbReturn.TabStop = False
        '
        'pbUser
        '
        Me.pbUser.Image = CType(resources.GetObject("pbUser.Image"), System.Drawing.Image)
        Me.pbUser.Location = New System.Drawing.Point(1074, 7)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(86, 59)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUser.TabIndex = 6
        Me.pbUser.TabStop = False
        '
        'pbCars
        '
        Me.pbCars.Image = CType(resources.GetObject("pbCars.Image"), System.Drawing.Image)
        Me.pbCars.Location = New System.Drawing.Point(227, 6)
        Me.pbCars.Name = "pbCars"
        Me.pbCars.Size = New System.Drawing.Size(86, 54)
        Me.pbCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCars.TabIndex = 26
        Me.pbCars.TabStop = False
        '
        'pbCustomers
        '
        Me.pbCustomers.Image = CType(resources.GetObject("pbCustomers.Image"), System.Drawing.Image)
        Me.pbCustomers.Location = New System.Drawing.Point(455, 6)
        Me.pbCustomers.Name = "pbCustomers"
        Me.pbCustomers.Size = New System.Drawing.Size(79, 54)
        Me.pbCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCustomers.TabIndex = 27
        Me.pbCustomers.TabStop = False
        '
        'pbRent
        '
        Me.pbRent.Image = CType(resources.GetObject("pbRent.Image"), System.Drawing.Image)
        Me.pbRent.Location = New System.Drawing.Point(722, 6)
        Me.pbRent.Name = "pbRent"
        Me.pbRent.Size = New System.Drawing.Size(85, 54)
        Me.pbRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRent.TabIndex = 28
        Me.pbRent.TabStop = False
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1467, 726)
        Me.Controls.Add(Me.dgvCustomerList)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.pSubhead)
        Me.Controls.Add(Me.mtbAddress)
        Me.Controls.Add(Me.mtbPhone)
        Me.Controls.Add(Me.lblCustomerList)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.mtbCustomerName)
        Me.Controls.Add(Me.pHead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1, 0)
        Me.Name = "Customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        Me.pSubhead.ResumeLayout(False)
        Me.pSubhead.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHead.ResumeLayout(False)
        Me.pHead.PerformLayout()
        CType(Me.dgvCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pCustomers As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pSubhead As Panel
    Friend WithEvents mtbAddress As MaskedTextBox
    Friend WithEvents mtbPhone As MaskedTextBox
    Friend WithEvents lblCustomerList As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents mtbCustomerName As MaskedTextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblhead As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pHead As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvCustomerList As DataGridView
    Friend WithEvents pbReturn As PictureBox
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents pbCars As PictureBox
    Friend WithEvents pbCustomers As PictureBox
    Friend WithEvents pbRent As PictureBox
End Class
