Public Class frmError

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Hide()
        Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=48159")
    End Sub

    Private Sub frmError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
End Class