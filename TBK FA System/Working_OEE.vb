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
    Private Sub Working_OEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataProgressBar()
    End Sub

    Private Sub CircularProgressBar2_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub loadDataProgressBar()
        WebBrowserProgressBar.Navigate("http://192.168.161.219/test_ci/table.html")
    End Sub
End Class
