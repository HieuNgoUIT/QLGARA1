﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TiếpNhậnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XuấtPhiếuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhiếuThuTiềnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiếpNhậnToolStripMenuItem, Me.XuấtPhiếuToolStripMenuItem, Me.PhiếuThuTiềnToolStripMenuItem})
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
        Me.XuấtPhiếuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLíXeToolStripMenuItem, Me.QuảnLíKháchHàngToolStripMenuItem})
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
End Class
