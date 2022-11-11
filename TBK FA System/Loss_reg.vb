Imports System.Globalization
Public Class Loss_reg
	Public date_start_data As Date
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Try
			If My.Computer.Network.Ping("192.168.161.101") Then
				Try
					Chang_Loss.ListView2.View = View.Details
					'Chang_Loss.ListView2.Scrollable = Size()
					'List_Emp.ListBox2.Items.Add(Trim(TextBox2.Text))
					Dim sel_combo As String = ComboBox1.SelectedIndex
					Dim wi_plan As String = Working_Pro.wi_no.Text
					Dim line_cd As String = Label2.Text
					Dim item_cd As String = Working_Pro.Label3.Text
					Dim seq_no As Integer = Working_Pro.Label22.Text
					Dim shift_prd As String = Working_Pro.Label14.Text
					Dim start_loss As Date = Date.Parse(Label8.Text)
					Dim end_loss As Date = Date.Parse(Label9.Text)
					Dim date1 As Date = Date.Parse(Label8.Text)
					Dim date2 As Date = Date.Parse(Label9.Text)
					Dim total_loss As Integer = DateDiff(DateInterval.Minute, date1, date2)
					Dim loss_type As String = "0"  '0:Normally,1:Manual
					Dim loss_cd_id As String = loss_cd.Text
					Dim op_id As String
					If sel_combo < 0 Then
						op_id = "0"
					Else
						op_id = ListBox1.Items(sel_combo).ToString()
					End If
					Dim pd As String = MainFrm.Label6.Text
					Dim transfer_flg As String = "0"
					Try
						If My.Computer.Network.Ping("192.168.161.101") Then
							transfer_flg = 1
							Backoffice_model.Update_flg_loss(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, total_loss, loss_type, loss_cd_id, op_id, transfer_flg, "2")
							Backoffice_model.Update_flg_loss_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, total_loss, loss_type, loss_cd_id, op_id, transfer_flg, "2")
							Backoffice_model.alert_loss(wi_plan, "2", pd, loss_cd_id)
						Else
							transfer_flg = 0
							Backoffice_model.Update_flg_loss_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, total_loss, loss_type, loss_cd_id, op_id, transfer_flg, "2")
						End If
					Catch ex As Exception
						transfer_flg = 0
						Backoffice_model.Update_flg_loss_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, total_loss, loss_type, loss_cd_id, op_id, transfer_flg, "2")
					End Try
					Dim LoadSQL = Backoffice_model.get_loss_mst()
					While LoadSQL.Read()
						Chang_Loss.ListView2.ForeColor = Color.Blue
						Chang_Loss.ListView2.Items.Add(LoadSQL("id_mst").ToString()).SubItems.AddRange(New String() {LoadSQL("loss_cd").ToString(), LoadSQL("description_th").ToString()})
						Chang_Loss.ListBox1.Items.Add(LoadSQL("loss_type").ToString())
					End While
					Chang_Loss.Show()
					Me.Close()
				Catch ex As Exception
					load_show.Show()
				End Try
			End If
		Catch ex As Exception
			load_show.Show()
		End Try
	End Sub
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Try
			If My.Computer.Network.Ping("192.168.161.101") Then
				Dim line_id As String = MainFrm.line_id.Text
				Try
					If My.Computer.Network.Ping("192.168.161.101") Then
						Backoffice_model.line_status_upd(line_id)
						Backoffice_model.line_status_upd_sqlite(line_id)
					Else
						Backoffice_model.line_status_upd_sqlite(line_id)
					End If
				Catch ex As Exception
					Backoffice_model.line_status_upd_sqlite(line_id)
				End Try
				Dim date_st As String = DateTime.Now.ToString("yyyy/MM/dd H:m:s")
				Dim date_end As String = DateTime.Now.ToString("yyyy/MM/dd H:m:s")
				Try
					If My.Computer.Network.Ping("192.168.161.101") Then
						Backoffice_model.line_status_ins(line_id, date_st, date_end, "1", "0", "24", "0", Prd_detail.lb_wi.Text)
						Backoffice_model.line_status_ins_sqlite(line_id, date_st, date_end, "1", "0", "24", "0", Prd_detail.lb_wi.Text)
					Else
						Backoffice_model.line_status_ins_sqlite(line_id, date_st, date_end, "1", "0", "24", "0", Prd_detail.lb_wi.Text)
					End If
				Catch ex As Exception
					Backoffice_model.line_status_ins_sqlite(line_id, date_st, date_end, "1", "0", "24", "0", Prd_detail.lb_wi.Text)
				End Try
				Dim sel_combo As String = ComboBox1.SelectedIndex
				Dim wi_plan As String = Working_Pro.wi_no.Text
				Dim line_cd As String = Label2.Text
				Dim item_cd As String = Working_Pro.Label3.Text
				Dim seq_no As Integer = Working_Pro.Label22.Text
				Dim shift_prd As String = Working_Pro.Label14.Text
				Dim start_loss As Date = Date.Parse(Label8.Text)
				Dim end_loss As Date = Date.Parse(Label9.Text)
				Dim date1 As Date = Date.Parse(Label8.Text)
				Dim date2 As Date = Date.Parse(Label9.Text)
				Dim date11 As Date = Date.Parse(date_st)
				Dim date22 As Date = Date.Parse(date_end)
				'Dim total_loss As Integer = DateDiff(DateInterval.Minute, date1, date2)
				Dim total_loss As Integer = DateDiff(DateInterval.Minute, date1, date2)
				Dim loss_type As String = "0"  '0:Normally,1:Manual
				Dim loss_cd_id As String = loss_cd.Text
				Dim op_id As String
				If sel_combo < 0 Then
					op_id = "0"
				Else
					op_id = ListBox1.Items(sel_combo).ToString()
				End If
				Dim pd As String = MainFrm.Label6.Text
				Dim transfer_flg As String = "0"
				Try
					If My.Computer.Network.Ping("192.168.161.101") Then
						transfer_flg = "1"
						Backoffice_model.Update_flg_loss(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, test_time_loss_time.Text, loss_type, loss_cd_id, op_id, transfer_flg, "1")
						Backoffice_model.Update_flg_loss_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, test_time_loss_time.Text, loss_type, loss_cd_id, op_id, transfer_flg, "1")
						Backoffice_model.alert_loss(wi_plan, "1", pd, loss_cd_id)
						'Backoffice_model.Insert_prd_close_lot_sqlite(wi_plan, line_cd, item_cd, plan_qty, act_qty, seq_no, shift_prd, staff_no, prd_st_datetime, prd_end_datetime, lot_no, comp_flg2, transfer_flg, del_flg, prd_flg, close_lot_flg, avarage_eff, avarage_act_prd_time)
						'Backoffice_model.Insert_prd_detail(pd, line_cd, wi_plan, item_cd, item_name, staff_no, seq_no, prd_qty, start_time, end_time, use_timee, number_qty)
						'Backoffice_model.test_ins(pd, line_cd, wi_plan, item_cd, seq_no, transfer_flg)
						'Dim temp_co_emp As Integer = List_Emp.ListView1.Items.Count
						'Dim emp_cd As String
						'For i = 0 To temp_co_emp - 1
						'    emp_cd = List_Emp.ListView1.Items(i).Text
						'    Backoffice_model.Insert_emp_cd(wi_plan, emp_cd, seq_no)
						'Next
					Else
						transfer_flg = "0"
						Backoffice_model.Update_flg_loss_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, test_time_loss_time.Text, loss_type, loss_cd_id, op_id, transfer_flg, "1")                'Backoffice_model.Insert_prd_close_lot_sqlite(wi_plan, line_cd, item_cd, plan_qty, act_qty, seq_no, shift_prd, staff_no, prd_st_datetime, prd_end_datetime, lot_no, comp_flg2, transfer_flg, del_flg, prd_flg, close_lot_flg, avarage_eff, avarage_act_prd_time)
						'Backoffice_model.insPrdDetail_sqlite(pd, line_cd, wi_plan, item_cd, item_name, staff_no, seq_no, prd_qty, number_qty, start_time, end_time, use_timee, tr_status)
						'MsgBox("Ins incompleted1")
					End If
				Catch ex As Exception
					'MsgBox("Ins incompleted2")
					transfer_flg = "0"
					Backoffice_model.Update_flg_loss_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, test_time_loss_time.Text, loss_type, loss_cd_id, op_id, transfer_flg, "1")            'Backoffice_model.Insert_prd_close_lot_sqlite(wi_plan, line_cd, item_cd, plan_qty, act_qty, seq_no, shift_prd, staff_no, prd_st_datetime, prd_end_datetime, lot_no, comp_flg2, transfer_flg, del_flg, prd_flg, close_lot_flg, avarage_eff, avarage_act_prd_time)
					'Backoffice_model.insPrdDetail_sqlite(pd, line_cd, wi_plan, item_cd, item_name, staff_no, seq_no, prd_qty, number_qty, start_time, end_time, use_timee, tr_status)
				End Try
				Working_Pro.Enabled = True
				Me.Close()
			Else
				load_show.Show()
			End If
		Catch ex As Exception
			load_show.Show()
		End Try
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Dim date_end_data As String = DateTime.Now.ToString("yyyy/MM/dd H:m:s")
		Dim date_end As Date = date_end_data
		Dim total_loss As Integer = DateDiff(DateInterval.Minute, date_start_data, date_end)
		test_time_loss_time.Text = total_loss
		If total_loss < 0 Then
			Minutes_total = Math.Abs(CDbl(Val(test_time_loss_time.Text)))
			test_time_loss_time.Text = Minutes_total
		End If
		Label9.Text = TimeOfDay.ToString("H:mm:ss")
		'Label1.Text = DateTime.Now.ToString("yyyy/MM/dd")
	End Sub

	Private Sub Loss_reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Timer1.Start()
		date_time_commit_data.Visible = False
		test_time_loss_time.Visible = False
		Label2.Text = MainFrm.Label4.Text
	End Sub

	Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

	End Sub

	Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

	End Sub

	Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

	End Sub

	Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

End Class
