<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLiXe
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
        Me.dgvDanhSachXe = New System.Windows.Forms.DataGridView()
        Me.tbBienSo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbHieuXe = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbMaKhachHang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMaHieuXe = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvDanhSachXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDanhSachXe
        '
        Me.dgvDanhSachXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachXe.Location = New System.Drawing.Point(12, 370)
        Me.dgvDanhSachXe.Name = "dgvDanhSachXe"
        Me.dgvDanhSachXe.Size = New System.Drawing.Size(731, 252)
        Me.dgvDanhSachXe.TabIndex = 0
        '
        'tbBienSo
        '
        Me.tbBienSo.Location = New System.Drawing.Point(207, 32)
        Me.tbBienSo.Name = "tbBienSo"
        Me.tbBienSo.Size = New System.Drawing.Size(137, 20)
        Me.tbBienSo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Biển số"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Chọn"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(585, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Thêm Xe"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Mã hiệu Xe"
        '
        'tbHieuXe
        '
        Me.tbHieuXe.Location = New System.Drawing.Point(207, 201)
        Me.tbHieuXe.Name = "tbHieuXe"
        Me.tbHieuXe.ReadOnly = True
        Me.tbHieuXe.Size = New System.Drawing.Size(137, 20)
        Me.tbHieuXe.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(77, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Hiệu Xe"
        '
        'tbMaKhachHang
        '
        Me.tbMaKhachHang.Location = New System.Drawing.Point(207, 87)
        Me.tbMaKhachHang.Name = "tbMaKhachHang"
        Me.tbMaKhachHang.Size = New System.Drawing.Size(137, 20)
        Me.tbMaKhachHang.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'cbMaHieuXe
        '
        Me.cbMaHieuXe.FormattingEnabled = True
        Me.cbMaHieuXe.Location = New System.Drawing.Point(207, 143)
        Me.cbMaHieuXe.Name = "cbMaHieuXe"
        Me.cbMaHieuXe.Size = New System.Drawing.Size(137, 21)
        Me.cbMaHieuXe.TabIndex = 21
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(350, 84)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(668, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Tra cứu"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(560, 16)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(100, 20)
        Me.tbSearch.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tbHieuXe)
        Me.GroupBox1.Controls.Add(Me.cbMaHieuXe)
        Me.GroupBox1.Controls.Add(Me.tbBienSo)
        Me.GroupBox1.Controls.Add(Me.tbMaKhachHang)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 256)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CHI TIẾT"
        '
        'QuanLiXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 634)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvDanhSachXe)
        Me.Name = "QuanLiXe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuanLiXe"
        CType(Me.dgvDanhSachXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDanhSachXe As DataGridView
    Friend WithEvents tbBienSo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tbHieuXe As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbMaKhachHang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMaHieuXe As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
