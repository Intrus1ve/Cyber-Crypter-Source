Imports System.Management
Imports System.Net
Imports System.Threading
Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Text
Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports System.Net.NetworkInformation


Public Class frmLogin
#Region "API"

#End Region
    Dim cpuInfo As String
    Function GetHWID()
        Dim mc As New ManagementClass("win32_processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances
        For Each mo As ManagementObject In moc
            If cpuInfo = "" Then
                cpuInfo = mo.Properties("processorID").Value.ToString
                Exit For
            End If
        Next
        Return cpuInfo
    End Function

    Dim MyIP As String
    Private Function GetExternalIp() As String
        Try
            Dim ExternalIP As String
            ExternalIP = (New WebClient()).DownloadString("http://checkip.dyndns.org/")
            ExternalIP = (New Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")) _
                         .Matches(ExternalIP)(0).ToString()
            Return ExternalIP
        Catch
            Return Nothing
        End Try
    End Function

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Me.WindowState = FormWindowState.Normal
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size
        Dim ZGQAk As Mutex = New Mutex(False, "SINGLE_INSTANCE_APP_MUTEX")
        If (ZGQAk.WaitOne(0, False) = False) Then
            ZGQAk.Close()
            ZGQAk = Nothing
            Environment.Exit(1)
        End If

        GunaTextBox1.Text = Get_HWID()
        GunaComboBox1.SelectedItem = "English"

    End Sub

    Public Function EncryptString(ByVal key As String, ByVal plainText As String) As String
        Dim iv As Byte() = New Byte(15) {}
        Dim array As Byte()

        Using aes As Aes = aes.Create()
            aes.Key = Encoding.UTF8.GetBytes(key)
            aes.IV = iv
            Dim encryptor As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)

            Using memoryStream As MemoryStream = New MemoryStream()

                Using cryptoStream As CryptoStream = New CryptoStream(CType(memoryStream, Stream), encryptor, CryptoStreamMode.Write)

                    Using streamWriter As StreamWriter = New StreamWriter(CType(cryptoStream, Stream))
                        streamWriter.Write(plainText)
                    End Using

                    array = memoryStream.ToArray()
                End Using
            End Using
        End Using

        Return Convert.ToBase64String(array)
    End Function

    Public Function Get_HWID() As String
        'Information Handler
        Dim hw As New clsComputerInfo
        'Decalre variables
        Dim hdd, cpu, mb, mac As String
        'Get all the values
        cpu = hw.GetProcessorId()
        hdd = hw.GetVolumeSerial("C")
        mb = hw.GetMotherBoardID()
        mac = hw.GetMACAddress()
        'Generate the hash
        Dim hwid As String = GenerateSHA512String(mac + My.Computer.Name)
        Return EncryptString("165df1b98dfb198fdagb9v8d1afg9aer", mac + My.Computer.Name)
        Return hwid
    End Function
    Public Shared Function GenerateSHA512String(ByVal inputString) As String
        Dim sha512 As SHA512 = SHA512Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha512.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next
        Return stringBuilder.ToString()
    End Function



    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim bytes As Byte() = New Byte(1023) {}
            Try

                Dim remoteEP As IPEndPoint = New IPEndPoint(IPAddress.Parse("20.52.33.123"), 1091)
                Dim senderr As Socket = New Socket(remoteEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
                Try
                    senderr.Connect(remoteEP)
                    Dim msg As Byte() = Encoding.ASCII.GetBytes("qq; " & Get_HWID() & "<end_of_line>")
                    Dim bytesSent As Integer = senderr.Send(msg)
                    Dim bytesRec As Integer = senderr.Receive(bytes)
                    Dim a As String = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                    If a.Contains("true") Then
                        Me.Hide()
                        frmMain.Show()
                        senderr.Shutdown(SocketShutdown.Both)
                        senderr.Close()
                    Else
                        Environment.Exit(1)
                    End If
                Catch e4 As Exception
                End Try
            Catch e5 As Exception
            End Try
        Catch ex As Exception
            DeleteLicense()
        End Try

    End Sub

    'Public Function OS()
    '    Try
    '        ServicePointManager.Expect100Continue = True
    '        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

    '        Dim bytes As Byte() = New Byte(1023) {}
    '        Try
    '            ServicePointManager.Expect100Continue = True
    '            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
    '            Dim remoteEP As IPEndPoint = New IPEndPoint(IPAddress.Parse("20.52.33.123"), 2222)
    '            ServicePointManager.Expect100Continue = True
    '            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

    '            Dim senderr As Socket = New Socket(remoteEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
    '            Try
    '                senderr.Connect(remoteEP)
    '                Dim msg As Byte() = Encoding.ASCII.GetBytes("qq; " & getCpuId() & "<end_of_line>")
    '                Dim bytesSent As Integer = senderr.Send(msg)
    '                Dim bytesRec As Integer = senderr.Receive(bytes)
    '                Dim a As String = Encoding.ASCII.GetString(bytes, 0, bytesRec)
    '                If a.Contains("true") Then
    '                    Me.Hide()
    '                    frmMain.Show()
    '                    senderr.Shutdown(SocketShutdown.Both)
    '                    senderr.Close()
    '                Else
    '                    Environment.Exit(1)
    '                End If
    '            Catch e4 As Exception
    '            End Try
    '        Catch e5 As Exception
    '        End Try
    '    Catch ex As Exception
    '        DeleteLicense()
    '    End Try
    'End Function
    Public Function DeleteLicense()
        Try
            Environment.Exit(1)
        Catch ex As Exception

        End Try
    End Function

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Try
            If GunaTextBox1.Text = "" Then
            Else
                Clipboard.SetText(GunaTextBox1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
Public Class clsComputerInfo
    Friend Function GetProcessorId() As String
        Dim strProcessorId As String = String.Empty
        Dim query As New SelectQuery("Win32_processor")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strProcessorId = info("processorId").ToString()
        Next
        Return strProcessorId
    End Function
    Friend Function GetMACAddress() As String
        Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim MACAddress As String = String.Empty
        For Each mo As ManagementObject In moc
            If (MACAddress.Equals(String.Empty)) Then
                If CBool(mo("IPEnabled")) Then MACAddress = mo("MacAddress").ToString()
                mo.Dispose()
            End If
            MACAddress = MACAddress.Replace(":", String.Empty)
        Next
        Return MACAddress
    End Function
    Friend Function GetVolumeSerial(Optional ByVal strDriveLetter As String = "C") As String
        Dim disk As ManagementObject = New ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", strDriveLetter))
        disk.Get()
        Return disk("VolumeSerialNumber").ToString()
    End Function
    Friend Function GetMotherBoardID() As String
        Dim strMotherBoardID As String = String.Empty
        Dim query As New SelectQuery("Win32_BaseBoard")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strMotherBoardID = info("SerialNumber").ToString()
        Next
        Return strMotherBoardID
    End Function
End Class