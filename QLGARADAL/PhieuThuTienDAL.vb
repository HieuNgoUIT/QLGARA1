Imports QLGARADTO
Imports QLGARADAL.data
Imports System.Data.SqlClient

Public Class PhieuThuTienDAL
    Dim dataaccess As New DataAccess
    Public Function Them(ByVal x As PhieuThuTienDTO) As String
        Dim sql As String = "INSERT INTO PHIEUTHUTIEN(maPhieuThu,bienSo,ngayThuTien,soTienThu) VALUES(N'" & x.MaPhieuThu1.Trim & "',N'" & x.BienSo1.Trim & "',N'" & x.NgayThuTien1 & "',N'" & x.SoTienThu1 & " ')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function Taidulieuphieuthu() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM PHIEUTHUTIEN")
    End Function
    Public Function Tangmaptt() As String
        Dim sql As String = "Select * From PHIEUTHUTIEN"
        Dim str As String = dataaccess.str
        Dim con As New SqlConnection()
        con.ConnectionString = str
        Dim da As New SqlDataAdapter(sql, con)
        Dim dt As New DataTable()
        da.Fill(dt)
        Dim ma As String = ""
        If dt.Rows.Count <= 0 Then
            ma = "PT001"
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
