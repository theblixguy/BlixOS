Public Class Form18

    Private Sub LinkLabel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LinkLabel1.MouseClick
        ToolTip1.Show("You can find your product key on your computer or inside the BlixOS package.", LinkLabel1)
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub

    Private Sub LinkLabel2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LinkLabel2.MouseClick
        ToolTip2.Show("Activation helps verify that your copy of BlixOS is genuine and that it has not been used on more computers than the Blix Software License Terms allow.", LinkLabel2)


    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        If TextBox1.Text = "VC2RB-TRE31-OMN64-88UXC-QS91P" Then
            Me.Hide()
            Form19.Show()
        Else
            MsgBox("Invalid product key.", MsgBoxStyle.Exclamation, "Activation Failed")
        End If

        If TextBox1.Text = "[admin] : GetProductKey()" Then
            MsgBox("BlixOS Software Licensing Protection (SLP) -> OEM Master Key : [VC2RB-TRE31-OMN64-88UXC-QS91P]", MsgBoxStyle.Information, "BlixOS Script Host")
        End If

        If TextBox1.Text = "[admin] : GetActivationID()" Then
            MsgBox("BlixOS Software Licensing Protection (SLP) -> Activation ID : [907512-7234-2]", MsgBoxStyle.Information, "BlixOS Script Host")
        End If

        If TextBox1.Text = "[admin] : GetExpirationDate()" Then
            MsgBox("BlixOS Software Licensing Protection (SLP) -> This license expires on 11th December 2010 at 19:51 PM (121980 minute(s) (90 days)", MsgBoxStyle.Information, "BlixOS Script Host")
        End If

        If TextBox1.Text = "[admin] : GetOSDetails()" Then
            MsgBox("%OS Name% : BlixOS(R), Professional. %Description% : Blix Operating System - BlixOS(R) Professional TIMEBASED_EVAL channel. %License Status% : Unlicensed. %Partial product key% : VC2RB. %Timebased activation expiration% : 121980 minute(s) or 90 days. %Remaining BlixOS rearm count(s)% : 3")
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Activate()
    End Sub
End Class
