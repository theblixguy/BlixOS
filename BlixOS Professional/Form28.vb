Imports System.Runtime.InteropServices

Public Class Form28

    Private Declare Auto Function CreateFile Lib "kernel32" _
        (ByVal lpFileName As String, ByVal dwDesiredAccess As Int32, _
        ByVal dwShareMode As Int32, ByVal lpSecurityAttributes As IntPtr, _
        ByVal dwCreationDisposition As Int32, _
        ByVal dwFlagsAndAttributes As Int32, ByVal hTemplateFile As IntPtr) As IntPtr

    Const GENERIC_READ As Int32 = &H80000000%
    Const SHARE_ALL As Int32 = &H7%
    Const OPEN_EXISTING As Int32 = &H3%

    Const IOCTL_VIDEO_SET_DISPLAY_BRIGHTNESS As Integer = &H23049C%

    Private Structure BRIGHTNESS
        Public ucDisplayPolicy As Byte
        Public ucACBrightness As Byte
        Public ucDCBrightness As Byte
    End Structure

    Private Declare Auto Function DeviceIoControl Lib "kernel32" _
        (ByVal hDevice As IntPtr, ByVal dwIoControlCode As Int32, _
        ByRef lpInBuffer As BRIGHTNESS, ByVal nInBufferSize As Int32, _
        ByVal lpOutBuffer As IntPtr, ByVal nOutBufferSize As Int32, _
        ByRef lpBytesReturned As Int32, ByVal lpOverlapped As IntPtr) As Boolean

    Private Declare Auto Function CloseHandle Lib "kernel32" _
        (ByVal hObject As IntPtr) As Boolean

    ''' <summary>
    ''' Set the brightness of the screen.
    ''' </summary>
    ''' <param name="Brightness">The Screen Brightness</param>
    ''' <remarks></remarks>
    Private Sub SetBrightness(ByRef Brightness As BRIGHTNESS)
        ' Get the display
        Dim pDisplay As IntPtr = _
        CreateFile("\\.\LCD", GENERIC_READ, SHARE_ALL, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero)

        ' Set the brightness.
        DeviceIoControl(pDisplay, IOCTL_VIDEO_SET_DISPLAY_BRIGHTNESS, _
        Brightness, Marshal.SizeOf(Brightness), IntPtr.Zero, 0, Nothing, IntPtr.Zero)

        ' Close the handle.
        CloseHandle(pDisplay)
    End Sub

    Private Sub Form28_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form3.pwr.Visible = False
    End Sub
    Private Sub Form28_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        KryptonListBox1.SelectedItem = "High Performance"
        Form3.pwr.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim a = Val(SystemInformation.PowerStatus.BatteryLifePercent * 100)
        ProgressBar1.Value = SystemInformation.PowerStatus.BatteryLifePercent * 100
        Label2.Text = "Battery Life Status : " & SystemInformation.PowerStatus.BatteryChargeStatus.ToString

        If a >= 100 Then
            Label1.Text = "Battery Life : " & SystemInformation.PowerStatus.BatteryLifePercent * 100 & "% (" & "fully charged)"
        Else
            Label1.Text = "Battery Life : " & SystemInformation.PowerStatus.BatteryLifePercent * 100 & "% remaining (discharging)"
        End If

    End Sub

    Private Sub KryptonListBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles KryptonListBox1.MouseClick

    End Sub

    Private Sub KryptonListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonListBox1.SelectedIndexChanged
        If KryptonListBox1.SelectedItem = "Power Saver" Then
            Label4.Text = "Description : Saves energy by reducing your computer's performance wherever possible."
            Label6.Text = "Screen Brightness : 1%"
            TrackBar1.Value = 1
            Dim brightness As BRIGHTNESS

            ' The brightness on DC Power
            brightness.ucDCBrightness = 1
            ' The Brightness on AC Power
            brightness.ucACBrightness = 1

            ' Call the function.
            SetBrightness(brightness)


        ElseIf KryptonListBox1.SelectedItem = "Balanced" Then
            Label4.Text = "Description : Automatically balances performance with energy consumption on capable hardware."
            Dim brightness As BRIGHTNESS
            Label6.Text = "Screen Brightness : 70%"
            TrackBar1.Value = 70
            ' The brightness on DC Power
            brightness.ucDCBrightness = 70
            ' The Brightness on AC Power
            brightness.ucACBrightness = 70

            ' Call the function.
            SetBrightness(brightness)

        ElseIf KryptonListBox1.SelectedItem = "High Performance" Then
            Label4.Text = "Description : Favours performance but may use more energy"
            Dim brightness As BRIGHTNESS
            Label6.Text = "Screen Brightness : 100%"
            TrackBar1.Value = 100
            ' The brightness on DC Power
            brightness.ucDCBrightness = 100
            ' The Brightness on AC Power
            brightness.ucACBrightness = 100

            ' Call the function.
            SetBrightness(brightness)
        End If
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Label6.Text = "Screen Brightness : " & TrackBar1.Value & "%"
        Dim brightness As BRIGHTNESS

        ' The brightness on DC Power
        brightness.ucDCBrightness = TrackBar1.Value
        ' The Brightness on AC Power
        brightness.ucACBrightness = TrackBar1.Value

        ' Call the function.
        SetBrightness(brightness)
    End Sub
End Class
