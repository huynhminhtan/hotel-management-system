Imports DTO.DTO
Imports System.Data.SqlClient

Namespace DAO

    Public Class ChiTietBaoCaoMDDAO

#Region "Inserting"
        Public Shared Function themChiTietBaoCaoMD(chiTietBaoCaoMD As ChiTietBaoCaoMDDTO) As Boolean
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@MaBaoCaoMatDo", chiTietBaoCaoMD.MaBaoCaoMatDo))
                sqlParams.Add(New SqlParameter("@MaPhong", chiTietBaoCaoMD.MaPhong))
                sqlParams.Add(New SqlParameter("@SoNgayThueTrongThang", chiTietBaoCaoMD.SoNgayThueTrongThang))
                sqlParams.Add(New SqlParameter("@TiLeSuDung", chiTietBaoCaoMD.TiLeSuDung))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("NewChiTietBaoCaoMD", sqlParams)

                If (n <= 0) Then
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return True
        End Function

#End Region

#Region "Retrieving"

        Public Shared Function selectChiTietBaoCaoMDByMaBaoCaoMaDo(maBaoCaoMatDo As String) As List(Of ChiTietBaoCaoMDDTO)
            Dim danhSachChiTietBaoCaoMD As New List(Of ChiTietBaoCaoMDDTO)
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@MaBaoCaoMatDo", maBaoCaoMatDo))

                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectChiTietBaoCaoMDByMaBaoCaoMaDo", sqlParams)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

                For Each hang As DataRow In dt.Rows
                    Dim chiTietBaoCaoDT As New ChiTietBaoCaoMDDTO
                    chiTietBaoCaoDT.MaChiTietBaoCaoMD = hang("MaChiTietBaoCaoMD").ToString
                    chiTietBaoCaoDT.MaBaoCaoMatDo = hang("MaBaoCaoMatDo").ToString
                    chiTietBaoCaoDT.MaPhong = hang("MaPhong").ToString
                    chiTietBaoCaoDT.SoNgayThueTrongThang = Integer.Parse(hang("SoNgayThueTrongThang").ToString)
                    chiTietBaoCaoDT.TiLeSuDung = hang("TiLeSuDung").ToString

                    danhSachChiTietBaoCaoMD.Add(chiTietBaoCaoDT)
                Next

            Catch ex As Exception
                Throw ex
            End Try
            Return danhSachChiTietBaoCaoMD
        End Function
#End Region
        
    End Class

End Namespace
