Imports System.Data.SQLite
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class ModelSqliteDefect
    Public Shared Function UpdateStatusCloselotSqlite(status As String, pwi_id As String)
        Dim api As New api
        Try
            Dim Sql = " Update defect_transactions set dt_status_close_lot = '" & status & "' where pwi_id = '" & pwi_id & "'"
            Dim jsonData As String = api.Load_dataSQLite(Sql)
            Return jsonData

        Catch ex As Exception
            MsgBox("Error Files ModelSqliteDefect In Function UpdateStatusCloselotSqlite")
        End Try
    End Function
    Public Function mSqliteGetdatachildpartsummaryfg(dtWino As String, dtSeq As String, dtLot As String)
        Dim api As New api
        Try
            Dim Sql = " 
                SELECT
						dt.dt_item_cd,
						dt.dt_code,
						SUM ( dt.dt_qty ) AS total_nc,
						dt.dt_item_type ,
						dt.dt_name_en AS description ,
						dt.dt_type,
						dt.dt_name_en AS defect_name,
                        dt.pwi_id
					FROM
						defect_transactions AS dt
					WHERE
						dt.dt_wi_no = '" & dtWino & "' 
						AND dt.dt_seq_no = '" & dtSeq & "' 
						AND dt.dt_lot_no = '" & dtLot & "' 
						AND dt.dt_status_flg = '1' 
						AND dt.dt_item_type = '1'
						AND dt.dt_qty <> '0'
					GROUP BY
						dt.dt_item_cd,
						dt.dt_code,
						dt.dt_item_type,
						dt.dt_name_en , 
						dt.dt_type,
						dt.dt_name_en,
                        dt.pwi_id
					ORDER BY
						dt.dt_item_type ASC
"
            Dim jsonData As String = api.Load_dataSQLite(Sql)
            If jsonData <> "0" Then
                Return jsonData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("Error Files ModelSqliteDefect In Function mSqliteGetdatachildpartsummaryfg")
        End Try
        ' No need to close the connection here; it's already closed after exiting the Using block
        Return 0
    End Function
    Public Function mSqliteGetdatachildpartsummarychild(dtWino As String, dtSeq As String, dtLot As String)
        Dim api As New api
        Try
            Dim Sql = " 
                SELECT
						dt.dt_item_cd,
						dt.dt_code,
						SUM ( dt.dt_qty ) AS total_nc,
						dt.dt_item_type ,
						dt.dt_name_en AS description ,
						dt.dt_type,
						dt.dt_name_en AS defect_name,
                        dt.pwi_id
					FROM
						defect_transactions AS dt
					WHERE
						dt.dt_wi_no = '" & dtWino & "' 
						AND dt.dt_seq_no = '" & dtSeq & "' 
						AND dt.dt_lot_no = '" & dtLot & "' 
						AND dt.dt_status_flg = '1' 
						AND dt.dt_item_type = '2'
						AND dt.dt_qty <> '0'
					GROUP BY
						dt.dt_item_cd,
						dt.dt_code,
						dt.dt_item_type,
						dt.dt_type,
                        dt.dt_name_en,
                        dt.pwi_id
					ORDER BY
						dt.dt_item_type ASC
"
            Console.WriteLine(Sql)
            Dim jsonData As String = api.Load_dataSQLite(Sql)
            If jsonData <> "0" Then
                Return jsonData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("Error Files ModelSqliteDefect In Function mSqliteGetdatachildpartsummarychild")
        End Try
        ' No need to close the connection here; it's already closed after exiting the Using block
        Return 0
    End Function
    Public Shared Function mSqliteGetdatachildpartsummaryfgSpc(arrayWI As Array, lengthDataPlan As Integer, dtLot As String, startseq As Integer)
        Try
            Dim api = New api()
            Dim tmpseq As Integer = startseq
            Dim condition As String = ""
            Dim conditionseq As String = ""
            Dim index As Integer = 0
            For Each item As String In arrayWI
                tmpseq += 1
                condition &= item
                conditionseq &= tmpseq
                index += 1
                If index < lengthDataPlan Then
                    condition &= ","
                    conditionseq &= ","
                End If
            Next
            Dim sql = "
                    SELECT
						dt.dt_item_cd,
						dt.dt_code,
						SUM ( dt.dt_qty ) AS total_nc,
						dt.dt_item_type ,
						dt.dt_name_en AS description ,
						dt.dt_type,
						dt.dt_name_en AS defect_name,
						dt.dt_wi_no
					FROM
						defect_transactions AS dt
					WHERE
						( 
                            dt.dt_wi_no  in (" & condition & ")
                        ) 
						AND 
						(
							dt.dt_seq_no in (" & conditionseq & ")
						)
						AND dt.dt_lot_no = '" & dtLot & "' 
						AND dt.dt_status_flg = '1' 
						AND dt.dt_item_type = '1'
						AND dt.dt_qty <> '0'
					GROUP BY
						dt.dt_item_cd,
						dt.dt_code,
						dt.dt_item_type,
						dt.dt_type,
						dt.dt_name_en,
						dt.dt_wi_no
					ORDER BY
						dt.dt_item_type ASC
            "
            Console.WriteLine(sql)
            Dim jsonData As String = api.Load_dataSQLite(sql)
            If jsonData <> "0" Then
                Return jsonData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check ModelSqliteDefect in Function mSqliteGetdatachildpartsummaryfgSpc = " & ex.Message)
            Return "0"
        End Try
    End Function


    Public Shared Function mSqliteGetdatachildpartsummarychildSpc(arrayWI As Array, lengthDataPlan As Integer, dtLot As String, startseq As Integer)
        Try
            Dim api = New api()
            Dim tmpseq As Integer = startseq
            Dim condition As String = ""
            Dim conditionseq As String = ""
            Dim index As Integer = 0
            For Each item As String In arrayWI
                tmpseq += 1
                condition &= item
                conditionseq &= tmpseq
                index += 1
                If index < lengthDataPlan Then
                    condition &= ","
                    conditionseq &= ","
                End If
            Next
            Dim sql = "
                   SELECT
						dt.dt_item_cd,
						dt.dt_code,
						SUM ( dt.dt_qty ) AS total_nc,
						dt.dt_item_type ,
						dt.dt_name_en AS description ,
						dt.dt_type,
						dt.dt_name_en AS defect_name , 
						dt.dt_wi_no
					FROM
						defect_transactions AS dt
					WHERE
						( 
                            dt.dt_wi_no in (" & condition & ")
                        ) 
						AND 
						(
							dt.dt_seq_no in (" & conditionseq & ")
						)
						AND dt.dt_lot_no = '" & dtLot & "' 
						AND dt.dt_status_flg = '1' 
						AND dt.dt_item_type = '2'
						AND dt.dt_qty <> '0'
					GROUP BY
						dt.dt_item_cd,
						dt.dt_code,
						dt.dt_item_type,
						dt.dt_type,
						dt.dt_name_en,
						dt.dt_wi_no
					ORDER BY
						dt.dt_item_type ASC
            "
            Console.WriteLine(sql)
            Dim jsonData As String = api.Load_dataSQLite(sql)
            If jsonData <> "0" Then
                Return jsonData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelSqliteDefect in Function mSqliteGetdatachildpartsummarychildSpc = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function


    Public Shared Function mSqlitegroupDataWiSpc(WI As String, seq As String, dtLot As String)
        Try
            Dim requestFunction As New JObject()
            Dim api = New api()
            Dim sql = "
                    SELECT 
				                    dt_wi_no, 
				                    dt_seq_no,
				                    (
					                    select IFNULL(sum(dt_qty) , 0) 
					                    from  defect_transactions 
					                    where 
						                    dt_status_flg = '1' AND
						                    dt_type = '2' AND 
						                    dt_lot_no ='" & dtLot & "' AND
						                    dt_wi_no in (" & WI & ") AND
						                    dt_seq_no in (" & seq & ")  AND
						                    dt_item_type ='1'
				                    ) AS TotaldfNC ,
				                    (
					                    select IFNULL(sum(dt_qty) , 0) 
					                    from  defect_transactions 
					                    where 
						                    dt_status_flg = '1' AND
						                    dt_type = '1' AND 
						                    dt_lot_no ='" & dtLot & "' AND
						                    dt_wi_no in (" & WI & ") AND
						                    dt_seq_no in (" & seq & ")  AND
						                    dt_item_type ='1'

				                    ) AS TotaldfNG ,
				                    sum( dt_qty ) AS totalDEFECT 
				                    FROM
					                    defect_transactions 
				                    WHERE
					                    dt_status_flg = '1' AND
					                    dt_lot_no ='" & dtLot & "' AND
					                    dt_wi_no in (" & WI & ") AND
					                    dt_seq_no in (" & seq & ")  AND
					                    dt_item_type ='1'
				                    GROUP BY
					                    dt_wi_no,
					                    dt_seq_no
            "
            Console.WriteLine(sql)
            Dim jsonData As String = api.Load_dataSQLite(sql)
            If jsonData <> "0" Then
                Return jsonData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check ModelSqliteDefect in Function mSqlitegroupDataWiSpc = " & ex.Message)
            Return "0"
        End Try
        Return "0"
    End Function

    Public Shared Function mSqliteGetdefectdetailncPartno(dtWino As String, dtSeq As String, dtLot As String, Type As String, PartNo As String)
        Try
            Dim api = New api()
            Dim sql = "
            SELECT
				    IFNULL(SUM(dt.dt_qty) , 0) AS total_nc
				    FROM
					    defect_transactions as dt
			WHERE
				dt.dt_wi_no = '" & dtWino & "' 
				AND dt.dt_seq_no = '" & dtSeq & "' 
				AND dt.dt_lot_no = '" & dtLot & "' 
				AND dt.dt_type = '" & Type & "' 
				And dt.dt_status_flg = '1'
				AND dt.dt_item_cd = '" & PartNo & "'"
            Console.WriteLine(sql)
            Dim jsonData As String = api.Load_dataSQLite(sql)
            If jsonData <> "0" Then
                Dim dcResultdata As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(jsonData)
                For Each items As Object In dcResultdata
                    Return items("total_nc").ToString
                Next
            Else
                Return False
            End If
            ' No need to close the connection here; it's already closed after exiting the Using block
        Catch ex As Exception
            MsgBox("connect Api Faill Please check ModelSqliteDefect in Function mSqliteGetdefectdetailncPartno = " & ex.Message)
            Return False
        End Try
    End Function
    Public Function mSqliteInsertDefectTransection(dt_wi_no As String, dt_line_cd As String, dt_item_cd As String, dt_item_type As String, dt_lot_no As String, dt_seq_no As String, dt_type As String, dt_code As String, dt_qty As String, dtMenu As String, dtActualdate As String, pwi_id As String, dt_name_en As String)
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
            cmd.CommandText = " update defect_transactions set dt_status_flg = '5' where dt_wi_no='" & dtWino & "' and dt_lot_no = '" & dtLotNo & "' and dt_seq_no = '" & dtSeqno & "' and dt_type = '" & dtType & "' and dt_code = '" & dtCode & "' and dt_item_type = '" & ItemType & "' and dt_item_cd = '" & PartNo & "'"
            Console.WriteLine(cmd.CommandText)
            Dim LoadSQL As SQLiteDataReader = cmd.ExecuteReader()
            sqliteConn.Close()
            Return True
        Catch ex As Exception
            '  MsgBox("SQLite Database connect failed. Please contact System System [Function mUpdateaddjust] In File ModelSqliteDefect.")
            Return False
        End Try
    End Function
    Public Shared Function mSqliteGetdefectdetailnc(dfWi As String, dfSeq As String, dfLot As String, dfType As String)
        Dim api As New api
        Try
            Dim Sql = "SELECT dt.dt_item_cd, dt.dt_code, SUM(dt.dt_qty) AS total_nc, dt.dt_name_en ,  dt.dt_item_type, dt.dt_wi_no as dt_wi_no " &
          "FROM defect_transactions as dt " &
          "WHERE dt.dt_wi_no = '" & dfWi & "' " &
          "AND dt.dt_seq_no = '" & dfSeq & "' " &
          "AND dt.dt_lot_no = '" & dfLot & "' " &
          "AND dt.dt_type = '" & dfType & "' " &
          "AND dt.dt_status_flg = '1' " &
          "GROUP BY dt.dt_item_cd, dt.dt_name_en , dt.dt_code, dt.dt_item_type, dt.dt_wi_no " &
          "ORDER BY dt.dt_item_type ASC"
            Console.WriteLine(Sql)
            Dim jsonData As String = api.Load_dataSQLite(Sql)
            Return jsonData
        Catch ex As Exception
            MsgBox("Error Files ModelSqliteDefect In Function mGetdefectdetailnc")
        End Try
        ' No need to close the connection here; it's already closed after exiting the Using block
        Return 0
    End Function
    Public Shared Function mSqliteGetdefectdetailncPartnoSpc(arrayWI As Array, lengthDataPlan As Integer, dtLot As String, Type As String, PartNo As String, dfWiSel As String, dfSeqSel As String)
        Try
            Dim api = New api()
            Dim requestFunction As New JObject()
            Dim jArrayWI As New JArray(arrayWI)
            Dim condition As String = ""
            Dim conditionseq As String = ""
            Dim index As Integer = 0
            Dim sql = "
SELECT
				 IFNULL(SUM(dt.dt_qty) , 0) AS total_nc
				 FROM
					 defect_transactions as dt
			WHERE
				dt.dt_wi_no = '" & dfWiSel & "' 
				AND dt.dt_seq_no = '" & dfSeqSel & "' 
				AND dt.dt_lot_no = '" & dtLot & "' 
				AND dt.dt_type = '" & Type & "' 
				And dt.dt_status_flg = '1'
				AND dt.dt_item_cd = '" & PartNo & "'"
            requestFunction("arrWi") = jArrayWI
            requestFunction("lengthDataPlan") = lengthDataPlan
            requestFunction("dfLot") = dtLot
            requestFunction("Type") = Type
            requestFunction("PartNo") = PartNo
            requestFunction("dfWiSel") = dfWiSel
            requestFunction("dfSeqSel") = dfSeqSel
            Console.WriteLine(sql)
            Dim jsonData As String = api.Load_dataSQLite(sql)
            If jsonData <> "0" Then
                Dim dcResultdata As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(jsonData)
                For Each items As Object In dcResultdata
                    Return items("total_nc").ToString
                Next
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mSqliteGetdefectdetailncPartnoSpc = " & ex.Message)
            Return False
        End Try
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
            Dim tmpseq As Integer = startSeq
            Dim condition As String = ""
            Dim conditionseq As String = ""
            Dim index As Integer = 0
            For Each item As String In arrayWI
                tmpseq += 1
                condition &= item
                conditionseq &= tmpseq
                index += 1
                If index < lengthDataPlan Then
                    condition &= ","
                    conditionseq &= ","
                End If
            Next
            Dim Sql = " SELECT
				dt.dt_item_cd,
				dt.dt_code,
                dt.dt_name_en , 
				SUM (dt.dt_qty) AS total_nc,
				dt.dt_item_type ,
				dt.dt_name_en AS description,
				dt.dt_name_en AS defect_name,
				dt.dt_wi_no,
				dt.dt_seq_no,
				dt.pwi_id
			FROM
				defect_transactions as dt
			WHERE
				(
					dt.dt_wi_no  in (" & condition & ") 
				) 
				AND (
					dt.dt_seq_no  in (" & conditionseq & ")
					) 
				AND dt.dt_lot_no = '" & dtLot & "' 
				AND dt.dt_type = '" & Type & "' 
				And dt.dt_status_flg = '1'
			GROUP BY
				dt.dt_item_cd,
				dt.dt_code,
				dt.dt_item_type ,
				dt.dt_wi_no,
				dt.dt_seq_no,
				dt.pwi_id,
                dt.dt_name_en
				order by dt.dt_item_type asc"
            Console.WriteLine(Sql)
            Dim jsonData As String = api.Load_dataSQLite(Sql)
            If jsonData <> "0" Then
                Return jsonData
            Else
                Return "0"
            End If

            ' Console.WriteLine(rsData)
            ' If rsData <> "0" Then
            ' Return rsData
            ' Else
            ' Return False
            '  End If
        Catch ex As Exception
            MsgBox("Error Files ModelSqliteDefect in Function mSqliteGetdefectdetailncSpc = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mSqliteUpdateaddjust(dtWino As String, dtLotNo As String, dtSeqno As String, dtType As String, dtCode As String, ItemType As String, PartNo As String)
        Try
            Dim api = New api()
            Dim sql = "update defect_transactions set dt_status_flg = '5' where dt_wi_no='" & dtWino & "' and dt_lot_no = '" & dtLotNo & "' and dt_seq_no = '" & dtSeqno & "' and dt_type = '" & dtType & "' and dt_code = '" & dtCode & "' and dt_item_type = '" & ItemType & "' and dt_item_cd = '" & PartNo & "'"
            Console.WriteLine(sql)
            Dim jsonData As String = api.Load_dataSQLite(sql)
            Return jsonData
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mSqliteUpdateaddjust = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mSqliteGetdatachildpartsummarychildgrouppart(dtWino As String, dtSeq As String, dtLot As String, dfType As String)
        Try
            Dim api = New api()
            Dim sql = "SELECT
						dt.dt_item_cd,
						SUM ( dt.dt_qty ) AS total_nc,
						dt.dt_item_type 
					FROM
						defect_transactions AS dt
					WHERE
						dt.dt_wi_no = '" & dtWino & "' 
						AND dt.dt_seq_no = '" & dtSeq & "' 
						AND dt.dt_lot_no = '" & dtLot & "' 
						AND dt.dt_status_flg = '1' 
						AND dt.dt_item_type = '2'
						AND dt.dt_type = '" & dfType & "'
						AND dt.dt_qty <> '0'
					GROUP BY
						dt.dt_item_cd,
						dt.dt_item_type
					ORDER BY
						dt.dt_item_type ASC"
            Console.WriteLine(sql)
            Dim jsonData As String = api.Load_dataSQLite(sql)
            If jsonData <> "0" Then
                Return jsonData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mSqliteGetdatachildpartsummarychildgrouppart = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mSqliteGetdatachildpartsummaryfggrouppart(dtWino As String, dtSeq As String, dtLot As String, dfType As String)
        Try
            Dim api = New api()
            Dim sql = "SELECT
						dt.dt_item_cd,
						SUM ( dt.dt_qty ) AS total_nc,
						dt.dt_item_type 
					FROM
						defect_transactions AS dt
					WHERE
						dt.dt_wi_no = '" & dtWino & "' 
						AND dt.dt_seq_no = '" & dtSeq & "' 
						AND dt.dt_lot_no = '" & dtLot & "' 
						AND dt.dt_status_flg = '1' 
						AND dt.dt_item_type = '1'
						AND dt.dt_type = '" & dfType & "'
						AND dt.dt_qty <> '0'
					GROUP BY
						dt.dt_item_cd,
						dt.dt_item_type
					ORDER BY
						dt.dt_item_type ASC"
            Console.WriteLine(sql)
            Dim jsonData As String = api.Load_dataSQLite(sql)
            If jsonData <> "0" Then
                Return jsonData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelDefect in Function mSqliteGetdatachildpartsummaryfggrouppart = " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function mSqliteGetdatachildpartsummarychildgrouppartAdminAdjust(dfWi As String, dfSeq As String, dfLot As String, dfType As String, ItemCd As String)
        Try
            Dim api = New api()
            Dim sql = "SELECT
						dt.dt_item_cd,
						SUM ( dt.dt_qty ) AS total_nc,
						dt.dt_item_type 
					FROM
						defect_transactions AS dt
					WHERE
						dt.dt_wi_no = '" & dfWi & "' 
						AND dt.dt_seq_no = '" & dfSeq & "' 
						AND dt.dt_lot_no = '" & dfLot & "' 
						AND dt.dt_status_flg = '1' 
						AND dt.dt_item_type = '2'
						AND dt.dt_type = '" & dfType & "'
						AND dt.dt_qty <> '0'
						AND dt.dt_item_cd = '" & ItemCd & "' 
					GROUP BY
						dt.dt_item_cd,
						dt.dt_item_type
					ORDER BY
						dt.dt_item_type ASC"
            Dim jsonData As String = api.Load_dataSQLite(sql)
            If jsonData <> "0" Then
                Return jsonData
            Else
                Return "0"
            End If
        Catch ex As Exception
            MsgBox("connect Api Faill Please check modelSqliteDefect in Function mSqliteGetdatachildpartsummarychildgrouppartAdminAdjust = " & ex.Message)
            Return False
        End Try
    End Function
End Class