Public Class frmSelect

    Private Sub frmSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
    Dim Save As String = ""
    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        If frmMain.TextBox1.Text = "" Then
        Else

            Me.Hide()
            frmMain.newversion()
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If frmMain.TextBox1.Text = "" Then
        Else

            Me.Hide()
            frmMain.oldversion()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs)

    End Sub
End Class