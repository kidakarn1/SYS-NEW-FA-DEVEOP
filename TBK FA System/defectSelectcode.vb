Imports System.Net
Imports System.Web.Script.Serialization
Friend Class defectSelectcode
    Shared Type = ""
    Shared Partfg = ""
    Shared datlvDefectcode As ListViewItem
    Shared mv = New manageVariable()
    Public Shared sPart As String = ""
    Public Shared sDefectcode As String = ""
    Public Shared sDefectdetail As String = ""
    Public Shared dSelecttype As New defectSelecttype()
    Public Shared S_index As Integer = 0
    Public Sub defectSelectcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dfHome As New defectHome
        If dfHome.dtType = "NC" Then
            lvDefectcode.BackColor = Color.Peru
        ElseIf dfHome.dtType = "NG" Then
            lvDefectcode.BackColor = Color.Tomato
        End If
        lbPartfg.Text = dfHome.dtType
        sPart = dSelecttype.sPart
        lbPartfg.Text = sPart
        lbType.Text = dfHome.dtType
        getDefectcode()
    End Sub
    Public Sub getDefectcode()
        Dim md = New modelDefect()
        Dim rsData = md.mGetdefectcode(MainFrm.Label4.Text)
        If rsData <> "0" Then
            Dim dcResultdata As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsData)
            Dim i As Integer = 1
            For Each item As Object In dcResultdata
                datlvDefectcode = New ListViewItem(item("defect_cd").ToString())
                datlvDefectcode.SubItems.Add(item("defect_name").ToString())
                lvDefectcode.Items.Add(datlvDefectcode)
                i += 1
            Next
            lvDefectcode.Items(0).Selected = True
        End If
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        tbnUp()
    End Sub
    Public Sub tbnUp()
        If S_index < 0 Then
            S_index = 0
        ElseIf S_index > CDbl(Val((lvDefectcode.Items.Count - 1))) Then
            S_index = CDbl(Val((lvDefectcode.Items.Count - 1)))
        End If
        Try
            lvDefectcode.Items(S_index).Selected = False
            S_index -= 1
            If S_index < 0 Then
                S_index = 0
                'ElseIf lvDefectcode.Items.Count > S_index Then
                '   S_index = CDbl(Val((lvDefectcode.Items.Count - 1)))
            End If
            lvDefectcode.Items(S_index).Selected = True
            lvDefectcode.Items(S_index).EnsureVisible()
            lvDefectcode.Select()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub tbnDown()
        If S_index < 0 Then
            S_index = 0
        ElseIf S_index > CDbl(Val((lvDefectcode.Items.Count - 1))) Then
            S_index = CDbl(Val((lvDefectcode.Items.Count - 1)))
        End If
        Try
            lvDefectcode.Items(S_index).Selected = False
            S_index += 1
            If S_index < 0 Then
                S_index = 0
                'ElseIf lvDefectcode.Items.Count > S_index Then
                '   S_index = CDbl(Val((lvDefectcode.Items.Count - 1)))
            End If
            lvDefectcode.Items(S_index).Selected = True
            lvDefectcode.Items(S_index).EnsureVisible()
            lvDefectcode.Select()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim objdSelecttype As New defectSelecttype()
        objdSelecttype.Show()
        Me.Close()
    End Sub

    Private Sub lvDefectcode_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each lvItem As ListViewItem In lvDefectcode.SelectedItems
            Me.sDefectcode = lvDefectcode.Items(lvItem.Index).SubItems(0).Text
            Me.sDefectdetail = lvDefectcode.Items(lvItem.Index).SubItems(1).Text
        Next
        Dim dfRegister = New defectRegister
        dfRegister.Show()
        Me.Hide()
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        tbnDown()
    End Sub
End Class