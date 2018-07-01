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
    Public Function taidulieumabaocaoton() As DataTable
        Return BCTDAL.taidulieumabaocaoton()
    End Function
    Public Function taidulieuthangbaocao() As DataTable
        Return BCTDAL.taidulieuthangbaocao()
    End Function
    Public Function taidulieumavattu() As DataTable
        Return BCTDAL.taidulieuthangbaocao()
    End Function
    Public Function taidulieutondau() As DataTable
        Return BCTDAL.taidulieutondau()
    End Function
    Public Function taidulieuphatsinh() As DataTable
        Return BCTDAL.taidulieuphatsinh()
    End Function
    Public Function taidulieutoncuoi() As DataTable
        Return BCTDAL.taidulieutoncuoi()
    End Function
End Class
