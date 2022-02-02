
Imports Microsoft.VisualBasic.CompilerServices
Public Class frmSettings

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        GunaComboBox1.SelectedItem = "Normal"

        MSGICON.SelectedIndex = 3
        MSGBUTTON.SelectedIndex = 3
    End Sub

    Private Sub GunaWinSwitch1_CheckedChanged(sender As Object, e As EventArgs)
        If Guna2ToggleSwitch1.Checked Then
            TextBox11.Enabled() = True
            TextBox12.Enabled() = True
            TextBox13.Enabled() = True

        Else
            TextBox11.Enabled() = False
            TextBox12.Enabled() = False
            TextBox13.Enabled() = False
        End If
    End Sub

    Private Sub frmSettings_FormClosing(sender As Object, A As FormClosingEventArgs) Handles MyBase.FormClosing
        If A.CloseReason <> CloseReason.FormOwnerClosing Then
            Me.Hide()
            A.Cancel = True
        End If
    End Sub


    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs)
        If Guna2ToggleSwitch1.Checked Then
            TextBox11.Enabled() = True
            TextBox12.Enabled() = True
            TextBox13.Enabled() = True

        Else
            TextBox11.Enabled() = False
            TextBox12.Enabled() = False
            TextBox13.Enabled() = False
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)
        GunaTextBox3.Text = Randomization.RandomPassword.Generate(15, 15)
    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged_1(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked Then
            TextBox11.Enabled() = True
            TextBox12.Enabled() = True
            TextBox13.Enabled() = True

        Else
            TextBox11.Enabled() = False
            TextBox12.Enabled() = False
            TextBox13.Enabled() = False
        End If
    End Sub
    Public Function MsgboxSettings(A As Integer, B As Integer) As String
        Dim str As String
        If A = 0 Then
            str = Conversions.ToString(2)
        ElseIf A = 1 Then
            str = Conversions.ToString(3)
        ElseIf A = 2 Then
            str = Conversions.ToString(5)
        ElseIf A = 3 Then
            str = Conversions.ToString(1)
        ElseIf A = 4 Then
            str = Conversions.ToString(4)
        ElseIf A = 5 Then
            str = Conversions.ToString(0)
        End If
        Dim str2 As String
        If B = 0 Then
            str2 = Conversions.ToString(64)
        ElseIf B = 1 Then
            str2 = Conversions.ToString(32)
        ElseIf B = 2 Then
            str2 = Conversions.ToString(48)
        ElseIf B = 3 Then
            str2 = Conversions.ToString(16)
        ElseIf B = 4 Then
            str2 = Conversions.ToString(0)
        End If
        Return str2 + "|" + str
    End Function
    Private Sub Guna2TrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2TrackBar1.Scroll
        GunaTextBox3.Text = Randomization.RandomPassword.Generate(15, 15)
    End Sub

    Private Sub GunaButton1_Click_1(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim msg As String() = Strings.Split((Me.MsgboxSettings(Me.MSGBUTTON.SelectedIndex, Me.MSGICON.SelectedIndex)).ToString, "|")
        Dim icon As MessageBoxIcon = Integer.Parse(msg(0))
        Dim buttons As MessageBoxButtons = Integer.Parse(msg(1))
        MessageBox.Show(Me.textbox16.Text, Me.textbox15.Text, buttons, icon)
    End Sub

    Private Sub Guna2ToggleSwitch8_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch8.CheckedChanged
        If Guna2ToggleSwitch8.Checked = True Then
            textbox15.Enabled = True
            textbox16.Enabled = True
            MSGBUTTON.Enabled = True
            MSGICON.Enabled = True
            GunaButton1.Enabled = True
        Else
            textbox15.Enabled = False
            textbox16.Enabled = False
            MSGBUTTON.Enabled = False
            MSGICON.Enabled = False
            GunaButton1.Enabled = False
        End If
    End Sub

    Private Sub Guna2ToggleSwitch9_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch9.CheckedChanged
        If Guna2ToggleSwitch9.Checked Then
            GunaTextBox4.Enabled = True
        Else
            GunaTextBox4.Enabled = False
        End If
    End Sub

    Private Sub Guna2ToggleSwitch6_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch6.CheckedChanged
        If Guna2ToggleSwitch6.Checked Then
            GunaTextBox1.Enabled = True
        Else
            GunaTextBox1.Enabled = False
        End If
    End Sub
End Class