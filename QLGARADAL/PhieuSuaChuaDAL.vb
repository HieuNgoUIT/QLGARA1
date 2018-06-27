Imports QLGARADTO
Imports QLGARADAL.data
Imports System.Data.SqlClient
Public Class PhieuSuaChuaDAL
    Dim dataaccess As New DataAccess
    Public Function Them(ByVal x As PhieuSuaChuaDTO) As String
        Dim sql As String = "INSERT INTO CHITIETPSC(MaPhieuSuaChua,BienSo,NoiDungSuaChua,MaVatTu,TienCong,ThanhTien) VALUES(N'" & x.MaPhieuSuaChua1.Trim & "',N'" & x.BienSo1.Trim & "',N'" & x.NoiDungSuaChua1.Trim & "',N'" & x.MaVatTu1.Trim & " ',N'" & x.TienCong1.Trim & "',N'" & x.ThanhTien1.Trim & "')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function Taidulieuphieusuachua() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM CHITIETPSC")
    End Function
    Public Function Tangmapsc() As String
        Dim sql As String = "Select * From CHITIETPSC"
        Dim str As String = dataaccess.str
        Dim con As New SqlConnection()
        con.ConnectionString = str
        Dim da As New SqlDataAdapter(sql, con)
        Dim dt As New DataTable()
        da.Fill(dt)
        Dim ma As String = ""
        If dt.Rows.Count <= 0 Then
            ma = "PS001"
        Else
            Dim k As Integer
            ma = "PT"
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
