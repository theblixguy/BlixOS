Public Class Form32
    Dim fullpath As New TextBox
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        NeroBar1.Value = NeroBar1.Value + 1
        If NeroBar1.Value = 33 Then
            NeroBar1.Segment1Color = Color.Yellow
        ElseIf NeroBar1.Value = 66 Then
            NeroBar1.Segment1Color = Color.LightGreen
        ElseIf NeroBar1.Value = 100 Then
            Try
                Shell(KryptonTextBox1.Text, AppWinStyle.NormalFocus)
                info.Text = "Application is running"
                img.Image = PictureBox1.Image
                Timer1.Enabled = False
            Catch ex As Exception
                info.Text = "The application failed to start correctly"
                img.Image = My.Resources.Delete.ToBitmap
            End Try
        End If
    End Sub

    Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton2.Click
        Dim rnd As New Random
        If KryptonTextBox1.Text = Nothing And KryptonListBox1.SelectedItem = Nothing Then
            info.Text = "No application has been selected to start"
            img.Image = My.Resources.Delete.ToBitmap
        ElseIf Not KryptonTextBox1.Text = Nothing And KryptonListBox1.SelectedItem = Nothing Then
            info.Text = "Please select the version of BlixOS for which the program will be made compatible"
            img.Image = My.Resources.Delete.ToBitmap
        Else
            Timer1.Enabled = True
            Timer1.Interval = rnd.Next(30, 300)
            KryptonButton2.Enabled = False
            KryptonButton1.Enabled = False
            KryptonListBox1.Enabled = False
            KryptonTextBox1.ReadOnly = True
            KryptonTextBox1.BackColor = Color.White
            info.Text = "Preparing the application to start"
            img.Image = My.Resources.ajax_loader

        End If
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub KryptonButton1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonButton1.MouseEnter
        info.Text = "Click to choose an Windows-based application"
        img.Image = My.Resources.Get_Info.ToBitmap
    End Sub

    Private Sub KryptonButton1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonButton1.MouseLeave
        info.Text = Nothing
        img.Image = Nothing
    End Sub

    Private Sub KryptonListBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonListBox1.MouseEnter
        info.Text = "Select the version of BlixOS to which the program will be made compatible to"
        img.Image = My.Resources.Get_Info.ToBitmap
    End Sub

    Private Sub KryptonListBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonListBox1.MouseLeave
        info.Text = Nothing
        img.Image = Nothing
    End Sub

    Private Sub KryptonListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonListBox1.SelectedIndexChanged
        If KryptonListBox1.SelectedItem = "BlixOS Professional" Then
            Exit Sub
            info.Text = Nothing
            img.Image = Nothing
        Else
            info.Text = "Choosing any other version of BlixOS may cause the program to run incorrectly"
            img.Image = My.Resources.Delete.ToBitmap
        End If
    End Sub

    Private Sub KryptonButton2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonButton2.MouseEnter
        info.Text = "Click to start the application"
        img.Image = My.Resources.Get_Info.ToBitmap
    End Sub

    Private Sub KryptonButton2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonButton2.MouseLeave
        info.Text = Nothing
        img.Image = Nothing
    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        KryptonTextBox1.Text = OpenFileDialog1.FileName
        KryptonTextBox1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub Form32_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.winmode.Visible = True
    End Sub

    Private Sub Form32_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Form3.winmode.Visible = False
    End Sub
End Class
