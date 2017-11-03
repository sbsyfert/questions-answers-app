<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class answersForm
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
        Me.dgvAnswers = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoadAnswersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvAnswers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAnswers
        '
        Me.dgvAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnswers.Location = New System.Drawing.Point(12, 26)
        Me.dgvAnswers.Name = "dgvAnswers"
        Me.dgvAnswers.Size = New System.Drawing.Size(593, 339)
        Me.dgvAnswers.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadAnswersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(617, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoadAnswersToolStripMenuItem
        '
        Me.LoadAnswersToolStripMenuItem.Name = "LoadAnswersToolStripMenuItem"
        Me.LoadAnswersToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.LoadAnswersToolStripMenuItem.Text = "Load Answers"
        '
        'answersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 377)
        Me.Controls.Add(Me.dgvAnswers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "answersForm"
        Me.Text = "answersForm"
        CType(Me.dgvAnswers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAnswers As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoadAnswersToolStripMenuItem As ToolStripMenuItem
End Class
