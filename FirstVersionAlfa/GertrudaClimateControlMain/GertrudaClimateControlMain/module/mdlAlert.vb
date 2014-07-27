Imports System
Imports System.Net
Imports System.IO

Module mdlAlert
    Public smsru As String = "http://sms.ru/sms/send?api_id="
    Public Sub SoundAlertPlay()
        Dim sndAlert As New Media.SoundPlayer
        sndAlert.Stream = My.Resources.ResourceManager.GetStream("criticalsound")


        sndAlert.Play()

    End Sub
    Public Sub SMSalert(Message As String)
        Dim xmlfilepath As String
        Dim msgN As String
        Dim smsTo As String
        Dim strFrom As String = My.Settings.SMS_FROM

        If My.Settings.SMS_ENABLE = True Then


            smsTo = My.Settings.SMS_TO

            xmlfilepath = Path.Combine(Application.CommonAppDataPath, "tmp.xml")

            'Attention! Your Pet ({PET_NAME}) be in a position to unfavorable atmospheric ambience
            'Внимание! Ваш любимец ({PET_NAME}) находиться в ситуации с неблагоприятной атмосферной обстановкой

            msgN = "CRITICAL|" & My.Settings.SMS_MSG_TMPL.ToString & "|"
            msgN = msgN.Replace("{PET_NAME}", My.Settings.PETNAME)
            msgN = msgN.Replace(" ", "+")


            Using wc As New WebClient()
                Dim startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
                wc.DownloadFile(smsru & My.Settings.SMS_KEY & "&from=" & strFrom & "&to=" & smsTo & "&text=" & msgN & "&partner_id=29591", xmlfilepath)
            End Using

        End If
    End Sub

End Module
