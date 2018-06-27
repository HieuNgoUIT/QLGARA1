Imports QLGARADTO
Imports QLGARADAL
Public Class VatTuBUS
    Dim VTDAL As VatTuDAL
    Public Function themvattu(ByVal vattu As vatTuDTO) As String
        '1. verify data here!!
        VTDAL = New VatTuDAL()
        '2. insert to DB
        Return VTDAL.Them(vattu)
    End Function
    Public Function Taidulieuvt()
        VTDAL = New VatTuDAL()
        Return VTDAL.Taidulieuvattu()
    End Function
End Class