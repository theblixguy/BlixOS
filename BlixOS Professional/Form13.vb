Public Class Form13

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = DesktopBounds.Width
        Me.Height = DesktopBounds.Height
        Label1.Visible = True
    End Sub

    Private Sub Form13_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Cursor.Hide()
        Timer1.Enabled = True
        Label1.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cursor.Show()
        Timer1.Enabled = False
        Me.Close()
    End Sub
End Class