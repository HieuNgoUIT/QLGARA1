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
    Private Sub Luoi_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhieuTiepNhan.RowEnter
        Dim dong As Integer = e.RowIndex
        tbMaPhieuTiepNhan.DataBindings.Clear()
        tbMaPhieuTiepNhan.DataBindings.Add("Text", dgvDanhSachPhieuTiepNhan.DataSource, "maPhieuTiepNhan")
        dtpNgayTiepNhan.DataBindings.Clear()
        dtpNgayTiepNhan.DataBindings.Add("Value", dgvDanhSachPhieuTiepNhan.DataSource, "ngayTiepNhan")
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


        'dtpNgayTiepNhan.Format = DateTimePickerFormat.Custom
        'dtpNgayTiepNhan.CustomFormat = "dd/MM/yyyy"
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)

        If (dtpNgayTiepNhan.Value.ToString("dd/MM/yyyy") = todaysdate And count < max) Then
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
        Else MessageBox.Show("Da tiep nhan qua 30xe !")

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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
End Class