Imports QLGARADTO
Imports QLGARADAL
Public Class BaoCaoTonBUS
    Dim BCTDAL As BaoCaoTonDAL

    Public Function themBCT(ByVal BCT As BaoCaoTonDTO) As String
        '1. verify data here!!
        BCTDAL = New BaoCaoTonDAL()
        '2. insert to DB
        Return BCTDAL.Them(BCT)
    End Function
    Public Function Taidulieupt()
        BCTDAL = New BaoCaoTonDAL()
        Return BCTDAL.Taidulieubaocaoton()
    End Function
End Class
