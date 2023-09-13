Imports System.Web.Script.Serialization

Public Class Change_Loss2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Working_Pro.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If My.Computer.Network.Ping("192.168.161.101") Then
                ins_time_loss.Label2.Text = Working_Pro.Label16.Text
                Loss_reg_pass.Label2.Text = MainFrm.Label4.Text
                Dim sel_cd As Integer = ListView2.SelectedIndices(0)
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
                Loss_reg_pass.date_start_data = date_st
                Try
                    If My.Computer.Network.Ping("192.168.161.101") Then
                        Backoffice_model.line_status_ins(line_id, date_st, date_end, "1", "0", ListView2.Items(sel_cd).SubItems(0).Text, "0", Prd_detail.lb_wi.Text)
                        Backoffice_model.line_status_ins_sqlite(line_id, date_st, date_end, "1", "0", ListView2.Items(sel_cd).SubItems(0).Text, "0", Prd_detail.lb_wi.Text)
                    Else
                        Backoffice_model.line_status_ins_sqlite(line_id, date_st, date_end, "1", "0", ListView2.Items(sel_cd).SubItems(0).Text, "0", Prd_detail.lb_wi.Text)
                    End If
                Catch ex As Exception
                    Backoffice_model.line_status_ins_sqlite(line_id, date_st, date_end, "1", "0", ListView2.Items(sel_cd).SubItems(0).Text, "0", Prd_detail.lb_wi.Text)
                End Try
                Loss_reg_pass.loss_cd.Text = ListView2.Items(sel_cd).SubItems(0).Text
                Loss_reg_pass.Label7.Text = ListView2.Items(sel_cd).SubItems(1).Text
                Loss_reg_pass.TextBox1.Text = ListView2.Items(sel_cd).SubItems(2).Text
                'If ListBox1.Items(sel_cd) = 1 Then
                If My.Computer.Network.Ping("192.168.161.101") Then
                    Dim LoadSQL = Backoffice_model.get_loss_op_mst(MainFrm.Label4.Text)
                    If LoadSQL <> "0" Then
                        Dim numm As Integer = 0
                        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(LoadSQL)
                        For Each item As Object In dict
                            Loss_reg_pass.ComboBox1.Items.Add(item("op_name").ToString())
                        Next
                    Else
                        Loss_reg_pass.ComboBox1.Items.Add("Proc :[NO PROCESS]")
                    End If
                Else
                    load_show.Show()
                    'LoadSQL = Backoffice_model.get_loss_op_mst_sqlite(MainFrm.Label4.Text)
                End If
                '	Dim numm As Integer = 0
                '                 While LoadSQL.Read()

                'Loss_reg_pass.ComboBox1.Items.Insert(numm, "Proc :" & LoadSQL("process_no").ToString() & "     [ " & LoadSQL("sk_name").ToString() & " ]")
                '                Loss_reg_pass.ListBox1.Items.Add(LoadSQL("sk_id"))
                '                    numm = numm + 1
                '                    End While
                Loss_reg_pass.ComboBox1.Visible = True
                Loss_reg_pass.Label10.Visible = True
                Loss_reg_pass.ComboBox1.SelectedIndex = 0
                'End If
                'Loss_reg_pass.Label8.Text = TimeOfDay.ToString("H:mm")
                'Working_Pro.Enabled = True
                Loss_reg_pass.Show()
                'ins_time_loss.Show()
                Me.Close()
                'End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            load_show.Show()
        End Try
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count <= 0 Then
            Button1.Enabled = False
            ListView2.ForeColor = Color.White
        ElseIf ListView2.SelectedItems.Count > 0 Then
            Button1.Enabled = True
            ListView2.ForeColor = Color.White
        End If
    End Sub

    Private Sub Change_Loss2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView2.Items(1).Selected = True
    End Sub
End Class
