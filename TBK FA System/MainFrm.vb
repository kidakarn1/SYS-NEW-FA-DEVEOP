Imports System.IO
Imports System.Web.Script.Serialization
Public Class MainFrm
	Public dbClass As New Backoffice_model
	Public dbClass2 As New Backoffice_model
	Public check_status_date As Integer = 0
	'Private Sub button1_click(sender As Object, e As EventArgs)
	'    dbClass.ConnectDB()
	'    dbClass.myConnection.Close()
	'End Sub
	Dim p() As Process
	Public Declare Auto Function FindWindowNullClassName Lib "user32.dll" Alias "FindWindow" (ByVal ipClassname As Integer, ByVal IpWindownName As String) As Integer
	Dim Counter As Integer = 0
	Public Sub check_process()
		Dim hWnd As Integer = FindWindowNullClassName(0, "TBK FA System.exe")
		If hWnd = 0 Then
			'MsgBox("No process found!")
		Else
			'MsgBox(" process found!")
		End If
	End Sub
	Public Function CheckIfRunning()
		p = Process.GetProcessesByName("TBK FA System")
		If p.Count > 1 Then
			Application.Exit()
			Return 1
			' Process is running
		Else
			Return 0
			' Process is not running
		End If
	End Function
	Public Sub check_close_fa()
		If Application.OpenForms().OfType(Of MainFrm).Any Then
		Else
			MsgBox("end program")
		End If
	End Sub
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        check_process()
        If CheckIfRunning() = 0 Then
            dbClass.GetLocalServerAPI()
            dbClass.sqlite_conn_dbsv()
            dbClass.updated_data_to_dbsvr()
            Timer1.Start()
            Timer2.Start()
            Dim sqlss = Backoffice_model.ConnectDBSQLite()
            While sqlss.Read()
                Label6.Text = sqlss("pd").ToString()
                Label4.Text = sqlss("line_cd").ToString()
                count_type.Text = sqlss("count_type").ToString()
                cavity.Text = sqlss("cavity").ToString()
                lb_scanner_port.Text = sqlss("scanner_port").ToString()
                lb_printer_port.Text = sqlss("printer_port").ToString()
                Backoffice_model.SCANNER_PORT = sqlss("scanner_port").ToString()
                lb_dio_port.Text = sqlss("dio_port").ToString()
            End While
            If Backoffice_model.SCANNER_PORT <> "" And Backoffice_model.SCANNER_PORT <> "USB" Then
                lb_ctrl_sc_flg.Text = "emp"
            End If
            Insert_list.Label3.Text = Label4.Text
            Prd_detail.Label3.Text = Label4.Text
        Else
            Application.Exit()
        End If
    End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		check_close_fa()
        Label2.Text = TimeOfDay.ToString("H:mm:ss")
        Label3.Text = DateTime.Now.ToString("D")
        Label1.Text = DateTime.Now.ToString("yyyy/MM/dd")
	End Sub
	Private Sub Label2_Click(sender As Object, e As EventArgs)

	End Sub
	Private Sub menu3_Click(sender As Object, e As EventArgs)
		MsgBox("New version")
	End Sub
	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

	End Sub
	Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

	End Sub
    Public Sub check_lot()
        Try
            If My.Computer.Network.Ping(Backoffice_model.svDatabase) Then
                Working_Pro.Label24.Text = Label4.Text
                Dim i = List_Emp.ListView1.Items.Count
                If i > 0 Then
                    Dim LoadSQL = Backoffice_model.Get_Line_id(Label4.Text)
                    While LoadSQL.Read()
                        line_id.Text = LoadSQL("line_id").ToString()
                    End While
                    Prd_detail.Label2.Text = i
                    Me.Enabled = False
                    Dim lotSubstYear As String = DateTime.Now.ToString("yyyy").Substring(3, 1)
                    Dim lotFirstDigit As String = ""
                    If lotSubstYear = "1" Then
                        lotFirstDigit = "A"
                    ElseIf lotSubstYear = "2" Then
                        lotFirstDigit = "B"
                    ElseIf lotSubstYear = "3" Then
                        lotFirstDigit = "C"
                    ElseIf lotSubstYear = "4" Then
                        lotFirstDigit = "D"
                    ElseIf lotSubstYear = "5" Then
                        lotFirstDigit = "E"
                    ElseIf lotSubstYear = "6" Then
                        lotFirstDigit = "F"
                    ElseIf lotSubstYear = "7" Then
                        lotFirstDigit = "G"
                    ElseIf lotSubstYear = "8" Then
                        lotFirstDigit = "H"
                    ElseIf lotSubstYear = "9" Then
                        lotFirstDigit = "I"
                    ElseIf lotSubstYear = "0" Then
                        lotFirstDigit = "J"
                    End If
                    Dim lotSubstMonth As String = DateTime.Now.ToString("MM")
                    Dim lotSecondDigit As String = ""
                    If lotSubstMonth = "01" Then
                        lotSecondDigit = "A"
                    ElseIf lotSubstMonth = "02" Then
                        lotSecondDigit = "B"
                    ElseIf lotSubstMonth = "03" Then
                        lotSecondDigit = "C"
                    ElseIf lotSubstMonth = "04" Then
                        lotSecondDigit = "D"
                    ElseIf lotSubstMonth = "05" Then
                        lotSecondDigit = "E"
                    ElseIf lotSubstMonth = "06" Then
                        lotSecondDigit = "F"
                    ElseIf lotSubstMonth = "07" Then
                        lotSecondDigit = "G"
                    ElseIf lotSubstMonth = "08" Then
                        lotSecondDigit = "H"
                    ElseIf lotSubstMonth = "09" Then
                        lotSecondDigit = "I"
                    ElseIf lotSubstMonth = "10" Then
                        lotSecondDigit = "J"
                    ElseIf lotSubstMonth = "11" Then
                        lotSecondDigit = "K"
                    ElseIf lotSubstMonth = "12" Then
                        lotSecondDigit = "L"
                    End If
                    Dim lotthirdDigit = DateTime.Now.ToString("dd")
                    Dim d As Date = DateTime.Now.ToString("dd-MM-yyyy")
                    Dim timeShift As String = DateTime.Now.ToString("HH")
                    Dim time_now As String = DateTime.Now.ToString("HH:mm:ss tt")
                    Dim date_st As Integer = lotthirdDigit
                    If time_now >= "00:00:00 AM" And time_now <= "08:00:00 AM" Then
                        date_st = lotthirdDigit - 1
                        If date_st <= 0 Then
                            Dim tmp_date As String = d.AddDays(-1)
                            lotthirdDigit = tmp_date.Substring(0, 2)
                            check_status_date = 1
                            lotSecondDigit = set_data_Month(tmp_date.Substring(3, 2))
                            lotFirstDigit = set_data_Year(tmp_date.Substring(6, 2))
                        Else
                            lotthirdDigit = date_st
                        End If
                    Else
                        'lotthirdDigit -= 1
                    End If
                    Dim defaultShift As String = ""
                    'If timeShift = "05" Or timeShift = "06" Or timeShift = "07" Then
                    'defaultShift = "N (05:00 - 08:00)"
                    'ElseIf timeShift = "08" Or timeShift = "09" Or timeShift = "10" Or timeShift = "11" Or timeShift = "12" Or timeShift = "13" Or timeShift = "14" Or timeShift = "15" Or timeShift = "16" Or timeShift = "17" Then
                    'defaultShift = "A (08:00 - 17:00)"
                    'ElseIf timeShift = "17" Or timeShift = "18" Or timeShift = "19" Then
                    'defaultShift = "M (17:00 - 20:00)"
                    'ElseIf timeShift = "20" Or timeShift = "21" Or timeShift = "22" Or timeShift = "23" Or timeShift = "24" Or timeShift = "00" Or timeShift = "01" Or timeShift = "02" Or timeShift = "03" Or timeShift = "04" Or timeShift = "05" Then
                    'defaultShift = "B (20:00 - 05:00)"
                    'End If
                    If timeShift = "05" Or timeShift = "06" Or timeShift = "07" Then
                        'defaultShift = "N (05:00 - 08:00)"
                        defaultShift = "Q (20:00 - 08:00)"
                    ElseIf timeShift = "08" Or timeShift = "09" Or timeShift = "10" Or timeShift = "11" Or timeShift = "12" Or timeShift = "13" Or timeShift = "14" Or timeShift = "15" Or timeShift = "16" Or timeShift = "17" Then
                        defaultShift = "P (08:00 - 20:00)"
                    ElseIf timeShift = "17" Or timeShift = "18" Or timeShift = "19" Then
                        ' defaultShift = "M (17:00 - 20:00)"
                        defaultShift = "P (08:00 - 20:00)"
                    ElseIf timeShift = "20" Or timeShift = "21" Or timeShift = "22" Or timeShift = "23" Or timeShift = "24" Or timeShift = "00" Or timeShift = "01" Or timeShift = "02" Or timeShift = "03" Or timeShift = "04" Or timeShift = "05" Then
                        defaultShift = "Q (20:00 - 08:00)"
                    End If
                    Prd_detail.Label12.Text = defaultShift
                    If Len(Trim(date_st)) <= 1 Then
                        Dim date_digit
                        If date_st = 0 Then
                            Dim DATES As Date = DateTime.Now.ToString("dd-MM-yyyy")
                            If check_status_date = 0 Then
                                Dim GET_DATA As String = GetLastDayOfMonth(DATES)
                                Dim re = GET_DATA.Substring(0, 2)
                                lotthirdDigit = re
                                date_digit = re
                            Else
                                Dim tmp_date As String = d.AddDays(-1)
                                'MsgBox(tmp_date)
                                'MsgBox("day = " & tmp_date.Substring(0, 2))
                                lotthirdDigit = tmp_date.Substring(0, 2)
                                date_digit = lotthirdDigit
                            End If
                        Else
                            lotthirdDigit = "0" & date_st
                            date_digit = "0" & date_st
                        End If
                        Prd_detail.Label6.Text = lotFirstDigit & lotSecondDigit & date_digit
                    Else
                        Prd_detail.Label6.Text = lotFirstDigit & lotSecondDigit & lotthirdDigit
                    End If
                Else
                    MsgBox("กรุณาลงข้อมูลพนักงานเพื่อเริ่มการผลิต")
                End If
            Else
                load_show.Show()
                Me.Enabled = True
            End If
        Catch ex As Exception
            load_show.Show()
            Me.Enabled = True
        End Try
    End Sub
    Private Sub menu1_Click_1(sender As Object, e As EventArgs) Handles menu1.Click
		check_lot()
        'Prd_detail.Label2.Text = ListView1.Items.Count
        Working_Pro.Label24.Text = Label4.Text
        Dim i = List_Emp.ListView1.Items.Count
        If i > 0 Then
            Prd_detail.Timer3.Enabled = True
            Backoffice_model.SET_LINE_PRODUCTION(Label4.Text)
            Insert_list.Label3.Text = Backoffice_model.GET_LINE_PRODUCTION()
            Prd_detail.Label3.Text = Backoffice_model.GET_LINE_PRODUCTION()
            'Sel_prod_start.Show()
            load_page()
        End If
    End Sub
	Public Sub load_page()
		Working_Pro.lb_nc_qty.Text = "0"
		Working_Pro.lb_ng_qty.Text = "0"
        'MsgBox(line_id.Text)
        Try
            If My.Computer.Network.Ping(Backoffice_model.svDatabase) Then
                Backoffice_model.updated_data_to_dbsvr()
                Dim LoadSQL_prd_plan = Backoffice_model.Get_prd_plan_new(Label4.Text)
                Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(LoadSQL_prd_plan)
                If LoadSQL_prd_plan <> " " Then
                    For Each item As Object In dict
                        Working_Pro.Label27.Text = item("PS_UNIT_NUMERATOR").ToString()
                        Prd_detail.lb_snp.Text = item("PS_UNIT_NUMERATOR").ToString()
                        Prd_detail.lb_item_cd.Text = item("ITEM_CD").ToString()
                        Prd_detail.lb_item_name.Text = item("ITEM_NAME").ToString()
                        Prd_detail.lb_model.Text = item("MODEL").ToString()
                        Prd_detail.lb_plan_qty.Text = item("QTY").ToString()
                        Prd_detail.lb_remain_qty.Text = (item("QTY").ToString() - item("prd_qty_sum").ToString())
                        Prd_detail.lb_wi.Text = item("WI").ToString()
                        Prd_detail.Show()
                    Next
                Else
                    MsgBox("Not have production plan!")
                    Me.Enabled = True
                End If
                'If LoadSQL_prd_plan.Read() Then
                'Prd_detail.lb_item_cd.Text = LoadSQL_prd_plan("ITEM_CD").ToString()
                'Prd_detail.lb_item_name.Text = LoadSQL_prd_plan("ITEM_NAME").ToString()
                'Prd_detail.lb_model.Text = LoadSQL_prd_plan("MODEL").ToString()
                'Prd_detail.lb_plan_qty.Text = LoadSQL_prd_plan("QTY").ToString()
                'Prd_detail.lb_remain_qty.Text = (LoadSQL_prd_plan("QTY").ToString() - LoadSQL_prd_plan("prd_qty_sum").ToString())
                'Prd_detail.lb_wi.Text = LoadSQL_prd_plan("WI").ToString()
                'Prd_detail.Show()
                'MainFrm.Enabled = True
                'MainFrm.Hide()
                'Me.Close()
                'Else
                'MsgBox("Not have production plan!")
                'MainFrm.Enabled = True
                'Me.Close()
                'End If
                Dim LoadSQLskill = Backoffice_model.Get_Line_skill_id(line_id.Text)
                While LoadSQLskill.Read()
                    List_Emp.ListBox1.Items.Add(LoadSQLskill("sk_id").ToString())
                End While
                LoadSQLskill.Close()
            End If
        Catch ex As Exception
            load_show.Show()
            Me.Enabled = True
        End Try
	End Sub
	Function GetLastDayOfMonth(ByVal CurrentDate As DateTime) As DateTime
		With CurrentDate
			Return (New DateTime(.Year, .Month, Date.DaysInMonth(.Year, .Month)))
		End With
	End Function
	Public Function set_data_Month(lotSubstMonth)
		Dim d As Date = DateTime.Now.ToString("dd-MM-yyyy")
		Dim GET_DATA As String = GetLastDayOfMonth(d)
		Dim re = GET_DATA.Substring(3, 2)
		Dim date_st As Integer = lotthirdDigit
		If lotSubstMonth = "01" Then
			lotSecondDigit = "A"
		ElseIf lotSubstMonth = "02" Then
			lotSecondDigit = "B"
		ElseIf lotSubstMonth = "03" Then
			lotSecondDigit = "C"
		ElseIf lotSubstMonth = "04" Then
			lotSecondDigit = "D"
		ElseIf lotSubstMonth = "05" Then
			lotSecondDigit = "E"
		ElseIf lotSubstMonth = "06" Then
			lotSecondDigit = "F"
		ElseIf lotSubstMonth = "07" Then
			lotSecondDigit = "G"
		ElseIf lotSubstMonth = "08" Then
			lotSecondDigit = "H"
		ElseIf lotSubstMonth = "09" Then
			lotSecondDigit = "I"
		ElseIf lotSubstMonth = "10" Then
			lotSecondDigit = "J"
		ElseIf lotSubstMonth = "11" Then
			lotSecondDigit = "K"
		ElseIf lotSubstMonth = "12" Then
			lotSecondDigit = "L"
		End If
		Return lotSecondDigit
	End Function
	Public Function set_data_Year(lotSubstYear)
		'MsgBox("(((((999")
		lotSubstYear = lotSubstYear.Substring(1, 1)
		'lotSubstYear = lotSubstYear - 1
		If lotSubstYear = "1" Then
			lotFirstDigit = "A"
		ElseIf lotSubstYear = "2" Then
			lotFirstDigit = "B"
		ElseIf lotSubstYear = "3" Then
			lotFirstDigit = "C"
		ElseIf lotSubstYear = "4" Then
			lotFirstDigit = "D"
		ElseIf lotSubstYear = "5" Then
			lotFirstDigit = "E"
		ElseIf lotSubstYear = "6" Then
			lotFirstDigit = "F"
		ElseIf lotSubstYear = "7" Then
			lotFirstDigit = "G"
		ElseIf lotSubstYear = "8" Then
			lotFirstDigit = "H"
		ElseIf lotSubstYear = "9" Then
			lotFirstDigit = "I"
		ElseIf lotSubstYear = "0" Then
			lotFirstDigit = "J"
		End If
		Return lotFirstDigit
	End Function
	Private Sub menu4_Click_1(sender As Object, e As EventArgs) Handles menu4.Click
		'Application.Exit()
		Confrm_end.Show()
	End Sub

	Private Sub menu3_Click_1(sender As Object, e As EventArgs)

	End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

	End Sub
	Private Sub menu2_Click(sender As Object, e As EventArgs) Handles menu2.Click
		Conf_login.TextBox1.Select()
		Conf_login.Show()
		'List_Emp.Enabled = True
		'Line_conf.Show()
		Me.Enabled = False

	End Sub
	Private Sub Timer2_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles Timer2.Elapsed
		Try
            If My.Computer.Network.Ping(Backoffice_model.svDatabase) Then
                dbClass.updated_data_to_dbsvr()
                'MsgBox("Synchronous completed")
            Else
                'MsgBox("Synchronous not completed")
            End If
		Catch ex As Exception

		End Try
	End Sub
	Private Sub menu3_Click_2(sender As Object, e As EventArgs) Handles menu3.Click
        Dim LoadSQL = Backoffice_model.get_information()
        While LoadSQL.Read()
            Adm_page.TextBox1.Text = LoadSQL("inf_txt").ToString
        End While
        Adm_page.TextBox1.SelectionStart = Adm_page.TextBox1.Text.Length
        Adm_page.Show()
        Me.Hide()
    End Sub
	Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

	End Sub
	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
		Me.Hide()
		List_Emp.lb_link.Text = "main"
		List_Emp.Show()
		List_Emp.Enabled = False
		Me.Enabled = False
		Sc.TextBox2.Select()
		Sc.Show()
	End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        load_worker()
    End Sub
    Public Sub load_worker()
        Dim i = List_Emp.ListView1.Items.Count
        'If i > 6 Then
        Dim t = New Show_Worker
        t.show()
        'End If
    End Sub

    Private Sub Test_Click(sender As Object, e As EventArgs)
        load_worker()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        load_worker()
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
