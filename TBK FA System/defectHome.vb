Public Class defectHome
    Public Shared dtType As String = "NO DATA"
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Working_Pro.Enabled = True
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegisternc.Click
        dtType = "NC"
        Dim dfSelecttype = New defectSelecttype()
        dfSelecttype.show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegisterng.Click
        dtType = "NG"
        Dim dfSelecttype1 = New defectSelecttype()
        dfSelecttype1.show()
        Me.Close()
    End Sub
    Private Sub btnAdjustnc_Click(sender As Object, e As EventArgs) Handles btnAdjustnc.Click
        dtType = "NC"
        Dim dfDetailnc = New defectDetailnc()
        dfDetailnc.show()
        Me.Close()
    End Sub
    Private Sub btnAdjustng_Click(sender As Object, e As EventArgs) Handles btnAdjustng.Click
        dtType = "NG"
        Dim dfDetailng = New defectDetailng()
        dfDetailng.show()
        Me.Close()
    End Sub
End Class
