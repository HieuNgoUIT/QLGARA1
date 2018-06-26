Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports QLGARABUS
Public Class QuanLiXe
    Dim xeBus As XeBus
    Private Sub QuanLiXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xeBus = New XeBus()
        dgvDanhSachXe.DataSource = xeBus.Taidulieu

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
        Dim dong As Integer = e.RowIndex
        tbBienSo.DataBindings.Clear()
        tbBienSo.DataBindings.Add("Text", dgvDanhSachXe.DataSource, "bienSo")
        'theloai.DataBindings.Clear()
        'theloai.DataBindings.Add("Text", Luoi.DataSource, "Theloai")
        'tacgia.DataBindings.Clear()
        'tacgia.DataBindings.Add("Text", Luoi.DataSource, "Tacgia")
        'soluongton.DataBindings.Clear()
        'soluongton.DataBindings.Add("Text", Luoi.DataSource, "Soluongton")
        'masach.DataBindings.Clear()
        'masach.DataBindings.Add("Text", Luoi.DataSource, "Masach")
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

End Class