Imports QLGARADTO
Imports QLGARADAL
Public Class DoanhThuBUS
    Dim DTDAL As DoanhThuDAL
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
End Class