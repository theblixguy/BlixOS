Public Class Form20

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "actapi.dll", "ACTIVATED_YES", False)
        Me.Hide()
    End Sub

    Private Sub KryptonHeader1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles KryptonHeader1.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Activate()
    End Sub
End Class
