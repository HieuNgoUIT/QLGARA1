Imports QLGARABUS
Imports QLGARADTO
Imports QLGARADAL
Public Class PhieuThuTien
    Dim phieuDAL As PhieuThuTienDAL
    Dim ptBUS As PhieuThuTienBUS
    Dim khBUS As KhachHangBUS
    Dim tienno As Integer


    Private Sub PhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpNgayThuTien.Value = Date.Now
        phieuDAL = New PhieuThuTienDAL()
        tbMaPhieuThu.Text = phieuDAL.Tangmaptt()
        ptBUS = New PhieuThuTienBUS()
        dgvDanhSachPhieuThuTien.DataSource = ptBUS.Taidulieupt
        dgvDanhSachPhieuThuTien.Columns(0).HeaderText = "Mã Phiếu Thu"
        dgvDanhSachPhieuThuTien.Columns(1).HeaderText = "Biển Số Xe"
        dgvDanhSachPhieuThuTien.Columns(2).HeaderText = "Ngày Thu Tiền"
        dgvDanhSachPhieuThuTien.Columns(3).HeaderText = "Số Tiền Thu"

    End Sub
    Private Sub Luoi_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhieuThuTien.RowEnter
        tbBienSo.ReadOnly = True

        tbSoTienThu.ReadOnly = True
        dtpNgayThuTien.Enabled = False


        Dim dong As Integer = e.RowIndex
        tbMaPhieuThu.DataBindings.Clear()
        tbMaPhieuThu.DataBindings.Add("Text", dgvDanhSachPhieuThuTien.DataSource, "maPhieuThu")
        dtpNgayThuTien.DataBindings.Clear()
        dtpNgayThuTien.DataBindings.Add("Text", dgvDanhSachPhieuThuTien.DataSource, "ngayThuTien")
        tbBienSo.DataBindings.Clear()
        tbBienSo.DataBindings.Add("Text", dgvDanhSachPhieuThuTien.DataSource, "bienSo")
        tbSoTienThu.DataBindings.Clear()
        tbSoTienThu.DataBindings.Add("Text", dgvDanhSachPhieuThuTien.DataSource, "soTienThu")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        khBUS = New KhachHangBUS
        Dim khhientai As String = tbMaKhachHang.Text
        Dim dtts As DataTable = khBUS.Taidulieuht(khhientai)
        tienno = Integer.Parse(dtts.Rows(0).Item(2).ToString())

        Dim PT As PhieuThuTienDTO
        PT = New PhieuThuTienDTO()
        PT.MaPhieuThu1 = tbMaPhieuThu.Text
        PT.NgayThuTien1 = dtpNgayThuTien.Value
        PT.SoTienThu1 = tbSoTienThu.Text
        PT.BienSo1 = tbBienSo.Text



        If (Integer.Parse(tbSoTienThu.Text) < tienno) Then


            ptBUS = New PhieuThuTienBUS()
            Dim ketQua As String = ptBUS.themphieu(PT)
            If (ketQua <> "Success") Then

                MessageBox.Show(ketQua)

            End If
            MessageBox.Show("Thêm PN thành công !")

            ptBUS = New PhieuThuTienBUS()
            dgvDanhSachPhieuThuTien.DataSource = ptBUS.Taidulieupt
            phieuDAL = New PhieuThuTienDAL()
            tbMaPhieuThu.Text = phieuDAL.Tangmaptt()
        Else MessageBox.Show("so tien thu > tien no :" & tienno)
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New QuanLiXe
        f.ShowDialog()
        If (f.DialogResult = DialogResult.OK) Then
            tbBienSo.Text = f.tbBienSo.Text
            tbMaKhachHang.Text = f.tbMaKhachHang.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ptBUS = New PhieuThuTienBUS()
        ptBUS.xoaphieu(tbMaPhieuThu.Text)
        dgvDanhSachPhieuThuTien.DataSource = ptBUS.Taidulieupt()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        tbBienSo.ReadOnly = False

        tbSoTienThu.ReadOnly = False
        dtpNgayThuTien.Enabled = True
        tbBienSo.Text = Nothing
        tbSoTienThu.Text = Nothing


        phieuDAL = New PhieuThuTienDAL()
        tbMaPhieuThu.Text = phieuDAL.Tangmaptt()
        dtpNgayThuTien.Value = Date.Now


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        tbBienSo.ReadOnly = False

        tbSoTienThu.ReadOnly = False
        dtpNgayThuTien.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim PT As PhieuThuTienDTO
        PT = New PhieuThuTienDTO()
        PT.MaPhieuThu1 = tbMaPhieuThu.Text
        PT.NgayThuTien1 = dtpNgayThuTien.Value
        PT.SoTienThu1 = tbSoTienThu.Text
        PT.BienSo1 = tbBienSo.Text

        ptBUS = New PhieuThuTienBUS()
        ptBUS.edit(PT)
        dgvDanhSachPhieuThuTien.DataSource = ptBUS.Taidulieupt


    End Sub
End Class