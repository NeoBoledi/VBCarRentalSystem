<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Returns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Returns))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pReturn = New System.Windows.Forms.Panel()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.lblRent = New System.Windows.Forms.Label()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.lblCars = New System.Windows.Forms.Label()
        Me.pSubhead = New System.Windows.Forms.Panel()
        Me.pbRent = New System.Windows.Forms.PictureBox()
        Me.pbCustomers = New System.Windows.Forms.PictureBox()
        Me.pbCars = New System.Windows.Forms.PictureBox()
        Me.pbReturn = New System.Windows.Forms.PictureBox()
        Me.lblRentalsList = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblhead = New System.Windows.Forms.Label()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.pHead = New System.Windows.Forms.Panel()
        Me.cbRegNo = New System.Windows.Forms.ComboBox()
        Me.lblReturnDate = New System.Windows.Forms.Label()
        Me.mtbRentDate = New System.Windows.Forms.MaskedTextBox()
        Me.mtbReturnDate = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCustomerName = New System.Windows.Forms.MaskedTextBox()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.lblRentDate = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.mtbFees = New System.Windows.Forms.MaskedTextBox()
        Me.lblReturnsList = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvRentList = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pSubhead.SuspendLayout()
        CType(Me.pbRent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHead.SuspendLayout()
        CType(Me.dgvRentList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pReturn
        '
        Me.pReturn.BackColor = System.Drawing.Color.Blue
        Me.pReturn.Location = New System.Drawing.Point(956, 63)
        Me.pReturn.Name = "pReturn"
        Me.pReturn.Size = New System.Drawing.Size(147, 10)
        Me.pReturn.TabIndex = 26
        '
        'lblReturn
        '
        Me.lblReturn.AutoSize = True
        Me.lblReturn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblReturn.ForeColor = System.Drawing.Color.Red
        Me.lblReturn.Location = New System.Drawing.Point(1032, 40)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(71, 23)
        Me.lblReturn.TabIndex = 25
        Me.lblReturn.Text = "Return"
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
        'pSubhead
        '
        Me.pSubhead.Controls.Add(Me.pbRent)
        Me.pSubhead.Controls.Add(Me.pbCustomers)
        Me.pSubhead.Controls.Add(Me.pbCars)
        Me.pSubhead.Controls.Add(Me.pReturn)
        Me.pSubhead.Controls.Add(Me.lblReturn)
        Me.pSubhead.Controls.Add(Me.pbReturn)
        Me.pSubhead.Controls.Add(Me.lblRent)
        Me.pSubhead.Controls.Add(Me.lblCustomers)
        Me.pSubhead.Controls.Add(Me.lblCars)
        Me.pSubhead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pSubhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pSubhead.Location = New System.Drawing.Point(0, 69)
        Me.pSubhead.Name = "pSubhead"
        Me.pSubhead.Size = New System.Drawing.Size(1499, 79)
        Me.pSubhead.TabIndex = 32
        '
        'pbRent
        '
        Me.pbRent.Image = CType(resources.GetObject("pbRent.Image"), System.Drawing.Image)
        Me.pbRent.Location = New System.Drawing.Point(714, 6)
        Me.pbRent.Name = "pbRent"
        Me.pbRent.Size = New System.Drawing.Size(81, 57)
        Me.pbRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRent.TabIndex = 29
        Me.pbRent.TabStop = False
        '
        'pbCustomers
        '
        Me.pbCustomers.Image = CType(resources.GetObject("pbCustomers.Image"), System.Drawing.Image)
        Me.pbCustomers.Location = New System.Drawing.Point(441, 6)
        Me.pbCustomers.Name = "pbCustomers"
        Me.pbCustomers.Size = New System.Drawing.Size(86, 57)
        Me.pbCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCustomers.TabIndex = 28
        Me.pbCustomers.TabStop = False
        '
        'pbCars
        '
        Me.pbCars.Image = CType(resources.GetObject("pbCars.Image"), System.Drawing.Image)
        Me.pbCars.Location = New System.Drawing.Point(229, 6)
        Me.pbCars.Name = "pbCars"
        Me.pbCars.Size = New System.Drawing.Size(86, 57)
        Me.pbCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCars.TabIndex = 27
        Me.pbCars.TabStop = False
        '
        'pbReturn
        '
        Me.pbReturn.Image = CType(resources.GetObject("pbReturn.Image"), System.Drawing.Image)
        Me.pbReturn.Location = New System.Drawing.Point(956, 6)
        Me.pbReturn.Name = "pbReturn"
        Me.pbReturn.Size = New System.Drawing.Size(73, 57)
        Me.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbReturn.TabIndex = 24
        Me.pbReturn.TabStop = False
        '
        'lblRentalsList
        '
        Me.lblRentalsList.AutoSize = True
        Me.lblRentalsList.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRentalsList.ForeColor = System.Drawing.Color.Red
        Me.lblRentalsList.Location = New System.Drawing.Point(814, 237)
        Me.lblRentalsList.Name = "lblRentalsList"
        Me.lblRentalsList.Size = New System.Drawing.Size(158, 34)
        Me.lblRentalsList.TabIndex = 25
        Me.lblRentalsList.Text = "Rentals List"
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
        'pbUser
        '
        Me.pbUser.Image = CType(resources.GetObject("pbUser.Image"), System.Drawing.Image)
        Me.pbUser.Location = New System.Drawing.Point(1074, 7)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(86, 59)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUser.TabIndex = 5
        Me.pbUser.TabStop = False
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
        Me.pHead.Controls.Add(Me.lblUser)
        Me.pHead.Controls.Add(Me.lblhead)
        Me.pHead.Controls.Add(Me.pbUser)
        Me.pHead.Controls.Add(Me.pbLogo)
        Me.pHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHead.Location = New System.Drawing.Point(0, 0)
        Me.pHead.Name = "pHead"
        Me.pHead.Size = New System.Drawing.Size(1499, 69)
        Me.pHead.TabIndex = 18
        '
        'cbRegNo
        '
        Me.cbRegNo.FormattingEnabled = True
        Me.cbRegNo.Location = New System.Drawing.Point(145, 270)
        Me.cbRegNo.Name = "cbRegNo"
        Me.cbRegNo.Size = New System.Drawing.Size(211, 28)
        Me.cbRegNo.TabIndex = 45
        '
        'lblReturnDate
        '
        Me.lblReturnDate.AutoSize = True
        Me.lblReturnDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblReturnDate.ForeColor = System.Drawing.Color.Red
        Me.lblReturnDate.Location = New System.Drawing.Point(145, 402)
        Me.lblReturnDate.Name = "lblReturnDate"
        Me.lblReturnDate.Size = New System.Drawing.Size(123, 23)
        Me.lblReturnDate.TabIndex = 43
        Me.lblReturnDate.Text = "Return Date"
        '
        'mtbRentDate
        '
        Me.mtbRentDate.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbRentDate.ForeColor = System.Drawing.Color.Red
        Me.mtbRentDate.Location = New System.Drawing.Point(145, 544)
        Me.mtbRentDate.Name = "mtbRentDate"
        Me.mtbRentDate.Size = New System.Drawing.Size(211, 32)
        Me.mtbRentDate.TabIndex = 42
        '
        'mtbReturnDate
        '
        Me.mtbReturnDate.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbReturnDate.ForeColor = System.Drawing.Color.Red
        Me.mtbReturnDate.Location = New System.Drawing.Point(145, 442)
        Me.mtbReturnDate.Name = "mtbReturnDate"
        Me.mtbReturnDate.Size = New System.Drawing.Size(211, 32)
        Me.mtbReturnDate.TabIndex = 41
        '
        'mtbCustomerName
        '
        Me.mtbCustomerName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbCustomerName.ForeColor = System.Drawing.Color.Red
        Me.mtbCustomerName.Location = New System.Drawing.Point(145, 355)
        Me.mtbCustomerName.Name = "mtbCustomerName"
        Me.mtbCustomerName.Size = New System.Drawing.Size(211, 32)
        Me.mtbCustomerName.TabIndex = 40
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFees.ForeColor = System.Drawing.Color.Red
        Me.lblFees.Location = New System.Drawing.Point(145, 608)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(55, 23)
        Me.lblFees.TabIndex = 39
        Me.lblFees.Text = "Fees"
        '
        'lblRentDate
        '
        Me.lblRentDate.AutoSize = True
        Me.lblRentDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRentDate.ForeColor = System.Drawing.Color.Red
        Me.lblRentDate.Location = New System.Drawing.Point(145, 502)
        Me.lblRentDate.Name = "lblRentDate"
        Me.lblRentDate.Size = New System.Drawing.Size(105, 23)
        Me.lblRentDate.TabIndex = 37
        Me.lblRentDate.Text = "Rent Date"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerName.ForeColor = System.Drawing.Color.Red
        Me.lblCustomerName.Location = New System.Drawing.Point(145, 320)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(170, 23)
        Me.lblCustomerName.TabIndex = 36
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegNo.ForeColor = System.Drawing.Color.Red
        Me.lblRegNo.Location = New System.Drawing.Point(145, 244)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(76, 23)
        Me.lblRegNo.TabIndex = 35
        Me.lblRegNo.Text = "RegNo"
        '
        'mtbFees
        '
        Me.mtbFees.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbFees.ForeColor = System.Drawing.Color.Red
        Me.mtbFees.Location = New System.Drawing.Point(145, 659)
        Me.mtbFees.Name = "mtbFees"
        Me.mtbFees.Size = New System.Drawing.Size(211, 32)
        Me.mtbFees.TabIndex = 34
        '
        'lblReturnsList
        '
        Me.lblReturnsList.AutoSize = True
        Me.lblReturnsList.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblReturnsList.ForeColor = System.Drawing.Color.Red
        Me.lblReturnsList.Location = New System.Drawing.Point(814, 475)
        Me.lblReturnsList.Name = "lblReturnsList"
        Me.lblReturnsList.Size = New System.Drawing.Size(159, 34)
        Me.lblReturnsList.TabIndex = 46
        Me.lblReturnsList.Text = "Returns List"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Blue
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(200, 709)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 40)
        Me.btnAdd.TabIndex = 51
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'dgvRentList
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dgvRentList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRentList.BackgroundColor = System.Drawing.Color.White
        Me.dgvRentList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvRentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRentList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRentList.Location = New System.Drawing.Point(626, 274)
        Me.dgvRentList.MinimumSize = New System.Drawing.Size(0, 26)
        Me.dgvRentList.Name = "dgvRentList"
        Me.dgvRentList.RowHeadersWidth = 51
        Me.dgvRentList.RowTemplate.Height = 26
        Me.dgvRentList.Size = New System.Drawing.Size(603, 167)
        Me.dgvRentList.TabIndex = 52
        '
        'DataGridView1
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Location = New System.Drawing.Point(627, 524)
        Me.DataGridView1.MinimumSize = New System.Drawing.Size(0, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 26
        Me.DataGridView1.Size = New System.Drawing.Size(603, 167)
        Me.DataGridView1.TabIndex = 53
        '
        'Returns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1499, 771)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dgvRentList)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblReturnsList)
        Me.Controls.Add(Me.cbRegNo)
        Me.Controls.Add(Me.lblReturnDate)
        Me.Controls.Add(Me.mtbRentDate)
        Me.Controls.Add(Me.mtbReturnDate)
        Me.Controls.Add(Me.mtbCustomerName)
        Me.Controls.Add(Me.lblFees)
        Me.Controls.Add(Me.lblRentDate)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblRegNo)
        Me.Controls.Add(Me.mtbFees)
        Me.Controls.Add(Me.pSubhead)
        Me.Controls.Add(Me.lblRentalsList)
        Me.Controls.Add(Me.pHead)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Returns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Returns"
        Me.pSubhead.ResumeLayout(False)
        Me.pSubhead.PerformLayout()
        CType(Me.pbRent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHead.ResumeLayout(False)
        Me.pHead.PerformLayout()
        CType(Me.dgvRentList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pReturn As Panel
    Friend WithEvents lblReturn As Label
    Friend WithEvents lblRent As Label
    Friend WithEvents lblCustomers As Label
    Friend WithEvents lblCars As Label
    Friend WithEvents pSubhead As Panel
    Friend WithEvents pbReturn As PictureBox
    Friend WithEvents lblRentalsList As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblhead As Label
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pHead As Panel
    Friend WithEvents cbRegNo As ComboBox
    Friend WithEvents lblReturnDate As Label
    Friend WithEvents mtbRentDate As MaskedTextBox
    Friend WithEvents mtbReturnDate As MaskedTextBox
    Friend WithEvents mtbCustomerName As MaskedTextBox
    Friend WithEvents lblFees As Label
    Friend WithEvents lblRentDate As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblRegNo As Label
    Friend WithEvents mtbFees As MaskedTextBox
    Friend WithEvents lblReturnsList As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvRentList As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pbCars As PictureBox
    Friend WithEvents pbCustomers As PictureBox
    Friend WithEvents pbRent As PictureBox
End Class
