Public Class TestProgressbar
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManageTimeLine()
    End Sub
    Public Sub ManageTimeLine()
        Dim myArray(23) As String
        Dim myArrayMin(28) As String
        Dim arrMin As String = ""
        Dim currentTime As DateTime = DateTime.Now
        Dim sNumber As Integer = 0
        Dim eNumber As Integer = 0
        Dim dNow = currentTime.ToString("HH:mm:ss")
        Dim myArrayColor() As String = {"Blue", "Red", "Green"}
        Dim W As Integer = 2
        If dNow >= "08:00:00" And dNow <= "20:00:00" Then
            myArray = {"8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"}
            ' sNumber = 8
            ' eNumber = 20
        Else
            myArray = {"20", "21", "22", "23", "00", "01", "02", "03", "04", "05", "06", "07", "08"}
            '  sNumber = 0
            '  eNumber = 8
        End If
        For i As Integer = 0 To 12
            ' Dim data As String = ""
            ' If i <= 9 Then
            ' data = "0" & i
            ' Data = i
            ' Else
            ' Data = i
            ' End If
            Console.WriteLine(myArray(i))
            Dim labelTime As New Label()
            labelTime.Location = New Point(54 * (i + 1), 370) ' กำหนดตำแหน่ง
            For j As Integer = 0 To 28
                Dim Panel As New Panel()
                If i = 0 And j = 0 Then
                    W = 18
                Else
                    If j = 28 Then
                        W = W + 3
                    Else
                        W = W + 2
                    End If
                End If
                Panel.Location = New Point(W, 470) ' กำหนดตำแหน่ง
                If (j + 1) Mod 12 = 0 Then
                    Panel.BackColor = Color.FromArgb(183, 34, 34)
                Else
                    Panel.BackColor = Color.FromArgb(113, 255, 36)
                End If
                If j = 28 Then
                    Panel.Width = 3  ' Set the width to 200 pixels
                Else
                    Panel.Width = 2
                End If
                Panel.Height = 50
                ' label.Location = New Point(31.5 * (i + 1), 30) ' กำหนดตำแหน่ง
                Panel.AutoSize = True
                Panel.Text = myArrayMin(j)
                Me.Controls.Add(Panel)
            Next
            Dim labelAct As New Label()
            labelAct.Location = New Point(54 * (i + 1), 460) ' กำหนดตำแหน่ง
            labelAct.Font = New Font("Arial", 10) ' กำหนดตัวอักษรและขนาด
            labelAct.AutoSize = True
            labelAct.Text = myArray(i)
            labelTime.Font = New Font("Arial", 10) ' กำหนดตัวอักษรและขนาด
            labelTime.AutoSize = True
            labelTime.Text = myArray(i)
            ' Me.Controls.Add(labelTime)
            ' Me.Controls.Add(labelAct)
        Next
    End Sub
End Class
