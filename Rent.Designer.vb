<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rent))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.pRent = New System.Windows.Forms.Panel()
        Me.lblRent = New System.Windows.Forms.Label()
        Me.pbRent = New System.Windows.Forms.PictureBox()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.pbCustomers = New System.Windows.Forms.PictureBox()
        Me.lblCars = New System.Windows.Forms.Label()
        Me.pbCars = New System.Windows.Forms.PictureBox()
        Me.pSubhead = New System.Windows.Forms.Panel()
        Me.pbReturn = New System.Windows.Forms.PictureBox()
        Me.cbRegNo = New System.Windows.Forms.ComboBox()
        Me.cbCustId = New System.Windows.Forms.ComboBox()
        Me.lblReturnDate = New System.Windows.Forms.Label()
        Me.mtbCustomerName = New System.Windows.Forms.MaskedTextBox()
        Me.lblRentList = New System.Windows.Forms.Label()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblRentDate = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.mtbFees = New System.Windows.Forms.MaskedTextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblhead = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.pHead = New System.Windows.Forms.Panel()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.RentDate = New System.Windows.Forms.DateTimePicker()
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvRentList = New System.Windows.Forms.DataGridView()
        CType(Me.pbRent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pSubhead.SuspendLayout()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHead.SuspendLayout()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReturn
        '
        Me.lblReturn.AutoSize = True
        Me.lblReturn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblReturn.ForeColor = System.Drawing.Color.Red
        Me.lblReturn.Location = New System.Drawing.Point(1034, 37)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(71, 23)
        Me.lblReturn.TabIndex = 25
        Me.lblReturn.Text = "Return"
        '
        'pRent
        '
        Me.pRent.BackColor = System.Drawing.Color.Blue
        Me.pRent.Location = New System.Drawing.Point(723, 63)
        Me.pRent.Name = "pRent"
        Me.pRent.Size = New System.Drawing.Size(141, 10)
        Me.pRent.TabIndex = 23
        '
        'lblRent
        '
        Me.lblRent.AutoSize = True
        Me.lblRent.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRent.ForeColor = System.Drawing.Color.Red
        Me.lblRent.Location = New System.Drawing.Point(801, 37)
        Me.lblRent.Name = "lblRent"
        Me.lblRent.Size = New System.Drawing.Size(53, 23)
        Me.lblRent.TabIndex = 22
        Me.lblRent.Text = "Rent"
        '
        'pbRent
        '
        Me.pbRent.Image = CType(resources.GetObject("pbRent.Image"), System.Drawing.Image)
        Me.pbRent.Location = New System.Drawing.Point(723, 6)
        Me.pbRent.Name = "pbRent"
        Me.pbRent.Size = New System.Drawing.Size(72, 54)
        Me.pbRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRent.TabIndex = 21
        Me.pbRent.TabStop = False
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomers.ForeColor = System.Drawing.Color.Red
        Me.lblCustomers.Location = New System.Drawing.Point(533, 34)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(113, 23)
        Me.lblCustomers.TabIndex = 19
        Me.lblCustomers.Text = "Customers"
        '
        'pbCustomers
        '
        Me.pbCustomers.Image = CType(resources.GetObject("pbCustomers.Image"), System.Drawing.Image)
        Me.pbCustomers.Location = New System.Drawing.Point(441, 6)
        Me.pbCustomers.Name = "pbCustomers"
        Me.pbCustomers.Size = New System.Drawing.Size(86, 57)
        Me.pbCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCustomers.TabIndex = 18
        Me.pbCustomers.TabStop = False
        '
        'lblCars
        '
        Me.lblCars.AutoSize = True
        Me.lblCars.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCars.ForeColor = System.Drawing.Color.Red
        Me.lblCars.Location = New System.Drawing.Point(319, 34)
        Me.lblCars.Name = "lblCars"
        Me.lblCars.Size = New System.Drawing.Size(54, 23)
        Me.lblCars.TabIndex = 13
        Me.lblCars.Text = "Cars"
        '
        'pbCars
        '
        Me.pbCars.Image = CType(resources.GetObject("pbCars.Image"), System.Drawing.Image)
        Me.pbCars.Location = New System.Drawing.Point(227, 6)
        Me.pbCars.Name = "pbCars"
        Me.pbCars.Size = New System.Drawing.Size(86, 57)
        Me.pbCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCars.TabIndex = 6
        Me.pbCars.TabStop = False
        '
        'pSubhead
        '
        Me.pSubhead.Controls.Add(Me.pbReturn)
        Me.pSubhead.Controls.Add(Me.lblReturn)
        Me.pSubhead.Controls.Add(Me.pRent)
        Me.pSubhead.Controls.Add(Me.lblRent)
        Me.pSubhead.Controls.Add(Me.pbRent)
        Me.pSubhead.Controls.Add(Me.lblCustomers)
        Me.pSubhead.Controls.Add(Me.pbCustomers)
        Me.pSubhead.Controls.Add(Me.lblCars)
        Me.pSubhead.Controls.Add(Me.pbCars)
        Me.pSubhead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pSubhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pSubhead.Location = New System.Drawing.Point(0, 69)
        Me.pSubhead.Name = "pSubhead"
        Me.pSubhead.Size = New System.Drawing.Size(1454, 79)
        Me.pSubhead.TabIndex = 32
        '
        'pbReturn
        '
        Me.pbReturn.Image = CType(resources.GetObject("pbReturn.Image"), System.Drawing.Image)
        Me.pbReturn.Location = New System.Drawing.Point(956, 6)
        Me.pbReturn.Name = "pbReturn"
        Me.pbReturn.Size = New System.Drawing.Size(72, 57)
        Me.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbReturn.TabIndex = 26
        Me.pbReturn.TabStop = False
        '
        'cbRegNo
        '
        Me.cbRegNo.FormattingEnabled = True
        Me.cbRegNo.Location = New System.Drawing.Point(200, 200)
        Me.cbRegNo.Name = "cbRegNo"
        Me.cbRegNo.Size = New System.Drawing.Size(211, 28)
        Me.cbRegNo.TabIndex = 31
        '
        'cbCustId
        '
        Me.cbCustId.FormattingEnabled = True
        Me.cbCustId.Location = New System.Drawing.Point(574, 200)
        Me.cbCustId.Name = "cbCustId"
        Me.cbCustId.Size = New System.Drawing.Size(211, 28)
        Me.cbCustId.TabIndex = 30
        '
        'lblReturnDate
        '
        Me.lblReturnDate.AutoSize = True
        Me.lblReturnDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblReturnDate.ForeColor = System.Drawing.Color.Red
        Me.lblReturnDate.Location = New System.Drawing.Point(574, 256)
        Me.lblReturnDate.Name = "lblReturnDate"
        Me.lblReturnDate.Size = New System.Drawing.Size(123, 23)
        Me.lblReturnDate.TabIndex = 29
        Me.lblReturnDate.Text = "Return Date"
        '
        'mtbCustomerName
        '
        Me.mtbCustomerName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbCustomerName.ForeColor = System.Drawing.Color.Red
        Me.mtbCustomerName.Location = New System.Drawing.Point(942, 200)
        Me.mtbCustomerName.Name = "mtbCustomerName"
        Me.mtbCustomerName.Size = New System.Drawing.Size(211, 32)
        Me.mtbCustomerName.TabIndex = 26
        '
        'lblRentList
        '
        Me.lblRentList.AutoSize = True
        Me.lblRentList.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRentList.ForeColor = System.Drawing.Color.Red
        Me.lblRentList.Location = New System.Drawing.Point(660, 437)
        Me.lblRentList.Name = "lblRentList"
        Me.lblRentList.Size = New System.Drawing.Size(158, 34)
        Me.lblRentList.TabIndex = 25
        Me.lblRentList.Text = "Rentals List"
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFees.ForeColor = System.Drawing.Color.Red
        Me.lblFees.Location = New System.Drawing.Point(942, 256)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(55, 23)
        Me.lblFees.TabIndex = 24
        Me.lblFees.Text = "Fees"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerID.ForeColor = System.Drawing.Color.Red
        Me.lblCustomerID.Location = New System.Drawing.Point(574, 162)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(130, 23)
        Me.lblCustomerID.TabIndex = 23
        Me.lblCustomerID.Text = "Customer ID"
        '
        'lblRentDate
        '
        Me.lblRentDate.AutoSize = True
        Me.lblRentDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRentDate.ForeColor = System.Drawing.Color.Red
        Me.lblRentDate.Location = New System.Drawing.Point(200, 256)
        Me.lblRentDate.Name = "lblRentDate"
        Me.lblRentDate.Size = New System.Drawing.Size(105, 23)
        Me.lblRentDate.TabIndex = 22
        Me.lblRentDate.Text = "Rent Date"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerName.ForeColor = System.Drawing.Color.Red
        Me.lblCustomerName.Location = New System.Drawing.Point(942, 162)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(170, 23)
        Me.lblCustomerName.TabIndex = 21
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegNo.ForeColor = System.Drawing.Color.Red
        Me.lblRegNo.Location = New System.Drawing.Point(200, 162)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(76, 23)
        Me.lblRegNo.TabIndex = 20
        Me.lblRegNo.Text = "RegNo"
        '
        'mtbFees
        '
        Me.mtbFees.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbFees.ForeColor = System.Drawing.Color.Red
        Me.mtbFees.Location = New System.Drawing.Point(942, 309)
        Me.mtbFees.Name = "mtbFees"
        Me.mtbFees.Size = New System.Drawing.Size(211, 32)
        Me.mtbFees.TabIndex = 19
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
        Me.pbLogo.Location = New System.Drawing.Point(48, 7)
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
        Me.pHead.Size = New System.Drawing.Size(1454, 69)
        Me.pHead.TabIndex = 18
        '
        'pbUser
        '
        Me.pbUser.Image = CType(resources.GetObject("pbUser.Image"), System.Drawing.Image)
        Me.pbUser.Location = New System.Drawing.Point(1074, 3)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(86, 59)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUser.TabIndex = 6
        Me.pbUser.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Blue
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(533, 382)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 40)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Blue
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(695, 382)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 40)
        Me.btnClear.TabIndex = 35
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'RentDate
        '
        Me.RentDate.CalendarFont = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RentDate.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RentDate.Location = New System.Drawing.Point(200, 305)
        Me.RentDate.Name = "RentDate"
        Me.RentDate.Size = New System.Drawing.Size(207, 32)
        Me.RentDate.TabIndex = 38
        '
        'ReturnDate
        '
        Me.ReturnDate.CalendarFont = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ReturnDate.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReturnDate.Location = New System.Drawing.Point(574, 305)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(207, 32)
        Me.ReturnDate.TabIndex = 39
        '
        'dgvRentList
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dgvRentList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRentList.BackgroundColor = System.Drawing.Color.White
        Me.dgvRentList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvRentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRentList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRentList.Location = New System.Drawing.Point(227, 499)
        Me.dgvRentList.MinimumSize = New System.Drawing.Size(0, 26)
        Me.dgvRentList.Name = "dgvRentList"
        Me.dgvRentList.RowHeadersWidth = 51
        Me.dgvRentList.RowTemplate.Height = 26
        Me.dgvRentList.Size = New System.Drawing.Size(1087, 233)
        Me.dgvRentList.TabIndex = 40
        '
        'Rent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1454, 744)
        Me.Controls.Add(Me.dgvRentList)
        Me.Controls.Add(Me.ReturnDate)
        Me.Controls.Add(Me.RentDate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.pSubhead)
        Me.Controls.Add(Me.cbRegNo)
        Me.Controls.Add(Me.cbCustId)
        Me.Controls.Add(Me.lblReturnDate)
        Me.Controls.Add(Me.mtbCustomerName)
        Me.Controls.Add(Me.lblRentList)
        Me.Controls.Add(Me.lblFees)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lblRentDate)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblRegNo)
        Me.Controls.Add(Me.mtbFees)
        Me.Controls.Add(Me.pHead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rent"
        CType(Me.pbRent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pSubhead.ResumeLayout(False)
        Me.pSubhead.PerformLayout()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHead.ResumeLayout(False)
        Me.pHead.PerformLayout()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReturn As Label
    Friend WithEvents pRent As Panel
    Friend WithEvents lblRent As Label
    Friend WithEvents pbRent As PictureBox
    Friend WithEvents lblCustomers As Label
    Friend WithEvents pbCustomers As PictureBox
    Friend WithEvents lblCars As Label
    Friend WithEvents pbCars As PictureBox
    Friend WithEvents pSubhead As Panel
    Friend WithEvents cbRegNo As ComboBox
    Friend WithEvents cbCustId As ComboBox
    Friend WithEvents lblReturnDate As Label
    Friend WithEvents mtbCustomerName As MaskedTextBox
    Friend WithEvents lblRentList As Label
    Friend WithEvents lblFees As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblRentDate As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblRegNo As Label
    Friend WithEvents mtbFees As MaskedTextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblhead As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pHead As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents RentDate As DateTimePicker
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents dgvRentList As DataGridView
    Friend WithEvents pbReturn As PictureBox
    Friend WithEvents pbUser As PictureBox
End Class
