Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Imports System.Web.Script.Serialization
Public Class Sc
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Private Sub Sc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()

        Dim sc_type As String = MainFrm.lb_scanner_port.Text

        If sc_type = "USB" Then
            'MsgBox("Data")
        Else
            If MainFrm.lb_ctrl_sc_flg.Text = "emp" Then
                Try
                    SerialPort1.PortName = sc_type
                    SerialPort1.BaudRate = 9600
                    SerialPort1.Parity = IO.Ports.Parity.None
                    SerialPort1.StopBits = IO.Ports.StopBits.One
                    SerialPort1.DataBits = 8
                    SerialPort1.Open()
                Catch ex As Exception
                    MsgBox("Please check the USB cable or contact administrator!")

                End Try

            End If

        End If



    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If MainFrm.lb_ctrl_sc_flg.Text = "emp" Then
            ReceivedText(SerialPort1.ReadExisting())
        End If
    End Sub
    Private Sub ReceivedText(ByVal [text] As String)
        If Me.TextBox2.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.TextBox2.Text &= [text]
            If MainFrm.lb_ctrl_sc_flg.Text = "emp" Then
                MsgBox(TextBox2.Text.Count)
                MsgBox(Trim(TextBox2.Text.Count))
                If MainFrm.lb_scanner_port.Text IsNot "USB" And Trim(TextBox2.Text.Count) = 6 Then
                    MsgBox("Corrected")
                    BeginInvoke(Sub()
                                    TextBox2.Text = TextBox2.Text.Substring(0, 5)
                                    TextBox2.Text = TextBox2.Text.ToUpper()
                                    checkEmp()
                                End Sub)
                Else
                    'MsgBox("Incorrected")
                    MsgBox("Please scan employee card only!!!")
                    TextBox2.Text = ""
                    List_Emp.Enabled = True
                    'List_Emp.Show()
                    Dim numPrd As Integer = List_Emp.ListView1.Items.Count
                    If numPrd > 0 Then
                        List_Emp.Button2.Enabled = True
                    End If
                End If
                'SerialPort1.Close()
            End If
        End If
        'SerialPort1.Close()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        List_Emp.Show()
        List_Emp.Enabled = True
        TextBox2.Text = ""
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        List_Emp.Show()
        List_Emp.Enabled = True
        Me.Close()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Public Sub checkEmp()
recheck:
        Try
            If My.Computer.Network.Ping("192.168.161.101") Then
                Dim total = List_Emp.ListView1.Items.Count
                If total < List_Emp.MaxManPower Then
                    TextBox2.Text = TextBox2.Text.ToUpper()
                    If Ck_dup(List_Emp.ListBox2, TextBox2.Text) Then
                        MsgBox("คุณลงทะเบียนไว้เรียบร้อยแล้ว")
                        TextBox2.Text = ""
                        List_Emp.Enabled = True
                        'List_Emp.Show()
                        Dim numPrd As Integer = List_Emp.ListView1.Items.Count
                        If numPrd > 0 Then
                            List_Emp.Button2.Enabled = True
                        End If
                        Me.Hide()
                    Else
                        TextBox2.Text = TextBox2.Text.ToUpper().Trim
                        If TextBox2.Text.Length = 5 Then
                            TextBox2.Text = TextBox2.Text.ToUpper()
                            Dim LoadSQL = Backoffice_model.chk_user_skill_line(Trim(TextBox2.Text), MainFrm.Label4.Text)
                            Dim chkUser As Boolean = True
                            'Dim sk_user As New ArrayList
                            Dim emp_name As String
                            Dim numi As Integer = 0
                            Dim mp_adm_control_flg As String = ""
                            Dim mp_prod_control_flg As String = ""
                            ' While LoadSQL.Read()
                            '  Dim tempp As String = LoadSQL("sk_id").ToString()
                            '  sk_user.Add(tempp)
                            '  numi = numi + 1
                            '  emp_name = LoadSQL("fname").ToString() & " " & LoadSQL("lname").ToString()
                            '  End While
                            If LoadSQL <> "0" Then
                                Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(LoadSQL)
                                For Each item As Object In dict3
                                    'Dim tempp As String = item("sk_id").ToString()
                                    '  sk_user.Add(tempp)
                                    mp_adm_control_flg = item("mp_adm_control_flg").ToString()
                                    mp_prod_control_flg = item("mp_prod_control_flg").ToString()
                                    emp_cd = item("sau_username").ToString()
                                    emp_name = item("sau_fname").ToString() & " " & item("sau_lname").ToString()
                                    numi = numi + 1
                                    emp_name = item("sau_fname").ToString() & " " & item("sau_lname").ToString()
                                Next
                                If mp_prod_control_flg = "1" Then
                                    Dim temp1 As Integer = Convert.ToInt32(List_Emp.lb_count_emp.Text)
                                    List_Emp.lb_count_emp.Text = temp1 + 1
                                    Dim target As Integer = List_Emp.ListBox1.Items.Count
                                    Dim resultTarget As Integer = 0
                                    'For i As Integer = 0 To List_Emp.ListBox1.Items.Count - 1
                                    'For j As Integer = 0 To sk_user.Count - 1
                                    'If List_Emp.ListBox1.Items(i).ToString = sk_user.Item(j).ToString Then
                                    'resultTarget = resultTarget + 1
                                    'End If
                                    '    Next
                                    '    Next
                                    '  If target = resultTarget Then
                                    ' If emp_name = "" Then
                                    'MsgBox("Please Register User Or Skill of user")
                                    'Else
                                    List_Emp.ListBox2.Items.Add(Trim(TextBox2.Text))
                                    List_Emp.ListView1.View = View.Details
                                    List_Emp.ListView1.Items.Add(TextBox2.Text).SubItems.Add(emp_name)
                                    Backoffice_model.arr_list_user.Add(Trim(TextBox2.Text))
                                    'Display(Backoffice_model.arr_list_user)
                                    'Dim result As IEnumerable(Of String) = From numbers In Backoffice_model.arr_list_user Where numbers = "K0071"
                                    '       End If
                                    TextBox2.Text = ""
                                    List_Emp.Enabled = True
                                    List_Emp.Show()
                                    'Dim numPrd As Integer = List_Emp.ListView1.Items.Count
                                    'If numPrd > 0 Then
                                    'List_Emp.Button2.Enabled = True
                                    'End If
                                    'List_Emp.Button4.Visible = True
                                    Me.Hide()
                                    ' Else
                                    ' MsgBox("You need more skill for this production line")
                                    ' TextBox2.Text = ""
                                    ' 'List_Emp.Enabled = True
                                    ' List_Emp.Show()
                                    ' Dim numPrd As Integer = List_Emp.ListView1.Items.Count
                                    ' If numPrd > 0 Then
                                    ' List_Emp.Button2.Enabled = True
                                    'End If
                                    '    'Me.Hide()
                                    'End If
                                Else
                                    MsgBox("คุณไม่มีสิทธิ์ในการเดินไลน์การผลิต")
                                    TextBox2.Text = ""
                                End If
                            Else
                                MsgBox("พนักงานคนนี้ไม่มี สิทธิในการเดินไลน์นี้")
                                TextBox2.Text = ""
                            End If
                        Else
                            MsgBox("Please scan employee card only!!!")
                            TextBox2.Text = ""
                            List_Emp.Enabled = True
                            'List_Emp.Show()
                            Dim numPrd As Integer = List_Emp.ListView1.Items.Count
                            If numPrd > 0 Then
                                List_Emp.Button2.Enabled = True
                            End If
                            'Me.Hide()
                        End If
                    End If
                Else
                    Dim bf = New Backoffice_model
                    List_Emp.MaxManPower = bf.Get_MaxManPower(MainFrm.Label4.Text)
                    MsgBox("ไลน์นี้มีพนักงานเดินไลน์ได้ " & List_Emp.MaxManPower & " คนเท่านั้น")
                End If
            Else
                load_show.Show()
                Dim bf = New Backoffice_model
                List_Emp.MaxManPower = bf.Get_MaxManPower(MainFrm.Label4.Text)
            End If
        Catch ex As Exception
            load_show.Show()
            Dim bf = New Backoffice_model
            List_Emp.MaxManPower = bf.Get_MaxManPower(MainFrm.Label4.Text)
        End Try
    End Sub
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Try
            If My.Computer.Network.Ping("192.168.161.101") Then
                If e.KeyCode = Keys.Enter Then
                    checkEmp()
                End If
            End If
        Catch ex As Exception
            load_show.Show()
        End Try
    End Sub
    Public Sub Display(ByVal argument As IEnumerable(Of String))
        Try
            ' Loop over IEnumerable.
            For Each value As String In argument
                Console.WriteLine("Value: {0}" & value)
            Next
            Console.WriteLine()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function Ck_dup(ByVal Lis As ListBox, ByVal Str As String)
        'Dim Lit = ListBox1.Items.Count - 1
        For i = 0 To Lis.Items.Count - 1

            If Lis.Items(i).ToString = Str Then
                Return True
            End If

            'Lit = ListBox1.Items.Count - 1
            'MsgBox("Code is : " & ListBox1.Items(0).ToString, 0, "Show")
            'ListBox1.Items.RemoveAt(0)
        Next

        Return False
    End Function

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Keyboard.Show()
    End Sub
End Class
