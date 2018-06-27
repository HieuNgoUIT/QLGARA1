Imports QLGARADTO
Imports QLGARADAL
Public Class KhachHangBUS
    Dim KHDAL As KhachHangDAL
    Public Function themkh(ByVal kh As KhachHangDTO) As String
        '1. verify data here!!
        KHDAL = New PhieuThuTienDAL()
        '2. insert to DB
        Return KHDAL.Them(kh)
    End Function
    Public Function Taidulieukh()
        KHDAL = New PhieuThuTienDAL()
        Return KHDAL.Taidulieukhachang()
    End Function
End Class




