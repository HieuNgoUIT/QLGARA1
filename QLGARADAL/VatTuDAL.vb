Imports QLGARADTO
Imports QLGARADAL.data
Imports System.Data.SqlClient
Imports QLGARADAL

Public Class VatTuDAL
    Dim dataaccess As New DataAccess
    Public Function Them(ByVal x As vatTuDTO) As String
        Dim sql As String = "INSERT INTO VATTU(MaVatTu,TenVatTu,SoLuong,DonGia) VALUES(N'" & x.MaVatTu1.Trim & "',N'" & x.TenVatTu1.Trim & "',N'" & x.SoLuong1 & "',N'" & x.DonGia1 & " ')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function Taidulieuvattu() As DataTable
        Return dataaccess.Taidulieu("SELECT * FROM VATTU")
    End Function
    Public Function Tangmavt() As String
        Dim sql As String = "Select * From VATTU"
        Dim str As String = dataaccess.str
        Dim con As New SqlConnection()
        con.ConnectionString = str
        Dim da As New SqlDataAdapter(sql, con)
        Dim dt As New DataTable()
        da.Fill(dt)
        Dim ma As String = ""
        If dt.Rows.Count <= 0 Then
            ma = "VT001"
        Else
            Dim k As Integer
            ma = "VT"
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
