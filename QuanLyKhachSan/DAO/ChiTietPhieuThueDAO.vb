Imports DTO.DTO
Imports System.Data.SqlClient

Namespace DAO


    Public Class ChiTietPhieuThueDAO

#Region "Inserting"

        Public Shared Function insertChiTietPhieuThue(chiTietPhieuThue As ChiTietPhieuThueDTO) As Boolean
            Dim trangThai As Boolean = False

            Try
                Dim SqlParams As New List(Of SqlParameter)

                SqlParams.Add(New SqlParameter("@MaPhieuThue", chiTietPhieuThue.MaPhieuThue))
                SqlParams.Add(New SqlParameter("@TenKhachHang", chiTietPhieuThue.TenKhachHang))
                SqlParams.Add(New SqlParameter("@MaLoaiKhachHang", chiTietPhieuThue.MaLoaiKhachHang))
                SqlParams.Add(New SqlParameter("@CMND", chiTietPhieuThue.CMnd))
                SqlParams.Add(New SqlParameter("@DiaChi", chiTietPhieuThue.DiaChi))
                SqlParams.Add(New SqlParameter("@HeSoThucTe", chiTietPhieuThue.HeSoThucTe))

                Dim n As Integer = SqlDataAccessHelper.ExecuteNoneQuery("NewChiTietPhieuThue", SqlParams)

                If (n = 1) Then
                    trangThai = True
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return trangThai
        End Function

#End Region

#Region "Retrieving"

        Public Shared Function selectDanhSachChiTietPhieuAllThueByMaPhieuThue(maPhieuThue As String) As List(Of ChiTietPhieuThueDTO)

            Dim danhSachCTPT As New List(Of ChiTietPhieuThueDTO)

            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@MaPhieuThue", maPhieuThue))

                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectChiTietPhieuAllThueByMaPhieuThue", sqlParams)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

                For Each hang As DataRow In dt.Rows
                    Dim chiTietPhieuThue As New ChiTietPhieuThueDTO

                    chiTietPhieuThue.MaPhieuThue = hang("MaPhieuThue").ToString
                    chiTietPhieuThue.MaChiTietPhieuThue = hang("MaChiTietPhieuThue").ToString
                    chiTietPhieuThue.MaLoaiKhachHang = hang("MaLoaiKhachHang").ToString
                    chiTietPhieuThue.TenKhachHang = hang("TenKhachHang").ToString
                    chiTietPhieuThue.HeSoThucTe = Double.Parse(hang("HeSoThucTe").ToString)
                    chiTietPhieuThue.DiaChi = hang("DiaChi").ToString
                    chiTietPhieuThue.CMnd = hang("CMND").ToString

                    danhSachCTPT.Add(chiTietPhieuThue)
                Next

            Catch ex As Exception
                Throw ex
            End Try
            Return danhSachCTPT
        End Function

#End Region

    End Class

End Namespace

