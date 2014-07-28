Public Class frmMain
    Dim StartCheck As Boolean = False

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        e.Cancel = True
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        main.mainStart()

    End Sub

    Private Sub btnAbout_Click(sender As System.Object, e As System.EventArgs) Handles btnAbout.Click




    End Sub

    Private Sub btnStartStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStartStop.Click
        If StartCheck = True Then
            StartCheck = False
            mdlCOM.GetAllPok()
            tmrIntCheck.Enabled = True
            btnStartStop.Text = "STOP"
        Else
            StartCheck = True
            mdlCOM.GetAllPok()
            tmrIntCheck.Enabled = False
            btnStartStop.Text = "START"
        End If


    End Sub
End Class
