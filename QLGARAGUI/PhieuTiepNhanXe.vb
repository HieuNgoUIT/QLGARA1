Imports QLGARABUS
Imports QLGARADTO
Imports QLGARADAL
Public Class PhieuTiepNhanXe
    Dim ptnBUS As PhieuNhapBUS
    Dim pnDAL As PhieuNhapDAL
    Dim tsBUS As ThamSoBUS
    Dim max As Integer
    Dim count As Integer
    Dim isEdit As Boolean


    Private Sub PhieuTiepNhanXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ptnBUS = New PhieuNhapBUS()
        Size = New Size(523, 714)
        dtpNgayTiepNhan.Value = Date.Now
        dgvDanhSachPhieuTiepNhan.DataSource = ptnBUS.Taidulieu
        dgvDanhSachPhieuTiepNhan.Columns(0).HeaderText = "Mã Phiếu Tiếp Nhận"
        dgvDanhSachPhieuTiepNhan.Columns(1).HeaderText = "Ngày tiếp nhận"
        dgvChiTietPhieuTiepNhan.DataSource = ptnBUS.Taidulieuchitiet
        dgvChiTietPhieuTiepNhan.Columns(0).HeaderText = "Mã Chi tiết Tiếp Nhận"
        dgvChiTietPhieuTiepNhan.Columns(1).HeaderText = "Mã Phiếu Tiếp Nhận"
        dgvChiTietPhieuTiepNhan.Columns(2).HeaderText = "Biển số"

        tsBUS = New ThamSoBUS()
        Dim dtts As DataTable = tsBUS.Taidulieu()
        max = Integer.Parse(dtts.Rows(0).Item(0).ToString())
        count = Integer.Parse(dtts.Rows(0).Item(1).ToString())
        tbXeCount.Text = count

    End Sub
    Private Sub Luoi_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhieuTiepNhan.RowEnter
        Dim dong As Integer = e.RowIndex
        tbMaPhieuTiepNhan.DataBindings.Clear()
        tbMaPhieuTiepNhan.DataBindings.Add("Text", dgvDanhSachPhieuTiepNhan.DataSource, "maPhieuTiepNhan")
        dtpNgayTiepNhan.DataBindings.Clear()
        dtpNgayTiepNhan.DataBindings.Add("Value", dgvDanhSachPhieuTiepNhan.DataSource, "ngayTiepNhan")
        If (Size = New Size(1092, 740)) Then
            tbMaPhieuTiepNhan1.Text = tbMaPhieuTiepNhan1.Text
        End If
    End Sub
    Private Sub Luoi_RowEnter1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChiTietPhieuTiepNhan.RowEnter
        Dim dong As Integer = e.RowIndex
        tbMaPhieuTiepNhan1.DataBindings.Clear()
        tbMaPhieuTiepNhan1.DataBindings.Add("Text", dgvChiTietPhieuTiepNhan.DataSource, "maPhieuTiepNhan")
        tbMaChiTietPhieu.DataBindings.Clear()
        tbMaChiTietPhieu.DataBindings.Add("Text", dgvChiTietPhieuTiepNhan.DataSource, "maCTPTN")
        tbBienSo.DataBindings.Clear()
        tbBienSo.DataBindings.Add("Text", dgvChiTietPhieuTiepNhan.DataSource, "bienSo")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Size = New Size(1092, 740)
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
        tbMaPhieuTiepNhan1.Text = tbMaPhieuTiepNhan.Text
        dgvDanhSachPhieuTiepNhan.DataSource = ptnBUS.Taidulieu
        Dim lastrow As Integer = dgvDanhSachPhieuTiepNhan.RowCount - 2
        dgvDanhSachPhieuTiepNhan.CurrentCell = dgvDanhSachPhieuTiepNhan(0, lastrow)
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

        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)

        If (dtpNgayTiepNhan.Value.ToString("dd/MM/yyyy") < todaysdate Or dtpNgayTiepNhan.Value.ToString("dd/MM/yyyy") > todaysdate) Then
            MessageBox.Show("Chỉ có thể tiếp nhận xe trong cùng ngày")
        ElseIf (count > max) Then
            MessageBox.Show("Chỉ có thể tiếp nhận tối đa 30 xe trong cùng ngày")
        End If
        If (dtpNgayTiepNhan.Value.ToString("dd/MM/yyyy") = todaysdate And count < max And isEdit = 0) Then

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
        End If
        If (isEdit = True) Then
            Dim CTPN1 As PhieuChiTietDTO
            CTPN1 = New PhieuChiTietDTO()
            CTPN1.MaCTPTN1 = tbMaChiTietPhieu.Text
            CTPN1.BienSo1 = tbBienSo.Text
            ptnBUS = New PhieuNhapBUS()
            ptnBUS.chinhsua(CTPN1)
            isEdit = False
            tbBienSo.ReadOnly = True
            dgvChiTietPhieuTiepNhan.DataSource = ptnBUS.Taidulieuchitiet()
        End If


        tbMaPhieuTiepNhan1.Text = tbMaPhieuTiepNhan.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dtpNgayTiepNhan.Value = Date.Now
        pnDAL = New PhieuNhapDAL()
        tbMaPhieuTiepNhan.Text = pnDAL.Tangma
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pnDAL = New PhieuNhapDAL()
        tbMaChiTietPhieu.Text = pnDAL.Tangmact
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Size = New Size(1092, 740)
        tbMaPhieuTiepNhan1.Text = tbMaPhieuTiepNhan.Text
        ptnBUS = New PhieuNhapBUS()
        dgvChiTietPhieuTiepNhan.DataSource = ptnBUS.Taidulieutyc(tbMaPhieuTiepNhan.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ptnBUS = New PhieuNhapBUS
        ptnBUS.xoaphieu(tbMaPhieuTiepNhan.Text)
        dgvDanhSachPhieuTiepNhan.DataSource = ptnBUS.Taidulieu
        dgvChiTietPhieuTiepNhan.DataSource = ptnBUS.Taidulieuchitiet
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ptnBUS = New PhieuNhapBUS
        ptnBUS.xoactphieu(tbMaChiTietPhieu.Text)
        dgvChiTietPhieuTiepNhan.DataSource = ptnBUS.Taidulieuchitiet
        tbXeCount.Text = count - 1
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim tsDTO As ThamSoDTO
        tsDTO = New ThamSoDTO()
        count = 0
        tsDTO.SoLuongXeTrongNgay1 = count
        tsBUS.themts(tsDTO)
        tbXeCount.Text = tsDTO.SoLuongXeTrongNgay1
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        tbBienSo.ReadOnly = False
        isEdit = True
    End Sub
End Class