Public Class Form15
    Dim txt As New TextBox

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        If Not ListView1.SelectedItems.Count = 0 Then
            For Each item As ListViewItem In ListView1.SelectedItems
                txt.Text = item.Text
                If txt.Text = "Plain" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall1
                    Form3.Panel1.BackgroundImage = My.Resources.wall1

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[1]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Colorful" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall2
                    Form3.Panel1.BackgroundImage = My.Resources.wall2

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[2]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Rainbow" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall3
                    Form3.Panel1.BackgroundImage = My.Resources.wall3

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[3]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Black and White" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall5
                    Form3.Panel1.BackgroundImage = My.Resources.wall5

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[5]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Water Fish" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall4
                    Form3.Panel1.BackgroundImage = My.Resources.wall4

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[4]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Atomize" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall6
                    Form3.Panel1.BackgroundImage = My.Resources.wall6

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[6]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Aurora" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall7
                    Form3.Panel1.BackgroundImage = My.Resources.wall7

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[7]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Sky" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall8
                    Form3.Panel1.BackgroundImage = My.Resources.wall8

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[8]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Sunrise" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall9
                    Form3.Panel1.BackgroundImage = My.Resources.wall9

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[9]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Grass" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall10
                    Form3.Panel1.BackgroundImage = My.Resources.wall10

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[10]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Animal" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall11
                    Form3.Panel1.BackgroundImage = My.Resources.wall11
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[11]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Puppies" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall12
                    Form3.Panel1.BackgroundImage = My.Resources.wall12

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[12]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Northern Lights" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall13
                    Form3.Panel1.BackgroundImage = My.Resources.wall13
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[13]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Abstract" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall14
                    Form3.Panel1.BackgroundImage = My.Resources.wall4

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[14]", False)
                    Cursor.Show()
                ElseIf txt.Text = "Skyline" Then
                    Cursor.Hide()
                    Form13.Show()
                    Form3.ListView1.BackgroundImage = My.Resources.wall15
                    Form3.Panel1.BackgroundImage = My.Resources.wall15

                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "wallval.dat", "WALL_VAL(INDEX:TO:STRING)[15]", False)
                    Cursor.Show()
                End If
            Next
        End If
    End Sub


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Form15_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form3.perso.Visible = False
    End Sub

    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.perso.Visible = True
    End Sub
End Class