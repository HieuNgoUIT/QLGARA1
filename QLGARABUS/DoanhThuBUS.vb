Imports QLGARADTO
Imports QLGARADAL
Public Class DoanhThuBUS
    Dim DTDAL As DoanhThuDAL
    Private connectionString As String

    Public Function themdoanhthu(ByVal doanhthu As DoanhThuDTO) As String
        '1. verify data here!!
        DTDAL = New DoanhThuDAL()
        '2. insert to DB
        Return DTDAL.Them(doanhthu)
    End Function
    Public Function Taidulieudt()
        DTDAL = New DoanhThuDAL()
        Return DTDAL.Taidulieudoanhthu()
    End Function
    Public Function taidulieuthang() As DataTable
        Return DTDAL.taidulieuthanhtien()
    End Function
    Public Function taidulieutongdoanhthu() As DataTable
        Return DTDAL.taidulieuthanhtien()
    End Function
    Public Function taidulieumaphieusuachua() As DataTable
        Return DTDAL.taidulieuthanhtien()
    End Function
    Public Function taidulieusoluotsua() As DataTable
        Return DTDAL.taidulieuthanhtien()
    End Function
    Public Function taidulieuthanhtien() As DataTable
        Return DTDAL.taidulieuthanhtien()
    End Function

End Class