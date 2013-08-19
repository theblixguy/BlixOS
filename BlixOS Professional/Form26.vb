Imports AnalogClock

Public Class Form26


    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label2.Text = "BlixOS is finalizing your settings, please wait." Then
            Label2.Text = "BlixOS is finalizing your settings, please wait ."
        ElseIf Label2.Text = "BlixOS is finalizing your settings, please wait ." Then
            Label2.Text = "BlixOS is finalizing your settings, please wait  ."
        ElseIf Label2.Text = "BlixOS is finalizing your settings, please wait  ." Then
            Label2.Text = "BlixOS is finalizing your settings, please wait."
        End If
    End Sub

    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Me.Height = 444
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Hide()
        Form2.KryptonLabel1.Text = "Preparing your Desktop"
        Form2.Timer1.Enabled = True
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "fsrun.dat", "FIRST_RUN[NO]", False)
        Timer2.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If Me.Height = 444 Then
            Me.Height = 485
        ElseIf Me.Height = 485 Then
            Me.Height = 444
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If ProgressBar1.MarqueeAnimationSpeed = 0 Then
            ProgressBar1.MarqueeAnimationSpeed = 10
        ElseIf ProgressBar1.MarqueeAnimationSpeed = 10 Then
            ProgressBar1.MarqueeAnimationSpeed = 20
        ElseIf ProgressBar1.MarqueeAnimationSpeed = 20 Then
            ProgressBar1.MarqueeAnimationSpeed = 30
        ElseIf ProgressBar1.MarqueeAnimationSpeed = 30 Then
            ProgressBar1.MarqueeAnimationSpeed = 40
        ElseIf ProgressBar1.MarqueeAnimationSpeed = 40 Then
            ProgressBar1.MarqueeAnimationSpeed = 50
        ElseIf ProgressBar1.MarqueeAnimationSpeed = 50 Then
            ProgressBar1.MarqueeAnimationSpeed = 60
        ElseIf ProgressBar1.MarqueeAnimationSpeed = 60 Then
            ProgressBar1.MarqueeAnimationSpeed = 70
        ElseIf ProgressBar1.MarqueeAnimationSpeed = 70 Then
            ProgressBar1.MarqueeAnimationSpeed = 80
        ElseIf ProgressBar1.MarqueeAnimationSpeed = 80 Then
            ProgressBar1.MarqueeAnimationSpeed = 90
        ElseIf ProgressBar1.MarqueeAnimationSpeed = 90 Then
            ProgressBar1.MarqueeAnimationSpeed = 100
        ElseIf ProgressBar1.MarqueeAnimationSpeed = 100 Then
            ProgressBar1.MarqueeAnimationSpeed = 0
        End If
    End Sub
End Class
