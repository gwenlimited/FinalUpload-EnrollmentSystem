Imports MySql.Data.MySqlClient
Public Class listbysec
    Dim con As MySqlConnection

    Private Sub form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con = New MySqlConnection("Server=localhost;User Id=root;Password= ;Database=Student_Information")
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        
    End Sub

    Private Sub lbl_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_back.Click
        List.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       

        Dim s_ys As String = cbx_s_yr.Text + "-" + tbx_s_sec.Text
        Dim commandtext As String = "Select * from si where Yr_sec = '" & s_ys & "' and Course = '" & cbx_s_course.Text & "'"

        Dim da As MySqlDataAdapter
        Dim ds As DataSet

        Try
            da = New MySqlDataAdapter(commandtext, con)
            ds = New DataSet()
            da.Fill(ds, "si")
            dgv_sec.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class