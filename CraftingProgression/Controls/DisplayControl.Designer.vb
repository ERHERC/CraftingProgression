<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CraftPanel = New System.Windows.Forms.Panel()
        Me.MaterialsPanel = New System.Windows.Forms.Panel()
        Me.RecipesPanel = New System.Windows.Forms.Panel()
        Me.ExpanderContentPanel = New System.Windows.Forms.Panel()
        Me.TaskPanel = New System.Windows.Forms.Panel()
        Me.AddNewBtn = New System.Windows.Forms.Button()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.HeaderMiddlePanel = New System.Windows.Forms.Panel()
        Me.Titlelbl = New System.Windows.Forms.TextBox()
        Me.ProgressionLbl = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.ExpandBtn = New System.Windows.Forms.Button()
        Me.CraftPanel.SuspendLayout()
        Me.ExpanderContentPanel.SuspendLayout()
        Me.TaskPanel.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.HeaderMiddlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CraftPanel
        '
        Me.CraftPanel.AutoScroll = True
        Me.CraftPanel.AutoSize = True
        Me.CraftPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CraftPanel.BackColor = System.Drawing.Color.White
        Me.CraftPanel.Controls.Add(Me.MaterialsPanel)
        Me.CraftPanel.Controls.Add(Me.RecipesPanel)
        Me.CraftPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CraftPanel.Location = New System.Drawing.Point(0, 0)
        Me.CraftPanel.Name = "CraftPanel"
        Me.CraftPanel.Padding = New System.Windows.Forms.Padding(24, 8, 8, 8)
        Me.CraftPanel.Size = New System.Drawing.Size(32, 16)
        Me.CraftPanel.TabIndex = 0
        '
        'MaterialsPanel
        '
        Me.MaterialsPanel.AutoSize = True
        Me.MaterialsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialsPanel.Location = New System.Drawing.Point(24, 8)
        Me.MaterialsPanel.Name = "MaterialsPanel"
        Me.MaterialsPanel.Size = New System.Drawing.Size(0, 0)
        Me.MaterialsPanel.TabIndex = 1
        '
        'RecipesPanel
        '
        Me.RecipesPanel.AutoSize = True
        Me.RecipesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RecipesPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.RecipesPanel.Location = New System.Drawing.Point(24, 8)
        Me.RecipesPanel.Name = "RecipesPanel"
        Me.RecipesPanel.Size = New System.Drawing.Size(0, 0)
        Me.RecipesPanel.TabIndex = 0
        '
        'ExpanderContentPanel
        '
        Me.ExpanderContentPanel.AutoSize = True
        Me.ExpanderContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ExpanderContentPanel.Controls.Add(Me.CraftPanel)
        Me.ExpanderContentPanel.Controls.Add(Me.TaskPanel)
        Me.ExpanderContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExpanderContentPanel.Location = New System.Drawing.Point(0, 64)
        Me.ExpanderContentPanel.Name = "ExpanderContentPanel"
        Me.ExpanderContentPanel.Size = New System.Drawing.Size(32, 64)
        Me.ExpanderContentPanel.TabIndex = 3
        '
        'TaskPanel
        '
        Me.TaskPanel.BackgroundImage = Global.CraftingProgression.My.Resources.Resources.Gradient
        Me.TaskPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TaskPanel.Controls.Add(Me.AddNewBtn)
        Me.TaskPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TaskPanel.Location = New System.Drawing.Point(0, 16)
        Me.TaskPanel.Name = "TaskPanel"
        Me.TaskPanel.Padding = New System.Windows.Forms.Padding(32, 8, 32, 8)
        Me.TaskPanel.Size = New System.Drawing.Size(32, 48)
        Me.TaskPanel.TabIndex = 2
        '
        'AddNewBtn
        '
        Me.AddNewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddNewBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddNewBtn.Location = New System.Drawing.Point(32, 8)
        Me.AddNewBtn.Name = "AddNewBtn"
        Me.AddNewBtn.Size = New System.Drawing.Size(0, 32)
        Me.AddNewBtn.TabIndex = 0
        Me.AddNewBtn.Text = "Ajouter"
        Me.AddNewBtn.UseVisualStyleBackColor = True
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackgroundImage = Global.CraftingProgression.My.Resources.Resources.Gradient
        Me.HeaderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeaderPanel.Controls.Add(Me.HeaderMiddlePanel)
        Me.HeaderPanel.Controls.Add(Me.ProgressionLbl)
        Me.HeaderPanel.Controls.Add(Me.DeleteBtn)
        Me.HeaderPanel.Controls.Add(Me.ExpandBtn)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.MaximumSize = New System.Drawing.Size(0, 64)
        Me.HeaderPanel.MinimumSize = New System.Drawing.Size(0, 64)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Padding = New System.Windows.Forms.Padding(8, 8, 12, 8)
        Me.HeaderPanel.Size = New System.Drawing.Size(32, 64)
        Me.HeaderPanel.TabIndex = 1
        '
        'HeaderMiddlePanel
        '
        Me.HeaderMiddlePanel.BackColor = System.Drawing.Color.Transparent
        Me.HeaderMiddlePanel.Controls.Add(Me.Titlelbl)
        Me.HeaderMiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderMiddlePanel.Location = New System.Drawing.Point(56, 8)
        Me.HeaderMiddlePanel.Name = "HeaderMiddlePanel"
        Me.HeaderMiddlePanel.Padding = New System.Windows.Forms.Padding(24, 12, 16, 0)
        Me.HeaderMiddlePanel.Size = New System.Drawing.Size(0, 48)
        Me.HeaderMiddlePanel.TabIndex = 2
        '
        'Titlelbl
        '
        Me.Titlelbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Titlelbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Titlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Titlelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Titlelbl.Location = New System.Drawing.Point(24, 12)
        Me.Titlelbl.Margin = New System.Windows.Forms.Padding(0)
        Me.Titlelbl.Name = "Titlelbl"
        Me.Titlelbl.Size = New System.Drawing.Size(0, 24)
        Me.Titlelbl.TabIndex = 0
        Me.Titlelbl.Text = "Title"
        '
        'ProgressionLbl
        '
        Me.ProgressionLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressionLbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.ProgressionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressionLbl.ForeColor = System.Drawing.Color.White
        Me.ProgressionLbl.Location = New System.Drawing.Point(-148, 8)
        Me.ProgressionLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.ProgressionLbl.MaximumSize = New System.Drawing.Size(120, 48)
        Me.ProgressionLbl.MinimumSize = New System.Drawing.Size(120, 48)
        Me.ProgressionLbl.Name = "ProgressionLbl"
        Me.ProgressionLbl.Size = New System.Drawing.Size(120, 48)
        Me.ProgressionLbl.TabIndex = 0
        Me.ProgressionLbl.Text = "0%"
        Me.ProgressionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.Transparent
        Me.DeleteBtn.BackgroundImage = Global.CraftingProgression.My.Resources.Resources.Delete
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.DeleteBtn.FlatAppearance.BorderSize = 0
        Me.DeleteBtn.Location = New System.Drawing.Point(-28, 8)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.DeleteBtn.MaximumSize = New System.Drawing.Size(48, 48)
        Me.DeleteBtn.MinimumSize = New System.Drawing.Size(48, 48)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(48, 48)
        Me.DeleteBtn.TabIndex = 3
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'ExpandBtn
        '
        Me.ExpandBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExpandBtn.BackgroundImage = Global.CraftingProgression.My.Resources.Resources.Retract
        Me.ExpandBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExpandBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExpandBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExpandBtn.FlatAppearance.BorderSize = 0
        Me.ExpandBtn.Location = New System.Drawing.Point(8, 8)
        Me.ExpandBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.ExpandBtn.MaximumSize = New System.Drawing.Size(48, 48)
        Me.ExpandBtn.MinimumSize = New System.Drawing.Size(48, 48)
        Me.ExpandBtn.Name = "ExpandBtn"
        Me.ExpandBtn.Size = New System.Drawing.Size(48, 48)
        Me.ExpandBtn.TabIndex = 0
        Me.ExpandBtn.UseVisualStyleBackColor = False
        '
        'DisplayControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.ExpanderContentPanel)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "DisplayControl"
        Me.Size = New System.Drawing.Size(32, 128)
        Me.CraftPanel.ResumeLayout(False)
        Me.CraftPanel.PerformLayout()
        Me.ExpanderContentPanel.ResumeLayout(False)
        Me.ExpanderContentPanel.PerformLayout()
        Me.TaskPanel.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderMiddlePanel.ResumeLayout(False)
        Me.HeaderMiddlePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents HeaderMiddlePanel As Panel
    Private WithEvents DeleteBtn As Button
    Private WithEvents TaskPanel As Panel
    Private WithEvents AddNewBtn As Button
    Private WithEvents HeaderPanel As Panel
    Private WithEvents ExpandBtn As Button
    Private WithEvents ProgressionLbl As Label
    Friend WithEvents ExpanderContentPanel As Panel
    Friend WithEvents Titlelbl As TextBox
    Friend WithEvents CraftPanel As Panel
    Friend WithEvents MaterialsPanel As Panel
    Friend WithEvents RecipesPanel As Panel
End Class
