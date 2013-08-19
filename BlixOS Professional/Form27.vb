Public Class Form27

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Me.Hide()
        Form26.Show()
    End Sub

    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 444
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If Me.Height = 444 Then
            Me.Height = 485
        ElseIf Me.Height = 485 Then
            Me.Height = 444
        End If
    End Sub
End Class
