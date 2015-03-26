Imports MySql.Data.MySqlClient

Public Class Home
    Dim con As MySqlConnection
    'Registration
    Private Sub lbl_reg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_reg.Click
        Register.Show()
        Me.Hide()
    End Sub
    'Student List
    Private Sub lbl_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        List.Show()
        Me.Hide()
    End Sub
    'Administration
    Private Sub lbl_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_admin.Click
        admin.Show()
        Me.Hide()
    End Sub
    'Setting
    Private Sub pbx_setting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_setting.Click
        setting.Show()
        Me.Hide()
    End Sub
    'Student List
    Private Sub pbx_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_list.Click
        List.Show()
        Me.Hide()
    End Sub
    'Administration
    Private Sub pbx_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_admin.Click
        admin.Show()
        Me.Hide()
    End Sub
    'Setting
    Private Sub lbl_setting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_setting.Click
        setting.Show()
        Me.Hide()
    End Sub
    'Registration
    Private Sub pbx_reg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_reg.Click
        Register.Show()
        Me.Hide()
    End Sub

End Class
