Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Globalization
Imports System.Data
Public Class OEE
    Public Shared Function OEE_GET_TARGET(shift As String, WI As String, actual As String)
        Dim api = New api()
        Dim TarGet = api.Load_data("http://" & Backoffice_model.svApi & "/API_NEW_FA/GET_OEE/GET_TARGET?shift=" & shift & "&WI=" & WI & "&actual=" & actual)
        Return TarGet
    End Function
End Class
