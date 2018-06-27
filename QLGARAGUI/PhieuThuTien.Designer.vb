<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhieuThuTien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMaPhieuThu = New System.Windows.Forms.TextBox()
        Me.tbSoTienThu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbBienSo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvDanhSachPhieuThuTien = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbMaKhachHang = New System.Windows.Forms.TextBox()
        CType(Me.dgvDanhSachPhieuThuTien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(163, 140)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayThuTien.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Phiếu Thu"
        '
        'tbMaPhieuThu
        '
        Me.tbMaPhieuThu.Location = New System.Drawing.Point(159, 81)
        Me.tbMaPhieuThu.Name = "tbMaPhieuThu"
        Me.tbMaPhieuThu.ReadOnly = True
        Me.tbMaPhieuThu.Size = New System.Drawing.Size(100, 20)
        Me.tbMaPhieuThu.TabIndex = 2
        '
        'tbSoTienThu
        '
        Me.tbSoTienThu.Location = New System.Drawing.Point(159, 251)
        Me.tbSoTienThu.Name = "tbSoTienThu"
        Me.tbSoTienThu.Size = New System.Drawing.Size(100, 20)
        Me.tbSoTienThu.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ngày Thu Tiền"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Số tiền thu"
        '
        'tbBienSo
        '
        Me.tbBienSo.Location = New System.Drawing.Point(163, 197)
        Me.tbBienSo.Name = "tbBienSo"
        Me.tbBienSo.Size = New System.Drawing.Size(100, 20)
        Me.tbBienSo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Biển số"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(408, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Nhap "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvDanhSachPhieuThuTien
        '
        Me.dgvDanhSachPhieuThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhieuThuTien.Location = New System.Drawing.Point(30, 351)
        Me.dgvDanhSachPhieuThuTien.Name = "dgvDanhSachPhieuThuTien"
        Me.dgvDanhSachPhieuThuTien.Size = New System.Drawing.Size(620, 150)
        Me.dgvDanhSachPhieuThuTien.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(269, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "MAKH"
        '
        'tbMaKhachHang
        '
        Me.tbMaKhachHang.Location = New System.Drawing.Point(408, 207)
        Me.tbMaKhachHang.Name = "tbMaKhachHang"
        Me.tbMaKhachHang.Size = New System.Drawing.Size(100, 20)
        Me.tbMaKhachHang.TabIndex = 12
        '
        'PhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 547)
        Me.Controls.Add(Me.tbMaKhachHang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvDanhSachPhieuThuTien)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbBienSo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbSoTienThu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbMaPhieuThu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpNgayThuTien)
        Me.Name = "PhieuThuTien"
        Me.Text = "PhieuThuTien"
        CType(Me.dgvDanhSachPhieuThuTien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpNgayThuTien As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMaPhieuThu As TextBox
    Friend WithEvents tbSoTienThu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbBienSo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvDanhSachPhieuThuTien As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbMaKhachHang As TextBox
End Class
