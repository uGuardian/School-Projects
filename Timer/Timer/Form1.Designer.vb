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
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblMinute = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.btnStopwatch = New System.Windows.Forms.Button()
        Me.timStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.btnCountdown = New System.Windows.Forms.Button()
        Me.btnResetQuit = New System.Windows.Forms.Button()
        Me.nudHour = New System.Windows.Forms.NumericUpDown()
        Me.nudMinute = New System.Windows.Forms.NumericUpDown()
        Me.nudSecond = New System.Windows.Forms.NumericUpDown()
        Me.timCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblHoursDef = New System.Windows.Forms.Label()
        Me.lblMinutesDef = New System.Windows.Forms.Label()
        Me.lblSecondsDef = New System.Windows.Forms.Label()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSecond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.Location = New System.Drawing.Point(26, 9)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(53, 37)
        Me.lblHour.TabIndex = 0
        Me.lblHour.Text = "00"
        '
        'lblMinute
        '
        Me.lblMinute.AutoSize = True
        Me.lblMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinute.Location = New System.Drawing.Point(114, 9)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(53, 37)
        Me.lblMinute.TabIndex = 1
        Me.lblMinute.Text = "00"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecond.Location = New System.Drawing.Point(198, 9)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(53, 37)
        Me.lblSecond.TabIndex = 2
        Me.lblSecond.Text = "00"
        '
        'btnStopwatch
        '
        Me.btnStopwatch.Location = New System.Drawing.Point(12, 149)
        Me.btnStopwatch.Name = "btnStopwatch"
        Me.btnStopwatch.Size = New System.Drawing.Size(75, 23)
        Me.btnStopwatch.TabIndex = 3
        Me.btnStopwatch.Text = "Stopwatch"
        Me.btnStopwatch.UseVisualStyleBackColor = True
        '
        'timStopwatch
        '
        Me.timStopwatch.Interval = 1000
        '
        'btnCountdown
        '
        Me.btnCountdown.Location = New System.Drawing.Point(196, 149)
        Me.btnCountdown.Name = "btnCountdown"
        Me.btnCountdown.Size = New System.Drawing.Size(75, 23)
        Me.btnCountdown.TabIndex = 4
        Me.btnCountdown.Text = "Countdown"
        Me.btnCountdown.UseVisualStyleBackColor = True
        '
        'btnResetQuit
        '
        Me.btnResetQuit.Location = New System.Drawing.Point(104, 149)
        Me.btnResetQuit.Name = "btnResetQuit"
        Me.btnResetQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnResetQuit.TabIndex = 5
        Me.btnResetQuit.Text = "Quit"
        Me.btnResetQuit.UseVisualStyleBackColor = True
        '
        'nudHour
        '
        Me.nudHour.Location = New System.Drawing.Point(33, 84)
        Me.nudHour.Maximum = New Decimal(New Integer() {11, 0, 0, 0})
        Me.nudHour.Name = "nudHour"
        Me.nudHour.Size = New System.Drawing.Size(46, 20)
        Me.nudHour.TabIndex = 6
        '
        'nudMinute
        '
        Me.nudMinute.Location = New System.Drawing.Point(121, 84)
        Me.nudMinute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMinute.Name = "nudMinute"
        Me.nudMinute.Size = New System.Drawing.Size(46, 20)
        Me.nudMinute.TabIndex = 7
        '
        'nudSecond
        '
        Me.nudSecond.Location = New System.Drawing.Point(205, 84)
        Me.nudSecond.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSecond.Name = "nudSecond"
        Me.nudSecond.Size = New System.Drawing.Size(46, 20)
        Me.nudSecond.TabIndex = 8
        '
        'timCountdown
        '
        Me.timCountdown.Interval = 1000
        '
        'lblHoursDef
        '
        Me.lblHoursDef.AutoSize = True
        Me.lblHoursDef.Location = New System.Drawing.Point(30, 68)
        Me.lblHoursDef.Name = "lblHoursDef"
        Me.lblHoursDef.Size = New System.Drawing.Size(35, 13)
        Me.lblHoursDef.TabIndex = 9
        Me.lblHoursDef.Text = "Hours"
        '
        'lblMinutesDef
        '
        Me.lblMinutesDef.AutoSize = True
        Me.lblMinutesDef.Location = New System.Drawing.Point(118, 68)
        Me.lblMinutesDef.Name = "lblMinutesDef"
        Me.lblMinutesDef.Size = New System.Drawing.Size(44, 13)
        Me.lblMinutesDef.TabIndex = 10
        Me.lblMinutesDef.Text = "Minutes"
        '
        'lblSecondsDef
        '
        Me.lblSecondsDef.AutoSize = True
        Me.lblSecondsDef.Location = New System.Drawing.Point(202, 68)
        Me.lblSecondsDef.Name = "lblSecondsDef"
        Me.lblSecondsDef.Size = New System.Drawing.Size(49, 13)
        Me.lblSecondsDef.TabIndex = 11
        Me.lblSecondsDef.Text = "Seconds"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 184)
        Me.Controls.Add(Me.lblSecondsDef)
        Me.Controls.Add(Me.lblMinutesDef)
        Me.Controls.Add(Me.lblHoursDef)
        Me.Controls.Add(Me.nudSecond)
        Me.Controls.Add(Me.nudMinute)
        Me.Controls.Add(Me.nudHour)
        Me.Controls.Add(Me.btnResetQuit)
        Me.Controls.Add(Me.btnCountdown)
        Me.Controls.Add(Me.btnStopwatch)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblMinute)
        Me.Controls.Add(Me.lblHour)
        Me.Name = "Form1"
        Me.Text = "Timer"
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSecond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHour As System.Windows.Forms.Label
    Friend WithEvents lblMinute As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents btnStopwatch As System.Windows.Forms.Button
    Friend WithEvents timStopwatch As System.Windows.Forms.Timer
    Friend WithEvents btnCountdown As System.Windows.Forms.Button
    Friend WithEvents btnResetQuit As System.Windows.Forms.Button
    Friend WithEvents nudHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMinute As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSecond As System.Windows.Forms.NumericUpDown
    Friend WithEvents timCountdown As System.Windows.Forms.Timer
    Friend WithEvents lblHoursDef As System.Windows.Forms.Label
    Friend WithEvents lblMinutesDef As System.Windows.Forms.Label
    Friend WithEvents lblSecondsDef As System.Windows.Forms.Label

End Class
