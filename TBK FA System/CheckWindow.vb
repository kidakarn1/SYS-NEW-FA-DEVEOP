Imports System
Imports System.Runtime.InteropServices
Imports NationalInstruments.DAQmx
Public Class CheckWindow
    Public Shared digitalReadTask_new_dio As New Task()
    Public Shared reader_new_dio As DigitalSingleChannelReader
    Public Shared data_new_dio As UInt32
    Public Function Per_CheckCounter()
        Dim rsWindows As Boolean = Working_Pro.CheckOs
        Working_Pro.rsWindow = rsWindows
        ' This call is required by the designer.
        ' Add any initialization after the InitializeComponent() call.
    End Function
    Public Function count_NIMAX()
        Try
            If Working_Pro.rsWindow Then
                Try
                    digitalReadTask_new_dio.DIChannels.CreateChannel(
            "Dev1/port0",
            "port0",
          ChannelLineGrouping.OneChannelForAllLines)
                Catch ex As Exception

                End Try
                reader_new_dio = New DigitalSingleChannelReader(digitalReadTask_new_dio.Stream)
                Working_Pro.Timer_new_dio.Start()
            End If
            Return "OK"
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "Please Check USB DIO"
            ' MsgBox(" Please Check USB DIO")
        End Try
    End Function


End Class
