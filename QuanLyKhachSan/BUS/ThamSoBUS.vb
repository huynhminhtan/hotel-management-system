Imports DAO.DAO
Imports DTO.DTO

Namespace BUS
    Public Class ThamSoBUS

#Region "ReTrieving"

        Public Shared Function selectThamSoAll() As ThamSoDTO
            Return ThamSoDAO.selectThamSoAll()
        End Function

#End Region

#Region "Inserting"

        Public Shared Function capNhatThamSo(thamSo As ThamSoDTO) As Boolean
            Return ThamSoDAO.capNhatThamSo(thamSo)
        End Function

#End Region

    End Class
End Namespace
