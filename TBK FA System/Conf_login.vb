Public Class Conf_login
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainFrm.Enabled = True
        MainFrm.Hide()

        MainFrm.Show()
        Me.Hide()

        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim usernm As String = TextBox1.Text
        Dim passwd As String = TextBox2.Text
        Dim numm As Integer = 0
        Dim temppo = Backoffice_model.chkLogin(usernm, passwd)

        If temppo.HasRows = True Then
            While temppo.Read()
                numm = numm + 1
            End While
        End If

        If numm = 1 Then
            MainFrm.Enabled = True
            Line_conf.Show()
            MainFrm.Hide()
            Me.Close()
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            MsgBox("Username or password is incorrect!. Please try again.")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Select()
        End If

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
           ByVal keyData As System.Windows.Forms.Keys) _
                                           As Boolean
        Dim usernm As String = TextBox1.Text
        Dim passwd As String = TextBox2.Text
        Dim numm As Integer = 0
        Dim temppo = Backoffice_model.chkLogin(usernm, passwd)

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            If temppo.HasRows = True Then
                While temppo.Read()
                    numm = numm + 1
                End While
            End If

            If numm = 1 Then
                MainFrm.Enabled = True
                Line_conf.Show()
                MainFrm.Hide()
                Me.Hide()
                TextBox1.Text = ""
                TextBox2.Text = ""
            Else
                MsgBox("Username or password is incorrect!. Please try again.")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Select()
            End If
        End If
        'Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Conf_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(12, 90)
    End Sub
End Class