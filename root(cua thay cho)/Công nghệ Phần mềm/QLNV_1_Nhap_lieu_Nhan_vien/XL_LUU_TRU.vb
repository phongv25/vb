Public Class XL_LUU_TRU
#Region "Biến/Đối tượng toàn cục"
    Dim Ten_CSDL As String = "QLNV_1"
    Dim Thu_muc_CSDL As String = "..\..\.."
    Dim Duong_dan_Tap_tin_Xml As String = Thu_muc_CSDL & "\" & Ten_CSDL & ".xml"
#End Region

#Region "Xử lý Đọc"
    Public Function Doc_Du_lieu() As DataSet
        Dim Kq As New DataSet
        Kq.ReadXml(Duong_dan_Tap_tin_Xml, XmlReadMode.ReadSchema)
        Return Kq
    End Function
#End Region

#Region "Xử lý Ghi"
    Public Function Cap_nhat(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        Dim Du_lieu As DataSet = Bang.DataSet
        Du_lieu.WriteXml(Duong_dan_Tap_tin_Xml, XmlWriteMode.WriteSchema)
        Return Kq
    End Function
#End Region
End Class