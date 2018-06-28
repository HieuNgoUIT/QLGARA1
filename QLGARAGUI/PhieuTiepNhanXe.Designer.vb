<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhieuTiepNhanXe
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvDanhSachPhieuTiepNhan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbMaPhieuTiepNhan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbMaChiTietPhieu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbMaPhieuTiepNhan1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbBienSo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvChiTietPhieuTiepNhan = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbXeCount = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDanhSachPhieuTiepNhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvChiTietPhieuTiepNhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.dgvDanhSachPhieuTiepNhan)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(523, 714)
        Me.Panel1.TabIndex = 0
        '
        'dgvDanhSachPhieuTiepNhan
        '
        Me.dgvDanhSachPhieuTiepNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachPhieuTiepNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhieuTiepNhan.Location = New System.Drawing.Point(12, 490)
        Me.dgvDanhSachPhieuTiepNhan.Name = "dgvDanhSachPhieuTiepNhan"
        Me.dgvDanhSachPhieuTiepNhan.Size = New System.Drawing.Size(492, 150)
        Me.dgvDanhSachPhieuTiepNhan.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpNgayTiepNhan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbMaPhieuTiepNhan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 226)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CHI TIẾT"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(17, 137)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(106, 23)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Xóa "
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(17, 88)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Chi Tiết"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(17, 42)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Thêm Phiếu"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Lưu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpNgayTiepNhan
        '
        Me.dtpNgayTiepNhan.Location = New System.Drawing.Point(163, 124)
        Me.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan"
        Me.dtpNgayTiepNhan.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayTiepNhan.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ngày Tiếp Nhận"
        '
        'tbMaPhieuTiepNhan
        '
        Me.tbMaPhieuTiepNhan.Location = New System.Drawing.Point(163, 53)
        Me.tbMaPhieuTiepNhan.Name = "tbMaPhieuTiepNhan"
        Me.tbMaPhieuTiepNhan.ReadOnly = True
        Me.tbMaPhieuTiepNhan.Size = New System.Drawing.Size(64, 20)
        Me.tbMaPhieuTiepNhan.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Tiếp Nhận"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(529, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(555, 686)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.tbMaChiTietPhieu)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tbMaPhieuTiepNhan1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbBienSo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(557, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(507, 198)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CHI TIẾT"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(264, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbMaChiTietPhieu
        '
        Me.tbMaChiTietPhieu.Location = New System.Drawing.Point(147, 146)
        Me.tbMaChiTietPhieu.Name = "tbMaChiTietPhieu"
        Me.tbMaChiTietPhieu.ReadOnly = True
        Me.tbMaChiTietPhieu.Size = New System.Drawing.Size(100, 20)
        Me.tbMaChiTietPhieu.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mã Chi tiết phiếu"
        '
        'tbMaPhieuTiepNhan1
        '
        Me.tbMaPhieuTiepNhan1.Location = New System.Drawing.Point(147, 89)
        Me.tbMaPhieuTiepNhan1.Name = "tbMaPhieuTiepNhan1"
        Me.tbMaPhieuTiepNhan1.ReadOnly = True
        Me.tbMaPhieuTiepNhan1.Size = New System.Drawing.Size(100, 20)
        Me.tbMaPhieuTiepNhan1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Mã Phiếu tiếp nhận"
        '
        'tbBienSo
        '
        Me.tbBienSo.Location = New System.Drawing.Point(147, 25)
        Me.tbBienSo.Name = "tbBienSo"
        Me.tbBienSo.ReadOnly = True
        Me.tbBienSo.Size = New System.Drawing.Size(100, 20)
        Me.tbBienSo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Biển số"
        '
        'dgvChiTietPhieuTiepNhan
        '
        Me.dgvChiTietPhieuTiepNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvChiTietPhieuTiepNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietPhieuTiepNhan.Location = New System.Drawing.Point(557, 490)
        Me.dgvChiTietPhieuTiepNhan.Name = "dgvChiTietPhieuTiepNhan"
        Me.dgvChiTietPhieuTiepNhan.Size = New System.Drawing.Size(507, 150)
        Me.dgvChiTietPhieuTiepNhan.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(794, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Lưu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(757, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Số xe đã tiếp nhận trong ngày"
        '
        'tbXeCount
        '
        Me.tbXeCount.Location = New System.Drawing.Point(913, 23)
        Me.tbXeCount.Name = "tbXeCount"
        Me.tbXeCount.ReadOnly = True
        Me.tbXeCount.Size = New System.Drawing.Size(100, 20)
        Me.tbXeCount.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(19, 42)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Thêm Chi Tiết"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(19, 137)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(103, 23)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Xóa"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(1019, 23)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(45, 23)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "Reset"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(153, 187)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CHỨC NĂNG"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button10)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Location = New System.Drawing.Point(557, 261)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(147, 187)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(19, 88)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(102, 23)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "Chỉnh Sửa"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'PhieuTiepNhanXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 701)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.tbXeCount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvChiTietPhieuTiepNhan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PhieuTiepNhanXe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhieuTiepNhanXe"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvDanhSachPhieuTiepNhan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvChiTietPhieuTiepNhan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvChiTietPhieuTiepNhan As DataGridView
    Friend WithEvents dgvDanhSachPhieuTiepNhan As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents tbMaPhieuTiepNhan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpNgayTiepNhan As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents tbMaChiTietPhieu As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbMaPhieuTiepNhan1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbBienSo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tbXeCount As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button10 As Button
End Class
