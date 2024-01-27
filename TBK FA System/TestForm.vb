Public Class TestForm
    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim widthP = 90
        Dim heightP = 120
        Dim widthW = 330
        Dim heightW = 120
        For i As Integer = 1 To 5
            Dim newLabelP As New Label()
            Dim newLabelW As New Label()
            newLabelP.Text = "1234567890"
            newLabelP.Location = New Point(widthP, heightP) ' Set the position of the label
            newLabelP.Font = New Font("Catamaran", 19) ' Change "Arial" to the desired font and 12 to the desired font size
            newLabelP.AutoSize = True ' Adjust the size of the label based on its content
            newLabelP.BackColor = Color.Transparent ' Change LightBlue to the desired color
            newLabelP.ForeColor = Color.White
            heightP += 50
            Me.Controls.Add(newLabelP)
            newLabelW.Text = "1234567890"
            newLabelW.Location = New Point(widthW, heightW) ' Set the position of the label
            newLabelW.Font = New Font("Catamaran", 19) ' Change "Arial" to the desired font and 12 to the desired font size
            newLabelW.AutoSize = True ' Adjust the size of the label based on its content
            newLabelW.BackColor = Color.Transparent ' Change LightBlue to the desired color
            newLabelW.ForeColor = Color.White
            heightW += 50
            Me.Controls.Add(newLabelW)
        Next i
        ' Add the label to the form
    End Sub
End Class