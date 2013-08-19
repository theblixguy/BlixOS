Public Class Form29
    Dim isMouseDown As Integer
    Dim MyX, MyY As Integer

    Private Sub A1Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles A1Panel1.MouseDown
        isMouseDown = 1
        MyX = e.X : MyY = e.Y
        Me.Cursor = Cursors.NoMove2D
    End Sub

    Private Sub A1Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles A1Panel1.MouseMove
        If isMouseDown = 1 Then
            If e.X > MyX Then Me.Left = Me.Left + 1
            If e.X < MyX Then Me.Left = Me.Left - 1
            If e.Y > MyY Then Me.Top = Me.Top + 1
            If e.Y < MyY Then Me.Top = Me.Top - 1

        End If
    End Sub

    Private Sub A1Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles A1Panel1.MouseUp
        isMouseDown = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BottomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottomToolStripMenuItem.Click
        Me.Dock = DockStyle.Bottom
    End Sub

    Private Sub DownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownToolStripMenuItem.Click
        Me.Dock = DockStyle.Right
    End Sub

    Private Sub UpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpToolStripMenuItem.Click
        Me.Dock = DockStyle.Left
    End Sub

    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        Me.Dock = DockStyle.Top
    End Sub

    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        Me.Dock = DockStyle.None
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Form16.Show()
        Form16.Activate()
    End Sub

    Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton2.Click
        Form8.Show()
        Form8.Activate()
    End Sub

    Private Sub KryptonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton3.Click
        Form15.Show()
        Form15.Activate()
    End Sub

    Private Sub KryptonButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton4.Click
        FrmMain.Show()
        FrmMain.Activate()
    End Sub

    Private Sub KryptonButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton5.Click
        Form6.Show()
        Form6.Activate()
    End Sub

    Private Sub KryptonButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton6.Click
        Form4.Show()
        Form4.Activate()
    End Sub

    Private Sub KryptonButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton8.Click
        Form9.Show()
        Form9.Activate()
    End Sub

    Private Sub KryptonButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton7.Click
        Form12.Show()
        Form12.Activate()
    End Sub

    Private Sub A1Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles A1Panel1.Paint

    End Sub

    Private Sub Form29_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Dim metop = Val(Me.Top)
        Dim wintop = Val(DesktopBounds.Top)

        If metop - wintop > 0 And metop - wintop < 10 Then
            MsgBox("You are close to the top of the screen")
        End If
    End Sub

    Private Sub Form29_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Location = New Point(338, 12)
    End Sub
End Class