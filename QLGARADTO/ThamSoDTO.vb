Public Class ThamSoDTO
    Private SoLuongNhapToiDa As Integer
    Private SoLuongXeTrongNgay As Integer

    Public Property SoLuongNhapToiDa1 As Integer
        Get
            Return SoLuongNhapToiDa
        End Get
        Set(value As Integer)
            SoLuongNhapToiDa = value
        End Set
    End Property

    Public Property SoLuongXeTrongNgay1 As Integer
        Get
            Return SoLuongXeTrongNgay
        End Get
        Set(value As Integer)
            SoLuongXeTrongNgay = value
        End Set
    End Property
End Class
