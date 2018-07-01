Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports QLGARABUS
Imports QLGARADTO
Public Class PhieuSuaChua
    Dim phieuSuaChuaBUS As PhieuSuaChuaBUS
    Dim phieuSuaChuaDTO As PhieuSuaChuaDTO

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub PhieuSuaChua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuSuaChuaBUS = New PhieuSuaChuaBUS()


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbMaPhieuSuaChua.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        phieuSuaChuaDTO = New PhieuSuaChuaDTO
        phieuSuaChuaDTO.maPhieuSuaChua1 = tbMaPhieuSuaChua.Text
        phieuSuaChuaDTO.ngaySuaChua1 = tbNgaySuaChua.Text
        phieuSuaChuaDTO.bienSo1 = tbBienSo.Text
        phieuSuaChuaDTO.noidung1 = tbNoiDungSuaChua.Text
        phieuSuaChuaDTO.maVatTu1 = tbMaVatTu.Text
        phieuSuaChuaDTO.tienCong1 = tbTienCong.Text
        phieuSuaChuaDTO.thanhTien1 = tbThanhTien.Text
        phieuSuaChuaDTO.maChiTietPSC1 = tbMaChiTietPSC.Text




        phieuSuaChuaBUS = New PhieuSuaChuaBUS
        phieuSuaChuaBUS.themphieusuachua(phieuSuaChuaDTO)
















    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles tbNgaySuaChua.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
