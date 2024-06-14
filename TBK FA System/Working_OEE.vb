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
'Imports NationalInstruments.DAQmx
Imports System.Net
Imports System.Web.Script.Serialization
Public Class Working_OEE
    Public shift As String = ""
    Public TarGetOverall As String = "0"
    Public check_network_frist As String = ""
    Private Sub Working_OEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setData()
        loadDataProgressBar()
    End Sub
    Public Sub setData()
        Dim OEE = New OEE
        picStart.Visible = True
        shift = Prd_detail.Label12.Text.Substring(0, 1)
        lbShiftQty.Text = OEE.OEE_GET_TARGET(shift, Prd_detail.lb_wi.Text, "0")
        TarGetOverall = lbShiftQty.Text
    End Sub
    Private Sub CircularProgressBar2_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub loadDataProgressBar()
        Me.WebView21.Source = New Uri("http://192.168.161.219/test_ci/table.html")

    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        StartOEE()
    End Sub
    Public Sub StartOEE()
        picStart.Visible = False
        BtnStart.Visible = False
        btnStop.Visible = True
    End Sub
    Public Sub StopOEE()
        picStart.Visible = True
        btnStop.Visible = False
        BtnStart.Visible = True
    End Sub
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        StopOEE()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Prd_detail.Enabled = True
        Prd_detail.Show()
        Me.Close()
    End Sub
End Class
