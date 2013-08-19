Public Class Form22

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Try
            Dim Val As String = Nothing
            Dim Result As New System.Text.StringBuilder
            For Each Character As Byte In System.Text.ASCIIEncoding.ASCII.GetBytes(TextBox1.Text)
                Result.Append(Convert.ToString(Character, 2).PadLeft(8, "0"))
                Result.Append(" ")
            Next
            Val = Result.ToString.Substring(0, Result.ToString.Length - 1)
            TextBox2.Text = Val
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "error.lod", Date.Now & "<|>" & ex.ToString, True)
        End Try
        
    End Sub

    Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton2.Click
        Try
            Dim Val As String = Nothing
            Dim Characters As String = System.Text.RegularExpressions.Regex.Replace(TextBox1.Text, "[^01]", "")
            Dim ByteArray((Characters.Length / 8) - 1) As Byte
            For Index As Integer = 0 To ByteArray.Length - 1
                ByteArray(Index) = Convert.ToByte(Characters.Substring(Index * 8, 8), 2)
            Next
            Val = System.Text.ASCIIEncoding.ASCII.GetString(ByteArray)
            TextBox2.Text = Val
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "error.lod", Date.Now & "<|>" & ex.ToString, True)
        End Try
        
    End Sub

    Private Sub Form22_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form3.txt2bin.Visible = False
    End Sub

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.txt2bin.Visible = True
    End Sub
End Class
