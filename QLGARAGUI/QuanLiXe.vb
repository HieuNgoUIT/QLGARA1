Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports QLGARABUS
Imports QLGARADTO
Public Class QuanLiXe
    Dim xeBus As XeBus
    Dim isEdit As Boolean
    Private Sub QuanLiXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xeBus = New XeBus()
        dgvDanhSachXe.DataSource = xeBus.Taidulieu
        dgvDanhSachXe.Columns(0).HeaderText = "Biển số Xe"
        dgvDanhSachXe.Columns(1).HeaderText = "Mã Hiệu Xe"
        dgvDanhSachXe.Columns(2).HeaderText = "Mã Khách Hàng"
        Dim query As String
        Dim con As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader
        con = New SqlConnection()
        con.ConnectionString = "Data Source=DESKTOP-M4843TO\SQLEXPRESS;Initial Catalog=QLGARA;Integrated Security=True"
        con.Open()
        query = "select maHieuXe from HIEUXE"
        command = New SqlCommand(query, con)
        reader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                cbMaHieuXe.Items.Add(reader("maHieuXe"))
            End While
        End If
    End Sub


    Private Sub Luoi_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachXe.RowEnter
        tbBienSo.ReadOnly = True
        cbMaHieuXe.Enabled = False
        tbMaKhachHang.ReadOnly = True

        Dim dong As Integer = e.RowIndex
        tbBienSo.DataBindings.Clear()
        tbBienSo.DataBindings.Add("Text", dgvDanhSachXe.DataSource, "bienSo")
        tbMaKhachHang.DataBindings.Clear()
        tbMaKhachHang.DataBindings.Add("Text", dgvDanhSachXe.DataSource, "maKhachHang")
        cbMaHieuXe.DataBindings.Clear()
        cbMaHieuXe.DataBindings.Add("Text", dgvDanhSachXe.DataSource, "maHieuXe")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DialogResult = DialogResult.OK


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaHieuXe.SelectedIndexChanged
        Dim query As String
        Dim con As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader
        con = New SqlConnection()
        con.ConnectionString = "Data Source=DESKTOP-M4843TO\SQLEXPRESS;Initial Catalog=QLGARA;Integrated Security=True"
        con.Open()
        query = "select * from HIEUXE where maHieuXe='" + cbMaHieuXe.Text + "'"
        command = New SqlCommand(query, con)
        reader = command.ExecuteReader()

        While (reader.Read())

            Dim ma As String
        Dim ten As String
        ma = reader.GetString(0)
        ten = reader.GetString(1)
        cbMaHieuXe.Text = ma
        tbHieuXe.Text = ten
        End While
        con.Close()
        'CP,,,EF
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New QuanLiKhachHang
        f.ShowDialog()
        If (f.DialogResult = DialogResult.OK) Then
            tbMaKhachHang.Text = f.tbMaKhachHang.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim XE As XeDTO
        XE = New XeDTO()
        XE.BienSo1 = tbBienSo.Text
        XE.MaHieuXe1 = cbMaHieuXe.Text
        XE.MaKhachHang1 = tbMaKhachHang.Text
        xeBus = New XeBus()
        If (isEdit = False) Then

            Dim ketQua As String = xeBus.themxe(XE)
            If (ketQua <> "Success") Then

                MessageBox.Show(ketQua)

            End If

            MessageBox.Show("Thêm xe thành công !")
        End If

        If (isEdit = True) Then
            xeBus.edit(XE)
            isEdit = False
        End If

        dgvDanhSachXe.DataSource = xeBus.Taidulieu
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        xeBus = New XeBus()
        dgvDanhSachXe.DataSource = xeBus.tracuuxe(tbSearch.Text)
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        If (tbSearch.Text = Nothing) Then
            xeBus = New XeBus()
            dgvDanhSachXe.DataSource = xeBus.Taidulieu
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        isEdit = True
        tbBienSo.ReadOnly = False
        cbMaHieuXe.Enabled = True
        tbMaKhachHang.ReadOnly = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        tbBienSo.ReadOnly = False
        cbMaHieuXe.Enabled = True
        tbMaKhachHang.ReadOnly = False
    End Sub
End Class