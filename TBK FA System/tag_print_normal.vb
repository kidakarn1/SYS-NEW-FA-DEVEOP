Public Class tag_print_normal
    Dim 
    Public Shared Sub set_tag_print_normal(wi As String, lot As String, seq As String, shift As String)
        Dim md = New modelDefect
        Dim getData = md.mGetTagprintDetail(wi, lot, seq, shift)

    End Sub
    Private Sub tag_print_normal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class