Imports System.Web.Script.Serialization
Public Class ShowSpcDetailDefect
    Shared aDefectcode As List(Of String) = New List(Of String)
    Shared aDefectQty As List(Of String) = New List(Of String)
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Public Function getDefectdetailnc()
        Try
            If My.Computer.Network.Ping("192.168.161.101") Then
                lvCp.Clear()
                Dim md As New modelDefect()
                Dim arrData0 As DataPlan = MainFrm.ArrayDataPlan(0)
                Dim arrData1 As DataPlan = MainFrm.ArrayDataPlan(1)
                Dim arrData2 As DataPlan = MainFrm.ArrayDataPlan(2)
                Dim arrData3 As DataPlan = MainFrm.ArrayDataPlan(3)
                Dim arrData4 As DataPlan = MainFrm.ArrayDataPlan(4)
                ' For Each itemPlanData As DataPlan In MainFrm.ArrayDataPlan
                ' Dim special_wi As String = itemPlanData.wi
                ' Next
                Dim GenSEQ As Integer = Working_Pro.Label22.Text - 5
                Dim Iseq = GenSEQ
                Dim Seq1 = Iseq + 1
                Dim Seq2 = Iseq + 2
                Dim Seq3 = Iseq + 3
                Dim Seq4 = Iseq + 4
                Dim Seq5 = Iseq + 5
                rs = md.mGetdatachildpartsummarychildSpc(arrData0.wi, arrData1.wi, arrData2.wi, arrData3.wi, arrData4.wi, Seq1, Seq2, Seq3, Seq4, Seq5, Working_Pro.Label18.Text)
                rsFg = md.mGetdatachildpartsummaryfgSpc(arrData0.wi, arrData1.wi, arrData2.wi, arrData3.wi, arrData4.wi, Seq1, Seq2, Seq3, Seq4, Seq5, Working_Pro.Label18.Text)
                cListview = 0
                MsgBox(rs)
                If rs <> "0" Then
                    Dim dcResultdata As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                    Dim i As Integer = 1
                    For Each item As Object In dcResultdata
                        cListview += 1
                        Dim dt_item_type As String = ""
                        If item("dt_type").ToString() = "1" Then
                            dt_item_type = "NG"
                        Else
                            dt_item_type = "NC"
                        End If
                        datlvDefectsumary = New ListViewItem("1")
                        datlvDefectsumary.SubItems.Add("1")
                        datlvDefectsumary.SubItems.Add("1")
                        datlvDefectsumary.SubItems.Add("1")
                        datlvDefectsumary.SubItems.Add("1")
                        lvCp.Items.Add(datlvDefectsumary)
                        lvFG.Items.Add(datlvDefectsumary)
                        ListView1.Items.Add(datlvDefectsumary)
                        aDefectcode.Add("1")
                        aDefectcode.Add("1")
                        datlvDefectsumary.Enabled = True
                        i += 1
                        cBuottndown += 1
                    Next
                Else
                    datlvDefectsumary = New ListViewItem("1")
                    datlvDefectsumary.SubItems.Add("NO DATA")
                    datlvDefectsumary.SubItems.Add("NO DATA")
                    datlvDefectsumary.SubItems.Add("NO DATA")
                    datlvDefectsumary.SubItems.Add("NO DATA")
                    datlvDefectsumary.SubItems.Add("NO DATA")
                    lvCp.Items.Add(datlvDefectsumary)
                End If
                Return rs
            End If
        Catch ex As Exception
            load_show.Show()
        End Try
    End Function

    Private Sub ShowSpcDetailDefect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDefectdetailnc()
    End Sub
End Class