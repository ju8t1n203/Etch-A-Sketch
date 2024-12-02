<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchASketch
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
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.ButtonBox = New System.Windows.Forms.GroupBox()
        Me.WaveFormButton = New System.Windows.Forms.Button()
        Me.ColorSelectButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(776, 346)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        '
        'ButtonBox
        '
        Me.ButtonBox.Controls.Add(Me.WaveFormButton)
        Me.ButtonBox.Controls.Add(Me.ColorSelectButton)
        Me.ButtonBox.Controls.Add(Me.ClearButton)
        Me.ButtonBox.Controls.Add(Me.ExitButton)
        Me.ButtonBox.Location = New System.Drawing.Point(390, 364)
        Me.ButtonBox.Name = "ButtonBox"
        Me.ButtonBox.Size = New System.Drawing.Size(408, 84)
        Me.ButtonBox.TabIndex = 1
        Me.ButtonBox.TabStop = False
        '
        'WaveFormButton
        '
        Me.WaveFormButton.Location = New System.Drawing.Point(17, 19)
        Me.WaveFormButton.Name = "WaveFormButton"
        Me.WaveFormButton.Size = New System.Drawing.Size(91, 55)
        Me.WaveFormButton.TabIndex = 0
        Me.WaveFormButton.Text = "WaveForm"
        Me.WaveFormButton.UseVisualStyleBackColor = True
        '
        'ColorSelectButton
        '
        Me.ColorSelectButton.Location = New System.Drawing.Point(114, 19)
        Me.ColorSelectButton.Name = "ColorSelectButton"
        Me.ColorSelectButton.Size = New System.Drawing.Size(91, 55)
        Me.ColorSelectButton.TabIndex = 1
        Me.ColorSelectButton.Text = "Color &Select"
        Me.ColorSelectButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(211, 19)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(91, 55)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(308, 19)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(91, 55)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'EtchASketch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonBox)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Name = "EtchASketch"
        Me.Text = "Form1"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents ButtonBox As GroupBox
    Friend WithEvents WaveFormButton As Button
    Friend WithEvents ColorSelectButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
