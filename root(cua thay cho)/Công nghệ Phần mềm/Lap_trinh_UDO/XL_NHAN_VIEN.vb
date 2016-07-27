Partial Public Class XL_NHAN_VIEN
#Region "Xử lý Khởi tạo "
    Public ReadOnly Dong As DataRow
    Public ReadOnly Ung_dung As XL_UNG_DUNG
    Public Sub New(Ud As XL_UNG_DUNG, x As DataRow)
        Ung_dung = Ud
        Dong = x
    End Sub
#End Region

#Region "Xử lý cung cấp thông tin"
    '==== Thuộc tính =====
    Public Property ID As Integer
        Get
            Return Dong("ID")
        End Get
        Set(value As Integer)
            Dong("ID") = value
        End Set
    End Property
    Public Property Ho_ten As String
        Get
            Return Dong("Ho_ten")
        End Get
        Set(value As String)
            Dong("Ho_ten") = value
        End Set
    End Property
    Public Property Gioi_tinh As Boolean
        Get
            Return Dong("Gioi_tinh")
        End Get
        Set(value As Boolean)
            Dong("Gioi_tinh") = value
        End Set
    End Property
    Public Property CMND As String
        Get
            Return Dong("CMND")
        End Get
        Set(value As String)
            Dong("CMND") = value
        End Set
    End Property
    Public Property Ngay_sinh As Date
        Get
            Return Dong("Ngay_sinh")
        End Get
        Set(value As Date)
            Dong("Ngay_sinh") = value
        End Set
    End Property
    Public Property Muc_luong As Integer
        Get
            Return Dong("Muc_luong")
        End Get
        Set(value As Integer)
            Dong("Muc_luong") = value
        End Set
    End Property
    Public Property Dia_chi As String
        Get
            Return Dong("Dia_chi")
        End Get
        Set(value As String)
            Dong("Dia_chi") = value
        End Set
    End Property
    Public Property Du_lieu_Hinh As Byte()
        Get
            Return Dong("Du_lieu_Hinh")
        End Get
        Set(value As Byte())
            Dong("Du_lieu_Hinh") = value
        End Set
    End Property
    Public Property ID_DON_VI As Integer
        Get
            Return Dong("ID_DON_VI")
        End Get
        Set(value As Integer)
            Dong("ID_DON_VI") = value
        End Set
    End Property
    '======= Quan hệ ======
    Public Function Don_vi() As XL_DON_VI
        Dim Kq As XL_DON_VI = Nothing
        For Each x As XL_DON_VI In Ung_dung.Danh_sach_Don_vi
            If x.ID = Me.ID_DON_VI Then
                Kq = x
            End If
        Next
        Return Kq
    End Function
#End Region



#Region "Xử lý Tạo chuỗi"
    Public Function Tao_Chuoi_Thong_tin() As String
        Dim Kq As String = ""
        Kq &= "Họ tên : " & Ho_ten & vbCrLf
        Kq &= "CMND : " & CMND & vbCrLf
        Kq &= "Ngày sinh : " & Ngay_sinh & vbCrLf
        If Gioi_tinh Then
            Kq &= "Giới tính : Nam" & vbCrLf
        Else
            Kq &= "Giới tính : Nữ" & vbCrLf
        End If
        Kq &= "Mức lương : " & Muc_luong & vbCrLf
        Kq &= "Địa chỉ : " & Dia_chi & vbCrLf
        Kq &= "Đơn vị : " & Don_vi.Ten & vbCrLf
        Return Kq
    End Function
#End Region

#Region "Xử lý Kiểm tra "
    Public Function Kiem_tra_Ghi_moi() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        '=== Kiểm tra Họ tên ====
        Hop_le = Ho_ten <> ""
        If Not Hop_le Then
            Kq &= "Họ tên phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra CMND ====
        Hop_le = CMND <> "" And Ung_dung.Danh_sach_Nhan_vien.FindAll(Function(x) x.CMND = CMND).Count = 0
        If Not Hop_le Then
            Kq &= "CMND phải khác trống và duy nhất" & vbCrLf
        End If
        '=== Kiểm tra Mức lương ====
        Hop_le = Muc_luong > 0
        If Not Hop_le Then
            Kq &= "Mức lương  là số nguyên >0 " & vbCrLf
        End If
        '=== Kiểm tra Ngày sinh ====
        Dim Cong_ty As XL_CONG_TY = Ung_dung.Cong_ty
        Dim Tuoi_Toi_thieu = Cong_ty.Tuoi_toi_thieu
        Dim Tuoi_Toi_da = Cong_ty.Tuoi_toi_da
        Dim Tuoi As Integer = Today.Year - Ngay_sinh.Year
        Hop_le = Tuoi >= Tuoi_Toi_thieu And Tuoi <= Tuoi_Toi_da
        If Not Hop_le Then
            Kq &= "Tuổi nhân viên từ " & Tuoi_Toi_thieu & " đến " & Tuoi_Toi_da & vbCrLf
        End If
        '=== Kiểm tra Địa chỉ ====
        Hop_le = Dia_chi <> ""
        If Not Hop_le Then
            Kq &= "Địa chỉ phải khác trống" & vbCrLf
        End If
        Return Kq
    End Function
    Public Function Kiem_tra_Cap_nhat() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        '=== Kiểm tra Họ tên ====
        Hop_le = Ho_ten <> ""
        If Not Hop_le Then
            Kq &= "Họ tên phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra CMND ====
        Hop_le = CMND <> "" And Ung_dung.Danh_sach_Nhan_vien.FindAll(Function(x) x.ID <> ID And x.CMND = CMND).Count = 0
        If Not Hop_le Then
            Kq &= "CMND phải khác trống và duy nhất" & vbCrLf
        End If
        '=== Kiểm tra Mức lương ====
        Hop_le = Muc_luong > 0
        If Not Hop_le Then
            Kq &= "Mức lương  là số nguyên >0 " & vbCrLf
        End If
        '=== Kiểm tra Ngày sinh ====
        Dim Cong_ty As XL_CONG_TY = Ung_dung.Cong_ty
        Dim Tuoi_Toi_thieu = Cong_ty.Tuoi_toi_thieu
        Dim Tuoi_Toi_da = Cong_ty.Tuoi_toi_da
        Dim Tuoi As Integer = Today.Year - Ngay_sinh.Year
        Hop_le = Tuoi >= Tuoi_Toi_thieu And Tuoi <= Tuoi_Toi_da
        If Not Hop_le Then
            Kq &= "Tuổi nhân viên từ " & Tuoi_Toi_thieu & " đến " & Tuoi_Toi_da & vbCrLf
        End If
        '=== Kiểm tra Địa chỉ ====
        Hop_le = Dia_chi <> ""
        If Not Hop_le Then
            Kq &= "Địa chỉ phải khác trống" & vbCrLf
        End If
        Return Kq
    End Function
#End Region
End Class