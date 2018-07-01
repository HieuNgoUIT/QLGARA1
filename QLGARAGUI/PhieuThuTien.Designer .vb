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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvDanhSachPhieuThuTien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(137, 71)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayThuTien.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Phiếu Thu"
        '
        'tbMaPhieuThu
        '
        Me.tbMaPhieuThu.Location = New System.Drawing.Point(137, 28)
        Me.tbMaPhieuThu.Name = "tbMaPhieuThu"
        Me.tbMaPhieuThu.ReadOnly = True
        Me.tbMaPhieuThu.Size = New System.Drawing.Size(200, 20)
        Me.tbMaPhieuThu.TabIndex = 2
        '
        'tbSoTienThu
        '
        Me.tbSoTienThu.Location = New System.Drawing.Point(137, 170)
        Me.tbSoTienThu.Name = "tbSoTienThu"
        Me.tbSoTienThu.Size = New System.Drawing.Size(200, 20)
        Me.tbSoTienThu.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ngày Thu Tiền"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Số tiền thu"
        '
        'tbBienSo
        '
        Me.tbBienSo.Location = New System.Drawing.Point(137, 124)
        Me.tbBienSo.Name = "tbBienSo"
        Me.tbBienSo.Size = New System.Drawing.Size(200, 20)
        Me.tbBienSo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Biển số"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(678, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Lưu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvDanhSachPhieuThuTien
        '
        Me.dgvDanhSachPhieuThuTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachPhieuThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhieuThuTien.Location = New System.Drawing.Point(30, 351)
        Me.dgvDanhSachPhieuThuTien.Name = "dgvDanhSachPhieuThuTien"
        Me.dgvDanhSachPhieuThuTien.Size = New System.Drawing.Size(713, 150)
        Me.dgvDanhSachPhieuThuTien.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(343, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(396, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Mã Chủ Xe"
        '
        'tbMaKhachHang
        '
        Me.tbMaKhachHang.Location = New System.Drawing.Point(462, 126)
        Me.tbMaKhachHang.Name = "tbMaKhachHang"
        Me.tbMaKhachHang.ReadOnly = True
        Me.tbMaKhachHang.Size = New System.Drawing.Size(131, 20)
        Me.tbMaKhachHang.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(510, 288)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Xóa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(206, 288)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Thêm phiếu"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbMaPhieuThu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbMaKhachHang)
        Me.GroupBox1.Controls.Add(Me.dtpNgayThuTien)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.tbBienSo)
        Me.GroupBox1.Controls.Add(Me.tbSoTienThu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 221)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'PhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 547)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvDanhSachPhieuThuTien)
        Me.Controls.Add(Me.Button1)
        Me.Name = "PhieuThuTien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhieuThuTien"
        CType(Me.dgvDanhSachPhieuThuTien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
