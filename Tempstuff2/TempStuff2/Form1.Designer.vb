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
        Me.lblMonster = New System.Windows.Forms.Label()
        Me.btnCall = New System.Windows.Forms.Button()
        Me.txtCall = New System.Windows.Forms.TextBox()
        Me.lblStr = New System.Windows.Forms.Label()
        Me.txtStr = New System.Windows.Forms.TextBox()
        Me.txtAgl = New System.Windows.Forms.TextBox()
        Me.txtArm = New System.Windows.Forms.TextBox()
        Me.txtSpd = New System.Windows.Forms.TextBox()
        Me.txtVit = New System.Windows.Forms.TextBox()
        Me.lblAgl = New System.Windows.Forms.Label()
        Me.lblArm = New System.Windows.Forms.Label()
        Me.lblVit = New System.Windows.Forms.Label()
        Me.lblSpd = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMonster
        '
        Me.lblMonster.AutoSize = True
        Me.lblMonster.Location = New System.Drawing.Point(11, 35)
        Me.lblMonster.Name = "lblMonster"
        Me.lblMonster.Size = New System.Drawing.Size(45, 13)
        Me.lblMonster.TabIndex = 5
        Me.lblMonster.Text = "Monster"
        '
        'btnCall
        '
        Me.btnCall.Location = New System.Drawing.Point(119, 12)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Size = New System.Drawing.Size(75, 23)
        Me.btnCall.TabIndex = 4
        Me.btnCall.Text = "Call"
        Me.btnCall.UseVisualStyleBackColor = True
        '
        'txtCall
        '
        Me.txtCall.Location = New System.Drawing.Point(12, 12)
        Me.txtCall.Name = "txtCall"
        Me.txtCall.Size = New System.Drawing.Size(100, 20)
        Me.txtCall.TabIndex = 3
        '
        'lblStr
        '
        Me.lblStr.AutoSize = True
        Me.lblStr.Location = New System.Drawing.Point(9, 83)
        Me.lblStr.Name = "lblStr"
        Me.lblStr.Size = New System.Drawing.Size(20, 13)
        Me.lblStr.TabIndex = 6
        Me.lblStr.Text = "Str"
        '
        'txtStr
        '
        Me.txtStr.Enabled = False
        Me.txtStr.Location = New System.Drawing.Point(12, 99)
        Me.txtStr.Name = "txtStr"
        Me.txtStr.Size = New System.Drawing.Size(100, 20)
        Me.txtStr.TabIndex = 8
        '
        'txtAgl
        '
        Me.txtAgl.Enabled = False
        Me.txtAgl.Location = New System.Drawing.Point(119, 99)
        Me.txtAgl.Name = "txtAgl"
        Me.txtAgl.Size = New System.Drawing.Size(100, 20)
        Me.txtAgl.TabIndex = 9
        '
        'txtArm
        '
        Me.txtArm.Enabled = False
        Me.txtArm.Location = New System.Drawing.Point(11, 138)
        Me.txtArm.Name = "txtArm"
        Me.txtArm.Size = New System.Drawing.Size(100, 20)
        Me.txtArm.TabIndex = 10
        '
        'txtSpd
        '
        Me.txtSpd.Enabled = False
        Me.txtSpd.Location = New System.Drawing.Point(119, 138)
        Me.txtSpd.Name = "txtSpd"
        Me.txtSpd.Size = New System.Drawing.Size(100, 20)
        Me.txtSpd.TabIndex = 11
        '
        'txtVit
        '
        Me.txtVit.Enabled = False
        Me.txtVit.Location = New System.Drawing.Point(12, 177)
        Me.txtVit.Name = "txtVit"
        Me.txtVit.Size = New System.Drawing.Size(100, 20)
        Me.txtVit.TabIndex = 12
        '
        'lblAgl
        '
        Me.lblAgl.AutoSize = True
        Me.lblAgl.Location = New System.Drawing.Point(115, 83)
        Me.lblAgl.Name = "lblAgl"
        Me.lblAgl.Size = New System.Drawing.Size(22, 13)
        Me.lblAgl.TabIndex = 13
        Me.lblAgl.Text = "Agl"
        '
        'lblArm
        '
        Me.lblArm.AutoSize = True
        Me.lblArm.Location = New System.Drawing.Point(9, 122)
        Me.lblArm.Name = "lblArm"
        Me.lblArm.Size = New System.Drawing.Size(25, 13)
        Me.lblArm.TabIndex = 14
        Me.lblArm.Text = "Arm"
        '
        'lblVit
        '
        Me.lblVit.AutoSize = True
        Me.lblVit.Location = New System.Drawing.Point(9, 161)
        Me.lblVit.Name = "lblVit"
        Me.lblVit.Size = New System.Drawing.Size(19, 13)
        Me.lblVit.TabIndex = 15
        Me.lblVit.Text = "Vit"
        '
        'lblSpd
        '
        Me.lblSpd.AutoSize = True
        Me.lblSpd.Location = New System.Drawing.Point(118, 122)
        Me.lblSpd.Name = "lblSpd"
        Me.lblSpd.Size = New System.Drawing.Size(26, 13)
        Me.lblSpd.TabIndex = 16
        Me.lblSpd.Text = "Spd"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblSpd)
        Me.Controls.Add(Me.lblVit)
        Me.Controls.Add(Me.lblArm)
        Me.Controls.Add(Me.lblAgl)
        Me.Controls.Add(Me.txtVit)
        Me.Controls.Add(Me.txtSpd)
        Me.Controls.Add(Me.txtArm)
        Me.Controls.Add(Me.txtAgl)
        Me.Controls.Add(Me.txtStr)
        Me.Controls.Add(Me.lblStr)
        Me.Controls.Add(Me.lblMonster)
        Me.Controls.Add(Me.btnCall)
        Me.Controls.Add(Me.txtCall)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMonster As System.Windows.Forms.Label
    Friend WithEvents btnCall As System.Windows.Forms.Button
    Friend WithEvents txtCall As System.Windows.Forms.TextBox
    Friend WithEvents lblStr As System.Windows.Forms.Label
    Friend WithEvents txtStr As System.Windows.Forms.TextBox
    Friend WithEvents txtAgl As System.Windows.Forms.TextBox
    Friend WithEvents txtArm As System.Windows.Forms.TextBox
    Friend WithEvents txtSpd As System.Windows.Forms.TextBox
    Friend WithEvents txtVit As System.Windows.Forms.TextBox
    Friend WithEvents lblAgl As System.Windows.Forms.Label
    Friend WithEvents lblArm As System.Windows.Forms.Label
    Friend WithEvents lblVit As System.Windows.Forms.Label
    Friend WithEvents lblSpd As System.Windows.Forms.Label

End Class
