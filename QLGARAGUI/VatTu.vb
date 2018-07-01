Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports QLGARABUS
Imports QLGARADTO
Public Class VatTu
    Dim vatTuBUS As VatTuBus
    Dim vattuDTO As vatTuDTO

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub VatTu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles tbMaVatTu.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbSoLuong.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vattuDTO = New vatTuDTO
        vattuDTO.DonGia1 = tbDonGia.Text
        vattuDTO.MaVatTu1 = tbMaVatTu.Text
        vattuDTO.SoLuong1 = tbSoLuong.Text
        vattuDTO.TenVatTu1 = tbTenVatTu.Text


        vatTuBUS = New VatTuBus()
        vatTuBUS.themmavattu(vattuDTO)

    End Sub
End Class