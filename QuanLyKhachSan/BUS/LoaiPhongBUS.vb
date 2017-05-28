Imports DAO.DAO


Namespace BUS

    Public Class LoaiPhongBUS

#Region "ReTrieving"

        Public Shared Function SelectAllLoaiPhong() As DataTable
            Return LoaiPhongDAO.selectAllLoaiPhong()
        End Function

#End Region

    End Class

End Namespace
