Imports VB = Microsoft.VisualBasic
Imports System
Imports System.Management
Imports System.ComponentModel
Imports System.Threading
Imports System.IO
Imports System.IO.Ports
Imports System.Text
Imports System.Globalization
Imports System.Drawing.Imaging
Imports IDAutomation.Windows.Forms.LinearBarCode
Imports System.Drawing.Printing
Imports System.Configuration
Imports GenCode128
Imports BarcodeLib.Barcode
Imports System.Web.Script.Serialization
Public Class tag_reprint_new
    Public Shared S_index As Integer = 0
    Dim g_index As Integer = 0
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Application.OpenForms().OfType(Of Sel_prd_setup).Any Then
            Sel_prd_setup.Enabled = True
            Sel_prd_setup.Show()
            Me.Close()
        Else
            Show_reprint_wi.Show()
            Me.Close()
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            If My.Computer.Network.Ping("192.168.161.101") Then
                tag_print()
                Dim numOfindex As Integer = ListView1.SelectedIndices(0)
                Dim qr_code As String = ListBox1.Items(numOfindex)
                If Application.OpenForms().OfType(Of Sel_prd_setup).Any Then
                    Sel_prd_setup.Enabled = True
                    Working_Pro.Enabled = True
                    Working_Pro.Show()
                    Me.Close()
                End If
            Else
                load_show.Show()
            End If
        Catch ex As Exception
            load_show.Show()
        End Try
    End Sub
    Public Function tag_print()
        Dim wi As String = ""
        If Application.OpenForms().OfType(Of Sel_prd_setup).Any Then
            wi = Working_Pro.wi_no.Text
        Else
            wi = Show_reprint_wi.hide_wi_select.Text
        End If
        Dim seq_plan = ListView1.Items(g_index).SubItems(2).Text
        Dim seq_box = ListView1.Items(g_index).SubItems(4).Text
        Try
            If My.Computer.Network.Ping("192.168.161.101") Then
                Dim numOfindex As Integer = ListView1.SelectedIndices(0)
                Dim qr_code As String = ListBox1.Items(numOfindex)
                Backoffice_model.update_data_new_qr_detail(qr_code)
            Else
                load_show.Show()
            End If
        Catch ex As Exception
            load_show.Show()
        End Try
        Dim api = New api()
        PrintDocument1.Print()
        Return 0
    End Function
    Public Sub print_batch()

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If IsNothing(Me.ListView1.FocusedItem) Then
        ElseIf ListView1.FocusedItem.Index >= 0 Then
            If ListView1.Items.Count > 0 Then
                Dim index As Integer = ListView1.FocusedItem.Index
                g_index = index
            End If
        Else
            MessageBox.Show("An Error has halted thid process")
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub tag_reprint_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Visible = False
        ListBox2.Visible = False
        Timer1.Start()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay.ToString("H:mm:ss")
        Label4.Text = DateTime.Now.ToString("D")
    End Sub

    Private Sub pb_down_Click(sender As Object, e As EventArgs) Handles pb_down.Click
        BTNDOWN1()
    End Sub

    Private Sub pbUp_Click(sender As Object, e As EventArgs) Handles pbUp.Click
        BTNUP1()
    End Sub
    Public Sub BTNUP1()
        If S_index < 0 Then
            S_index = 0
        ElseIf S_index > CDbl(Val((ListView1.Items.Count - 1))) Then
            S_index = CDbl(Val((ListView1.Items.Count - 1)))
        End If
        Try
            ListView1.Items(S_index).Selected = False
            S_index -= 1
            If S_index < 0 Then
                S_index = 0
                'ElseIf lvDefectact.Items.Count > S_index Then
                'S_index = CDbl(Val((lvDefectact.Items.Count - 1)))
            End If
            ListView1.Items(S_index).Selected = True
            ListView1.Items(S_index).EnsureVisible()
            ListView1.Select()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub BTNDOWN1()
        If S_index < 0 Then
            S_index = 0
        ElseIf S_index > CDbl(Val((ListView1.Items.Count - 1))) Then
            S_index = CDbl(Val((ListView1.Items.Count - 1)))
        End If
        Try
            ListView1.Items(S_index).Selected = False
            S_index += 1
            If S_index < 0 Then
                S_index = 0
                'ElseIf S_index > lvDefectact.Items.Count Then
                '  S_index = CDbl(Val((lvDefectact.Items.Count - 1)))
            End If
            ListView1.Items(S_index).Selected = True
            ListView1.Items(S_index).EnsureVisible()
            ListView1.Select()
        Catch ex As Exception
        End Try
    End Sub
End Class
