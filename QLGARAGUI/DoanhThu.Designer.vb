﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoanhThu
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tbTongDoanhThu = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvPhieuThuTien = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPhieuThuTien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 75)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "Tổng Doanh Thu"
        '
        'tbTongDoanhThu
        '
        Me.tbTongDoanhThu.Location = New System.Drawing.Point(180, 75)
        Me.tbTongDoanhThu.Name = "tbTongDoanhThu"
        Me.tbTongDoanhThu.Size = New System.Drawing.Size(468, 20)
        Me.tbTongDoanhThu.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(342, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvPhieuThuTien
        '
        Me.dgvPhieuThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhieuThuTien.Location = New System.Drawing.Point(65, 157)
        Me.dgvPhieuThuTien.Name = "dgvPhieuThuTien"
        Me.dgvPhieuThuTien.Size = New System.Drawing.Size(525, 150)
        Me.dgvPhieuThuTien.TabIndex = 11
        '
        'DoanhThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvPhieuThuTien)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbTongDoanhThu)
        Me.Controls.Add(Me.TextBox3)
        Me.Name = "DoanhThu"
        Me.Text = "DoanhThu"
        CType(Me.dgvPhieuThuTien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents tbTongDoanhThu As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvPhieuThuTien As DataGridView
End Class
