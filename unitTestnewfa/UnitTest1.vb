Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Windows.Form
Imports TBK_FA_System
<TestClass()> Public Class UnitTest1
    <TestMethod()> Public Sub TestMethod1()
        Dim md = New modelDefect()
        Dim lwi = "5100287083"
        Dim lLot = "BK12"
        Dim lSeq = "30"
        Dim lPartno = "J107-11820-RM"
        Dim dfType = "1"
        Dim rs = md.mGetDatadefectcodeprint(lwi, lLot, lSeq, lPartno, dfType)
        Assert.AreNotEqual("0", rs)
    End Sub
End Class