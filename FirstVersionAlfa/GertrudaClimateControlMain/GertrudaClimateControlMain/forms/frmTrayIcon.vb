Public Class frmTrayIcon


    Private Sub frmTrayIcon_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        iconTrayMainIcon.BalloonTipText = "Programm Started"
        iconTrayMainIcon.ShowBalloonTip(3243)
        iconTrayMainIcon.Visible = True
        frmMain.ShowInTaskbar = False



    End Sub


    Private Sub iconTrayMainIcon_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles iconTrayMainIcon.MouseDoubleClick
        frmMain.WindowState = FormWindowState.Normal

        frmMain.Show() : frmMain.Activate()


    End Sub

    Private Sub mnuSettings_Click(sender As System.Object, e As System.EventArgs) Handles mnuSettings.Click
        frmSettings.Show()

    End Sub

    Private Sub mnuAbout_Click(sender As System.Object, e As System.EventArgs) Handles mnuAbout.Click
        AboutBox.Show()
        MsgBox("For About information please write to email: admin@0xff.link or visit http://gcc.codeplex.com ")
    End Sub
End Class