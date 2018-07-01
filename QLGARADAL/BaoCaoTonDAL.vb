Imports QLGARADTO
Imports QLGARADAL.data
Imports System.Data.SqlClient
Imports QLGARADAL
Public Class BaoCaoTonDAL
    Dim dataaccess As New DataAccess
    Public Function Them(ByVal x As BaoCaoTonDTO) As String
        Dim sql As String = "INSERT INTO BAOCAOTON(maBaoCaoTon,thangBaoCao,maVatTu,tonDau,phatSinh,tonCuoi) VALUES(N'" & x.maBaoCaoTon1.Trim & "',N'" & x.thangBaoCao1.Trim & "',N'" & x.maVatTu1.Trim & "',,N'" & x.tonDau1 & " ',,N'" & x.phatSinh1 & " ',,N'" & x.tonCuoi1 & " ')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function Taidulieubaocaoton() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM BAOCAOTON")
    End Function
    Public Function Tangmabct() As String
        Dim sql As String = "Select * From BAOCAOTON"
        Dim str As String = dataaccess.str
        Dim con As New SqlConnection()
        con.ConnectionString = str
        Dim da As New SqlDataAdapter(sql, con)
        Dim dt As New DataTable()
        da.Fill(dt)
        Dim ma As String = ""
        If dt.Rows.Count <= 0 Then
            ma = "BCT001"
        Else
            Dim k As Integer
            ma = "BCT"
            k = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0).ToString().Substring(2, 3))
            k = k + 1
            If k < 10 Then
                ma = ma + "00"
            ElseIf k < 100 Then
                ma = ma + "0"
            End If
            ma = ma + k.ToString()
        End If
        Return ma
    End Function
    Public Function taidulieumabaocaoton() As DataTable
        Return dataaccess.taidulieu("SELECT maBaoCaoTon FROM BAOCAOTON")
    End Function
    Public Function taidulieuthangbaocao() As DataTable
        Return dataaccess.taidulieu("SELECT thangBaoCao FROM BAOCAOTON")
    End Function
    Public Function taidulieumavattu() As DataTable
        Return dataaccess.taidulieu("SELECT maVatTu FROM BAOCAOTON")
    End Function
    Public Function taidulieutondau() As DataTable
        Return dataaccess.taidulieu("SELECT tonDau FROM BAOCAOTON")
    End Function
    Public Function taidulieuphatsinh() As DataTable
        Return dataaccess.taidulieu("SELECT phatSinh FROM BAOCAOTON")
    End Function
    Public Function taidulieutoncuoi() As DataTable
        Return dataaccess.taidulieu("SELECT tonCuoi FROM BAOCAOTON")
    End Function

End Class
