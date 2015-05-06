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
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(13, 13)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(291, 13)
        Me.lblAnswer.TabIndex = 0
        Me.lblAnswer.Text = "Type in a number to find a random number between 0 and it!"
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(16, 30)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(319, 20)
        Me.txtQuestion.TabIndex = 1
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(181, 56)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(154, 23)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(16, 56)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(159, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 93)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.lblAnswer)
        Me.Name = "Form1"
        Me.Text = "Random Number Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
