Public Class Form6

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If ToolStripTextBox1.Text = "My Pictures" Then
            Me.Close()
            Form4.Width = 760
            Form4.Height = 495
            Form4.Show()
            Form3.pics.Visible = True
            Form3.docs.Visible = False
            Form3.comp.Visible = False
        ElseIf ToolStripTextBox1.Text = "My Documents" Then
           Exit Sub
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

    Private Sub Form6_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form3.docs.Visible = False
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.docs.Visible = True
    End Sub
End Class