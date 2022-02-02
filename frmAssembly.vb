Public Class frmAssembly
#Region "ASSEMBLY"
    Dim FileTitle As String
    Dim FileDescription As String
    Dim FileCompany As String
    Dim Fileproduct As String
    Dim Filecopyright As String
    Dim Fileversion1 As Integer
    Dim Fileversion2 As Integer
    Dim Fileversion3 As Integer
    Dim Fileversion4 As Integer
    Sub ReadAssembly(ByVal Filepath As String)
        Dim f As FileVersionInfo = FileVersionInfo.GetVersionInfo(Filepath)
        FileTitle = f.InternalName
        FileDescription = f.FileDescription
        FileCompany = f.CompanyName
        Fileproduct = f.ProductName
        Filecopyright = f.LegalCopyright
        Dim version As String()
        If f.FileVersion.Contains(",") Then
            version = f.FileVersion.Split(","c)
        Else
            version = f.FileVersion.Split("."c)
        End If
        Try
            Fileversion1 = version(0)
            Fileversion2 = version(1)
            Fileversion3 = version(2)
            Fileversion4 = version(3)
        Catch ex As Exception
        End Try
    End Sub
#End Region
    Private Sub frmAssembly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Try
            Dim Open As New OpenFileDialog
            Open.Filter = "All Files (*.*)|*.*"
            If Open.ShowDialog = vbOK Then
                ReadAssembly(Open.FileName)
                TextBoxTitle.Text = FileTitle
                TextBoxDescription.Text = FileDescription
                TextBoxCompany.Text = FileCompany
                TextBoxProduct.Text = Fileproduct
                TextBoxCopyright.Text = Filecopyright
                num1.Text = Fileversion1
                num2.Text = Fileversion2
                num3.Text = Fileversion3
                num4.Text = Fileversion4
            End If
        Catch Complexious As Exception
        End Try
    End Sub



    Private Sub frmAssembly_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason <> CloseReason.FormOwnerClosing Then
            Me.Hide()
            e.Cancel = True
        End If
    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged_1(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked Then
            TextBoxTitle.Enabled = True
            TextBoxDescription.Enabled = True
            TextBoxCompany.Enabled = True
            TextBoxProduct.Enabled = True
            TextBoxCopyright.Enabled = True
            num1.Enabled = True
            num2.Enabled = True
            num3.Enabled = True
            num4.Enabled = True
            GunaButton2.Enabled = True

        Else
            TextBoxTitle.Enabled = False
            TextBoxDescription.Enabled = False
            TextBoxCompany.Enabled = False
            TextBoxProduct.Enabled = False
            TextBoxCopyright.Enabled = False
            num1.Enabled = False
            num2.Enabled = False
            num3.Enabled = False
            num4.Enabled = False
            GunaButton2.Enabled = False
        End If
    End Sub
End Class