Imports QLGARADTO
Imports QLGARADAL.data
Imports System.Data.SqlClient
Imports QLGARADAL
Public Class DoanhThuDAL
    Dim dataaccess As New DataAccess
    Public Function Them(ByVal x As DoanhThuDTO) As String
        Dim sql As String = "INSERT INTO DOANHTHU(thang,tongDoanhThu,maPhieuSuaChua,soLuotSua,thanhTien) VALUES(N'" & x.Thang1 & "',N'" & x.TongDoanhThu1 & "',N'" & x.MaPhieuSuaChua1.Trim & "',N'" & x.SoLuotSua1 & "',N'" & x.ThanhTien1 & "')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function Taidulieudoanhthu() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM DOANHTHU")
    End Function
    Public Function taidulieuthang() As DataTable
        Return dataaccess.Taidulieu("SELECT thang FROM DOANHTHU")
    End Function
    Public Function taidulieutongdoanhthu() As DataTable
        Return dataaccess.Taidulieu("SELECT tongDoanhThu FROM DOANHTHU")
    End Function
    Public Function taidulieumaphieusuachua() As DataTable
        Return dataaccess.Taidulieu("SELECT maChiTietPSC FROM CHITIETPSC")
    End Function
    Public Function taidulieusoluotsua() As DataTable
        Return dataaccess.Taidulieu("SELECT soLuotSua FROM DOANHTHU")
    End Function
    Public Function taidulieuthanhtien() As DataTable
        Return dataaccess.Taidulieu("SELECT thanhTien FROM DOANHTHU")
    End Function



End Class


