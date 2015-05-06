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
        Me.txtCall = New System.Windows.Forms.TextBox()
        Me.btnCall = New System.Windows.Forms.Button()
        Me.lblMonster = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCall
        '
        Me.txtCall.Location = New System.Drawing.Point(13, 13)
        Me.txtCall.Name = "txtCall"
        Me.txtCall.Size = New System.Drawing.Size(100, 20)
        Me.txtCall.TabIndex = 0
        '
        'btnCall
        '
        Me.btnCall.Location = New System.Drawing.Point(120, 13)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Size = New System.Drawing.Size(75, 23)
        Me.btnCall.TabIndex = 1
        Me.btnCall.Text = "Call"
        Me.btnCall.UseVisualStyleBackColor = True
        '
        'lblMonster
        '
        Me.lblMonster.AutoSize = True
        Me.lblMonster.Location = New System.Drawing.Point(12, 36)
        Me.lblMonster.Name = "lblMonster"
        Me.lblMonster.Size = New System.Drawing.Size(45, 13)
        Me.lblMonster.TabIndex = 2
        Me.lblMonster.Text = "Monster"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblMonster)
        Me.Controls.Add(Me.btnCall)
        Me.Controls.Add(Me.txtCall)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCall As System.Windows.Forms.TextBox
    Friend WithEvents btnCall As System.Windows.Forms.Button
    Friend WithEvents lblMonster As System.Windows.Forms.Label
End Class
