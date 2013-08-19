Public Class Form21

    Private Sub Form21_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form3.sinf.Visible = False
    End Sub

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.sinf.Visible = True
    End Sub
End Class
