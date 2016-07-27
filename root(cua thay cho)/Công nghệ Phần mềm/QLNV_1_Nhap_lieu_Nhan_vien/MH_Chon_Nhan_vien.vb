Public Class MH_Chon_Nhan_vien

#Region "Biến/Đối tượng giao tiếp"
    Public Nhan_vien_Chon As DataRow
#End Region
#Region "Biến/Đối tượng toàn cục"
    Dim Luu_tru As New XL_LUU_TRU
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Du_lieu As DataSet
#End Region

#Region "Xử lý Khởi động"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Khoi_dong()
    End Sub

    Sub Khoi_dong()
        '==== Khởi động dữ liệu : CSDL ---> Du_lieu ====
        Du_lieu = Luu_tru.Doc_Du_lieu
        '===Khởi động thể hiện ===
        Dim Danh_sach_Don_vi As List(Of DataRow) = Du_lieu.Tables("DON_VI").Select.ToList
        For Each Don_vi As DataRow In Danh_sach_Don_vi
            '=== Tạo thể hiện : Don_vi ---> Th_Don_vi
            Dim Th_Don_vi As New Button
            Th_Danh_sach_Don_vi.Controls.Add(Th_Don_vi)
            '=== Xuất Tóm tắt
            Dim Chuoi_Tom_tat As String = Don_vi("Ten")
            Th_Don_vi.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Dim Chuoi_Thong_tin As String = ""
            Chuoi_Thong_tin &= "Tên : " & Don_vi("Ten") & vbCrLf
            Chuoi_Thong_tin &= "Số nhân viên : " & Nghiep_vu.Danh_sach_Nhan_vien_theo_Don_vi(Don_vi).Count & vbCrLf
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Don_vi, Chuoi_Thong_tin)
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
        Dim Don_vi As DataRow = Th_Don_vi.Tag
        '=== Xử lý : Tạo Danh sách nhân viên tương ứng 
        Dim Danh_sach_Nhan_vien As List(Of DataRow) = Nghiep_vu.Danh_sach_Nhan_vien_theo_Don_vi(Don_vi)
        '===Kết xuất : Xuất danh sách nhân viên 
        Th_Danh_sach_Nhan_vien.Controls.Clear()
        For Each Nhan_vien As DataRow In Danh_sach_Nhan_vien
            '=== Tạo thể hiện : Nhan_vien --> Th_Nhan_vien
            Dim Th_Nhan_vien As New Button
            Th_Danh_sach_Nhan_vien.Controls.Add(Th_Nhan_vien)
            '=== Xuất Tóm tắt
            Dim Chuoi_Tom_tat As String = Nhan_vien("Ho_ten")
            Th_Nhan_vien.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Dim Chuoi_Thong_tin As String = ""
            Chuoi_Thong_tin &= "Họ tên : " & Nhan_vien("Ho_ten") & vbCrLf
            Chuoi_Thong_tin &= "CMND : " & Nhan_vien("CMND") & vbCrLf
            If Nhan_vien("Gioi_tinh") Then
                Chuoi_Thong_tin &= "Giới tính : Nam" & vbCrLf
            Else
                Chuoi_Thong_tin &= "Giới tính : Nữ" & vbCrLf
            End If
            Dim Ngay_sinh As Date = Nhan_vien("Ngay_sinh")
            Chuoi_Thong_tin &= "Ngày sinh : " & Ngay_sinh & "  "
            Dim Tuoi As Integer = Date.Today.Year - Ngay_sinh.Year
            Chuoi_Thong_tin &= "Tuổi : " & Tuoi & vbCrLf
            Chuoi_Thong_tin &= "Mức lương: " & Nhan_vien("Muc_luong") & vbCrLf
            Chuoi_Thong_tin &= "Địa chỉ : " & Nhan_vien("Dia_chi") & vbCrLf
            Chuoi_Thong_tin &= "Đơn vị : " & Nghiep_vu.Don_vi(Nhan_vien)("Ten") & vbCrLf
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Nhan_vien, Chuoi_Thong_tin)
            '==Định dạng thể hiện 
            Th_Nhan_vien.Size = New Size(220, 50)
            Th_Nhan_vien.Font = New Font("Arial", 14)
            Th_Nhan_vien.BackColor = Color.Black
            Th_Nhan_vien.ForeColor = Color.Yellow
            '===Chuẩn bị biến cố chọn 
            Th_Nhan_vien.Tag = Nhan_vien
            AddHandler Th_Nhan_vien.Click, AddressOf XL_Chon_Nhan_vien
        Next
    End Sub

    Sub XL_Chon_Nhan_vien(Th_Nhan_vien As Control, Bc As EventArgs)
        Nhan_vien_Chon = Th_Nhan_vien.Tag
        Me.Close()
    End Sub
#End Region

End Class