Public Class Form1
    Private Sub TiếpNhậnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiếpNhậnToolStripMenuItem.Click
        Dim frm As PhieuTiepNhanXe = New PhieuTiepNhanXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub XuấtPhiếuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtPhiếuToolStripMenuItem.Click

    End Sub

    Private Sub QuảnLíXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíXeToolStripMenuItem.Click
        Dim frm As QuanLiXe = New QuanLiXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLíKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíKháchHàngToolStripMenuItem.Click
        Dim frm As QuanLiKhachHang = New QuanLiKhachHang()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuThuTiềnToolStripMenuItem.Click
        Dim frm As PhieuThuTien = New PhieuThuTien()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanToolStripMenuItem.Click
        Dim frm As VatTu = New VatTu()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PhiếuSữaChữaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuSữaChữaToolStripMenuItem.Click
        Dim frm As PhieuSuaChua = New PhieuSuaChua()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DoanhThuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoanhThuToolStripMenuItem.Click
        Dim frm As DoanhThu = New DoanhThu()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoTồnToolStripMenuItem.Click
        Dim frm As BaoCaoTon = New BaoCaoTon()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
