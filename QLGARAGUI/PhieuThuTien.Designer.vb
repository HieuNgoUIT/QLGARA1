<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhieuThuTien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvDanhSachPhieuThuTien = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMaPhieuThu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbBienSo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        Me.tbSoTienThu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbMaKhachHang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvDanhSachPhieuThuTien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDanhSachPhieuThuTien
        '
        Me.dgvDanhSachPhieuThuTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachPhieuThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhieuThuTien.Location = New System.Drawing.Point(43, 326)
        Me.dgvDanhSachPhieuThuTien.Name = "dgvDanhSachPhieuThuTien"
        Me.dgvDanhSachPhieuThuTien.Size = New System.Drawing.Size(669, 150)
        Me.dgvDanhSachPhieuThuTien.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Phiếu thu"
        '
        'tbMaPhieuThu
        '
        Me.tbMaPhieuThu.Location = New System.Drawing.Point(131, 38)
        Me.tbMaPhieuThu.Name = "tbMaPhieuThu"
        Me.tbMaPhieuThu.ReadOnly = True
        Me.tbMaPhieuThu.Size = New System.Drawing.Size(200, 20)
        Me.tbMaPhieuThu.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ngày thu tiền"
        '
        'tbBienSo
        '
        Me.tbBienSo.Location = New System.Drawing.Point(131, 140)
        Me.tbBienSo.Name = "tbBienSo"
        Me.tbBienSo.Size = New System.Drawing.Size(100, 20)
        Me.tbBienSo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Biển số"
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(131, 83)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayThuTien.TabIndex = 7
        '
        'tbSoTienThu
        '
        Me.tbSoTienThu.Location = New System.Drawing.Point(131, 193)
        Me.tbSoTienThu.Name = "tbSoTienThu"
        Me.tbSoTienThu.Size = New System.Drawing.Size(200, 20)
        Me.tbSoTienThu.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Số tiền thu"
        '
        'tbMaKhachHang
        '
        Me.tbMaKhachHang.Location = New System.Drawing.Point(470, 138)
        Me.tbMaKhachHang.Name = "tbMaKhachHang"
        Me.tbMaKhachHang.ReadOnly = True
        Me.tbMaKhachHang.Size = New System.Drawing.Size(100, 20)
        Me.tbMaKhachHang.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(367, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mã khách hàng"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(256, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(672, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Xóa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(672, 92)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Thêm"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(343, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Nhập"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbMaKhachHang)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbMaPhieuThu)
        Me.GroupBox1.Controls.Add(Me.dtpNgayThuTien)
        Me.GroupBox1.Controls.Add(Me.tbBienSo)
        Me.GroupBox1.Controls.Add(Me.tbSoTienThu)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 235)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'PhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 506)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvDanhSachPhieuThuTien)
        Me.Name = "PhieuThuTien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhieuThuTien"
        CType(Me.dgvDanhSachPhieuThuTien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDanhSachPhieuThuTien As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMaPhieuThu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbBienSo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpNgayThuTien As DateTimePicker
    Friend WithEvents tbSoTienThu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbMaKhachHang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
