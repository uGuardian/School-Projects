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
        Me.txtFullprice = New System.Windows.Forms.TextBox()
        Me.radSpacebar = New System.Windows.Forms.RadioButton()
        Me.radKitkat = New System.Windows.Forms.RadioButton()
        Me.rad3musketeer = New System.Windows.Forms.RadioButton()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.radExplodium = New System.Windows.Forms.RadioButton()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFullprice
        '
        Me.txtFullprice.Enabled = False
        Me.txtFullprice.Location = New System.Drawing.Point(12, 12)
        Me.txtFullprice.Name = "txtFullprice"
        Me.txtFullprice.Size = New System.Drawing.Size(233, 20)
        Me.txtFullprice.TabIndex = 0
        '
        'radSpacebar
        '
        Me.radSpacebar.AutoSize = True
        Me.radSpacebar.Location = New System.Drawing.Point(12, 38)
        Me.radSpacebar.Name = "radSpacebar"
        Me.radSpacebar.Size = New System.Drawing.Size(72, 17)
        Me.radSpacebar.TabIndex = 1
        Me.radSpacebar.TabStop = True
        Me.radSpacebar.Text = "SpaceBar"
        Me.radSpacebar.UseVisualStyleBackColor = True
        '
        'radKitkat
        '
        Me.radKitkat.AutoSize = True
        Me.radKitkat.Location = New System.Drawing.Point(176, 38)
        Me.radKitkat.Name = "radKitkat"
        Me.radKitkat.Size = New System.Drawing.Size(53, 17)
        Me.radKitkat.TabIndex = 2
        Me.radKitkat.TabStop = True
        Me.radKitkat.Text = "KitKat"
        Me.radKitkat.UseVisualStyleBackColor = True
        '
        'rad3musketeer
        '
        Me.rad3musketeer.AutoSize = True
        Me.rad3musketeer.Location = New System.Drawing.Point(12, 61)
        Me.rad3musketeer.Name = "rad3musketeer"
        Me.rad3musketeer.Size = New System.Drawing.Size(84, 17)
        Me.rad3musketeer.TabIndex = 3
        Me.rad3musketeer.TabStop = True
        Me.rad3musketeer.Text = "3 Musketeer"
        Me.rad3musketeer.UseVisualStyleBackColor = True
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(12, 84)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 23)
        Me.btnPurchase.TabIndex = 4
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(93, 84)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'radExplodium
        '
        Me.radExplodium.AutoSize = True
        Me.radExplodium.Location = New System.Drawing.Point(176, 61)
        Me.radExplodium.Name = "radExplodium"
        Me.radExplodium.Size = New System.Drawing.Size(73, 17)
        Me.radExplodium.TabIndex = 6
        Me.radExplodium.TabStop = True
        Me.radExplodium.Text = "Explodium"
        Me.radExplodium.UseVisualStyleBackColor = True
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
        Me.ClientSize = New System.Drawing.Size(259, 119)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.radExplodium)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.rad3musketeer)
        Me.Controls.Add(Me.radKitkat)
        Me.Controls.Add(Me.radSpacebar)
        Me.Controls.Add(Me.txtFullprice)
        Me.Name = "Form1"
        Me.Text = "Candy Bar Machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFullprice As System.Windows.Forms.TextBox
    Friend WithEvents radSpacebar As System.Windows.Forms.RadioButton
    Friend WithEvents radKitkat As System.Windows.Forms.RadioButton
    Friend WithEvents rad3musketeer As System.Windows.Forms.RadioButton
    Friend WithEvents btnPurchase As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents radExplodium As System.Windows.Forms.RadioButton
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
