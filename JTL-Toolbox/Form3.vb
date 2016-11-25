Imports System.IO
Imports System.Text
Public Class Form3
    Dim Kundenliste As IEnumerable(Of Kunde)
    Dim Exportliste As IEnumerable(Of Kunde)
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Button3.Enabled = False
        With ListView1
            .View = View.Details
            .AllowColumnReorder = True
            .GridLines = True
        End With
        'Anpassen der Listview
        Dim ColumnHeader1 As New ColumnHeader
        With ColumnHeader1
            .Text = "Kundennummer"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader2 As New ColumnHeader
        With ColumnHeader2
            .Text = "Interner Schlüssel"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader3 As New ColumnHeader
        With ColumnHeader3
            .Text = "Kundengruppe"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader4 As New ColumnHeader
        With ColumnHeader4
            .Text = "Kategorie"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader5 As New ColumnHeader
        With ColumnHeader5
            .Text = "Sprache"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader6 As New ColumnHeader
        With ColumnHeader6
            .Text = "Zahlungsart"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader7 As New ColumnHeader
        With ColumnHeader7
            .Text = "Anrede"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader8 As New ColumnHeader
        With ColumnHeader8
            .Text = "Titel"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader9 As New ColumnHeader
        With ColumnHeader9
            .Text = "Vorname"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader10 As New ColumnHeader
        With ColumnHeader10
            .Text = "Nachname"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader11 As New ColumnHeader
        With ColumnHeader11
            .Text = "Firma"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader12 As New ColumnHeader
        With ColumnHeader12
            .Text = "Firmenzusatz"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader13 As New ColumnHeader
        With ColumnHeader13
            .Text = "Straße"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader14 As New ColumnHeader
        With ColumnHeader14
            .Text = "Adresszusatz"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader15 As New ColumnHeader
        With ColumnHeader15
            .Text = "Zu Händen"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader16 As New ColumnHeader
        With ColumnHeader16
            .Text = "PLZ"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader17 As New ColumnHeader
        With ColumnHeader17
            .Text = "Ort"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader18 As New ColumnHeader
        With ColumnHeader18
            .Text = "Bundesland"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader19 As New ColumnHeader
        With ColumnHeader19
            .Text = "Land"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader20 As New ColumnHeader
        With ColumnHeader20
            .Text = "Tel."
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader21 As New ColumnHeader
        With ColumnHeader21
            .Text = "Fax"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader22 As New ColumnHeader
        With ColumnHeader22
            .Text = "Mobil"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader23 As New ColumnHeader
        With ColumnHeader23
            .Text = "E-Mail"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader24 As New ColumnHeader
        With ColumnHeader24
            .Text = "Homepage(WWW)"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader25 As New ColumnHeader
        With ColumnHeader25
            .Text = "Geburtstag"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader26 As New ColumnHeader
        With ColumnHeader26
            .Text = "PostID"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader27 As New ColumnHeader
        With ColumnHeader27
            .TextAlign = HorizontalAlignment.Left
            .Text = "eBay-Name"
        End With
        Dim ColumnHeader28 As New ColumnHeader
        With ColumnHeader28
            .Text = "Ust-ID"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader29 As New ColumnHeader
        With ColumnHeader29
            .Text = "Zahlungsziel"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader30 As New ColumnHeader
        With ColumnHeader30
            .Text = "Kundenherkunft"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader31 As New ColumnHeader
        With ColumnHeader31
            .Text = "Status"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader32 As New ColumnHeader
        With ColumnHeader32
            .Text = "Kommentar"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader33 As New ColumnHeader
        With ColumnHeader33
            .Text = "Rabatt"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader34 As New ColumnHeader
        With ColumnHeader34
            .Text = "Aktiv"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader35 As New ColumnHeader
        With ColumnHeader35
            .Text = "Newsletter"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader36 As New ColumnHeader
        With ColumnHeader36
            .Text = "Kassenkunde"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader37 As New ColumnHeader
        With ColumnHeader37
            .Text = "Gesperrt"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader38 As New ColumnHeader
        With ColumnHeader38
            .Text = "Drittland"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader39 As New ColumnHeader
        With ColumnHeader39
            .Text = "Erstellt am"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader40 As New ColumnHeader
        With ColumnHeader40
            .Text = "Debitorennummer"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader41 As New ColumnHeader
        With ColumnHeader41
            .Text = "HRB"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim ColumnHeader42 As New ColumnHeader
        With ColumnHeader42
            .Text = "Steuernummer"
            .TextAlign = HorizontalAlignment.Left
        End With
        With ListView1
            .Columns.Add(ColumnHeader1)
            .Columns.Add(ColumnHeader2)
            .Columns.Add(ColumnHeader3)
            .Columns.Add(ColumnHeader4)
            .Columns.Add(ColumnHeader5)
            .Columns.Add(ColumnHeader6)
            .Columns.Add(ColumnHeader7)
            .Columns.Add(ColumnHeader8)
            .Columns.Add(ColumnHeader9)
            .Columns.Add(ColumnHeader10)
            .Columns.Add(ColumnHeader11)
            .Columns.Add(ColumnHeader12)
            .Columns.Add(ColumnHeader13)
            .Columns.Add(ColumnHeader14)
            .Columns.Add(ColumnHeader15)
            .Columns.Add(ColumnHeader16)
            .Columns.Add(ColumnHeader17)
            .Columns.Add(ColumnHeader18)
            .Columns.Add(ColumnHeader19)
            .Columns.Add(ColumnHeader20)
            .Columns.Add(ColumnHeader21)
            .Columns.Add(ColumnHeader22)
            .Columns.Add(ColumnHeader23)
            .Columns.Add(ColumnHeader24)
            .Columns.Add(ColumnHeader25)
            .Columns.Add(ColumnHeader26)
            .Columns.Add(ColumnHeader27)
            .Columns.Add(ColumnHeader28)
            .Columns.Add(ColumnHeader29)
            .Columns.Add(ColumnHeader30)
            .Columns.Add(ColumnHeader31)
            .Columns.Add(ColumnHeader32)
            .Columns.Add(ColumnHeader33)
            .Columns.Add(ColumnHeader34)
            .Columns.Add(ColumnHeader35)
            .Columns.Add(ColumnHeader36)
            .Columns.Add(ColumnHeader37)
            .Columns.Add(ColumnHeader38)
            .Columns.Add(ColumnHeader39)
            .Columns.Add(ColumnHeader40)
            .Columns.Add(ColumnHeader41)
            .Columns.Add(ColumnHeader42)
        End With

        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Me.Button1.Enabled = False
        Ameise.StartAmeise(My.Settings.kdtemplateid, My.Settings.outputpath, My.Settings.kdoutputfile, True)
        'Warten bis der Prozess beendet ist
        Ameise.ProcAmeise.WaitForExit()
        'Einlesen der Datei mit LINQ
        Kundenliste = From line In File.ReadAllLines(My.Settings.outputpath & "\" & My.Settings.kdoutputfile, Encoding.Default)
                      Let personRecord = line.Split(";"c)
                      Select New Kunde With {
                        .Kundennummer = personRecord(0),
                        .InternerSchluessel = personRecord(1),
                        .Kundengruppe = personRecord(2),
                        .Kategorie = personRecord(3),
                        .Sprache = personRecord(4),
                        .Zahlungsart = personRecord(5),
                        .Anrede = personRecord(6),
                        .Titel = personRecord(7),
                        .Vorname = personRecord(8),
                        .Nachname = personRecord(9),
                        .Firma = personRecord(10),
                        .Firmenzusatz = personRecord(11),
                        .Strasse = personRecord(12),
                        .Adresszusatz = personRecord(13),
                        .ZuHaenden = personRecord(14),
                        .PLZ = personRecord(15),
                        .Ort = personRecord(16),
                        .Bundesland = personRecord(17),
                        .Land = personRecord(18),
                        .Tel = personRecord(19),
                        .Fax = personRecord(20),
                        .Mobil = personRecord(21),
                        .Email = personRecord(22),
                        .Homepage = personRecord(23),
                        .Geburtstag = personRecord(24),
                        .PostID = personRecord(25),
                        .EbayName = personRecord(26),
                        .UStID = personRecord(27),
                        .Zahlungsziel = personRecord(28),
                        .Kundenherkunft = personRecord(29),
                        .Status = personRecord(30),
                        .Kommentar = personRecord(31),
                        .Rabatt = personRecord(32),
                        .Aktiv = personRecord(33),
                        .Newsletter = personRecord(34),
                        .Kassenkunde = personRecord(35),
                        .Gesperrt = personRecord(36),
                        .Drittland = personRecord(37),
                        .ErstelltAm = personRecord(38),
                        .Debitorennummer = personRecord(39),
                        .HRB = personRecord(40),
                        .Steuernummer = personRecord(41)}

        'Anzahl der Datensätze für die Progressbar ermitteln
        ProgressBar1.Maximum = Kundenliste.Count

        Dim zahlungsarten As IEnumerable(Of String) = From kd In Kundenliste
                                                      Select kd.Zahlungsart
        Dim nodupZahlungsart = zahlungsarten.Distinct()
        'Ausgabe der Abfrage in einer Listlistview
        For Each item In Kundenliste
            Dim listItem As New ListViewItem(item.Kundennummer)
            With listItem
                .SubItems.Add(item.InternerSchluessel)
                .SubItems.Add(item.Kundengruppe)
                .SubItems.Add(item.Kategorie)
                .SubItems.Add(item.Sprache)
                .SubItems.Add(item.Zahlungsart)
                .SubItems.Add(item.Anrede)
                .SubItems.Add(item.Titel)
                .SubItems.Add(item.Vorname)
                .SubItems.Add(item.Nachname)
                .SubItems.Add(item.Firma)
                .SubItems.Add(item.Firmenzusatz)
                .SubItems.Add(item.Strasse)
                .SubItems.Add(item.Adresszusatz)
                .SubItems.Add(item.ZuHaenden)
                .SubItems.Add(item.PLZ)
                .SubItems.Add(item.Ort)
                .SubItems.Add(item.Bundesland)
                .SubItems.Add(item.Land)
                .SubItems.Add(item.Tel)
                .SubItems.Add(item.Fax)
                .SubItems.Add(item.Mobil)
                .SubItems.Add(item.Email)
                .SubItems.Add(item.Homepage)
                .SubItems.Add(item.Geburtstag)
                .SubItems.Add(item.PostID)
                .SubItems.Add(item.EbayName)
                .SubItems.Add(item.UStID)
                .SubItems.Add(item.Zahlungsziel)
                .SubItems.Add(item.Kundenherkunft)
                .SubItems.Add(item.Status)
                .SubItems.Add(item.Kommentar)
                .SubItems.Add(item.Rabatt)
                .SubItems.Add(item.Aktiv)
                .SubItems.Add(item.Newsletter)
                .SubItems.Add(item.Kassenkunde)
                .SubItems.Add(item.Gesperrt)
                .SubItems.Add(item.Drittland)
                .SubItems.Add(item.ErstelltAm)
                .SubItems.Add(item.Debitorennummer)
                .SubItems.Add(item.HRB)
                .SubItems.Add(item.Steuernummer)
            End With
            ListView1.Items.Add(listItem)
            'Progressbar Wert um einen erhöhen
            ProgressBar1.Value += 1
        Next
        For Each item In nodupZahlungsart
            CheckedListBox1.Items.Add(item)
        Next
        ProgressBar1.Value = 0
        Button2.Enabled = True
        ProcAmeise.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False

        Dim dStart As Integer = My.Settings.DebitorenStart
        Dim dEnde As Integer = My.Settings.DebitorenEnde

        ListView1.Items.Clear()
        Exportliste = From kd In Kundenliste
                      Where kd.Debitorennummer = String.Empty Or kd.Debitorennummer = "0" And CheckedListBox1.CheckedItems.Contains(kd.Zahlungsart)
                      Select kd

        ProgressBar1.Maximum = Exportliste.Count

        If Exportliste.Count > 0 Then
            For Each item In Exportliste
                'Hat der Kunde eine Debitorennummer?
                If item.Debitorennummer = String.Empty Or item.Debitorennummer = "0" Then
                    'Die kleinste freie Nummer ermitteln
                    Dim i As Integer = 0
                    For i = dStart To dEnde
                        Dim query = From kd In Kundenliste
                                    Where kd.Debitorennummer = i.ToString
                                    Select kd
                        'Wenn keine Datensätze zurückgegeben werden ist die Nummer noch frei!
                        If query.Count = 0 Then
                            item.Debitorennummer = i.ToString
                            'Startnummer neu festlegen.
                            dStart = i + 1
                            Exit For
                        End If
                    Next
                End If
                'Listenfeld wieder neue befüllen
                Dim listItem As New ListViewItem(item.Kundennummer)
                With listItem
                    .SubItems.Add(item.InternerSchluessel)
                    .SubItems.Add(item.Kundengruppe)
                    .SubItems.Add(item.Kategorie)
                    .SubItems.Add(item.Sprache)
                    .SubItems.Add(item.Zahlungsart)
                    .SubItems.Add(item.Anrede)
                    .SubItems.Add(item.Titel)
                    .SubItems.Add(item.Vorname)
                    .SubItems.Add(item.Nachname)
                    .SubItems.Add(item.Firma)
                    .SubItems.Add(item.Firmenzusatz)
                    .SubItems.Add(item.Strasse)
                    .SubItems.Add(item.Adresszusatz)
                    .SubItems.Add(item.ZuHaenden)
                    .SubItems.Add(item.PLZ)
                    .SubItems.Add(item.Ort)
                    .SubItems.Add(item.Bundesland)
                    .SubItems.Add(item.Land)
                    .SubItems.Add(item.Tel)
                    .SubItems.Add(item.Fax)
                    .SubItems.Add(item.Mobil)
                    .SubItems.Add(item.Email)
                    .SubItems.Add(item.Homepage)
                    .SubItems.Add(item.Geburtstag)
                    .SubItems.Add(item.PostID)
                    .SubItems.Add(item.EbayName)
                    .SubItems.Add(item.UStID)
                    .SubItems.Add(item.Zahlungsziel)
                    .SubItems.Add(item.Kundenherkunft)
                    .SubItems.Add(item.Status)
                    .SubItems.Add(item.Kommentar)
                    .SubItems.Add(item.Rabatt)
                    .SubItems.Add(item.Aktiv)
                    .SubItems.Add(item.Newsletter)
                    .SubItems.Add(item.Kassenkunde)
                    .SubItems.Add(item.Gesperrt)
                    .SubItems.Add(item.Drittland)
                    .SubItems.Add(item.ErstelltAm)
                    .SubItems.Add(item.Debitorennummer)
                    .SubItems.Add(item.HRB)
                    .SubItems.Add(item.Steuernummer)
                End With
                ListView1.Items.Add(listItem)
                'Progressbar Wert um einen erhöhen
                ProgressBar1.Value += 1
            Next
        End If
        Button3.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Streamwriter öffnen
        Dim Path As String = My.Settings.outputpath & "\" & My.Settings.kdinputfile
        Using sw As New StreamWriter(Path, False, Encoding.UTF8)
            Dim sep As String = ";"
            For Each item As ListViewItem In ListView1.Items
                For i As Integer = 0 To ListView1.Columns.Count - 1
                    sw.Write(item.SubItems(i).Text)
                    If i < ListView1.Columns.Count - 1 Then
                        sw.Write(sep)
                    End If
                Next
                sw.Write(sw.NewLine)
            Next
        End Using

        'Import der Daten in die JTL-Wawi
        Ameise.StartAmeise(My.Settings.kditemplateid, My.Settings.outputpath, My.Settings.kdinputfile, False)
        'Warten bis der Input abgeschlossen ist
        Ameise.ProcAmeise.WaitForExit()
        ProcAmeise.Close()
        Me.Close()
    End Sub
End Class