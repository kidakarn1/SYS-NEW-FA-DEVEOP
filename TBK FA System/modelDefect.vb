Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Globalization
Imports System.Data
Imports Newtonsoft.Json.Linq

Public Class modelDefect
    Public Shared bf = New Backoffice_model()
    Public Shared Function mGetchildpart(wi)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getChildpart?wi=" & wi)
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
    Public Shared Function mGetchildpartSpc(arrWi As Array)
        Try
            Dim api = New api()
            Dim requestFunction As New JObject()
            Dim jArrayWI As New JArray(arrWi)
            Console.WriteLine(jArrayWI)
            requestFunction("arrWi") = jArrayWI
            Dim url As String = "http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefectSpecial/getChildpart"
            Dim result = api.Load_dataPOST(url, requestFunction)

            If result <> "0" Then
                Return result
            Else
                MsgBox("connect Api Faill Please check modelDefect in Function mGetchildpartSpc Data = 0 ")
                Return 0
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetchildpartSpc = " & ex.Message)
            Return 0
        End Try
    End Function
    Public Function mGetPartno(wi As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/GetMainPartNo?Wi=" & wi)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDataplan?itemCd=" & pNo & "&flg=" & flg)
            Console.WriteLine("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDataplan?itemCd=" & pNo & "&flg=" & flg)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDefectcode?LineCd=" & LineCd)
            If rsData <> "0" Then
                Return rsData
            Else
                MsgBox("Please Check Master Defect Code.")
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDatadefectcodeprint?wi=" & wi & "&lot=" & lot & "&seqNo=" & seqNo & "&itemCd=" & itemCd & "&dfType=" & dfType)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getBoxInformation?wi=" & wi & "&lot=" & lot & "&seq=" & seqNo)
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


    Public Shared Function mInsertdefectregister(dtWino As String, dtLineno As String, dtItemcd As String, dtItemtype As String, dtLotno As String, dtSeqno As String, dtType As String, dtCode As String, dtQty As String, dtMenu As String, dtActualdate As String, pwi_id As String)
        Try
            Dim api = New api()
            Dim rsData As Boolean = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/insertDatadefect/insertDefectregister?dtWino=" & dtWino & "&dtLineno=" & dtLineno & "&dtItemcd=" & dtItemcd & "&dtItemtype=" & dtItemtype & "&dtLotNo=" & dtLotno & "&dtSeqno=" & dtSeqno & "&dtType=" & dtType & "&dtCode=" & dtCode & "&dtQty=" & dtQty & "&dtMenu=" & dtMenu & "&dtActualdate=" & dtActualdate & "&pwi_id=" & pwi_id)
            Console.WriteLine("http://" & Backoffice_model.svApi & "/apiShopfloor_test/insertDatadefect/insertDefectregister?dtWino=" & dtWino & "&dtLineno=" & dtLineno & "&dtItemcd=" & dtItemcd & "&dtItemtype=" & dtItemtype & "&dtLotNo=" & dtLotno & "&dtSeqno=" & dtSeqno & "&dtType=" & dtType & "&dtCode=" & dtCode & "&dtQty=" & dtQty & "&dtMenu=" & dtMenu & "&dtActualdate=" & dtActualdate & "&pwi_id=" & pwi_id)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mInsertdefectregister = " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function mInsertdefectactual(dtWino As String, dtLineno As String, dtItemcd As String, dtItemtype As String, dtLotno As String, dtSeqno As String, dtType As String, dtCode As String, dtQty As String, dtMenu As String, dtActualdate As String, pwi_id As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/insertDatadefect/insertDefectactual?dtWino=" & dtWino & "&dtLineno=" & dtLineno & "&dtItemcd=" & dtItemcd & "&dtItemtype=" & dtItemtype & "&dtLotNo=" & dtLotno & "&dtSeqno=" & dtSeqno & "&dtType=" & dtType & "&dtCode=" & dtCode & "&dtQty=" & dtQty & "&dtMenu=" & dtMenu & "&dtActualdate=" & dtActualdate & "&pwi_id=" & pwi_id)
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
            Dim rsData As Boolean = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/updateDatadefect/updateDatadefectregister?dtWino=" & dtWino & "&dtLotNo=" & dtLotNo & "&dtSeqno=" & CDbl(Val(dtSeqno)) & "&dtType=" & dtType & "&dtCode=" & dtCode & "&dtItemType=" & ItemType & "&PartNo=" & PartNo)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mUpdateaddjust = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mUpdatedefectactual(dtWino As String, dtLotNo As String, dtSeqno As String, dtType As String, dtCode As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/updateDatadefect/updateDefectactual?dtWino=" & dtWino & "&dtLotNo=" & dtLotNo & "&dtSeqno=" & dtSeqno & "&dtType=" & dtType & "&dtCode=" & dtCode & "&itemCd=" & itemCd)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mUpdatedefectactual = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mUpdatedefectactualAdmin(dtWino As String, dtLotNo As String, dtSeqno As String, dtType As String, dtCode As String, dtItemType As String, ItemCd As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/updateDatadefect/updateDefectactualAdmin?dtWino=" & dtWino & "&dtLotNo=" & dtLotNo & "&dtSeqno=" & dtSeqno & "&dtType=" & dtType & "&dtCode=" & dtCode & "&dtItemType=" & dtItemType & "&ItemCd=" & ItemCd)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mUpdatedefectactual = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mGetdefectdetailnc(dtWino As String, dtSeq As String, dtLot As String, Type As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDefectnc?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot & "&dfType=" & Type)
            Console.WriteLine("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDefectnc?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot & "&dfType=" & Type)
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
    Public Shared Function mGetdefectdetailncSpc(arrayWI As Array, lengthDataPlan As Integer, dtLot As String, Type As String, startSeq As Integer)
        Try
            Dim api = New api()
            Dim requestFunction As New JObject()
            Dim jArrayWI As New JArray(arrayWI)
            requestFunction("arrWi") = jArrayWI
            requestFunction("lengthDataPlan") = lengthDataPlan
            requestFunction("startseq") = startSeq
            requestFunction("dfLot") = dtLot
            requestFunction("dfType") = Type
            Dim url As String = "http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefectSpecial/getDefectnc"
            Dim rsData = api.Load_dataPOST(url, requestFunction)
            Console.WriteLine(rsData)
            If rsData <> "0" Then
                Return rsData
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdefectdetailncSpc = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mGetdefectdetailncPartno(dtWino As String, dtSeq As String, dtLot As String, Type As String, PartNo As String)
        Try
            Dim api = New api()
            Dim rsData As String = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDefectncPartNo?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot & "&dfType=" & Type & "&PartNo=" & PartNo)
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
    Public Shared Function mGetdefectdetailncPartnoSpc(arrayWI As Array, lengthDataPlan As Integer, dtLot As String, Type As String, PartNo As String, dfWiSel As String, dfSeqSel As String)
        Try
            Dim api = New api()
            Dim requestFunction As New JObject()
            Dim jArrayWI As New JArray(arrayWI)
            requestFunction("arrWi") = jArrayWI
            requestFunction("lengthDataPlan") = lengthDataPlan
            requestFunction("dfLot") = dtLot
            requestFunction("Type") = Type
            requestFunction("PartNo") = PartNo
            requestFunction("dfWiSel") = dfWiSel
            requestFunction("dfSeqSel") = dfSeqSel
            Dim url As String = "http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefectSpecial/getDefectncPartNo"
            Dim rsData = api.Load_dataPOST(url, requestFunction)
            If rsData <> "0" Then
                Return rsData
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdefectdetailncPartnoSpc = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mGetdatachildpartsummarychild(dtWino As String, dtSeq As String, dtLot As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/Getdatachildpartsummarychild?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdatachildpartsummarychild = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function
    Public Shared Function mGetdatachildpartsummarychildSpc(arrayWI As Array, lengthDataPlan As Integer, dtLot As String, startseq As Integer)
        Try
            Dim api = New api()
            Dim requestFunction As New JObject()
            Dim jArrayWI As New JArray(arrayWI)
            requestFunction("dfWi") = jArrayWI
            requestFunction("lengthDataPlan") = lengthDataPlan
            requestFunction("dfLot") = dtLot
            requestFunction("startseq") = startseq

            Dim url As String = "http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefectSpecial/GetdatachildpartsummarychildSpc"
            Dim result = api.Load_dataPOST(url, requestFunction)
            MsgBox(result)
            'Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefectSpecial/GetdatachildpartsummarychildSpc?dfWi1=" & dtWino1 & "&dfWi2=" & dtWino2 & "&dfWi3=" & dtWino3 & "&dfWi4=" & dtWino4 & "&dfWi5=" & dtWino5 & "&dfSeq1=" & dtSeq1 & "&dfSeq2=" & dtSeq2 & "&dfSeq3=" & dtSeq3 & "&dfSeq4=" & dtSeq4 & "&dfSeq5=" & dtSeq5 & "&dfLot=" & dtLot)
            If result <> "0" Then
                Return result
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdatachildpartsummarychildSpc = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function
    Public Shared Function mGetdatachildpartsummaryfg(dtWino As String, dtSeq As String, dtLot As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/Getdatachildpartsummaryfg?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot)
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
    Public Shared Function mGetdatachildpartsummaryfgSpc(arrayWI As Array, lengthDataPlan As Integer, dtLot As String, startseq As Integer)
        Try
            Dim requestFunction As New JObject()
            Dim api = New api()
            Dim jArrayWI As New JArray(arrayWI)
            requestFunction("dfWi") = jArrayWI
            requestFunction("lengthDataPlan") = lengthDataPlan
            requestFunction("dfLot") = dtLot
            requestFunction("startseq") = startseq
            Dim url As String = "http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefectSpecial/GetdatachildpartsummaryfgSpc"
            Dim rsData = api.Load_dataPOST(url, requestFunction)
            '  Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefectSpecial/GetdatachildpartsummaryfgSpc?dfWi1=" & dtWino1 & "&dfWi2=" & dtWino2 & "&dfWi3=" & dtWino3 & "&dfWi4=" & dtWino4 & "&dfWi5=" & dtWino5 & "&dfSeq1=" & dtSeq1 & "&dfSeq2=" & dtSeq2 & "&dfSeq3=" & dtSeq3 & "&dfSeq4=" & dtSeq4 & "&dfSeq5=" & dtSeq5 & "&dfLot=" & dtLot)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetdatachildpartsummaryfgSpc = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function

    Public Shared Function mgroupDataWiSpc(WI As String, seq As String, dtLot As String)
        Try
            Dim requestFunction As New JObject()
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefectSpecial/groupDataWiSpc?dfWi=" & WI & "&dfseq=" & seq & "&dfLot=" & dtLot)
            If rsData <> "0" Then
                Return rsData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mgroupDataWiSpc = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function

    Public Shared Function Getdatachildpartsummaryfggrouppart(dtWino As String, dtSeq As String, dtLot As String, dfType As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/Getdatachildpartsummaryfggrouppart?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot & "&dfType=" & dfType)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/Getdatachildpartsummarychildgrouppart?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot & "&dfType=" & dfType)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/GetdatachildpartsummarychildgrouppartAdminAdjust?dfWi=" & dtWino & "&dfSeq=" & dtSeq & "&dfLot=" & dtLot & "&dfType=" & dfType & "&ItemCd=" & itemCd)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDefectactualadmin?LineCd=" & LineCd & "&sDate=" & sDate & "&eDate=" & eDate)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDefectadmindetailncFG?LineCd=" & LineCd & "&sDate=" & sDate & "&eDate=" & eDate)
            Console.WriteLine("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDefectadmindetailncFG?LineCd=" & LineCd & "&sDate=" & sDate & "&eDate=" & eDate)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/GetDefect?wi=" & wi & "&lotNo=" & lotNo & "&shift=" & shift)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/GetPartBySelectDate?LineCd=" & LineCd & "&sDate=" & sDate & "&Shift=" & Shift & "&Type=" & Type)
            Console.WriteLine("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/GetPartBySelectDate?LineCd=" & LineCd & "&sDate=" & sDate & "&Shift=" & Shift & "&Type=" & Type)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/GetPartBySelectDateWi?LineCd=" & LineCd & "&sDate=" & sDate & "&Shift=" & Shift & "&Wi=" & wi & "&itemType=" & itemType & "&seqNo=" & seqNo & "&Type=" & Type)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDefectadmindetailngFG?LineCd=" & LineCd & "&sDate=" & sDate & "&eDate=" & eDate)
            Console.WriteLine("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getDefectadmindetailngFG?LineCd=" & LineCd & "&sDate=" & sDate & "&eDate=" & eDate)
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
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/getQtyofdefectcode?dtWino=" & dtWino & "&dtLotNo=" & dtLotNo & "&dtSeqno=" & dtSeqno & "&dtType=" & dtType & "&dtCode=" & dtCode & "&ItemCd=" & itemCd)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetQtyofdefectcode = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mInserttagdefect(dti_wi_no As String, dti_line_cd As String, dti_item_cd As String, dti_item_type As String, dti_lot_no As String, dti_seq_no As String, dti_type As String, dti_sum_qty As String, dti_menu As String, dti_box_no As String, dti_info_qr_cd As String, dti_defect_qr_cd As String, dti_status_flg As String, dti_created_date As String, dti_created_by As String, dti_updated_date As String, dti_updated_by As String, pwi_id As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/insertDatadefect/inserttagdefect?dti_wi_no=" & dti_wi_no & "&dti_line_cd=" & dti_line_cd & "&dti_item_cd=" & dti_item_cd & "&dti_item_type=" & dti_item_type & "&dti_lot_no=" & dti_lot_no & "&dti_seq_no=" & dti_seq_no & "&dti_type=" & dti_type & "&dti_sum_qty=" & dti_sum_qty & "&dti_menu=" & dti_menu & "&dti_box_no=" & dti_box_no & "&dti_info_qr_cd=" & dti_info_qr_cd & "&dti_defect_qr_cd=" & dti_defect_qr_cd & "&dti_status_flg=" & dti_status_flg & "&dti_created_date=" & dti_created_date & "&dti_created_by=" & dti_created_by & "&dti_updated_date=" & dti_updated_date & "&dti_updated_by=" & dti_updated_by & "&pwi_id=" & pwi_id)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mInserttagdefect = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mGetDatasys_exp_defect_mst(def_cd As String)
        Try
            Dim api = New api()
            Dim rsData = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefect/GetDatasys_exp_defect_mst?def_cd=" & def_cd)
            Return rsData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mGetDatasys_exp_defect_mst = " & ex.Message)
            Return False
        End Try
    End Function


End Class