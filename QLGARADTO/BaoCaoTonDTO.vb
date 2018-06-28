Public Class BaoCaoTonDTO
    Private MaBaoCaoTon As String
    Private ThangBaoCao As String
    Private MaVatTu As String
    Private TonDau As Integer
    Private PhatSinh As Integer
    Private TonCuoi As Integer
    Public Property MaBaoCaoTon1 As String
        Get
            Return MaBaoCaoTon
        End Get
        Set(value As String)
            MaBaoCaoTon = value
        End Set
    End Property

    Public Property ThangBaoCao1 As String
        Get
            Return ThangBaoCao
        End Get
        Set(value As String)
            ThangBaoCao = value
        End Set
    End Property

    Public Property MaVatTu1 As String
        Get
            Return MaVatTu
        End Get
        Set(value As String)
            MaVatTu = value
        End Set
    End Property
    Public Property TonDau1 As Integer
        Get
            Return TonDau
        End Get
        Set(value As Integer)
            TonDau = value
        End Set
    End Property

    Public Property PhatSinh1 As Integer
        Get
            Return PhatSinh
        End Get
        Set(value As Integer)
            PhatSinh = value
        End Set
    End Property

    Public Property TonCuoi1 As Integer
        Get
            Return TonCuoi
        End Get
        Set(value As Integer)
            TonCuoi = value
        End Set
    End Property
End Class
