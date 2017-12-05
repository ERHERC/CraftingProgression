Public Class AddForm
    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Me.Close()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Globals.AddResult = "Cancel"
        Me.Close()
    End Sub

    Private Sub GroupChckb_CheckedChanged(sender As Object, e As EventArgs) Handles GroupChckb.CheckedChanged
        If GroupChckb.Checked Then
            Globals.AddResult = "Group"
        End If
    End Sub

    Private Sub MaterialChckb_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialChckb.CheckedChanged
        If MaterialChckb.Checked Then
            Globals.AddResult = "Material"
        End If
    End Sub
End Class