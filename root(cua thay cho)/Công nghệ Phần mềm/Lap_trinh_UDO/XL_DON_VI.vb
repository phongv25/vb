Partial Public Class XL_DON_VI
#Region "Xử lý Khởi tạo  "
    Public ReadOnly Dong As DataRow
    Public ReadOnly Ung_dung As XL_UNG_DUNG
    Public Sub New(Ud As XL_UNG_DUNG, x As DataRow)
        Ung_dung = Ud
        Dong = x
    End Sub

#End Region
#Region "Xử lý cung cấp thông tin"
    '====== Thuộc tính ======
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
    Public Property Du_lieu_Hinh As Byte()
        Get
            Return Dong("Du_lieu_Hinh")
        End Get
        Set(value As Byte())
            Dong("Du_lieu_Hinh") = value
        End Set
    End Property
    '======= Quan hệ ======
    Public Function Danh_sach_Nhan_vien() As List(Of XL_NHAN_VIEN)
        Dim Kq As New List(Of XL_NHAN_VIEN)
        For Each Nhan_vien As XL_NHAN_VIEN In Ung_dung.Danh_sach_Nhan_vien
            If Nhan_vien.ID_DON_VI = Me.ID Then
                Kq.Add(Nhan_vien)
            End If
        Next
        Return Kq
    End Function
#End Region

#Region "Xử lý Tạo chuỗi"
    Public Function Tao_Chuoi_Thong_tin() As String
        Dim Kq As String = ""
        Kq &= "Tên: " & Ten & vbCrLf
        Kq &= "Số nhân viên : " & Danh_sach_Nhan_vien.Count & vbCrLf
        Return Kq
    End Function
#End Region



End Class