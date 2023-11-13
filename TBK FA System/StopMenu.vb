Public Class StopMenu
    Dim contDelay As Integer = 0
    Dim flg_check As Integer = 0
    Public date_start_data = DateTime.Now.ToString("yyyy/MM/dd H:m:s")
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If PanelShowLoss.Visible Then
            UpdateAutoLoss()
            Dim BreakTime = Backoffice_model.GetTimeAutoBreakTime(MainFrm.Label4.Text) ' for set data 
            Backoffice_model.ILogLossBreakTime(MainFrm.Label4.Text, Working_Pro.wi_no.Text, Working_Pro.Label22.Text)
            Working_Pro.lbNextTime.Text = BreakTime
            Working_Pro.Enabled = True
            TimerLossBT.Start()
            Working_Pro.Start_Production()
            Me.Close()
        Else
            Dim BreakTime = Backoffice_model.GetTimeAutoBreakTime(MainFrm.Label4.Text) ' for set data 
            Backoffice_model.ILogLossBreakTime(MainFrm.Label4.Text, Working_Pro.wi_no.Text, Working_Pro.Label22.Text)
            Working_Pro.lbNextTime.Text = BreakTime
            Working_Pro.Enabled = True
            TimerLossBT.Start()
            Working_Pro.Start_Production()
            Me.Close()
        End If
    End Sub
    Public Sub UpdateAutoLoss()
        Dim pd As String = MainFrm.Label6.Text
        Dim sel_combo As String = 0 'ComboBox1.SelectedIndex
        Dim wi_plan As String = Working_Pro.wi_no.Text
        Dim line_cd As String = MainFrm.Label4.Text
        Dim item_cd As String = Working_Pro.Label3.Text
        Dim seq_no As Integer = Working_Pro.Label22.Text
        Dim shift_prd As String = Working_Pro.Label14.Text
        Dim start_loss As Date = Date.Parse(TimeOfDay.ToString("H:mm:ss"))
        Dim end_loss As Date = Date.Parse(TimeOfDay.ToString("H:mm:ss"))
        Dim date1 As Date = Date.Parse(TimeOfDay.ToString("H:mm:ss"))
        Dim date2 As Date = Date.Parse(TimeOfDay.ToString("H:mm:ss"))
        Dim total_loss As Integer = DateDiff(DateInterval.Minute, date1, date2)
        Dim loss_type As String = "0"  '0:Normally,1:Manual
        Dim op_id As String = "0"
        Try
            If My.Computer.Network.Ping("192.168.161.101") Then
                transfer_flg = "1"
                Backoffice_model.Update_flg_loss(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, test_time_loss_time.Text, loss_type, loss_cd_id, op_id, transfer_flg, "1")
                Backoffice_model.Update_flg_loss_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, test_time_loss_time.Text, loss_type, loss_cd_id, op_id, transfer_flg, "1")
                Backoffice_model.alert_loss(wi_plan, "1", pd, loss_cd_id)
            Else
                transfer_flg = "0"
                Backoffice_model.Update_flg_loss_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, test_time_loss_time.Text, loss_type, loss_cd_id, op_id, transfer_flg, "1")                'Backoffice_model.Insert_prd_close_lot_sqlite(wi_plan, line_cd, item_cd, plan_qty, act_qty, seq_no, shift_prd, staff_no, prd_st_datetime, prd_end_datetime, lot_no, comp_flg2, transfer_flg, del_flg, prd_flg, close_lot_flg, avarage_eff, avarage_act_prd_time)
            End If
        Catch ex As Exception
            transfer_flg = "0"
            Backoffice_model.Update_flg_loss_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, date_start_data, end_loss, test_time_loss_time.Text, loss_type, loss_cd_id, op_id, transfer_flg, "1")            'Backoffice_model.Insert_prd_close_lot_sqlite(wi_plan, line_cd, item_cd, plan_qty, act_qty, seq_no, shift_prd, staff_no, prd_st_datetime, prd_end_datetime, lot_no, comp_flg2, transfer_flg, del_flg, prd_flg, close_lot_flg, avarage_eff, avarage_act_prd_time)
        End Try
    End Sub
    Private Sub btnBreakTime_Click(sender As Object, e As EventArgs) Handles btnBreakTime.Click
        If Backoffice_model.CountDelay <> "" Then

            Console.WriteLine(contDelay)
                'MsgBox("ครบ 5 นาที")
                btnContinue.BringToFront()
                btnContinue.Visible = True
                'btnContinue.BackColor = Color.FromArgb(63, 63, 63)
                'btnContinue.Size = New Size(312, 555)
                insLoss()
                lock.Visible = True
                btnBreakTime.Visible = False
                lbLossCode.Text = Backoffice_model.LossCodeAuto
                lbStartCount.Text = Backoffice_model.TimeStartBreakTime
                lbEndCount.Text = TimeOfDay.ToString("H:mm:ss")
                btnBreakTime.Visible = False
                PanelShowLoss.Visible = True
            lbEndCount.Text = TimeOfDay.ToString("H:mm:ss")
            Dim date_end_data As String = DateTime.Now.ToString("yyyy/MM/dd H:m:s")
            Dim date_end As Date = date_end_data
            Dim total_loss As Integer = DateDiff(DateInterval.Minute, date_start_data, date_end)
            test_time_loss_time.Text = total_loss
            If total_loss < 0 Then
                Minutes_total = Math.Abs(CDbl(Val(test_time_loss_time.Text)))
                test_time_loss_time.Text = Minutes_total
            End If
        End If
        lbEndCount.Text = TimeOfDay.ToString("H:mm:ss")
    End Sub
    Private Sub TimerLossBT_Tick(sender As Object, e As EventArgs) Handles TimerLossBT.Tick
        Try
            contDelay += 1
            If Application.OpenForms().OfType(Of Loss_reg).Any Or Application.OpenForms().OfType(Of Loss_reg_pass).Any Then
            Else
                If Backoffice_model.CountDelay <> "" Then
                    If btnBreakTime.Visible = True Then
                        Console.WriteLine(contDelay)
                        If CDbl(Val(contDelay)) = CDbl(Val((Backoffice_model.CountDelay))) Then
                            'MsgBox("ครบ 5 นาที")
                            btnContinue.BringToFront()
                            btnContinue.Visible = True
                            'btnContinue.BackColor = Color.FromArgb(63, 63, 63)
                            'btnContinue.Size = New Size(312, 555)
                            insLoss()
                            lock.Visible = True
                            btnBreakTime.Visible = False
                            lbLossCode.Text = Backoffice_model.LossCodeAuto
                            lbStartCount.Text = Backoffice_model.TimeStartBreakTime
                            lbEndCount.Text = TimeOfDay.ToString("H:mm:ss")
                            btnBreakTime.Visible = False
                            PanelShowLoss.Visible = True
                        End If
                    End If
                    lbEndCount.Text = TimeOfDay.ToString("H:mm:ss")
                    Dim date_end_data As String = DateTime.Now.ToString("yyyy/MM/dd H:m:s")
                    Dim date_end As Date = date_end_data
                    Dim total_loss As Integer = DateDiff(DateInterval.Minute, date_start_data, date_end)
                    test_time_loss_time.Text = total_loss
                    If total_loss < 0 Then
                        Minutes_total = Math.Abs(CDbl(Val(test_time_loss_time.Text)))
                        test_time_loss_time.Text = Minutes_total
                    End If
                End If
                lbEndCount.Text = TimeOfDay.ToString("H:mm:ss")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub insLoss()
        Dim pd As String = MainFrm.Label6.Text
        Dim sel_combo As String = 0 'ComboBox1.SelectedIndex
        Dim wi_plan As String = Working_Pro.wi_no.Text
        Dim line_cd As String = MainFrm.Label4.Text
        Dim item_cd As String = Working_Pro.Label3.Text
        Dim seq_no As Integer = Working_Pro.Label22.Text
        Dim shift_prd As String = Working_Pro.Label14.Text
        Dim start_loss As Date = date_start_data 'Date.Parse(TimeOfDay.ToString("H:mm:ss"))
        Dim end_loss As Date = Date.Parse(TimeOfDay.ToString("H:mm:ss"))
        Dim date1 As Date = Date.Parse(TimeOfDay.ToString("H:mm:ss"))
        Dim date2 As Date = Date.Parse(TimeOfDay.ToString("H:mm:ss"))
        Dim total_loss As Integer = DateDiff(DateInterval.Minute, date1, date2)
        Dim loss_type As String = "0"  '0:Normally,1:Manual
        Dim op_id As String = "0"
        Try
            If My.Computer.Network.Ping("192.168.161.101") Then
                transfer_flg = "1"
                Backoffice_model.ins_loss_act(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, start_loss, end_loss, total_loss, loss_type, Backoffice_model.IDLossCodeAuto, op_id, transfer_flg, "0", Working_Pro.pwi_id)
                Backoffice_model.ins_loss_act_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, start_loss, end_loss, total_loss, loss_type, Backoffice_model.IDLossCodeAuto, op_id, transfer_flg, "0", Working_Pro.pwi_id)
            Else
                transfer_flg = "0"
                Backoffice_model.ins_loss_act_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, start_loss, end_loss, total_loss, loss_type, Backoffice_model.IDLossCodeAuto, op_id, transfer_flg, "0", Working_Pro.pwi_id)
            End If
        Catch ex As Exception
            transfer_flg = "0"
            Backoffice_model.ins_loss_act_sqlite(pd, line_cd, wi_plan, item_cd, seq_no, shift_prd, start_loss, end_loss, total_loss, loss_type, Backoffice_model.IDLossCodeAuto, op_id, transfer_flg, "0", Working_Pro.pwi_id)
        End Try
    End Sub
    Private Sub StopMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerLossBT.Start()
        TimerLossBT.Enabled = True
        lbLineCode.Text = MainFrm.Label4.Text
    End Sub
End Class