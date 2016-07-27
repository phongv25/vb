Public Class MH_Tra_cuu_Nhan_vien_theo_Don_vi

#Region "Biến/Đối tượng toàn cục"
    Dim Luu_tru As New XL_LUU_TRU
    Dim Ung_dung As XL_UNG_DUNG

#End Region

#Region "Xử lý Khởi động"
    Public Sub New(Ung_dung As XL_UNG_DUNG)
        ' This call is required by the designer.
        InitializeComponent()
        Me.Ung_dung = Ung_dung
        ' Add any initialization after the InitializeComponent() call.
        Khoi_dong()
    End Sub

    Sub Khoi_dong()

        '===Khởi động thể hiện ===

        For Each Don_vi As XL_DON_VI In Ung_dung.Danh_sach_Don_vi
            '=== Tạo thể hiện : Don_vi ---> Th_Don_vi
            Dim Th_Don_vi As New Button
            Th_Danh_sach_Don_vi.Controls.Add(Th_Don_vi)
            '=== Xuất Tóm tắt
            Dim Chuoi_Tom_tat As String = Don_vi.Ten
            Th_Don_vi.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Don_vi, Don_vi.Tao_Chuoi_Thong_tin)
            '==Định dạng thể hiện 
            Th_Don_vi.Size = New Size(120, 40)
            Th_Don_vi.Font = New Font("Arial", 14)
            Th_Don_vi.BackColor = Color.White
            Th_Don_vi.ForeColor = Color.Blue
            '===Chuẩn bị biến cố chọn 
            Th_Don_vi.Tag = Don_vi
            AddHandler Th_Don_vi.Click, AddressOf XL_Chon_Don_vi
        Next
    End Sub
#End Region

#Region "Xử lý Biến cố"
    Sub XL_Chon_Don_vi(Th_Don_vi As Control, Bc As EventArgs)
        '=== Nhập liệu : Xác định Đơn vị được chọn 
        Dim Don_vi As XL_DON_VI = Th_Don_vi.Tag
        '=== Xử lý : Tạo Danh sách nhân viên tương ứng 
        Dim Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN) = Don_vi.Danh_sach_Nhan_vien()
        '===Kết xuất : Xuất danh sách nhân viên 
        Th_Danh_sach_Nhan_vien.Controls.Clear()
        For Each Nhan_vien As XL_NHAN_VIEN In Danh_sach_Nhan_vien
            '=== Tạo thể hiện : Nhan_vien --> Th_Nhan_vien
            Dim Th_Nhan_vien As New Button
            Th_Danh_sach_Nhan_vien.Controls.Add(Th_Nhan_vien)
            '=== Xuất Tóm tắt
            Dim Chuoi_Tom_tat As String = Nhan_vien.Ho_ten
            Th_Nhan_vien.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Nhan_vien, Nhan_vien.Tao_Chuoi_Thong_tin)
            '==Định dạng thể hiện 
            Th_Nhan_vien.Size = New Size(220, 50)
            Th_Nhan_vien.Font = New Font("Arial", 14)
            Th_Nhan_vien.BackColor = Color.Black
            Th_Nhan_vien.ForeColor = Color.Yellow
            '===Chuẩn bị biến cố chọn 

        Next
    End Sub
#End Region

End Class