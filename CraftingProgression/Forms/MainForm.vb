Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization

Public Class MainForm
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        SaveDlg.ShowDialog()
    End Sub

    Private Sub SaveDlg_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveDlg.FileOk
        Dim DATA As RootObject = New RootObject
        With DATA
            .Title = CraftViewer.Title
            .Data = CraftViewer.GetSerialisedObject()
        End With
        FileSerializer.Serialize(DATA, SaveDlg.FileName)
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        OpenDlg.ShowDialog()
    End Sub

    Private Sub OpenDlg_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenDlg.FileOk
        Me.CraftViewer.LoadObject(FileSerializer.Deserialize(OpenDlg.FileName))
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        Dim NEW_DOCUMENT As RootObject = New RootObject
        With NEW_DOCUMENT
            .Title = "CraftTitle"
            .Data = New RecipeObject With {.Materials = Nothing, .Recipes = Nothing, .Type = "group", .Title = "Craft"}
        End With
        Me.CraftViewer.LoadObject(NEW_DOCUMENT)
    End Sub
End Class