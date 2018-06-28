Imports System.Data.SqlClient
Imports System.Configuration
Namespace data
    Public Class DataAccess


        Private strConnect As New SqlConnection()

        Public str As String
        'Tạo kết nối
        Public Sub New()
            ' Read ConnectionString value from App.config file
            str = ConfigurationManager.AppSettings("ConnectionString")
        End Sub
        Public Sub New(ConnectionString As String)
            Me.str = ConnectionString
        End Sub

        Public Sub Create_Connect()
            If strConnect.State = ConnectionState.Closed Then
                strConnect.ConnectionString = str
                strConnect.Open()
            End If
        End Sub
        'Đóng kết nối
        Public Sub Close_Connect()
            If strConnect.State = ConnectionState.Open Then
                strConnect.Close()
            End If
        End Sub
        'Tải dữ liệu
        Public Function Taidulieu(strLenh As String) As DataTable
            Dim ds As New DataTable
            Create_Connect()
            Dim da As New SqlDataAdapter(strLenh, strConnect)
            da.Fill(ds)
            Return ds
        End Function
        'Thực thi lệnh
        Public Function Thucthisql(ByVal sql As String) As String
            Try
                Create_Connect()
                Dim cmd As New SqlCommand(sql, strConnect)
                cmd.ExecuteNonQuery()
                Close_Connect()
                Return "Success"
            Catch e As Exception
                Return e.ToString
            End Try
        End Function
        Public Function DoCBB(ByVal sql As String) As String
            Try
                Create_Connect()
                Dim cmd As New SqlCommand(sql, strConnect)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                While (dr.Read())

                End While
                ' cmd.ExecuteNonQuery()
                Close_Connect()
                Return "Success"
            Catch e As Exception
                Return e.ToString
            End Try
        End Function
    End Class
End Namespace
