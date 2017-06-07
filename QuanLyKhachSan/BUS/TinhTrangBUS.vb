Imports DTO.DTO
Imports DAO.DAO

Namespace BUS

    Public Class TinhTrangBUS
#Region "Inserting"

        Public Shared Function themTinhTrang(tinhTrang As TinhTrangDTO, ngayLapPhong As Date) As Boolean
            ' ngày lập phòng cộng số năm cho tình trạng
            Dim ngayTam As Date = ngayLapPhong

            For chiSo As Integer = 1 To (Cons.namTinhTrang * 365)
                Dim tinhTrangTam As New TinhTrangDTO

                tinhTrangTam.NgayCuaTinhTrang = ngayTam.Date
                tinhTrangTam.LoaiTinhTrang = tinhTrang.LoaiTinhTrang
                tinhTrangTam.MaPhong = tinhTrang.MaPhong

                If (TinhTrangDAO.themTinhTrang(tinhTrangTam) = False) Then
                    Return False
                End If

                ngayTam = ngayTam.AddDays(1)

            Next

            Return True
        End Function

#End Region

#Region "Retrieving"

        Public Shared Function selectTinhTrangPhongByThoiGian(ngayBatDau As Date, ngayKetThuc As Date) As DataTable
            Return TinhTrangDAO.selectTinhTrangPhongByThoiGian(ngayBatDau, ngayKetThuc)
        End Function

        Public Shared Function phongDuocThue(maPhong As String,
                                                 ngayBatDau As Date, ngayTraPhong As Date) As Boolean
            Return TinhTrangDAO.phongDuocThue(maPhong, ngayBatDau, ngayTraPhong)
        End Function

#End Region

#Region "Updating"

        Public Shared Function capNhatTinhTrangPhongByMaPhong(maPhong As String,
                                        ngayBatDau As Date, ngayTraPhong As Date) As Boolean

            Dim ngayTam As Date = ngayBatDau

            For chiSo As Integer = 1 To ((ngayTraPhong - ngayBatDau).Days + 1)
                If (TinhTrangDAO.capNhatTinhTrangPhongByMaPhong(maPhong, ngayTam) = False) Then
                    Return False
                End If
                ngayTam = ngayTam.AddDays(1)
            Next

            Return True
        End Function

#End Region

    End Class

End Namespace

