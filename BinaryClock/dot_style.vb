Public Class dot_style
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, PictureBox1.MouseDown, PictureBox2.MouseDown, PictureBox3.MouseDown, PictureBox4.MouseDown, PictureBox5.MouseDown, PictureBox6.MouseDown, PictureBox11.MouseDown, PictureBox12.MouseDown, PictureBox13.MouseDown, PictureBox14.MouseDown, PictureBox15.MouseDown, PictureBox16.MouseDown, PictureBox17.MouseDown, PictureBox18.MouseDown, PictureBox21.MouseDown, PictureBox22.MouseDown, PictureBox23.MouseDown, PictureBox24.MouseDown, PictureBox25.MouseDown, PictureBox26.MouseDown, Label1.MouseDown, MenuStrip1.MouseDown, PictureBox27.MouseDown, PictureBox28.MouseDown, PictureBox29.MouseDown, PictureBox30.MouseDown, PictureBox7.MouseDown, PictureBox8.MouseDown, PictureBox9.MouseDown, PictureBox10.MouseDown, PictureBox19.MouseDown, PictureBox20.MouseDown, PictureBox31.MouseDown, PictureBox32.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, PictureBox1.MouseUp, PictureBox2.MouseUp, PictureBox3.MouseUp, PictureBox4.MouseUp, PictureBox5.MouseUp, PictureBox6.MouseUp, PictureBox11.MouseUp, PictureBox12.MouseUp, PictureBox13.MouseUp, PictureBox14.MouseUp, PictureBox15.MouseUp, PictureBox16.MouseUp, PictureBox17.MouseUp, PictureBox18.MouseUp, PictureBox21.MouseUp, PictureBox22.MouseUp, PictureBox23.MouseUp, PictureBox24.MouseUp, PictureBox25.MouseUp, PictureBox26.MouseUp, Label1.MouseUp, MenuStrip1.MouseUp, PictureBox27.MouseUp, PictureBox28.MouseUp, PictureBox29.MouseUp, PictureBox30.MouseUp, PictureBox7.MouseUp, PictureBox8.MouseUp, PictureBox9.MouseUp, PictureBox10.MouseUp, PictureBox19.MouseUp, PictureBox20.MouseUp, PictureBox31.MouseUp, PictureBox32.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, PictureBox1.MouseMove, PictureBox2.MouseMove, PictureBox3.MouseMove, PictureBox4.MouseMove, PictureBox5.MouseMove, PictureBox6.MouseMove, PictureBox11.MouseMove, PictureBox12.MouseMove, PictureBox13.MouseMove, PictureBox14.MouseMove, PictureBox15.MouseMove, PictureBox16.MouseMove, PictureBox17.MouseMove, PictureBox18.MouseMove, PictureBox21.MouseMove, PictureBox22.MouseMove, PictureBox23.MouseMove, PictureBox24.MouseMove, PictureBox25.MouseMove, PictureBox26.MouseMove, Label1.MouseMove, MenuStrip1.MouseMove, PictureBox27.MouseMove, PictureBox28.MouseMove, PictureBox29.MouseMove, PictureBox30.MouseMove, PictureBox7.MouseMove, PictureBox8.MouseMove, PictureBox9.MouseMove, PictureBox10.MouseMove, PictureBox19.MouseMove, PictureBox20.MouseMove, PictureBox31.MouseMove, PictureBox32.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
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
    Private Sub dot_style_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        main.WindowState = FormWindowState.Normal
    End Sub

    Private Sub dot_style_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = myappfullname & " - Dot Style Clock"
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.TopMost = True
        '
        dot_style_show_time()
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dot_style_show_time()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        main.WindowState = FormWindowState.Normal
        Me.Hide()
    End Sub

    Private Sub LeftDigitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftDigitsToolStripMenuItem.Click
        Select Case LeftDigitsToolStripMenuItem.Checked
            Case True
                LeftDigitsToolStripMenuItem.Checked = False
                PictureBox27.Visible = False
                PictureBox28.Visible = False
                PictureBox29.Visible = False
                PictureBox30.Visible = False
            Case False
                LeftDigitsToolStripMenuItem.Checked = True
                PictureBox27.Visible = True
                PictureBox28.Visible = True
                PictureBox29.Visible = True
                PictureBox30.Visible = True
        End Select
    End Sub

    Private Sub RealDigitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealDigitsToolStripMenuItem.Click
        Select Case RealDigitsToolStripMenuItem.Checked
            Case True
                RealDigitsToolStripMenuItem.Checked = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox20.Visible = False
                PictureBox19.Visible = False
                PictureBox31.Visible = False
                PictureBox32.Visible = False
            Case False
                RealDigitsToolStripMenuItem.Checked = True
                PictureBox7.Visible = True
                PictureBox8.Visible = True
                PictureBox9.Visible = True
                PictureBox10.Visible = True
                PictureBox20.Visible = True
                PictureBox19.Visible = True
                PictureBox31.Visible = True
                PictureBox32.Visible = True
        End Select
    End Sub

    Private Sub FramedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FramedToolStripMenuItem.Click
        Select Case FramedToolStripMenuItem.Text
            Case "Frameless"
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                FramedToolStripMenuItem.Text = "Framed"
            Case "Framed"
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                FramedToolStripMenuItem.Text = "Frameless"
        End Select
    End Sub
End Class