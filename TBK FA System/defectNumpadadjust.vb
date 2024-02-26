Public Class defectNumpadadjust
    Shared dfDetailsnc As New defectDetailnc()
    Shared dfDetailsng As New defectDetailng()
    Shared maxQty As Integer = 0
    Shared sPart As String = ""
    Shared actQty As Integer = 0
    Shared dtWino
    Shared dtLineno
    Shared dtItemcd
    Shared dtItemtype
    Shared dtLotNo
    Shared dtSeqno
    Shared dtType
    Shared dtCode
    Shared dtQty
    Shared dtMenu
    Shared dtActualdate
    Shared pd As New Confrime_work_production()
    Shared nc As Integer = Working_Pro.lb_nc_qty.Text
    Shared ng As Integer = Working_Pro.lb_ng_qty.Text
    Shared sNc
    Shared sNg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNumber1.Click
        tbAddjust.Text = tbAddjust.Text + "1"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnNumber2.Click
        tbAddjust.Text = tbAddjust.Text + "2"
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnNumber3.Click
        tbAddjust.Text = tbAddjust.Text + "3"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNumber4.Click
        tbAddjust.Text = tbAddjust.Text + "4"
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnNumber5.Click
        tbAddjust.Text = tbAddjust.Text + "5"
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnNumber6.Click
        tbAddjust.Text = tbAddjust.Text + "6"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnNumber7.Click
        tbAddjust.Text = tbAddjust.Text + "7"
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnNumber8.Click
        tbAddjust.Text = tbAddjust.Text + "8"
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnNumber9.Click
        tbAddjust.Text = tbAddjust.Text + "9"
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnNumber0.Click
        tbAddjust.Text = tbAddjust.Text + "0"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        tbAddjust.Clear()
        tbAddjust.Text = "0"
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Dim objDefectdetailnc As New defectDetailnc()
        Dim dfHome As defectHome
        If dfHome.dtType = "NC" Then
            defectDetailnc.Show()
        ElseIf dfHome.dtType = "NG" Then
            defectDetailng.Show()
        End If
        Me.Close()
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim txt_lenght As Integer = tbAddjust.Text.Length
        Try
            tbAddjust.Text = tbAddjust.Text.Substring(0, txt_lenght - 1)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub setVariable()
        Dim pd As New Working_Pro()
        Dim dfHome As defectHome
        If dfHome.dtType = "NC" Then
            Dim objDefectdetailnc As New defectDetailnc
            sPart = dfDetailsnc.dtItemcd '"J107-11820-RM" 'pd.pFg
            dtWino = objDefectdetailnc.dtWino
            dtLineno = objDefectdetailnc.dtLineno
            dtItemcd = objDefectdetailnc.dtItemcd
            dtItemtype = objDefectdetailnc.dtItemtype
            dtLotNo = objDefectdetailnc.dtLotNo
            dtSeqno = objDefectdetailnc.dtSeqno
            dtType = objDefectdetailnc.dtType
            dtCode = objDefectdetailnc.dtCode
            dtQty = objDefectdetailnc.dtQty
            dtMenu = objDefectdetailnc.dtMenu
            dtActualdate = objDefectdetailnc.dtActualdate
            sNc = objDefectdetailnc.sNc
            If defectDetailnc.Types = "FG" Then
                actQty = Working_Pro.LB_COUNTER_SEQ.Text
            Else
                actQty = CDbl(Val(sNc))
            End If
        ElseIf dfHome.dtType = "NG" Then
            Dim objDefectdetailng As New defectDetailng
            sPart = dfDetailsng.dtItemcd '"J107-11820-RM" 'pd.pFg
            dtWino = objDefectdetailng.dtWino
            dtLineno = objDefectdetailng.dtLineno
            dtItemcd = objDefectdetailng.dtItemcd
            If objDefectdetailng.dtnameItemtype = "FG" Then
                dtItemtype = "1"
            ElseIf objDefectdetailng.dtnameItemtype = "CP" Then
                dtItemtype = "2"
            End If
            dtLotNo = objDefectdetailng.dtLotNo
            dtSeqno = objDefectdetailng.dtSeqno
            dtType = objDefectdetailng.dtType
            dtCode = objDefectdetailng.dtCode
            dtQty = objDefectdetailng.dtQty
            dtMenu = objDefectdetailng.dtMenu
            dtActualdate = objDefectdetailng.dtActualdate
            sNg = objDefectdetailng.sNg
            If defectDetailng.types = "FG" Then
                actQty = Working_Pro.LB_COUNTER_SEQ.Text
            Else
                actQty = CDbl(Val(sNg))
            End If
        End If
        nc = Working_Pro.lb_nc_qty.Text
        ng = Working_Pro.lb_ng_qty.Text
    End Sub

    Private Sub defectNumpadadjust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setVariable()
        lbAct.Text = actQty
        lbPart.Text = sPart
        Dim dfHome As defectHome
        Try
            lbMax.Text = ""
            If dfHome.dtType = "NC" Then
                If defectDetailnc.Types = "FG" Then
                    lbMax.Text = calNumpadadjustNc(actQty, nc, ng, sNc)
                Else
                    Dim md = New modelDefect
                    Dim UseQty = md.mGetdefectdetailncPartno(Working_Pro.wi_no.Text, Working_Pro.Label22.Text, Working_Pro.Label18.Text, "2", lbPart.Text)
                    Dim maxQty As Integer = (999 - Convert.ToInt32(UseQty)) + sNc
                    lbMax.Text = maxQty '"Unlimited"
                End If
            ElseIf dfHome.dtType = "NG" Then
                If defectDetailng.types = "FG" Then
                    lbMax.Text = calNumpadadjustNg(actQty, nc, ng, sNg)
                Else
                    Dim md = New modelDefect
                    Dim UseQty = md.mGetdefectdetailncPartno(Working_Pro.wi_no.Text, Working_Pro.Label22.Text, Working_Pro.Label18.Text, "1", lbPart.Text)
                    Dim maxQty As Integer = (999 - Convert.ToInt32(UseQty)) + sNg
                    lbMax.Text = maxQty '"Unlimited"
                End If
            End If
        Catch ex As Exception
            MsgBox("Please Select Data")
        End Try
    End Sub
    Public Sub manageNc()
        If defectDetailnc.Types = "FG" Then
            Dim rs = ckInputqtyaddjust(tbAddjust.Text, lbMax.Text)
            If rs Then
                Dim dfHome As New defectHome
                Dim wi
                Dim lot
                Dim seq
                Dim dfType
                Dim dtCode
                If dfHome.dtType = "NC" Then
                    wi = dfDetailsnc.dtWino
                    lot = dfDetailsnc.dtLotNo
                    seq = dfDetailsnc.dtSeqno
                    dfType = dfDetailsnc.dtType
                    dtCode = dfDetailsnc.dtCode
                    setValuenc(actQty, nc, ng, sNc, tbAddjust.Text)
                ElseIf dfHome.dtType = "NG" Then
                    wi = dfDetailsng.dtWino
                    lot = dfDetailsng.dtLotNo
                    seq = dfDetailsng.dtSeqno
                    dfType = dfDetailsng.dtType
                    dtCode = dfDetailsng.dtCode
                    setValueng(actQty, nc, ng, sNg, tbAddjust.Text)
                End If
                'MsgBox("wi = " & wi)
                'MsgBox("lot = " & lot)
                'MsgBox("seq = " & seq)
                'MsgBox("dfType = " & dfType)
                'MsgBox("dtCode = " & dtCode)
                updateAddjustqty(wi, lot, seq, dfType, dtCode)
                Working_Pro.Enabled = True
                Me.Close()
            Else
                MsgBox("Please Check QTY.")
            End If
        Else ' Child Part
            Dim LdfDetailsnc As New defectDetailnc()
            Dim LdfDetailsng As New defectDetailng()
            Dim dfHome As New defectHome
            Dim wi
            Dim lot
            Dim seq
            Dim dfType
            Dim dtCode
            If dfHome.dtType = "NC" Then
                wi = LdfDetailsnc.dtWino
                lot = LdfDetailsnc.dtLotNo
                seq = LdfDetailsnc.dtSeqno
                dfType = LdfDetailsnc.dtType
                dtCode = LdfDetailsnc.dtCode
                Dim rs = ckInputqtyaddjust(tbAddjust.Text, lbMax.Text)
                If rs Then
                    setValuenc(actQty, Working_Pro.lb_nc_child_part.Text, Working_Pro.lb_ng_child_part.Text, sNc, tbAddjust.Text)
                    updateAddjustqty(wi, lot, seq, dfType, dtCode)
                    Working_Pro.Enabled = True
                    Me.Close()
                Else
                    MsgBox("Please Check QTY.")
                End If
                'MsgBox("-->")
                'MsgBox("wi = " & wi)
                'MsgBox("lot = " & lot)
                'MsgBox("seq = " & seq)
            ElseIf dfHome.dtType = "NG" Then
                wi = LdfDetailsng.dtWino
                lot = LdfDetailsng.dtLotNo
                seq = LdfDetailsng.dtSeqno
                dfType = LdfDetailsng.dtType
                dtCode = LdfDetailsng.dtCode
                Dim rs = ckInputqtyaddjust(tbAddjust.Text, lbMax.Text)
                If rs Then
                    setValueng(actQty, Working_Pro.lb_nc_child_part.Text, Working_Pro.lb_ng_child_part.Text, sNg, tbAddjust.Text)
                    updateAddjustqty(wi, lot, seq, dfType, dtCode)
                    Working_Pro.Enabled = True
                    Me.Close()
                End If
                'MsgBox("-->")
                'MsgBox("wi = " & wi)
                'MsgBox("lot = " & lot)
                'MsgBox("seq = " & seq)
            End If
        End If
    End Sub
    Public Sub manageNg()
        If defectDetailng.types = "FG" Then
            Dim rs = ckInputqtyaddjust(tbAddjust.Text, lbMax.Text)
            If rs Then
                Dim dfHome As New defectHome
                Dim wi
                Dim lot
                Dim seq
                Dim dfType
                Dim dtCode
                If dfHome.dtType = "NC" Then
                    wi = dfDetailsnc.dtWino
                    lot = dfDetailsnc.dtLotNo
                    seq = dfDetailsnc.dtSeqno
                    dfType = dfDetailsnc.dtType
                    dtCode = dfDetailsnc.dtCode
                    Dim rsCheck = ckInputqtyaddjust(tbAddjust.Text, lbMax.Text)
                    If rsCheck Then
                        setValuenc(actQty, nc, ng, sNc, tbAddjust.Text)
                        updateAddjustqty(wi, lot, seq, dfType, dtCode)
                        Working_Pro.Enabled = True
                        Me.Close()
                    Else
                        MsgBox("Please Check QTY.")
                    End If
                ElseIf dfHome.dtType = "NG" Then
                    Dim rsCheck = ckInputqtyaddjust(tbAddjust.Text, lbMax.Text)
                    wi = dfDetailsng.dtWino
                    lot = dfDetailsng.dtLotNo
                    seq = dfDetailsng.dtSeqno
                    dfType = dfDetailsng.dtType
                    dtCode = dfDetailsng.dtCode
                    If rsCheck Then
                        setValueng(actQty, nc, ng, sNg, tbAddjust.Text)
                        updateAddjustqty(wi, lot, seq, dfType, dtCode)
                        Working_Pro.Enabled = True
                        Me.Close()
                    Else
                        MsgBox("Please Check QTY.")
                    End If
                End If
            Else
                MsgBox("Please Check QTY.")
            End If
        Else ' Child Part
            Dim LdfDetailsnc As New defectDetailnc()
            Dim LdfDetailsng As New defectDetailng()
            Dim dfHome As New defectHome
            Dim wi
            Dim lot
            Dim seq
            Dim dfType
            Dim dtCode
            If dfHome.dtType = "NC" Then
                wi = LdfDetailsnc.dtWino
                lot = LdfDetailsnc.dtLotNo
                seq = Working_Pro.seqNo
                dfType = LdfDetailsnc.dtType
                dtCode = LdfDetailsnc.dtCode
                Dim rs = ckInputqtyaddjust(tbAddjust.Text, lbMax.Text)
                If rs Then
                    setValuenc(actQty, Working_Pro.lb_nc_child_part.Text, Working_Pro.lb_ng_child_part.Text, sNc, tbAddjust.Text)
                    updateAddjustqty(wi, lot, seq, dfType, dtCode)
                    Working_Pro.Enabled = True
                    Me.Close()
                Else
                    MsgBox("Please Check QTY.")
                End If
            ElseIf dfHome.dtType = "NG" Then
                wi = LdfDetailsng.dtWino
                lot = LdfDetailsng.dtLotNo
                seq = Working_Pro.seqNo
                dfType = LdfDetailsng.dtType
                dtCode = LdfDetailsng.dtCode
                Dim rs = ckInputqtyaddjust(tbAddjust.Text, lbMax.Text)
                If rs Then
                    setValueng(actQty, Working_Pro.lb_nc_child_part.Text, Working_Pro.lb_ng_child_part.Text, sNg, tbAddjust.Text)
                    updateAddjustqty(wi, lot, seq, dfType, dtCode)
                    Working_Pro.Enabled = True
                    Me.Close()
                Else
                    MsgBox("Please Check QTY.")
                End If
            End If
        End If
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If tbAddjust.Text = "" Then
            tbAddjust.Text = 0
        End If
        If defectHome.dtType = "NC" Then
            manageNc()
        Else
            manageNg()
        End If
        '  Me.Close()
    End Sub
    Public Shared Function setValuenc(Act As String, nc As String, ng As String, sNc As String, ipQty As Integer)
        Dim total = (nc - sNc) + ipQty
        If defectDetailnc.Types = "FG" Then
            Working_Pro.lb_nc_qty.Text = total
        Else
            Working_Pro.lb_nc_child_part.Text = total
        End If
    End Function
    Public Shared Function setValueng(Act As String, nc As String, ng As String, sNg As String, ipQty As Integer)
        Dim total = (ng - sNg) + ipQty
        If defectDetailng.types = "FG" Then
            Working_Pro.lb_ng_qty.Text = total
        Else
            Working_Pro.lb_ng_child_part.Text = total
        End If
    End Function
    Public Function updateAddjustqty(dtWino As String, dtLotNo As String, dtSeqno As String, dtType As String, dtCode As String)
        Dim md As New modelDefect()
        Dim itemType As String = ""
        If defectHome.dtType = "NC" Then
            If defectDetailnc.Types = "FG" Then
                itemType = "1"
            Else
                itemType = "2"
            End If
        Else
            If defectDetailng.types = "FG" Then
                itemType = "1"
            Else
                itemType = "2"
            End If
        End If
        ' MsgBox("NG ITEM TYHPE ===>" & itemType)
        Dim rs = md.mUpdateaddjust(dtWino, dtLotNo, dtSeqno, dtType, dtCode, itemType, lbPart.Text)
        If rs Then
            Dim dfRegister As New defectRegister()
            dfRegister.insertDefectregister(dtWino, dtLineno, dtItemcd, itemType, dtLotNo, dtSeqno, dtType, dtCode, tbAddjust.Text, dtMenu, dtActualdate)
        Else
            MsgBox("Update Status Fiall Function updateAddjustqty in defectNumpadadjust.vb")
            MsgBox("mUpdateaddjust rs===>" & rs)
        End If
        Return 0
    End Function
    Public Function calNumpadadjustNc(Act As Integer, nc As Integer, ng As Integer, sNc As Integer)
        Dim totals = (Act - (nc + ng)) + sNc
        '  MsgBox("total = " & totals)
        'MsgBox("(" & Act & " - (" & nc & " + " & ng & ")) + " & sNc)
        Return totals
    End Function
    Public Function calNumpadadjustNg(Act As Integer, nc As Integer, ng As Integer, sNg As Integer)
        Dim totals = (Act - (nc + ng)) + sNg
        'MsgBox(Act & "-" & nc & "+" & ng & "-" & sNg)
        Return totals
    End Function
    Public Function ckInputqtyaddjust(ipQty As Integer, maxQty As Integer)
        If ipQty <= maxQty And ipQty >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class