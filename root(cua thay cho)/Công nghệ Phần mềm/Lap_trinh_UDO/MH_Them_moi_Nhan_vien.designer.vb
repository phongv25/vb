﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Them_moi_Nhan_vien
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
        Me.XL_Dong_y = New System.Windows.Forms.Button()
        Me.Th_Danh_sach_Don_vi = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Th_Ngay_sinh = New System.Windows.Forms.DateTimePicker()
        Me.Th_Gioi_tinh = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Th_Dia_chi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Th_Nhan_vien = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Th_CMND = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Th_Ho_ten = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Th_Thong_bao = New System.Windows.Forms.Label()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.Th_Muc_luong = New System.Windows.Forms.MaskedTextBox()
        Me.Th_Nhan_vien.SuspendLayout()
        Me.SuspendLayout()
        '
        'XL_Dong_y
        '
        Me.XL_Dong_y.BackColor = System.Drawing.Color.Red
        Me.XL_Dong_y.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XL_Dong_y.ForeColor = System.Drawing.Color.White
        Me.XL_Dong_y.Location = New System.Drawing.Point(241, 393)
        Me.XL_Dong_y.Name = "XL_Dong_y"
        Me.XL_Dong_y.Size = New System.Drawing.Size(147, 53)
        Me.XL_Dong_y.TabIndex = 29
        Me.XL_Dong_y.Text = "Đồng ý"
        Me.XL_Dong_y.UseVisualStyleBackColor = False
        '
        'Th_Danh_sach_Don_vi
        '
        Me.Th_Danh_sach_Don_vi.BackColor = System.Drawing.Color.Maroon
        Me.Th_Danh_sach_Don_vi.Location = New System.Drawing.Point(141, 231)
        Me.Th_Danh_sach_Don_vi.Name = "Th_Danh_sach_Don_vi"
        Me.Th_Danh_sach_Don_vi.Size = New System.Drawing.Size(461, 55)
        Me.Th_Danh_sach_Don_vi.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.Location = New System.Drawing.Point(18, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Đơn vị"
        '
        'Th_Ngay_sinh
        '
        Me.Th_Ngay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Th_Ngay_sinh.Location = New System.Drawing.Point(142, 106)
        Me.Th_Ngay_sinh.Name = "Th_Ngay_sinh"
        Me.Th_Ngay_sinh.Size = New System.Drawing.Size(151, 26)
        Me.Th_Ngay_sinh.TabIndex = 28
        '
        'Th_Gioi_tinh
        '
        Me.Th_Gioi_tinh.AutoSize = True
        Me.Th_Gioi_tinh.Location = New System.Drawing.Point(142, 67)
        Me.Th_Gioi_tinh.Name = "Th_Gioi_tinh"
        Me.Th_Gioi_tinh.Size = New System.Drawing.Size(15, 14)
        Me.Th_Gioi_tinh.TabIndex = 27
        Me.Th_Gioi_tinh.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label8.Location = New System.Drawing.Point(14, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Giới tính"
        '
        'Th_Dia_chi
        '
        Me.Th_Dia_chi.Location = New System.Drawing.Point(142, 156)
        Me.Th_Dia_chi.Multiline = True
        Me.Th_Dia_chi.Name = "Th_Dia_chi"
        Me.Th_Dia_chi.Size = New System.Drawing.Size(461, 59)
        Me.Th_Dia_chi.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label7.Location = New System.Drawing.Point(14, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Địa chỉ"
        '
        'Th_Nhan_vien
        '
        Me.Th_Nhan_vien.BackColor = System.Drawing.Color.Maroon
        Me.Th_Nhan_vien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Th_Nhan_vien.Controls.Add(Me.Th_Muc_luong)
        Me.Th_Nhan_vien.Controls.Add(Me.Th_Danh_sach_Don_vi)
        Me.Th_Nhan_vien.Controls.Add(Me.Label5)
        Me.Th_Nhan_vien.Controls.Add(Me.Th_Ngay_sinh)
        Me.Th_Nhan_vien.Controls.Add(Me.Th_Gioi_tinh)
        Me.Th_Nhan_vien.Controls.Add(Me.Label8)
        Me.Th_Nhan_vien.Controls.Add(Me.Th_Dia_chi)
        Me.Th_Nhan_vien.Controls.Add(Me.Label7)
        Me.Th_Nhan_vien.Controls.Add(Me.Label6)
        Me.Th_Nhan_vien.Controls.Add(Me.Label4)
        Me.Th_Nhan_vien.Controls.Add(Me.Th_CMND)
        Me.Th_Nhan_vien.Controls.Add(Me.Label3)
        Me.Th_Nhan_vien.Controls.Add(Me.Th_Ho_ten)
        Me.Th_Nhan_vien.Controls.Add(Me.Label2)
        Me.Th_Nhan_vien.ForeColor = System.Drawing.Color.Yellow
        Me.Th_Nhan_vien.Location = New System.Drawing.Point(25, 67)
        Me.Th_Nhan_vien.Name = "Th_Nhan_vien"
        Me.Th_Nhan_vien.Size = New System.Drawing.Size(632, 320)
        Me.Th_Nhan_vien.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(324, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Mức lương"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(14, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Ngày sinh"
        '
        'Th_CMND
        '
        Me.Th_CMND.Location = New System.Drawing.Point(328, 62)
        Me.Th_CMND.Name = "Th_CMND"
        Me.Th_CMND.Size = New System.Drawing.Size(151, 26)
        Me.Th_CMND.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(200, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CMND"
        '
        'Th_Ho_ten
        '
        Me.Th_Ho_ten.Location = New System.Drawing.Point(141, 18)
        Me.Th_Ho_ten.Name = "Th_Ho_ten"
        Me.Th_Ho_ten.Size = New System.Drawing.Size(389, 26)
        Me.Th_Ho_ten.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(13, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Họ tên"
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.AutoSize = True
        Me.Th_Thong_bao.BackColor = System.Drawing.Color.White
        Me.Th_Thong_bao.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao.ForeColor = System.Drawing.Color.Navy
        Me.Th_Thong_bao.Location = New System.Drawing.Point(677, 67)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Size = New System.Drawing.Size(0, 24)
        Me.Th_Thong_bao.TabIndex = 30
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.ForeColor = System.Drawing.Color.Navy
        Me.Th_Tieu_de.Location = New System.Drawing.Point(212, 19)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(275, 31)
        Me.Th_Tieu_de.TabIndex = 27
        Me.Th_Tieu_de.Text = "Thêm nhân viên mới"
        '
        'Th_Muc_luong
        '
        Me.Th_Muc_luong.Location = New System.Drawing.Point(430, 105)
        Me.Th_Muc_luong.Mask = "0000009"
        Me.Th_Muc_luong.Name = "Th_Muc_luong"
        Me.Th_Muc_luong.RejectInputOnFirstFailure = True
        Me.Th_Muc_luong.Size = New System.Drawing.Size(158, 26)
        Me.Th_Muc_luong.TabIndex = 0
        '
        'MH_Them_moi_Nhan_vien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1104, 462)
        Me.Controls.Add(Me.XL_Dong_y)
        Me.Controls.Add(Me.Th_Nhan_vien)
        Me.Controls.Add(Me.Th_Thong_bao)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_Them_moi_Nhan_vien"
        Me.Text = "MH_Them_moi_Nhan_vien"
        Me.Th_Nhan_vien.ResumeLayout(False)
        Me.Th_Nhan_vien.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents XL_Dong_y As Button
    Friend WithEvents Th_Danh_sach_Don_vi As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Th_Ngay_sinh As DateTimePicker
    Friend WithEvents Th_Gioi_tinh As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Th_Dia_chi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Th_Nhan_vien As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Th_CMND As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Th_Ho_ten As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Th_Thong_bao As Label
    Friend WithEvents Th_Tieu_de As Label
    Friend WithEvents Th_Muc_luong As MaskedTextBox
End Class
