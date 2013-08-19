Public Class Form24

    Private Sub KryptonButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Me.Hide()
        Form25.Show()
    End Sub

    Private Sub Form24_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 444
        Me.Activate()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Me.Height = 444 Then
            Me.Height = 485
        ElseIf Me.Height = 485 Then
            Me.Height = 444
        End If
    End Sub
End Class
