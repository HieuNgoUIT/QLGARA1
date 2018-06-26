Imports QLGARADTO
Imports QLGARADAL.data
Public Class ThamSoDAL
    Dim dataaccess As New DataAccess

    Public Function taidulieuthamso() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM THAMSO")
    End Function
    Public Function Themts(ByVal x As ThamSoDTO) As String
        Dim sql As String = "UPDATE THAMSO SET soLuongXeTrongNgay=" & x.SoLuongXeTrongNgay1
        Return dataaccess.Thucthisql(sql)
    End Function
End Class
