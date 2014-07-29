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

                ' .PortName = sCom
                ' .Open()
                If .IsOpen = True Then
                    .WriteLine("T")
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

                ' .PortName = sCom
                '  .Open()
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
        On Error GoTo 653

        main.WriteToErrorLog("GetAllPok - start", "Getallpok")

        sCom = My.Settings.COMPORT

        If comState = False Then
            Return "BUSY"
            main.WriteToErrorLog("COM port - busy", "Getallpok")
            Exit Function
        Else
            comState = False

            Dim humidity As String = 0
            Dim Temrature As String = 0

            Dim stringFromCOM As String
            stringFromCOM = ""

            'get temperature
            With frmMain.srlCOMPORT

                ' .PortName = sCom
                ' .Open()
                If .IsOpen = True Then
                    .WriteLine("H") 'FOR TEST UART RX=TX: ("67.00")
                    '  MsgBox("w-t-ok")
                    main.WriteToErrorLog("GetAllPok - check H", "Getallpok")
                    humidity = .ReadLine.ToString()
                    main.WriteToErrorLog("GetAllPok - Get H =" & humidity, "Getallpok")
                    ' .Close()
                End If
            End With

            'get humudity
            With frmMain.srlCOMPORT
                ' .PortName = sCom
                ' .Open()
                If .IsOpen = True Then
                    .WriteLine("T") 'FOR TEST UART RX=TX:("78.00")
                    main.WriteToErrorLog("GetAllPok - check T", "Getallpok")
                    '   MsgBox("w-t-ok")
                    Temrature = .ReadLine.ToString()
                    main.WriteToErrorLog("GetAllPok - Get T =" & Temrature, "Getallpok")
                    '    .Close()
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
653:    main.WriteToErrorLog("GetAllPok - Error=" & Err.Description.ToString & " | " & Err.GetException.ToString, "Getallpok")

    End Function

End Module
