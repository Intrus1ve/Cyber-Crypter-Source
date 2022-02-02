Imports System.Runtime.InteropServices

Module VM


    <DllImport("user32.dll")> _
    Private Function ReleaseDC(ByVal hWnd As IntPtr, _
   ByVal hDc As IntPtr) As Boolean
    End Function

    <DllImport("gdi32.dll")> _
    Private Function DeleteDC(ByVal hDc As IntPtr) As IntPtr
    End Function

    <DllImport("gdi32.dll")> _
    Private Function DeleteObject(ByVal hDc As IntPtr) As IntPtr
    End Function

    <DllImport("gdi32.dll")> _
    Private Function CreateCompatibleBitmap(ByVal hdc As IntPtr, _
   ByVal nWidth As Integer, ByVal nHeight As Integer) As IntPtr
    End Function

    <DllImport("gdi32.dll")> _
    Private Function CreateCompatibleDC(ByVal hdc As IntPtr) As IntPtr
    End Function

    <DllImport("gdi32.dll")> _
    Private Function SelectObject(ByVal hdc As IntPtr, _
   ByVal bmp As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Public Function GetDesktopWindow() As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Public Function GetWindowDC(ByVal ptr As IntPtr) As IntPtr
    End Function
    Sub VM()

    End Sub
End Module
