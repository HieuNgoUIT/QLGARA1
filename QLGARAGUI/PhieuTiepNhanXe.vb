Imports QLGARABUS
Imports QLGARADTO
Imports QLGARADAL
Public Class PhieuTiepNhanXe
    Dim ptnBUS As PhieuNhapBUS
    Dim pnDAL As PhieuNhapDAL
    Dim tsBUS As ThamSoBUS

    Dim max As Integer
    Dim count As Integer



    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhieuTiepNhan.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PhieuTiepNhanXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnDAL = New PhieuNhapDAL()
        tbMaPhieuTiepNhan.Text = pnDAL.Tangma

        ptnBUS = New PhieuNhapBUS()
        Size = New Size(523, 714)
        dtpNgayTiepNhan.Value = Date.Now
        dgvDanhSachPhieuTiepNhan.DataSource = ptnBUS.Taidulieu
        dgvChiTietPhieuTiepNhan.DataSource = ptnBUS.Taidulieuchitiet


        tsBUS = New ThamSoBUS()
        Dim dtts As DataTable = tsBUS.Taidulieu()
        max = Integer.Parse(dtts.Rows(0).Item(0).ToString())
        count = Integer.Parse(dtts.Rows(0).Item(1).ToString())
        tbXeCount.Text = count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Size = New Size(1092, 740)
        pnDAL = New PhieuNhapDAL()
        tbMaPhieuTiepNhan.Text = pnDAL.Tangma
        tbMaChiTietPhieu.Text = pnDAL.Tangmact

        Dim PN As PhieuNhapDTO
        PN = New PhieuNhapDTO()
        PN.MaPhieuTiepNhan1 = tbMaPhieuTiepNhan.Text
        PN.NgayTiepNhan1 = dtpNgayTiepNhan.Value

        ptnBUS = New PhieuNhapBUS()
        Dim ketQua As String = ptnBUS.thempn(PN)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)

        End If
        MessageBox.Show("Thêm PN thành công !")

        dgvDanhSachPhieuTiepNhan.DataSource = ptnBUS.Taidulieu
        tbMaPhieuTiepNhan1.Text = tbMaPhieuTiepNhan.Text
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles tbMaChiTietPhieu.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New QuanLiXe
        f.ShowDialog()
        If (f.DialogResult = DialogResult.OK) Then
            tbBienSo.Text = f.tbBienSo.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CTPN As PhieuChiTietDTO
        CTPN = New PhieuChiTietDTO()
        CTPN.MaCTPTN1 = tbMaChiTietPhieu.Text
        CTPN.BienSo1 = tbBienSo.Text
        CTPN.MaPhieuTiepNhan1 = tbMaPhieuTiepNhan1.Text


        ptnBUS = New PhieuNhapBUS()
        Dim ketQua As String = ptnBUS.themctpn(CTPN)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)

        End If
        MessageBox.Show("Thêm PN thành công !")
        dgvChiTietPhieuTiepNhan.DataSource = ptnBUS.Taidulieuchitiet

        count += 1
        tbXeCount.Text = count

        Dim tsDTO As ThamSoDTO
        tsDTO = New ThamSoDTO()
        tsDTO.SoLuongXeTrongNgay1 = count
        tsBUS.themts(tsDTO)

        pnDAL = New PhieuNhapDAL()
        tbMaChiTietPhieu.Text = pnDAL.Tangmact

    End Sub
End Class