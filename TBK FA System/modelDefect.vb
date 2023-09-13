Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Globalization
Imports System.Data
Public Class modelDefect
    Public Shared bf = New Backoffice_model()
    Public Shared Function mGetchildpart(wi)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/getChildpart?wi=" & wi)
            If rsData <> "0" Then
                Return rsData
            Else
                MsgBox("connect Api Faill Please check modelDefect in Function mGetchildpart Data = 0 ")
                Return 0
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetchildpart = " & ex.Message)
            Return 0
        End Try
    End Function
    Public Function mGetPartno(wi As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/GetMainPartNo?Wi=" & wi)
            If rsData <> "0" Then
                Return rsData
            Else
                MsgBox("connect Api Faill Please check modelDefect in Function mGetPartno Data = 0 ")
                Return 0
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetPartno = " & ex.Message)
            Return 0
        End Try
    End Function
    Public Function mGetdatepartdetail(pNo As String, flg As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/getDataplan?itemCd=" & pNo & "&flg=" & flg)
            If rsData <> "0" Then
                Return rsData
            Else
                MsgBox("connect Api Faill Please check modelDefect in Function mGetdatepartdetail Data = 0 ")
                Return 0
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdatepartdetail = " & ex.Message)
            Return 0
        End Try
    End Function

    Public Shared Function mGetdefectcode(LineCd As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/getDefectcode?LineCd=" & LineCd)
            If rsData <> "0" Then
                Return rsData
            Else
                MsgBox("connect Api Faill Please check modelDefect in Function mGetdefectcode Data = 0 ")
                Return 0
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdefectcode = " & ex.Message)
            Return 0
        End Try
    End Function

    Public Shared Function mGetDatadefectcodeprint(wi As String, lot As String, seqNo As String, itemCd As String, dfType As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/getDatadefectcodeprint?wi=" & wi & "&lot=" & lot & "&seqNo=" & seqNo & "&itemCd=" & itemCd & "&dfType=" & dfType)
            If rsData <> "0" Then
                Return rsData
            Else
                MsgBox("connect Api Faill Please check modelDefect in Function mGetDatadefectcodeprint Data = 0 ")
                Return 0
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetDatadefectcodeprint = " & ex.Message)
            Return 0
        End Try
    End Function
    Public Shared Function mGetboxInformation(wi As String, lot As String, seqNo As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/getBoxInformation?wi=" & wi & "&lot=" & lot & "&seq=" & seqNo)
            If rsData <> "0" Then
                Return rsData
            Else
                ' MsgBox("connect Api Faill Please check modelDefect in Function mGetboxInformation Data = 0 ")
                Return 0
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetboxInformation = " & ex.Message)
            Return 0
        End Try
    End Function


    Public Shared Function mInsertdefectregister(dtWino As String, dtLineno As String, dtItemcd As String, dtItemtype As String, dtLotno As String, dtSeqno As String, dtType As String, dtCode As String, dtQty As String, dtMenu As String, dtActualdate As String)
        Try
            Dim api = New api()
            Dim rsData As Boolean = api.Load_data("http://192.168.161.77/apiShopfloor/insertDatadefect/insertDefectregister?dtWino=" & dtWino & "&dtLineno=" & dtLineno & "&dtItemcd=" & dtItemcd & "&dtItemtype=" & dtItemtype & "&dtLotNo=" & dtLotno & "&dtSeqno=" & dtSeqno & "&dtType=" & dtType & "&dtCode=" & dtCode & "&dtQty=" & dtQty & "&dtMenu=" & dtMenu & "&dtActualdate=" & dtActualdate)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mInsertdefectregister = " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function mInsertdefectactual(dtWino As String, dtLineno As String, dtItemcd As String, dtItemtype As String, dtLotno As String, dtSeqno As String, dtType As String, dtCode As String, dtQty As String, dtMenu As String, dtActualdate As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/insertDatadefect/insertDefectactual?dtWino=" & dtWino & "&dtLineno=" & dtLineno & "&dtItemcd=" & dtItemcd & "&dtItemtype=" & dtItemtype & "&dtLotNo=" & dtLotno & "&dtSeqno=" & dtSeqno & "&dtType=" & dtType & "&dtCode=" & dtCode & "&dtQty=" & dtQty & "&dtMenu=" & dtMenu & "&dtActualdate=" & dtActualdate)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mInsertdefectactual = " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function mUpdateaddjust(dtWino As String, dtLotNo As String, dtSeqno As String, dtType As String, dtCode As String, ItemType As String, PartNo As String)
        Try
            ' MsgBox("dtWino = " & dtWino)
            ' MsgBox("dtLotNo = " & dtLotNo)
            ' MsgBox("dtSeqno = " & dtSeqno)
            ' MsgBox("dtType = " & dtType)
            ' MsgBox("dtCode = " & dtCode)
            ' MsgBox("ItemType = " & ItemType)
            ' MsgBox("PartNo = " & PartNo)
            Dim api = New api()
            Dim rsData As Boolean = api.Load_data("http://192.168.161.77/apiShopfloor/updateDatadefect/updateDatadefectregister?dtWino=" & dtWino & "&dtLotNo=" & dtLotNo & "&dtSeqno=" & CDbl(Val(dtSeqno)) & "&dtType=" & dtType & "&dtCode=" & dtCode & "&dtItemType=" & ItemType & "&PartNo=" & PartNo)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mUpdateaddjust = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mUpdatedefectactual(dtWino As String, dtLotNo As String, dtSeqno As String, dtType As String, dtCode As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/updateDatadefect/updateDefectactual?dtWino=" & dtWino & "&dtLotNo=" & dtLotNo & "&dtSeqno=" & dtSeqno & "&dtType=" & dtType & "&dtCode=" & dtCode & "&itemCd=" & itemCd)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mUpdatedefectactual = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mUpdatedefectactualAdmin(dtWino As String, dtLotNo As String, dtSeqno As String, dtType As String, dtCode As String, dtItemType As String, ItemCd As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/updateDatadefect/updateDefectactualAdmin?dtWino=" & dtWino & "&dtLotNo=" & dtLotNo & "&dtSeqno=" & dtSeqno & "&dtType=" & dtType & "&dtCode=" & dtCode & "&dtItemType=" & dtItemType & "&ItemCd=" & ItemCd)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mUpdatedefectactual = " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function mGetdefectdetailnc(dtWino As String, dtSeq As String, dtLot As String, Type As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/getDefectnc?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot & "&dfType=" & Type)
            If rsData <> "0" Then
                Return rsData
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdefectdetailnc = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mGetdefectdetailncPartno(dtWino As String, dtSeq As String, dtLot As String, Type As String, PartNo As String)
        Try
            Dim api = New api()
            Dim rsData As String = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/getDefectncPartNo?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot & "&dfType=" & Type & "&PartNo=" & PartNo)
            If rsData <> "0" Then
                Return rsData
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdefectdetailnc = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mGetdatachildpartsummarychild(dtWino As String, dtSeq As String, dtLot As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/Getdatachildpartsummarychild?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdatachildpartsummary = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function

    Public Shared Function mGetdatachildpartsummaryfg(dtWino As String, dtSeq As String, dtLot As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/Getdatachildpartsummaryfg?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdatachildpartsummary = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function

    Public Shared Function Getdatachildpartsummaryfggrouppart(dtWino As String, dtSeq As String, dtLot As String, dfType As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/Getdatachildpartsummaryfggrouppart?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot & "&dfType=" & dfType)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdatachildpartsummary = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function
    Public Shared Function mGetdatachildpartsummarychildgrouppart(dtWino As String, dtSeq As String, dtLot As String, dfType As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/Getdatachildpartsummarychildgrouppart?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot & "&dfType=" & dfType)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdatachildpartsummary = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function

    Public Shared Function GetdatachildpartsummarychildgrouppartAdminAdjust(dtWino As String, dtSeq As String, dtLot As String, dfType As String, itemCd As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/GetdatachildpartsummarychildgrouppartAdminAdjust?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot & "&dfType=" & dfType & "&ItemCd=" & itemCd)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function GetdatachildpartsummarychildgrouppartAdminAdjust = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function
    Public Shared Function mGetdefectactual(LineCd As String, sDate As String, eDate As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/getDefectactualadmin?LineCd=" & LineCd & "&sDate=" & sDate & "&eDate=" & eDate)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdefectactual = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function

    Public Shared Function mGetDefectadmindetailncFG(LineCd As String, sDate As String, eDate As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/getDefectadmindetailncFG?LineCd=" & LineCd & "&sDate=" & sDate & "&eDate=" & eDate)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetDefectadmindetailnc = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function
    Public Shared Function mGetDataAdminAdjust()

    End Function
    Public Shared Function mGetDefect(wi As String, lotNo As String, shift As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/GetDefect?wi=" & wi & "&lotNo=" & lotNo & "&shift=" & shift)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetDefect = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function
    Public Shared Function mGetPartBySelectDate(LineCd As String, sDate As String, Shift As String, Type As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/GetPartBySelectDate?LineCd=" & LineCd & "&sDate=" & sDate & "&Shift=" & Shift & "&Type=" & Type)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetPartBySelectDate = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function
    Public Shared Function mGetDataAdminAdjustByWi(LineCd As String, sDate As String, Shift As String, wi As String, itemType As String, seqNo As String, Type As String)
        Try
            Dim api = New api()
            'MsgBox("LineCd = " & LineCd)
            'MsgBox("sDate = " & sDate)
            'MsgBox("Shift = " & Shift)
            'MsgBox("wi = " & wi)
            'MsgBox("itemType = " & itemType)
            'MsgBox("seqNo = " & seqNo)
            'MsgBox("Type = " & Type)
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/GetPartBySelectDateWi?LineCd=" & LineCd & "&sDate=" & sDate & "&Shift=" & Shift & "&Wi=" & wi & "&itemType=" & itemType & "&seqNo=" & seqNo & "&Type=" & Type)
            ' MsgBox(rsData)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetPartBySelectDate = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function
    Public Shared Function mGetDefectadmindetailng(LineCd As String, sDate As String, eDate As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/getDefectadmindetailngFG?LineCd=" & LineCd & "&sDate=" & sDate & "&eDate=" & eDate)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function getDefectadmindetailng = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function
    Public Shared Function mGetQtyofdefectcode(dtWino As String, dtLotNo As String, dtSeqno As String, dtType As String, dtCode As String, itemCd As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/getDatadefect/getQtyofdefectcode?dtWino=" & dtWino & "&dtLotNo=" & dtLotNo & "&dtSeqno=" & dtSeqno & "&dtType=" & dtType & "&dtCode=" & dtCode & "&ItemCd=" & itemCd)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetQtyofdefectcode = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mInserttagdefect(dti_wi_no As String, dti_line_cd As String, dti_item_cd As String, dti_item_type As String, dti_lot_no As String, dti_seq_no As String, dti_type As String, dti_sum_qty As String, dti_menu As String, dti_box_no As String, dti_info_qr_cd As String, dti_defect_qr_cd As String, dti_status_flg As String, dti_created_date As String, dti_created_by As String, dti_updated_date As String, dti_updated_by As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://192.168.161.77/apiShopfloor/insertDatadefect/inserttagdefect?dti_wi_no=" & dti_wi_no & "&dti_line_cd=" & dti_line_cd & "&dti_item_cd=" & dti_item_cd & "&dti_item_type=" & dti_item_type & "&dti_lot_no=" & dti_lot_no & "&dti_seq_no=" & dti_seq_no & "&dti_type=" & dti_type & "&dti_sum_qty=" & dti_sum_qty & "&dti_menu=" & dti_menu & "&dti_box_no=" & dti_box_no & "&dti_info_qr_cd=" & dti_info_qr_cd & "&dti_defect_qr_cd=" & dti_defect_qr_cd & "&dti_status_flg=" & dti_status_flg & "&dti_created_date=" & dti_created_date & "&dti_created_by=" & dti_created_by & "&dti_updated_date=" & dti_updated_date & "&dti_updated_by=" & dti_updated_by)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetQtyofdefectcode = " & ex.Message)
            Return False
        End Try
    End Function
End Class