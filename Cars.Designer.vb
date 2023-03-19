<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cars
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cars))
        Me.pHead = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblhead = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.mtbRegNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.lblCarList = New System.Windows.Forms.Label()
        Me.mtbModel = New System.Windows.Forms.MaskedTextBox()
        Me.mtbPrice = New System.Windows.Forms.MaskedTextBox()
        Me.mtbColor = New System.Windows.Forms.MaskedTextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.cbBrand = New System.Windows.Forms.ComboBox()
        Me.cbAvailable = New System.Windows.Forms.ComboBox()
        Me.pSubhead = New System.Windows.Forms.Panel()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.lblRent = New System.Windows.Forms.Label()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.pCars = New System.Windows.Forms.Panel()
        Me.lblCars = New System.Windows.Forms.Label()
        Me.dgvCarList = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pbReturn = New System.Windows.Forms.PictureBox()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.pbCars = New System.Windows.Forms.PictureBox()
        Me.pbCustomers = New System.Windows.Forms.PictureBox()
        Me.pbRent = New System.Windows.Forms.PictureBox()
        Me.pHead.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pSubhead.SuspendLayout()
        CType(Me.dgvCarList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pHead.Size = New System.Drawing.Size(1403, 69)
        Me.pHead.TabIndex = 0
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
        'mtbRegNo
        '
        Me.mtbRegNo.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbRegNo.ForeColor = System.Drawing.Color.Red
        Me.mtbRegNo.Location = New System.Drawing.Point(200, 219)
        Me.mtbRegNo.Name = "mtbRegNo"
        Me.mtbRegNo.Size = New System.Drawing.Size(211, 28)
        Me.mtbRegNo.TabIndex = 1
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegNo.ForeColor = System.Drawing.Color.Red
        Me.lblRegNo.Location = New System.Drawing.Point(200, 181)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(76, 23)
        Me.lblRegNo.TabIndex = 3
        Me.lblRegNo.Text = "RegNo"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblModel.ForeColor = System.Drawing.Color.Red
        Me.lblModel.Location = New System.Drawing.Point(942, 181)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(72, 23)
        Me.lblModel.TabIndex = 4
        Me.lblModel.Text = "Model"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.ForeColor = System.Drawing.Color.Red
        Me.lblPrice.Location = New System.Drawing.Point(200, 275)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(58, 23)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "Price"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBrand.ForeColor = System.Drawing.Color.Red
        Me.lblBrand.Location = New System.Drawing.Point(574, 181)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(66, 23)
        Me.lblBrand.TabIndex = 6
        Me.lblBrand.Text = "Brand"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAvailable.ForeColor = System.Drawing.Color.Red
        Me.lblAvailable.Location = New System.Drawing.Point(942, 275)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(103, 23)
        Me.lblAvailable.TabIndex = 7
        Me.lblAvailable.Text = "Available"
        '
        'lblCarList
        '
        Me.lblCarList.AutoSize = True
        Me.lblCarList.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCarList.ForeColor = System.Drawing.Color.Red
        Me.lblCarList.Location = New System.Drawing.Point(645, 453)
        Me.lblCarList.Name = "lblCarList"
        Me.lblCarList.Size = New System.Drawing.Size(111, 34)
        Me.lblCarList.TabIndex = 8
        Me.lblCarList.Text = "Car List"
        '
        'mtbModel
        '
        Me.mtbModel.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbModel.ForeColor = System.Drawing.Color.Red
        Me.mtbModel.Location = New System.Drawing.Point(942, 219)
        Me.mtbModel.Name = "mtbModel"
        Me.mtbModel.Size = New System.Drawing.Size(211, 28)
        Me.mtbModel.TabIndex = 9
        '
        'mtbPrice
        '
        Me.mtbPrice.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbPrice.ForeColor = System.Drawing.Color.Red
        Me.mtbPrice.Location = New System.Drawing.Point(200, 319)
        Me.mtbPrice.Name = "mtbPrice"
        Me.mtbPrice.Size = New System.Drawing.Size(211, 28)
        Me.mtbPrice.TabIndex = 10
        '
        'mtbColor
        '
        Me.mtbColor.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbColor.ForeColor = System.Drawing.Color.Red
        Me.mtbColor.Location = New System.Drawing.Point(574, 319)
        Me.mtbColor.Name = "mtbColor"
        Me.mtbColor.Size = New System.Drawing.Size(211, 28)
        Me.mtbColor.TabIndex = 11
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblColor.ForeColor = System.Drawing.Color.Red
        Me.lblColor.Location = New System.Drawing.Point(574, 275)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(63, 23)
        Me.lblColor.TabIndex = 12
        Me.lblColor.Text = "Color"
        '
        'cbBrand
        '
        Me.cbBrand.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbBrand.ForeColor = System.Drawing.Color.Red
        Me.cbBrand.FormattingEnabled = True
        Me.cbBrand.Items.AddRange(New Object() {"Tesla", "Porche", "Maserati", "Bentley", "Ferrari", "Audi", "BMW", "Lambhorghini", "Jaguar", "Bugatti"})
        Me.cbBrand.Location = New System.Drawing.Point(574, 219)
        Me.cbBrand.Name = "cbBrand"
        Me.cbBrand.Size = New System.Drawing.Size(211, 29)
        Me.cbBrand.TabIndex = 14
        '
        'cbAvailable
        '
        Me.cbAvailable.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbAvailable.ForeColor = System.Drawing.Color.Red
        Me.cbAvailable.FormattingEnabled = True
        Me.cbAvailable.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbAvailable.Location = New System.Drawing.Point(942, 319)
        Me.cbAvailable.Name = "cbAvailable"
        Me.cbAvailable.Size = New System.Drawing.Size(211, 29)
        Me.cbAvailable.TabIndex = 15
        '
        'pSubhead
        '
        Me.pSubhead.Controls.Add(Me.pbRent)
        Me.pSubhead.Controls.Add(Me.pbCustomers)
        Me.pSubhead.Controls.Add(Me.pbCars)
        Me.pSubhead.Controls.Add(Me.pbReturn)
        Me.pSubhead.Controls.Add(Me.lblReturn)
        Me.pSubhead.Controls.Add(Me.lblRent)
        Me.pSubhead.Controls.Add(Me.lblCustomers)
        Me.pSubhead.Controls.Add(Me.pCars)
        Me.pSubhead.Controls.Add(Me.lblCars)
        Me.pSubhead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pSubhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pSubhead.Location = New System.Drawing.Point(0, 69)
        Me.pSubhead.Name = "pSubhead"
        Me.pSubhead.Size = New System.Drawing.Size(1403, 79)
        Me.pSubhead.TabIndex = 16
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
        'pCars
        '
        Me.pCars.BackColor = System.Drawing.Color.Blue
        Me.pCars.Location = New System.Drawing.Point(241, 60)
        Me.pCars.Name = "pCars"
        Me.pCars.Size = New System.Drawing.Size(141, 10)
        Me.pCars.TabIndex = 17
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
        'dgvCarList
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dgvCarList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCarList.BackgroundColor = System.Drawing.Color.White
        Me.dgvCarList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCarList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCarList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCarList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCarList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCarList.Location = New System.Drawing.Point(200, 509)
        Me.dgvCarList.MinimumSize = New System.Drawing.Size(0, 26)
        Me.dgvCarList.Name = "dgvCarList"
        Me.dgvCarList.RowHeadersWidth = 51
        Me.dgvCarList.RowTemplate.Height = 26
        Me.dgvCarList.Size = New System.Drawing.Size(1087, 233)
        Me.dgvCarList.TabIndex = 17
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Blue
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(685, 386)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 40)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Blue
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(821, 386)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 40)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Blue
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(546, 386)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 40)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Blue
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(396, 386)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 40)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'pbReturn
        '
        Me.pbReturn.Image = CType(resources.GetObject("pbReturn.Image"), System.Drawing.Image)
        Me.pbReturn.Location = New System.Drawing.Point(956, 6)
        Me.pbReturn.Name = "pbReturn"
        Me.pbReturn.Size = New System.Drawing.Size(72, 51)
        Me.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbReturn.TabIndex = 26
        Me.pbReturn.TabStop = False
        '
        'pbUser
        '
        Me.pbUser.Image = CType(resources.GetObject("pbUser.Image"), System.Drawing.Image)
        Me.pbUser.Location = New System.Drawing.Point(1084, 4)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(86, 59)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUser.TabIndex = 6
        Me.pbUser.TabStop = False
        '
        'pbCars
        '
        Me.pbCars.Image = CType(resources.GetObject("pbCars.Image"), System.Drawing.Image)
        Me.pbCars.Location = New System.Drawing.Point(241, 6)
        Me.pbCars.Name = "pbCars"
        Me.pbCars.Size = New System.Drawing.Size(81, 51)
        Me.pbCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCars.TabIndex = 27
        Me.pbCars.TabStop = False
        '
        'pbCustomers
        '
        Me.pbCustomers.Image = CType(resources.GetObject("pbCustomers.Image"), System.Drawing.Image)
        Me.pbCustomers.Location = New System.Drawing.Point(441, 6)
        Me.pbCustomers.Name = "pbCustomers"
        Me.pbCustomers.Size = New System.Drawing.Size(86, 51)
        Me.pbCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCustomers.TabIndex = 28
        Me.pbCustomers.TabStop = False
        '
        'pbRent
        '
        Me.pbRent.Image = CType(resources.GetObject("pbRent.Image"), System.Drawing.Image)
        Me.pbRent.Location = New System.Drawing.Point(711, 6)
        Me.pbRent.Name = "pbRent"
        Me.pbRent.Size = New System.Drawing.Size(84, 51)
        Me.pbRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRent.TabIndex = 29
        Me.pbRent.TabStop = False
        '
        'Cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1403, 763)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgvCarList)
        Me.Controls.Add(Me.pSubhead)
        Me.Controls.Add(Me.cbAvailable)
        Me.Controls.Add(Me.cbBrand)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.mtbColor)
        Me.Controls.Add(Me.mtbPrice)
        Me.Controls.Add(Me.mtbModel)
        Me.Controls.Add(Me.lblCarList)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblRegNo)
        Me.Controls.Add(Me.mtbRegNo)
        Me.Controls.Add(Me.pHead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cars"
        Me.pHead.ResumeLayout(False)
        Me.pHead.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pSubhead.ResumeLayout(False)
        Me.pSubhead.PerformLayout()
        CType(Me.dgvCarList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pHead As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblhead As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents mtbRegNo As MaskedTextBox
    Friend WithEvents lblRegNo As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents lblCarList As Label
    Friend WithEvents mtbModel As MaskedTextBox
    Friend WithEvents mtbPrice As MaskedTextBox
    Friend WithEvents mtbColor As MaskedTextBox
    Friend WithEvents lblColor As Label
    Friend WithEvents cbBrand As ComboBox
    Friend WithEvents cbAvailable As ComboBox
    Friend WithEvents pSubhead As Panel
    Friend WithEvents lblCars As Label
    Friend WithEvents pCars As Panel
    Friend WithEvents lblReturn As Label
    Friend WithEvents lblRent As Label
    Friend WithEvents lblCustomers As Label
    Friend WithEvents dgvCarList As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents pbReturn As PictureBox
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents pbCars As PictureBox
    Friend WithEvents pbCustomers As PictureBox
    Friend WithEvents pbRent As PictureBox
End Class
