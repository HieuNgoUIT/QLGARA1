Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports QLGARABUS
Imports QLGARADTO
Public Class BaoCaoTon
    Dim baoCaoTonBUS As BaoCaoTonBUS
    Dim baoCaoTonDTO As BaoCaoTonDTO
    Private Sub BaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbMaBaoCaoTon.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        baoCaoTonDTO = New BaoCaoTonDTO
        baoCaoTonDTO.maBaoCaoTon1 = tbMaBaoCaoTon.Text
        baoCaoTonDTO.thangBaoCao1 = tbThangBaoCao.Text
        baoCaoTonDTO.maVatTu1 = tbMaVatTu.Text
        baoCaoTonDTO.tonDau1 = tbTonDau.Text
        baoCaoTonDTO.phatSinh1 = tbPhatSinh.Text
        baoCaoTonDTO.tonCuoi1 = tbTonCuoi.Text
        baoCaoTonBUS = New BaoCaoTonBUS
        baoCaoTonBUS.themBCT(baoCaoTonDTO)
    End Sub
End Class