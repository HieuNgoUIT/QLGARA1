﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TiếpNhậnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XuấtPhiếuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhiếuThuTiềnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhiếuSữaChữaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoanhThuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoTồnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiếpNhậnToolStripMenuItem, Me.XuấtPhiếuToolStripMenuItem, Me.PhiếuThuTiềnToolStripMenuItem, Me.PhiếuSữaChữaToolStripMenuItem, Me.DoanhThuToolStripMenuItem, Me.BáoCáoTồnToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(623, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TiếpNhậnToolStripMenuItem
        '
        Me.TiếpNhậnToolStripMenuItem.Name = "TiếpNhậnToolStripMenuItem"
        Me.TiếpNhậnToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.TiếpNhậnToolStripMenuItem.Text = "Tiếp Nhận"
        '
        'XuấtPhiếuToolStripMenuItem
        '
        Me.XuấtPhiếuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLíXeToolStripMenuItem, Me.QuảnLíKháchHàngToolStripMenuItem, Me.QuanToolStripMenuItem})
        Me.XuấtPhiếuToolStripMenuItem.Name = "XuấtPhiếuToolStripMenuItem"
        Me.XuấtPhiếuToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.XuấtPhiếuToolStripMenuItem.Text = "Quản lí"
        '
        'QuảnLíXeToolStripMenuItem
        '
        Me.QuảnLíXeToolStripMenuItem.Name = "QuảnLíXeToolStripMenuItem"
        Me.QuảnLíXeToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.QuảnLíXeToolStripMenuItem.Text = "Quản lí xe"
        '
        'QuảnLíKháchHàngToolStripMenuItem
        '
        Me.QuảnLíKháchHàngToolStripMenuItem.Name = "QuảnLíKháchHàngToolStripMenuItem"
        Me.QuảnLíKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.QuảnLíKháchHàngToolStripMenuItem.Text = "Quản lí khách hàng"
        '
        'PhiếuThuTiềnToolStripMenuItem
        '
        Me.PhiếuThuTiềnToolStripMenuItem.Name = "PhiếuThuTiềnToolStripMenuItem"
        Me.PhiếuThuTiềnToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.PhiếuThuTiềnToolStripMenuItem.Text = "Phiếu Thu Tiền"
        '
        'QuanToolStripMenuItem
        '
        Me.QuanToolStripMenuItem.Name = "QuanToolStripMenuItem"
        Me.QuanToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.QuanToolStripMenuItem.Text = "Quản lí vật tư"
        '
        'PhiếuSữaChữaToolStripMenuItem
        '
        Me.PhiếuSữaChữaToolStripMenuItem.Name = "PhiếuSữaChữaToolStripMenuItem"
        Me.PhiếuSữaChữaToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.PhiếuSữaChữaToolStripMenuItem.Text = "Phiếu sữa chữa"
        '
        'DoanhThuToolStripMenuItem
        '
        Me.DoanhThuToolStripMenuItem.Name = "DoanhThuToolStripMenuItem"
        Me.DoanhThuToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.DoanhThuToolStripMenuItem.Text = "Doanh thu"
        '
        'BáoCáoTồnToolStripMenuItem
        '
        Me.BáoCáoTồnToolStripMenuItem.Name = "BáoCáoTồnToolStripMenuItem"
        Me.BáoCáoTồnToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.BáoCáoTồnToolStripMenuItem.Text = "Báo cáo tồn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 446)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TiếpNhậnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XuấtPhiếuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhiếuThuTiềnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLíXeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLíKháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhiếuSữaChữaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoanhThuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BáoCáoTồnToolStripMenuItem As ToolStripMenuItem
End Class
