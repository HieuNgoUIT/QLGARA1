Public Class PhieuThuTienDTO
    Private MaPhieuThu As String
    Private BienSo As String
    Private NgayThuTien As String
    Private SoTienThu As Integer
    Public Property MaPhieuThu1 As String
        Get
            Return MaPhieuThu
        End Get
        Set(value As String)
            MaPhieuThu = value
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
    Public Property NgayThuTien1 As String
        Get
            Return NgayThuTien
        End Get
        Set(value As String)
            NgayThuTien = value
        End Set
    End Property

    Public Property SoTienThu1 As Integer
        Get
            Return SoTienThu
        End Get
        Set(value As Integer)
            SoTienThu = value
        End Set
    End Property


End Class
