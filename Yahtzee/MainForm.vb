
Public Class MainForm
    
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each stopScoreIt In StopScore
            Dim whichScore As Integer
            whichScore += 1
            StopScore(whichScore - 1) = True
        Next
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize
        Me.CenterToScreen()
        FinalScoresUpdater.Enabled = True
        If Form1.Visible Then
            If Me.Visible Then
                Form1.Hide()
                If Form1.numPlayers.Value = 4 Then
                    lblName4.Show()
                    lblName4.Text = PlayerName(3)
                End If
            End If
        End If
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        ScoreTimer.Enabled = False
        If Not Ready Then
            Ready = True
        End If
        Dim GetDice As String = "GetDice"
        Select Case AllowedCount
            Case 0
                gboScores.Enabled = True
                If CurrentPlayer = Turn Then
                    playerRound(CurrentPlayer) = 1
                End If
                'Allows for recalling of scores
                For Each checkPlayer In playerRound
                    If Turn > CurrentPlayer * playerRound(checkPlayer + 1) Then
                        Yahtzee("RefreshScores")
                    End If
                Next
                If StopScore(0) = False Then
                    lblAces.Text = PlayerScore(CurrentPlayer, 1)
                    lblAces.Enabled = False
                End If
                If StopScore(1) = False Then
                    lblTwos.Text = PlayerScore(CurrentPlayer, 2)
                End If
                If StopScore(2) = False Then
                    lblThrees.Text = PlayerScore(CurrentPlayer, 3)
                End If
                If StopScore(3) = False Then
                    lblFours.Text = PlayerScore(CurrentPlayer, 4)
                End If
                If StopScore(4) = False Then
                    lblFives.Text = PlayerScore(CurrentPlayer, 5)
                End If
                If StopScore(5) = False Then
                    lblSixes.Text = PlayerScore(CurrentPlayer, 6)
                End If
                If StopScore(6) = False Then
                    lbl3Kind.Text = PlayerScore(CurrentPlayer, 7)
                End If
                If StopScore(7) = False Then
                    lbl4Kind.Text = PlayerScore(CurrentPlayer, 8)
                End If
                If StopScore(8) = False Then
                    lblFull.Text = PlayerScore(CurrentPlayer, 9)
                End If
                If StopScore(9) = False Then
                    lblSmStraight.Text = PlayerScore(CurrentPlayer, 10)
                End If
                If StopScore(10) = False Then
                    lblLgStraight.Text = PlayerScore(CurrentPlayer, 11)
                End If
                If StopScore(11) = False Then
                    lblChance.Text = PlayerScore(CurrentPlayer, 12)
                End If
                If StopScore(12) = False Then
                    lblYahtzee.Text = PlayerScore(CurrentPlayer, 13)
                End If
                Yahtzee(GetDice)
                AllowedCount += 1
                Select Case AllowedCount
                    Case 0 To 2
                        lblAces.Enabled = True
                        lblTwos.Enabled = True
                        lblThrees.Enabled = True
                        lblFours.Enabled = True
                        lblFives.Enabled = True
                        lblSixes.Enabled = True
                        lbl3Kind.Enabled = True
                        lbl4Kind.Enabled = True
                        lblFull.Enabled = True
                        lblSmStraight.Enabled = True
                        lblLgStraight.Enabled = True
                        lblChance.Enabled = True
                        lblYahtzee.Enabled = True
                        btnRoll.Text = "Roll"
                        For X = 0 To 12
                            StopScore(X) = False
                        Next
                End Select
            Case 1
                Yahtzee(GetDice)
                AllowedCount += 1
            Case 2
                Yahtzee(GetDice)
                AllowedCount += 1
            Case 3
                Yahtzee("NextPlayer")
                AllowedCount = 0
                CurrentPlayer += 1
                If Form1.numPlayers.Value < CurrentPlayer Then
                    CurrentPlayer = 1
                End If
                btnRoll.Text = "Next Player"
                'Creates next turn
                Turn = Turn + 1
                playerRound(CurrentPlayer) /= Turn
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    ''' <summary>
    ''' Checking for Clicked
    ''' </summary>
    ''' <param name="finishPlayer">Write isClicked(True, Category) to finish move </param>
    ''' <param name="CategoryI">The category of the current score</param>
    ''' <remarks></remarks>
    Sub isClicked(finishPlayer As Boolean, CategoryI As Integer)
        If Not Clicked(CategoryI - 1) Then
            Yahtzee("GetTypes")
        End If
        If finishPlayer Then
            Yahtzee("finishMove")
        End If
    End Sub
    Private Sub lblAces_MouseHover(sender As Object, e As EventArgs) Handles lblAces.MouseHover
        Category = 1
        isClicked(False, Category)
        If lblAces.Text = ScoreTypes(0) Then
            lblAces.Text = 0
        End If
    End Sub

    Private Sub lblTwos_MouseHover(sender As Object, e As EventArgs) Handles lblTwos.MouseHover
        Category = 2
        isClicked(False, Category)
        If lblTwos.Text = ScoreTypes(1) Then
            lblTwos.Text = 0
        End If
    End Sub

    Private Sub lblThrees_MouseHover(sender As Object, e As EventArgs) Handles lblThrees.MouseHover
        Category = 3
        isClicked(False, Category)
        If lblThrees.Text = ScoreTypes(2) Then
            lblThrees.Text = 0
        End If
    End Sub

    Private Sub lblFours_MouseHover(sender As Object, e As EventArgs) Handles lblFours.MouseHover
        Category = 4
        isClicked(False, Category)
        If lblFours.Text = ScoreTypes(3) Then
            lblFours.Text = 0
        End If
    End Sub
    Private Sub lblFives_MouseHover(sender As Object, e As EventArgs) Handles lblFives.MouseHover
        Category = 5
        isClicked(False, Category)
        If lblFives.Text = ScoreTypes(4) Then
            lblFives.Text = 0
        End If
    End Sub

    Private Sub lblSixes_MouseHover(sender As Object, e As EventArgs) Handles lblSixes.MouseHover
        Category = 6
        isClicked(False, Category)
        If lblSixes.Text = ScoreTypes(5) Then
            lblSixes.Text = 0
        End If
    End Sub

    Private Sub lbl3Kind_MouseHover(sender As Object, e As EventArgs) Handles lbl3Kind.MouseHover
        Category = 7
        isClicked(False, Category)
        If lbl3Kind.Text = ScoreTypes(6) Then
            lbl3Kind.Text = 0
        End If
    End Sub


    Private Sub Label9_MouseHover(sender As Object, e As EventArgs) Handles lbl4Kind.MouseHover
        Category = 8
        isClicked(False, Category)
        If lbl4Kind.Text = ScoreTypes(7) Then
            lbl4Kind.Text = 0
        End If
    End Sub

    Private Sub lblFull_MouseHover1(sender As Object, e As EventArgs) Handles lblFull.MouseHover
        Category = 9
        isClicked(False, Category)
        If lblFull.Text = ScoreTypes(8) Then
            lblFull.Text = 0
        End If
    End Sub


    Private Sub lblSmStraight_MouseHover(sender As Object, e As EventArgs) Handles lblSmStraight.MouseHover
        Category = 10
        isClicked(False, Category)
        If lblSmStraight.Text = ScoreTypes(9) Then
            lblSmStraight.Text = 0
        End If
    End Sub

    Private Sub lblLgStraight_MouseHover(sender As Object, e As EventArgs) Handles lblLgStraight.MouseHover
        Category = 11
        isClicked(False, Category)
        If lblLgStraight.Text = ScoreTypes(10) Then
            lblLgStraight.Text = 0
        End If
    End Sub

    Private Sub lblChance_MouseHover(sender As Object, e As EventArgs) Handles lblChance.MouseHover
        Category = 12
        isClicked(False, Category)
    End Sub


    Private Sub lblLgStraight_MouseLeave(sender As Object, e As EventArgs) Handles lblLgStraight.MouseLeave
        If Not Clicked(10) Then
            lblLgStraight.Text = ScoreTypes(10)
        End If
    End Sub

    Private Sub lblSmStraight_MouseLeave(sender As Object, e As EventArgs) Handles lblSmStraight.MouseLeave
        If Not Clicked(9) Then
            lblSmStraight.Text = ScoreTypes(9)
        End If
    End Sub


    Private Sub lblChance_MouseLeave(sender As Object, e As EventArgs) Handles lblChance.MouseLeave
        If Not Clicked(11) Then
            lblChance.Text = ScoreTypes(12)
        End If
    End Sub

    Private Sub lblFull_MouseLeave(sender As Object, e As EventArgs) Handles lblFull.MouseLeave
        If Not Clicked(8) Then
            lblFull.Text = ScoreTypes(8)
        End If
    End Sub

    Private Sub lbl4Kind_MouseLeave(sender As Object, e As EventArgs) Handles lbl4Kind.MouseLeave
        If Not Clicked(7) Then
            lbl4Kind.Text = ScoreTypes(7)
        End If
    End Sub

    Private Sub lbl3Kind_MouseLeave(sender As Object, e As EventArgs) Handles lbl3Kind.MouseLeave
        If Not Clicked(6) Then
            lbl3Kind.Text = ScoreTypes(6)
        End If
    End Sub


    Private Sub lblAces_MouseLeave(sender As Object, e As EventArgs) Handles lblAces.MouseLeave
        If Not Clicked(0) Then
            lblAces.Text = ScoreTypes(0)
        End If
    End Sub

    Private Sub lblTwos_MouseLeave(sender As Object, e As EventArgs) Handles lblTwos.MouseLeave
        If Not Clicked(1) Then
            lblTwos.Text = ScoreTypes(1)
        End If
    End Sub

    Private Sub lblThrees_MouseLeave(sender As Object, e As EventArgs) Handles lblThrees.MouseLeave
        If Not Clicked(2) Then
            lblThrees.Text = ScoreTypes(2)
        End If
    End Sub

    Private Sub lblFours_MouseLeave(sender As Object, e As EventArgs) Handles lblFours.MouseLeave
        If Not Clicked(3) Then
            lblFours.Text = ScoreTypes(3)
        End If
    End Sub

    Private Sub lblFives_MouseLeave(sender As Object, e As EventArgs) Handles lblFives.MouseLeave
        If Not Clicked(4) Then
            lblFives.Text = ScoreTypes(4)
        End If
    End Sub

    Private Sub lblSixes_MouseLeave(sender As Object, e As EventArgs) Handles lblSixes.MouseLeave
        If Not Clicked(5) Then
            lblSixes.Text = ScoreTypes(5)
        End If
    End Sub

    Private Sub lblYahtzee_MouseHover(sender As Object, e As EventArgs) Handles lblYahtzee.MouseHover
        Category = 13
        If GetTotals() > 0 Then
            isClicked(False, Category)
        End If

    End Sub

    Private Sub lblYahtzee_MouseLeave(sender As Object, e As EventArgs) Handles lblYahtzee.MouseLeave
        If Not Clicked(12) Then
            lblYahtzee.Text = ScoreTypes(11)
        End If
    End Sub

    Private Sub ScoreTimer_Tick(sender As Object, e As EventArgs) Handles ScoreTimer.Tick
        lblAces.Text = ScoreTypes(0)
        lblTwos.Text = ScoreTypes(1)
        lblThrees.Text = ScoreTypes(2)
        lblFours.Text = ScoreTypes(3)
        lblFives.Text = ScoreTypes(4)
        lblSixes.Text = ScoreTypes(5)
        lbl3Kind.Text = ScoreTypes(6)
        lbl4Kind.Text = ScoreTypes(7)
        lblFull.Text = ScoreTypes(8)
        lblSmStraight.Text = ScoreTypes(9)
        lblLgStraight.Text = ScoreTypes(10)
        lblYahtzee.Text = ScoreTypes(11)
        lblChance.Text = ScoreTypes(12)


    End Sub
    ''' <summary>
    ''' Makes it more efficient to store the value of score
    ''' </summary>
    ''' <param name="HoverResponse">Place the score</param>
    ''' <remarks></remarks>
    Sub GetI(HoverResponse)
        ClickedInt(Category) = HoverResponse
        'Yahtzee("EndofTurn")
    End Sub
    Private Sub lblAces_Click(sender As Object, e As EventArgs) Handles lblAces.Click
        Try
            Dim HoverNumber = lblAces.Text
            If HoverNumber > 0 Then
                lblAces.Text = HoverNumber
                Clicked(1) = True
                GetI(HoverNumber)
                isClicked(Clicked(1), Category)
            End If
        Catch ex As FormatException
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lblTwos_Click(sender As Object, e As EventArgs) Handles lblTwos.Click
        Try
            Dim HoverNumber = lblTwos.Text
            If HoverNumber > 0 Then
                lblTwos.Text = HoverNumber
                Clicked(2) = True
                GetI(HoverNumber)
                isClicked(Clicked(2), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lblThrees_Click(sender As Object, e As EventArgs) Handles lblThrees.Click
        Try
            Dim HoverNumber = lblThrees.Text
            If HoverNumber > 0 Then
                lblThrees.Text = HoverNumber
                Clicked(3) = True
                GetI(HoverNumber)
                isClicked(Clicked(3), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lblFours_Click(sender As Object, e As EventArgs) Handles lblFours.Click
        Try
            Dim HoverNumber = lblFours.Text
            If HoverNumber > 0 Then
                lblFours.Text = HoverNumber
                Clicked(4) = True
                GetI(HoverNumber)
                isClicked(Clicked(4), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lblFives_Click(sender As Object, e As EventArgs) Handles lblFives.Click
        Try
            Dim HoverNumber = lblFives.Text
            If HoverNumber > 0 Then
                lblFives.Text = HoverNumber
                Clicked(5) = True
                GetI(HoverNumber)
                isClicked(Clicked(5), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lblSixes_Click(sender As Object, e As EventArgs) Handles lblSixes.Click
        Try
            Dim HoverNumber = lblSixes.Text
            If HoverNumber > 0 Then
                lblSixes.Text = HoverNumber
                Clicked(6) = True
                GetI(HoverNumber)
                isClicked(Clicked(6), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lbl3Kind_Click(sender As Object, e As EventArgs) Handles lbl3Kind.Click
        Try
            Dim HoverNumber = lbl3Kind.Text
            If HoverNumber > 0 Then
                lbl3Kind.Text = HoverNumber
                Clicked(7) = True
                GetI(HoverNumber)
                isClicked(Clicked(7), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lbl4Kind_Click(sender As Object, e As EventArgs) Handles lbl4Kind.Click
        Try
            Dim HoverNumber = lbl4Kind.Text
            If HoverNumber > 0 Then
                lbl4Kind.Text = HoverNumber
                Clicked(8) = True
                GetI(HoverNumber)
                isClicked(Clicked(8), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lblFull_Click(sender As Object, e As EventArgs) Handles lblFull.Click
        Try
            Dim HoverNumber = lblFull.Text
            If HoverNumber > 0 Then
                lblFull.Text = HoverNumber
                Clicked(9) = True
                GetI(HoverNumber)
                isClicked(Clicked(9), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lblSmStraight_Click(sender As Object, e As EventArgs) Handles lblSmStraight.Click
        Try
            Dim HoverNumber = lblSmStraight.Text
            If HoverNumber > 0 Then
                lblSmStraight.Text = HoverNumber
                Clicked(10) = True
                GetI(HoverNumber)
                isClicked(Clicked(10), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lblChance_Click(sender As Object, e As EventArgs) Handles lblChance.Click
        Try
            Dim HoverNumber = lblChance.Text
            If HoverNumber > 0 Then
                lblChance.Text = HoverNumber
                Clicked(12) = True
                GetI(HoverNumber)
                isClicked(Clicked(12), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lblYahtzee_Click(sender As Object, e As EventArgs) Handles lblYahtzee.Click
        Try
            Dim HoverText = lblYahtzee.Text
            If lblYahtzee.Text <> "Reallly dude? You really tried to get a Yahtzee!? Are you crazy!? " & _
                                "Trying to pull a fast one on me? Well, I don't think so!" Then
                lblYahtzee.Text = HoverText
                Clicked(13) = True
                GetI(HoverText)
                isClicked(Clicked(13), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub

    Private Sub lblLgStraight_Click(sender As Object, e As EventArgs) Handles lblLgStraight.Click
        Try
            Dim HoverText = lblLgStraight.Text
            If lblLgStraight.Text > 0 Then
                lblLgStraight.Text = HoverText
                Clicked(11) = True
                GetI(HoverText)
                isClicked(Clicked(11), Category)
            End If
        Catch ex As Exception
            Yahtzee("Error")
        End Try
    End Sub
    Private Sub FinalScoresUpdater_Tick(sender As Object, e As EventArgs) Handles FinalScoresUpdater.Tick
        Yahtzee("RefreshScores")
        '14 = Upper.Total Score
        PlayerScore(CurrentPlayer, 14) = PlayerScore(CurrentPlayer, 1) + PlayerScore(CurrentPlayer, 2) + PlayerScore(CurrentPlayer, 3) + PlayerScore(CurrentPlayer, 4) + PlayerScore(CurrentPlayer, 5) + PlayerScore(CurrentPlayer, 6)
        lblTotal.Text = PlayerScore(CurrentPlayer, 14)
        For isChecking = 0 To 12
            If Clicked(isChecking) Then
                Done(CurrentPlayer, isChecking) = True
            Else
                Done(CurrentPlayer, isChecking) = False
            End If
        Next
        Select Case CurrentPlayer
            Case 1
                Me.lblName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            Case 2
                Me.lblName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Case 3
                Me.lblName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Case 4
                Me.lblName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblName4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End Select
    End Sub
End Class