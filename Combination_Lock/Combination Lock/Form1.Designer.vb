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
        Me.nud2 = New System.Windows.Forms.NumericUpDown()
        Me.nud1 = New System.Windows.Forms.NumericUpDown()
        Me.nud3 = New System.Windows.Forms.NumericUpDown()
        Me.nud4 = New System.Windows.Forms.NumericUpDown()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.tim1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTries = New System.Windows.Forms.Label()
        CType(Me.nud2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nud2
        '
        Me.nud2.Location = New System.Drawing.Point(65, 256)
        Me.nud2.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nud2.Name = "nud2"
        Me.nud2.Size = New System.Drawing.Size(47, 20)
        Me.nud2.TabIndex = 2
        '
        'nud1
        '
        Me.nud1.Location = New System.Drawing.Point(12, 256)
        Me.nud1.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nud1.Name = "nud1"
        Me.nud1.Size = New System.Drawing.Size(47, 20)
        Me.nud1.TabIndex = 5
        '
        'nud3
        '
        Me.nud3.Location = New System.Drawing.Point(118, 256)
        Me.nud3.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nud3.Name = "nud3"
        Me.nud3.Size = New System.Drawing.Size(47, 20)
        Me.nud3.TabIndex = 6
        '
        'nud4
        '
        Me.nud4.Location = New System.Drawing.Point(171, 256)
        Me.nud4.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nud4.Name = "nud4"
        Me.nud4.Size = New System.Drawing.Size(47, 20)
        Me.nud4.TabIndex = 7
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(12, 223)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 8
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(143, 223)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'pic1
        '
        Me.pic1.Image = Global.Combination_Lock.My.Resources.Resources.depositphotos_1696563_Closed_safe
        Me.pic1.Location = New System.Drawing.Point(12, 12)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(206, 205)
        Me.pic1.TabIndex = 4
        Me.pic1.TabStop = False
        '
        'tim1
        '
        Me.tim1.Interval = 1700
        '
        'lblTries
        '
        Me.lblTries.AutoSize = True
        Me.lblTries.Location = New System.Drawing.Point(108, 228)
        Me.lblTries.Name = "lblTries"
        Me.lblTries.Size = New System.Drawing.Size(0, 13)
        Me.lblTries.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 290)
        Me.Controls.Add(Me.lblTries)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.nud4)
        Me.Controls.Add(Me.nud3)
        Me.Controls.Add(Me.nud1)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.nud2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nud2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nud2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents nud1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tim1 As System.Windows.Forms.Timer
    Friend WithEvents lblTries As System.Windows.Forms.Label

End Class
