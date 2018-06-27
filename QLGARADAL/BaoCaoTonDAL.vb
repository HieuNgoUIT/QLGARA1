Imports QLGARADTO
Imports QLGARADAL.data
Imports System.Data.SqlClient
Imports QLGARADAL
Public Class BaoCaoTonDAL
    Dim dataaccess As New DataAccess
    Public Function Them(ByVal x As BaoCaoTonDTO) As String
        Dim sql As String = "INSERT INTO BAOCAOTON(MaBaoCaoTon,ThangBaoCao,MaVatTu,TonDau,PhatSinh,TonCuoi) VALUES(N'" & x.MaBaoCaoTon1.Trim & "',N'" & x.ThangBaoCao1.Trim & "',N'" & x.MaVatTu1.Trim & "',,N'" & x.TonDau1 & " ',,N'" & x.PhatSinh1 & " ',,N'" & x.TonCuoi1 & " ')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function Taidulieubaocaoton() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM BAOCAOTON")
    End Function
    Public Function Tangbct() As String
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

End Class
