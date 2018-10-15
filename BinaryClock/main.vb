Public Class main
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, MenuStrip1.MouseDown, ListView1.MouseDown, Label1.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, MenuStrip1.MouseUp, ListView1.MouseUp, Label1.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, MenuStrip1.MouseMove, ListView1.MouseMove, Label1.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = myappfullname
        NotifyIcon1.Text = myappfullname
        '
        Me.Location = New Point((My.Computer.Screen.WorkingArea.Width / 100) * 80, (My.Computer.Screen.WorkingArea.Height / 100) * 30)
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim SelectedItem_of_listview As String = Nothing
        For a = 0 To ListView1.SelectedItems.Count - 1
            Dim k As String = ListView1.SelectedItems(a).ToString.Substring(ListView1.SelectedItems(a).ToString.IndexOf("{") + 1)
            SelectedItem_of_listview = k.Substring(0, k.IndexOf("}"))

            Select Case SelectedItem_of_listview
                Case "Binary"
                    binary_style.Show()
                Case "Wrist Watch"
                    wrist_watch.Show()
                Case "Dot Styles"
                    dot_style.Show()
                Case "Windows Blocks"
                    win_block_style.Show()
            End Select
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
        End
    End Sub
    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        infobox.ShowDialog()
    End Sub

    Private Sub MinimizeToTrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToTrayToolStripMenuItem.Click
        Me.Hide()
        NotifyIcon1.BalloonTipTitle = "Double click to show menu!"
        NotifyIcon1.BalloonTipText = "Double click to show menu"
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.None
        NotifyIcon1.ShowBalloonTip(500)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub
End Class
