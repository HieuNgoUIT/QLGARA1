Imports QLGARADTO
Imports QLGARABUS
Imports Utility
Imports System.Data.SqlClient
Public Class XeGUI
    Private xeBus As XeBus
    Private khBus As KhachHangBUS




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim XE As XeDTO
        XE = New XeDTO()
        XE.BienSo1 = tbBienSo.Text
        XE.MaHieuXe1 = tbMaHieuXe.Text
        XE.MaKhachHang1 = tbMaKhachHang.Text

        xeBus = New XeBus()
        Dim ketQua As String = xeBus.themxe(XE)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)

        End If
        MessageBox.Show("Thêm xe thành công !")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim KH As KhachHangDTO
        KH = New KhachHangDTO()

        KH.DiaChi1 = tbDiaChi.Text
        KH.DienThoai1 = tbDienThoai.Text
        KH.Email1 = tbEmail.Text
        KH.MaKhachHang1 = tbMaKhachHang.Text
        KH.TenChuXe1 = tbTenKhachHang.Text
        KH.TienNo1 = tbTienNo.Text

        khBus = New KhachHangBUS()
        Dim ketQua As String = khBus.themkh(KH)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)

        End If
        MessageBox.Show("Thêm kh thành công !")
    End Sub
    ''2. Business .....
    'xeBus = New XeBus()

    ''3. Insert to DB
    'Dim result As Result
    'result = xeBus.insert(XE)
    'If (result.FlagResult = True) Then
    '    MessageBox.Show("Thêm xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    'Else
    '    MessageBox.Show("Thêm xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    System.Console.WriteLine(result.SystemMessage)
    'End If

    'Dim KH As KhachHangDTO
    '    KH = New KhachHangDTO()
    '    KH.DiaChi1 = tbDiaChi.Text
    '    KH.DienThoai1 = tbDienThoai.Text
    '    KH.Email1 = tbEmail.Text
    '    KH.MaKhachHang1 = tbMaKhachHang.Text
    '    KH.TenChuXe1 = tbTenKhachHang.Text
    '    KH.TienNo1 = tbTienNo.Text


    '    '2. Business .....
    '    khBus = New KhachHangBUS()

    '    '3. Insert to DB

    '    result = khBus.insert(KH)
    '    If (result.FlagResult = True) Then
    '        MessageBox.Show("Thêm khach hang thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '    Else
    '        MessageBox.Show("Thêm khach hang không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result.SystemMessage)
    '    End If

    '    Dim HX As HieuXeDTO
    '    HX = New HieuXeDTO()
    '    HX.MaHieuXe1 = tbMaHieuXe.Text
    '    HX.TenHieuXe1 = tbHieuXe.Text


    '    '2. Business .....
    '    hxBus = New HieuXeBUS()

    '    '3. Insert to DB

    '    result = hxBus.insert(HX)
    '    If (result.FlagResult = True) Then
    '        MessageBox.Show("Thêm hieu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '    Else
    '        MessageBox.Show("Thêm hieu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result.SystemMessage)
    '    End If



    'End Sub
End Class