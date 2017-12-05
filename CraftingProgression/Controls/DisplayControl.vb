Imports CraftingProgression

Public Class DisplayControl
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

    Private _CanBeDeleted As Boolean = True
    Public Property CanBeDeleted As Boolean
        Get
            Return _CanBeDeleted
        End Get
        Set(Value As Boolean)
            _CanBeDeleted = Value
            DeleteBtn.Visible = Value
        End Set
    End Property

    Private _CanBeExpanded As Boolean = True
    Public Property CanBeExpanded As Boolean
        Get
            Return _CanBeExpanded
        End Get
        Set(Value As Boolean)
            _CanBeExpanded = Value
            ExpandBtn.Visible = Value
            State = State
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

    Private _State As ExpanderState = ExpanderState.Expanded
    Public Property State As ExpanderState
        Get
            Return _State
        End Get
        Set(Value As ExpanderState)
            _State = Value
            If State = ExpanderState.Retracted AndAlso CanBeExpanded Then
                ExpanderContentPanel.Visible = False
                ExpandBtn.BackgroundImage = My.Resources.Expand
            Else
                ExpanderContentPanel.Visible = True
                ExpandBtn.BackgroundImage = My.Resources.Retract
            End If
        End Set
    End Property

    Private Sub ExpandBtn_Click(sender As Object, e As EventArgs) Handles ExpandBtn.Click
        State = 1 - State
    End Sub

    Private Sub OnSizeChangedEvent(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.SizeChanged
        State = State
    End Sub

    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        Call New AddForm().ShowDialog()
        Select Case Globals.AddResult
            Case "Material"
                Dim Control As MaterialControl = New MaterialControl
                Control.Dock = DockStyle.Top
                MaterialsPanel.Controls.Add(Control)
                Control.BringToFront()
            Case "Group"
                Dim Control As DisplayControl = New DisplayControl
                Control.Dock = DockStyle.Top
                RecipesPanel.Controls.Add(Control)
                Control.BringToFront()
        End Select
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If MsgBox("Voulez-vous vraiment supprimer ce groupe ainsi que tous ses sous-composants ?", vbQuestion + vbYesNo, "Supprimer ...").ToString = "Yes" Then
            Me.Parent.Controls.Remove(Me)
        End If
    End Sub

    Public Function CalculateProgress() As Double Implements ICraftingProgression.CalculateProgress
        Dim Total As Double = 0
        Dim Divider As Integer = 0
        Dim Result As Double = 0
        If RecipesPanel.Controls.Count > 0 Then
            For Each CraftingOBJ As ICraftingProgression In RecipesPanel.Controls
                Total += CraftingOBJ.CalculateProgress
                Divider += 1
            Next
        End If
        If MaterialsPanel.Controls.Count > 0 Then
            For Each CraftingOBJ As ICraftingProgression In MaterialsPanel.Controls
                Total += CraftingOBJ.CalculateProgress
                Divider += 1
            Next
        End If

        If Divider > 0 Then
            Result = Total / Divider
            Return Result
        Else
            Return 100
        End If
    End Function

    Public Sub ColorChange() Implements ICraftingProgression.ColorChange
        Dim Progress As Integer = Math.Floor(CalculateProgress())
        ProgressionLbl.BackColor = Functions.GetColor(Progress)
        ProgressionLbl.Text = CStr(Progress) & "%"
        Try
            If Not (Me.Parent.Parent.Parent.Parent Is Nothing) AndAlso Me.Parent.Parent.Parent.Parent.GetType.FullName.ToString.Contains(".DisplayControl") Then
                CType(Me.Parent.Parent.Parent.Parent, DisplayControl).ColorChange()
            End If
        Catch ErrorCode As Exception
        End Try
    End Sub

    Private Sub DisplayControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorChange()
    End Sub

    Public Function GetSerialisedObject() As RecipeObject
        Dim RESULT_RECIPES As List(Of RecipeObject) = New List(Of RecipeObject) : RESULT_RECIPES.Clear()
        For Each RECIPE_OBJ As DisplayControl In RecipesPanel.Controls
            RESULT_RECIPES.Add(RECIPE_OBJ.GetSerialisedObject)
        Next

        Dim RESULT_MATERIALS As List(Of MaterialObject) = New List(Of MaterialObject) : RESULT_MATERIALS.Clear()
        For Each MATERIAL_OBJ As MaterialControl In MaterialsPanel.Controls
            RESULT_MATERIALS.Add(MATERIAL_OBJ.GetSerialisedObject)
        Next

        Dim RESULT As RecipeObject = New RecipeObject
        With RESULT
            .Type = "group"
            .Title = Titlelbl.Text
            .Recipes = RESULT_RECIPES
            .Materials = RESULT_MATERIALS
        End With

        Return RESULT
    End Function

    Private Sub MaterialsPanel_ControlAdded(sender As Object, e As ControlEventArgs) Handles MaterialsPanel.ControlAdded
        ColorChange()
    End Sub

    Private Sub MaterialsPanel_ControlRemoved(sender As Object, e As ControlEventArgs) Handles MaterialsPanel.ControlRemoved
        ColorChange()
    End Sub

    Private Sub RecipesPanel_ControlAdded(sender As Object, e As ControlEventArgs) Handles RecipesPanel.ControlAdded
        ColorChange()
    End Sub

    Private Sub RecipesPanel_ControlRemoved(sender As Object, e As ControlEventArgs) Handles RecipesPanel.ControlRemoved
        ColorChange()
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(ByVal ELEMENT As RootObject)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        LoadObject(ELEMENT)
    End Sub

    Public Sub LoadObject(ByVal ELEMENT As RootObject)
        Destroy()

        Dim CONTAINER As RecipeObject = ELEMENT.Data

        If Not (CONTAINER.Recipes Is Nothing) Then
            For Each RECIPE_OBJ As RecipeObject In CONTAINER.Recipes
                Me.RecipesPanel.Controls.Add(New DisplayControl(RECIPE_OBJ) With {.Dock = DockStyle.Top})
            Next
        End If

        If Not (CONTAINER.Materials Is Nothing) Then
            For Each MATERIAL_OBJ As MaterialObject In CONTAINER.Materials
                Me.MaterialsPanel.Controls.Add(New MaterialControl(MATERIAL_OBJ) With {.Dock = DockStyle.Top})
            Next
        End If

        With ELEMENT
            Me.Titlelbl.Text = .Title
        End With
    End Sub

    Public Sub New(ByVal ELEMENT As RecipeObject)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        LoadObject(ELEMENT)
    End Sub

    Public Sub LoadObject(ByVal ELEMENT As RecipeObject)
        Destroy()

        If Not (ELEMENT.Recipes Is Nothing) Then
            For Each RECIPE_OBJ As RecipeObject In ELEMENT.Recipes
                Me.RecipesPanel.Controls.Add(New DisplayControl(RECIPE_OBJ) With {.Dock = DockStyle.Top})
            Next
        End If

        If Not (ELEMENT.Materials Is Nothing) Then
            For Each MATERIAL_OBJ As MaterialObject In ELEMENT.Materials
                Me.MaterialsPanel.Controls.Add(New MaterialControl(MATERIAL_OBJ) With {.Dock = DockStyle.Top})
            Next
        End If

        With ELEMENT
            Me.Titlelbl.Text = .Title
        End With
    End Sub

    Public Sub Destroy()
        Try
            Me.RecipesPanel.Controls.Clear()
            Me.MaterialsPanel.Controls.Clear()
        Catch ErrorCode As Exception

        End Try
    End Sub
End Class
