Public Class Form35

    Private Sub shwinf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shwinf.Click
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Technical Info:")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Fault Location : <System>/Boot")
        ListBox1.Items.Add("Fault Time : " & Date.Now)
        ListBox1.Items.Add("Base Location : 0x000FC21")
        ListBox1.Items.Add("Error Code : 0x001FATAL")
        ListBox1.Items.Add("Info:")
        ListBox1.Items.Add("This file ('hal.vll') is required to enable BlixOS from contacting and managing hardware devices on your computer. If this file is missing, BlixOS cannot boot on your computer.")

    End Sub
End Class