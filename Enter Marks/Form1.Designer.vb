<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Score = New System.Windows.Forms.Label()
        Me.BtnResults = New System.Windows.Forms.Button()
        Me.txtMarks = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.Location = New System.Drawing.Point(132, 150)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(95, 20)
        Me.Score.TabIndex = 0
        Me.Score.Text = "Enter Marks"
        '
        'BtnResults
        '
        Me.BtnResults.Location = New System.Drawing.Point(340, 247)
        Me.BtnResults.Name = "BtnResults"
        Me.BtnResults.Size = New System.Drawing.Size(100, 39)
        Me.BtnResults.TabIndex = 1
        Me.BtnResults.Text = "RESULTS"
        Me.BtnResults.UseVisualStyleBackColor = True
        '
        'txtMarks
        '
        Me.txtMarks.Location = New System.Drawing.Point(340, 144)
        Me.txtMarks.Name = "txtMarks"
        Me.txtMarks.Size = New System.Drawing.Size(100, 26)
        Me.txtMarks.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMarks)
        Me.Controls.Add(Me.BtnResults)
        Me.Controls.Add(Me.Score)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Score As Label
    Friend WithEvents BtnResults As Button
    Friend WithEvents txtMarks As TextBox
End Class
