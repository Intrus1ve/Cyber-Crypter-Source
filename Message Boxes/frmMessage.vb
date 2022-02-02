Public Class frmMessage

    Private Sub frmMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Hide()

    End Sub
End Class