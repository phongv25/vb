Public Class MH_Tra_cuu_Nhan_vien_theo_Muc_luong

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
                Dim Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN) = Ung_dung.Danh_sach_Nhan_vien.FindAll(
                                                Function(x) x.Muc_luong >= Can_duoi And x.Muc_luong <= Can_tren)
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