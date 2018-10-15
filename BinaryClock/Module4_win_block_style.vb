Imports System.Drawing
Module Module4_win_block_style
    Public number_pictures() = {My.Resources._0, My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9}
    '
    Public hour_boxes_1st() = {Nothing, win_block_style.PictureBox1, win_block_style.PictureBox2}
    Public hour_boxes_2nd() = {Nothing, win_block_style.PictureBox3, win_block_style.PictureBox4, Nothing, win_block_style.PictureBox5, Nothing, Nothing, Nothing, win_block_style.PictureBox6}
    '
    Public hour_minutes_1st() = {Nothing, win_block_style.PictureBox16, win_block_style.PictureBox15, Nothing, win_block_style.PictureBox17}
    Public hour_minutes_2nd() = {Nothing, win_block_style.PictureBox14, win_block_style.PictureBox13, Nothing, win_block_style.PictureBox12, Nothing, Nothing, Nothing, win_block_style.PictureBox11}
    '
    Public hour_seconds_1st() = {Nothing, win_block_style.PictureBox26, win_block_style.PictureBox25, Nothing, win_block_style.PictureBox18}
    Public hour_seconds_2nd() = {Nothing, win_block_style.PictureBox24, win_block_style.PictureBox23, Nothing, win_block_style.PictureBox22, Nothing, Nothing, Nothing, win_block_style.PictureBox21}
    Public Sub win_block_style_show_time()
        'clear_boxes
        For Each i In hour_boxes_1st
            If TypeOf i Is PictureBox Then
                i.Image = Nothing
            End If
        Next
        For Each i In hour_boxes_2nd
            If TypeOf i Is PictureBox Then
                i.Image = Nothing
            End If
        Next
        For Each i In hour_minutes_1st
            If TypeOf i Is PictureBox Then
                i.Image = Nothing
            End If
        Next
        For Each i In hour_minutes_2nd
            If TypeOf i Is PictureBox Then
                i.Image = Nothing
            End If
        Next
        For Each i In hour_seconds_1st
            If TypeOf i Is PictureBox Then
                i.Image = Nothing
            End If
        Next
        For Each i In hour_seconds_2nd
            If TypeOf i Is PictureBox Then
                i.Image = Nothing
            End If
        Next

        'hours
        Dim i_hour = Date.Now.Hour
        If i_hour = 0 Then
            hour_boxes_1st(1).Image = Nothing
            hour_boxes_1st(2).Image = Nothing
            hour_boxes_2nd(1).Image = Nothing
            hour_boxes_2nd(2).Image = Nothing
            hour_boxes_2nd(4).Image = Nothing
            hour_boxes_2nd(8).Image = Nothing
        Else
            If i_hour.ToString.Length >= 2 Then
                ''first digit
                Dim h_1nd_digit = i_hour.ToString.Substring(0, 1)

                If (h_1nd_digit / 8) >= 1 And (h_1nd_digit / 8) < 2 Then
                    hour_boxes_1st(8).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 8
                End If
                If (h_1nd_digit / 4) >= 1 And (h_1nd_digit / 4) < 2 Then
                    hour_boxes_1st(4).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 4
                End If
                If (h_1nd_digit / 2) >= 1 And (h_1nd_digit / 2) < 2 Then
                    hour_boxes_1st(2).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 2
                End If
                If (h_1nd_digit / 1) >= 1 And (h_1nd_digit / 1) < 2 Then
                    hour_boxes_1st(1).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 1
                End If
                ''second digit
                Dim h_2nd_digit = i_hour.ToString.Substring(1, 1)

                If (h_2nd_digit / 8) >= 1 And (h_2nd_digit / 8) < 2 Then
                    hour_boxes_2nd(8).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 8
                End If
                If (h_2nd_digit / 4) >= 1 And (h_2nd_digit / 4) < 2 Then
                    hour_boxes_2nd(4).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 4
                End If
                If (h_2nd_digit / 2) >= 1 And (h_2nd_digit / 2) < 2 Then
                    hour_boxes_2nd(2).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 2
                End If
                If (h_2nd_digit / 1) >= 1 And (h_2nd_digit / 1) < 2 Then
                    hour_boxes_2nd(1).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 1
                End If
            Else
                ''first digit
                Dim h_1nd_digit = 0

                If (h_1nd_digit / 8) >= 1 And (h_1nd_digit / 8) < 2 Then
                    hour_boxes_1st(8).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 8
                End If
                If (h_1nd_digit / 4) >= 1 And (h_1nd_digit / 4) < 2 Then
                    hour_boxes_1st(4).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 4
                End If
                If (h_1nd_digit / 2) >= 1 And (h_1nd_digit / 2) < 2 Then
                    hour_boxes_1st(2).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 2
                End If
                If (h_1nd_digit / 1) >= 1 And (h_1nd_digit / 1) < 2 Then
                    hour_boxes_1st(1).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 1
                End If
                ''second digit
                Dim h_2nd_digit = i_hour.ToString.Substring(0, 1)

                If (h_2nd_digit / 8) >= 1 And (h_2nd_digit / 8) < 2 Then
                    hour_boxes_2nd(8).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 8
                    Debug.Print("8")
                End If
                If (h_2nd_digit / 4) >= 1 And (h_2nd_digit / 4) < 2 Then
                    hour_boxes_2nd(4).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 4
                End If
                If (h_2nd_digit / 2) >= 1 And (h_2nd_digit / 2) < 2 Then
                    hour_boxes_2nd(2).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 2
                End If
                If (h_2nd_digit / 1) >= 1 And (h_2nd_digit / 1) < 2 Then
                    hour_boxes_2nd(1).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 1
                End If
            End If
        End If




        'minutes
        Dim i_mins = Date.Now.Minute
        If i_mins = 0 Then
            hour_minutes_1st(1).Image = Nothing
            hour_minutes_1st(2).Image = Nothing
            hour_minutes_1st(4).Image = Nothing
            hour_minutes_2nd(1).Image = Nothing
            hour_minutes_2nd(2).Image = Nothing
            hour_minutes_2nd(4).Image = Nothing
            hour_minutes_2nd(8).Image = Nothing
        Else
            If i_mins.ToString.Length >= 2 Then
                ''first digit
                Dim m_1st_digit = i_mins.ToString.Substring(0, 1)

                If (m_1st_digit / 8) >= 1 And (m_1st_digit / 8) < 2 Then
                    hour_minutes_1st(8).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 8
                End If
                If (m_1st_digit / 4) >= 1 And (m_1st_digit / 4) < 2 Then
                    hour_minutes_1st(4).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 4
                End If
                If (m_1st_digit / 2) >= 1 And (m_1st_digit / 2) < 2 Then
                    hour_minutes_1st(2).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 2
                End If
                If (m_1st_digit / 1) >= 1 And (m_1st_digit / 1) < 2 Then
                    hour_minutes_1st(1).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 1
                End If
                ''second digit
                Dim m_2nd_digit = i_mins.ToString.Substring(1, 1)

                If (m_2nd_digit / 8) >= 1 And (m_2nd_digit / 8) < 2 Then
                    hour_minutes_2nd(8).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 8
                End If
                If (m_2nd_digit / 4) >= 1 And (m_2nd_digit / 4) < 2 Then
                    hour_minutes_2nd(4).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 4
                End If
                If (m_2nd_digit / 2) >= 1 And (m_2nd_digit / 2) < 2 Then
                    hour_minutes_2nd(2).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 2
                End If
                If (m_2nd_digit / 1) >= 1 And (m_2nd_digit / 1) < 2 Then
                    hour_minutes_2nd(1).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 1
                End If
            Else
                ''first digit
                Dim m_1st_digit = 0

                If (m_1st_digit / 8) >= 1 And (m_1st_digit / 8) < 2 Then
                    hour_minutes_1st(8).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 8
                End If
                If (m_1st_digit / 4) >= 1 And (m_1st_digit / 4) < 2 Then
                    hour_minutes_1st(4).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 4
                End If
                If (m_1st_digit / 2) >= 1 And (m_1st_digit / 2) < 2 Then
                    hour_minutes_1st(2).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 2
                End If
                If (m_1st_digit / 1) >= 1 And (m_1st_digit / 1) < 2 Then
                    hour_minutes_1st(1).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 1
                End If
                ''second digit
                Dim m_2nd_digit = i_mins.ToString.Substring(0, 1)

                If (m_2nd_digit / 8) >= 1 And (m_2nd_digit / 8) < 2 Then
                    hour_minutes_2nd(8).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 8
                End If
                If (m_2nd_digit / 4) >= 1 And (m_2nd_digit / 4) < 2 Then
                    hour_minutes_2nd(4).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 4
                End If
                If (m_2nd_digit / 2) >= 1 And (m_2nd_digit / 2) < 2 Then
                    hour_minutes_2nd(2).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 2
                End If
                If (m_2nd_digit / 1) >= 1 And (m_2nd_digit / 1) < 2 Then
                    hour_minutes_2nd(1).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 1
                End If
            End If
        End If


        'seconds
        Dim i_secs = Date.Now.Second
        If i_secs = 0 Then
            hour_seconds_1st(1).Image = Nothing
            hour_seconds_1st(2).Image = Nothing
            hour_seconds_1st(4).Image = Nothing
            hour_seconds_2nd(1).Image = Nothing
            hour_seconds_2nd(2).Image = Nothing
            hour_seconds_2nd(4).Image = Nothing
            hour_seconds_2nd(8).Image = Nothing
        Else
            If i_secs.ToString.Length >= 2 Then

                ''first digit
                Dim s_1st_digit = i_secs.ToString.Substring(0, 1)

                If (s_1st_digit / 8) >= 1 And (s_1st_digit / 8) < 2 Then
                    hour_seconds_1st(8).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 8
                End If
                If (s_1st_digit / 4) >= 1 And (s_1st_digit / 4) < 2 Then
                    hour_seconds_1st(4).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 4
                End If
                If (s_1st_digit / 2) >= 1 And (s_1st_digit / 2) < 2 Then
                    hour_seconds_1st(2).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 2
                End If
                If (s_1st_digit / 1) >= 1 And (s_1st_digit / 1) < 2 Then
                    hour_seconds_1st(1).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 1
                End If
                ''second digit
                Dim s_2nd_digit = i_secs.ToString.Substring(1, 1)

                If (s_2nd_digit / 8) >= 1 And (s_2nd_digit / 8) < 2 Then
                    hour_seconds_2nd(8).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 8
                End If
                If (s_2nd_digit / 4) >= 1 And (s_2nd_digit / 4) < 2 Then
                    hour_seconds_2nd(4).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 4
                End If
                If (s_2nd_digit / 2) >= 1 And (s_2nd_digit / 2) < 2 Then
                    hour_seconds_2nd(2).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 2
                End If
                If (s_2nd_digit / 1) >= 1 And (s_2nd_digit / 1) < 2 Then
                    hour_seconds_2nd(1).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 1
                End If
            Else
                ''first digit
                Dim s_1st_digit = 0

                If (s_1st_digit / 8) >= 1 And (s_1st_digit / 8) < 2 Then
                    hour_seconds_1st(8).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 8
                End If
                If (s_1st_digit / 4) >= 1 And (s_1st_digit / 4) < 2 Then
                    hour_seconds_1st(4).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 4
                End If
                If (s_1st_digit / 2) >= 1 And (s_1st_digit / 2) < 2 Then
                    hour_seconds_1st(2).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 2
                End If
                If (s_1st_digit / 1) >= 1 And (s_1st_digit / 1) < 2 Then
                    hour_seconds_1st(1).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 1
                End If
                ''second digit
                Dim s_2nd_digit = i_secs.ToString.Substring(0, 1)

                If (s_2nd_digit / 8) >= 1 And (s_2nd_digit / 8) < 2 Then
                    hour_seconds_2nd(8).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 8
                End If
                If (s_2nd_digit / 4) >= 1 And (s_2nd_digit / 4) < 2 Then
                    hour_seconds_2nd(4).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 4
                End If
                If (s_2nd_digit / 2) >= 1 And (s_2nd_digit / 2) < 2 Then
                    hour_seconds_2nd(2).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 2
                End If
                If (s_2nd_digit / 1) >= 1 And (s_2nd_digit / 1) < 2 Then
                    hour_seconds_2nd(1).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 1
                End If
            End If
        End If

    End Sub

    Public Sub win_block_style_show_time_with_zeroes()
        'clear_boxes
        For Each i In hour_boxes_1st
            If TypeOf i Is PictureBox Then
                i.Image = My.Resources.block_style_0
            End If
        Next
        For Each i In hour_boxes_2nd
            If TypeOf i Is PictureBox Then
                i.Image = My.Resources.block_style_0
            End If
        Next
        For Each i In hour_minutes_1st
            If TypeOf i Is PictureBox Then
                i.Image = My.Resources.block_style_0
            End If
        Next
        For Each i In hour_minutes_2nd
            If TypeOf i Is PictureBox Then
                i.Image = My.Resources.block_style_0
            End If
        Next
        For Each i In hour_seconds_1st
            If TypeOf i Is PictureBox Then
                i.Image = My.Resources.block_style_0
            End If
        Next
        For Each i In hour_seconds_2nd
            If TypeOf i Is PictureBox Then
                i.Image = My.Resources.block_style_0
            End If
        Next

        'hours
        Dim i_hour = Date.Now.Hour
        If i_hour = 0 Then
            hour_boxes_1st(1).Image = My.Resources.block_style_0
            hour_boxes_1st(2).Image = My.Resources.block_style_0
            hour_boxes_2nd(1).Image = My.Resources.block_style_0
            hour_boxes_2nd(2).Image = My.Resources.block_style_0
            hour_boxes_2nd(4).Image = My.Resources.block_style_0
            hour_boxes_2nd(8).Image = My.Resources.block_style_0
        Else
            If i_hour.ToString.Length >= 2 Then
                ''first digit
                Dim h_1nd_digit = i_hour.ToString.Substring(0, 1)

                If (h_1nd_digit / 8) >= 1 And (h_1nd_digit / 8) < 2 Then
                    hour_boxes_1st(8).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 8
                End If
                If (h_1nd_digit / 4) >= 1 And (h_1nd_digit / 4) < 2 Then
                    hour_boxes_1st(4).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 4
                End If
                If (h_1nd_digit / 2) >= 1 And (h_1nd_digit / 2) < 2 Then
                    hour_boxes_1st(2).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 2
                End If
                If (h_1nd_digit / 1) >= 1 And (h_1nd_digit / 1) < 2 Then
                    hour_boxes_1st(1).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 1
                End If
                ''second digit
                Dim h_2nd_digit = i_hour.ToString.Substring(1, 1)

                If (h_2nd_digit / 8) >= 1 And (h_2nd_digit / 8) < 2 Then
                    hour_boxes_2nd(8).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 8
                End If
                If (h_2nd_digit / 4) >= 1 And (h_2nd_digit / 4) < 2 Then
                    hour_boxes_2nd(4).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 4
                End If
                If (h_2nd_digit / 2) >= 1 And (h_2nd_digit / 2) < 2 Then
                    hour_boxes_2nd(2).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 2
                End If
                If (h_2nd_digit / 1) >= 1 And (h_2nd_digit / 1) < 2 Then
                    hour_boxes_2nd(1).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 1
                End If
            Else
                ''first digit
                Dim h_1nd_digit = 0

                If (h_1nd_digit / 8) >= 1 And (h_1nd_digit / 8) < 2 Then
                    hour_boxes_1st(8).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 8
                End If
                If (h_1nd_digit / 4) >= 1 And (h_1nd_digit / 4) < 2 Then
                    hour_boxes_1st(4).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 4
                End If
                If (h_1nd_digit / 2) >= 1 And (h_1nd_digit / 2) < 2 Then
                    hour_boxes_1st(2).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 2
                End If
                If (h_1nd_digit / 1) >= 1 And (h_1nd_digit / 1) < 2 Then
                    hour_boxes_1st(1).Image = My.Resources.block_style
                    h_1nd_digit = h_1nd_digit - 1
                End If
                ''second digit
                Dim h_2nd_digit = i_hour.ToString.Substring(0, 1)

                If (h_2nd_digit / 8) >= 1 And (h_2nd_digit / 8) < 2 Then
                    hour_boxes_2nd(8).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 8
                    Debug.Print("8")
                End If
                If (h_2nd_digit / 4) >= 1 And (h_2nd_digit / 4) < 2 Then
                    hour_boxes_2nd(4).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 4
                End If
                If (h_2nd_digit / 2) >= 1 And (h_2nd_digit / 2) < 2 Then
                    hour_boxes_2nd(2).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 2
                End If
                If (h_2nd_digit / 1) >= 1 And (h_2nd_digit / 1) < 2 Then
                    hour_boxes_2nd(1).Image = My.Resources.block_style
                    h_2nd_digit = h_2nd_digit - 1
                End If
            End If
        End If




        'minutes
        Dim i_mins = Date.Now.Minute
        If i_mins = 0 Then
            hour_minutes_1st(1).Image = My.Resources.block_style_0
            hour_minutes_1st(2).Image = My.Resources.block_style_0
            hour_minutes_1st(4).Image = My.Resources.block_style_0
            hour_minutes_2nd(1).Image = My.Resources.block_style_0
            hour_minutes_2nd(2).Image = My.Resources.block_style_0
            hour_minutes_2nd(4).Image = My.Resources.block_style_0
            hour_minutes_2nd(8).Image = My.Resources.block_style_0
        Else
            If i_mins.ToString.Length >= 2 Then
                ''first digit
                Dim m_1st_digit = i_mins.ToString.Substring(0, 1)

                If (m_1st_digit / 8) >= 1 And (m_1st_digit / 8) < 2 Then
                    hour_minutes_1st(8).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 8
                End If
                If (m_1st_digit / 4) >= 1 And (m_1st_digit / 4) < 2 Then
                    hour_minutes_1st(4).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 4
                End If
                If (m_1st_digit / 2) >= 1 And (m_1st_digit / 2) < 2 Then
                    hour_minutes_1st(2).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 2
                End If
                If (m_1st_digit / 1) >= 1 And (m_1st_digit / 1) < 2 Then
                    hour_minutes_1st(1).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 1
                End If
                ''second digit
                Dim m_2nd_digit = i_mins.ToString.Substring(1, 1)

                If (m_2nd_digit / 8) >= 1 And (m_2nd_digit / 8) < 2 Then
                    hour_minutes_2nd(8).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 8
                End If
                If (m_2nd_digit / 4) >= 1 And (m_2nd_digit / 4) < 2 Then
                    hour_minutes_2nd(4).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 4
                End If
                If (m_2nd_digit / 2) >= 1 And (m_2nd_digit / 2) < 2 Then
                    hour_minutes_2nd(2).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 2
                End If
                If (m_2nd_digit / 1) >= 1 And (m_2nd_digit / 1) < 2 Then
                    hour_minutes_2nd(1).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 1
                End If
            Else
                ''first digit
                Dim m_1st_digit = 0

                If (m_1st_digit / 8) >= 1 And (m_1st_digit / 8) < 2 Then
                    hour_minutes_1st(8).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 8
                End If
                If (m_1st_digit / 4) >= 1 And (m_1st_digit / 4) < 2 Then
                    hour_minutes_1st(4).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 4
                End If
                If (m_1st_digit / 2) >= 1 And (m_1st_digit / 2) < 2 Then
                    hour_minutes_1st(2).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 2
                End If
                If (m_1st_digit / 1) >= 1 And (m_1st_digit / 1) < 2 Then
                    hour_minutes_1st(1).Image = My.Resources.block_style
                    m_1st_digit = m_1st_digit - 1
                End If
                ''second digit
                Dim m_2nd_digit = i_mins.ToString.Substring(0, 1)

                If (m_2nd_digit / 8) >= 1 And (m_2nd_digit / 8) < 2 Then
                    hour_minutes_2nd(8).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 8
                End If
                If (m_2nd_digit / 4) >= 1 And (m_2nd_digit / 4) < 2 Then
                    hour_minutes_2nd(4).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 4
                End If
                If (m_2nd_digit / 2) >= 1 And (m_2nd_digit / 2) < 2 Then
                    hour_minutes_2nd(2).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 2
                End If
                If (m_2nd_digit / 1) >= 1 And (m_2nd_digit / 1) < 2 Then
                    hour_minutes_2nd(1).Image = My.Resources.block_style
                    m_2nd_digit = m_2nd_digit - 1
                End If
            End If
        End If


        'seconds
        Dim i_secs = Date.Now.Second
        If i_secs = 0 Then
            hour_seconds_1st(1).Image = My.Resources.block_style_0
            hour_seconds_1st(2).Image = My.Resources.block_style_0
            hour_seconds_1st(4).Image = My.Resources.block_style_0
            hour_seconds_2nd(1).Image = My.Resources.block_style_0
            hour_seconds_2nd(2).Image = My.Resources.block_style_0
            hour_seconds_2nd(4).Image = My.Resources.block_style_0
            hour_seconds_2nd(8).Image = My.Resources.block_style_0
        Else
            If i_secs.ToString.Length >= 2 Then

                ''first digit
                Dim s_1st_digit = i_secs.ToString.Substring(0, 1)

                If (s_1st_digit / 8) >= 1 And (s_1st_digit / 8) < 2 Then
                    hour_seconds_1st(8).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 8
                End If
                If (s_1st_digit / 4) >= 1 And (s_1st_digit / 4) < 2 Then
                    hour_seconds_1st(4).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 4
                End If
                If (s_1st_digit / 2) >= 1 And (s_1st_digit / 2) < 2 Then
                    hour_seconds_1st(2).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 2
                End If
                If (s_1st_digit / 1) >= 1 And (s_1st_digit / 1) < 2 Then
                    hour_seconds_1st(1).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 1
                End If
                ''second digit
                Dim s_2nd_digit = i_secs.ToString.Substring(1, 1)

                If (s_2nd_digit / 8) >= 1 And (s_2nd_digit / 8) < 2 Then
                    hour_seconds_2nd(8).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 8
                End If
                If (s_2nd_digit / 4) >= 1 And (s_2nd_digit / 4) < 2 Then
                    hour_seconds_2nd(4).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 4
                End If
                If (s_2nd_digit / 2) >= 1 And (s_2nd_digit / 2) < 2 Then
                    hour_seconds_2nd(2).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 2
                End If
                If (s_2nd_digit / 1) >= 1 And (s_2nd_digit / 1) < 2 Then
                    hour_seconds_2nd(1).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 1
                End If
            Else
                ''first digit
                Dim s_1st_digit = 0

                If (s_1st_digit / 8) >= 1 And (s_1st_digit / 8) < 2 Then
                    hour_seconds_1st(8).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 8
                End If
                If (s_1st_digit / 4) >= 1 And (s_1st_digit / 4) < 2 Then
                    hour_seconds_1st(4).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 4
                End If
                If (s_1st_digit / 2) >= 1 And (s_1st_digit / 2) < 2 Then
                    hour_seconds_1st(2).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 2
                End If
                If (s_1st_digit / 1) >= 1 And (s_1st_digit / 1) < 2 Then
                    hour_seconds_1st(1).Image = My.Resources.block_style
                    s_1st_digit = s_1st_digit - 1
                End If
                ''second digit
                Dim s_2nd_digit = i_secs.ToString.Substring(0, 1)

                If (s_2nd_digit / 8) >= 1 And (s_2nd_digit / 8) < 2 Then
                    hour_seconds_2nd(8).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 8
                End If
                If (s_2nd_digit / 4) >= 1 And (s_2nd_digit / 4) < 2 Then
                    hour_seconds_2nd(4).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 4
                End If
                If (s_2nd_digit / 2) >= 1 And (s_2nd_digit / 2) < 2 Then
                    hour_seconds_2nd(2).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 2
                End If
                If (s_2nd_digit / 1) >= 1 And (s_2nd_digit / 1) < 2 Then
                    hour_seconds_2nd(1).Image = My.Resources.block_style
                    s_2nd_digit = s_2nd_digit - 1
                End If
            End If
        End If

    End Sub

End Module
