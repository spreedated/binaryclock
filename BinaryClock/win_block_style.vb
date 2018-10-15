Public Class win_block_style
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, PictureBox1.MouseDown, PictureBox2.MouseDown, PictureBox3.MouseDown, PictureBox4.MouseDown, PictureBox5.MouseDown, PictureBox6.MouseDown, PictureBox11.MouseDown, PictureBox12.MouseDown, PictureBox13.MouseDown, PictureBox14.MouseDown, PictureBox15.MouseDown, PictureBox16.MouseDown, PictureBox17.MouseDown, PictureBox18.MouseDown, PictureBox21.MouseDown, PictureBox22.MouseDown, PictureBox23.MouseDown, PictureBox24.MouseDown, PictureBox25.MouseDown, PictureBox26.MouseDown, Label1.MouseDown, MenuStrip1.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, PictureBox1.MouseUp, PictureBox2.MouseUp, PictureBox3.MouseUp, PictureBox4.MouseUp, PictureBox5.MouseUp, PictureBox6.MouseUp, PictureBox11.MouseUp, PictureBox12.MouseUp, PictureBox13.MouseUp, PictureBox14.MouseUp, PictureBox15.MouseUp, PictureBox16.MouseUp, PictureBox17.MouseUp, PictureBox18.MouseUp, PictureBox21.MouseUp, PictureBox22.MouseUp, PictureBox23.MouseUp, PictureBox24.MouseUp, PictureBox25.MouseUp, PictureBox26.MouseUp, Label1.MouseUp, MenuStrip1.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, PictureBox1.MouseMove, PictureBox2.MouseMove, PictureBox3.MouseMove, PictureBox4.MouseMove, PictureBox5.MouseMove, PictureBox6.MouseMove, PictureBox11.MouseMove, PictureBox12.MouseMove, PictureBox13.MouseMove, PictureBox14.MouseMove, PictureBox15.MouseMove, PictureBox16.MouseMove, PictureBox17.MouseMove, PictureBox18.MouseMove, PictureBox21.MouseMove, PictureBox22.MouseMove, PictureBox23.MouseMove, PictureBox24.MouseMove, PictureBox25.MouseMove, PictureBox26.MouseMove, Label1.MouseMove, MenuStrip1.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub



    Private Sub win_block_style_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = myappfullname & " - Windows Blocks"
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#222222")
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.TopMost = True
        '
        win_block_style_show_time_with_zeroes()
        Timer1.Start()
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property
    Private Sub binary_style_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        main.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        win_block_style_show_time_with_zeroes()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        main.WindowState = FormWindowState.Normal
        Me.Hide()
    End Sub

    Private Sub WithZeroesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithZeroesToolStripMenuItem.Click
        WithZeroesToolStripMenuItem.Checked = True
        WithoutZeroesToolStripMenuItem.Checked = False
        '
        Timer1.Start()
        Timer2.Stop()
    End Sub

    Private Sub WithoutZeroesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithoutZeroesToolStripMenuItem.Click
        WithZeroesToolStripMenuItem.Checked = False
        WithoutZeroesToolStripMenuItem.Checked = True
        '
        Timer1.Stop()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        win_block_style_show_time()
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
End Class