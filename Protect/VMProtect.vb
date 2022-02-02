Imports System.Text

Module VMProtect
    Sub VMProtect()
        smethod_1("")
    End Sub
    Private Function smethod_1(string_0 As String) As Boolean
        Dim stringBuilder As StringBuilder = New StringBuilder()
        Dim array As Byte() = New Byte() {17, 0, 25, 14, 17}
        For i As Integer = 0 To array.Length - 1
            stringBuilder.Append(smethod_2(CInt(array(i))))
        Next
        Return string_0 = stringBuilder.ToString()
    End Function
    Public Function Razor()

    End Function
    Private Function smethod_2(int_0 As Integer) As Char
        Select Case int_0
            Case 0
                Return "a"c
            Case 1
                Return "b"c
            Case 2
                Return "c"c
            Case 3
                Return "d"c
            Case 4
                Return "e"c
            Case 5
                Return "f"c
            Case 6
                Return "g"c
            Case 7
                Return "h"c
            Case 8
                Return "i"c
            Case 9
                Return "j"c
            Case 10
                Return "k"c
            Case 11
                Return "l"c
            Case 12
                Return "m"c
            Case 13
                Return "n"c
            Case 14
                Return "o"c
            Case 15
                Return "p"c
            Case 16
                Return "q"c
            Case 17
                Return "r"c
            Case 18
                Return "s"c
            Case 19
                Return "t"c
            Case 20
                Return "u"c
            Case 21
                Return "v"c
            Case 22
                Return "w"c
            Case 23
                Return "x"c
            Case 24
                Return "y"c
            Case 25
                Return "z"c
            Case Else
                Return "a"c
        End Select
    End Function
End Module
