<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Chon_Nhan_vien
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
        Me.Th_Danh_sach_Nhan_vien = New System.Windows.Forms.FlowLayoutPanel()
        Me.Th_Danh_sach_Don_vi = New System.Windows.Forms.FlowLayoutPanel()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Th_Danh_sach_Nhan_vien
        '
        Me.Th_Danh_sach_Nhan_vien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Danh_sach_Nhan_vien.Location = New System.Drawing.Point(11, 120)
        Me.Th_Danh_sach_Nhan_vien.Name = "Th_Danh_sach_Nhan_vien"
        Me.Th_Danh_sach_Nhan_vien.Size = New System.Drawing.Size(1194, 389)
        Me.Th_Danh_sach_Nhan_vien.TabIndex = 5
        '
        'Th_Danh_sach_Don_vi
        '
        Me.Th_Danh_sach_Don_vi.Location = New System.Drawing.Point(11, 63)
        Me.Th_Danh_sach_Don_vi.Name = "Th_Danh_sach_Don_vi"
        Me.Th_Danh_sach_Don_vi.Size = New System.Drawing.Size(1194, 51)
        Me.Th_Danh_sach_Don_vi.TabIndex = 4
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.ForeColor = System.Drawing.Color.Navy
        Me.Th_Tieu_de.Location = New System.Drawing.Point(358, 15)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(398, 31)
        Me.Th_Tieu_de.TabIndex = 3
        Me.Th_Tieu_de.Text = "Tra cứu nhân viên theo đơn vị"
        '
        'MH_Chon_Nhan_vien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1221, 525)
        Me.Controls.Add(Me.Th_Danh_sach_Nhan_vien)
        Me.Controls.Add(Me.Th_Danh_sach_Don_vi)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_Chon_Nhan_vien"
        Me.Text = "MH_Chon_Nhan_vieni"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Danh_sach_Nhan_vien As FlowLayoutPanel
    Friend WithEvents Th_Danh_sach_Don_vi As FlowLayoutPanel
    Friend WithEvents Th_Tieu_de As Label
End Class
