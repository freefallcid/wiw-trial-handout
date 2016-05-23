Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'comboPeriod.SelectedItem = "2 weeks (default)"
        dateCalendar.TodayDate = Now
        comboCutoff.SelectedItem = "no"
    End Sub


    Private Sub buttonGenerateText_Click(sender As Object, e As EventArgs) Handles buttonGenerateText.Click
        If txtNickname.Text = Nothing Then
            MsgBox("You must submit a username!", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf dateCalendar.SelectionRange.End = Nothing Then
            MsgBox("You must select a valid trial period!", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf comboCutoff.Text = Nothing Then
            MsgBox("You must provide a valid cutoff time!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        frmResult.Show()
        'Me.Hide()

        Dim sNickname As String = txtNickname.Text
        Dim sCutoff As String = comboCutoff.SelectedItem
        Dim sWeek As String = ""
        If lblWeeks.Text = "(need update)" Then
            sWeek = lblPeriod.Text
        Else
            sWeek = lblWeeks.Text
        End If
        Dim sPeriodDays As String = lblPeriod.Text
        Dim sPeriodFrom As String = lblPeriod2.Text

        ' den ganzen text einfügen mit den neuen variablen
        frmResult.TextBox1.Text = ""
        frmResult.TextBox1.AppendText("Hi there " + sNickname + "!" + vbNewLine + vbNewLine)
        frmResult.TextBox1.AppendText("You are now officially on a " + sWeek + " trial starting on " + Format(dateCalendar.SelectionRange.Start, "dd.MM.yyyy") + " (Expected end date: " + Format(dateCalendar.SelectionRange.End, "dd.MM.yyyy") + ")." + vbNewLine)
        frmResult.TextBox1.AppendText("It is time for you to put on your WiWR (mind the R<--) tags." + vbNewLine)
        frmResult.TextBox1.AppendText("During this " + sWeek + " week trial we, the recruitment team, expect you to stay active in both our forum and server." + vbNewLine)

        Dim datePeriod As Long = DateDiff(DateInterval.Day, dateCalendar.SelectionRange.Start, dateCalendar.SelectionRange.End)
        If datePeriod > 10 Then
            Dim dateWeeks As Long = datePeriod / 7
            If sCutoff = "yes" Then
                Dim iCutoff As Integer = Int(dateWeeks) - 1
                frmResult.TextBox1.AppendText("Note: being an active soldier might result in having your trial cut by 1 week, meaning your trial ends after " + iCutoff.ToString + " week(s)." + vbNewLine)
            End If
            'Else
            '    If sCutoff = "yes" Then
            'MsgBox("Cutoff not possible!" + vbNewLine + "Not enough days.", MsgBoxStyle.Information)
            'On Error Resume Next
            'End If
        End If
        frmResult.TextBox1.AppendText("If for some reason you are away during your trial please let us know (for example work, holidays or school)." + vbNewLine + vbNewLine)
        frmResult.TextBox1.AppendText("You also have to apply for this platoon: http://battlelog.battlefield.com/bf3/platoon/2832655391843860729/" + vbNewLine + "Its the official recruitment platoon." + vbNewLine + vbNewLine)
        frmResult.TextBox1.AppendText("Good luck on the trial, greetings" + vbNewLine + vbNewLine + "Recruitment team" + vbNewLine + vbNewLine + vbNewLine)
        frmResult.TextBox1.AppendText("If for some reason you have any questions/problems feel free to ask them here, in the Recruits+ forum, on battlelog, on Teamspeak or on X-Fire!" + vbNewLine)
        frmResult.TextBox1.AppendText("The Recruits+ forum is only visible to Recruits and clan members. No public visitor will ever see that section." + vbNewLine + vbNewLine)
        frmResult.TextBox1.AppendText("Recruits+: http://www.wakeislandwarriors.com/forum/viewforum.php?f=27" + vbNewLine + "X-Fire: http://www.wakeislandwarriors.com/forum/viewtopic.php?f=3&t=26" + vbNewLine + "TS3: http://www.wakeislandwarriors.com/forum/viewtopic.php?f=3&t=363" + vbNewLine + vbNewLine + "Good luck!")
        Me.Close()
    End Sub

    Private Sub buttonResetForm_Click(sender As Object, e As EventArgs) Handles buttonResetForm.Click
        txtNickname.Text = Nothing
        dateCalendar.TodayDate = Now
        comboCutoff.SelectedItem = "no"
    End Sub

    Private Sub dateCalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles dateCalendar.DateChanged
        Dim datePeriod As Long = DateDiff(DateInterval.Day, dateCalendar.SelectionRange.Start, dateCalendar.SelectionRange.End)
        lblPeriod.Text = datePeriod & " day(s)"
        If datePeriod > 0 Then
            Dim dateWeeks As Long = datePeriod / 7
            If dateWeeks > 0 Then
                lblWeeks.Text = dateWeeks & " week(s)"
            End If
        End If
        lblPeriod2.Text = Format(dateCalendar.SelectionRange.Start, "dd.MM.yyyy") & " - " & Format(dateCalendar.SelectionRange.End, "dd.MM.yyyy")

        'Generate Button Freigabe
        buttonGenerateText.Enabled = True
        buttonGenerateText.Text = "Generate Text"
    End Sub

    Private Sub linkBugreport_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkBugreport.LinkClicked
        ' http://dotnet-snippets.de/dns/c-webseite-mit-standartbrowser-oeffnen-SID919.aspx
        On Error GoTo ShowError
        'Select Case MessageBox.Show("You will now be taken to the Wake Island Warriors website" & vbNewLine & "to send me a private message." & vbNewLine & "Please use a crucial subject line!" & vbNewLine & vbNewLine & "Please also note, the more information I get about an error," & vbNewLine & "the easier it will be to fix it.", "You are beeing forwarded", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        '    Case Windows.Forms.DialogResult.Cancel
        '       Exit Sub
        'End Select
        System.Diagnostics.Process.Start("http://klamm.io")
        linkBugreport.LinkVisited = True
        Exit Sub
ShowError:
        MessageBox.Show(Err.Description, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class