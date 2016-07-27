Public Class MH_Tra_cuu_Nhan_vien_theo_Muc_luong

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
        Th_Muc_luong.Text = "4000000-8000000"

    End Sub
#End Region

#Region "Xử lý Biến cố"



    Private Sub Th_Muc_luong_KeyDown(sender As Object, e As KeyEventArgs) Handles Th_Muc_luong.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Chuoi_loi As String = Kiem_tra_Du_lieu_Nhap()
            If Chuoi_loi = "" Then
                '==== Nhập liệu tiêu chí tra cứu 
                Dim Muc_luong As String = Th_Muc_luong.Text.Trim
                Dim M As String() = Split(Muc_luong, "-")
                Dim Can_duoi As Double = M(0)
                Dim Can_tren As Double = M(1)
                '=== Xử lý : Tạo Danh sách nhân viên tương ứng 
                Dim Danh_sach_Nhan_vien As List(Of DataRow) =
                            Nghiep_vu.Danh_sach_Nhan_vien_theo_Muc_luong(Du_lieu, Can_duoi, Can_tren)
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

                Next
            End If
        End If

    End Sub
    Function Kiem_tra_Du_lieu_Nhap() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Muc_luong As String = Th_Muc_luong.Text.Trim
        Hop_le = Muc_luong.Contains("-")
        If Hop_le Then
            Dim M As String() = Split(Muc_luong, "-")
            Hop_le = M.Count = 2 AndAlso IsNumeric(M(0)) AndAlso IsNumeric(M(1))
        End If
        If Not Hop_le Then
            Kq &= "Mức lương nhập có dạng Can_duoi - Can_tren với Can_duoi,Can_tren là 2 số "
        Else

        End If
        Return Kq
    End Function
#End Region

End Class