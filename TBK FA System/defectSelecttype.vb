Imports System.Net
Imports System.Web.Script.Serialization

Friend Class defectSelecttype
    Public Shared type
    Shared pFG
    Shared wi
    Public Shared dtType
    Public Shared dt_menu
    Public Shared datlvChildpart As ListViewItem
    Public Shared sPart As String = ""
    Public Shared actTotal As Integer = Working_Pro.LB_COUNTER_SEQ.Text 'Working_Pro.Label6.Text
    Public Shared ncTotal As Integer = Working_Pro.lb_nc_qty.Text
    Public Shared ngTotal As Integer = Working_Pro.lb_ng_qty.Text
    Public Shared mv = New manageVariable()
    Public Shared S_index As Integer = 0
    Public Shared Sub setVariable()
        actTotal = Working_Pro.LB_COUNTER_SEQ.Text
        ncTotal = Working_Pro.lb_nc_qty.Text
        ngTotal = Working_Pro.lb_ng_qty.Text
        Dim pd As New Working_Pro()
        Dim dfHome As New defectHome
        type = dfHome.dtType
        pFG = pd.pFg
        wi = pd.wiNo '"5100287204"
        sPart = ""

    End Sub
    Private Sub defectSelecttype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dfHpme As New defectHome()
        If dfHpme.dtType = "NC" Then
            'lvChildpart.BackColor = Color.Peru
        ElseIf dfHpme.dtType = "NG" Then
            'lvChildpart.BackColor = Color.Tomato
        End If
        lvChildpart.Scrollable = True
        setVariable()
        Dim dfHome As New defectHome
        lbType.Text = dfHome.dtType
        btnPartfg.Text = pFG
        Dim reData = getChildpart(wi)
    End Sub

    Public Function getChildpart(wi)
        Dim md = New modelDefect()
        Dim rsData = md.mGetchildpart(wi)
        If rsData <> "0" Then
            Dim dcResultdata As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsData)
            Dim i As Integer = 1
            For Each item As Object In dcResultdata
                datlvChildpart = New ListViewItem(i)
                datlvChildpart.SubItems.Add(item("ITEM_CD").ToString())
                lvChildpart.Items.Add(datlvChildpart)
                i += 1
            Next
        End If
    End Function
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dfHome As New defectHome
        dfHome.Show()
        Me.Close()
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        'Me.Close()
        'Dim dfHome = New defectHome()
        'dfHome.show()
        tbnUp()
    End Sub

    Public Sub tbnUp()
        If S_index < 0 Then
            S_index = 0
        ElseIf S_index > CDbl(Val((lvChildpart.Items.Count - 1))) Then
            S_index = CDbl(Val((lvChildpart.Items.Count - 1)))
        End If
        Try
            lvChildpart.Items(S_index).Selected = False
            S_index -= 1
            If S_index < 0 Then
                S_index = 0
                ' ElseIf lvChildpart.Items.Count > S_index Then
                '    S_index = CDbl(Val((lvChildpart.Items.Count - 1)))
            End If
            lvChildpart.Items(S_index).Selected = True
            lvChildpart.Items(S_index).EnsureVisible()
            lvChildpart.Select()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub tbnDown()
        If S_index < 0 Then
            S_index = 0
        ElseIf S_index > CDbl(Val((lvChildpart.Items.Count - 1))) Then
            S_index = CDbl(Val((lvChildpart.Items.Count - 1)))
        End If
        Try
            lvChildpart.Items(S_index).Selected = False
            S_index += 1
            If S_index < 0 Then
                S_index = 0
                ' ElseIf lvChildpart.Items.Count > S_index Then
                '    S_index = CDbl(Val((lvChildpart.Items.Count - 1)))
            End If
            lvChildpart.Items(S_index).Selected = True
            lvChildpart.Items(S_index).EnsureVisible()
            lvChildpart.Select()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub lvChildpart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvChildpart.SelectedIndexChanged
        For Each lvItem As ListViewItem In lvChildpart.SelectedItems
            Me.sPart = lvChildpart.Items(lvItem.Index).SubItems(1).Text
        Next
        dt_menu = "1"
        If type = "NG" Then
            dtType = "1"
        ElseIf type = "NC" Then
            dtType = "2"
        End If
        type = "2"
        ' mv.setSelectpartdefect("TEST OK")

    End Sub

    Private Sub btnPartfg_Click(sender As Object, e As EventArgs) Handles btnPartfg.Click
        If type = "NG" Then
            dtType = "1"
        ElseIf type = "NC" Then
            dtType = "2"
        End If
        type = "1"
        dt_menu = "1"
        Dim sDefectcode As New defectSelectcode()
        Me.sPart = btnPartfg.Text
        sDefectcode.Show()
        Me.Hide()
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)
        'create two scroll bars
        Dim hs As HScrollBar
        Dim vs As VScrollBar
        hs = New HScrollBar()
        vs = New VScrollBar()

        'set properties
        hs.Location = New Point(10, 200)
        hs.Size = New Size(175, 15)
        hs.Value = 50
        vs.Location = New Point(200, 30)
        vs.Size = New Size(15, 175)
        hs.Value = 50

        'adding the scroll bars to the form
        Me.Controls.Add(hs)
        Me.Controls.Add(vs)
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspoint.com"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub lbType_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        tbnDown()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim sDefectcode As New defectSelectcode()
        sDefectcode.Show()
        Me.Hide()
    End Sub
End Class