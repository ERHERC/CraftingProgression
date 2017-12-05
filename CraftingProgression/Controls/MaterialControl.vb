Imports CraftingProgression

Public Class MaterialControl
    Implements ICraftingProgression
    Private _Data As CraftingObject
    Friend Property Data As CraftingObject Implements ICraftingProgression.Data
        Get
            Return _Data
        End Get
        Set(Value As CraftingObject)
            _Data = Value
        End Set
    End Property

    Public Property Title As String
        Get
            Return Titlelbl.Text
        End Get
        Set(Value As String)
            Titlelbl.Text = Value
        End Set
    End Property

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If MsgBox("Voulez-vous vraiment supprimer ce composant ?", vbQuestion + vbYesNo, "Supprimer ...").ToString = "Yes" Then
            Me.Parent.Controls.Remove(Me)
        End If
    End Sub

    Private Sub OwnedUD_ValueChanged(sender As Object, e As EventArgs) Handles OwnedUD.ValueChanged
        ColorChange()
    End Sub

    Private Sub NeededUD_ValueChanged(sender As Object, e As EventArgs) Handles NeededUD.ValueChanged
        OwnedUD.Maximum = NeededUD.Value
        ColorChange()
    End Sub

    Private Sub ColorChange() Implements ICraftingProgression.ColorChange
        ProgressionLbl.BackColor = Functions.GetColor(100 * OwnedUD.Value / NeededUD.Value)
        ProgressionLbl.Text = CStr(Math.Floor(100 * OwnedUD.Value / NeededUD.Value)) & "%"
        Try
            If Not (Me.Parent.Parent.Parent.Parent Is Nothing) AndAlso Me.Parent.Parent.Parent.Parent.GetType.FullName.ToString.Contains(".DisplayControl") Then
                CType(Me.Parent.Parent.Parent.Parent, DisplayControl).ColorChange()
            End If
        Catch ErrorCode As Exception
        End Try
    End Sub

    Public Function CalculateProgress() As Double Implements ICraftingProgression.CalculateProgress
        Return CDbl(100 * OwnedUD.Value / NeededUD.Value)
    End Function

    Public Function GetSerialisedObject() As MaterialObject
        Dim ELEMENT As MaterialObject = New MaterialObject
        With CType(ELEMENT, MaterialObject)
            .Type = "material"
            .Title = Titlelbl.Text
            .AmountOwned = OwnedUD.Value
            .AmountNeeded = NeededUD.Value
        End With
        Return ELEMENT
    End Function

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(ByVal ELEMENT As MaterialObject)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        With ELEMENT
            Me.Titlelbl.Text = .Title
            Me.NeededUD.Value = .AmountNeeded
            Me.OwnedUD.Value = .AmountOwned
        End With
    End Sub
End Class
