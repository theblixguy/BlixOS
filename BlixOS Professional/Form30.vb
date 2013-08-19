Public Class Form30
    Dim isMouseDown As Integer
    Dim MyX, MyY As Integer
    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.URL = "I:\test.wmv"
    End Sub

    Private Sub Form30_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        isMouseDown = 1
        MyX = e.X : MyY = e.Y
        Me.Cursor = Cursors.NoMove2D
    End Sub

    Private Sub Form30_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If isMouseDown = 1 Then
            If e.X > MyX Then Me.Left = Me.Left + 1
            If e.X < MyX Then Me.Left = Me.Left - 1
            If e.Y > MyY Then Me.Top = Me.Top + 1
            If e.Y < MyY Then Me.Top = Me.Top - 1

        End If
    End Sub


    Private Sub Form30_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        isMouseDown = 0
        Me.Cursor = Cursors.Default
    End Sub
End Class
