Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim formQuanLyPhong As New frmQuanLyPhong

        formQuanLyPhong.TopLevel = False
        formQuanLyPhong.Parent = tabQuanLyPhong
        formQuanLyPhong.Dock = DockStyle.Fill

        formQuanLyPhong.Show()

    End Sub

    Private Sub tabControlQuanLy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControlQuanLy.SelectedIndexChanged

        Dim id As Integer = tabControlQuanLy.SelectedIndex

        Select Case id
            Case 0
                Dim formQuanLyPhong As New frmQuanLyPhong

                formQuanLyPhong.TopLevel = False
                formQuanLyPhong.Parent = tabQuanLyPhong
                formQuanLyPhong.Dock = DockStyle.Fill

                formQuanLyPhong.Show()
            Case 1
                Dim formQuanLyPhieuThue As New frmQuanLyPhieuThue

                formQuanLyPhieuThue.TopLevel = False
                formQuanLyPhieuThue.Parent = tabQuanLyPhieuThue
                formQuanLyPhieuThue.Dock = DockStyle.Fill

                formQuanLyPhieuThue.Show()
            Case 2
                Dim formBaoCaoThang As New frmBaoCaoThang

                formBaoCaoThang.TopLevel = False
                formBaoCaoThang.Parent = tabBaoCaoThang
                formBaoCaoThang.Dock = DockStyle.Fill

                formBaoCaoThang.Show()
            Case 3
                Dim formThayDoiQuyDinh As New frmThayDoiQuyDinh

                formThayDoiQuyDinh.TopLevel = False
                formThayDoiQuyDinh.Parent = tabThayDoiQuyDinh
                formThayDoiQuyDinh.Dock = DockStyle.Fill

                formThayDoiQuyDinh.Show()
            Case 4
                Dim formHeThong As New frmHeThong

                formHeThong.TopLevel = False
                formHeThong.Parent = tabHeThong
                formHeThong.Dock = DockStyle.Fill

                formHeThong.Show()
        End Select

    End Sub
End Class
