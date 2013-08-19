Public Class Form12

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("BlixPad Beta 2 (Build 121). This program is for testing purposes only.", MsgBoxStyle.Information, "About")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer3.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "atrec.rfd")
        Timer3.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "atrec.rfd", RichTextBox1.Text, False)
    End Sub

    Private Sub Form12_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Form3.bpad.Visible = False
            Me.Dispose()
        Catch ex As Exception : End Try
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Width = 0
        Form3.bpad.Visible = True
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        If RichTextBox1.TextLength >= 5 Then
            Timer1.Enabled = True
        Else
            Exit Sub
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "atrec.rfd", "", False)
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        If OpenFileDialog1.Filter = "Text Files (.txt)" Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        ElseIf OpenFileDialog1.Filter = "Rich Text Files (.rtf)" Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
        ElseIf OpenFileDialog1.Filter = "ClearText Format (.ctf)" Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichNoOleObjs)
        Else
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        If SaveFileDialog1.Filter = "Text Files (.txt)" Then
            Timer2.Enabled = True
            Timer1.Enabled = False
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "atrec.rfd", "", False)
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        ElseIf SaveFileDialog1.Filter = "Rich Text Files (.rtf)" Then
            Timer2.Enabled = True
            Timer1.Enabled = False
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "atrec.rfd", "", False)
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        ElseIf SaveFileDialog1.Filter = "ClearText Format (.ctf)" Then
            Timer2.Enabled = True
            Timer1.Enabled = False
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "atrec.rfd", "", False)
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichNoOleObjs)
        Else
            Timer2.Enabled = True
            Timer1.Enabled = False
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "atrec.rfd", "", False)
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)

        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("BlixPad Beta 2 (Build 121). This program is for testing purposes only.", MsgBoxStyle.Information, "About")
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Panel1.Width = 232 Then
            Panel1.Width = 217
        ElseIf Panel1.Width = 217 Then
            Panel1.Width = 205
        ElseIf Panel1.Width = 205 Then
            Panel1.Width = 184
        ElseIf Panel1.Width = 184 Then
            Panel1.Width = 162
        ElseIf Panel1.Width = 162 Then
            Panel1.Width = 128
        ElseIf Panel1.Width = 128 Then
            Panel1.Width = 114
        ElseIf Panel1.Width = 114 Then
            Panel1.Width = 94
        ElseIf Panel1.Width = 94 Then
            Panel1.Width = 72
        ElseIf Panel1.Width = 72 Then
            Panel1.Width = 53
        ElseIf Panel1.Width = 53 Then
            Panel1.Width = 38
        ElseIf Panel1.Width = 38 Then
            Panel1.Width = 15
        ElseIf Panel1.Width = 15 Then
            Panel1.Hide()
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Panel1.Width = 0 Then
            Panel1.Width = 15
        ElseIf Panel1.Width = 15 Then
            Panel1.Width = 38
        ElseIf Panel1.Width = 38 Then
            Panel1.Width = 53
        ElseIf Panel1.Width = 53 Then
            Panel1.Width = 78
        ElseIf Panel1.Width = 78 Then
            Panel1.Width = 94
        ElseIf Panel1.Width = 94 Then
            Panel1.Width = 114
        ElseIf Panel1.Width = 114 Then
            Panel1.Width = 131
        ElseIf Panel1.Width = 131 Then
            Panel1.Width = 148
        ElseIf Panel1.Width = 148 Then
            Panel1.Width = 162
        ElseIf Panel1.Width = 162 Then
            Panel1.Width = 184
        ElseIf Panel1.Width = 184 Then
            Panel1.Width = 205
        ElseIf Panel1.Width = 205 Then
            Panel1.Width = 217
        ElseIf Panel1.Width = 217 Then
            Panel1.Width = 232
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Form12_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim recload As New TextBox
        Try
            recload.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "atrec.rfd")
            If recload.TextLength >= 5 Then
                Timer4.Enabled = True
                Label3.Text = "This file was last saved on " + System.IO.File.GetLastAccessTime(Application.StartupPath & "/" & "atrec.rfd") + ". This file contains all the data that is required to recover what you were typing the last time you opened BlixPad."
                With ListView1.Items.Add("Filename:")
                    .SubItems.Add("atrec.rfd")
                End With
                With ListView1.Items.Add("Last Access Date:")
                    .SubItems.Add(System.IO.File.GetLastAccessTime(Application.StartupPath & "/" & "atrec.rfd"))
                End With
                With ListView1.Items.Add("OpenHash Value:")
                    .SubItems.Add(recload.Text.GetHashCode)
                End With
                With ListView1.Items.Add("Characters Present:")
                    .SubItems.Add(recload.TextLength)
                End With
            Else
                Panel1.Hide()
            End If
        Catch ex As Exception
            MsgBox("The auto-recovery file is missing. BlixPad will now create a new auto-recovery file.", MsgBoxStyle.Information, "BlixPad")
            System.IO.File.Create(Application.StartupPath & "/" & "atrec.rfd")
        End Try
    End Sub
End Class