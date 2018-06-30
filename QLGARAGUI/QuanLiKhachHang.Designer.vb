<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuanLiKhachHang
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
        Me.dgvDanhSachKhachHang = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTenKhachHang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbMaKhachHang = New System.Windows.Forms.TextBox()
        Me.tbDienThoai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbTienNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSachKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDanhSachKhachHang
        '
        Me.dgvDanhSachKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachKhachHang.Location = New System.Drawing.Point(33, 413)
        Me.dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang"
        Me.dgvDanhSachKhachHang.Size = New System.Drawing.Size(717, 150)
        Me.dgvDanhSachKhachHang.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'tbTenKhachHang
        '
        Me.tbTenKhachHang.Location = New System.Drawing.Point(192, 100)
        Me.tbTenKhachHang.Name = "tbTenKhachHang"
        Me.tbTenKhachHang.Size = New System.Drawing.Size(127, 20)
        Me.tbTenKhachHang.TabIndex = 4
        Me.tbTenKhachHang.Text = "a"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tên Khách Hàng"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbMaKhachHang)
        Me.GroupBox2.Controls.Add(Me.tbDienThoai)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbDiaChi)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbEmail)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tbTienNo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbTenKhachHang)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 337)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CHI TIẾT"
        '
        'tbMaKhachHang
        '
        Me.tbMaKhachHang.Location = New System.Drawing.Point(192, 52)
        Me.tbMaKhachHang.Name = "tbMaKhachHang"
        Me.tbMaKhachHang.ReadOnly = True
        Me.tbMaKhachHang.Size = New System.Drawing.Size(127, 20)
        Me.tbMaKhachHang.TabIndex = 14
        '
        'tbDienThoai
        '
        Me.tbDienThoai.Location = New System.Drawing.Point(192, 274)
        Me.tbDienThoai.Name = "tbDienThoai"
        Me.tbDienThoai.Size = New System.Drawing.Size(127, 20)
        Me.tbDienThoai.TabIndex = 12
        Me.tbDienThoai.Text = "123"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Điện Thoại"
        '
        'tbDiaChi
        '
        Me.tbDiaChi.Location = New System.Drawing.Point(192, 225)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(127, 20)
        Me.tbDiaChi.TabIndex = 10
        Me.tbDiaChi.Text = "c"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Địa chỉ"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(192, 186)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(127, 20)
        Me.tbEmail.TabIndex = 8
        Me.tbEmail.Text = "b"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email"
        '
        'tbTienNo
        '
        Me.tbTienNo.Location = New System.Drawing.Point(192, 139)
        Me.tbTienNo.Name = "tbTienNo"
        Me.tbTienNo.Size = New System.Drawing.Size(127, 20)
        Me.tbTienNo.TabIndex = 6
        Me.tbTienNo.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tiền nợ"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(356, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Nhập"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(225, 366)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Chọn"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(620, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Thêm KH"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(650, 18)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(100, 20)
        Me.tbSearch.TabIndex = 17
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(569, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Tra cứu"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(620, 198)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'QuanLiKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 584)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvDanhSachKhachHang)
        Me.Name = "QuanLiKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuanLiKhachHang"
        CType(Me.dgvDanhSachKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDanhSachKhachHang As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTenKhachHang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbDienThoai As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbTienNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tbMaKhachHang As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
