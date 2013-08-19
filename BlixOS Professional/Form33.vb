Public Class Form33

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        If KryptonTextBox1.Text = "wincompat" Then
            Form3.winmode.Visible = True
            Form32.Show()
            Me.Close()

        ElseIf KryptonTextBox1.Text = "gbar" Then
            Form3.Panel1.Visible = True
        ElseIf KryptonTextBox1.Text = "gbar -hide" Then
            Form3.Panel1.Visible = False
        Else
            Me.Hide()
            MsgBox("Blix cannot find '" & KryptonTextBox1.Text.Trim & "'. Make sure you typed the name correctly, and then try again.", MsgBoxStyle.Critical, "Run")
            Me.Show()
            Me.Activate()
        End If
    End Sub

    Private Sub Form33_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
