Public Class MH_Chinh
    Dim Ung_dung As XL_UNG_DUNG
    Dim Luu_tru As New XL_LUU_TRU
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim Du_lieu As DataSet = Luu_tru.Doc_Du_lieu
        Ung_dung = New XL_UNG_DUNG(Du_lieu)
    End Sub
    Private Sub XL_Tra_cuu_Click(sender As Object, e As EventArgs) Handles XL_Tra_cuu_Nhan_vien_theo_Don_vi.Click
        Dim Mh As New MH_Tra_cuu_Nhan_vien_theo_Don_vi(Ung_dung)
        Mh.ShowDialog()
    End Sub

    Private Sub XL_Them_moi_Click(sender As Object, e As EventArgs) Handles XL_Them_moi_Nhan_vien.Click
        Dim Mh As New MH_Them_moi_Nhan_vien(Ung_dung)
        Mh.ShowDialog()
    End Sub

    Private Sub XL_Tra_cuu_Nhan_vien_theo_Muc_luong_Click(sender As Object, e As EventArgs) Handles XL_Tra_cuu_Nhan_vien_theo_Muc_luong.Click
        Dim Mh As New MH_Tra_cuu_Nhan_vien_theo_Muc_luong(Ung_dung)
        Mh.ShowDialog()
    End Sub

    Private Sub XL_Cap_nhat_Nhan_vien_Click(sender As Object, e As EventArgs) Handles XL_Cap_nhat_Nhan_vien.Click
        Dim Mh As New MH_Cap_nhat_Nhan_vien(Ung_dung)
        Mh.ShowDialog()
    End Sub
End Class