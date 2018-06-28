Imports QLGARADTO
Imports QLGARADAL.data
Imports System.Data.SqlClient
Imports QLGARADAL
Public Class DoanhThuDAL
    Dim dataaccess As New DataAccess
    Public Function Them(ByVal x As DoanhThuDTO) As String
        Dim sql As String = "INSERT INTO DOANHTHU(Thang,TongDoanhThu,MaPhieuSuaChua,SoLuotSua,ThanhTien) VALUES(N'" & x.Thang1 & "',N'" & x.TongDoanhThu1 & "',N'" & x.MaPhieuSuaChua1.Trim & "',N'" & x.SoLuotSua1 & "',N'" & x.ThanhTien1 & "')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function Taidulieudoanhthu() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM DOANHTHU")
    End Function
    Public Function Tangmadt() As String
        Dim sql As String = "Select * From DOANHTHU"
        Dim str As String = dataaccess.str
        Dim con As New SqlConnection()
        con.ConnectionString = str
        Dim da As New SqlDataAdapter(sql, con)
        Dim dt As New DataTable()
        da.Fill(dt)
        Dim ma As String = ""
        If dt.Rows.Count <= 0 Then
            ma = "DT001"
        Else
            Dim k As Integer
            ma = "DT"
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


