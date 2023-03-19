Imports System.Data.SqlClient
Public Class Cars
    Dim Con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VBCarRentalSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If mtbRegNo.Text = "" Or cbBrand.SelectedIndex = -1 Or mtbModel.Text = "" Or mtbPrice.Text = "" Or mtbColor.Text = "" Or cbAvailable.SelectedIndex = -1 Then
            MsgBox("Missing Data")
        Else
            Try
                Con.Open()
                Dim query = "insert into CarTbl values ('" & mtbRegNo.Text & "', '" & cbBrand.SelectedItem.ToString() & "', '" & mtbModel.Text & "', '" & mtbPrice.Text & "', '" & mtbColor.Text & "', '" & cbAvailable.SelectedItem.ToString() & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Car Successfully Saved")
                Con.Close()
                Clear()
                Populate()

            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub Clear()
        mtbRegNo.Text = ""
        cbBrand.SelectedIndex = -1
        mtbModel.Text = ""
        mtbPrice.Text = ""
        mtbColor.Text = ""
        cbAvailable.SelectedIndex = -1
        Key = 0

    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from CarTbl" 
        Dim cmd = New SqlCommand(sql, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvCarList.DataSource = ds.Tables(0)
        Con.Close()


    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        If mtbRegNo.Text = "" Or cbBrand.SelectedIndex = -1 Or mtbModel.Text = "" Or mtbPrice.Text = "" Or mtbColor.Text = "" Or cbAvailable.SelectedIndex = -1 Then
            MsgBox("No Selected Data")
        Else
            Clear()
        End If
    End Sub

    Private Sub dgvCarList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCarList.CellMouseClick
        Dim row As DataGridViewRow = dgvCarList.Rows(e.RowIndex)
        mtbRegNo.Text = row.Cells(1).Value.ToString
        cbBrand.SelectedItem = row.Cells(2).Value.ToString
        mtbModel.Text = row.Cells(3).Value.ToString
        mtbPrice.Text = row.Cells(4).Value.ToString
        mtbColor.Text = row.Cells(5).Value.ToString
        cbAvailable.SelectedItem = row.Cells(6).Value.ToString
        If mtbRegNo.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Cars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Dim Key = 0
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Key = 0 Then
            MsgBox("Select The Car")

        Else
            Try
                Con.Open()
                Dim query = "delete from CarTbl where CId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Car Successfully Deleted")
                Con.Close()

                Clear()
                Populate()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If mtbRegNo.Text = "" Or cbBrand.SelectedIndex = -1 Or mtbModel.Text = "" Or mtbPrice.Text = "" Or mtbColor.Text = "" Or cbAvailable.SelectedIndex = -1 Then
            MsgBox("Missing Information")

        Else
            Try
                Con.Open()
                Dim query = "update CarTbl set RegNo = '" & mtbRegNo.Text & "', Brand = '" & cbBrand.SelectedItem.ToString() & "', Model = '" & mtbModel.Text & "', Price = '" & mtbPrice.Text & "', Color = '" & mtbColor.Text & "', Available ='" & cbAvailable.SelectedItem.ToString() & "' where CId = " & Key & ""
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