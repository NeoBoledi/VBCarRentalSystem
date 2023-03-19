Imports System.Data.SqlClient
Public Class Customers
    Dim Con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VBCarRentalSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If mtbCustomerName.Text = "" Or mtbAddress.Text = "" Or mtbPhone.Text = "" Then
            MsgBox("Missing Data")
        Else
            Try
                Con.Open()
                Dim query = "insert into CustomerTbl values ('" & mtbCustomerName.Text & "','" & mtbAddress.Text & "', '" & mtbPhone.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Successfully Saved")
                Con.Close()

                Clear()
                Populate()

            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub Clear()
        mtbCustomerName.Text = ""
        mtbAddress.Text = ""
        mtbPhone.Text = ""
    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from CustomerTbl"
        Dim cmd = New SqlCommand(sql, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvCustomerList.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If mtbCustomerName.Text = "" Or mtbAddress.Text = "" Or mtbPhone.Text = "" Then
            MsgBox("No Selected Data")
        Else
            Clear()
        End If
    End Sub
    Dim Key = 0
    Private Sub dgvCustomerList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCustomerList.CellMouseClick
        Dim row As DataGridViewRow = dgvCustomerList.Rows(e.RowIndex)
        mtbCustomerName.Text = row.Cells(1).Value.ToString
        mtbAddress.Text = row.Cells(2).Value.ToString
        mtbPhone.Text = row.Cells(3).Value.ToString
        If mtbCustomerName.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Key = 0 Then
            MsgBox("Select Customer")

        Else
            Try
                Con.Open()
                Dim query = "delete from CustomerTbl where CustId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Successfully Deleted")
                Con.Close()

                Clear()
                Populate()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If mtbCustomerName.Text = "" Or mtbAddress.Text = "" Or mtbPhone.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                Con.Open()
                Dim query = "update CustomerTbl set CustName = '" & mtbCustomerName.Text & "', CustAdd = '" & mtbAddress.Text & "', CustPhone = '" & mtbPhone.Text & "' where CustId = " & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Car Successfully Updated")
                Con.Close()

                Clear()
                Populate()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class