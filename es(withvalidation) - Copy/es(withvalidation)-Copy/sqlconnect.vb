Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class sqlconnect
    Public sqlcon As New SqlConnection With {.ConnectionString = "Server=GWENNYXD\SQLEXPRESS;Initial Catalog=Student_Information;User=sa;Pwd=enrollsyspupt"}
    Public str As SqlCommand
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public dt As DataTable
    Public dr As SqlDataReader


    Public Function hasconnection() As Boolean
        Try
            sqlcon.Open()
            sqlcon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Sub RunQuery(ByVal Query As String)
        Try
            sqlcon.Open()

            str = New SqlCommand(Query, sqlcon)

            da = New SqlDataAdapter(str)
            ds = New DataSet

            da.Fill(ds)

            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If
        End Try
    End Sub
    Public Sub RunQuerycombo(ByVal Query As String)
        Try
            sqlcon.Open()

            str = New SqlCommand(Query, sqlcon)

            da = New SqlDataAdapter(str)
            dt = New DataTable

            da.Fill(dt)

            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If
        End Try
    End Sub
End Class


