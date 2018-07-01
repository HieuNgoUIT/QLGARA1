<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VatTu
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbSoLuong = New System.Windows.Forms.TextBox()
        Me.tbMaVatTu = New System.Windows.Forms.TextBox()
        Me.tbDonGia = New System.Windows.Forms.TextBox()
        Me.tbTenVatTu = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(26, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Mã Vật Tư"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(26, 124)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "Tên Vật Tư"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(26, 74)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "Số Lượng"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(26, 174)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 6
        Me.TextBox7.Text = "Đơn Giá"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbSoLuong
        '
        Me.tbSoLuong.Location = New System.Drawing.Point(196, 74)
        Me.tbSoLuong.Name = "tbSoLuong"
        Me.tbSoLuong.Size = New System.Drawing.Size(450, 20)
        Me.tbSoLuong.TabIndex = 9
        '
        'tbMaVatTu
        '
        Me.tbMaVatTu.Location = New System.Drawing.Point(196, 30)
        Me.tbMaVatTu.Name = "tbMaVatTu"
        Me.tbMaVatTu.Size = New System.Drawing.Size(450, 20)
        Me.tbMaVatTu.TabIndex = 10
        '
        'tbDonGia
        '
        Me.tbDonGia.Location = New System.Drawing.Point(196, 174)
        Me.tbDonGia.Name = "tbDonGia"
        Me.tbDonGia.Size = New System.Drawing.Size(450, 20)
        Me.tbDonGia.TabIndex = 24
        '
        'tbTenVatTu
        '
        Me.tbTenVatTu.Location = New System.Drawing.Point(196, 124)
        Me.tbTenVatTu.Name = "tbTenVatTu"
        Me.tbTenVatTu.Size = New System.Drawing.Size(450, 20)
        Me.tbTenVatTu.TabIndex = 25
        '
        'VatTu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbTenVatTu)
        Me.Controls.Add(Me.tbDonGia)
        Me.Controls.Add(Me.tbMaVatTu)
        Me.Controls.Add(Me.tbSoLuong)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "VatTu"
        Me.Text = "VatTu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tbSoLuong As TextBox
    Friend WithEvents tbMaVatTu As TextBox
    Friend WithEvents tbDonGia As TextBox
    Friend WithEvents tbTenVatTu As TextBox
End Class
