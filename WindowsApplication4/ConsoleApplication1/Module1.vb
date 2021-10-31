Imports System.Runtime.InteropServices

Module Module1
    <DllImport("G:\vb and fortran\array\ftest\ftest\Debug\ftest.dll", EntryPoint:="Subtract", CallingConvention:=CallingConvention.Cdecl)>
    Public Function Subtract(ByRef A As Double(), ByRef B As Double(), ByRef C As Double(), ByVal N As Integer) As Double
    End Function
    Sub Main()
        'Dim I As Integer
        Dim N As Integer
        Dim ValueA() As Double
        Dim ValueB() As Double
        Dim ValueC() As Double
        N = 5
        ReDim ValueA(N - 1), ValueB(N - 1), ValueC(N - 1)
        Call Subtract(ValueA, ValueB, ValueC, N)
        Console.WriteLine(ValueC)
        Console.ReadLine()
    End Sub
End Module
