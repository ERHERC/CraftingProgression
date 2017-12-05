Module Functions
    Public Function GetColor(ByVal Progress As Double) As Color
        If Progress = 100 Then
            Return Color.FromArgb(17, 85, 204)
        End If
        If Progress = 50 Then
            Return Color.FromArgb(241, 194, 50)
        End If
        If Progress > 50 Then
            Return LerpColor(Color.FromArgb(241, 194, 50), Color.FromArgb(56, 118, 29), (Progress - 50) / 50)

        End If
        If Progress < 50 Then
            Return LerpColor(Color.FromArgb(153, 0, 0), Color.FromArgb(241, 194, 50), 1 + ((Progress - 50) / 50))
        End If
        Return Color.White
    End Function

    Public Function LerpColor(ByVal color1 As Color, ByVal color2 As Color, ByVal amount As Single) As Color
        Const bitmask As Single = 65536.0!
        Dim n As UInteger = CUInt(Math.Round(CDbl(Math.Max(Math.Min((amount * bitmask), bitmask), 0.0!))))
        Dim r As Integer = (CInt(color1.R) + (((CInt(color2.R) - CInt(color1.R)) * CInt(n)) >> 16))
        Dim g As Integer = (CInt(color1.G) + (((CInt(color2.G) - CInt(color1.G)) * CInt(n)) >> 16))
        Dim b As Integer = (CInt(color1.B) + (((CInt(color2.B) - CInt(color1.B)) * CInt(n)) >> 16))
        Dim a As Integer = (CInt(color1.A) + (((CInt(color2.A) - CInt(color1.A)) * CInt(n)) >> 16))
        Return Color.FromArgb(a, r, g, b)
    End Function
End Module
