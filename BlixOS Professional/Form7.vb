Public Class Form7
    Dim frmShutdown As New Form2
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try

            Form3.Close()
            frmShutdown.Show()
            Windows.Forms.Cursor.Hide()
            frmShutdown.KryptonLabel1.Text = "  Shutting Down"
            frmShutdown.Timer1.Stop()
            frmShutdown.Timer2.Stop()
            frmShutdown.Timer3.Stop()
            frmShutdown.Timer4.Stop() '
            frmShutdown.Timer5.Stop()
            frmShutdown.Timer6.Stop()
            frmShutdown.Timer7.Stop()
            frmShutdown.Timer8.Stop()
            frmShutdown.Timer1.Dispose()
            frmShutdown.Timer3.Dispose()
            frmShutdown.Timer4.Dispose()
            frmShutdown.Timer5.Dispose()
            frmShutdown.Timer6.Dispose()
            frmShutdown.Timer7.Dispose()
            frmShutdown.Timer8.Dispose()
            frmShutdown.Timer2.Enabled = True
            frmShutdown.Timer2.Start()
            Me.Close()
            Me.Timer1.Enabled = False
        Catch ex As Exception
            Form10.Show()
        End Try
        
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer1.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form3.docs.Visible = True Then
            With ListView1.Items.Add("My Documents", 1)
                .ForeColor = Color.White
            End With
        End If
        If Form3.pics.Visible = True Then
            With ListView1.Items.Add("My Pictures", 1)
                .ForeColor = Color.White
            End With
        End If
        If Form3.comp.Visible = True Then
            With ListView1.Items.Add("My Computers", 1)
                .ForeColor = Color.White
            End With
        End If
        If Form3.bpad.Visible = True Then
            With ListView1.Items.Add("BlixPad", 2)
                .ForeColor = Color.White
            End With
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Form7_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim itms As String = ListView1.Items.Count
        If itms = 1 Then
            Label1.Text = "1 program still need to close"
        Else
            Label1.Text = itms + " programs still need to close"
        End If

    End Sub

    Private Sub CancelShutdownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelShutdownToolStripMenuItem.Click
        Me.Close()
        Cursor.Show()
        Timer1.Enabled = False
        Timer2.Enabled = False
        Form3.Timer3.Enabled = False
        Me.Timer1.Enabled = False
        Me.Timer2.Enabled = False
        Form2.Timer1.Enabled = False
        Form2.Timer2.Enabled = False
        Form2.Timer3.Enabled = False
        Form1.Timer1.Enabled = False
        Form1.Timer2.Enabled = False
    End Sub
End Class