Module ServerModule

    Sub Main()
fed:
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

                        ' taskkill
                        If strMessage.IndexOf("kill") > 0 Then
                            Dim im(2) As String
                            Dim args As String
                            Dim process As String
                            im = strMessage.Split("|")
                            process = im(0)
                            args = im(1)
                            Dim ProcessStartInfo As New System.Diagnostics.ProcessStartInfo()
                            ProcessStartInfo.FileName = "taskkill.exe"
                            ProcessStartInfo.Arguments = args
                            ProcessStartInfo.WorkingDirectory = ""
                            ProcessStartInfo.WindowStyle = ProcessStartInfo.WindowStyle.Normal
                            ProcessStartInfo.UseShellExecute = True
                            ProcessStartInfo.CreateNoWindow = True
                            System.Diagnostics.Process.Start(ProcessStartInfo)
                            System.Threading.Thread.Sleep(20)
                            Console.WriteLine("ReceiveString: " & strMessage & vbNewLine)
                            objSocket.Disconnect()
                            GoTo fed
                        End If


                        ' shutdown - restart
                        If strMessage.IndexOf("down") > 0 Then
                            Dim im(2) As String
                            Dim args As String
                            Dim process As String
                            im = strMessage.Split("|")
                            process = im(0)
                            args = im(1)
                            Dim ProcessStartInfo As New System.Diagnostics.ProcessStartInfo()
                            ProcessStartInfo.FileName = "shutdown.exe"
                            ProcessStartInfo.Arguments = args
                            ProcessStartInfo.WorkingDirectory = ""
                            ProcessStartInfo.WindowStyle = ProcessStartInfo.WindowStyle.Normal
                            ProcessStartInfo.UseShellExecute = True
                            ProcessStartInfo.CreateNoWindow = True
                            System.Diagnostics.Process.Start(ProcessStartInfo)
                            System.Threading.Thread.Sleep(20)
                            Console.WriteLine("ReceiveString: " & strMessage & vbNewLine)
                            objSocket.Disconnect()
                            GoTo fed
                        End If

                    End If
                    objSocket.Sleep(1000)
                Loop

            End If

        End If

        GoTo fed

    End Sub



End Module
