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
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.chkSlideshow = New System.Windows.Forms.CheckBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.iml = New System.Windows.Forms.ImageList(Me.components)
        Me.timSlideshow = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic1
        '
        Me.pic1.InitialImage = Nothing
        Me.pic1.Location = New System.Drawing.Point(12, 12)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(175, 175)
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.Location = New System.Drawing.Point(193, 12)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(175, 175)
        Me.pic2.TabIndex = 1
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.Location = New System.Drawing.Point(374, 12)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(175, 175)
        Me.pic3.TabIndex = 2
        Me.pic3.TabStop = False
        '
        'chkSlideshow
        '
        Me.chkSlideshow.AutoSize = True
        Me.chkSlideshow.Location = New System.Drawing.Point(230, 201)
        Me.chkSlideshow.Name = "chkSlideshow"
        Me.chkSlideshow.Size = New System.Drawing.Size(110, 17)
        Me.chkSlideshow.TabIndex = 3
        Me.chkSlideshow.Text = "Slideshow On/Off"
        Me.chkSlideshow.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(12, 201)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(117, 63)
        Me.btnPrevious.TabIndex = 4
        Me.btnPrevious.Text = "<< Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(432, 201)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(117, 63)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next >>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(246, 241)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'iml
        '
        Me.iml.ImageStream = CType(resources.GetObject("iml.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iml.TransparentColor = System.Drawing.Color.Transparent
        Me.iml.Images.SetKeyName(0, "Chrysanthemum.jpg")
        Me.iml.Images.SetKeyName(1, "Desert.jpg")
        Me.iml.Images.SetKeyName(2, "Hydrangeas.jpg")
        Me.iml.Images.SetKeyName(3, "Jellyfish.jpg")
        Me.iml.Images.SetKeyName(4, "Koala.jpg")
        Me.iml.Images.SetKeyName(5, "Lighthouse.jpg")
        Me.iml.Images.SetKeyName(6, "Penguins.jpg")
        Me.iml.Images.SetKeyName(7, "Tulips.jpg")
        '
        'timSlideshow
        '
        Me.timSlideshow.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 272)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.chkSlideshow)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents chkSlideshow As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents iml As System.Windows.Forms.ImageList
    Friend WithEvents timSlideshow As System.Windows.Forms.Timer

End Class
