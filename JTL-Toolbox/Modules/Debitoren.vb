Module Debitoren
    Public Function GetFreieNummer(sTheField As String, sTheTable As String, Optional lStart As Integer = 10000) As Integer
        Dim sSQL As String
        'Gibt es in der Tabelle den Startwert?
        GetFreieNummer = lStart
        sSQL = "SELECT [" & sTheField & "]  " _
            & " FROM [" & sTheTable & "]    " _
            & "WHERE [" & sTheField & "] = " & lStart
    End Function
End Module
