Public Class Form2



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim txt As New TextBox
        txt.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "pshive.vll")
        If System.IO.File.Exists("hybfl.hdf") = True Then
            KryptonLabel1.Text = "            Welcome"
            Timer9.Enabled = True
        ElseIf txt.Text = "PSS|HIVE_LOAD#DWRD => *0x0001" Then
            Timer4.Enabled = True
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer5.Enabled = False
            Timer6.Enabled = False
            Timer7.Enabled = False
            Timer8.Enabled = False
        ElseIf txt.Text = "PSS|HIVE_LOAD#DWRD => 0x1000*" Then
            TextBox1.Dispose()
            KryptonButton1.Dispose()
            PictureBox2.Dispose()
            KryptonLabel1.Text = "            Welcome"
            KryptonLabel1.Visible = True
            KryptonLabel1.Show()
            Timer5.Enabled = True
            Timer4.Enabled = True
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer6.Enabled = False
            Timer7.Enabled = False
            Timer8.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Timer1.Enabled = False
        Else
            Timer1.Enabled = False
            MsgBox("Logon Profile Hive#1# is invalid. BlixOS could not load statup logon data because Hive#1# is damaged.")
            KryptonLabel1.Text = "         Invalid Hive#1#"
            Timer7.Enabled = True
        End If
    End Sub

    Private Sub Fade()
        Dim Clear As Double

        'Fade In
        '
        'Always use 1.01 instead of 1 or your form will have a tiny bit
        'of transparency left which can sometimes really slow things
        'down.
        For Clear = 0 To 1.01 Step 0.01
            Me.Opacity = Clear
        Next


        'Fade Out
        For Clear = 1 To 0 Step -0.01
            Me.Opacity = Clear
        Next
        Form1.Show()
        Form3.Show()
        Timer1.Enabled = False
        Timer4.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer5.Enabled = False
        Timer6.Enabled = False
        Timer7.Enabled = False
        Timer8.Enabled = False
    End Sub

    Private Sub DisableAllTimers()
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Form7.Timer1.Enabled = False
        Form7.Timer2.Enabled = False
        Form1.Timer1.Enabled = False
        Form1.Timer2.Enabled = False
        Timer1.Enabled = False
        Timer4.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer5.Enabled = False
        Timer6.Enabled = False
        Timer7.Enabled = False
        Timer8.Enabled = False
        DisableAllTimers()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Application.Exit()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Form1.Show()
        Me.Hide()
        Form1.PictureBox1.Visible = True
        Form1.PictureBox2.Visible = True
        Form1.Label1.Visible = True
        Form1.Label2.Visible = True
        Form1.Timer4.Enabled = True
    End Sub

    Private Sub Form2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.BackgroundImage = My.Resources.blogonwpp
        Dim fsrun As New TextBox
        fsrun.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "fsrun.dat")
        Form1.Label3.Visible = False
        Form1.Label2.Visible = False
        Form1.Label1.Visible = False
        Windows.Forms.Cursor.Show()

        If fsrun.Text = "FIRST_RUN" Then
            Me.Cursor = Cursors.Default
            Form24.Show()
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub



    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Fade()
        Timer5.Enabled = False
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        KryptonLabel1.Visible = False
        KryptonButton1.Visible = True
        TextBox1.Visible = True
        PictureBox2.Visible = True
        Timer4.Enabled = False
        Me.Cursor = Cursors.Default
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.PasswordChar = "•"
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.PasswordChar = "•"
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Dim ett As New ToolTip
        If TextBox1.Text = "professional" Then
            TextBox1.Dispose()
            KryptonButton1.Dispose()
            PictureBox2.Dispose()
            KryptonLabel1.Text = "            Welcome"
            KryptonLabel1.Visible = True
            KryptonLabel1.Show()
            Timer5.Enabled = True
            Me.Cursor = Cursors.WaitCursor
        Else
            ett.IsBalloon = False
            ett.ToolTipIcon = ToolTipIcon.Warning
            ett.ToolTipTitle = "Invalid Password"
            ett.Show("The password you entered is invalid. Please check again. (Your password is : professional)", TextBox1, 2000)
            Exit Sub
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        Do
            Me.Show()
        Loop Until Me.Visible = True
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        Form11.Show()
        Timer7.Enabled = False
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        Form12.Dispose()
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "hybdt.hdf", "><HIBERNATION><", False)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "hybfl.hdf", Form12.RichTextBox1.Text, False)
        Me.Hide()
        Form1.Show()
        Form3.Close()
        Form1.Label4.Visible = True
        Form1.Timer5.Enabled = True
        Form1.Timer6.Enabled = True
        Timer8.Enabled = False
        Me.Close()

    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        Me.Hide()
        Form3.Show()
        Form3.Visible = True
        Form12.Show()
        Form12.Activate()
        Form12.Panel1.Visible = False
        Form12.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "hybfl.hdf")
        Timer9.Enabled = False
        Form1.Timer7.Enabled = False
        Try
            Kill(Application.StartupPath & "/" & "hybfl.hdf")
        Catch ex As Exception : End Try
    End Sub

    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        KryptonLabel1.Text = "Preparing to Hibernate"
    End Sub
End Class