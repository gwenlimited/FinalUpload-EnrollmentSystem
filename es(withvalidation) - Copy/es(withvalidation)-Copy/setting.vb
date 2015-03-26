Imports System.Text.RegularExpressions
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class setting
    Dim sql As New sqlconnect
    Private Sub setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub tab_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_admin.Click

    End Sub

    Private Sub btn_save_grade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save_grade.Click
        If sql.hasconnection = True Then
            sql.RunQuery("Insert into tbl_grade (Grade) Values ('" + tbx_add_grade.Text + "')")
        End If
        MsgBox("Added")
        tbx_add_grade.Clear()

    End Sub

    Private Sub btn_add_section_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_section.Click
        If sql.hasconnection = True Then
            sql.RunQuery("Insert into tbl_section (Section) Values ('" + tbx_add_section.Text + "')")
        End If
        MsgBox("Added")
        tbx_add_section.Clear()

    End Sub

    Private Sub btn_find_grade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find_grade.Click
        If sql.hasconnection = True Then
            sql.RunQuery("Select * from tbl_grade where Grade = ('" & tbx_find_grade.Text & "')")
        End If
        dgv_search_grsec.DataSource = sql.ds.Tables(0)
    End Sub

    Private Sub btn_grade_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grade_find.Click
        If sql.hasconnection = True Then
            sql.RunQuery("Select * from tbl_section where Section = ('" & tbx_find_section.Text & "')")
        End If
        dgv_search_grsec.DataSource = sql.ds.Tables(0)
    End Sub

    Private Sub btn_add_teacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_teacher.Click
        Dim name As String = tbx_t_fname.Text + " " + tbx_t_lname.Text

        If sql.hasconnection = True Then
            sql.RunQuery("Insert Into tbl_teacher (Name, Birthday, Age, Contact_Number, Email_Address, Designated_Subject) Values ('" + name + "', '" + t_datetimepicker.Value.Date + "', '" + tbx_t_age.Text + "', '" + tbx_t_cnum.Text + "', '" + tbx_t_emailad.Text + "', '" + tbx_t_dsubject.Text + "')")
        End If
        MsgBox("Added")

    End Sub

    Private Sub btn_find_teacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find_teacher.Click
        If sql.hasconnection = True Then
            sql.RunQuery("Select * from tbl_teacher where Name = '" & tbx_s_name_teacher.Text & "'")
        End If
        dgv_search_teacher.DataSource = sql.ds.Tables(0)
    End Sub
    Private Sub t_datetimepicker_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles t_datetimepicker.ValueChanged
        With t_datetimepicker.Value()
            Dim celebrate As DateTime = New DateTime(Now.Year, .Month, .Day)
            Dim age As Integer = Now.Year - .Year
            If celebrate > Now Then age -= 1
            tbx_t_age.Text = CStr(age)
        End With


    End Sub

    Private Sub tbx_t_cnum_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_t_cnum.Leave
        If tbx_t_cnum.Text = "" Or tbx_t_cnum.Text = " " Then
            tip_noempty.Show("enter atleast one mobile number", sender, 5000)
        ElseIf Not Regex.Match(tbx_t_cnum.Text, "\d{4}-\d{3}-\d{4}", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid Mobile Number", sender, 5000)
            tbx_t_cnum.Clear()
        End If
    End Sub

    Private Sub tbx_t_emailad_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_t_emailad.Leave
        If tbx_t_emailad.Text = "" Or tbx_t_emailad.Text = " " Then
            tip_noempty.Show("Invalid input", sender, 5000)
        ElseIf Not Regex.Match(tbx_t_emailad.Text, "^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid Email Address", sender, 5000)
            tbx_t_emailad.Clear()
        End If
    End Sub
End Class