' This sample connects to the local host on port 1500. 
' It  attempts to establish a connection, and send some ascii strings to server process.
' NOTE: Run the server application before running the client application.

Module ClientModule

    Sub Main()
        Dim objSocket As ASOCKETLib.Socket = New ASOCKETLib.Socket()
        Dim objConstants As Constants = New Constants()
        Dim strHost As String = "localhost"
        Dim strMessage As String
        Dim numPort As Integer = 1500

        objSocket.Protocol = objConstants.asPROTOCOL_RAW
        objSocket.Connect(strHost, numPort)
        Console.WriteLine("Connect, result: " & objSocket.LastError.ToString() & " (" & objSocket.GetErrorDescription(objSocket.LastError) & ")" & vbCrLf)
        If objSocket.LastError = 0 Then
            ' Send some strings now

            strMessage = "This is just a message"
            objSocket.SendString(strMessage, False)
            Console.WriteLine("SendString '" & strMessage & "', result: " & objSocket.LastError.ToString() & " (" & objSocket.GetErrorDescription(objSocket.LastError) & ")" & vbCrLf)

            objSocket.Sleep(3000)

            strMessage = "And this is another message"
            objSocket.SendString(strMessage, False)
            Console.WriteLine("SendString '" & strMessage & "', result: " & objSocket.LastError.ToString() & " (" & objSocket.GetErrorDescription(objSocket.LastError) & ")" & vbCrLf)

            objSocket.Sleep(3000)

            strMessage = "Quit"
            objSocket.SendString(strMessage, False)
            Console.WriteLine("SendString '" & strMessage & "', result: " & objSocket.LastError.ToString() & " (" & objSocket.GetErrorDescription(objSocket.LastError) & ")" & vbCrLf)

            objSocket.Sleep(3000)

            ' And finally, disconnect
            objSocket.Disconnect()
        End If

    End Sub

End Module
