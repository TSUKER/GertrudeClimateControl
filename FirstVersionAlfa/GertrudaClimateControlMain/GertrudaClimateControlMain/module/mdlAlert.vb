Module mdlAlert
    Public Sub SoundAlertPlay()
        Dim sndAlert As New Media.SoundPlayer
        sndAlert.Stream = My.Resources.ResourceManager.GetStream("criticalsound")


        sndAlert.Play()

    End Sub

End Module
