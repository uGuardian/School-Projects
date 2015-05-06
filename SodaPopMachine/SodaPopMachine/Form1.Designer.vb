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
        Me.txtSodaprice = New System.Windows.Forms.TextBox()
        Me.radCoke = New System.Windows.Forms.RadioButton()
        Me.radPepper = New System.Windows.Forms.RadioButton()
        Me.radSprite = New System.Windows.Forms.RadioButton()
        Me.radMountaindew = New System.Windows.Forms.RadioButton()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSodaprice
        '
        Me.txtSodaprice.Location = New System.Drawing.Point(12, 12)
        Me.txtSodaprice.Name = "txtSodaprice"
        Me.txtSodaprice.ReadOnly = True
        Me.txtSodaprice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSodaprice.Size = New System.Drawing.Size(190, 20)
        Me.txtSodaprice.TabIndex = 0
        '
        'radCoke
        '
        Me.radCoke.AutoSize = True
        Me.radCoke.Location = New System.Drawing.Point(12, 38)
        Me.radCoke.Name = "radCoke"
        Me.radCoke.Size = New System.Drawing.Size(71, 17)
        Me.radCoke.TabIndex = 1
        Me.radCoke.TabStop = True
        Me.radCoke.Text = "CocaCola"
        Me.radCoke.UseVisualStyleBackColor = True
        '
        'radPepper
        '
        Me.radPepper.AutoSize = True
        Me.radPepper.Location = New System.Drawing.Point(108, 38)
        Me.radPepper.Name = "radPepper"
        Me.radPepper.Size = New System.Drawing.Size(76, 17)
        Me.radPepper.TabIndex = 2
        Me.radPepper.TabStop = True
        Me.radPepper.Text = "Dr. Pepper"
        Me.radPepper.UseVisualStyleBackColor = True
        '
        'radSprite
        '
        Me.radSprite.AutoSize = True
        Me.radSprite.Location = New System.Drawing.Point(12, 61)
        Me.radSprite.Name = "radSprite"
        Me.radSprite.Size = New System.Drawing.Size(52, 17)
        Me.radSprite.TabIndex = 3
        Me.radSprite.TabStop = True
        Me.radSprite.Text = "Sprite"
        Me.radSprite.UseVisualStyleBackColor = True
        '
        'radMountaindew
        '
        Me.radMountaindew.AutoSize = True
        Me.radMountaindew.Location = New System.Drawing.Point(108, 61)
        Me.radMountaindew.Name = "radMountaindew"
        Me.radMountaindew.Size = New System.Drawing.Size(94, 17)
        Me.radMountaindew.TabIndex = 4
        Me.radMountaindew.TabStop = True
        Me.radMountaindew.Text = "Mountain Dew"
        Me.radMountaindew.UseVisualStyleBackColor = True
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(12, 84)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 23)
        Me.btnPurchase.TabIndex = 5
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(93, 84)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(174, 84)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 122)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.radMountaindew)
        Me.Controls.Add(Me.radSprite)
        Me.Controls.Add(Me.radPepper)
        Me.Controls.Add(Me.radCoke)
        Me.Controls.Add(Me.txtSodaprice)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSodaprice As System.Windows.Forms.TextBox
    Friend WithEvents radCoke As System.Windows.Forms.RadioButton
    Friend WithEvents radPepper As System.Windows.Forms.RadioButton
    Friend WithEvents radSprite As System.Windows.Forms.RadioButton
    Friend WithEvents radMountaindew As System.Windows.Forms.RadioButton
    Friend WithEvents btnPurchase As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
