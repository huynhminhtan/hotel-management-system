Imports BUS.BUS
Imports DTO.DTO
Imports GUI.XuLy

Public Class frmLapBaoCaoMatDo

    Private Sub frmLapBaoCaoMatDo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpThang.MaxDate = Date.Now

        '' hiển thị chi tiết phiếu thuê
        hienThiChiTietPhieuThue()
    End Sub

    Private Sub hienThiChiTietPhieuThue()
        Dim bangBaoCaoMatDo As New DataTable

        bangBaoCaoMatDo.Columns.Add("MaPhong", GetType(String))
        bangBaoCaoMatDo.Columns.Add("TenPhong", GetType(String))
        bangBaoCaoMatDo.Columns.Add("TenLoaiPhong", GetType(String))
        bangBaoCaoMatDo.Columns.Add("SoNgayThueTrongThang", GetType(String))
        bangBaoCaoMatDo.Columns.Add("TiLeSuDung", GetType(String))

        If ((PhongBUS.selectDanhSachPhongVoiSoNgayThuegByThang(dtpThang.Value)) Is Nothing) Then
            MessageBox.Show("Không có phòng nào tương ứng với tháng.")
            bangBaoCaoMatDo.Clear()
            dgvBaoCao.ResetBindings()
            dgvBaoCao.DataSource = bangBaoCaoMatDo
            btnLapBaoCao.Enabled = False
            Return
        Else
            For Each hang As DataRow In (PhongBUS.selectDanhSachPhongVoiSoNgayThuegByThang(dtpThang.Value).Rows)
                bangBaoCaoMatDo.Rows.Add(hang("MaPhong"), hang("TenPhong"),
                                         hang("TenLoaiPhong"), hang("SoNgayThue"),
                                        String.Format("{0:0.0%}", hang("SoNgayThue") / System.DateTime.DaysInMonth(dtpThang.Value.Year,
                                                                                                                   dtpThang.Value.Month)))
            Next

            btnLapBaoCao.Enabled = True
            dgvBaoCao.ResetBindings()
            dgvBaoCao.DataSource = bangBaoCaoMatDo

        End If

    End Sub

    Private Sub dtpThang_ValueChanged(sender As Object, e As EventArgs) Handles dtpThang.ValueChanged
        hienThiChiTietPhieuThue()
    End Sub

    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs) Handles btnLapBaoCao.Click
        Dim baoCaoMatDo As New BaoCaoMatDoDTO
        baoCaoMatDo.ThangBaoCaoMatDo = dtpThang.Value.ToShortDateString()

        Using New CenteredMessageBox(Me)
            If (BaoCaoMatDoBUS.kiemTrabaoCaoMatDoByThang(baoCaoMatDo.ThangBaoCaoMatDo) = True) Then
                MessageBox.Show("Báo cáo đã tồn tại trong hệ thống.")
                Return
            End If
        End Using

        Dim bangBaoCaoMatDo As New DataTable
        Dim danhSachChiTietBaoCaoMD As New List(Of ChiTietBaoCaoMDDTO)
        Dim maBaoCaoMatDo = XuLyGUI.tangMa(BaoCaoMatDoBUS.selectMaBaoCaoMatDoMoiNhat(), "MD")

        bangBaoCaoMatDo = dgvBaoCao.DataSource

        For Each hang As DataRow In bangBaoCaoMatDo.Rows
            Dim chiTietBaoCaoMatDo As New ChiTietBaoCaoMDDTO

            chiTietBaoCaoMatDo.MaBaoCaoMatDo = maBaoCaoMatDo
            chiTietBaoCaoMatDo.MaPhong = hang("MaPhong").ToString
            chiTietBaoCaoMatDo.SoNgayThueTrongThang = Integer.Parse(hang("SoNgayThueTrongThang").ToString)
            chiTietBaoCaoMatDo.TiLeSuDung = hang("TiLeSuDung").ToString

            danhSachChiTietBaoCaoMD.Add(chiTietBaoCaoMatDo)
        Next

        Using New CenteredMessageBox(Me)
            '' lưu chi tiết báo cáo xuống hệ thống
            '' lưu báo cáo mật độ xuống hệ thống
            If (((BaoCaoMatDoBUS.themBaoCaoMatDo(baoCaoMatDo)) = True) And
                (ChiTietBaoCaoMDBUS.themDanhSachChiTietBaoCaoMD(danhSachChiTietBaoCaoMD) > 0)) Then
                MessageBox.Show("Lập báo cáo mật độ thành công.")
            Else
                MessageBox.Show("Lập báo cáo mật độ bị lỗi.")
                Return
            End If
        End Using

    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub
End Class