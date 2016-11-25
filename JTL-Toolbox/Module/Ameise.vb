Module Ameise
    Public ProcAmeise As New System.Diagnostics.Process()
    Private export As Boolean = False
    Public Sub StartAmeise(template As String, path As String, file As String, type As Boolean)
        'Festlegen ob Export oder Import
        export = type
        'String für den Start der Wawi zusammenstellen
        Dim sType As String
        If export = True Then
            sType = " -o "
        Else
            sType = " -i "
        End If
        Dim start As String = My.Settings.PathWawi &
            "\JTL-wawi-ameise.exe"
        Dim param As String = "-s " & My.Settings.server &
                              " -d " & My.Settings.Database &
                              " -u " & My.Settings.User &
                              " -p " & My.Settings.Password &
                              " -t " & template &
                              sType & path & "\" & file
        'Ereignis festlegen, der das Beenden der JTL-Wawi-Ameise überwacht.
        ProcAmeise.EnableRaisingEvents = False
        AddHandler ProcAmeise.Exited, AddressOf ProcAmeise_Exited
        ProcAmeise.StartInfo.FileName = start
        ProcAmeise.StartInfo.Arguments = param
        ProcAmeise.Start()
    End Sub

    Private Sub ProcAmeise_Exited(sender As Object, e As EventArgs)
        If export = True Then
            MessageBox.Show("Die Daten wurden exportiert und werden mit einem Klick auf OK eingelesen")
        Else
            MessageBox.Show("Die Daten wurden importiert.")
        End If
    End Sub
End Module
