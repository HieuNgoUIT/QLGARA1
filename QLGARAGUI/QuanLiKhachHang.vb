Imports QLGARABUS
Imports QLGARADTO
Imports QLGARADAL
Public Class QuanLiKhachHang
    Dim khBUS As KhachHangBUS
    Dim khDAL As KhachHangDAL
    Dim isEdit As Boolean
    Private Sub QuanLiKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBUS = New KhachHangBUS()
        dgvDanhSachKhachHang.DataSource = khBUS.Taidulieu
        dgvDanhSachKhachHang.Columns(0).HeaderText = "Mã Khách Hàng"
        dgvDanhSachKhachHang.Columns(1).HeaderText = "Tên Chủ Xe"
        dgvDanhSachKhachHang.Columns(2).HeaderText = "Tiền nợ"
        dgvDanhSachKhachHang.Columns(3).HeaderText = "Email"
        dgvDanhSachKhachHang.Columns(4).HeaderText = "Địa chỉ"
        dgvDanhSachKhachHang.Columns(5).HeaderText = "Điện thoại"

    End Sub
    Private Sub Luoi_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachKhachHang.RowEnter
        tbDienThoai.ReadOnly = True
        tbDiaChi.ReadOnly = True
        tbEmail.ReadOnly = True
        tbTenKhachHang.ReadOnly = True
        tbTienNo.ReadOnly = True


        Dim dong As Integer = e.RowIndex
        tbMaKhachHang.DataBindings.Clear()
        tbMaKhachHang.DataBindings.Add("Text", dgvDanhSachKhachHang.DataSource, "maKhachHang")
        tbTenKhachHang.DataBindings.Clear()
        tbTenKhachHang.DataBindings.Add("Text", dgvDanhSachKhachHang.DataSource, "tenChuXe")
        tbEmail.DataBindings.Clear()
        tbEmail.DataBindings.Add("Text", dgvDanhSachKhachHang.DataSource, "Email")
        tbDienThoai.DataBindings.Clear()
        tbDienThoai.DataBindings.Add("Text", dgvDanhSachKhachHang.DataSource, "dienThoai")
        tbDiaChi.DataBindings.Clear()
        tbDiaChi.DataBindings.Add("Text", dgvDanhSachKhachHang.DataSource, "diaChi")
        tbTienNo.DataBindings.Clear()
        tbTienNo.DataBindings.Add("Text", dgvDanhSachKhachHang.DataSource, "tienNo")


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
        If (isEdit = False) Then
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
        End If

        If (isEdit = True) Then
            khBUS.edit(KH)
            isEdit = False
            dgvDanhSachKhachHang.DataSource = khBUS.Taidulieu()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        khDAL = New KhachHangDAL()
        tbMaKhachHang.Text = khDAL.Tangmakh
        tbDienThoai.ReadOnly = False
        tbDiaChi.ReadOnly = False
        tbEmail.ReadOnly = False
        tbTenKhachHang.ReadOnly = False
        tbTienNo.ReadOnly = False

        tbDienThoai.Text = Nothing
        tbDiaChi.Text = Nothing
        tbEmail.Text = Nothing
        tbTenKhachHang.Text = Nothing
        tbTienNo.Text = Nothing

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        If (tbSearch.Text = Nothing) Then
            khBUS = New KhachHangBUS()
            dgvDanhSachKhachHang.DataSource = khBUS.Taidulieu
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        khBUS = New KhachHangBUS()
        dgvDanhSachKhachHang.DataSource = khBUS.tracuukh(tbSearch.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        isEdit = True
        tbDienThoai.ReadOnly = False
        tbDiaChi.ReadOnly = False
        tbEmail.ReadOnly = False
        tbTenKhachHang.ReadOnly = False
        tbTienNo.ReadOnly = False
    End Sub

End Class