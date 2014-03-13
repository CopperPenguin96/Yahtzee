Imports System.IO

Module YahtzeeModule
    Public playerRound(13) As Integer
    Public Done(Form1.numPlayers.Value, 19) As Boolean
    Public StopScore(12) As Boolean
    Public Turn As Integer
    Public CheckedPublic As Integer
    ''' <summary>
    ''' The Names of all scoring types
    ''' </summary>
    ''' <remarks></remarks>
    Public ScoreTypes() As String = {"Aces", "Twos", "Threes", "Fours", "Fives", "Sixes",
                                  "3 of a Kind", "4 of a Kind", "Full House", "Small Straight",
                                  "Large Straight", "Yahtzee", "Chance"}
    ''' <summary>
    ''' The Current Player taking their turn
    ''' </summary>
    ''' <remarks></remarks>
    Public CurrentPlayer As Integer = 1
    ''' <summary>
    ''' Where the player's information is store
    ''' PlayerScore(CurrentPlayer, WhichScoringType)
    ''' </summary>
    ''' <remarks></remarks>
    Public PlayerScore(Form1.numPlayers.Value, 19)
    Public Clicked() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False}
    Public ClickedInt(12) As Integer
    Public Ready As Boolean = False

    Public CurrentLarge As Integer
    Public Temp As Integer
    Public Category As Integer
    Dim GetTypes As String = "GetTypes"
    ''' <summary>
    ''' The Array that will hold Dice Values after they've been sorted
    ''' </summary>
    ''' <remarks></remarks>
    Public TempDice(4) As Integer
    ''' <summary>
    ''' Some funky things were going on with the 4th Player so this String was used to help fix it up.... Only part of it
    ''' </summary>
    ''' <remarks></remarks>
    Dim s4thPlayer As String = "GetPlayers"
    ''' <summary>
    ''' The Amount of Players - 1 That are in the game
    ''' </summary>
    ''' <remarks></remarks>
    Public PlayerCount As Integer
    ''' <summary>
    ''' Amount of Rolls the Current Player Has Done
    ''' </summary>
    ''' <remarks></remarks>
    Public AllowedCount As Integer
    ''' <summary>
    ''' Allows the User to Continue
    ''' </summary>
    ''' <remarks></remarks>
    Public ReadytoGO As Boolean
    ''' <summary>
    ''' Random Names as TempNames in the InputBoxes | I was just testing something out
    ''' </summary>
    ''' <remarks></remarks>
    Dim RandomNames() As String = {"Bob", "Joe", "Troy", "Alex"}
    ''' <summary>
    ''' Will hold all the PlayerNames
    ''' </summary>
    ''' <remarks></remarks>
    Public PlayerName(3) As String
    ''' <summary>
    ''' Use for Arguement Calling
    ''' </summary>
    ''' <remarks></remarks>
    Public GetNames As String = "GetNames"
    ''' <summary>
    ''' Will hold each of the Dice's 1st Random Integer
    ''' </summary>
    ''' <remarks></remarks>
    Public Dice(4) As Integer
    Public strFiles() As String = {"1_dice.png", "2_dice.png", "3_dice.png", "4_dice.png", "5_dice.png", "6_dice.png", "blank_dice.png"}
    Public RollType As String = "RollType"
    Public Keep(4) As Boolean
    ''' <summary>
    ''' Yahtzee Methods that Keep the Game Going
    ''' </summary>
    ''' <param name="StepIn">The Section of Code to Activate in Yahtzee. An invalid line will cause the app to stop.</param>
    ''' <remarks></remarks> 
    Sub Yahtzee(StepIn As String)
        If StepIn = s4thPlayer Then
            'Allows for 4th Player to Continue
            Dim Players As Integer = Form1.numPlayers.Value
            Randomize()

            'Fixes 4th Player Randomization
            Dim RandomPlayer As Integer = Int(Rnd() * 4)
            PlayerName(Players) = InputBox("Player #" & Players + 1 & ", enter your name!", "Enter Player #" & Players + 1 & "'s name!", RandomNames(RandomPlayer))
            Yahtzee("Names")
            MainForm.lblName4.Show()
            MainForm.lblName4.Text = PlayerName(3)
            If PlayerName(Players) = Nothing Then
                MsgBox("Your name isn't Nothing. Try again")
                Application.Restart()
            Else
                'Allows the game to continue
                ReadytoGO = True
            End If
        ElseIf StepIn = GetNames Then
            For Players = 0 To Form1.numPlayers.Value - 1
                Try
                    Select Case Players
                        Case Is < 4
                            Randomize()
                            Dim RandomPlayer As Integer = Int(Rnd() * 4)
                            PlayerName(Players) = InputBox("Player #" & Players + 1 & ", enter your name!", "Enter Player #" & Players + 1 & "'s name!", RandomNames(RandomPlayer))
                            Yahtzee("Names")
                            If PlayerName(Players) = Nothing Then
                                MsgBox("Your name isn't Nothing. Try again")
                                Application.Restart()
                            Else
                                ReadytoGO = True
                            End If
                        Case Form1.numPlayers.Value > Players
                            Yahtzee(s4thPlayer)
                    End Select
                Catch ex As OverflowException
                    MsgBox("What have you done!? Tsk tsk tsk..... Don't over feed me!")
                    Application.Restart()
                Catch ex2 As FormatException
                    MsgBox("You silly doof. You input something bad.")
                    Application.Restart()
                End Try
            Next
        ElseIf StepIn = "GetDice" Then
            'Hold diceif they are checked
            For intNext = 0 To 4
                If MainForm.chkDice1.Checked Then
                    Keep(0) = True
                Else
                    Keep(0) = False
                End If

                If MainForm.chkDice2.Checked Then
                    Keep(1) = True
                Else
                    Keep(1) = False
                End If

                If MainForm.chkDice3.Checked Then
                    Keep(2) = True
                Else
                    Keep(2) = False
                End If

                If MainForm.chkDice4.Checked Then
                    Keep(3) = True
                Else
                    Keep(3) = False
                End If

                If MainForm.chkDice5.Checked Then
                    Keep(4) = True
                Else
                    Keep(4) = False
                End If

                'If not held, creates the random dice
                If Not Keep(intNext) Then
                    Randomize()
                    Dice(intNext) = Int(Rnd() * 6)
                End If
            Next
            'Loads the Dice
            'The Dice Control is a custom control only for this project.
            MainForm.Dice1.BackgroundImage = Image.FromFile(strFiles(Dice(0)))
            MainForm.Dice2.BackgroundImage = Image.FromFile(strFiles(Dice(1)))
            MainForm.Dice3.BackgroundImage = Image.FromFile(strFiles(Dice(2)))
            MainForm.Dice4.BackgroundImage = Image.FromFile(strFiles(Dice(3)))
            MainForm.Dice5.BackgroundImage = Image.FromFile(strFiles(Dice(4)))
        ElseIf StepIn = "Names" Then
            'Allows showing the player names in the player list
            If PlayerName(2) = Nothing Then
                PlayerCount = 1
            ElseIf PlayerName(3) = Nothing Then
                PlayerCount = 2
            Else
                PlayerCount = 3
            End If
            Select Case PlayerCount
                'Prevents {Name} from showing if there is less than 4 or 3
                Case 1
                    MainForm.lblName1.Text = PlayerName(PlayerCount - 1)
                    MainForm.lblName2.Text = PlayerName(PlayerCount)
                Case 2
                    MainForm.lblName1.Text = PlayerName(PlayerCount - 2)
                    MainForm.lblName2.Text = PlayerName(PlayerCount - 1)
                    MainForm.lblName3.Text = PlayerName(PlayerCount)

                    MainForm.lblName3.Show()
                Case 3
                    MainForm.lblName1.Text = PlayerName(PlayerCount - 3)
                    MainForm.lblName2.Text = PlayerName(PlayerCount - 2)
                    MainForm.lblName3.Text = PlayerName(PlayerCount - 1)
                    MainForm.lblName4.Text = PlayerName(3)

                    MainForm.lblName3.Show()
                    MainForm.lblName4.Show()
                Case Else
                    MsgBox("Something went wrong!?")
            End Select
        ElseIf StepIn = "GetTypes" Then
            'Call to Sort the die in numerical order
            Yahtzee("Sort")
            Select Case Category
                Case 1 To 6 'Ones Twos Threes Fours Fives Sixes
                    If Ready Then
                        Dim TopScores(5) As Integer
                        If GetTotals() > 0 Then
                            For X = 0 To 4
                                'Adds up the die per category
                                If TempDice(X) = 0 Then
                                    TopScores(0) += Category
                                ElseIf TempDice(X) = 1 Then
                                    TopScores(1) += Category
                                ElseIf TempDice(X) = 2 Then
                                    TopScores(2) += Category
                                ElseIf TempDice(X) = 3 Then
                                    TopScores(3) += Category
                                ElseIf TempDice(X) = 4 Then
                                    TopScores(4) += Category
                                ElseIf TempDice(X) = 5 Then
                                    TopScores(5) += Category
                                Else
                                    '"Error" is not implemented in the Yahtzee Sub Procedure
                                    'It will break the program
                                    'Using it because know if this code is ever reached, I've
                                    'Coded Something Wrong
                                    Yahtzee("Error")
                                End If
                            Next
                        End If
                        'If Scores Together are greater than 0, they can be used
                        'This prevents from viewing scores before the dice is ever rolled
                        If TopScores(Category - 1) > 0 Then
                            If Category = 1 Then
                                MainForm.lblAces.Text = TopScores(Category - 1)
                            ElseIf Category = 2 Then
                                MainForm.lblTwos.Text = TopScores(Category - 1)
                            ElseIf Category = 3 Then
                                MainForm.lblThrees.Text = TopScores(Category - 1)
                            ElseIf Category = 4 Then
                                MainForm.lblFours.Text = TopScores(Category - 1)
                            ElseIf Category = 5 Then
                                MainForm.lblFives.Text = TopScores(Category - 1)
                            ElseIf Category = 6 Then
                                MainForm.lblSixes.Text = TopScores(Category - 1)
                            End If
                        End If
                    End If
                Case 7 '3 of a Kind
                    If Ready Then
                        'Checks if Total is greater than 0, again preventing
                        'Before Dice rolling
                        If GetTotals() > 0 Then
                            'Checks for 3 of a Kind
                            'With the Sorted Dice, only 3 possibilities are valid
                            If TempDice(0) = TempDice(1) And TempDice(1) = TempDice(2) Then
                                MainForm.lbl3Kind.Text = GetTotals()
                            ElseIf TempDice(1) = TempDice(2) And TempDice(2) = TempDice(3) Then
                                MainForm.lbl3Kind.Text = GetTotals()
                            ElseIf TempDice(2) = TempDice(3) And TempDice(3) = TempDice(4) Then
                                MainForm.lbl3Kind.Text = GetTotals()
                            End If
                        End If
                    End If
                Case 8 '4 of a Kind
                    'Same method for 3 of a kind
                    'EXCEPT there are two methods only
                    'AND! -> There are 4 per If
                    If Ready Then
                        If GetTotals() > 0 Then
                            If TempDice(0) = TempDice(1) And TempDice(1) = TempDice(2) And TempDice(2) = TempDice(3) Then
                                MainForm.lbl4Kind.Text = GetTotals()
                            ElseIf TempDice(1) = TempDice(2) And TempDice(2) = TempDice(3) And TempDice(3) = TempDice(4) Then
                                MainForm.lbl4Kind.Text = GetTotals()
                            End If
                        End If
                    End If
                Case 9 'Full House
                    If Ready Then
                        If TempDice(0) = TempDice(1) And TempDice(1) = TempDice(2) Then
                            If TempDice(3) = TempDice(4) Then
                                If TempDice(3) <> TempDice(0) Then
                                    MainForm.lblFull.Text = 25
                                End If
                            End If
                        ElseIf TempDice(0) = TempDice(1) Then
                            If TempDice(2) = TempDice(3) And TempDice(3) = TempDice(4) Then
                                If TempDice(2) <> TempDice(0) Then
                                    MainForm.lblFull.Text = 25
                                End If
                            End If
                        End If
                    End If
                Case 10 'Small Straight
                    '0 1 2 3
                    '1 2 3 4
                    If Ready Then
                        If TempDice(0) + 1 = TempDice(1) And TempDice(1) + 1 = TempDice(2) And TempDice(2) + 1 = TempDice(3) Then
                            MainForm.lblSmStraight.Text = 30
                        ElseIf TempDice(1) + 1 = TempDice(2) And TempDice(2) + 1 = TempDice(3) And TempDice(3) + 1 = TempDice(4) Then
                            MainForm.lblSmStraight.Text = 30
                        End If
                    End If
                Case 11 'Large Straight
                    '0 1 2 3 4
                    If Ready Then
                        If TempDice(0) + 1 = TempDice(1) And TempDice(1) + 1 = TempDice(2) And TempDice(2) + 1 = TempDice(3) And TempDice(3) + 1 = TempDice(4) Then
                            MainForm.lblLgStraight.Text = 40
                        End If
                    End If
                Case 12 'Chance
                    If Ready Then
                        If GetTotals() > 0 Then
                            MainForm.lblChance.Text = GetTotals()
                        End If
                    End If
                Case 13 'Yahtzee
                    If Ready Then
                        If (TempDice(0) + TempDice(1) + TempDice(2) + TempDice(3) + TempDice(4)) / 5 = TempDice(0) Then
                            MainForm.lblYahtzee.Text = 50
                        Else
                            MainForm.lblYahtzee.Text = "Reallly dude? You really tried to get a Yahtzee!? Are you crazy!? " & _
                                "Trying to pull a fast one on me? Well, I don't think so!"
                        End If
                    End If
            End Select
        ElseIf StepIn = "Sort" Then
            'Sorts the dice into numeric order so that
            'Scoring can be more efficient
            For StoreDice = 0 To 4
                TempDice(StoreDice) = Dice(StoreDice)
            Next
            For X = 0 To 3
                For Y = X To 4
                    If TempDice(X) > TempDice(Y) Then
                        Temp = TempDice(X)
                        TempDice(X) = TempDice(Y)
                        TempDice(Y) = Temp
                    End If
                Next Y
            Next X
        ElseIf StepIn = "finishMove" Then
            AllowedCount = 3
            MainForm.btnRoll.Text = "Finish Your Move"
            MainForm.gboScores.Enabled = False
        ElseIf StepIn = "NextPlayer" Then


            If Clicked(Category) Then
                PlayerScore(CurrentPlayer, Category) = ClickedInt(Category)
            End If
            Yahtzee("Restore")
        ElseIf StepIn = "Restore" Then
            For RestoreKeep = 0 To 4
                If Keep(RestoreKeep) <> False Then
                    Keep(RestoreKeep) = False
                End If
            Next
            For StepofDice = 1 To 4
                Dice(StepofDice) = 0
                MainForm.lblAces.Text = ScoreTypes(0)
                MainForm.lblTwos.Text = ScoreTypes(1)
                MainForm.lblThrees.Text = ScoreTypes(2)
                MainForm.lblFours.Text = ScoreTypes(3)
                MainForm.lblFives.Text = ScoreTypes(4)
                MainForm.lblSixes.Text = ScoreTypes(5)
                MainForm.lbl3Kind.Text = ScoreTypes(6)
                MainForm.lbl4Kind.Text = ScoreTypes(7)
                MainForm.lblFull.Text = ScoreTypes(8)
                MainForm.lblSmStraight.Text = ScoreTypes(9)
                MainForm.lblLgStraight.Text = ScoreTypes(10)
                MainForm.lblYahtzee.Text = ScoreTypes(11)
                MainForm.lblChance.Text = ScoreTypes(12)

                MainForm.lblAces.Enabled = False
                MainForm.lblTwos.Enabled = False
                MainForm.lblThrees.Enabled = False
                MainForm.lblFours.Enabled = False
                MainForm.lblFives.Enabled = False
                MainForm.lblSixes.Enabled = False
                MainForm.lbl3Kind.Enabled = False
                MainForm.lbl4Kind.Enabled = False
                MainForm.lblFull.Enabled = False
                MainForm.lblSmStraight.Enabled = False
                MainForm.lblLgStraight.Enabled = False
                MainForm.lblChance.Enabled = False
                MainForm.lblYahtzee.Enabled = False
                Try
                    MainForm.Dice1.BackgroundImage = Image.FromFile(strFiles(6))
                    MainForm.Dice2.BackgroundImage = Image.FromFile(strFiles(6))
                    MainForm.Dice3.BackgroundImage = Image.FromFile(strFiles(6))
                    MainForm.Dice4.BackgroundImage = Image.FromFile(strFiles(6))
                    MainForm.Dice5.BackgroundImage = Image.FromFile(strFiles(6))
                Catch ex As FileNotFoundException
                    MsgBox("Cannot find one or more of the Dice Images")
                    Application.Exit()
                End Try
                For NextClear = 0 To 12
                    ClickedInt(NextClear) = 0
                    Clicked(NextClear) = False
                    If NextClear = 12 Then
                        Clicked(NextClear) = False
                    End If
                Next
            Next
        ElseIf StepIn = "RefreshScores" Then
            If PlayerScore(CurrentPlayer, 1) > 0 Then
                MainForm.lblAces.Text = PlayerScore(CurrentPlayer, 1)
                StopScore(0) = False
                MainForm.lblAces.Enabled = False
            Else
                StopScore(0) = True
                MainForm.lblAces.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 2) > 0 Then
                MainForm.lblTwos.Text = PlayerScore(CurrentPlayer, 2)
                StopScore(1) = False
                MainForm.lblTwos.Enabled = False
            Else
                StopScore(1) = True
                MainForm.lblTwos.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 3) > 0 Then
                MainForm.lblThrees.Text = PlayerScore(CurrentPlayer, 3)
                StopScore(2) = False
                MainForm.lblThrees.Enabled = False
            Else
                StopScore(2) = True
                MainForm.lblThrees.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 4) > 0 Then
                MainForm.lblFours.Text = PlayerScore(CurrentPlayer, 4)
                StopScore(3) = False
                MainForm.lblFours.Enabled = False
            Else
                StopScore(3) = True
                MainForm.lblFours.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 5) > 0 Then
                MainForm.lblFives.Text = PlayerScore(CurrentPlayer, 5)
                StopScore(4) = False
                MainForm.lblFives.Enabled = False
            Else
                StopScore(4) = True
                MainForm.lblFives.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 6) > 0 Then
                MainForm.lblSixes.Text = PlayerScore(CurrentPlayer, 6)
                StopScore(5) = False
                MainForm.lblSixes.Enabled = False
            Else
                StopScore(5) = True
                MainForm.lblSixes.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 7) > 0 Then
                MainForm.lbl3Kind.Text = PlayerScore(CurrentPlayer, 7)
                StopScore(6) = False
                MainForm.lbl3Kind.Enabled = False
            Else
                StopScore(6) = True
                MainForm.lbl3Kind.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 8) > 0 Then
                MainForm.lbl4Kind.Text = PlayerScore(CurrentPlayer, 8)
                StopScore(7) = False
                MainForm.lbl4Kind.Enabled = False
            Else
                StopScore(7) = True
                MainForm.lbl4Kind.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 9) > 0 Then
                MainForm.lblFull.Text = PlayerScore(CurrentPlayer, 9)
                StopScore(8) = False
                MainForm.lblFull.Enabled = False
            Else
                StopScore(8) = True
                MainForm.lblFull.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 10) > 0 Then
                MainForm.lblSmStraight.Text = PlayerScore(CurrentPlayer, 10)
                StopScore(9) = False
                MainForm.lblSmStraight.Enabled = False
            Else
                StopScore(9) = True
                MainForm.lblSmStraight.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 11) > 0 Then
                MainForm.lblLgStraight.Text = PlayerScore(CurrentPlayer, 11)
                StopScore(10) = False
                MainForm.lblLgStraight.Enabled = False
            Else
                StopScore(10) = True
                MainForm.lblLgStraight.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 12) > 0 Then
                MainForm.lblChance.Text = PlayerScore(CurrentPlayer, 12)
                StopScore(11) = False
                MainForm.lblChance.Enabled = False
            Else
                StopScore(11) = True
                MainForm.lblChance.Enabled = True
            End If
            If PlayerScore(CurrentPlayer, 13) > 0 Then
                MainForm.lblYahtzee.Text = PlayerScore(CurrentPlayer, 13)
                StopScore(12) = False
                MainForm.lblYahtzee.Enabled = False
            Else
                StopScore(12) = True
                MainForm.lblYahtzee.Enabled = True
            End If
        ElseIf StepIn = "EndofTurn" Then
            MainForm.gboScores.Enabled = False
            Yahtzee("checkTurn")
        ElseIf StepIn = "checkTurn" Then
            If Turn = PlayerCount * 13 + 1 Then
                Yahtzee("EndOfGame")
            End If
        ElseIf StepIn = "EndOfGame" Then

        Else
            'If Someone is modifiying the code, per se making mods for the game, like crazy stuff
            'And Forget to add the Method they are trying to imply, then the app will break
            MsgBox("An invalid arguement has passed in the application. It must close")
            Application.Exit()
        End If
    End Sub

    ''' <summary>
    ''' Totals up all the dice
    ''' </summary>
    ''' <returns>Returns the total of all the dice</returns>
    ''' <remarks></remarks>
    Function GetTotals() As Integer
        'Totals up all the die
        Dim NextDie As Integer
        For WhichDie = 0 To 4
            'Needs to be + 1 because of 0
            NextDie += Dice(WhichDie) + 1
        Next
        Return NextDie
    End Function

End Module
