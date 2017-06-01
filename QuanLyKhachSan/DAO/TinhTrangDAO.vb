Imports DTO.DTO
Imports System.Data.SqlClient

Namespace DAO

    Public Class TinhTrangDAO

#Region "Inserting"
        Public Shared Function themTinhTrang(tinhTrang As TinhTrangDTO) As Boolean
            Dim trangThai As Boolean = False

            Try
                Dim sqlParams As New List(Of SqlParameter)

                sqlParams.Add(New SqlParameter("@LoaiTinhTrang", tinhTrang.LoaiTinhTrang))
                sqlParams.Add(New SqlParameter("@MaPhong", tinhTrang.MaPhong))
                sqlParams.Add(New SqlParameter("@NgayCuaTinhTrang", tinhTrang.NgayCuaTinhTrang))

                Dim n As Integer = SqlDataAccessHelper.ExecuteNoneQuery("NewTinhTrang", sqlParams)

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

        Public Shared Function selectTinhTrangPhongByThoiGian(ngayBatDau As Date, ngayKetThuc As Date) As DataTable

            Dim dt As New DataTable
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@NgayBatDau", ngayBatDau))
                sqlParams.Add(New SqlParameter("@NgayKetThuc", ngayKetThuc))

                dt = SqlDataAccessHelper.ExecuteQuery("selectTinhTrangPhongByThoiGian", sqlParams)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return dt

        End Function

        Public Shared Function phongDuocThue(maPhong As String,
                                                     ngayBatDau As Date, ngayTraPhong As Date) As Boolean
            Dim dt As New DataTable

            Try
                Dim sqlParams As New List(Of SqlParameter)

                sqlParams.Add(New SqlParameter("@MaPhong", maPhong))
                sqlParams.Add(New SqlParameter("@NgayBatDau", ngayBatDau))
                sqlParams.Add(New SqlParameter("@NgayTraPhong", ngayTraPhong))

                dt = SqlDataAccessHelper.ExecuteQuery("phongDuocThue", sqlParams)

                If (dt.Rows.Count > 0) Then
                    Return True 'có phòng đã thuê 
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return False
        End Function

#End Region

#Region "Updating"

        Public Shared Function capNhatTinhTrangPhongByMaPhong(maPhong As String, ngayThue As Date) As Boolean
            Try
                Dim sqlParams As New List(Of SqlParameter)

                sqlParams.Add(New SqlParameter("@MaPhong", maPhong))
                sqlParams.Add(New SqlParameter("@NgayCuaTinhTrang", ngayThue))

                Dim n As Integer = SqlDataAccessHelper.ExecuteNoneQuery("capNhatTinhTrangPhongByMaPhong", sqlParams)

                If (n < 0) Then
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return True
        End Function

#End Region

    End Class

End Namespace

