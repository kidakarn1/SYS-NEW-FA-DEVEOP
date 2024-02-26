Imports System.Speech.Synthesis
Imports System.Globalization
Imports System.Web.Script.Serialization

Public Class RobotApppSuport
    Private synth As New SpeechSynthesizer()
    Public Sub loadMain()
        ' ตั้งค่าการใช้งาน SpeechSynthesizer
        synth.Volume = 100 ' ระดับเสียง (0-100)
        synth.Rate = 0 ' ความเร็วการพูด (-10 ถึง 10)
        synth.SetOutputToDefaultAudioDevice()
        ' List available voices and their supported languages
        For Each voice As InstalledVoice In synth.GetInstalledVoices()
            Dim voiceInfo As VoiceInfo = voice.VoiceInfo
            Console.WriteLine("Name: " & voiceInfo.Name)
            Console.WriteLine("Culture: " & voiceInfo.Culture.ToString())
            Console.WriteLine("Description: " & voiceInfo.Description)
            Console.WriteLine()
        Next
        ' Select a Thai voice
        synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, New CultureInfo("th-TH"))
        ' Speak a Thai phrase
        synth.SpeakAsync("ยินดีต้อนรับ สู่ระบบ เอฟ เอ")
        synth.SpeakAsync("หากมีอะไรให้ชั้นช่วยเหลือ โปรด บอกชั้นได้")
        realTimeRequest()
    End Sub
    Public Async Function realTimeRequest() As Task
        Task.Delay(10000).ContinueWith(Sub(task)
                                           Try
                                               Dim NumberTopices As Integer = 1
                                               Dim iir_title = backofficeRobot.loadRequest()
                                               Console.WriteLine(iir_title)
                                               If iir_title <> "0" Then
                                                   Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(iir_title)
                                                   For Each item As Object In dict2
                                                       NumberTopices = 1
                                                       synth.SpeakAsync("ปัญหาที่คุณเจอ คือ  " & item("iir_title").ToString())
                                                       Dim solutionData = backofficeRobot.loadsolution(item("iir_title").ToString())
                                                       If solutionData <> "0" Then
                                                           synth.SpeakAsync("ทางแก้ไขปัญหามีดังนี้")
                                                           Console.WriteLine("ready1")
                                                           Console.WriteLine(solutionData)
                                                           Console.WriteLine("ready2")
                                                           Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(solutionData)
                                                           For Each itemSolution As Object In dict3
                                                               synth.SpeakAsync("1")
                                                               NumberTopices = NumberTopices + 1
                                                           Next
                                                       Else
                                                           synth.SpeakAsync("ไม่พบทางแก้ไขปัญหา")
                                                       End If
                                                   Next
                                               End If
                                           Catch ex As Exception
                                           End Try
                                       End Sub, TaskScheduler.FromCurrentSynchronizationContext())
    End Function
End Class