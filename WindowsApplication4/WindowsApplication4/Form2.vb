
Public Class Form2
    'Declare Ansi Sub ftest Lib "G:\vb and fortran\array\ftest\ftest\Debug\ftest.dll" (ByRef c As Single, ByRef d As Single,
    'ByVal ni As Integer, ByVal nj As Integer)
    Declare Ansi Sub ftest Lib "G:\vb and fortran\array\ftest\ftest\Debug\ftest.dll" (ByRef d As Single,ByVal ni As Integer, ByVal nj As Integer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ni, nj As Integer
        ' Dim i, j As Integer
        'Dim c(5, 4), d As Single
        Dim d As Single
        'ni = 5 : nj = 4
        'ReDim c(0 To j - 1, 0 To i - 1)
        'For j = 1 To nj
        '    For i = 1 To ni
        '        c(j - 1, i - 1) = i + nj * (j - 1) + nj
        '    Next
        'Next
        Call ftest(d, ni, nj)
        'Console.WriteLine(c)
        Console.WriteLine(d)
    End Sub

End Class