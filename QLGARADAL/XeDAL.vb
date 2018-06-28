Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGARADTO
Imports QLGARADAL.data

Public Class XeDAL
    Private connectionString As String
    Dim dataaccess As New DataAccess

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function Them(ByVal x As XeDTO) As String
        Dim sql As String = "INSERT INTO XE(bienSo,maHieuXe,maKhachHang) VALUES(N'" & x.BienSo1.Trim & "',N'" & x.MaHieuXe1.Trim & "',N'" & x.MaKhachHang1.Trim & " ')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function tracuuxe(x As String) As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM XE WHERE bienSo='" & x & "'")
    End Function
    Public Function Taidulieu() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM XE")
    End Function
    Public Function Taidulieuhieuxe() As DataTable
        Return dataaccess.Taidulieu("SELECT maHieuXe FROM HIEUXE")
    End Function

End Class
