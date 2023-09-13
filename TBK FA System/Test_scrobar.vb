Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports NationalInstruments.DAQmx

Public Class Test_scrobar
    Private Sub Test_scrobar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(TimeOfDay.ToString("HH:mm:ss"))
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class