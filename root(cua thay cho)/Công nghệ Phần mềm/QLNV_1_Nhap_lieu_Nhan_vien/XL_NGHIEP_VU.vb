Public Class XL_NGHIEP_VU

#Region "Khai thác thông tin"
    '==== Xử lý Trích rút 
    Public Function Danh_sach_Nhan_vien_theo_Don_vi(Don_vi As DataRow) As List(Of DataRow)
        Dim Kq As List(Of DataRow)
        Dim Du_lieu As DataSet = Don_vi.Table.DataSet
        Dim Bang_Nhan_vien As DataTable = Du_lieu.Tables("NHAN_VIEN")
        Dim Dieu_kien As String = "ID_DON_VI=" & Don_vi("ID")
        Kq = Bang_Nhan_vien.Select(Dieu_kien).ToList
        Return Kq
    End Function
    Public Function Don_vi(Nhan_vien As DataRow) As DataRow
        Dim Kq As DataRow
        Dim Du_lieu As DataSet = Nhan_vien.Table.DataSet
        Dim Bang_Don_vi As DataTable = Du_lieu.Tables("DON_VI")
        Dim Dieu_kien As String = "ID=" & Nhan_vien("ID_DON_VI")
        Kq = Bang_Don_vi.Select(Dieu_kien)(0)
        Return Kq
    End Function
#End Region

#Region "Tiếp nhận thông tin"


    Public Function Kiem_tra_Cap_nhat_Nhan_vien(Nhan_vien As DataRow) As String
        Dim Kq As String = ""
        Dim Du_lieu As DataSet = Nhan_vien.Table.DataSet
        Dim Cong_ty As DataRow = Du_lieu.Tables("CONG_TY").Rows(0)
        Dim Hop_le As Boolean
        '=== Kiểm tra Họ tên ====
        Hop_le = Nhan_vien("Ho_ten").ToString.Trim <> ""
        If Not Hop_le Then
            Kq &= "Họ tên phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra CMND ====
        Dim CMND As String = Nhan_vien("CMND")
        Dim Dieu_kien As String = "ID <> " & Nhan_vien("ID") & " and CMND='" & CMND & "'"
        Hop_le = CMND <> "" And Du_lieu.Tables("NHAN_VIEN").Select(Dieu_kien).Count = 0
        If Not Hop_le Then
            Kq &= "CMND phải khác trống và duy nhất" & vbCrLf
        End If
        '=== Kiểm tra Mức lương ====
        Hop_le = Nhan_vien("Muc_luong") > 0
        If Not Hop_le Then
            Kq &= "Mức lương  là số nguyên > 0 " & vbCrLf
        End If
        '=== Kiểm tra Ngày sinh ====
        Dim Tuoi_Toi_thieu = Cong_ty("Tuoi_Toi_thieu")
        Dim Tuoi_Toi_da = Cong_ty("Tuoi_Toi_da")
        Dim Tuoi As Integer = Today.Year - Nhan_vien("Ngay_sinh").Year
        Hop_le = Tuoi >= Tuoi_Toi_thieu And Tuoi <= Tuoi_Toi_da
        If Not Hop_le Then
            Kq &= "Tuổi nhân viên từ " & Tuoi_Toi_thieu & " đến " & Tuoi_Toi_da & vbCrLf
        End If
        '=== Kiểm tra Địa chỉ ====
        Hop_le = Nhan_vien("Dia_chi").ToString.Trim <> ""
        If Not Hop_le Then
            Kq &= "Địa chỉ phải khác trống" & vbCrLf
        End If
        Return Kq
    End Function
#End Region

End Class
