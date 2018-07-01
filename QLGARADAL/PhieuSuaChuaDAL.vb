Imports QLGARADTO
Imports QLGARADAL
Imports System.Data.SqlClient
Imports System.Configuration
Imports QLGARADAL.data

Public Class PhieuSuaChuaDAL
    Dim dataaccess As New DataAccess
    Dim connectionString As String

    Public Function Them(ByVal x As PhieuSuaChuaDTO) As String
        Dim sql As String = "INSERT INTO CHITIETPSC(maChiTietPSC,maPSC,bienSo,noidung,maVatTu,tienCong,thanhTien) VALUES(N'" & x.maChiTietPSC1.Trim & "',N'" & x.maPhieuSuaChua1.Trim & "',N'" & x.bienSo1.Trim & "',N'" & x.noidung1.Trim & "',N'" & x.maVatTu1.Trim & " ',N'" & x.tienCong1 & "',N'" & x.thanhTien1 & "')"
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
    Public Function taidulieumaphieusuachua() As DataTable
        Return dataaccess.Taidulieu("SELECT maChiTietPSC FROM CHITIETPSC")
    End Function
    Public Function Taidulieungaysuachua() As DataTable
        Return dataaccess.Taidulieu("SELECT ngaySuaChua FROM PHIEUSUACHUA")
    End Function
    Public Function Taidulieubienso() As DataTable
        Return dataaccess.Taidulieu("SELECT bienSo FROM CHITIETPSC")
    End Function
    Public Function taidulieunoidungsuachua() As DataTable
        Return dataaccess.Taidulieu("SELECT noiDung from CHITIETPSC")
    End Function
    Public Function taidulieumavattu() As DataTable
        Return dataaccess.Taidulieu("SELECT maVatTu from CHITIETPSC")
    End Function
    Public Function taidulieutiencong() As DataTable
        Return dataaccess.Taidulieu("SELECT tienCong from CHITIETPSC")
    End Function
    Public Function taidulieuthanhtien() As DataTable
        Return dataaccess.Taidulieu("SELECT thanhTien from CHITIETPSC")
    End Function





End Class