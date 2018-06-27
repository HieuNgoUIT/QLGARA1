Imports QLGARADAL
Imports QLGARADTO
Public Class PhieuNhapBUS
    Dim pnDAL As PhieuNhapDAL


    Public Function Taidulieu()
        pnDAL = New PhieuNhapDAL()
        Return pnDAL.Taidulieu()
    End Function
    Public Function Taidulieutyc(map As String)
        pnDAL = New PhieuNhapDAL()
        Return pnDAL.Taidulieutheoyeucau(map)
    End Function
    Public Function Taidulieuchitiet()
        pnDAL = New PhieuNhapDAL()
        Return pnDAL.Taidulieuchitiet()
    End Function
    Public Function thempn(ByVal pn As PhieuNhapDTO) As String
        '1. verify data here!!
        pnDAL = New PhieuNhapDAL()
        '2. insert to DB
        Return pnDAL.Them(pn)
    End Function
    Public Function themctpn(ByVal pn1 As PhieuChiTietDTO) As String
        '1. verify data here!!
        pnDAL = New PhieuNhapDAL()
        '2. insert to DB
        Return pnDAL.Themchitiet(pn1)
    End Function
    Public Function xoaphieu(p As String) As String
        '1. verify data here!!
        pnDAL = New PhieuNhapDAL()
        '2. insert to DB
        Return pnDAL.xoaphieu(p)
    End Function
    Public Function xoactphieu(p As String) As String
        '1. verify data here!!
        pnDAL = New PhieuNhapDAL()
        '2. insert to DB
        Return pnDAL.xoactphieu(p)
    End Function
End Class
