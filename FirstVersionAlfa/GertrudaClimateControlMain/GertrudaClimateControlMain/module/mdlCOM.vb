Module mdlCOM
    Dim comState As Boolean = True
    Public sCom As String = My.Settings.COMPORT

    Public Function GetStringFromCOMPort()
        sCom = My.Settings.COMPORT
        If comState = False Then
            Return "BUSY"
            Exit Function
        Else
            comState = False

            Dim stringFromCOM As String
            stringFromCOM = ""

            With frmMain.srlCOMPORT

                .PortName = sCom
                .Open()
                If .IsOpen = True Then
                    .WriteLine("H\r\n")
                    MsgBox("w-ok")
                    stringFromCOM = .ReadLine.ToString()
                    .Close()
                End If

            End With

            comState = True
            Return stringFromCOM

        End If
    End Function
    Public Function SendStringToCOMPort(toCOM As String)

        Dim stringFromCOM As String
        stringFromCOM = ""
        sCom = My.Settings.COMPORT

        If comState = False Then
            Return "BUSY"
            Exit Function
        Else
            comState = False

            With frmMain.srlCOMPORT

                .PortName = sCom
                .Open()
                If .IsOpen = True Then
                    .WriteLine("H\r\n")
                    MsgBox("w-ok")
                    stringFromCOM = .ReadLine.ToString()
                    .Close()
                End If

            End With

            comState = True
            Return stringFromCOM

        End If
    End Function
    Public Function GetAllPok()

        sCom = My.Settings.COMPORT

        If comState = False Then
            Return "BUSY"
            Exit Function
        Else
            comState = False

            Dim humidity As String
            Dim Temrature As String

            Dim stringFromCOM As String
            stringFromCOM = ""

            'get temperature
            With frmMain.srlCOMPORT

                .PortName = sCom
                .Open()
                If .IsOpen = True Then
                    .WriteLine("67.00") '("T\r\n")
                    MsgBox("w-t-ok")
                    humidity = .ReadLine.ToString()
                    .Close()
                End If
            End With

            'get humudity
            With frmMain.srlCOMPORT
                .PortName = sCom
                .Open()
                If .IsOpen = True Then
                    .WriteLine("78.00") '("H\r\n")
                    MsgBox("w-t-ok")
                    Temrature = .ReadLine.ToString()
                    .Close()
                End If
            End With

            comState = True

            humidity = humidity.Replace(".", ",")
            Temrature = Temrature.Replace(".", ",")

            With frmMain
                .lblNH.Text = CInt(humidity)
                .lblNT.Text = CInt(Temrature)

                'check critical temperature
                If My.Settings.CRITICAL_T_MAX < .lblNT.Text > My.Settings.CRITICAL_T_MIN Then
                    .lblNT.BackColor = Color.Green
                Else
                    .lblNT.BackColor = Color.Red
                End If
                'check critical humidity
                If My.Settings.CRITICAL_H_MAX < .lblNH.Text > My.Settings.CRITICAL_H_MIN Then
                    .lblNH.BackColor = Color.Green
                Else
                    .lblNH.BackColor = Color.Red
                End If

            End With

            Return "OK"

        End If
    End Function

End Module
