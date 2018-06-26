Imports QLGARADTO
Imports QLGARADAL
Public Class PhieuThuTienBUS
    Dim phieuDAL As PhieuThuTienDAL
    Public Function themphieu(ByVal phieu As PhieuThuTienDTO) As String
        '1. verify data here!!
        phieuDAL = New PhieuThuTienDAL()
        '2. insert to DB
        Return phieuDAL.Them(phieu)
    End Function
    Public Function Taidulieupt()
        phieuDAL = New PhieuThuTienDAL()
        Return phieuDAL.Taidulieuphieuthu()
    End Function
End Class
