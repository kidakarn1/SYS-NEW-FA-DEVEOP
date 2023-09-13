Imports System.Web.Script.Serialization
Public Class defectDetailng
    Shared datlvDefectdetails As ListViewItem
    Public Shared sDefectcode As String = ""
    Public Shared sDefectdetail As String = ""
    Public Shared sNg As String = ""
    Dim pd As New Working_Pro()
    Public Shared dtWino As String = Working_Pro.wi_no.Text
    Public Shared dtLineno As String = Working_Pro.Label24.Text
    Public Shared dtItemcd As String = ""
    Public Shared dtItemtype As String = defectSelecttype.type
    Public Shared dtLotNo As String = Working_Pro.Label18.Text
    Public Shared dtSeqno As String = Working_Pro.Label22.Text
    Public Shared dtType As String = "1"
    Public Shared dtCode As String = ""
    Public Shared dtQty As String = ""
    Public Shared dtMenu As String = "1"
    Public Shared dtActualdate As String = DateTime.Now.ToString("yyyy-MM-dd H:m:s")
    Dim cBuottndown As Integer = 0
    Dim cListview As Integer = 0
    Public Shared S_index As Integer = 0
    Public Shared types As String = ""
    Public Shared dtnameItemtype As String = ""
    Private Sub defectDetailng_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rs = getDefectdetailg(dtWino, dtSeqno, dtLotNo, dtType)
        lbType.Text = defectHome.dtType
    End Sub
    Public Function getDefectdetailg(wi As String, seq As String, lot As String, type As String)
        Dim md As New modelDefect()
        seq = Working_Pro.Label22.Text
        lot = Working_Pro.Label18.Text
        Dim rs = md.mGetdefectdetailnc(wi, seq, lot, type)
        cListview = 0
        If rs <> "0" Then
            Dim dcResultdata As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
            Dim i As Integer = 1
            For Each item As Object In dcResultdata
                If item("total_nc").ToString() <> "0" Then
                    cListview += 1
                    Dim dt_item_type As String = ""
                    If item("dt_item_type").ToString() = "1" Then
                        dt_item_type = "FG"
                    Else
                        dt_item_type = "CP"
                    End If
                    datlvDefectdetails = New ListViewItem(i)
                    datlvDefectdetails.SubItems.Add(item("dt_item_cd").ToString())
                    datlvDefectdetails.SubItems.Add(dt_item_type)
                    datlvDefectdetails.SubItems.Add(item("dt_code").ToString())
                    datlvDefectdetails.SubItems.Add(item("defect_name").ToString())
                    datlvDefectdetails.SubItems.Add(item("total_nc").ToString())
                    lvDefectdetails.Items.Add(datlvDefectdetails)
                    i += 1
                End If
            Next
            Try
                lvDefectdetails.Items(cBuottndown).Selected = True
            Catch ex As Exception

            End Try
        Else
            lvDefectdetails.Clear()
        End If
        Return rs
    End Function

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            If lvDefectdetails.SelectedItems.Count > 0 Then
                For Each lvItem As ListViewItem In lvDefectdetails.SelectedItems
                    Me.dtnameItemtype = lvDefectdetails.Items(lvItem.Index).SubItems(2).Text
                    Me.types = lvDefectdetails.Items(lvItem.Index).SubItems(2).Text
                    Me.dtItemcd = lvDefectdetails.Items(lvItem.Index).SubItems(1).Text
                    Me.dtCode = lvDefectdetails.Items(lvItem.Index).SubItems(3).Text
                    Me.sDefectcode = lvDefectdetails.Items(lvItem.Index).SubItems(0).Text
                    Me.sDefectdetail = lvDefectdetails.Items(lvItem.Index).SubItems(1).Text
                    Me.sNg = lvDefectdetails.Items(lvItem.Index).SubItems(5).Text
                    Me.dtQty = lvDefectdetails.Items(lvItem.Index).SubItems(5).Text
                Next
                Dim dfNumpadafjust = New defectNumpadadjust
                dfNumpadafjust.Show()
                Me.Close()
            Else
                MsgBox("Please Select Data")
            End If
        Catch ex As Exception
            MsgBox("Please Select Data")
        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
		Dim dfHome As New defectHome
		dfHome.Show()
		Me.Close()
	End Sub
	Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        BTNDOWN1()
    End Sub

	Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        BTNUP1()
    End Sub

    Private Sub lvDefectdetails_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub BTNUP1()
        If S_index < 0 Then
            S_index = 0
        ElseIf S_index > CDbl(Val((lvDefectdetails.Items.Count - 1))) Then
            S_index = CDbl(Val((lvDefectdetails.Items.Count - 1)))
        End If
        Try
            lvDefectdetails.Items(S_index).Selected = False
            S_index -= 1
            If S_index < 0 Then
                S_index = 0
                'ElseIf lvDefectdetails.Items.Count > S_index Then
                '   S_index = CDbl(Val((lvDefectdetails.Items.Count - 1)))
            End If
            lvDefectdetails.Items(S_index).Selected = True
            lvDefectdetails.Items(S_index).EnsureVisible()
            lvDefectdetails.Select()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub BTNDOWN1()
        If S_index < 0 Then
            S_index = 0
        ElseIf S_index > CDbl(Val((lvDefectdetails.Items.Count - 1))) Then
            S_index = CDbl(Val((lvDefectdetails.Items.Count - 1)))
        End If
        Try
            lvDefectdetails.Items(S_index).Selected = False
            S_index += 1
            If S_index < 0 Then
                S_index = 0
                'ElseIf lvDefectdetails.Items.Count > S_index Then
                '   S_index = CDbl(Val((lvDefectdetails.Items.Count - 1)))
            End If
            lvDefectdetails.Items(S_index).Selected = True
            lvDefectdetails.Items(S_index).EnsureVisible()
            lvDefectdetails.Select()
        Catch ex As Exception

        End Try

    End Sub
End Class
