Public Class Adm_login
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Adm_page.Enabled = True
		Me.Close()

	End Sub

	Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

	End Sub

	Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
		If e.KeyCode = Keys.Enter Then
			Dim tempp As String = ""
			Dim emp_cd As String = ""
			Dim name_sur As String = ""
			If TextBox1.Text.Length = 5 Then
				Dim LoadSQL = Backoffice_model.chk_user_skill_line(Trim(TextBox1.Text))
				While LoadSQL.Read()
					tempp = LoadSQL("sug_id").ToString()
					emp_cd = LoadSQL("emp_id").ToString()
					name_sur = LoadSQL("fname").ToString() & " " & LoadSQL("lname").ToString()
				End While
				If tempp = "1" Or tempp = "2" Then
					'MsgBox("OK")
					Adm_manage.Label2.Text = name_sur
					Adm_manage.Label3.Text = "(" & emp_cd & ")"
					Adm_manage.Show()
					Me.Close()
					Adm_page.Hide()
					Adm_page.Enabled = True

				ElseIf tempp = "" Then
					MsgBox("Error! Please login by Admin")
					TextBox1.Text = ""
					'TextBox1.Select()
					Adm_page.Enabled = True
					Me.Close()

				Else
					MsgBox("Error! Please login by Admin")
					TextBox1.Text = ""
					'TextBox1.Select()
					Adm_page.Enabled = True
					Me.Close()

				End If

			Else
				MsgBox("Can't to login! Please scan your employee card.")
				TextBox1.Text = ""
				TextBox1.Select()

			End If
		End If
	End Sub

	Private Sub Adm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
