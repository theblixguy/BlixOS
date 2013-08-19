Imports System.IO.File

Public Class Form1
    Const WM_CAP As Short = &H400S
    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As Integer = 0  ' Normal device ID 
    Dim hHwnd As Integer  ' Handle value to preview window

    ' Declare function from AVI capture DLL.

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
         ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim picCapture As New PictureBox
        If PictureBox1.Visible = False Then
            Try
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
                Timer4.Enabled = False
                Form2.Show()
            Catch ex As Exception : End Try
        End If
        Try
            hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
          480, picCapture.Handle.ToInt32, 0)

            ' Connect to device
            If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then

                ' Set the preview scale
                SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

                ' Set the preview rate in milliseconds
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

                ' Start previewing the image from the camera 
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

                ' Resize window to fit in picturebox 
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, picCapture.Width, picCapture.Height, _
                                       SWP_NOMOVE Or SWP_NOZORDER)

                SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)

                DestroyWindow(hHwnd)
            End If
        Catch ex As Exception : End Try
        Cursor.Show()
        Timer1.Interval = 1700
        PictureBox1.Hide()
        PictureBox2.Visible = False
        Label1.Hide()
        Label2.Hide()
        Timer5.Enabled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(Application.StartupPath & "/" & "hal.vll") Then
            Dim firstrun As New TextBox
            firstrun.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "fsrun.dat")
            Cursor.Hide()
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Me.Height = DesktopBounds.Height
            Me.Width = DesktopBounds.Width
            PictureBox1.Width = DesktopBounds.Width
            PictureBox1.Height = DesktopBounds.Height
            PictureBox1.Dock = DockStyle.Fill
            PictureBox1.BackgroundImageLayout = ImageLayout.Center

            If firstrun.Text = "FIRST_RUN" Then
                Timer4.Enabled = True
                Label1.Text = "Starting Blix"
            ElseIf System.IO.File.Exists(Application.StartupPath & "/" & "hybfl.hdf") = True Then
                Label1.Text = "Resuming Blix"
                Timer7.Enabled = True
            Else
                Timer1.Enabled = True
                Timer4.Enabled = False
            End If
        Else
            Form35.Show()
            Form35.ListBox1.Enabled = False
            Me.Hide()
            Me.Timer1.Enabled = False
            Me.Timer2.Enabled = False
            Me.Timer3.Enabled = False
            Me.Timer4.Enabled = False

        End If
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label3.Text = "Booting up" Then
            Label3.Text = "Loading startup files"
        ElseIf Label3.Text = "Loading startup files" Then
            Label3.Text = "Loading Blix files"
        ElseIf Label3.Text = "Loading Blix files" Then
            Label3.Text = "Starting BTV (Boot Time Virtualization)"
        ElseIf Label3.Text = "Starting BTV (Boot Time Virtualization)" Then
            Label3.Text = "Launching Logon screen"
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Label1.Text = "Setup is preparing your computer for first use" Then
            Timer3.Interval = 6000
            Label1.Text = "Setup is configuring your computer"
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Dim fsrun As New TextBox
        fsrun.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "fsrun.dat")
        If fsrun.Text = "FIRST_RUN" Then
            Timer3.Enabled = True
            Label1.Text = "Setup is preparing your computer for first use"
        Else
            Timer1.Enabled = True
            Timer4.Enabled = True
            Timer4.Enabled = False
            Label1.Text = "Starting Blix"
            Exit Sub
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If Label4.Visible = True Then
            Label4.Visible = False
        ElseIf Label4.Visible = False Then
            Label4.Visible = True
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        Label4.Dispose()
        Label3.Show()
        Label3.Text = "BlixOS has successfully hibernated. Press Alt + F4 to exit."
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        If Label1.Text = "Resuming Blix" Then
            Timer7.Enabled = False
            Label1.Dispose()
            Label2.Dispose()
            Label4.Dispose()
            PictureBox1.Dispose()
            PictureBox2.Dispose()
            Form2.Show()
            Form2.Visible = True
            Form2.Timer9.Enabled = True
            Form2.Timer1.Enabled = False
            Form2.Timer2.Enabled = False
            Form2.Timer3.Enabled = False
            Form2.Timer4.Enabled = False
            Form2.Timer5.Enabled = False
            Form2.Timer6.Enabled = False
            Form2.Timer7.Enabled = False
            Form2.Timer8.Enabled = False
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = False
            Timer5.Enabled = False
            Timer6.Enabled = False
        End If

    End Sub
End Class
