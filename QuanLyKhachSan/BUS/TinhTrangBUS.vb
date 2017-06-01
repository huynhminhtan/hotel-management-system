Imports DTO.DTO
Imports DAO.DAO

Namespace BUS

    Public Class TinhTrangBUS
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

        Public Shared Function selectTinhTrangPhongByThoiGian(ngayBatDau As Date, ngayKetThuc As Date) As DataTable
            Return TinhTrangDAO.selectTinhTrangPhongByThoiGian(ngayBatDau, ngayKetThuc.AddDays(1))
        End Function

    End Class

End Namespace

