<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wrist_watch
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wrist_watch))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SquareOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FramelessBETAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox_1_hr = New System.Windows.Forms.PictureBox()
        Me.PictureBox_2_hr = New System.Windows.Forms.PictureBox()
        Me.PictureBox_4_hr = New System.Windows.Forms.PictureBox()
        Me.PictureBox_8_hr = New System.Windows.Forms.PictureBox()
        Me.PictureBox_PM = New System.Windows.Forms.PictureBox()
        Me.PictureBox_AM = New System.Windows.Forms.PictureBox()
        Me.PictureBox_1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_32 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_clock = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.show_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PlayAnimationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffTimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox_1_hr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_2_hr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_4_hr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_8_hr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_PM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_AM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_clock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SquareOptionsToolStripMenuItem, Me.FramelessBETAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(288, 24)
        Me.MenuStrip1.TabIndex = 78
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.ToolStripMenuItem1.Text = "&Close"
        '
        'SquareOptionsToolStripMenuItem
        '
        Me.SquareOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayAnimationToolStripMenuItem, Me.OffTimerToolStripMenuItem})
        Me.SquareOptionsToolStripMenuItem.Name = "SquareOptionsToolStripMenuItem"
        Me.SquareOptionsToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.SquareOptionsToolStripMenuItem.Text = "Wrist &Options"
        '
        'FramelessBETAToolStripMenuItem
        '
        Me.FramelessBETAToolStripMenuItem.Name = "FramelessBETAToolStripMenuItem"
        Me.FramelessBETAToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.FramelessBETAToolStripMenuItem.Text = "Framed"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(76, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 23)
        Me.Button1.TabIndex = 94
        Me.Button1.Text = "Real behavior"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 742)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 15)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "By: Markus K. Wackermann"
        '
        'PictureBox_1_hr
        '
        Me.PictureBox_1_hr.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_1_hr.Location = New System.Drawing.Point(45, 573)
        Me.PictureBox_1_hr.Name = "PictureBox_1_hr"
        Me.PictureBox_1_hr.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_1_hr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_1_hr.TabIndex = 91
        Me.PictureBox_1_hr.TabStop = False
        '
        'PictureBox_2_hr
        '
        Me.PictureBox_2_hr.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_2_hr.Location = New System.Drawing.Point(45, 516)
        Me.PictureBox_2_hr.Name = "PictureBox_2_hr"
        Me.PictureBox_2_hr.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_2_hr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_2_hr.TabIndex = 90
        Me.PictureBox_2_hr.TabStop = False
        '
        'PictureBox_4_hr
        '
        Me.PictureBox_4_hr.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_4_hr.Location = New System.Drawing.Point(45, 456)
        Me.PictureBox_4_hr.Name = "PictureBox_4_hr"
        Me.PictureBox_4_hr.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_4_hr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_4_hr.TabIndex = 89
        Me.PictureBox_4_hr.TabStop = False
        '
        'PictureBox_8_hr
        '
        Me.PictureBox_8_hr.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_8_hr.Location = New System.Drawing.Point(45, 395)
        Me.PictureBox_8_hr.Name = "PictureBox_8_hr"
        Me.PictureBox_8_hr.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_8_hr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_8_hr.TabIndex = 88
        Me.PictureBox_8_hr.TabStop = False
        '
        'PictureBox_PM
        '
        Me.PictureBox_PM.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_PM.Location = New System.Drawing.Point(45, 335)
        Me.PictureBox_PM.Name = "PictureBox_PM"
        Me.PictureBox_PM.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_PM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_PM.TabIndex = 87
        Me.PictureBox_PM.TabStop = False
        '
        'PictureBox_AM
        '
        Me.PictureBox_AM.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_AM.Location = New System.Drawing.Point(45, 275)
        Me.PictureBox_AM.Name = "PictureBox_AM"
        Me.PictureBox_AM.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_AM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_AM.TabIndex = 86
        Me.PictureBox_AM.TabStop = False
        '
        'PictureBox_1
        '
        Me.PictureBox_1.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_1.Location = New System.Drawing.Point(154, 573)
        Me.PictureBox_1.Name = "PictureBox_1"
        Me.PictureBox_1.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_1.TabIndex = 85
        Me.PictureBox_1.TabStop = False
        '
        'PictureBox_2
        '
        Me.PictureBox_2.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_2.Location = New System.Drawing.Point(154, 516)
        Me.PictureBox_2.Name = "PictureBox_2"
        Me.PictureBox_2.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_2.TabIndex = 84
        Me.PictureBox_2.TabStop = False
        '
        'PictureBox_4
        '
        Me.PictureBox_4.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_4.Location = New System.Drawing.Point(154, 456)
        Me.PictureBox_4.Name = "PictureBox_4"
        Me.PictureBox_4.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_4.TabIndex = 83
        Me.PictureBox_4.TabStop = False
        '
        'PictureBox_8
        '
        Me.PictureBox_8.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_8.Location = New System.Drawing.Point(154, 395)
        Me.PictureBox_8.Name = "PictureBox_8"
        Me.PictureBox_8.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_8.TabIndex = 82
        Me.PictureBox_8.TabStop = False
        '
        'PictureBox_16
        '
        Me.PictureBox_16.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_16.Location = New System.Drawing.Point(154, 335)
        Me.PictureBox_16.Name = "PictureBox_16"
        Me.PictureBox_16.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_16.TabIndex = 81
        Me.PictureBox_16.TabStop = False
        '
        'PictureBox_32
        '
        Me.PictureBox_32.Image = Global.BinaryClock.My.Resources.Resources.blue
        Me.PictureBox_32.Location = New System.Drawing.Point(154, 275)
        Me.PictureBox_32.Name = "PictureBox_32"
        Me.PictureBox_32.Size = New System.Drawing.Size(84, 10)
        Me.PictureBox_32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_32.TabIndex = 80
        Me.PictureBox_32.TabStop = False
        '
        'PictureBox_clock
        '
        Me.PictureBox_clock.Image = Global.BinaryClock.My.Resources.Resources.clock
        Me.PictureBox_clock.Location = New System.Drawing.Point(2, 67)
        Me.PictureBox_clock.Name = "PictureBox_clock"
        Me.PictureBox_clock.Size = New System.Drawing.Size(284, 672)
        Me.PictureBox_clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_clock.TabIndex = 79
        Me.PictureBox_clock.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(288, 25)
        Me.ToolStrip1.TabIndex = 95
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton1.Text = "&Show Time"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripButton2.Text = "&Show Date"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripButton3.Text = "Animation"
        '
        'show_Timer
        '
        Me.show_Timer.Interval = 5000
        '
        'PlayAnimationToolStripMenuItem
        '
        Me.PlayAnimationToolStripMenuItem.Checked = True
        Me.PlayAnimationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PlayAnimationToolStripMenuItem.Name = "PlayAnimationToolStripMenuItem"
        Me.PlayAnimationToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PlayAnimationToolStripMenuItem.Text = "Play Animation"
        '
        'OffTimerToolStripMenuItem
        '
        Me.OffTimerToolStripMenuItem.Checked = True
        Me.OffTimerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OffTimerToolStripMenuItem.Name = "OffTimerToolStripMenuItem"
        Me.OffTimerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OffTimerToolStripMenuItem.Text = "Off Timer"
        '
        'wrist_watch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 761)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox_1_hr)
        Me.Controls.Add(Me.PictureBox_2_hr)
        Me.Controls.Add(Me.PictureBox_4_hr)
        Me.Controls.Add(Me.PictureBox_8_hr)
        Me.Controls.Add(Me.PictureBox_PM)
        Me.Controls.Add(Me.PictureBox_AM)
        Me.Controls.Add(Me.PictureBox_1)
        Me.Controls.Add(Me.PictureBox_2)
        Me.Controls.Add(Me.PictureBox_4)
        Me.Controls.Add(Me.PictureBox_8)
        Me.Controls.Add(Me.PictureBox_16)
        Me.Controls.Add(Me.PictureBox_32)
        Me.Controls.Add(Me.PictureBox_clock)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "wrist_watch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wrist_watch"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox_1_hr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_2_hr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_4_hr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_8_hr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_PM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_AM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_clock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SquareOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FramelessBETAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox_1_hr As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_2_hr As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_4_hr As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_8_hr As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_PM As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_AM As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_32 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_clock As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents show_Timer As System.Windows.Forms.Timer
    Friend WithEvents PlayAnimationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffTimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
