Imports QLGARABUS
Imports QLGARADTO
Imports QLGARADAL
Public Class PhieuThuTien
    Dim phieuDAL As PhieuThuTienDAL
    Dim ptBUS As PhieuThuTienBUS
    Dim khBUS As KhachHangBUS
    Dim tienno As Integer

    Private Sub PhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuDAL = New PhieuThuTienDAL()
        tbMaPhieuThu.Text = phieuDAL.Tangmaptt()
        ptBUS = New PhieuThuTienBUS()
        dgvDanhSachPhieuThuTien.DataSource = ptBUS.Taidulieupt


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        khBUS = New KhachHangBUS
        Dim khhientai As String = tbMaKhachHang.Text
        Dim dtts As DataTable = khBUS.Taidulieuht(khhientai)
        tienno = Integer.Parse(dtts.Rows(0).Item(2).ToString())


        If (Integer.Parse(tbSoTienThu.Text) < tienno) Then
            Dim PT As PhieuThuTienDTO
            PT = New PhieuThuTienDTO()
            PT.MaPhieuThu1 = tbMaPhieuThu.Text
            PT.NgayThuTien1 = dtpNgayThuTien.Value
            PT.SoTienThu1 = tbSoTienThu.Text
            PT.BienSo1 = tbBienSo.Text

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
End Class