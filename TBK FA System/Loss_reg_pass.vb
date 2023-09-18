Public Class Loss_reg_pass
    Public date_start_data As Date
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ins_time_loss.Button10.Enabled = False
        Me.Enabled = False
        ins_time_loss.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Change_Loss2.ListView2.Items(2).Selected = True
        Change_Loss2.ListView2.View = View.Details
        'Chang_Loss.ListView2.Scrollable = Size()

        'List_Emp.ListBox2.Items.Add(Trim(TextBox2.Text))
        Try
            If My.Computer.Network.Ping("192.168.161.101") Then
                Dim LoadSQL = Backoffice_model.get_loss_mst()
                While LoadSQL.Read()
                    Change_Loss2.ListView2.ForeColor = Color.Blue
                    Change_Loss2.ListView2.Items.Add(LoadSQL("id_mst").ToString()).SubItems.AddRange(New String() {LoadSQL("loss_cd").ToString(), LoadSQL("description_th").ToString()})
                    Change_Loss2.ListBox1.Items.Add(LoadSQL("loss_type").ToString())
                End While
                Change_Loss2.Show()
                Me.Hide()
            Else
                load_show.Show()
            End If
        Catch ex As Exception
            load_show.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim line_id As String = MainFrm.line_id.Text
        Try
            If My.Computer.Network.Ping("192.168.161.101") Then
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
                Dim date_cerrunt As Date = DateTime.Now.ToString("yyyy-MM-dd H:m:s")
                Dim time_cerrunt As Date = DateTime.Now.ToString("H:m:s")
                'Dim total_loss As Integer = DateDiff(DateInterval.Minute, date_start_data, date_cerrunt)
                If Label8.Text >= time_cerrunt Then
                    start_loss = date_cerrunt.AddDays(-1)
                    Dim s As String = start_loss.ToString().Substring(0, 9)
                    start_loss = s & Label8.Text
                    'Else
                End If
                If Label9.Text > time_cerrunt Then
                    end_loss = date_cerrunt.AddDays(-1)
                    Dim s As String = end_loss.ToString().Substring(0, 9)
                    end_loss = s & Label9.Text
                End If
                Dim total_loss As Integer = DateDiff(DateInterval.Minute, start_loss, end_loss)
                If total_loss < 0 Then
                    total_loss = Math.Abs(CDbl(Val(total_loss)))
                End If
                Dim loss_type As String = "1"  '0:Normally,1:Manual
                Dim loss_cd_id As String = loss_cd.Text
                Dim op_id As String
                'If sel_combo < 0 Then
                '             op_id = "0"
                '            Else'
                'op_id = ListBox1.Items(sel_combo).ToString()
                'End If
                op_id = 0 'ComboBox1.Text
                Dim pd As String = MainFrm.Label6.Text
                Dim transfer_flg As String = "0"
                Try
                    If My.Computer.Network.Ping("192.168.161.101") Then
                        transfer_flg = "1"
                        Backoffice_model.ins_loss_act(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, start_loss, end_loss, total_loss, loss_type, loss_cd_id, op_id, transfer_flg, "1", Working_Pro.pwi_id)
                        Backoffice_model.ins_loss_act_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, start_loss, end_loss, total_loss, loss_type, loss_cd_id, op_id, transfer_flg, "1", Working_Pro.pwi_id)
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
                        Backoffice_model.ins_loss_act_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, start_loss, end_loss, total_loss, loss_type, loss_cd_id, op_id, transfer_flg, "1", Working_Pro.pwi_id)
                        'Backoffice_model.Insert_prd_close_lot_sqlite(wi_plan, line_cd, item_cd, plan_qty, act_qty, seq_no, shift_prd, staff_no, prd_st_datetime, prd_end_datetime, lot_no, comp_flg2, transfer_flg, del_flg, prd_flg, close_lot_flg, avarage_eff, avarage_act_prd_time)
                        'Backoffice_model.insPrdDetail_sqlite(pd, line_cd, wi_plan, item_cd, item_name, staff_no, seq_no, prd_qty, number_qty, start_time, end_time, use_timee, tr_status)
                        'MsgBox("Ins incompleted1")
                    End If
                Catch ex As Exception
                    'MsgBox("Ins incompleted2")
                    transfer_flg = "0"
                    Backoffice_model.ins_loss_act_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, start_loss, end_loss, total_loss, loss_type, loss_cd_id, op_id, transfer_flg, "1", Working_Pro.pwi_id)
                    'Backoffice_model.Insert_prd_close_lot_sqlite(wi_plan, line_cd, item_cd, plan_qty, act_qty, seq_no, shift_prd, staff_no, prd_st_datetime, prd_end_datetime, lot_no, comp_flg2, transfer_flg, del_flg, prd_flg, close_lot_flg, avarage_eff, avarage_act_prd_time)
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
    Private Sub Loss_reg_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = MainFrm.Label4.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        '  Shell("C:\Program Files (x86)\Default Company Name\Maintenance\Maintenance.exe")
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        Shell("C:\Program Files (x86)\Default Company Name\Maintenance\Maintenance.exe")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
