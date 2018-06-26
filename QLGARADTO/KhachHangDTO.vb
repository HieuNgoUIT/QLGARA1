Public Class KhachHangDTO
    Private TenChuXe As String
    Private Email As String
    Private MaKhachHang As String
    Private TienNo As Integer
    Private DiaChi As String
    Private DienThoai As String

    Public Property TenChuXe1 As String
        Get
            Return TenChuXe
        End Get
        Set(value As String)
            TenChuXe = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property

    Public Property MaKhachHang1 As String
        Get
            Return MaKhachHang
        End Get
        Set(value As String)
            MaKhachHang = value
        End Set
    End Property

    Public Property TienNo1 As Integer
        Get
            Return TienNo
        End Get
        Set(value As Integer)
            TienNo = value
        End Set
    End Property

    Public Property DiaChi1 As String
        Get
            Return DiaChi
        End Get
        Set(value As String)
            DiaChi = value
        End Set
    End Property

    Public Property DienThoai1 As String
        Get
            Return DienThoai
        End Get
        Set(value As String)
            DienThoai = value
        End Set
    End Property
End Class
