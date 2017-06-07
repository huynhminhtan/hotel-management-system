Imports System.Data.SqlClient
Imports DTO.DTO

Namespace DAO

    Public Class ChiTietBaoCaoDTDAO
#Region "Inserting"
        Public Shared Function themChiTietBaoCaoDT(chiTietBaoCaoDT As ChiTietBaoCaoDTDTO) As Boolean
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@MaBaoCaoDoanhThu", chiTietBaoCaoDT.MaBaoCaoDoanhThu))
                sqlParams.Add(New SqlParameter("@MaLoaiPhong", chiTietBaoCaoDT.MaLoaiPhong))
                sqlParams.Add(New SqlParameter("@DoanhThuLoaiPhong", chiTietBaoCaoDT.DoanhThuLoaiPhong))
                sqlParams.Add(New SqlParameter("@TiLeDoanhThu", chiTietBaoCaoDT.TiLeDoanhThu))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("NewChiTietBaoCaoDT", sqlParams)

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

        Public Shared Function selectChiTietBaoCaoDoanhThuByMaBaoCaoDoanhThu(maBaoCaDoanhThu As String) As List(Of ChiTietBaoCaoDTDTO)
            Dim danhSachChiTietBaoCaoDT As New List(Of ChiTietBaoCaoDTDTO)
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@MaBaoCaoDoanhThu", maBaoCaDoanhThu))

                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectChiTietBaoCaoDoanhThuByMaBaoCaoDoanhThu", sqlParams)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

                For Each hang As DataRow In dt.Rows
                    Dim chiTietBaoCaoDT As New ChiTietBaoCaoDTDTO
                    chiTietBaoCaoDT.MaChiTietBaoCaoDT = hang("MaChiTietBaoCaoDT").ToString
                    chiTietBaoCaoDT.MaBaoCaoDoanhThu = hang("MaBaoCaoDoanhThu").ToString
                    chiTietBaoCaoDT.MaLoaiPhong = hang("MaLoaiPhong").ToString
                    chiTietBaoCaoDT.DoanhThuLoaiPhong = Double.Parse(hang("DoanhThuLoaiPhong").ToString)
                    chiTietBaoCaoDT.TiLeDoanhThu = hang("TiLeDoanhThu").ToString

                    danhSachChiTietBaoCaoDT.Add(chiTietBaoCaoDT)
                Next

            Catch ex As Exception
                Throw ex
            End Try
            Return danhSachChiTietBaoCaoDT
        End Function

#End Region

    End Class

End Namespace

