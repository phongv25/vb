Partial Public Class XL_CONG_TY
#Region "Xử lý Khởi tạo  "
    Public ReadOnly Dong As DataRow
    Public ReadOnly Ung_dung As XL_UNG_DUNG
    Public Sub New(Ud As XL_UNG_DUNG, x As DataRow)
        Ung_dung = Ud
        Dong = x
    End Sub
#End Region

#Region "Xử lý cung cấp thông tin"
    Public Property ID As Integer
        Get
            Return Dong("ID")
        End Get
        Set(value As Integer)
            Dong("ID") = value
        End Set
    End Property
    Public Property Ten As String
        Get
            Return Dong("Ten")
        End Get
        Set(value As String)
            Dong("Ten") = value
        End Set
    End Property
    Public Property Tuoi_toi_thieu As Integer
        Get
            Return Dong("Tuoi_toi_thieu")
        End Get
        Set(value As Integer)
            Dong("Tuoi_toi_thieu") = value
        End Set
    End Property
    Public Property Tuoi_toi_da As Integer
        Get
            Return Dong("Tuoi_toi_da")
        End Get
        Set(value As Integer)
            Dong("Tuoi_toi_da") = value
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
#End Region

#Region "Xử lý Tạo chuỗi"
    Public Function Tao_Chuoi_Thong_tin() As String
        Dim Kq As String = ""
        Kq &= "Tên: " & Ten & vbCrLf
        Kq &= "Tuổi tối thiểu: " & Tuoi_toi_thieu & vbCrLf
        Kq &= "Tuổi tối đa: " & Tuoi_toi_da & vbCrLf
        Kq &= "Số đơn vị : " & Ung_dung.Danh_sach_Don_vi.Count & vbCrLf
        Kq &= "Số nhân viên : " & Ung_dung.Danh_sach_Nhan_vien.Count & vbCrLf
        Return Kq
    End Function
#End Region

#Region "Xử lý Kiểm tra "
    
    Public Function Kiem_tra_Cap_nhat() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        '=== Kiểm tra Tên  ====
        Hop_le = Ten <> ""
        If Not Hop_le Then
            Kq &= "Tên phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra Tuổi tối thiểu ====
        Hop_le = Tuoi_toi_thieu >= 18
        If Not Hop_le Then
            Kq &= "Tuổi tối thiểu  là số nguyên >=18 " & vbCrLf
        End If
        '=== Kiểm tra Tuổi tối đa ====
        Hop_le = Tuoi_toi_da <= 150
        If Not Hop_le Then
            Kq &= "Tuổi tối đa  là số nguyên <=150 >" & vbCrLf
        End If
        '=== Kiểm tra Tuổi tối thiểu - Tuổi tối đa ====
        Hop_le = Tuoi_toi_thieu > Tuoi_toi_da
        If Not Hop_le Then
            Kq &= "Tuổi tối thiểu phải <=Tuổi tối đa " & vbCrLf
        End If
        Return Kq
    End Function
    
#End Region







End Class