Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Me.Location = New Point(0, 0)
        'Me.Size = SystemInformation.PrimaryMonitorSize
        If numPlayers.Value >= 2 Then
            btnStart.Enabled = True
        End If
        btnStart.Focus()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub numPlayers_ValueChanged(sender As Object, e As EventArgs) Handles numPlayers.ValueChanged
        If numPlayers.Value < 2 Then
            MsgBox("You have to at least have 2 players! You can't play by yourself you know!")
            numPlayers.Value = 2
        ElseIf numPlayers.Value > 4 Then
            MsgBox("No more than 4 Players!")
            numPlayers.Value = 4
        Else
            btnStart.Enabled = True
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Yahtzee(GetNames)
        If ReadytoGO Then
            MainForm.Show()
        End If
    End Sub
End Class
