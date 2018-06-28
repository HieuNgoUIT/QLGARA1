Public Class vatTuDTO
    Private MaVatTu As String
    Private TenVatTu As String
    Private SoLuong As Integer
    Private DonGia As Integer

    Public Property MaVatTu1 As String
        Get
            Return MaVatTu
        End Get
        Set(value As String)
            MaVatTu = value
        End Set
    End Property

    Public Property TenVatTu1 As String
        Get
            Return TenVatTu
        End Get
        Set(value As String)
            TenVatTu = value
        End Set
    End Property

    Public Property SoLuong1 As Integer
        Get
            Return SoLuong
        End Get
        Set(value As Integer)
            SoLuong = value
        End Set
    End Property

    Public Property DonGia1 As Integer
        Get
            Return DonGia
        End Get
        Set(value As Integer)
            DonGia = value
        End Set
    End Property
End Class

