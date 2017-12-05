<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveDlg = New Vista_Api.SaveFileDialog()
        Me.OpenDlg = New Vista_Api.OpenFileDialog()
        Me.CraftViewer = New CraftingProgression.DisplayControl()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.BackColor = System.Drawing.Color.Transparent
        Me.MenuBar.BackgroundImage = Global.CraftingProgression.My.Resources.Resources.TopBar
        Me.MenuBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Padding = New System.Windows.Forms.Padding(0, 0, 1, 4)
        Me.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuBar.Size = New System.Drawing.Size(1161, 25)
        Me.MenuBar.TabIndex = 3
        Me.MenuBar.Text = "MenuBar"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 0)
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(75, 20)
        Me.NewToolStripButton.Text = "&Nouveau"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 0)
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(60, 20)
        Me.OpenToolStripButton.Text = "&Ouvrir"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 0)
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(92, 20)
        Me.SaveToolStripButton.Text = "&Sauvegarder"
        '
        'SaveDlg
        '
        Me.SaveDlg.DefaultExt = "craft"
        Me.SaveDlg.Filter = "Fichier CraftViewer (*.craft)|*.craft|Fichier XML (*.xml)|*.xml|Fichiers texte (*" &
    ".txt)|*.txt|Tout les fichiers (*.*)|*.*"
        Me.SaveDlg.RestoreDirectory = True
        Me.SaveDlg.Title = "Sauvegarder un fichier"
        '
        'OpenDlg
        '
        Me.OpenDlg.DefaultExt = "craft"
        Me.OpenDlg.Filter = "Fichier CraftViewer (*.craft)|*.craft|Fichier XML (*.xml)|*.xml|Fichiers texte (*" &
    ".txt)|*.txt|Tout les fichiers (*.*)|*.*"
        Me.OpenDlg.RestoreDirectory = True
        Me.OpenDlg.Title = "Ouvrir un fichier"
        '
        'CraftViewer
        '
        Me.CraftViewer.AutoSize = True
        Me.CraftViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CraftViewer.BackColor = System.Drawing.Color.Gray
        Me.CraftViewer.CanBeDeleted = False
        Me.CraftViewer.CanBeExpanded = False
        Me.CraftViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CraftViewer.Location = New System.Drawing.Point(0, 25)
        Me.CraftViewer.Margin = New System.Windows.Forms.Padding(8)
        Me.CraftViewer.Name = "CraftViewer"
        Me.CraftViewer.Size = New System.Drawing.Size(1161, 501)
        Me.CraftViewer.State = CraftingProgression.ExpanderState.Expanded
        Me.CraftViewer.TabIndex = 2
        Me.CraftViewer.Title = "CraftTitle"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 526)
        Me.Controls.Add(Me.CraftViewer)
        Me.Controls.Add(Me.MenuBar)
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Craft Viewer"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CraftViewer As DisplayControl
    Friend WithEvents MenuBar As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents SaveDlg As Vista_Api.SaveFileDialog 'SaveFileDialog
    Friend WithEvents OpenDlg As Vista_Api.OpenFileDialog 'OpenFileDialog
End Class
