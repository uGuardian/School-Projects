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
        Me.btnFlavor = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblToppings = New System.Windows.Forms.Label()
        Me.lblFlavor = New System.Windows.Forms.Label()
        Me.lblOrders = New System.Windows.Forms.Label()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radIchigo = New System.Windows.Forms.RadioButton()
        Me.radCaramel = New System.Windows.Forms.RadioButton()
        Me.lstOrders = New System.Windows.Forms.ListBox()
        Me.cmbFlavor = New System.Windows.Forms.ComboBox()
        Me.btnToppings = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblPrices = New System.Windows.Forms.Label()
        Me.lstPrices = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnFlavor
        '
        Me.btnFlavor.Location = New System.Drawing.Point(18, 82)
        Me.btnFlavor.Name = "btnFlavor"
        Me.btnFlavor.Size = New System.Drawing.Size(75, 23)
        Me.btnFlavor.TabIndex = 0
        Me.btnFlavor.Text = "Add Flavor"
        Me.btnFlavor.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(18, 141)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(267, 31)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Awesome Ice-Cream"
        '
        'lblToppings
        '
        Me.lblToppings.AutoSize = True
        Me.lblToppings.Location = New System.Drawing.Point(162, 40)
        Me.lblToppings.Name = "lblToppings"
        Me.lblToppings.Size = New System.Drawing.Size(51, 13)
        Me.lblToppings.TabIndex = 3
        Me.lblToppings.Text = "Toppings"
        '
        'lblFlavor
        '
        Me.lblFlavor.AutoSize = True
        Me.lblFlavor.Location = New System.Drawing.Point(15, 40)
        Me.lblFlavor.Name = "lblFlavor"
        Me.lblFlavor.Size = New System.Drawing.Size(87, 13)
        Me.lblFlavor.TabIndex = 4
        Me.lblFlavor.Text = "Ice Cream Flavor"
        '
        'lblOrders
        '
        Me.lblOrders.AutoSize = True
        Me.lblOrders.Location = New System.Drawing.Point(306, 40)
        Me.lblOrders.Name = "lblOrders"
        Me.lblOrders.Size = New System.Drawing.Size(89, 13)
        Me.lblOrders.TabIndex = 5
        Me.lblOrders.Text = "Ice Cream Orders"
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(165, 73)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(73, 17)
        Me.radChocolate.TabIndex = 6
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "Chocolate"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radIchigo
        '
        Me.radIchigo.AutoSize = True
        Me.radIchigo.Location = New System.Drawing.Point(165, 95)
        Me.radIchigo.Name = "radIchigo"
        Me.radIchigo.Size = New System.Drawing.Size(75, 17)
        Me.radIchigo.TabIndex = 7
        Me.radIchigo.TabStop = True
        Me.radIchigo.Text = "Strawberry"
        Me.radIchigo.UseVisualStyleBackColor = True
        '
        'radCaramel
        '
        Me.radCaramel.AutoSize = True
        Me.radCaramel.Location = New System.Drawing.Point(165, 118)
        Me.radCaramel.Name = "radCaramel"
        Me.radCaramel.Size = New System.Drawing.Size(63, 17)
        Me.radCaramel.TabIndex = 8
        Me.radCaramel.TabStop = True
        Me.radCaramel.Text = "Caramel"
        Me.radCaramel.UseVisualStyleBackColor = True
        '
        'lstOrders
        '
        Me.lstOrders.FormattingEnabled = True
        Me.lstOrders.Location = New System.Drawing.Point(309, 73)
        Me.lstOrders.Name = "lstOrders"
        Me.lstOrders.Size = New System.Drawing.Size(239, 95)
        Me.lstOrders.TabIndex = 9
        '
        'cmbFlavor
        '
        Me.cmbFlavor.FormattingEnabled = True
        Me.cmbFlavor.Items.AddRange(New Object() {"Chocolate", "Vanilla", "Strawberry", "Pinapple", "Rocky Road", "Cookies & Cream"})
        Me.cmbFlavor.Location = New System.Drawing.Point(12, 56)
        Me.cmbFlavor.Name = "cmbFlavor"
        Me.cmbFlavor.Size = New System.Drawing.Size(121, 21)
        Me.cmbFlavor.TabIndex = 10
        '
        'btnToppings
        '
        Me.btnToppings.Location = New System.Drawing.Point(165, 141)
        Me.btnToppings.Name = "btnToppings"
        Me.btnToppings.Size = New System.Drawing.Size(85, 23)
        Me.btnToppings.TabIndex = 11
        Me.btnToppings.Text = "Add Topping"
        Me.btnToppings.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(18, 112)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 12
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblPrices
        '
        Me.lblPrices.AutoSize = True
        Me.lblPrices.Location = New System.Drawing.Point(551, 40)
        Me.lblPrices.Name = "lblPrices"
        Me.lblPrices.Size = New System.Drawing.Size(31, 13)
        Me.lblPrices.TabIndex = 5
        Me.lblPrices.Text = "Price"
        '
        'lstPrices
        '
        Me.lstPrices.FormattingEnabled = True
        Me.lstPrices.Location = New System.Drawing.Point(554, 73)
        Me.lstPrices.Name = "lstPrices"
        Me.lstPrices.Size = New System.Drawing.Size(99, 95)
        Me.lstPrices.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 177)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnToppings)
        Me.Controls.Add(Me.cmbFlavor)
        Me.Controls.Add(Me.lstPrices)
        Me.Controls.Add(Me.lstOrders)
        Me.Controls.Add(Me.radCaramel)
        Me.Controls.Add(Me.radIchigo)
        Me.Controls.Add(Me.lblPrices)
        Me.Controls.Add(Me.radChocolate)
        Me.Controls.Add(Me.lblOrders)
        Me.Controls.Add(Me.lblFlavor)
        Me.Controls.Add(Me.lblToppings)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnFlavor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFlavor As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblToppings As System.Windows.Forms.Label
    Friend WithEvents lblFlavor As System.Windows.Forms.Label
    Friend WithEvents lblOrders As System.Windows.Forms.Label
    Friend WithEvents radChocolate As System.Windows.Forms.RadioButton
    Friend WithEvents radIchigo As System.Windows.Forms.RadioButton
    Friend WithEvents radCaramel As System.Windows.Forms.RadioButton
    Friend WithEvents cmbFlavor As System.Windows.Forms.ComboBox
    Friend WithEvents lstOrders As System.Windows.Forms.ListBox
    Friend WithEvents btnToppings As System.Windows.Forms.Button
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents lblPrices As System.Windows.Forms.Label
    Friend WithEvents lstPrices As System.Windows.Forms.ListBox

End Class
