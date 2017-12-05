<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MaterialControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.HeaderMiddlePanel = New System.Windows.Forms.Panel()
        Me.Titlelbl = New System.Windows.Forms.TextBox()
        Me.ProgressTextLbl = New System.Windows.Forms.Label()
        Me.OwnedUD = New System.Windows.Forms.NumericUpDown()
        Me.SeparatorLbl = New System.Windows.Forms.Label()
        Me.NeededUD = New System.Windows.Forms.NumericUpDown()
        Me.ProgressionLbl = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.HeaderPanel.SuspendLayout()
        Me.HeaderMiddlePanel.SuspendLayout()
        CType(Me.OwnedUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeededUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.AutoSize = True
        Me.HeaderPanel.BackgroundImage = Global.CraftingProgression.My.Resources.Resources.Gradient
        Me.HeaderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeaderPanel.Controls.Add(Me.HeaderMiddlePanel)
        Me.HeaderPanel.Controls.Add(Me.ProgressionLbl)
        Me.HeaderPanel.Controls.Add(Me.DeleteBtn)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.MaximumSize = New System.Drawing.Size(0, 64)
        Me.HeaderPanel.MinimumSize = New System.Drawing.Size(0, 64)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Padding = New System.Windows.Forms.Padding(8, 8, 12, 8)
        Me.HeaderPanel.Size = New System.Drawing.Size(1106, 64)
        Me.HeaderPanel.TabIndex = 2
        '
        'HeaderMiddlePanel
        '
        Me.HeaderMiddlePanel.BackColor = System.Drawing.Color.Transparent
        Me.HeaderMiddlePanel.Controls.Add(Me.Titlelbl)
        Me.HeaderMiddlePanel.Controls.Add(Me.ProgressTextLbl)
        Me.HeaderMiddlePanel.Controls.Add(Me.OwnedUD)
        Me.HeaderMiddlePanel.Controls.Add(Me.SeparatorLbl)
        Me.HeaderMiddlePanel.Controls.Add(Me.NeededUD)
        Me.HeaderMiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderMiddlePanel.Location = New System.Drawing.Point(8, 8)
        Me.HeaderMiddlePanel.Name = "HeaderMiddlePanel"
        Me.HeaderMiddlePanel.Padding = New System.Windows.Forms.Padding(24, 12, 16, 0)
        Me.HeaderMiddlePanel.Size = New System.Drawing.Size(918, 48)
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
        Me.Titlelbl.Size = New System.Drawing.Size(505, 24)
        Me.Titlelbl.TabIndex = 0
        Me.Titlelbl.Text = "Title"
        '
        'ProgressTextLbl
        '
        Me.ProgressTextLbl.AutoSize = True
        Me.ProgressTextLbl.BackColor = System.Drawing.Color.Transparent
        Me.ProgressTextLbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.ProgressTextLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.ProgressTextLbl.ForeColor = System.Drawing.Color.Black
        Me.ProgressTextLbl.Location = New System.Drawing.Point(529, 12)
        Me.ProgressTextLbl.Name = "ProgressTextLbl"
        Me.ProgressTextLbl.Size = New System.Drawing.Size(151, 25)
        Me.ProgressTextLbl.TabIndex = 4
        Me.ProgressTextLbl.Text = "   Progression "
        '
        'OwnedUD
        '
        Me.OwnedUD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OwnedUD.Dock = System.Windows.Forms.DockStyle.Right
        Me.OwnedUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.OwnedUD.Location = New System.Drawing.Point(680, 12)
        Me.OwnedUD.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.OwnedUD.Name = "OwnedUD"
        Me.OwnedUD.Size = New System.Drawing.Size(96, 27)
        Me.OwnedUD.TabIndex = 2
        Me.OwnedUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SeparatorLbl
        '
        Me.SeparatorLbl.AutoSize = True
        Me.SeparatorLbl.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorLbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.SeparatorLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.SeparatorLbl.ForeColor = System.Drawing.Color.Black
        Me.SeparatorLbl.Location = New System.Drawing.Point(776, 12)
        Me.SeparatorLbl.Name = "SeparatorLbl"
        Me.SeparatorLbl.Size = New System.Drawing.Size(30, 25)
        Me.SeparatorLbl.TabIndex = 3
        Me.SeparatorLbl.Text = " / "
        '
        'NeededUD
        '
        Me.NeededUD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NeededUD.Dock = System.Windows.Forms.DockStyle.Right
        Me.NeededUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.NeededUD.Location = New System.Drawing.Point(806, 12)
        Me.NeededUD.Maximum = New Decimal(New Integer() {1661992960, 1808227885, 5, 0})
        Me.NeededUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NeededUD.Name = "NeededUD"
        Me.NeededUD.Size = New System.Drawing.Size(96, 27)
        Me.NeededUD.TabIndex = 1
        Me.NeededUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NeededUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ProgressionLbl
        '
        Me.ProgressionLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressionLbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.ProgressionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressionLbl.ForeColor = System.Drawing.Color.White
        Me.ProgressionLbl.Location = New System.Drawing.Point(926, 8)
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
        Me.DeleteBtn.Location = New System.Drawing.Point(1046, 8)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.DeleteBtn.MaximumSize = New System.Drawing.Size(48, 48)
        Me.DeleteBtn.MinimumSize = New System.Drawing.Size(48, 48)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(48, 48)
        Me.DeleteBtn.TabIndex = 3
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'MaterialControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.HeaderPanel)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.MaximumSize = New System.Drawing.Size(0, 64)
        Me.MinimumSize = New System.Drawing.Size(0, 64)
        Me.Name = "MaterialControl"
        Me.Size = New System.Drawing.Size(1106, 64)
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderMiddlePanel.ResumeLayout(False)
        Me.HeaderMiddlePanel.PerformLayout()
        CType(Me.OwnedUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeededUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents HeaderPanel As Panel
    Private WithEvents HeaderMiddlePanel As Panel
    Friend WithEvents Titlelbl As TextBox
    Private WithEvents ProgressionLbl As Label
    Private WithEvents DeleteBtn As Button
    Friend WithEvents ProgressTextLbl As Label
    Friend WithEvents SeparatorLbl As Label
    Friend WithEvents NeededUD As NumericUpDown
    Friend WithEvents OwnedUD As NumericUpDown
End Class
