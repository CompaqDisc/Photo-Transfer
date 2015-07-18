<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhotoTransferPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhotoTransferPanel))
        Me.MainProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.BeginButton = New System.Windows.Forms.Button()
        Me.CopyPhoto = New System.Windows.Forms.PictureBox()
        CType(Me.CopyPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainProgressBar
        '
        Me.MainProgressBar.Location = New System.Drawing.Point(12, 335)
        Me.MainProgressBar.Name = "MainProgressBar"
        Me.MainProgressBar.Size = New System.Drawing.Size(568, 23)
        Me.MainProgressBar.TabIndex = 0
        Me.MainProgressBar.UseWaitCursor = True
        '
        'ProgressLabel
        '
        Me.ProgressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressLabel.Location = New System.Drawing.Point(12, 313)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(568, 19)
        Me.ProgressLabel.TabIndex = 1
        Me.ProgressLabel.Text = "Waiting to begin..."
        '
        'BeginButton
        '
        Me.BeginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginButton.Location = New System.Drawing.Point(12, 279)
        Me.BeginButton.Name = "BeginButton"
        Me.BeginButton.Size = New System.Drawing.Size(568, 31)
        Me.BeginButton.TabIndex = 2
        Me.BeginButton.Text = "Begin Photo Transfer"
        Me.BeginButton.UseVisualStyleBackColor = True
        '
        'CopyPhoto
        '
        Me.CopyPhoto.BackColor = System.Drawing.Color.White
        Me.CopyPhoto.BackgroundImage = CType(resources.GetObject("CopyPhoto.BackgroundImage"), System.Drawing.Image)
        Me.CopyPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CopyPhoto.Location = New System.Drawing.Point(12, 12)
        Me.CopyPhoto.Name = "CopyPhoto"
        Me.CopyPhoto.Size = New System.Drawing.Size(568, 261)
        Me.CopyPhoto.TabIndex = 3
        Me.CopyPhoto.TabStop = False
        '
        'PhotoTransferPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 370)
        Me.Controls.Add(Me.CopyPhoto)
        Me.Controls.Add(Me.BeginButton)
        Me.Controls.Add(Me.ProgressLabel)
        Me.Controls.Add(Me.MainProgressBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PhotoTransferPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Photo Transfer"
        CType(Me.CopyPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressLabel As System.Windows.Forms.Label
    Friend WithEvents BeginButton As System.Windows.Forms.Button
    Friend WithEvents CopyPhoto As System.Windows.Forms.PictureBox

End Class
