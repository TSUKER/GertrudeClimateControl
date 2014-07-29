Public Class frmSettings

    Private Sub cmbCOMport_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCOMport.SelectedIndexChanged

    End Sub

    Private Sub frmSettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbCOMport.Items.Add(sp)
        Next

        txtSmsApiKey.Text = My.Settings.SMS_KEY
        txtSMSfrom.Text = My.Settings.SMS_FROM
        txtSMSmsg.Text = My.Settings.SMS_MSG_TMPL
        txtSMSto.Text = My.Settings.SMS_TO
        If My.Settings.SMS_ENABLE = True Then checkSmsEnable.CheckState = CheckState.Checked
        If My.Settings.SMS_ENABLE = False Then checkSmsEnable.CheckState = CheckState.Unchecked

        txtPetName.Text = My.Settings.PETNAME
        cmbCOMport.Text = My.Settings.COMPORT

        humMAX.Value = My.Settings.CRITICAL_H_MAX
        humMIN.Value = My.Settings.CRITICAL_H_MIN
        tmpMAX.Value = My.Settings.CRITICAL_T_MAX
        tmpMin.Value = My.Settings.CRITICAL_T_MIN



    End Sub

    Private Sub btnAply_Click(sender As System.Object, e As System.EventArgs) Handles btnAply.Click
        'main settings save
        txtPetName.Text = My.Settings.PETNAME
        cmbCOMport.Text = My.Settings.COMPORT
        'sms alert - settings save
        If checkSmsEnable.CheckState = CheckState.Checked Then
            My.Settings.SMS_ENABLE = True
        Else
            My.Settings.SMS_ENABLE = False
        End If
        My.Settings.SMS_KEY = txtSmsApiKey.Text
        My.Settings.SMS_FROM = txtSMSfrom.Text
        My.Settings.SMS_MSG_TMPL = txtSMSmsg.Text
        My.Settings.SMS_TO = txtSMSto.Text
        'min\max limits check
        If tmpMAX.Value < tmpMin.Value Then tmpMAX.Value = tmpMin.Value - 1
        If humMAX.Value < humMIN.Value Then humMAX.Value = humMIN.Value - 1
        'save min\max limits
        My.Settings.CRITICAL_H_MAX = humMAX.Value
        My.Settings.CRITICAL_H_MIN = humMIN.Value
        My.Settings.CRITICAL_T_MAX = tmpMAX.Value
        My.Settings.CRITICAL_T_MIN = tmpMin.Value

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class