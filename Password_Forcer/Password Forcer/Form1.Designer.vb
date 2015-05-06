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
        Me.components = New System.ComponentModel.Container()
        Me.lblStarttimer = New System.Windows.Forms.Label()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.timStart = New System.Windows.Forms.Timer(Me.components)
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.timRunning = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblStarttimer
        '
        Me.lblStarttimer.AutoSize = True
        Me.lblStarttimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarttimer.Location = New System.Drawing.Point(123, 105)
        Me.lblStarttimer.Name = "lblStarttimer"
        Me.lblStarttimer.Size = New System.Drawing.Size(35, 37)
        Me.lblStarttimer.TabIndex = 5
        Me.lblStarttimer.Text = "5"
        '
        'btnStartStop
        '
        Me.btnStartStop.Location = New System.Drawing.Point(13, 227)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(259, 23)
        Me.btnStartStop.TabIndex = 6
        Me.btnStartStop.Text = "Start Hacking"
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'timStart
        '
        Me.timStart.Interval = 1000
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(13, 13)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(219, 26)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Press the start button, select the text box you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "want to hack, and hack away!"
        '
        'timRunning
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.lblStarttimer)
        Me.Name = "Form1"
        Me.Text = "Password Hacker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStarttimer As System.Windows.Forms.Label
    Friend WithEvents btnStartStop As System.Windows.Forms.Button
    Friend WithEvents timStart As System.Windows.Forms.Timer
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents timRunning As System.Windows.Forms.Timer

End Class
