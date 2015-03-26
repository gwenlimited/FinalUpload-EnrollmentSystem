Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Register
    Dim sql As New sqlconnect

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        combo_grade()
    End Sub

    Private Sub combo_grade()
        'Dim sqlcon As New SqlConnection With {.ConnectionString = "Server=GWENNYXD\SQLEXPRESS;Initial Catalog=Student_Information;User=sa;Pwd=enrollsyspupt"}
        'Dim query As String = "Select Grade from tbl_grade"
        'Dim dt As New DataTable()
        'Dim str = New SqlCommand(query, sqlcon)
        'sqlcon.Open()
        'Using da As New SqlDataAdapter(str)
        'da.Fill(dt)
        'End Using
        'sql.RunQuerycombo("Select Grade from tbl_grade")
        'With cbx_yr
        '.DisplayMember = "tbl_grade"
        '.ValueMember = "Grade"
        '.DataSource = dt
        '.SelectedIndex = 0
        'End With
    End Sub
    'accepts data with validation if submit button is clicked
    Private Sub btn_submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_submit.Click

        If tbx_lname.Text = "" And tbx_fname.Text = "" And tbx_mname.Text = "" And cbGender.Text = "" _
            And cbx_yr.Text = "" And cbx_sec.Text = "" _
            And tbx_cnum.Text = "" And tbx_hnum.Text = "" And tbx_eadd.Text = "" And tbx_guard.Text = "" _
            And tbx_add.Text = "" And tbx_city.Text = "" And tbx_zip.Text = "" Then
            MsgBox("Fill up the Form", MsgBoxStyle.Information, "Error")

        ElseIf tbx_lname.Text = " " And tbx_fname.Text = " " And tbx_mname.Text = " " And cbGender.Text = " " _
        And cbx_yr.Text = " " And cbx_sec.Text = " " _
        And tbx_cnum.Text = " " And tbx_hnum.Text = " " And tbx_eadd.Text = " " And tbx_guard.Text = " " _
        And tbx_add.Text = " " And tbx_city.Text = " " And tbx_zip.Text = " " Then
            MsgBox("Fill up the Form", MsgBoxStyle.Information, "Error")

        ElseIf tbx_lname.Text = "" Or tbx_lname.Text = " " Then
            MsgBox("Fill up the Form", MsgBoxStyle.Information, "Error") 'Lastname
        ElseIf tbx_fname.Text = "" Or tbx_fname.Text = " " Then
            MsgBox("Fill up the Form", MsgBoxStyle.Information, "Error") 'firstname
        ElseIf cbGender.Text = "" Or cbGender.Text = " " Then
            MsgBox("Fill up the Form", MsgBoxStyle.Information, "Error") 'gender
        ElseIf cbx_yr.Text = "" Or cbx_yr.Text = " " Then
            MsgBox("Fill up the Form", MsgBoxStyle.Information, "Error") 'gradelevel
        ElseIf cbx_sec.Text = "" Or cbx_sec.Text = " " Then
            MsgBox("Fill up the Form", MsgBoxStyle.Information, "Error") 'section
        ElseIf cbx_adv.Text = "" Or cbx_adv.Text = " " Then
            MsgBox("Fill up the Form", MsgBoxStyle.Information, "Error") 'adviser
        ElseIf tbx_cnum.Text = "" And tbx_hnum.Text = "" Or tbx_cnum.Text = " " And tbx_hnum.Text = " " Then
            MsgBox("Input atleast one(1) Contact Number", MsgBoxStyle.Information, "Error") 'Contact number
        ElseIf tbx_guard.Text = "" Or tbx_guard.Text = " " Then
            MsgBox("Fill up the Form", MsgBoxStyle.Information, "Error") 'guardian
        ElseIf tbx_add.Text = "" Or tbx_add.Text = " " Then
            MsgBox("Fill up the Form", MsgBoxStyle.Information, "Error") 'address

        ElseIf tbx_lname.Text = "" And _
               tbx_fname.Text = "" And _
               cbGender.Text = "" And _
               cbx_yr.Text = "" And _
               cbx_sec.Text = "" And _
               tbx_guard.Text = "" And _
               cbx_adv.Text = "" And _
               tbx_add.Text = " " Then
            MsgBox("Fill up all the required fields", MsgBoxStyle.Information, "Error")

        ElseIf sql.hasconnection = True Then
            Dim add As String = tbx_add.Text + " " + tbx_city.Text + " " + tbx_zip.Text
            Dim contact As String = tbx_cnum.Text + ", " + tbx_hnum.Text
            sql.RunQuery("Insert Into tbl_student (Last_Name, First_Name, Middle_Name, Gender, Birthday, Age, Email, Guardian, Address)  Values ('" + tbx_lname.Text + "' , '" + tbx_fname.Text + "' , '" + tbx_mname.Text + "' , '" + cbGender.Text + "' , '" + DateTimePicker1.Value.Date + "' , '" + showage.Text + "', '" + tbx_eadd.Text + "', '" + tbx_guard.Text + "', '" + add + "')")
            sql.RunQuery("Insert Into tbl_contact (Mobile_Number, Home_Number) Values ('" + tbx_cnum.Text + "', '" + tbx_hnum.Text + "')")
            'Course, Yr_sec, Address, Telnum, Email, Guard - other
            ' '" + ys + "', '" + add + "', '" + contact + "','" + tbx_eadd.Text + "','" + tbx_guard.Text + "'
        End If

        MsgBox("ADDED")
        'Clear Form
        tbx_lname.Clear()
        tbx_fname.Clear()
        tbx_mname.Clear()
        cbx_sec.Text = ""
        cbx_adv.Text = ""
        tbx_cnum.Clear()
        tbx_hnum.Clear()
        tbx_eadd.Clear()
        tbx_guard.Clear()
        tbx_add.Clear()
        tbx_city.Clear()
        tbx_zip.Clear()
        cbGender.Text = " "
        cbx_yr.Text = " "
        DateTimePicker1.ResetText()

    End Sub
    'back to home
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub
    'Validations: First Name'
    Private Sub tbx_fname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_fname.Leave
        If tbx_fname.Text = "" Or tbx_fname.Text = " " Then
            tip_noempty.Show("First Name is Required", sender, 5000)

        ElseIf Not Regex.Match(tbx_fname.Text, "^[a-z A-Z\s]+$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input. Numbers are not allowed", sender, 5000)
            tbx_fname.Focus()

        End If
    End Sub
    'Validations: Middle Name'
    Private Sub tbx_mname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_mname.Leave
        If tbx_mname.Text = "" Or tbx_mname.Text = " " Then
            tip_info.Show("Note: Use space if no Middle Name", sender, 5000)

        ElseIf Not Regex.Match(tbx_mname.Text, "^[a-z A-Z\s-]+$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input. Numbers are not allowed", sender, 5000)
            tbx_mname.Focus()

        End If
    End Sub
    'Validations: Gender'
    Private Sub cbGender_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGender.Leave
        If cbGender.Text = " " Or cbGender.Text = "" Then
            tip_noempty.Show("Gender is Required", sender, 5000)

        ElseIf Not Regex.Match(cbGender.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input. Numbers,space, hyphen are not allowed", sender, 5000)
            cbGender.Focus()
        End If
    End Sub
    'Validations: Grade'
    Private Sub cbx_yr_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If cbx_yr.Text = " " Or cbx_yr.Text = "" Then
            tip_noempty.Show("Grade Level is Required", sender, 5000)
        End If
    End Sub
    'Validations: Section'
    Private Sub cbx_sec_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If cbx_sec.Text = " " Or cbx_sec.Text = "" Then
            tip_noempty.Show("Section is Required", sender, 5000)
        End If
    End Sub
    'Validations: Adviser'
    Private Sub tbx_adv_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If cbx_adv.Text = " " Or cbx_adv.Text = "" Then
            tip_info.Show("Note: Indicate Adviser", sender, 5000)

        ElseIf Not Regex.Match(cbx_adv.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input. Numbers, space, hyphen are not allowed", sender, 5000)
            cbx_adv.Focus()
        End If
    End Sub
    'Validations: Guardian'
    Private Sub tbx_guard_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_guard.Leave
        If tbx_guard.Text = " " Or tbx_guard.Text = "" Then
            tip_noempty.Show("Guardian is Required", sender, 5000)

        ElseIf Not Regex.Match(tbx_guard.Text, "^[a-z A-Z/s-]*$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input. Numbers, space, hyphen are not allowed", sender, 5000)
            tbx_guard.Focus()
        End If
    End Sub
    'Validations: Address'
    Private Sub tbx_add_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_add.Leave
        If tbx_add.Text = "" Or tbx_add.Text = " " Then
            tip_noempty.Show("Address is Required", sender, 5000)
        End If
    End Sub
    'Validations: City'
    Private Sub tbx_city_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_city.Leave
        If tbx_city.Text = " " Or tbx_city.Text = "" Then
            tip_noempty.Show("Guardian is Required", sender, 5000)

        ElseIf Not Regex.Match(tbx_city.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input. Numbers, space, hyphen are not allowed", sender, 5000)
            tbx_city.Focus()
        End If
    End Sub
    Private Sub tbx_lname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_lname.Leave
        If tbx_lname.Text = "" Or tbx_lname.Text = " " Then
            tip_noempty.Show("Last name is Required", sender, 5000)

        ElseIf Not Regex.Match(tbx_lname.Text, "^[a-z A-Z\s-]+$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input. Numbers are not allowed", sender, 5000)
            tbx_lname.Focus()
            tbx_lname.Clear()
        End If
    End Sub
    'calculate age
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        With DateTimePicker1.Value
            Dim celebrate As DateTime = New DateTime(Now.Year, .Month, .Day)
            Dim age As Integer = Now.Year - .Year
            If celebrate > Now Then age -= 1
            showage.Text = CStr(age)
        End With
    End Sub

    Private Sub tbx_cnum_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_cnum.Leave
        If tbx_cnum.Text = "" Or tbx_cnum.Text = " " Then
            tip_noempty.Show("enter atleast one mobile number", sender, 5000)
        ElseIf Not Regex.Match(tbx_cnum.Text, "\d{4}-\d{3}-\d{4}", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid Mobile Number", sender, 5000)
            tbx_cnum.Clear()
        End If

    End Sub

    Private Sub tbx_eadd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_eadd.Leave
        If tbx_eadd.Text = "" Or tbx_eadd.Text = " " Then
            tip_noempty.Show("Invalid input", sender, 5000)
        ElseIf Not Regex.Match(tbx_eadd.Text, "^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid Email Address", sender, 5000)
            tbx_eadd.Clear()
        End If
    End Sub
End Class