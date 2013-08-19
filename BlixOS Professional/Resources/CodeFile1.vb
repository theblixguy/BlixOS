Namespace Webcam
    Public Class Capture
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
    End Class
End Namespace