Public Class FrmMain
    Dim xStart, yStart, xEnd, yEnd As Integer
    Dim Drawbitmap As Bitmap
    Dim Drawgraphics As Graphics
    Dim myPen As New Pen(Color.BlueViolet, 3)
    Dim myColor As Color = Color.Blue
    Dim myBrush As New Drawing.SolidBrush(Color.Red)
    Dim myBrushWidth As Integer
    Dim ContinuousFlag As Boolean

    Private Sub FrmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form3.bpaint.Visible = False
    End Sub

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Drawbitmap = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Drawgraphics = Graphics.FromImage(Drawbitmap)
        PictureBox1.Image = Drawbitmap
        Drawgraphics.Clear(Color.White)
        myBrushWidth = 4
        Form3.bpaint.Visible = True
    End Sub

    Private Sub drawMyline()
        Try
            PictureBox1.Image = Drawbitmap
            Drawgraphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            Drawgraphics.DrawLine(myPen, xStart, yStart, xEnd, yEnd)
        Catch ex As Exception : End Try
    End Sub
    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Width = 1
        myBrushWidth = 2
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Width = 3
        myBrushWidth = 4
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Width = 6
        myBrushWidth = 7
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Width = 10
        myBrushWidth = 12
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Width = 15
        myBrushWidth = 17
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Color = Color.Red
        myBrush.Color = Color.Red
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Color = Color.Green
        myBrush.Color = Color.Green
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Color = Color.Yellow
        myBrush.Color = Color.Yellow
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Color = Color.OrangeRed
        myBrush.Color = Color.OrangeRed
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Color = Color.Purple
        myBrush.Color = Color.Purple
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Color = Color.Black
        myBrush.Color = Color.Black
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Color = Color.White
        myPen.Color = Color.White
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Color = Color.Gray
        myBrush.Color = Color.Gray
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myPen.Color = Color.BlueViolet
        myBrush.Color = Color.Red
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = myBrush.Color
            dlg.ShowDialog()
            myBrush.Color = dlg.Color
            myPen.Color = dlg.Color
        Catch ex As Exception : End Try
    End Sub



    Private Sub LineByLineToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If LineByLineToolStripMenuItem.Checked = True And ContinuousToolStripMenuItem.Checked = False Then
            ContinuousFlag = False
        ElseIf LineByLineToolStripMenuItem.Checked = False And ContinuousToolStripMenuItem.Checked = True Then
            ContinuousFlag = True
        End If
    End Sub

    Private Sub LineByLineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dlg As SaveFileDialog = New SaveFileDialog()
        Try
            dlg.Title = "Save"
            dlg.Filter = "Bitmap Image (*.bmp)|*.bmp |All Files |*.*"
            If dlg.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub ContinuousToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If LineByLineToolStripMenuItem.Checked = True And ContinuousToolStripMenuItem.Checked = False Then
            ContinuousFlag = False
        ElseIf LineByLineToolStripMenuItem.Checked = False And ContinuousToolStripMenuItem.Checked = True Then
            ContinuousFlag = True
        End If
    End Sub

    Private Sub ClearDrawingAreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearDrawingAreaToolStripMenuItem.Click
        Try
            Drawbitmap = New Bitmap(PictureBox1.Width, PictureBox1.Height)
            Drawgraphics = Graphics.FromImage(Drawbitmap)
            PictureBox1.Image = Drawbitmap
            Drawgraphics.Clear(Color.White)
        Catch ex As Exception : End Try
    End Sub

   

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        myPen.Color = ToolStripButton1.BackColor
        myBrush.Color = ToolStripButton1.BackColor
    End Sub

    Private Sub ToolStripButton15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        myPen.Color = ToolStripButton15.BackColor
        myBrush.Color = ToolStripButton15.BackColor
    End Sub

    Private Sub ToolStripButton14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        myPen.Color = ToolStripButton14.BackColor
        myBrush.Color = ToolStripButton14.BackColor
    End Sub

    Private Sub ToolStripButton13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        myPen.Color = ToolStripButton13.BackColor
        myBrush.Color = ToolStripButton13.BackColor
    End Sub

    Private Sub ToolStripButton12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        myPen.Color = ToolStripButton12.BackColor
        myBrush.Color = ToolStripButton12.BackColor
    End Sub

    Private Sub ToolStripButton11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        myPen.Color = ToolStripButton11.BackColor
        myBrush.Color = ToolStripButton11.BackColor
    End Sub

    Private Sub ToolStripButton10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        myPen.Color = ToolStripButton10.BackColor
        myBrush.Color = ToolStripButton10.BackColor
    End Sub

    Private Sub ToolStripButton9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        myPen.Color = ToolStripButton9.BackColor
        myBrush.Color = ToolStripButton9.BackColor
    End Sub

    Private Sub ToolStripButton8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        myPen.Color = ToolStripButton8.BackColor
        myBrush.Color = ToolStripButton8.BackColor
    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        myPen.Color = ToolStripButton3.BackColor
        myBrush.Color = ToolStripButton3.BackColor
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        myPen.Color = ToolStripButton2.BackColor
        myBrush.Color = ToolStripButton2.BackColor
    End Sub

    Private Sub OpenToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        Try
            dlg.Title = "Open"
            dlg.Filter = "Bitmap Image (*.bmp)|*.bmp |All Files |*.*"
            If dlg.ShowDialog() = DialogResult.OK Then
                PictureBox1.ImageLocation = dlg.FileName
                PictureBox1.Load()
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim dlg As SaveFileDialog = New SaveFileDialog()
        Try
            dlg.Title = "Save"
            dlg.Filter = "Bitmap Image (*.bmp)|*.bmp |All Files |*.*"
            If dlg.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image.Save(dlg.FileName)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SuperThinToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuperThinToolStripMenuItem.Click
        myPen.Width = 1
        myBrushWidth = 2
    End Sub

    Private Sub ThinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThinToolStripMenuItem.Click
        myPen.Width = 3
        myBrushWidth = 4
    End Sub

    Private Sub MediumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumToolStripMenuItem.Click
        myPen.Width = 5
        myBrushWidth = 6
    End Sub

    Private Sub ThickToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThickToolStripMenuItem.Click
        myPen.Width = 7
        myBrushWidth = 8
    End Sub

    Private Sub SuperThickToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuperThickToolStripMenuItem.Click
        myPen.Width = 9
        myBrushWidth = 10
    End Sub

    Private Sub ContinuousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContinuousToolStripMenuItem.Click
        ContinuousToolStripMenuItem.Checked = True
        LineByLineToolStripMenuItem.Checked = False
        ContinuousFlag = True
    End Sub

    Private Sub LineByLineToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineByLineToolStripMenuItem.Click
        ContinuousToolStripMenuItem.Checked = False
        LineByLineToolStripMenuItem.Checked = True
        ContinuousFlag = False
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Blix Paint (Version 2, Build 10). Copyright (C) 2010 Blix Corporation", MsgBoxStyle.Information, "About")
    End Sub

    Private Sub PictureBox1_MouseDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        Try
            xStart = Control.MousePosition.X - (Me.Left + PictureBox1.Left + 4)
            yStart = Control.MousePosition.Y - (Me.Top + PictureBox1.Top + 31)

        Catch ex As Exception : End Try
    End Sub

    Private Sub PictureBox1_MouseMove1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Try
            If ContinuousFlag Then
                Drawgraphics.SmoothingMode = Drawing2D.SmoothingMode.None
                Drawgraphics.FillEllipse(myBrush, e.X, e.Y, myBrushWidth, myBrushWidth)
                PictureBox1.Image = Drawbitmap
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub PictureBox1_MouseUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Try
            xEnd = Control.MousePosition.X - (Me.Left + PictureBox1.Left + 4)
            yEnd = Control.MousePosition.Y - (Me.Top + PictureBox1.Top + 31)

            drawMyline()

        Catch ex As Exception : End Try
    End Sub
End Class
