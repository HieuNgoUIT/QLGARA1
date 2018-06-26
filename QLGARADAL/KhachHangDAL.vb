Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGARADTO
Imports QLGARADAL.data
Imports Utility
Public Class KhachHangDAL
    Private connectionString As String
    Dim dataaccess As New DataAccess

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    'Public Function insertKH(kh As KhachHangDTO) As Result
    '    Dim query As String = String.Empty
    '    query &= "INSERT INTO [KHACHHANG] ([maKhachHang], [tenChuXe],[tienNo],[email],[diachi],[dienthoai])"
    '    query &= "VALUES (@MAKHACHHANG,@TENCHUXE,@TIENNO,@EMAIL,@DIACHI,@DIENTHOAI)"

    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '                .Parameters.AddWithValue("@MAKHACHHANG", kh.MaKhachHang1)
    '                .Parameters.AddWithValue("@TENCHUXE", kh.TenChuXe1)
    '                .Parameters.AddWithValue("@TIENNO", kh.TienNo1)
    '                .Parameters.AddWithValue("@EMAIL", kh.Email1)
    '                .Parameters.AddWithValue("@DIACHI", kh.DiaChi1)
    '                .Parameters.AddWithValue("@DIENTHOAI", kh.DienThoai1)

    '            End With
    '            Try
    '                conn.Open()
    '                comm.ExecuteNonQuery()
    '            Catch ex As Exception
    '                conn.Close()
    '                System.Console.WriteLine(ex.StackTrace)
    '                Return New Result(False, "Thêm Xe không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using
    '    Return New Result(True) ' thanh cong
    'End Function
    Public Function Them(ByVal K As KhachHangDTO) As String
        Dim sql As String = "INSERT INTO KHACHHANG(maKhachHang,tenChuXe,tienNo,email,diachi,dienthoai) VALUES('" & K.MaKhachHang1.Trim & "',N'" & K.TenChuXe1.Trim & "',N'" & K.TienNo1 & "','" & K.Email1.Trim & "',N'" & K.DiaChi1 & "','" & K.DienThoai1 & "')"
        Return dataaccess.Thucthisql(sql)
    End Function
    Public Function Taidulieu()
        Return dataaccess.Taidulieu("SELECT * FROM KHACHHANG")
    End Function
    Public Function Tangmakh() As String
        Dim sql As String = "Select * From KHACHHANG"
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
