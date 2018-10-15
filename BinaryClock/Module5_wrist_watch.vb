Module Module5_wrist_watch
    Public Sub clear_all_boxes()
        wrist_watch.PictureBox_32.Image = Nothing
        wrist_watch.PictureBox_16.Image = Nothing
        wrist_watch.PictureBox_8.Image = Nothing
        wrist_watch.PictureBox_4.Image = Nothing
        wrist_watch.PictureBox_2.Image = Nothing
        wrist_watch.PictureBox_1.Image = Nothing
        wrist_watch.PictureBox_AM.Image = Nothing
        wrist_watch.PictureBox_PM.Image = Nothing
        wrist_watch.PictureBox_8_hr.Image = Nothing
        wrist_watch.PictureBox_4_hr.Image = Nothing
        wrist_watch.PictureBox_2_hr.Image = Nothing
        wrist_watch.PictureBox_1_hr.Image = Nothing
    End Sub
    '
    Public show_what As String = Nothing
    Public Sub display_time()
        Dim time_hours As Integer = Date.Now.Hour
        Dim time_minutes As Integer = Date.Now.Minute

        'AM - PM
        If time_hours <= 12 Then
            wrist_watch.PictureBox_AM.Image = My.Resources.red
        Else
            wrist_watch.PictureBox_PM.Image = My.Resources.red
            Select Case time_hours
                Case 13
                    time_hours = 1
                Case 14
                    time_hours = 2
                Case 15
                    time_hours = 3
                Case 16
                    time_hours = 4
                Case 17
                    time_hours = 5
                Case 18
                    time_hours = 6
                Case 19
                    time_hours = 7
                Case 20
                    time_hours = 8
                Case 21
                    time_hours = 9
                Case 22
                    time_hours = 10
                Case 23
                    time_hours = 11
                Case 0
                    time_hours = 12
            End Select
        End If

        'show hours
        If (time_hours / 8) >= 1 And (time_hours / 8) < 2 Then
            wrist_watch.PictureBox_8_hr.Image = My.Resources.blue
            time_hours = time_hours - 8
        End If
        If (time_hours / 4) >= 1 And (time_hours / 4) < 2 Then
            wrist_watch.PictureBox_4_hr.Image = My.Resources.blue
            time_hours = time_hours - 4
        End If
        If (time_hours / 2) >= 1 And (time_hours / 2) < 2 Then
            wrist_watch.PictureBox_2_hr.Image = My.Resources.blue
            time_hours = time_hours - 2
        End If
        If (time_hours / 1) >= 1 And (time_hours / 1) < 2 Then
            wrist_watch.PictureBox_1_hr.Image = My.Resources.blue
            time_hours = time_hours - 1
        End If
        'show minutes
        If (time_minutes / 32) >= 1 And (time_minutes / 32) < 2 Then
            wrist_watch.PictureBox_32.Image = My.Resources.blue
            time_minutes = time_minutes - 32
        End If
        If (time_minutes / 16) >= 1 And (time_minutes / 16) < 2 Then
            wrist_watch.PictureBox_16.Image = My.Resources.blue
            time_minutes = time_minutes - 16
        End If
        If (time_minutes / 8) >= 1 And (time_minutes / 8) < 2 Then
            wrist_watch.PictureBox_8.Image = My.Resources.blue
            time_minutes = time_minutes - 8
        End If
        If (time_minutes / 4) >= 1 And (time_minutes / 4) < 2 Then
            wrist_watch.PictureBox_4.Image = My.Resources.blue
            time_minutes = time_minutes - 4
        End If
        If (time_minutes / 2) >= 1 And (time_minutes / 2) < 2 Then
            wrist_watch.PictureBox_2.Image = My.Resources.blue
            time_minutes = time_minutes - 2
        End If
        If (time_minutes / 1) >= 1 And (time_minutes / 1) < 2 Then
            wrist_watch.PictureBox_1.Image = My.Resources.blue
            time_minutes = time_minutes - 1
        End If
    End Sub

    Public Sub display_date()
        Dim date_mon As Integer = Date.Now.Month
        Dim date_day As Integer = Date.Now.Day

        'AM - PM
        wrist_watch.PictureBox_AM.Image = My.Resources.blue
        wrist_watch.PictureBox_PM.Image = My.Resources.blue


        'show hours
        If (date_mon / 8) >= 1 And (date_mon / 8) < 2 Then
            wrist_watch.PictureBox_8_hr.Image = My.Resources.both
            date_mon = date_mon - 8
        End If
        If (date_mon / 4) >= 1 And (date_mon / 4) < 2 Then
            wrist_watch.PictureBox_4_hr.Image = My.Resources.both
            date_mon = date_mon - 4
        End If
        If (date_mon / 2) >= 1 And (date_mon / 2) < 2 Then
            wrist_watch.PictureBox_2_hr.Image = My.Resources.both
            date_mon = date_mon - 2
        End If
        If (date_mon / 1) >= 1 And (date_mon / 1) < 2 Then
            wrist_watch.PictureBox_1_hr.Image = My.Resources.both
            date_mon = date_mon - 1
        End If
        'show minutes
        If (date_day / 32) >= 1 And (date_day / 32) < 2 Then
            wrist_watch.PictureBox_32.Image = My.Resources.both
            date_day = date_day - 32
        End If
        If (date_day / 16) >= 1 And (date_day / 16) < 2 Then
            wrist_watch.PictureBox_16.Image = My.Resources.both
            date_day = date_day - 16
        End If
        If (date_day / 8) >= 1 And (date_day / 8) < 2 Then
            wrist_watch.PictureBox_8.Image = My.Resources.both
            date_day = date_day - 8
        End If
        If (date_day / 4) >= 1 And (date_day / 4) < 2 Then
            wrist_watch.PictureBox_4.Image = My.Resources.both
            date_day = date_day - 4
        End If
        If (date_day / 2) >= 1 And (date_day / 2) < 2 Then
            wrist_watch.PictureBox_2.Image = My.Resources.both
            date_day = date_day - 2
        End If
        If (date_day / 1) >= 1 And (date_day / 1) < 2 Then
            wrist_watch.PictureBox_1.Image = My.Resources.both
            date_day = date_day - 1
        End If
    End Sub

    WithEvents ani_timer As New Timer
    Public ani_ticks As Integer = 0
    Public Sub animation_stuff()
        With ani_timer
            .Enabled = True
            .Interval = 150
        End With
        ani_timer.Start()
    End Sub
    Private Sub ani_timer_tick() Handles ani_timer.Tick
        Select Case ani_ticks
            Case 1
                wrist_watch.PictureBox_AM.Image = My.Resources.red
                wrist_watch.PictureBox_32.Image = My.Resources.blue
                '
                wrist_watch.PictureBox_2_hr.Image = My.Resources.blue
                wrist_watch.PictureBox_2.Image = My.Resources.blue
            Case 2
                clear_all_boxes()
                wrist_watch.PictureBox_PM.Image = My.Resources.red
                wrist_watch.PictureBox_16.Image = My.Resources.blue
                '
                wrist_watch.PictureBox_4_hr.Image = My.Resources.blue
                wrist_watch.PictureBox_4.Image = My.Resources.blue
            Case 3
                clear_all_boxes()
                wrist_watch.PictureBox_8_hr.Image = My.Resources.both
                wrist_watch.PictureBox_8.Image = My.Resources.both
            Case 4
                clear_all_boxes()
                wrist_watch.PictureBox_4_hr.Image = My.Resources.red
                wrist_watch.PictureBox_4.Image = My.Resources.blue
                '
                wrist_watch.PictureBox_PM.Image = My.Resources.blue
                wrist_watch.PictureBox_16.Image = My.Resources.blue
            Case 5
                clear_all_boxes()
                wrist_watch.PictureBox_2_hr.Image = My.Resources.red
                wrist_watch.PictureBox_2.Image = My.Resources.blue
                '
                wrist_watch.PictureBox_AM.Image = My.Resources.blue
                wrist_watch.PictureBox_32.Image = My.Resources.blue
            Case 6
                clear_all_boxes()
                wrist_watch.PictureBox_1_hr.Image = My.Resources.red
                wrist_watch.PictureBox_1.Image = My.Resources.blue
                '
                wrist_watch.PictureBox_AM.Image = My.Resources.blue
                wrist_watch.PictureBox_32.Image = My.Resources.blue
            Case 7
                clear_all_boxes()
                wrist_watch.PictureBox_2_hr.Image = My.Resources.red
                wrist_watch.PictureBox_2.Image = My.Resources.blue
                '
                wrist_watch.PictureBox_PM.Image = My.Resources.blue
                wrist_watch.PictureBox_16.Image = My.Resources.blue
            Case 8
                clear_all_boxes()
                wrist_watch.PictureBox_4_hr.Image = My.Resources.red
                wrist_watch.PictureBox_4.Image = My.Resources.blue
                '
                wrist_watch.PictureBox_8_hr.Image = My.Resources.blue
                wrist_watch.PictureBox_8.Image = My.Resources.blue
            Case 9
                clear_all_boxes()
                wrist_watch.PictureBox_4_hr.Image = My.Resources.both
                wrist_watch.PictureBox_4.Image = My.Resources.both
            Case 10
                clear_all_boxes()
                wrist_watch.PictureBox_8_hr.Image = My.Resources.red
                wrist_watch.PictureBox_8.Image = My.Resources.blue
                '
                wrist_watch.PictureBox_2_hr.Image = My.Resources.blue
                wrist_watch.PictureBox_2.Image = My.Resources.blue
            Case 11
                clear_all_boxes()
                wrist_watch.PictureBox_PM.Image = My.Resources.red
                wrist_watch.PictureBox_16.Image = My.Resources.blue
                '
                wrist_watch.PictureBox_1_hr.Image = My.Resources.blue
                wrist_watch.PictureBox_1.Image = My.Resources.blue
            Case 12
                clear_all_boxes()
                ani_ticks = 0
                ani_timer.Stop()
                Select Case show_what
                    Case "time"
                        display_time()
                    Case "date"
                        display_date()
                End Select
        End Select
        ani_ticks += 1
    End Sub
End Module
