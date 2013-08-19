Imports System.IO
Imports System.IO.Directory
Public Class Form4
    Dim txt As New TextBox

    Private Sub Form4_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form3.pics.Visible = False
        Form29.Show()
        Form29.Activate()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.pics.Visible = True
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If ToolStripTextBox1.Text = "My Pictures" Then
            Exit Sub
        ElseIf ToolStripTextBox1.Text = "My Documents" Then
            Me.Close()
            Form6.Width = 760
            Form6.Height = 495
            Form6.Show()
            Form3.pics.Visible = False
            Form3.docs.Visible = True
            Form3.comp.Visible = False
        ElseIf ToolStripTextBox1.Text = "My Computer" Then
            Me.Close()
            Form8.Width = 760
            Form8.Height = 495
            Form8.Show()
            Form3.pics.Visible = False
            Form3.docs.Visible = False
            Form3.comp.Visible = True
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        If Not ListView1.SelectedItems.Count = 0 Then
            For Each item As ListViewItem In ListView1.SelectedItems
                txt.Text = item.Text
                If txt.Text = "Water Fish" Then
                    Form5.Show()
                    Form5.PictureBox1.Image = My.Resources.wall4
                ElseIf txt.Text = "Wallpaper" Then
                    Form5.Show()
                    Form5.PictureBox1.Image = My.Resources.wall9
                Else
                    MsgBox("You have not seletced any picture to view.", MsgBoxStyle.Information, "My Pictures")
                End If
            Next
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ListView1.Width = 883 Then
            ListView1.Width = 871
        ElseIf ListView1.Width = 871 Then
            ListView1.Width = 855
        ElseIf ListView1.Width = 855 Then
            ListView1.Width = 838
        ElseIf ListView1.Width = 838 Then
            ListView1.Width = 824
        ElseIf ListView1.Width = 824 Then
            ListView1.Width = 804
        ElseIf ListView1.Width = 804 Then
            ListView1.Width = 782
        ElseIf ListView1.Width = 782 Then
            ListView1.Width = 759
        ElseIf ListView1.Width = 759 Then
            ListView1.Width = 740
        ElseIf ListView1.Width = 740 Then
            ListView1.Width = 718
        ElseIf ListView1.Width = 718 Then
            ListView1.Width = 700
            TreeView1.Visible = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim x_val As Integer = 100
        If ListView1.Height = 462 Then
            ListView1.Height = 447
        ElseIf ListView1.Height = 447 Then
            ListView1.Height = 432
        ElseIf ListView1.Height = 432 Then
            ListView1.Height = 420
            ToolStrip2.Visible = True
            ToolStrip1.Visible = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        ToolStrip1.Visible = False
    End Sub
End Class
