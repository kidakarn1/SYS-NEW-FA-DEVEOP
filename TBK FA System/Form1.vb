Imports System.Drawing.Printing

Public Class Form1
    Private WithEvents printDocument1 As New PrintDocument()
    Private WithEvents printDocument2 As New PrintDocument()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' กำหนดค่า PrinterSettings สำหรับเครื่องปริ้นที่หนึ่ง (เปลี่ยน "Printer1" เป็นชื่อจริงของเครื่องปริ้นที่ 1)
        printDocument1.PrinterSettings.PrinterName = "Citizen CL-S400DT TAG FA"
        ' กำหนดค่า PrinterSettings สำหรับเครื่องปริ้นที่สอง (เปลี่ยน "Printer2" เป็นชื่อจริงของเครื่องปริ้นที่ 2)
        printDocument2.PrinterSettings.PrinterName = "Citizen Label"
    End Sub
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        ' แทนที่ด้วยคำสั่งหรือเนื้อหาการพิมพ์จริง ๆ ของคุณ
        Dim val As String = RichTextBox1.Text
        e.Graphics.DrawString(val, Label1.Font, Brushes.Black, widthText.Text, HeightText.Text)
    End Sub
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' เริ่มกระบวนการการพิมพ์สำหรับเครื่องปริ้นที่หนึ่ง
        printDocument1.Print()
        ' เริ่มกระบวนการการพิมพ์สำหรับเครื่องปริ้นที่สอง
        printDocument2.Print()
    End Sub
    Private Sub PrintDocument31_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDocument1.PrintPage
        Dim val As String = RichTextBox1.Text
        e.Graphics.DrawString(val, Label1.Font, Brushes.Black, widthText.Text, HeightText.Text)
    End Sub
    Private Sub PrintDocument32_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDocument2.PrintPage
        Dim val As String = RichTextBox1.Text
        e.Graphics.DrawString(val, Label1.Font, Brushes.Black, widthText.Text, HeightText.Text)
    End Sub
End Class
