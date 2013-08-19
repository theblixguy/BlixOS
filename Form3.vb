Imports AnalogClock
Imports System.Speech
Imports System.Speech.Synthesis
Imports System.Web.Mail
Imports System.Net.Mail
Imports System.Net
Imports System.Net.Mime
Imports System.Web
Imports System
Imports System.Runtime.Remoting.Messaging
Imports Emant.SMS
Imports Emant
Imports Microsoft.VisualBasic.ApplicationServices
Imports ComponentFactory.Krypton.Toolkit

Public Class Form3
    Dim isMouseDown As Integer
    Dim MyX, MyY As Integer
    Dim txt As New TextBox
    Dim txt1 As New TextBox
    Dim eoa As Boolean
    Dim speak As New SpeechSynthesizer

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If Panel2.Visible = True Then
            Panel2.Visible = False
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        If Panel2.Visible = True Then
            Panel2.Visible = False
        Else
            Exit Sub
        End If
    End Sub


    Private Sub ListView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        If Not ListView1.SelectedItems.Count = 0 Then
            For Each item As ListViewItem In ListView1.SelectedItems
                txt.Text = item.Text

                If txt.Text = "My Pictures" Then
                    Form4.Show()
                    pics.Visible = True
                ElseIf txt.Text = "My Documents" Then
                    Form6.Show()
                    docs.Visible = True
                ElseIf txt.Text = "Canure" Then
                    Form16.Show()
                ElseIf txt.Text = "Recycle Bin" Then
                    MsgBox("The Recycle Bin form is missing.", MsgBoxStyle.Critical, "Internal Error")
                ElseIf txt.Text = "Blix Paint" Then
                    FrmMain.Show()
                End If

                If eoa = True Then
                    speak.Speak(item.Text & item.ToolTipText)
                ElseIf eoa = False Then
                    Exit Sub
                End If
            Next
        End If


    End Sub

    Private Sub ListView1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.MouseHover
        If eoa = True Then
            speak.Speak("This is the desktop, your main screen area")
        ElseIf eoa = False Then
            Exit Sub
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub RenameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameToolStripMenuItem.Click
        ListView1.Refresh()

    End Sub

    Private Sub RenameToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameToolStripMenuItem1.Click
        If Not ListView1.SelectedItems.Count = 0 Then
            For Each item As ListViewItem In ListView1.SelectedItems
                item.BeginEdit()
            Next
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Form7.Show()
        Form7.Timer2.Enabled = True
        Windows.Forms.Cursor.Hide()
        Timer1.Enabled = False
    End Sub

    Private Sub ShutDownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub pics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pics.Click
        Form4.Activate()
    End Sub

    Private Sub docs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles docs.Click
        Form6.Activate()
    End Sub

    Private Sub MyComputerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comp.Click
        Form8.Activate()

    End Sub

    Private Sub StopShutdownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopShutdownToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskManagerToolStripMenuItem.Click
        Form9.Show()
    End Sub

    Private Sub BlixPadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bpad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpad.Click
        Form12.Activate()
    End Sub

    Private Sub tman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tman.Click
        Form9.Activate()
    End Sub

    Private Sub ChangeWallpaperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeWallpaperToolStripMenuItem.Click
        Form15.Show()
    End Sub

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        ListView1.Dock = DockStyle.Fill
        Dim speaker As New SpeechSynthesizer
        Dim ac As New TextBox
        Try
            ac.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "actapi.dll")
            If ac.Text = "ACTIVATED_YES" Then
                Exit Sub
            Else
                Form17.Show()
                Windows.Forms.Cursor.Show()
            End If
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "actapi.dll", "%%%%%ACTSTRING_ENCODED$$$$$$", False)
            ListView1.BackgroundImage = Nothing
            ListView1.BackColor = Color.Black
            MenuStrip1.Visible = False
            ListView1.Visible = False
            Me.BackgroundImage = Nothing
            Me.BackColor = Color.Black
            Form17.Show()
            Windows.Forms.Cursor.Show()
            Label1.Visible = True
        End Try
    End Sub

    Private Sub Form3_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ListView1.BackgroundImage = My.Resources.wall1
        Panel1.BackgroundImage = My.Resources.wall1
        Panel2.BackgroundImage = My.Resources.wall1
        Form17.Activate()
        Me.Show()
        Me.Cursor = Cursors.Default
        Timer7.Enabled = True
    End Sub

    Private Sub InitializeDesktop()
        Dim sel As New TextBox
        Try
            sel.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "wallval.dat")
            If sel.Text = "WALL_VAL(INDEX:TO:STRING)[1]" Then
                ListView1.BackgroundImage = My.Resources.wall1
                Panel1.BackgroundImage = My.Resources.wall1
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[2]" Then
                ListView1.BackgroundImage = My.Resources.wall2
                Panel1.BackgroundImage = My.Resources.wall1
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[3]" Then
                ListView1.BackgroundImage = My.Resources.wall3
                Panel1.BackgroundImage = My.Resources.wall1
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[4]" Then
                ListView1.BackgroundImage = My.Resources.wall4
                Panel1.BackgroundImage = My.Resources.wall1
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[5]" Then
                ListView1.BackgroundImage = My.Resources.wall5
                Panel1.BackgroundImage = My.Resources.wall1
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[6]" Then
                ListView1.BackgroundImage = My.Resources.wall6
                Panel1.BackgroundImage = My.Resources.wall1
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[7]" Then
                ListView1.BackgroundImage = My.Resources.wall7
                Panel1.BackgroundImage = My.Resources.wall1
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[8]" Then
                ListView1.BackgroundImage = My.Resources.wall8
                Panel1.BackgroundImage = My.Resources.wall1
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[9]" Then
                ListView1.BackgroundImage = My.Resources.wall9
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[10]" Then
                ListView1.BackgroundImage = My.Resources.wall10
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[11]" Then
                ListView1.BackgroundImage = My.Resources.wall11
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[12]" Then
                ListView1.BackgroundImage = My.Resources.wall12
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[13]" Then
                ListView1.BackgroundImage = My.Resources.wall13
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[14]" Then
                ListView1.BackgroundImage = My.Resources.wall14
            ElseIf sel.Text = "WALL_VAL(INDEX:TO:STRING)[15]" Then
                ListView1.BackgroundImage = My.Resources.wall15
            End If

        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "errlog.lod", Date.Today & "<|>" & ex.ToString, True)
            ToolTip1.Show("Cannot locate a system file for desktop initialization. Blix has created a new desktop initialization file.", PictureBox1)
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "System.Init Error"
            ToolTip1.IsBalloon = True
            ListView1.BackgroundImage = Nothing
            ListView1.BackColor = Color.Black
        End Try
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MenuStrip1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseClick
        If eoa = True Then
            speak.Speak("This is the taskbar. The taskbar is the long horizontal bar at the bottom of your screen. Unlike the desktop, which can get obscured by open windows, the taskbar is almost always visible.")
        ElseIf eoa = False Then
            Exit Sub
        End If
    End Sub

    Private Sub MenuStrip1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuStrip1.MouseEnter

    End Sub

    Private Sub MenuStrip1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuStrip1.MouseHover

    End Sub

    Private Sub MenuStrip1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuStrip1.MouseLeave

    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
            Panel2.Show()
            Panel2.Refresh()
            Panel2.Focus()
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False
        End If

        If eoa = True Then
            speak.Speak("This is the start button")
        ElseIf eoa = False Then
            Exit Sub
        End If
    End Sub

    Private Sub StartToolStripMenuItem_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.MouseEnter
        StartToolStripMenuItem.Font = FontDialog1.Font
    End Sub

    Private Sub StartToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.MouseLeave
        StartToolStripMenuItem.Font = FontDialog2.Font
    End Sub

    Private Sub KryptonMonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)

    End Sub

    Private Sub KryptonDropButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KryptonDropButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonDropButton1.Click
        Timer1.Enabled = True
        Panel2.Visible = False
    End Sub

    Private Sub KryptonDropButton1_DropDown(ByVal sender As Object, ByVal e As ComponentFactory.Krypton.Toolkit.ContextPositionMenuArgs) Handles KryptonDropButton1.DropDown
        KryptonContextMenu1.Show()
    End Sub

    Private Sub KryptonContextMenu1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles KryptonContextMenu1.Opening

    End Sub

    Private Sub KryptonContextMenuCheckButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonContextMenuCheckButton1.Click
        Me.Hide()
        Form1.Hide()
        Form2.Show()
        Form2.Timer3.Enabled = True
        Timer1.Enabled = True
        KryptonContextMenu1.Close()
        Panel2.Visible = False
    End Sub

    Private Sub KryptonListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        For Clear = 1 To 0 Step -0.01
            Me.Opacity = Clear
        Next
        Timer6.Enabled = True
    End Sub

    Private Sub KryptonListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Form6.Show()
        Panel2.Visible = False

    End Sub

    Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton2.Click
        Form4.Show()
        Panel2.Visible = False

    End Sub

    Private Sub KryptonTextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonTextBox1.Click
    End Sub

    Private Sub KryptonTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonTextBox1.TextChanged

    End Sub


    Private Sub KryptonButton1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonButton1.MouseHover
        PictureBox2.Image = My.Resources.my_docs
    End Sub

    Private Sub KryptonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton3.Click

    End Sub

    Private Sub KryptonButton3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonButton3.MouseHover
        PictureBox2.Image = My.Resources.MyComputer
    End Sub

    Private Sub KryptonButton2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonButton2.MouseHover
        PictureBox2.Image = My.Resources.my_pictures
    End Sub

    Private Sub Panel2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover
        PictureBox2.Image = Nothing
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub bpaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpaint.Click
        FrmMain.Activate()
    End Sub

    Private Sub perso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles perso.Click
        Form15.Activate()
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        KryptonTextBox1.Text = TreeView1.SelectedNode.FullPath

        If TreeView1.SelectedNode.Text = "Blix Paint" Then
            Panel2.Visible = False
            FrmMain.Show()
        ElseIf TreeView1.SelectedNode.Text = "BlixPad" Then
            Panel2.Visible = False
            Form12.Show()
        ElseIf TreeView1.SelectedNode.Text = "Foxlight MIDE" Then
            Panel2.Visible = False
            Form14.Show()
        ElseIf TreeView1.SelectedNode.Text = "Text to Binary" Then
            Panel2.Visible = False
            Form22.Show()
        ElseIf TreeView1.SelectedNode.Text = "View system info" Then
            Panel2.Visible = False
            Form21.Show()
        ElseIf TreeView1.SelectedNode.Text = "My Computer" Then
            Panel2.Visible = False
            Form8.Show()
        ElseIf TreeView1.SelectedNode.Text = "My Documents" Then
            Panel2.Visible = False
            Form6.Show()
        ElseIf TreeView1.SelectedNode.Text = "My Pictures" Then
            Panel2.Visible = False
            Form4.Show()
        ElseIf TreeView1.SelectedNode.Text = "Canure" Then
            Panel2.Visible = False
            Form16.Show()
        ElseIf TreeView1.SelectedNode.Text = "Narrator" Then
            Form23.Show()
            Panel2.Visible = False
        ElseIf TreeView1.SelectedNode.Text = "Webcam" Then
            Panel2.Visible = False
            Form36.Show()
            Form36.Activate()
        ElseIf TreeView1.SelectedNode.Text = "Handwriting Recognizer" Then
            Panel2.Visible = False
            frmRecognizer.Show()
            frmRecognizer.Activate()
        Else
            Exit Sub
        End If

        If eoa = True Then
            speak.Speak(TreeView1.SelectedNode.Text)
        ElseIf eoa = False Then
            Exit Sub
        End If
    End Sub

    Private Sub SystemInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinf.Click
        Form21.Activate()
    End Sub

    Private Sub TextToBinaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2bin.Click
        Form22.Activate()
    End Sub

    Private Sub canure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles canure.Click
        Form16.Activate()
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form17.Activate()
        Form18.Activate()
        Form19.Activate()
        Form20.Activate()
    End Sub

    Private Sub TreeView1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.MouseHover

    End Sub

    Private Sub EnableEOAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableEOAToolStripMenuItem.Click
        If eoa = Nothing Or False Then
            eoa = True
        ElseIf eoa = Nothing Or True Then
            eoa = False
        End If
    End Sub

    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        If eoa = True Then
            speak.Speak("BlixOS contains mini-programs called gadgets, which offer information at a glance and provide easy access to frequently used tools.")
        ElseIf eoa = False Then
            Exit Sub
        End If
    End Sub

    Private Sub Panel1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseHover

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Clock1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Clock1.MouseClick
        If eoa = True Then
            speak.Speak("This is the clock gadget")
        ElseIf eoa = False Then
            Exit Sub
        End If
    End Sub

    Private Sub Clock1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Clock1.MouseDown
        isMouseDown = 1
        MyX = e.X : MyY = e.Y
        Me.Cursor = Cursors.NoMove2D
    End Sub

    Private Sub Clock1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Clock1.MouseHover

    End Sub

    Private Sub Clock1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Clock1.MouseMove
        If isMouseDown = 1 Then
            If e.X > MyX Then Me.Left = Me.Left + 1
            If e.X < MyX Then Me.Left = Me.Left - 1
            If e.Y > MyY Then Me.Top = Me.Top + 1
            If e.Y < MyY Then Me.Top = Me.Top - 1
        End If
    End Sub

    Private Sub Clock1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Clock1.MouseUp
        isMouseDown = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Clock1_TimeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock1.TimeChanged

    End Sub

    Private Sub PowerOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerOptionsToolStripMenuItem.Click
        Form28.Show()
    End Sub

    Private Sub PowerOptionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pwr.Click
        Form28.Activate()
    End Sub

    Private Sub KryptonButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton4.Click
        Try
            Dim smssend As New Emant.SMS
            smssend.Send(TextBox2.Text, TextBox1.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub Timer5_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Label4.Text = SystemInformation.PowerStatus.BatteryLifePercent * 100 & "%"
        ProgressBar1.Value = SystemInformation.PowerStatus.BatteryLifePercent * 100
    End Sub

    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseDown
        isMouseDown = 1
        MyX = e.X : MyY = e.Y
        Me.Cursor = Cursors.NoMove2D
    End Sub

    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If isMouseDown = 1 Then
            If e.X > MyX Then Me.Left = Me.Left + 1
            If e.X < MyX Then Me.Left = Me.Left - 1
            If e.Y > MyY Then Me.Top = Me.Top + 1
            If e.Y < MyY Then Me.Top = Me.Top - 1
        End If
    End Sub

    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseUp
        isMouseDown = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Panel4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseDown
        isMouseDown = 1
        MyX = e.X : MyY = e.Y
        Me.Cursor = Cursors.NoMove2D
    End Sub

    Private Sub Panel4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseMove
        If isMouseDown = 1 Then
            If e.X > MyX Then Me.Left = Me.Left + 1
            If e.X < MyX Then Me.Left = Me.Left - 1
            If e.Y > MyY Then Me.Top = Me.Top + 1
            If e.Y < MyY Then Me.Top = Me.Top - 1
        End If
    End Sub

    Private Sub Panel4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseUp
        isMouseDown = 0
        Me.Cursor = Cursors.Default
    End Sub

    

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ShowDockbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowDockbarToolStripMenuItem.Click
        Form29.Show()
        Form29.Visible = True
        Form29.Activate()
    End Sub

    Private Sub LockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockToolStripMenuItem.Click
        Form29.Show()
        Form29.Activate()
        Form29.Enabled = False
    End Sub

    Private Sub UnlockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnlockToolStripMenuItem.Click
        Form29.Show()
        Form29.Activate()
        Form29.Enabled = True
    End Sub

    Private Sub ShowMiniPlayerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMiniPlayerToolStripMenuItem.Click
        Form30.Show()
        Form30.Activate()
    End Sub

    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click
        Form33.Show()
        Form33.Activate()
    End Sub

    Private Sub winmode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles winmode.Click
        Form32.Activate()
    End Sub

    Private Sub KryptonContextMenuCheckButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonContextMenuCheckButton2.Click
        Panel2.Visible = False
        Timer6.Enabled = True
        KryptonContextMenu1.Close()
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        Form2.Show()
        Form2.Visible = True
        Form2.Activate()
        Form2.KryptonLabel1.Text = "Preparing to Hibernate"
        Form2.Timer8.Enabled = True
        Form2.Timer10.Enabled = True
        Timer6.Enabled = False
    End Sub

    Private Sub wcam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wcam.Click
        Form36.Activate()
    End Sub

    Private Sub recog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recog.Click
        frmRecognizer.Activate()
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        Label5.Text = Date.Now.Hour & ":" & Date.Now.Minute
        Label6.Text = Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year
    End Sub

    Private Sub KryptonButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm = Application.OpenForms
        For Each frm As Windows.Forms.Form In ofrm
            If frm.Visible = True Then
                frm.Visible = False
            ElseIf frm.Visible = False Then
                frm.Visible = True
                frm.Activate()
            End If
        Next
    End Sub

    Private Sub KryptonCheckButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonCheckButton2.Click
        Me.Show()
        KryptonCheckButton1.Checked = True
        KryptonCheckButton2.Checked = False
    End Sub
End Class