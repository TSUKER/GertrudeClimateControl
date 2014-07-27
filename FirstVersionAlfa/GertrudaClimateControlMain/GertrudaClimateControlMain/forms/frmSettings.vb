Public Class frmSettings

    Private Sub cmbCOMport_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCOMport.SelectedIndexChanged

    End Sub

    Private Sub frmSettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbCOMport.Items.Add(sp)
        Next

        txtPetName.Text = My.Settings.PETNAME
        txtSmsApiKey.Text = My.Settings.SMS_KEY
        txtSMSfrom.Text = My.Settings.SMS_FROM
        txtSMSmsg.Text = My.Settings.SMS_MSG_TMPL
        txtSMSto.Text = My.Settings.SMS_TO
        cmbCOMport.Text = My.Settings.COMPORT


    End Sub
End Class