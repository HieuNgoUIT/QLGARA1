Public Class BaoCaoTonDTO
    Private maBaoCaoTon As String
    Private thangBaoCao As String
    Private maVatTu As String
    Private tonDau As Integer
    Private phatSinh As Integer
    Private tonCuoi As Integer
    Public Property maBaoCaoTon1 As String
        Get
            Return maBaoCaoTon
        End Get
        Set(value As String)
            maBaoCaoTon = value
        End Set
    End Property

    Public Property thangBaoCao1 As String
        Get
            Return thangBaoCao
        End Get
        Set(value As String)
            thangBaoCao = value
        End Set
    End Property

    Public Property maVatTu1 As String
        Get
            Return maVatTu
        End Get
        Set(value As String)
            maVatTu = value
        End Set
    End Property
    Public Property tonDau1 As Integer
        Get
            Return tonDau
        End Get
        Set(value As Integer)
            tonDau = value
        End Set
    End Property

    Public Property phatSinh1 As Integer
        Get
            Return phatSinh
        End Get
        Set(value As Integer)
            phatSinh = value
        End Set
    End Property

    Public Property tonCuoi1 As Integer
        Get
            Return tonCuoi
        End Get
        Set(value As Integer)
            tonCuoi = value
        End Set
    End Property
End Class
