
Public Class ins_qty
    Public count_time As Integer = 0
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim txt_lenght As Integer = TextBox1.Text.Length
        Try
            TextBox1.Text = TextBox1.Text.Substring(0, txt_lenght - 1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Working_Pro.Enabled = True
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text_now As String = TextBox1.Text
        Dim sum_str As Integer = text_now & "1"
        Dim rem_qty As Integer = Working_Pro.Label10.Text.Substring(1)
        If sum_str > rem_qty Then
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Insert mitaked! Please try it again."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            TextBox1.Text = ""
            ' MsgBox("Insert mitaked! Please try it again.")
        Else
            TextBox1.Text = text_now & "1"
            Button10.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim text_now As String = TextBox1.Text
        Dim sum_str As Integer = text_now & "2"
        Dim rem_qty As Integer = Working_Pro.Label10.Text.Substring(1)

        If sum_str > rem_qty Then
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Insert mitaked! Please try it again."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            TextBox1.Text = ""
        Else
            TextBox1.Text = text_now & "2"
            Button10.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim text_now As String = TextBox1.Text
        Dim sum_str As Integer = text_now & "3"
        Dim rem_qty As Integer = Working_Pro.Label10.Text.Substring(1)

        If sum_str > rem_qty Then
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Insert mitaked! Please try it again."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            TextBox1.Text = ""
        Else
            TextBox1.Text = text_now & "3"
            Button10.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim text_now As String = TextBox1.Text
        Dim sum_str As Integer = text_now & "4"
        Dim rem_qty As Integer = Working_Pro.Label10.Text.Substring(1)

        If sum_str > rem_qty Then
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Insert mitaked! Please try it again."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            TextBox1.Text = ""
        Else
            TextBox1.Text = text_now & "4"
            Button10.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim text_now As String = TextBox1.Text
        Dim sum_str As Integer = text_now & "5"
        Dim rem_qty As Integer = Working_Pro.Label10.Text.Substring(1)

        If sum_str > rem_qty Then
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Insert mitaked! Please try it again."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            TextBox1.Text = ""
        Else
            TextBox1.Text = text_now & "5"
            Button10.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim text_now As String = TextBox1.Text
        Dim sum_str As Integer = text_now & "6"
        Dim rem_qty As Integer = Working_Pro.Label10.Text.Substring(1)

        If sum_str > rem_qty Then
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Insert mitaked! Please try it again."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            TextBox1.Text = ""
        Else
            TextBox1.Text = text_now & "6"
            Button10.Enabled = True
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim text_now As String = TextBox1.Text
        Dim sum_str As Integer = text_now & "7"
        Dim rem_qty As Integer = Working_Pro.Label10.Text.Substring(1)

        If sum_str > rem_qty Then
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Insert mitaked! Please try it again."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            TextBox1.Text = ""
        Else
            TextBox1.Text = text_now & "7"
            Button10.Enabled = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim text_now As String = TextBox1.Text
        Dim sum_str As Integer = text_now & "8"
        Dim rem_qty As Integer = Working_Pro.Label10.Text.Substring(1)

        If sum_str > rem_qty Then
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Insert mitaked! Please try it again."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            TextBox1.Text = ""
        Else
            TextBox1.Text = text_now & "8"
            Button10.Enabled = True
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim text_now As String = TextBox1.Text
        Dim sum_str As Integer = text_now & "9"
        Dim rem_qty As Integer = Working_Pro.Label10.Text.Substring(1)

        If sum_str > rem_qty Then
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Insert mitaked! Please try it again."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            TextBox1.Text = ""
        Else
            TextBox1.Text = text_now & "9"
            Button10.Enabled = True
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim text_now As String = TextBox1.Text
        Dim sum_str As Integer = text_now & "0"
        Dim rem_qty As Integer = Working_Pro.Label10.Text.Substring(1)

        If sum_str > rem_qty Then
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Insert mitaked! Please try it again."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            TextBox1.Text = ""
        Else
            TextBox1.Text = text_now & "0"
            Button10.Enabled = True
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = ""
        TextBox1.Select()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim ins_qtyy As Integer = TextBox1.Text
        Dim max_val As String = Working_Pro.Label10.Text
        max_val = max_val.Substring(1, max_val.Length - 1)

        Dim max_val_int As Integer = Convert.ToInt32(max_val)
        'MsgBox(max_val)

        If ins_qtyy > 0 And ins_qtyy <= max_val_int Then
            Working_Pro.lb_ins_qty.Text = TextBox1.Text

            Working_Pro.ins_qty_fn()
            Working_Pro.Enabled = True
            Me.Close()
        Else
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Insert mitaked! Please try it again."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            Working_Pro.Enabled = False
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        select_int_qty.Show()
        'Working_Pro.Enabled = True
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pb_ok.Click
        If Trim(TextBox1.Text) = "" Then
            'MsgBox("Please check QTY.")
            Button10.Enabled = False
            Button11.Enabled = False
            Dim listdetail = "Please check QTY."
            PictureBox10.BringToFront()
            PictureBox10.Show()
            PictureBox3.BringToFront()
            PictureBox3.Show()
            Panel2.BringToFront()
            Panel2.Show()
            Label2.Text = listdetail
            Label2.BringToFront()
            Label2.Show()
            TextBox1.Text = ""
        Else
            If Trim(TextBox1.Text) <= 0 Then
                'MsgBox("Please check QTY.")
                Button10.Enabled = False
                Button11.Enabled = False
                Dim listdetail = "Please check QTY."
                PictureBox10.BringToFront()
                PictureBox10.Show()
                PictureBox3.BringToFront()
                PictureBox3.Show()
                Panel2.BringToFront()
                Panel2.Show()
                Label2.Text = listdetail
                Label2.BringToFront()
                Label2.Show()
                TextBox1.Text = ""
            Else
                If TextBox1.Text = "" Then
                    'MsgBox("Please check QTY.")
                    Button10.Enabled = False
                    Button11.Enabled = False
                    Dim listdetail = "Please check QTY."
                    PictureBox10.BringToFront()
                    PictureBox10.Show()
                    PictureBox3.BringToFront()
                    PictureBox3.Show()
                    Panel2.BringToFront()
                    Panel2.Show()
                    Label2.Text = listdetail
                    Label2.BringToFront()
                    Label2.Show()
                    TextBox1.Text = ""
                Else
                    ' Wait_data.Label1.Text = "กรุณารอสักครู่ ระบบกำลังบันทึกข้อมูล"
                    ' Wait_data.Label2.Text = "PLEASE WAIT SYSTEM SAVING DATA."
                    Wait_data.Show()
                    Timer1.Enabled = True
                End If
            End If
        End If
    End Sub
    Public Sub insert_qty()
        If Wait_data.check_load_wit_data = "1" Then
            Dim ins_qtyy As Integer = TextBox1.Text
            Dim max_val As String = Working_Pro.Label10.Text
            max_val = max_val.Substring(1, max_val.Length - 1)
            Working_Pro.LB_COUNTER_SHIP.Text = CDbl(Val(Working_Pro.LB_COUNTER_SHIP.Text)) + CDbl(Val(TextBox1.Text))
            Working_Pro.LB_COUNTER_SEQ.Text = CDbl(Val(Working_Pro.LB_COUNTER_SEQ.Text)) + CDbl(Val(TextBox1.Text))
            Dim max_val_int As Integer = Convert.ToInt32(max_val)
            Backoffice_model.qty_int = ins_qtyy
            If ins_qtyy > 0 And ins_qtyy <= max_val_int Then
                Working_Pro.lb_ins_qty.Text = TextBox1.Text
                Working_Pro.ins_qty_fn_manual()
                Working_Pro.Enabled = True
                select_int_qty.Close()
                Wait_data.Close()
                Me.Close()
            Else
                Button10.Enabled = False
                Button11.Enabled = False
                Dim listdetail = "Insert mitaked! Please try it again."
                PictureBox10.BringToFront()
                PictureBox10.Show()
                PictureBox3.BringToFront()
                PictureBox3.Show()
                Panel2.BringToFront()
                Panel2.Show()
                Label2.Text = listdetail
                Label2.BringToFront()
                Label2.Show()
                TextBox1.Text = ""
                Working_Pro.Enabled = False
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count_time += 1
        If count_time = 20 Then
            Timer1.Enabled = False
            insert_qty()
            count_time = 0
        End If
    End Sub

    Private Sub ins_qty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        show_remain_qty.Text = CDbl(Val(Working_Pro.Label8.Text)) - CDbl(Val(Working_Pro.Label6.Text))
        lbpartNo.Text = Working_Pro.Label3.Text
        Backoffice_model.start_check_date_paralell_line = ""
        Backoffice_model.end_check_date_paralell_line = ""
        TextBox1.Enabled = False
        ' If Backoffice_model.S_chk_spec_line = 0 Then
        ' SPECIAL_MENU.Visible = False
        ' Else
        ' SPECIAL_MENU.Visible = True
        ' End If
    End Sub
    Private Sub SPECIAL_MENU_Click(sender As Object, e As EventArgs) Handles SPECIAL_MENU.Click
        ins_qty_special_time.Show()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Button10.Enabled = True
        Button11.Enabled = True
        PictureBox10.Visible = False
        PictureBox3.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub
End Class
