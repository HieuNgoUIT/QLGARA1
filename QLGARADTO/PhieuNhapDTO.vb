Public Class PhieuNhapDTO
    Private MaPhieuTiepNhan As String
    Private NgayTiepNhan As String

    Public Property MaPhieuTiepNhan1 As String
        Get
            Return MaPhieuTiepNhan
        End Get
        Set(value As String)
            MaPhieuTiepNhan = value
        End Set
    End Property

    Public Property NgayTiepNhan1 As String
        Get
            Return NgayTiepNhan
        End Get
        Set(value As String)
            NgayTiepNhan = value
        End Set
    End Property
End Class
