Public Class studentdetails
    Private _studnum As String
    Private _lastname As String
    Private _middlename As String
    Private _firstname As String
    Private _course As String
    Private _year As String
    Private _section As String
    Private _status As String
    Private _telnum As Integer
    Private _address As String
    Private _guardian As String
    Private _emailad As String
    Private _semester As String
    Private _sex As String
#Region "Constructors"
    Public Sub New()
        'Default Constructor
        _studnum = ""
        _lastname = ""
        _middlename = ""
        _firstname = ""
        _course = ""
        _year = ""
        _section = ""
        _status = ""
        _telnum = ""
        _address = ""
        _guardian = ""
        _emailad = ""
        _semester = ""
        _sex = ""
    End Sub

    Public Sub New(ByVal studnum As String, ByVal lastname As String,
                   ByVal middlename As String, ByVal firstname As String,
                   ByVal course As String, ByVal year As String,
                   ByVal section As String, ByVal status As String,
                   ByVal telnum As Integer, ByVal address As String,
                   ByVal guardian As String, ByVal emailad As String,
                   ByVal semester As String, ByVal sex As String)

        Me._studnum = studnum
        Me._lastname = lastname
        Me._middlename = middlename
        Me._firstname = firstname
        Me._course = course
        Me._year = year
        Me._section = section
        Me._status = status
        Me._telnum = telnum
        Me._address = address
        Me._guardian = guardian
        Me._emailad = emailad
        Me._semester = semester
        Me._sex = sex
    End Sub
#End Region
#Region "Property"
    Public Property studnum As String
        Get
            Return _studnum
        End Get
        Set(ByVal value As String)
            _studnum = value
        End Set
    End Property
    Public Property lastname As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property
    Public Property middlename As String
        Get
            Return _middlename
        End Get
        Set(ByVal value As String)
            _middlename = value
        End Set
    End Property
    Public Property firstname As String
        Get
            Return _firstname
        End Get
        Set(ByVal value As String)
            _firstname = value
        End Set
    End Property
    Public Property course As String
        Get
            Return _course
        End Get
        Set(ByVal value As String)
            _course = value
        End Set
    End Property
    Public Property year As String
        Get
            Return _year
        End Get
        Set(ByVal value As String)
            _year = value
        End Set
    End Property
    Public Property section As String
        Get
            Return _section
        End Get
        Set(ByVal value As String)
            _section = value
        End Set
    End Property
    Public Property status As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property
    Public Property telnum As Integer
        Get
            Return _telnum
        End Get
        Set(ByVal value As Integer)
            _telnum = value
        End Set
    End Property
    Public Property address As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property
    Public Property guardian As String
        Get
            Return _guardian
        End Get
        Set(ByVal value As String)
            _guardian = value
        End Set
    End Property
    Public Property emailad As String
        Get
            Return _emailad
        End Get
        Set(ByVal value As String)
            _emailad = value
        End Set
    End Property
    Public Property semester As String
        Get
            Return _semester
        End Get
        Set(ByVal value As String)
            _semester = value
        End Set
    End Property
    Public Property sex As String
        Get
            Return _sex
        End Get
        Set(ByVal value As String)
            _sex = value
        End Set
    End Property
#End Region
End Class
