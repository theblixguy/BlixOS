Public Class Form8

    Private Sub ListView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        Dim txt As New TextBox
        If Not ListView1.SelectedItems.Count = 0 Then
            For Each item As ListViewItem In ListView1.SelectedItems
                txt.Text = item.Text
                If txt.Text = "Physical Drive (C:)" Then
                    cpath.Text = "C:\"
                    ListView2.Visible = True
                ElseIf txt.Text = "CD/DVD Drive (D:)" Then
                    MsgBox("Cannot open the drive you have selected. Make sure it is correctly installed", MsgBoxStyle.Exclamation, "DriveBoot Error")
                Else
                    MsgBox("You have not selected anything.", MsgBoxStyle.Information, "Blixplorer")
                End If
            Next
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView2_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView2.MouseDoubleClick
        Dim txt As New TextBox
        If Not ListView2.SelectedItems.Count = 0 Then
            For Each item As ListViewItem In ListView2.SelectedItems
                txt.Text = item.Text
                If txt.Text = "App Files" Then
                    cpath.Text = "C:\App Files"
                    ListView3.Visible = True
                ElseIf txt.Text = "BlixOS" Then
                    cpath.Text = "C:\BlixOS"
                    ListView3.Visible = True
                ElseIf txt.Text = "pagefile.sy" Then
                    MsgBox("This is a system file and cannot be modified", MsgBoxStyle.Exclamation, "Security Protocol")
                ElseIf txt.Text = "Computer Data" Then
                    MsgBox("Access to the path is denied. Please contact your computer administrator", MsgBoxStyle.Critical, "Admin")
                ElseIf txt.Text = "startexec.blx" Then
                    Form4.Show()
                    Form4.Text = "startexec"
                    Form4.ListView1.Hide()
                    Form4.ToolStrip1.Hide()
                    Form4.ToolStrip1.Dispose()
                    Form4.ListView1.Dispose()
                    Form4.BackColor = Color.Black
                    Form4.Close()
                Else
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If cpath.Text = "C:\" Then

        End If
    End Sub

    Private Sub Form8_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form3.comp.Visible = False
    End Sub

    Private Sub ListView4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.comp.Visible = True
    End Sub
End Class