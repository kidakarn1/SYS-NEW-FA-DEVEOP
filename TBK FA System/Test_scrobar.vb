Imports System.Drawing.Printing

Public Class Test_scrobar
    Private WithEvents printDocument3 As New PrintDocument()
    Private WithEvents printDocument4 As New PrintDocument()
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        ' แทนที่ด้วยคำสั่งหรือเนื้อหาการพิมพ์จริง ๆ ของคุณ
        Dim val As String = RichTextBox2.Text
        e.Graphics.DrawString(val, New Font("Arial", 12), Brushes.Black, 100, 100)
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' เริ่มกระบวนการการพิมพ์สำหรับเครื่องปริ้นที่หนึ่ง
        PrintDocument1.Print()
        ' เริ่มกระบวนการการพิมพ์สำหรับเครื่องปริ้นที่สอง
        PrintDocument2.Print()
    End Sub

    Private Sub Test_scrobar_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the ComboBox with available COM ports
        ' ComboBox2.Items.Add("USB")
        ' ComboBox2.Items.Add("USB001")
        ' ComboBox2.Items.Add("USB002")
        ' ComboBox2.Items.Add("USB003")
        ' ComboBox2.Items.Add("USB004")
        ' For Each portName As String In SerialPort.GetPortNames()
        ' ComboBox1.Items.Add(portName)
        ' MsgBox(portName)
        ' Next
        PrintDocument2.PrinterSettings.PrinterName = "Citizen CL-S400DT TAG FA"
        PrintDocument5.PrinterSettings.PrinterName = "Citizen Label"
    End Sub
End Class
