Imports QLGARABUS
Imports QLGARADTO
Imports QLGARADAL
Public Class QuanLiKhachHang
    Dim khBUS As KhachHangBUS
    Dim khDAL As KhachHangDAL
    Dim loading As Boolean
    Private Sub QuanLiKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBUS = New KhachHangBUS()
        dgvDanhSachKhachHang.DataSource = khBUS.Taidulieu


    End Sub
    Private Sub Luoi_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachKhachHang.RowEnter


        Dim dong As Integer = e.RowIndex
        tbMaKhachHang.DataBindings.Clear()
        tbMaKhachHang.DataBindings.Add("Text", dgvDanhSachKhachHang.DataSource, "maKhachHang")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim KH As KhachHangDTO
        KH = New KhachHangDTO()

        KH.DiaChi1 = tbDiaChi.Text
        KH.DienThoai1 = tbDienThoai.Text
        KH.Email1 = tbEmail.Text
        KH.MaKhachHang1 = tbMaKhachHang.Text
        KH.TenChuXe1 = tbTenKhachHang.Text
        KH.TienNo1 = tbTienNo.Text

        khBUS = New KhachHangBUS()
        Dim ketQua As String = khBUS.themkh(KH)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)

        End If
        MessageBox.Show("Thêm kh thành công !")
        khBUS = New KhachHangBUS()
        dgvDanhSachKhachHang.DataSource = khBUS.Taidulieu
        khDAL = New KhachHangDAL()
        tbMaKhachHang.Text = khDAL.Tangmakh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        khDAL = New KhachHangDAL()
        tbMaKhachHang.Text = khDAL.Tangmakh
    End Sub
End Class