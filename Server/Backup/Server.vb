Module ServerModule

    Sub Main()
        Dim objSocket As ASOCKETLib.Socket = New ASOCKETLib.Socket()
        Dim objConstants As Constants = New Constants()
        Dim strHost As String = "localhost"
        Dim strMessage As String
        Dim numPort As Integer = 1500

        objSocket.Protocol = objConstants.asPROTOCOL_RAW
        objSocket.StartListening(numPort)
        Console.WriteLine("StartListening, result: " & objSocket.LastError.ToString() & " (" & objSocket.GetErrorDescription(objSocket.LastError) & ")")

        If objSocket.LastError = 0 Then
            ' Wait for a connection on port 1500 on this machine now...
            Console.WriteLine("Waiting for a connection...")

            Do While objSocket.ConnectionState = objConstants.asCONN_LISTENING
                objSocket.Sleep(1000)
            Loop

            If objSocket.ConnectionState = objConstants.asCONN_CONNECTED Then

                ' YES, connection established.
                Console.WriteLine("Connection established" & vbCrLf)

                strMessage = ""
                Do While objSocket.ConnectionState = objConstants.asCONN_CONNECTED And strMessage <> "Quit"

                    If objSocket.HasData Then
                        strMessage = objSocket.ReceiveString
                        Console.WriteLine("ReceiveString: " & strMessage)
                    End If
                    objSocket.Sleep(100)
                Loop

                ' And finally, disconnect
                objSocket.Disconnect()
            End If
        End If

    End Sub

End Module
