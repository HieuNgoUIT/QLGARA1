﻿Imports QLGARADTO
Imports QLGARADAL.data
Imports System.Data.SqlClient
Imports QLGARADAL
Public Class KhachhangDAL
    Dim dataaccess As New DataAccess
    Public Function Them(ByVal x As KhachHangDTO) As String
        Dim sql As String = "INSERT INTO KHACHHANG(MaKhachHang,TenChuXe,TienNo,Email,DiaChi,DienThoai) VALUES(N'" & x.MaKhachHang1.Trim & "',N'" & x.TenChuXe1.Trim & "',N'" & x.TienNo1 & "',N'" & x.Email1.Trim & " ',N'" & x.DiaChi1.Trim & " ',N'" & x.DienThoai1.Trim & " ')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function Taidulieukhachang() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM KHACHHANG")
    End Function
    Public Function Tangmakh() As String
        Dim sql As String = "Select * From KHACHAHNG"
        Dim str As String = dataaccess.str
        Dim con As New SqlConnection()
        con.ConnectionString = str
        Dim da As New SqlDataAdapter(sql, con)
        Dim dt As New DataTable()
        da.Fill(dt)
        Dim ma As String = ""
        If dt.Rows.Count <= 0 Then
            ma = "KH001"
        Else
            Dim k As Integer
            ma = "KH"
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
