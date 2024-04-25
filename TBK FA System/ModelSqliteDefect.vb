Imports System.Data.SQLite
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ModelSqliteDefect
    Public Function mInsertDefectTransection(dt_wi_no As String, dt_line_cd As String, dt_item_cd As String, dt_item_type As String, dt_lot_no As String, dt_seq_no As String, dt_type As String, dt_code As String, dt_qty As String, dtMenu As String, dtActualdate As String, pwi_id As String, dt_name_en As String)
        Dim sqliteConn As New SQLiteConnection(Backoffice_model.sqliteConnect)
        Backoffice_model.Check_connect_sqlite()
        Backoffice_model.Clear_sqlite()
        Try
            Dim created_date = DateTime.Now.ToString("yyyy-MM-dd H:m:s")
            sqliteConn.Open()
            Dim sva_ip_address As String = ""
            Dim cmd As New SQLiteCommand
            cmd.Connection = sqliteConn
            If Convert.ToInt32(dt_qty) > 0 Then
                dt_status_flg = "1"
            Else
                dt_status_flg = "5"
            End If
            cmd.CommandText = " 
                INSERT into defect_transactions (
					dt_wi_no,
					dt_line_cd,
					dt_item_cd,
					dt_item_type,
					dt_lot_no,
					dt_seq_no,
					dt_type,
					dt_code,
					dt_qty,
					dt_menu,
					dt_actual_date,
					dt_status_flg,
					dt_created_date,
					dt_created_by,
					dt_updated_date,
					dt_updated_by,
					pwi_id,
                    dt_status_close_lot,
                    dt_name_en
					) Values(
					'" & dt_wi_no & "',
					'" & dt_line_cd & "',
					'" & dt_item_cd & "',
					'" & dt_item_type & "',
					'" & dt_lot_no & "',
					'" & dt_seq_no & "',
					'" & dt_type & "',
					'" & dt_code & "',
					'" & dt_qty & "',
					'" & dtMenu & "',
					'" & created_date & "',
					'" & dt_status_flg & "',
					 '" & created_date & "',
					'" & dt_line_cd & "',
					 '" & created_date & "',
					'" & dt_line_cd & "',
					'" & pwi_id & "',
                    '0',
                    '" & dt_name_en & "')
            "
            Console.WriteLine(cmd.CommandText)
            Dim LoadSQL As SQLiteDataReader = cmd.ExecuteReader()
            sqliteConn.Close()
            Return True
        Catch ex As Exception
            MsgBox("SQLite Database connect failed. Please contact System System [Function mInsertDefectTransection] In File ModelSqliteDefect.")
            sqliteConn.Close()
            Return False
        End Try
        Return 0
    End Function
    Public Shared Function mUpdateaddjust(dtWino As String, dtLotNo As String, dtSeqno As String, dtType As String, dtCode As String, ItemType As String, PartNo As String)
        'Dim api = New api()
        ' Dim rsData As Boolean = api.Load_data("http://" & Backoffice_model.svApi & "/apiShopfloor_test/updateDatadefect/updateDatadefectregister?dtWino=" & dtWino & "&dtLotNo=" & dtLotNo & "&dtSeqno=" & CDbl(Val(dtSeqno)) & "&dtType=" & dtType & "&dtCode=" & dtCode & "&dtItemType=" & ItemType & "&PartNo=" & PartNo)
        Dim sqliteConn As New SQLiteConnection(Backoffice_model.sqliteConnect)
        Backoffice_model.Check_connect_sqlite()
        Backoffice_model.Clear_sqlite()
        Try
            Dim created_date = DateTime.Now.ToString("yyyy-MM-dd H:m:s")
            sqliteConn.Open()
            Dim sva_ip_address As String = ""
            Dim cmd As New SQLiteCommand
            cmd.Connection = sqliteConn
            cmd.CommandText = " update defect_transactions set dt_status_flg = '5' where dt_wi_no='" & dtWino & "' and dt_lot_no = '" & dtLotNo & "' and dt_seq_no = '" & dtSeqno & "' and dt_type = '" & dtType & "' and dt_code = '" & dtCode & "' and dt_item_type = '" & ItemType & "' and dt_item_cd = '" & PartNo & "')"
            Console.WriteLine(cmd.CommandText)
            Dim LoadSQL As SQLiteDataReader = cmd.ExecuteReader()
            sqliteConn.Close()
        Catch ex As Exception
            MsgBox("SQLite Database connect failed. Please contact System System [Function mUpdateaddjust] In File ModelSqliteDefect.")
            Return False
        End Try
    End Function
    Public Shared Function mSqliteGetdefectdetailnc(dfWi As String, dfSeq As String, dfLot As String, dfType As String)
        Dim api As New api
        Try
            Dim Sql = "SELECT dt.dt_item_cd, dt.dt_code, SUM(dt.dt_qty) AS total_nc, dt.dt_item_type, dt.dt_wi_no as dt_wi_no " &
          "FROM defect_transactions as dt " &
          "WHERE dt.dt_wi_no = '" & dfWi & "' " &
          "AND dt.dt_seq_no = '" & dfSeq & "' " &
          "AND dt.dt_lot_no = '" & dfLot & "' " &
          "AND dt.dt_type = '" & dfType & "' " &
          "AND dt.dt_status_flg = '1' " &
          "GROUP BY dt.dt_item_cd, dt.dt_code, dt.dt_item_type, dt.dt_wi_no " &
          "ORDER BY dt.dt_item_type ASC"
            Dim jsonData = api.Load_dataSQLite(Sql)
            MsgBox(jsonData) ' This is just for debugging purposes, you might want to remove it
            Return jsonData
        Catch ex As Exception
            MsgBox("Error Files ModelSqliteDefect In Function mGetdefectdetailnc")
        End Try
        ' No need to close the connection here; it's already closed after exiting the Using block
        Return 0
    End Function
    Public Shared Function mSqliteGetdefectdetailncSpc(arrayWI As Array, lengthDataPlan As Integer, dtLot As String, Type As String, startSeq As Integer)
        Try
            Dim api = New api()
            Dim requestFunction As New JObject()
            Dim jArrayWI As New JArray(arrayWI)
            requestFunction("arrWi") = jArrayWI
            requestFunction("lengthDataPlan") = lengthDataPlan
            requestFunction("startseq") = startSeq
            requestFunction("dfLot") = dtLot
            requestFunction("dfType") = Type

            Dim Sql = "

"








            Dim url As String = "http://" & Backoffice_model.svApi & "/apiShopfloor_test/getDatadefectSpecial/getDefectnc"
            Dim rsData = api.Load_dataPOST(url, requestFunction)
            Console.WriteLine(rsData)
            If rsData <> "0" Then
                Return rsData
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error Files ModelSqliteDefect in Function mSqliteGetdefectdetailncSpc = " & ex.Message)
            Return False
        End Try
    End Function


End Class
