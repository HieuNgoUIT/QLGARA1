Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports QLGARABUS
Imports QLGARADTO
Imports QLGARADAL.data
Public Class DoanhThu
    Dim doanhThuBUS As DoanhThuBUS
    Dim doanhThuDTO As DoanhThuDTO
    Dim pttBus As PhieuThuTienBUS
    Dim dac As DataAccess
    Private Sub DoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pttBus = New PhieuThuTienBUS
        dgvPhieuThuTien.DataSource = pttBus.Taidulieupt
        dac = New DataAccess

        Dim dtts As DataTable = dac.Taidulieu("SELECT SUM(soTienThu) FROM PHIEUTHUTIEN")
        tbTongDoanhThu.Text = Integer.Parse(dtts.Rows(0).Item(0).ToString())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        doanhThuDTO = New DoanhThuDTO

        doanhThuDTO.TongDoanhThu1 = tbTongDoanhThu.Text
        'doanhThuDTO.MaPhieuSuaChua1 = tbMaPhieuSuaChua.Text
        'doanhThuDTO.SoLuotSua1 = tbSoLuotSua.Text
        'doanhThuDTO.ThanhTien1 = tbThanhTien.Text
        doanhThuBUS = New DoanhThuBUS()
        doanhThuBUS.themdoanhthu(doanhThuDTO)
    End Sub
End Class