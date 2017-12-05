<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.GroupChckb = New System.Windows.Forms.RadioButton()
        Me.MaterialChckb = New System.Windows.Forms.RadioButton()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GroupChckb
        '
        Me.GroupChckb.AutoSize = True
        Me.GroupChckb.Checked = True
        Me.GroupChckb.Location = New System.Drawing.Point(12, 12)
        Me.GroupChckb.Name = "GroupChckb"
        Me.GroupChckb.Size = New System.Drawing.Size(104, 17)
        Me.GroupChckb.TabIndex = 0
        Me.GroupChckb.TabStop = True
        Me.GroupChckb.Text = "Groupe de crafts"
        Me.GroupChckb.UseVisualStyleBackColor = True
        '
        'MaterialChckb
        '
        Me.MaterialChckb.AutoSize = True
        Me.MaterialChckb.Location = New System.Drawing.Point(12, 35)
        Me.MaterialChckb.Name = "MaterialChckb"
        Me.MaterialChckb.Size = New System.Drawing.Size(66, 17)
        Me.MaterialChckb.TabIndex = 1
        Me.MaterialChckb.Text = "Matériau"
        Me.MaterialChckb.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.Location = New System.Drawing.Point(99, 81)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(75, 23)
        Me.OkBtn.TabIndex = 2
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(180, 81)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.Text = "Annuler"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 116)
        Me.ControlBox = False
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.MaterialChckb)
        Me.Controls.Add(Me.GroupChckb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter ..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupChckb As RadioButton
    Friend WithEvents MaterialChckb As RadioButton
    Friend WithEvents OkBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
