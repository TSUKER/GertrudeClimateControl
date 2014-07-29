Public Class frmMain
    Dim StartCheck As Boolean = True
    Dim checkInProgress As Boolean = False

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        e.Cancel = True
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Me.Text = Application.ProductName

        main.mainStart()

    End Sub

    Private Sub btnAbout_Click(sender As System.Object, e As System.EventArgs) Handles btnAbout.Click




    End Sub

    Private Sub btnStartStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStartStop.Click
        If StartCheck = True Then
            srlCOMPORT.PortName = My.Settings.COMPORT
            srlCOMPORT.Open()

            StartCheck = False
            mdlCOM.GetAllPok()
            tmrIntCheck.Enabled = True
            btnStartStop.Text = "СТОП"
        Else
            srlCOMPORT.Close()

            StartCheck = True
            tmrIntCheck.Enabled = False
            btnStartStop.Text = "СТАРТ"
        End If


    End Sub

    Private Sub tmrIntCheck_Tick(sender As System.Object, e As System.EventArgs) Handles tmrIntCheck.Tick
        If checkInProgress = False Then
            checkInProgress = True
            mdlCOM.GetAllPok()
            checkInProgress = False
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        StartCheck = True
        tmrIntCheck.Enabled = False
        btnStartStop.Text = "START"

        frmTrayIcon.iconTrayMainIcon.Dispose()
        End

    End Sub

    Private Sub btnSetting_Click(sender As System.Object, e As System.EventArgs) Handles btnSetting.Click
        frmSettings.Show()
    End Sub
End Class
