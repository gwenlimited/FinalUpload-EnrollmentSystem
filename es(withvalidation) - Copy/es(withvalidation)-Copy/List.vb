Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class List
    Dim sql As New sqlconnect
    Private Sub List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Home.Show()
        Me.Hide()
    End Sub


    Private Sub btn_s_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_s_go.Click
        If sql.hasconnection = True Then
            sql.RunQuery("select Student_Number, Last_Name, First_Name, Middle_Name, Age, Birthday, Gender, Email, Guardian, Address, Mobile_Number, Home_Number from tbl_student as s inner join tbl_contact as c on s.Student_Number = c.Student_Number where First_Name = '" & tbx_s_fname.Text & "' and Last_Name = '" & tbx_s_lname.Text & "' or Middle_Name = '" & tbx_s_mname.Text & "'")
            'where studnum = '" & tbx_s_snum.Text & "'"
        End If
        dgv_stud.DataSource = sql.ds.Tables(0)
    End Sub

End Class

