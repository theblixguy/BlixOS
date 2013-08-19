Public Class Form16

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            WebKitBrowser1.Navigate(ToolStripComboBox1.Text)
            ToolStripComboBox1.Items.Add(ToolStripComboBox1.Text)
        Catch ex As Exception : End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            WebKitBrowser1.Reload()
        Catch ex As Exception : End Try
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Try
            WebKitBrowser1.Stop()
        Catch ex As Exception : End Try
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Try
            WebKitBrowser1.GoForward()
        Catch ex As Exception : End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            WebKitBrowser1.GoBack()
        Catch ex As Exception : End Try
    End Sub

    Private Sub Form16_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form3.canure.Visible = False
    End Sub

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.canure.Visible = True
    End Sub

    Private Sub WebKitBrowser1_DocumentTitleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebKitBrowser1.DocumentTitleChanged
        Me.TextExtra = WebKitBrowser1.DocumentTitle
    End Sub

    Private Sub WebKitBrowser1_DownloadBegin(ByVal sender As Object, ByVal e As WebKit.FileDownloadBeginEventArgs) Handles WebKitBrowser1.DownloadBegin
        My.Computer.Network.DownloadFile(WebKitBrowser1.Document.NamespaceURI.AbsolutePath, Application.StartupPath & "/" & "download", "", "", True, 10000, True, FileIO.UICancelOption.DoNothing)
    End Sub

    Private Sub WebKitBrowser1_Error(ByVal sender As Object, ByVal e As WebKit.WebKitBrowserErrorEventArgs) Handles WebKitBrowser1.Error
        status.Text = "Canure could not locate '" + ToolStripComboBox1.Text.Trim("www", "http://", "") + "'"
        WebKitBrowser1.Navigate("file:///I:/BlixOS%20pro/BlixOS%20Professional/bin/Debug/Err.htm")
    End Sub

    Private Sub WebKitBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebKitBrowser1.Navigated
        status.Text = "Done"
        ToolStripComboBox1.Text = WebKitBrowser1.Document.NamespaceURI.AbsolutePath
    End Sub

    Private Sub WebKitBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebKitBrowser1.Navigating
        status.Text = "Navigating to: " + ToolStripComboBox1.Text.ToLower
    End Sub
    Private Sub SavePageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavePageToolStripMenuItem.Click
        Dim box As New SaveFileDialog
        box.ShowDialog()
        box.Filter = "HTML Files (.htm)|*.htm"
        If box.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(box.FileName, WebKitBrowser1.DocumentText, False)
        Else
            Exit Sub
        End If
    End Sub
End Class
