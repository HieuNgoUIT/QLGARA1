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
End Class
