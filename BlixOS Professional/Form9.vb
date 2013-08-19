Imports System.Diagnostics
Imports System.Diagnostics.Process

Public Class Form9
    
    Private Sub TerminateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerminateToolStripMenuItem.Click
        Dim txt As New TextBox
        If Not ListView1.SelectedItems.Count = 0 Then
            For Each item As ListViewItem In ListView1.SelectedItems
                txt.Text = item.Text
                If txt.Text = "blixplorer.blx" Then
                    item.Remove()
                    Form3.MenuStrip1.Visible = False
                    Form3.ListView1.Visible = False
                ElseIf txt.Text = "icache.blx" Then
                    Form3.ListView1.Visible = False
                ElseIf txt.Text = "kernel.blx" Then
                    ContextMenuStrip1.Enabled = True
                    MsgBox("This is a very critical process which cannot be terminated", MsgBoxStyle.Exclamation, "End Task")
                ElseIf txt.Text = "System Idle Time" Then
                    ContextMenuStrip1.Enabled = False
                ElseIf txt.Text = "System" Then
                    MsgBox("This is a very critical process which cannot be terminated", MsgBoxStyle.Exclamation, "End Task")
                ElseIf txt.Text = "shutdown.blx" Then
                    If MsgBox("If you kill this process, you cannot shutdown Blix. Are you sure you want to continue?", MsgBoxStyle.YesNo, "Shutdown") = MsgBoxResult.Yes Then
                        Form3.KryptonContextMenu1.Enabled = False
                    Else
                        Exit Sub
                    End If
                End If
                
            Next
        ElseIf txt.Text = "startexec.blx" Then
            Form10.Show()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Form9_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form3.tman.Visible = False
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.tman.Visible = True
        Timer1.Enabled = True
    End Sub

    Private Sub ContextMenuStrip1_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles ContextMenuStrip1.Closing
        ContextMenuStrip1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim rnd As New Random
        ListView1.Items.Clear()
        With ListView1.Items.Add("blixplorer.blx")
            .SubItems.Add(rnd.Next(1, 10))
            .SubItems.Add(rnd.Next(2412, 2800) & " K")
            .SubItems.Add("Blix Explorer")
        End With
        With ListView1.Items.Add("icache.blx")
            .SubItems.Add(rnd.Next(1, 10))
            .SubItems.Add(rnd.Next(700, 999) & " K")
            .SubItems.Add("Icon Cache")
        End With
        With ListView1.Items.Add("dwm.blx")
            .SubItems.Add(rnd.Next(1, 10))
            .SubItems.Add(rnd.Next(1000, 1762) & " K")
            .SubItems.Add("Desktop Window Manager")
        End With
        With ListView1.Items.Add("kernel.blx")
            .SubItems.Add(rnd.Next(1, 10))
            .SubItems.Add(rnd.Next(2000, 2500) & " K")
            .SubItems.Add("BlixOS Kernel")
        End With
        With ListView1.Items.Add("System")
            .SubItems.Add(rnd.Next(1, 10))
            .SubItems.Add(rnd.Next(300, 900) & " K")
            .SubItems.Add("System")
        End With
        With ListView1.Items.Add("System Idle Time")
            .SubItems.Add(rnd.Next(1, 100))
            .SubItems.Add("")
            .SubItems.Add("Shows the percentage of time the CPU is idle")
        End With
        With ListView1.Items.Add("shutdown.blx")
            .SubItems.Add(rnd.Next(1, 10))
            .SubItems.Add(rnd.Next(414, 769) & " K")
            .SubItems.Add("Blix Shutdown Manager")
        End With
        With ListView1.Items.Add("startexec.blx")
            .SubItems.Add(rnd.Next(1, 10))
            .SubItems.Add(rnd.Next(230, 561) & " K")
            .SubItems.Add("Blix Start-up Application")
        End With
    End Sub

    Private Sub CreateDumpFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateDumpFileToolStripMenuItem.Click
        MsgBox("Process written to dump file.", , "Dump")
    End Sub

    Private Sub DebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugToolStripMenuItem.Click
        MsgBox("No debugger was found.", MsgBoxStyle.Exclamation, "Debug Process")
    End Sub
End Class