Public Class PhieuChiTietDTO
    Private MaCTPTN As String
    Private MaPhieuTiepNhan As String
    Private BienSo As String
    Private SoLuongTiepNhan As Integer

    Public Property MaCTPTN1 As String
        Get
            Return MaCTPTN
        End Get
        Set(value As String)
            MaCTPTN = value
        End Set
    End Property

    Public Property MaPhieuTiepNhan1 As String
        Get
            Return MaPhieuTiepNhan
        End Get
        Set(value As String)
            MaPhieuTiepNhan = value
        End Set
    End Property

    Public Property BienSo1 As String
        Get
            Return BienSo
        End Get
        Set(value As String)
            BienSo = value
        End Set
    End Property

    Public Property SoLuongTiepNhan1 As Integer
        Get
            Return SoLuongTiepNhan
        End Get
        Set(value As Integer)
            SoLuongTiepNhan = value
        End Set
    End Property
End Class
