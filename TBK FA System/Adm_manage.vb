Public Class Adm_manage
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Adm_page.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LoadSQL = Backoffice_model.get_information()

        While LoadSQL.Read()
            Inf_manage.TextBox1.Text = LoadSQL("inf_txt").ToString
        End While
        Inf_manage.TextBox1.SelectionStart = Inf_manage.TextBox1.Text.Length

        Inf_manage.Label2.Text = Label2.Text
        Inf_manage.Label3.Text = Label3.Text

        Inf_manage.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        user_manage.ComboBox1.Items.Add("ALL")
        Dim LoadSQLdep = Backoffice_model.get_department()
        While LoadSQLdep.Read()
            user_manage.ComboBox1.Items.Add(LoadSQLdep("sec_name").ToString())
        End While


        Dim LoadSQL = Backoffice_model.get_all_user()
        Dim num As Integer = 0
        While LoadSQL.Read()
            user_manage.ListView1.View = View.Details
            user_manage.ListView1.Items.Add(LoadSQL("emp_id").ToString()).SubItems.AddRange(New String() {LoadSQL("fname").ToString() & " " & LoadSQL("lname").ToString(), LoadSQL("sec_name").ToString()})
        End While

        user_manage.ComboBox1.SelectedIndex = 0
        user_manage.Label2.Text = Label2.Text
        user_manage.Label3.Text = Label3.Text
        user_manage.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim LoadSQL = Backoffice_model.get_all_skill()
        Dim num As Integer = 1
        While LoadSQL.Read()
            skill_manage.ListView1.View = View.Details
            skill_manage.ListView1.Items.Add(num).SubItems.AddRange(New String() {LoadSQL("sk_name").ToString()})
            skill_manage.ListBox1.Items.Add(LoadSQL("sk_id").ToString())
            num = num + 1
        End While

        skill_manage.Label2.Text = Label2.Text
        skill_manage.Label3.Text = Label3.Text
        skill_manage.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim LoadSQL = Backoffice_model.get_all_line()
        Dim num As Integer = 1
        While LoadSQL.Read()
            line_manage.ListView1.View = View.Details
            line_manage.ListView1.Items.Add(num).SubItems.AddRange(New String() {LoadSQL("line_cd").ToString(), LoadSQL("line_name").ToString()})
            line_manage.ListBox1.Items.Add(LoadSQL("line_id").ToString())
            num = num + 1
        End While

        line_manage.Label2.Text = Label2.Text
        line_manage.Label3.Text = Label3.Text
        line_manage.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Enabled = False
        'Scan_reprint.TextBox1.Select()
        Scan_reprint.Show()
    End Sub
End Class