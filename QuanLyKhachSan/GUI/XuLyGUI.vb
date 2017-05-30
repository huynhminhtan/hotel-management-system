Namespace XuLy

    Public Class XuLyGUI

        Public Shared Function laChuoiHopLe(str As String) As Boolean
            If (String.IsNullOrEmpty(str) Or String.IsNullOrWhiteSpace(str)) Then
                Return False
            End If
            Return True
        End Function

    End Class
End Namespace
