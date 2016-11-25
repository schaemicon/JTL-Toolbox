Public Class Kunde

    'Felder
    Private _kundennummer As String
    Private _internerschluessel As String
    Private _kundengruppe As String
    Private _kategorie As String
    Private _sprache As String
    Private _zahlungsart As String
    Private _anrede As String
    Private _titel As String
    Private _vorname As String
    Private _nachname As String
    Private _firma As String
    Private _firmenzusatz As String
    Private _strasse As String
    Private _adresszusatz As String
    Private _zuhaenden As String
    Private _plz As String
    Private _ort As String
    Private _bundesland As String
    Private _land As String
    Private _tel As String
    Private _fax As String
    Private _mobil As String
    Private _email As String
    Private _homepage As String
    Private _geburtstag As String
    Private _postid As String
    Private _ebayname As String
    Private _ustid As String
    Private _zahlungsziel As String
    Private _kundenherkunft As String
    Private _status As String
    Private _kommentar As String
    Private _rabatt As String
    Private _aktiv As String
    Private _newsletter As String
    Private _kassenkunde As String
    Private _gesperrt As String
    Private _drittland As String
    Private _erstelltam As String
    Private _debitorennummer As String
    Private _hrb As String
    Private _steuernummer As String
    'Konstruktoren

    'Eigenschaften
    Public Property Kundennummer As String
        Get
            Return _kundennummer
        End Get
        Set(value As String)
            _kundennummer = value
        End Set
    End Property

    Public Property InternerSchluessel As String
        Get
            Return _internerschluessel
        End Get
        Set(value As String)
            _internerschluessel = value
        End Set
    End Property

    Public Property Kundengruppe As String
        Get
            Return _kundengruppe
        End Get
        Set(value As String)
            _kundengruppe = value
        End Set
    End Property

    Public Property Kategorie As String
        Get
            Return _kategorie
        End Get
        Set(value As String)
            _kategorie = value
        End Set
    End Property

    Public Property Sprache As String
        Get
            Return _sprache
        End Get
        Set(value As String)
            _sprache = value
        End Set
    End Property

    Public Property Zahlungsart As String
        Get
            Return _zahlungsart
        End Get
        Set(value As String)
            _zahlungsart = value
        End Set
    End Property

    Public Property Anrede As String
        Get
            Return _anrede
        End Get
        Set(value As String)
            _anrede = value
        End Set
    End Property

    Public Property Titel As String
        Get
            Return _titel
        End Get
        Set(value As String)
            _titel = value
        End Set
    End Property

    Public Property Vorname As String
        Get
            Return _vorname
        End Get
        Set(value As String)
            _vorname = value
        End Set
    End Property

    Public Property Nachname As String
        Get
            Return _nachname
        End Get
        Set(value As String)
            _nachname = value
        End Set
    End Property

    Public Property Firma As String
        Get
            Return _firma
        End Get
        Set(value As String)
            _firma = value
        End Set
    End Property

    Public Property Firmenzusatz As String
        Get
            Return _firmenzusatz
        End Get
        Set(value As String)
            _firmenzusatz = value
        End Set
    End Property

    Public Property Strasse As String
        Get
            Return _strasse
        End Get
        Set(value As String)
            _strasse = value
        End Set
    End Property

    Public Property Adresszusatz As String
        Get
            Return _adresszusatz
        End Get
        Set(value As String)
            _adresszusatz = value
        End Set
    End Property

    Public Property ZuHaenden As String
        Get
            Return _zuhaenden
        End Get
        Set(value As String)
            _zuhaenden = value
        End Set
    End Property

    Public Property PLZ As String
        Get
            Return _plz
        End Get
        Set(value As String)
            _plz = value
        End Set
    End Property

    Public Property Ort As String
        Get
            Return _ort
        End Get
        Set(value As String)
            _ort = value
        End Set
    End Property

    Public Property Bundesland As String
        Get
            Return _bundesland
        End Get
        Set(value As String)
            _bundesland = value
        End Set
    End Property

    Public Property Land As String
        Get
            Return _land
        End Get
        Set(value As String)
            _land = value
        End Set
    End Property

    Public Property Tel As String
        Get
            Return _tel
        End Get
        Set(value As String)
            _tel = value
        End Set
    End Property

    Public Property Fax As String
        Get
            Return _fax
        End Get
        Set(value As String)
            _fax = value
        End Set
    End Property

    Public Property Mobil As String
        Get
            Return _mobil
        End Get
        Set(value As String)
            _mobil = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Homepage As String
        Get
            Return _homepage
        End Get
        Set(value As String)
            _homepage = value
        End Set
    End Property

    Public Property Geburtstag As String
        Get
            Return _geburtstag
        End Get
        Set(value As String)
            _geburtstag = value
        End Set
    End Property

    Public Property PostID As String
        Get
            Return _postid
        End Get
        Set(value As String)
            _postid = value
        End Set
    End Property

    Public Property EbayName As String
        Get
            Return _ebayname
        End Get
        Set(value As String)
            _ebayname = value
        End Set
    End Property

    Public Property UStID As String
        Get
            Return _ustid
        End Get
        Set(value As String)
            _ustid = value
        End Set
    End Property

    Public Property Zahlungsziel As String
        Get
            Return _zahlungsziel
        End Get
        Set(value As String)
            _zahlungsziel = value
        End Set
    End Property

    Public Property Kundenherkunft As String
        Get
            Return _kundenherkunft
        End Get
        Set(value As String)
            _kundenherkunft = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property Kommentar As String
        Get
            Return _kommentar
        End Get
        Set(value As String)
            _kommentar = value
        End Set
    End Property

    Public Property Rabatt As String
        Get
            Return _rabatt
        End Get
        Set(value As String)
            _rabatt = value
        End Set
    End Property

    Public Property Aktiv As String
        Get
            Return _aktiv
        End Get
        Set(value As String)
            _aktiv = value
        End Set
    End Property

    Public Property Newsletter As String
        Get
            Return _newsletter
        End Get
        Set(value As String)
            _newsletter = value
        End Set
    End Property

    Public Property Kassenkunde As String
        Get
            Return _kassenkunde
        End Get
        Set(value As String)
            _kassenkunde = value
        End Set
    End Property

    Public Property Gesperrt As String
        Get
            Return _gesperrt
        End Get
        Set(value As String)
            _gesperrt = value
        End Set
    End Property

    Public Property Drittland As String
        Get
            Return _drittland
        End Get
        Set(value As String)
            _drittland = value
        End Set
    End Property

    Public Property ErstelltAm As String
        Get
            Return _erstelltam
        End Get
        Set(value As String)
            _erstelltam = value
        End Set
    End Property

    Public Property Debitorennummer As String
        Get
            Return _debitorennummer
        End Get
        Set(value As String)
            _debitorennummer = value
        End Set
    End Property

    Public Property HRB As String
        Get
            Return _hrb
        End Get
        Set(value As String)
            _hrb = value
        End Set
    End Property

    Public Property Steuernummer As String
        Get
            Return _steuernummer
        End Get
        Set(value As String)
            _steuernummer = value
        End Set
    End Property

    'Ereignisse

End Class
