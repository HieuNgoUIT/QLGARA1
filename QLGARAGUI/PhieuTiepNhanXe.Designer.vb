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
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDanhSachPhieuTiepNhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvChiTietPhieuTiepNhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
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
        Me.dgvDanhSachPhieuTiepNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhieuTiepNhan.Location = New System.Drawing.Point(42, 445)
        Me.dgvDanhSachPhieuTiepNhan.Name = "dgvDanhSachPhieuTiepNhan"
        Me.dgvDanhSachPhieuTiepNhan.Size = New System.Drawing.Size(435, 150)
        Me.dgvDanhSachPhieuTiepNhan.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtpNgayTiepNhan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbMaPhieuTiepNhan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 308)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Tạo Phiếu"
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
        Me.tbMaPhieuTiepNhan.Size = New System.Drawing.Size(100, 20)
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
        Me.GroupBox2.Location = New System.Drawing.Point(609, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 273)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
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
        Me.dgvChiTietPhieuTiepNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietPhieuTiepNhan.Location = New System.Drawing.Point(587, 466)
        Me.dgvChiTietPhieuTiepNhan.Name = "dgvChiTietPhieuTiepNhan"
        Me.dgvChiTietPhieuTiepNhan.Size = New System.Drawing.Size(430, 150)
        Me.dgvChiTietPhieuTiepNhan.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(756, 372)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Thêm Chi Tiết"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(565, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Số xe đã tiếp nhận trong ngày"
        '
        'tbXeCount
        '
        Me.tbXeCount.Location = New System.Drawing.Point(721, 23)
        Me.tbXeCount.Name = "tbXeCount"
        Me.tbXeCount.Size = New System.Drawing.Size(100, 20)
        Me.tbXeCount.TabIndex = 8
        '
        'PhieuTiepNhanXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 701)
        Me.Controls.Add(Me.tbXeCount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvChiTietPhieuTiepNhan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PhieuTiepNhanXe"
        Me.Text = "PhieuTiepNhanXe"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvDanhSachPhieuTiepNhan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvChiTietPhieuTiepNhan, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
