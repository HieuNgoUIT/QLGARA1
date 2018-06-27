Imports QLGARADTO
Imports QLGARADAL
Public Class PhieuSuaChuaBUS
    Dim PSCDAL As PhieuSuaChuaDAL
    Public Function themphieusuachua(ByVal phieusuachua As PhieuSuaChuaDTO) As String
        '1. verify data here!!
        PSCDAL = New PhieuSuaChuaDAL()
        '2. insert to DB
        Return PSCDAL.Them(phieusuachua)
    End Function
    Public Function Taidulieupsc()
        PSCDAL = New PhieuSuaChuaDAL()
        Return PSCDAL.Taidulieuphieusuachua()
    End Function
End Class
