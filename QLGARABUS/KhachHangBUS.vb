Imports QLGARADAL
Imports QLGARADTO
Imports Utility
Public Class KhachHangBUS


    Private khDAL As KhachHangDAL
    Public Sub New()
        khDAL = New KhachHangDAL()
    End Sub
    Public Sub New(connectionString As String)
        khDAL = New KhachHangDAL(connectionString)
    End Sub
    Public Function themkh(ByVal kh As KhachHangDTO) As String
        '1. verify data here!!

        '2. insert to DB
        Return khDAL.Them(kh)
    End Function
    Public Function Taidulieu()
        Return khDAL.Taidulieu()
    End Function
    Public Function Taidulieuht(mkh As String)
        Return khDAL.Taidulieuhientai(mkh)
    End Function

End Class




