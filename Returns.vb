Imports System.Data.SqlClient
Public Class Returns
    Dim Con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VBCarRentalSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class