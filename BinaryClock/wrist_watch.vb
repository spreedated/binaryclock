Public Class wrist_watch
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, Button1.MouseDown, PictureBox_clock.MouseDown, PictureBox_1.MouseDown, PictureBox_1_hr.MouseDown, PictureBox_16.MouseDown, PictureBox_2.MouseDown, PictureBox_2_hr.MouseDown, PictureBox_32.MouseDown, PictureBox_4.MouseDown, PictureBox_4_hr.MouseDown, PictureBox_8.MouseDown, PictureBox_8_hr.MouseDown, PictureBox_AM.MouseDown, PictureBox_PM.MouseDown, ToolStrip1.MouseDown, MenuStrip1.MouseDown, Label1.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, Button1.MouseUp, PictureBox_clock.MouseUp, PictureBox_1.MouseUp, PictureBox_1_hr.MouseUp, PictureBox_16.MouseUp, PictureBox_2.MouseUp, PictureBox_2_hr.MouseUp, PictureBox_32.MouseUp, PictureBox_4.MouseUp, PictureBox_4_hr.MouseUp, PictureBox_8.MouseUp, PictureBox_8_hr.MouseUp, PictureBox_AM.MouseUp, PictureBox_PM.MouseUp, ToolStrip1.MouseUp, MenuStrip1.MouseUp, Label1.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, Button1.MouseMove, PictureBox_clock.MouseMove, PictureBox_1.MouseMove, PictureBox_1_hr.MouseMove, PictureBox_16.MouseMove, PictureBox_2.MouseMove, PictureBox_2_hr.MouseMove, PictureBox_32.MouseMove, PictureBox_4.MouseMove, PictureBox_4_hr.MouseMove, PictureBox_8.MouseMove, PictureBox_8_hr.MouseMove, PictureBox_AM.MouseMove, PictureBox_PM.MouseMove, ToolStrip1.MouseMove, MenuStrip1.MouseMove, Label1.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub wrist_watch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = myappfullname & " - Wrist Watch"
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.TopMost = True
        '
        clear_all_boxes()
    End Sub

    Private Sub binary_style_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        main.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles show_Timer.Tick
        clear_all_boxes()
        show_Timer.Stop()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        main.WindowState = FormWindowState.Normal
        Me.Hide()
    End Sub

    Private Sub FramelessBETAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FramelessBETAToolStripMenuItem.Click
        Select Case FramelessBETAToolStripMenuItem.Text
            Case "Frameless"
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                FramelessBETAToolStripMenuItem.Text = "Framed"
            Case "Framed"
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                FramelessBETAToolStripMenuItem.Text = "Frameless"
        End Select
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        show_Timer.Stop()
        show_what = Nothing
        animation_stuff()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        show_Timer.Stop()
        clear_all_boxes()
        If PlayAnimationToolStripMenuItem.Checked = True Then
            show_what = "date"
            animation_stuff()
        Else
            display_date()
        End If
        If OffTimerToolStripMenuItem.Checked = True Then
            show_Timer.Start()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        show_Timer.Stop()
        clear_all_boxes()
        If PlayAnimationToolStripMenuItem.Checked = True Then
            show_what = "time"
            animation_stuff()
        Else
            display_time()
        End If
        If OffTimerToolStripMenuItem.Checked = True Then
            show_Timer.Start()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim am_led As Boolean
        Dim pm_led As Boolean
        If PictureBox_AM.Image Is Nothing Then
            am_led = False
        Else
            am_led = True
        End If
        If PictureBox_PM.Image Is Nothing Then
            pm_led = False
        Else
            pm_led = True
        End If
        PlayAnimationToolStripMenuItem.Checked = True
        OffTimerToolStripMenuItem.Checked = True
        show_Timer.Stop()

        If am_led = False And pm_led = False Then
            show_what = "time"
            animation_stuff()
            show_Timer.Start()
        End If

        If (am_led = True And pm_led = False) Or (am_led = False And pm_led = True) Then
            clear_all_boxes()
            display_date()
            show_Timer.Start()
        End If

        If am_led = True And pm_led = True Then
            clear_all_boxes()
            display_time()
            show_Timer.Start()
        End If
    End Sub

    Private Sub PlayAnimationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayAnimationToolStripMenuItem.Click
        Select Case PlayAnimationToolStripMenuItem.Checked
            Case True
                PlayAnimationToolStripMenuItem.Checked = False
            Case False
                PlayAnimationToolStripMenuItem.Checked = True
        End Select
    End Sub

    Private Sub OffTimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OffTimerToolStripMenuItem.Click
        Select Case OffTimerToolStripMenuItem.Checked
            Case True
                OffTimerToolStripMenuItem.Checked = False
            Case False
                OffTimerToolStripMenuItem.Checked = True
        End Select
    End Sub
End Class