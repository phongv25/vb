Partial Public Class XL_UNG_DUNG
#Region "Xử lý Khởi tạo"
    Public ReadOnly Du_lieu As DataSet
    Public Sub New(x As DataSet)
        Du_lieu = x
    End Sub

    Public Function Tao_Nhan_vien_moi() As XL_NHAN_VIEN
        Dim Kq As XL_NHAN_VIEN
        Dim Dong = Du_lieu.Tables("NHAN_VIEN").NewRow
        Dong("Ho_ten") = ""
        Dong("CMND") = ""
        Dong("Gioi_tinh") = True
        Dong("Ngay_sinh") = New Date(Today.Year - 30, 1, 1)
        Dong("Muc_luong") = 4000000
        Dong("Dia_chi") = ""
        Dong("ID_DON_VI") = Danh_sach_Don_vi(0).ID
        Kq = New XL_NHAN_VIEN(Me, Dong)
        Return Kq
    End Function
#End Region

#Region "Xử lý cung cấp thông tin"
    Public Function Cong_ty() As XL_CONG_TY
        Dim Kq As XL_CONG_TY
        Dim Dong As DataRow = Du_lieu.Tables("CONG_TY").Rows(0)
        Kq = New XL_CONG_TY(Me, Dong)
        Return Kq
    End Function
    Public Function Danh_sach_Don_vi() As List(Of XL_DON_VI)
        Dim Kq As New List(Of XL_DON_VI)
        For Each Dong As DataRow In Du_lieu.Tables("DON_VI").Rows
            Dim Don_vi As New XL_DON_VI(Me, Dong)
            Kq.Add(Don_vi)
        Next
        Return Kq
    End Function
    Public Function Danh_sach_Nhan_vien() As List(Of XL_NHAN_VIEN)
        Dim Kq As New List(Of XL_NHAN_VIEN)
        For Each Dong As DataRow In Du_lieu.Tables("NHAN_VIEN").Rows
            Dim Nhan_vien As New XL_NHAN_VIEN(Me, Dong)
            Kq.Add(Nhan_vien)
        Next
        Return Kq
    End Function

#End Region

End Class