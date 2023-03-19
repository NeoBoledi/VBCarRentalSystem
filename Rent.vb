Imports System.Data.SqlClient
Public Class Rent
    Dim Con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VBCarRentalSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private Sub fillCustomer()
        Con.Open()
        Dim sql = "select * from CustomerTbl"
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        cbCustId.DataSource = Tbl
        cbCustId.DisplayMember = "CustId"
        cbCustId.ValueMember = "CustId"
        Con.Close()
    End Sub
    Private Sub fillRegistration()
        Dim status = "Yes"
        Con.Open()
        Dim sql = "select * from CarTbl where Available ='" & status & "'"
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        cbRegNo.DataSource = Tbl
        cbRegNo.DisplayMember = "RegNo"
        cbRegNo.ValueMember = "RegNo"
        Con.Close()
    End Sub
    Private Sub UpdateCar()
        Dim status = "No"
        Try
            Con.Open()
            Dim query = "update CarTbl set Available = '" & status & "' where RegNo = '" & cbRegNo.SelectedValue.ToString & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            'MsgBox("Car Successfully Updated")
            Con.Close()

            'Clear()
            'Populate()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GetCustomerName()
        Con.Open()
        Dim sql = "select * from CustomerTbl where CustId=" & cbCustId.SelectedValue().ToString() & ""
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            mtbCustomerName.Text = reader(1).ToString()
        End While
        Con.Close()
    End Sub
    Dim Cost
    Private Sub GetCarRate()
        Con.Open()
        Dim sql = "select * from CarTbl where RegNo='" & cbRegNo.SelectedValue().ToString() & "'"
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            Cost = Convert.ToInt32(reader(4).ToString())
        End While
        Con.Close()
    End Sub
    Private Sub Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCustomer()
        fillRegistration()
        Populate()
    End Sub
    Private Sub cbCustId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCustId.SelectionChangeCommitted
        GetCustomerName()
    End Sub
    Private Sub Clear()
        cbRegNo.SelectedIndex = -1
        cbCustId.SelectedIndex = -1
        mtbCustomerName.Text = ""
        RentDate.Text = ""
        ReturnDate.Text = ""
        mtbFees.Text = ""
    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from RentTbl"
        Dim cmd = New SqlCommand(sql, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvRentList.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub CalculateFees()

        Dim diff As System.TimeSpan = ReturnDate.Value.Date.Subtract(RentDate.Value.Date)
            'MsgBox(diff.TotalDays)
            Dim Days = diff.TotalDays
            Dim fees = Days * Cost
        mtbFees.Text = fees

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cbRegNo.SelectedIndex = -1 Or cbCustId.SelectedIndex = -1 Or mtbCustomerName.Text = "" Or RentDate.Text = "" Or ReturnDate.Text = "" Or mtbFees.Text = "" Then
            MsgBox("Missing Data")
        Else
            Try
                Con.Open()
                Dim query = "insert into RentTbl values ('" & cbRegNo.SelectedValue.ToString() & "', '" & cbCustId.SelectedValue.ToString() & "', '" & mtbCustomerName.Text & "', '" & RentDate.Value.Date & "', '" & ReturnDate.Value.Date & "', '" & mtbFees.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Car Successfully Rented. Enjoy")
                Con.Close()
                UpdateCar()
                Clear()
                Populate()
                fillRegistration()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If cbRegNo.SelectedIndex = -1 Or cbCustId.SelectedIndex = -1 Or mtbCustomerName.Text = "" Or RentDate.Text = "" Or ReturnDate.Text = "" Or mtbFees.Text = "" Then
            MsgBox("No Available Data")
        Else
            Clear()
        End If
    End Sub

    Private Sub ReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles ReturnDate.ValueChanged
        CalculateFees()
    End Sub

    Private Sub cbRegNo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbRegNo.SelectionChangeCommitted
        GetCarRate()
    End Sub
End Class