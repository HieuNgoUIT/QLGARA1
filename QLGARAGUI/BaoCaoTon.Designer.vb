<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaoCaoTon
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tbMaBaoCaoTon = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tbThangBaoCao = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.tbMaVatTu = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.tbTonDau = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.tbPhatSinh = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.tbTonCuoi = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(31, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Mã Báo Cáo Tồn"
        '
        'tbMaBaoCaoTon
        '
        Me.tbMaBaoCaoTon.Location = New System.Drawing.Point(189, 44)
        Me.tbMaBaoCaoTon.Name = "tbMaBaoCaoTon"
        Me.tbMaBaoCaoTon.Size = New System.Drawing.Size(479, 20)
        Me.tbMaBaoCaoTon.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(31, 83)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "Tháng Báo Cáo"
        '
        'tbThangBaoCao
        '
        Me.tbThangBaoCao.Location = New System.Drawing.Point(189, 83)
        Me.tbThangBaoCao.Name = "tbThangBaoCao"
        Me.tbThangBaoCao.Size = New System.Drawing.Size(479, 20)
        Me.tbThangBaoCao.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(31, 127)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "Mã Vật Tư"
        '
        'tbMaVatTu
        '
        Me.tbMaVatTu.Location = New System.Drawing.Point(189, 127)
        Me.tbMaVatTu.Name = "tbMaVatTu"
        Me.tbMaVatTu.Size = New System.Drawing.Size(479, 20)
        Me.tbMaVatTu.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(31, 175)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 6
        Me.TextBox7.Text = "Tồn Đầu"
        '
        'tbTonDau
        '
        Me.tbTonDau.Location = New System.Drawing.Point(189, 175)
        Me.tbTonDau.Name = "tbTonDau"
        Me.tbTonDau.Size = New System.Drawing.Size(479, 20)
        Me.tbTonDau.TabIndex = 7
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(31, 226)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 8
        Me.TextBox9.Text = "Phát Sinh"
        '
        'tbPhatSinh
        '
        Me.tbPhatSinh.Location = New System.Drawing.Point(189, 226)
        Me.tbPhatSinh.Name = "tbPhatSinh"
        Me.tbPhatSinh.Size = New System.Drawing.Size(479, 20)
        Me.tbPhatSinh.TabIndex = 9
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(31, 273)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 10
        Me.TextBox11.Text = "Tồn Cuối"
        '
        'tbTonCuoi
        '
        Me.tbTonCuoi.Location = New System.Drawing.Point(189, 273)
        Me.tbTonCuoi.Name = "tbTonCuoi"
        Me.tbTonCuoi.Size = New System.Drawing.Size(479, 20)
        Me.tbTonCuoi.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 28)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BaoCaoTon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbTonCuoi)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.tbPhatSinh)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.tbTonDau)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.tbMaVatTu)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.tbThangBaoCao)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.tbMaBaoCaoTon)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "BaoCaoTon"
        Me.Text = "BaoCaoTon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tbMaBaoCaoTon As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents tbThangBaoCao As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents tbMaVatTu As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents tbTonDau As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents tbPhatSinh As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents tbTonCuoi As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
