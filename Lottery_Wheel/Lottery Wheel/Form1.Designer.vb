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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.pic3_3 = New System.Windows.Forms.PictureBox()
        Me.pic2_3 = New System.Windows.Forms.PictureBox()
        Me.pic1_3 = New System.Windows.Forms.PictureBox()
        Me.picLever = New System.Windows.Forms.PictureBox()
        Me.timLever = New System.Windows.Forms.Timer(Me.components)
        Me.timSpin = New System.Windows.Forms.Timer(Me.components)
        Me.imlSlots = New System.Windows.Forms.ImageList(Me.components)
        Me.pic3_1 = New System.Windows.Forms.PictureBox()
        Me.pic2_1 = New System.Windows.Forms.PictureBox()
        Me.pic1_1 = New System.Windows.Forms.PictureBox()
        Me.pic3_2 = New System.Windows.Forms.PictureBox()
        Me.pic2_2 = New System.Windows.Forms.PictureBox()
        Me.pic1_2 = New System.Windows.Forms.PictureBox()
        Me.timSpinning = New System.Windows.Forms.Timer(Me.components)
        Me.timStart = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pic3_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLever, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(12, 630)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(612, 39)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'pic3_3
        '
        Me.pic3_3.Location = New System.Drawing.Point(424, 424)
        Me.pic3_3.Name = "pic3_3"
        Me.pic3_3.Size = New System.Drawing.Size(200, 200)
        Me.pic3_3.TabIndex = 7
        Me.pic3_3.TabStop = False
        '
        'pic2_3
        '
        Me.pic2_3.Location = New System.Drawing.Point(218, 424)
        Me.pic2_3.Name = "pic2_3"
        Me.pic2_3.Size = New System.Drawing.Size(200, 200)
        Me.pic2_3.TabIndex = 6
        Me.pic2_3.TabStop = False
        '
        'pic1_3
        '
        Me.pic1_3.Location = New System.Drawing.Point(12, 424)
        Me.pic1_3.Name = "pic1_3"
        Me.pic1_3.Size = New System.Drawing.Size(200, 200)
        Me.pic1_3.TabIndex = 5
        Me.pic1_3.TabStop = False
        '
        'picLever
        '
        Me.picLever.InitialImage = Global.Lottery_Wheel.My.Resources.Resources.lever
        Me.picLever.Location = New System.Drawing.Point(630, 207)
        Me.picLever.Name = "picLever"
        Me.picLever.Size = New System.Drawing.Size(150, 225)
        Me.picLever.TabIndex = 10
        Me.picLever.TabStop = False
        '
        'timLever
        '
        Me.timLever.Interval = 1000
        '
        'timSpin
        '
        '
        'imlSlots
        '
        Me.imlSlots.ImageStream = CType(resources.GetObject("imlSlots.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlSlots.TransparentColor = System.Drawing.Color.Transparent
        Me.imlSlots.Images.SetKeyName(0, "Banana Peel Triple.png")
        Me.imlSlots.Images.SetKeyName(1, "Banana Peel.png")
        Me.imlSlots.Images.SetKeyName(2, "Blooper.png")
        Me.imlSlots.Images.SetKeyName(3, "Bob-omb.png")
        Me.imlSlots.Images.SetKeyName(4, "Bullet Bill.png")
        Me.imlSlots.Images.SetKeyName(5, "Fake Item Box.png")
        Me.imlSlots.Images.SetKeyName(6, "Golden Mushroom.png")
        Me.imlSlots.Images.SetKeyName(7, "Green Koopa Shell Triple.png")
        Me.imlSlots.Images.SetKeyName(8, "Green Koopa Shell.png")
        Me.imlSlots.Images.SetKeyName(9, "Lightning.png")
        Me.imlSlots.Images.SetKeyName(10, "Mushroom.png")
        Me.imlSlots.Images.SetKeyName(11, "Red Koopa Shell Triple.png")
        Me.imlSlots.Images.SetKeyName(12, "Red Koopa Shell.png")
        Me.imlSlots.Images.SetKeyName(13, "Star.png")
        Me.imlSlots.Images.SetKeyName(14, "Triple Mushroom.png")
        Me.imlSlots.Images.SetKeyName(15, "Winged Spiny Shell.png")
        '
        'pic3_1
        '
        Me.pic3_1.Location = New System.Drawing.Point(424, 12)
        Me.pic3_1.Name = "pic3_1"
        Me.pic3_1.Size = New System.Drawing.Size(200, 200)
        Me.pic3_1.TabIndex = 13
        Me.pic3_1.TabStop = False
        '
        'pic2_1
        '
        Me.pic2_1.Location = New System.Drawing.Point(218, 12)
        Me.pic2_1.Name = "pic2_1"
        Me.pic2_1.Size = New System.Drawing.Size(200, 200)
        Me.pic2_1.TabIndex = 12
        Me.pic2_1.TabStop = False
        '
        'pic1_1
        '
        Me.pic1_1.Location = New System.Drawing.Point(12, 12)
        Me.pic1_1.Name = "pic1_1"
        Me.pic1_1.Size = New System.Drawing.Size(200, 200)
        Me.pic1_1.TabIndex = 11
        Me.pic1_1.TabStop = False
        '
        'pic3_2
        '
        Me.pic3_2.Location = New System.Drawing.Point(424, 218)
        Me.pic3_2.Name = "pic3_2"
        Me.pic3_2.Size = New System.Drawing.Size(200, 200)
        Me.pic3_2.TabIndex = 16
        Me.pic3_2.TabStop = False
        '
        'pic2_2
        '
        Me.pic2_2.Location = New System.Drawing.Point(218, 218)
        Me.pic2_2.Name = "pic2_2"
        Me.pic2_2.Size = New System.Drawing.Size(200, 200)
        Me.pic2_2.TabIndex = 15
        Me.pic2_2.TabStop = False
        '
        'pic1_2
        '
        Me.pic1_2.Location = New System.Drawing.Point(12, 218)
        Me.pic1_2.Name = "pic1_2"
        Me.pic1_2.Size = New System.Drawing.Size(200, 200)
        Me.pic1_2.TabIndex = 14
        Me.pic1_2.TabStop = False
        '
        'timSpinning
        '
        '
        'timStart
        '
        Me.timStart.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 681)
        Me.Controls.Add(Me.pic3_2)
        Me.Controls.Add(Me.pic2_2)
        Me.Controls.Add(Me.pic1_2)
        Me.Controls.Add(Me.pic3_1)
        Me.Controls.Add(Me.pic2_1)
        Me.Controls.Add(Me.pic1_1)
        Me.Controls.Add(Me.picLever)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.pic3_3)
        Me.Controls.Add(Me.pic2_3)
        Me.Controls.Add(Me.pic1_3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic3_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLever, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents pic3_3 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2_3 As System.Windows.Forms.PictureBox
    Friend WithEvents pic1_3 As System.Windows.Forms.PictureBox
    Friend WithEvents picLever As System.Windows.Forms.PictureBox
    Friend WithEvents timLever As System.Windows.Forms.Timer
    Friend WithEvents timSpin As System.Windows.Forms.Timer
    Friend WithEvents imlSlots As System.Windows.Forms.ImageList
    Friend WithEvents pic3_1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2_1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic1_1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic3_2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2_2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic1_2 As System.Windows.Forms.PictureBox
    Friend WithEvents timSpinning As System.Windows.Forms.Timer
    Friend WithEvents timStart As System.Windows.Forms.Timer

End Class
