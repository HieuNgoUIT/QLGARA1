Imports QLGARADTO
Imports QLGARADAL.data
Imports System.Data.SqlClient

Public Class PhieuNhapDAL
    Dim dataaccess As New DataAccess
    Public Function Taidulieu() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM PHIEUTIEPNHAN")
    End Function
    Public Function Taidulieuchitiet() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM CHITIETPHIEUTIEPNHAN")
    End Function
    Public Function Taidulieutheoyeucau(ma As String) As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM CHITIETPHIEUTIEPNHAN WHERE maPhieuTiepNhan='" & ma & "'")
    End Function
    Public Function Them(ByVal x As PhieuNhapDTO) As String
        Dim sql As String = "INSERT INTO PHIEUTIEPNHAN(maPhieuTiepNHan,ngayTiepNhan) VALUES(N'" & x.MaPhieuTiepNhan1.Trim & "',N'" & x.NgayTiepNhan1 & " ')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function Themchitiet(ByVal x As PhieuChiTietDTO) As String
        Dim sql As String = "INSERT INTO CHITIETPHIEUTIEPNHAN(maCTPTN,maPhieuTiepNHan,bienSo) VALUES(N'" & x.MaCTPTN1.Trim & "',N'" & x.MaPhieuTiepNhan1 & "',N'" & x.BienSo1 & " ')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function xoaphieu(x As String) As String
        Dim sql As String = "DELETE FROM PHIEUTIEPNHAN WHERE maPhieuTiepNhan='" & x & "' DELETE FROM CHITIETPHIEUTIEPNHAN WHERE maPhieuTiepNhan='" & x & "' "
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function xoactphieu(x As String) As String
        Dim sql As String = "DELETE FROM CHITIETPHIEUTIEPNHAN WHERE maCTPTN='" & x & "' "
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function chinhsua(x As PhieuChiTietDTO) As String
        Dim sql As String = "UPDATE CHITIETPHIEUTIEPNHAN SET bienSo='" & x.BienSo1 & "'" & " WHERE maCTPTN='" & x.MaCTPTN1 & "' "
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function Tangma() As String
        Dim sql As String = "Select * From PHIEUTIEPNHAN"
        Dim str As String = dataaccess.str
        Dim con As New SqlConnection()
        con.ConnectionString = str
        Dim da As New SqlDataAdapter(sql, con)
        Dim dt As New DataTable()
        da.Fill(dt)
        Dim ma As String = ""
        If dt.Rows.Count <= 0 Then
            ma = "PN001"
        Else
            Dim k As Integer
            ma = "PN"
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
    Public Function Tangmact() As String
        Dim sql As String = "Select * From CHITIETPHIEUTIEPNHAN"
        Dim str As String = dataaccess.str
        Dim con As New SqlConnection()
        con.ConnectionString = str
        Dim da As New SqlDataAdapter(sql, con)
        Dim dt As New DataTable()
        da.Fill(dt)
        Dim ma As String = ""
        If dt.Rows.Count <= 0 Then
            ma = "CT001"
        Else
            Dim k As Integer
            ma = "CT"
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
