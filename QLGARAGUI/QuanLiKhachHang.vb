Imports QLGARABUS
Public Class QuanLiKhachHang
    Dim khBUS As KhachHangBUS
    Private Sub QuanLiKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBUS = New KhachHangBUS()
        dgvDanhSachKhachHang.DataSource = khBUS.Taidulieu
    End Sub
End Class