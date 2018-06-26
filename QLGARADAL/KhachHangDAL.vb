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
End Class
