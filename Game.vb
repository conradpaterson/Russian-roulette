Imports System.Timers


Public Class Game

    Public myGame As GameScreen = MainMenu.myGame
    Public myRound As Round = MainMenu.myGame.round
    Public responsePlayerDeath As MsgBoxResult
    Public responseOpponentDeath As MsgBoxResult
    Public pointsDisplay As Integer

    Public Sub displayGameNames()

        lblPlayer1.Text = myGame.Player1.getName
        lblPlayer1Other.Text = myGame.Player1.getName

        lblPlayer2.Text = myGame.Player2.getName
        lblPlayer2Other.Text = myGame.Player2.getName

    End Sub

    Public Sub displayPlayerTurn()

        If myRound.player1Turn = True Then
            lblPlayerTurn.Text = myGame.Player1.getName
        Else
            lblPlayerTurn.Text = myGame.Player2.getName
        End If

    End Sub

    Private Sub chkPointAtOpponent_CheckedChanged(sender As Object, e As EventArgs) Handles chkPointAtOpponent.CheckedChanged

        If chkPointAtOpponent.Checked = True Then

            myRound.pointToOpponent = True

        Else

            myRound.pointToOpponent = False

        End If

    End Sub


    Private Sub rb1ChamberPlay_CheckedChanged(sender As Object, e As EventArgs) Handles rb1ChamberPlay.CheckedChanged

        If rb1ChamberPlay.Checked = True Then

            chkPointAtOpponent.Enabled = False
            setChamber1Play()

        End If

    End Sub

    Public Sub setChamber1Play()

        myRound.chamber1Play = True
        myRound.chamber3Play = False
        myRound.chamber6Play = False
        myRound.turnCount = 1
        myRound.currentTurnCount = 1

    End Sub

    Private Sub rb3ChamberPlay_CheckedChanged(sender As Object, e As EventArgs) Handles rb3ChamberPlay.CheckedChanged

        If rb3ChamberPlay.Checked = True Then

            chkPointAtOpponent.Enabled = True
            setChamber3Play()

        End If

    End Sub

    Public Sub setChamber3Play()

        myRound.chamber1Play = False
        myRound.chamber3Play = True
        myRound.chamber6Play = False
        myRound.turnCount = 3
        myRound.currentTurnCount = 1
        myRound.pointToOpponentCount = 1
        myRound.pointToOpponentCounter = 0

    End Sub

    Private Sub rb6ChamberPlay_CheckedChanged(sender As Object, e As EventArgs) Handles rb6ChamberPlay.CheckedChanged

        If rb6ChamberPlay.Checked = True Then

            chkPointAtOpponent.Enabled = True
            setChamber6Play()

        End If

    End Sub

    Public Sub setChamber6Play()

        myRound.chamber1Play = False
        myRound.chamber3Play = False
        myRound.chamber6Play = True
        myRound.turnCount = 6
        myRound.currentTurnCount = 1
        myRound.pointToOpponentCount = 2
        myRound.pointToOpponentCounter = 0

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        loadBullet()

    End Sub

    Public Sub loadBullet()

        playChamberingTheBullet()
        myRound.setGunChamberWithBullet()
        btnLoad.Enabled = False
        btnSpin.Enabled = True
        GroupBox1.Enabled = False

    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click

        spinChamber()

    End Sub

    Public Sub spinChamber()

        playSpinningTheChamber()
        myRound.setChamberOnBarrelToFire()
        btnSpin.Enabled = False
        btnFire.Enabled = True

    End Sub

    Public Sub initializeRound()

        rb1ChamberPlay.Checked = True
        btnLoad.Enabled = True
        btnSpin.Enabled = False
        btnFire.Enabled = False
        chkPointAtOpponent.Enabled = False
        chkPointAtOpponent.Checked = False
        myRound.player1Turn = True
        myRound.player2Turn = False
        GroupBox1.Enabled = True
        displayPlayerTurn()
        reinitializeBulletCount()
        'lbl2Bullet.BackColor = SystemColors.ControlDark


    End Sub

    Public Sub initializeRoundCham1Player1()

        btnLoad.Enabled = True
        btnSpin.Enabled = False
        btnFire.Enabled = False
        chkPointAtOpponent.Enabled = False
        chkPointAtOpponent.Checked = False
        GroupBox1.Enabled = False
        displayPlayerTurn()

    End Sub

    Public Sub initializeRoundCham1Player2()

        rb1ChamberPlay.Checked = True
        btnLoad.Enabled = True
        btnSpin.Enabled = False
        btnFire.Enabled = False
        chkPointAtOpponent.Enabled = False
        chkPointAtOpponent.Checked = False
        GroupBox1.Enabled = True
        displayPlayerTurn()

    End Sub

    Public Sub initializeRoundCham3Player1()

        btnLoad.Enabled = True
        btnSpin.Enabled = False
        btnFire.Enabled = False
        myRound.currentTurnCount = 1
        myRound.pointToOpponentCounter = 0
        chkPointAtOpponent.Enabled = True
        chkPointAtOpponent.Checked = False
        displayPlayerTurn()

    End Sub

    Public Sub initializeRoundCham3Player2()

        btnLoad.Enabled = True
        btnSpin.Enabled = False
        btnFire.Enabled = False
        GroupBox1.Enabled = True
        myRound.currentTurnCount = 1
        chkPointAtOpponent.Enabled = True
        chkPointAtOpponent.Checked = False
        myRound.pointToOpponentCounter = 0
        displayPlayerTurn()

    End Sub

    Public Sub initializeRoundCham6Player1()

        rb6ChamberPlay.Checked = True
        btnLoad.Enabled = True
        btnSpin.Enabled = False
        btnFire.Enabled = False
        chkPointAtOpponent.Enabled = True
        chkPointAtOpponent.Checked = False
        displayPlayerTurn()

    End Sub

    Public Sub initializeRoundCham6Player2()

        rb6ChamberPlay.Checked = True
        btnLoad.Enabled = True
        btnSpin.Enabled = False
        btnFire.Enabled = False
        chkPointAtOpponent.Enabled = True
        chkPointAtOpponent.Checked = False
        displayPlayerTurn()

    End Sub

    Public Sub drawBulletCount(count As Integer)

        If (count = 1) Then
            lbl1Bullet.BackColor = SystemColors.ControlDarkDark
        ElseIf (count = 2) Then
            lbl2Bullet.BackColor = SystemColors.ControlDarkDark
        ElseIf (count = 3) Then
            lbl3Bullet.BackColor = SystemColors.ControlDarkDark
        ElseIf (count = 4) Then
            lbl4Bullet.BackColor = SystemColors.ControlDarkDark
        ElseIf (count = 5) Then
            lbl5Bullet.BackColor = SystemColors.ControlDarkDark
        ElseIf (count = 6) Then
            lbl6Bullet.BackColor = SystemColors.ControlDarkDark
        End If

    End Sub

    Public Sub reinitializeBulletCount()

        myRound.bulletCount = 0
        lbl1Bullet.BackColor = SystemColors.Control
        lbl2Bullet.BackColor = SystemColors.Control
        lbl3Bullet.BackColor = SystemColors.Control
        lbl4Bullet.BackColor = SystemColors.Control
        lbl5Bullet.BackColor = SystemColors.Control
        lbl6Bullet.BackColor = SystemColors.Control

    End Sub

    Public Sub performPointToOpponentMove()

        If myRound.computerPointToOpponentNumber = myRound.currentTurnCount Then
            chkPointAtOpponent.Checked = True
        End If



    End Sub

    Public Sub playFireBulletSound()

        'make firing sound
        My.Computer.Audio.Play(My.Resources.single_shot, AudioPlayMode.Background)

    End Sub

    Public Sub playChamberingTheBullet()

        My.Computer.Audio.Play(My.Resources.chambering_shot, AudioPlayMode.Background)

    End Sub

    Public Sub playSpinningTheChamber()

        My.Computer.Audio.Play(My.Resources.chamber_spinning, AudioPlayMode.Background)

    End Sub

    Public Sub playGunClicking()

        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)

    End Sub

    Public Sub fireTheBullet()

        myRound.bulletCount = myRound.bulletCount + 1
        drawBulletCount(myRound.bulletCount)

        If myRound.player1Turn Then

            If (myRound.chamber6Play) And (myRound.currentTurnCount <= myRound.turnCount) Then
                If (myRound.gunChamberWithBullet = myRound.chamberOnBarrelToFire) Then
                    playFireBulletSound()
                    If (myRound.pointToOpponent) Then
                        'Opposing player killed
                        haveKilledOpposingPlayer1cham6() 'sorted
                    Else
                        haveDiedMyselfPlayer1() 'sorted
                    End If
                Else
                    'gun clicking, not going off
                    playGunClicking()
                    'have written points
                    havePassedOneTurnPlayer1()
                    'increment turncount and chamber on barrel to fire, and check
                    incrementTurnAndChamber()
                    'increment point to opponent counter, check and take actions
                    incrementPointToOpponentCounterAndCheck()

                End If

            ElseIf (myRound.chamber3Play) And (myRound.currentTurnCount = myRound.turnCount) Then
                If (myRound.gunChamberWithBullet = myRound.chamberOnBarrelToFire) Then
                    playFireBulletSound()
                    If (myRound.pointToOpponent) Then
                        haveKilledOpposingPlayer1cham3() 'sorted
                    Else
                        haveDiedMyselfPlayer1() 'sorted
                    End If
                Else
                    playGunClicking()
                    'completed all turns, not died, write points
                    havePassedLastTurnPlayer1()
                    'swap players
                    swapPlayerTurnsPlayer1()
                    'reinitialize play screen for loading etc
                    initializeRoundCham3Player1()
                    reinitializeBulletCount()

                    If myRound.computerIsPlaying Then
                        myRound.setComputerPointToOpponentNumber()
                        performPointToOpponentMove()
                        Threading.Thread.Sleep(1000)
                        loadBullet()
                        Threading.Thread.Sleep(1000)
                        spinChamber()
                        Threading.Thread.Sleep(1000)
                        fireTheBullet()
                        Threading.Thread.Sleep(1000)
                        'TimerLoad.Start()
                        'TimerSpin.Start()
                        'TimerFireBullet.Start()

                    End If

                End If

            ElseIf (myRound.chamber3Play) And (myRound.currentTurnCount < myRound.turnCount) Then
                If (myRound.gunChamberWithBullet = myRound.chamberOnBarrelToFire) Then
                    playFireBulletSound()
                    If (myRound.pointToOpponent) Then
                        'claim points, write to displays, and mygame
                        haveKilledOpposingPlayer1cham3()
                    Else
                        'zero round points, mygame total points, not accum though
                        haveDiedMyselfPlayer1()
                    End If
                Else
                    playGunClicking()
                    'have written points
                    havePassedOneTurnPlayer1()
                    'increment turncount and chamber on barrel to fire, and check
                    incrementTurnAndChamber()
                    'increment point to opponent counter, check and take actions
                    incrementPointToOpponentCounterAndCheck()
                End If

            ElseIf (myRound.chamber1Play) Then
                If (myRound.gunChamberWithBullet = myRound.chamberOnBarrelToFire) Then
                    playFireBulletSound()
                    'round points 0, msg ask if play again, if y go back to menu screen, display points there
                    haveDiedMyselfPlayer1()
                Else
                    playGunClicking()
                    'have not died, add points to round and total
                    havePassedOneTurnPlayer1()
                    'swap player turns, disable type of play, enable load button and disable others
                    swapPlayerTurnsPlayer1()
                    initializeRoundCham1Player1()
                    reinitializeBulletCount()

                    If myRound.computerIsPlaying Then
                        Threading.Thread.Sleep(1000)
                        loadBullet()
                        Threading.Thread.Sleep(2000)
                        spinChamber()
                        Threading.Thread.Sleep(2000)
                        fireTheBullet()
                        Threading.Thread.Sleep(1000)

                        'TimerLoad.Start()
                        'TimerSpin.Start()
                        'TimerFireBullet.Start()

                    End If


                End If

            End If

        ElseIf myRound.player2Turn Then
            If (myRound.chamber6Play) And (myRound.currentTurnCount <= myRound.turnCount) Then
                If (myRound.gunChamberWithBullet = myRound.chamberOnBarrelToFire) Then
                    playFireBulletSound()
                    If (myRound.pointToOpponent) Then
                        'player2 killed
                        haveKilledOpposingPlayer2cham6() 'sorted
                        Exit Sub
                    Else
                        haveDiedMyselfPlayer2() 'sorted
                    End If
                Else
                    playGunClicking()
                    havePassedOneTurnPlayer2()
                End If

            ElseIf (myRound.chamber3Play) And (myRound.currentTurnCount = myRound.turnCount) Then

                If (myRound.gunChamberWithBullet = myRound.chamberOnBarrelToFire) Then
                    playFireBulletSound()
                    If (myRound.pointToOpponent) Then
                        haveKilledOpposingPlayer2cham3() 'sorted
                        Exit Sub
                    Else
                        haveDiedMyselfPlayer2() 'sorted
                    End If
                Else
                    playGunClicking()
                    havePassedLastTurnPlayer2() 'sorted
                    'change players
                    swapPlayerTurnsPlayer2()
                    'set up new round
                    initializeRoundCham3Player2() 'sorted
                    reinitializeBulletCount()
                End If

            ElseIf (myRound.chamber3Play) And (myRound.currentTurnCount < myRound.turnCount) Then
                If (myRound.gunChamberWithBullet = myRound.chamberOnBarrelToFire) Then
                    playFireBulletSound()
                    If (myRound.pointToOpponent) Then
                        haveKilledOpposingPlayer2cham3() ' same as player1, sorted
                    Else
                        haveDiedMyselfPlayer2() 'sorted
                    End If
                Else
                    playGunClicking()
                    'have written points
                    havePassedOneTurnPlayer2() 'sorted
                    'increment turncount and chamber on barrel to fire, and check
                    incrementTurnAndChamber() 'sorted
                    'increment point to opponent counter, check and take actions
                    incrementPointToOpponentCounterAndCheck() 'sorted

                    If myRound.computerIsPlaying Then
                        performPointToOpponentMove()
                        Threading.Thread.Sleep(1000)
                        fireTheBullet()
                        Threading.Thread.Sleep(1000)
                        'TimerFireBullet.Start()
                    End If

                End If

            ElseIf (myRound.chamber1Play) Then
                If (myRound.gunChamberWithBullet = myRound.chamberOnBarrelToFire) Then
                    playFireBulletSound()
                    'round points 0, msg ask if play again, if y go back to menu screen, display points there
                    haveDiedMyselfPlayer2()
                Else
                    playGunClicking()
                    'have not died, add points to round and total
                    havePassedOneTurnPlayer2()
                    'swap player turns, enable type of play, enable load button and disable others
                    swapPlayerTurnsPlayer2()
                    initializeRoundCham1Player2()
                    reinitializeBulletCount()
                End If

            End If

        End If



    End Sub


    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click

        fireTheBullet()

    End Sub

    Public Sub incrementPointToOpponentCounterAndCheck()
        'increment point to opponent counter, check and take actions

        If (myRound.pointToOpponent) Then
            myRound.pointToOpponentCounter += 1
            If (myRound.pointToOpponentCounter = myRound.pointToOpponentCount) Then
                myRound.pointToOpponent = False
                chkPointAtOpponent.Enabled = False
            End If
        End If
    End Sub

    Public Sub incrementTurnAndChamber()

        myRound.currentTurnCount = myRound.currentTurnCount + 1
        myRound.chamberOnBarrelToFire = myRound.chamberOnBarrelToFire + 1
        If (myRound.chamberOnBarrelToFire = 7) Then
            myRound.chamberOnBarrelToFire = 1
        End If

    End Sub

    Public Sub swapPlayerTurnsPlayer1()

        myRound.player1Turn = False
        myRound.player2Turn = True

    End Sub

    Public Sub swapPlayerTurnsPlayer2()

        myRound.player2Turn = False
        myRound.player1Turn = True

    End Sub

    Public Sub haveKilledOpposingPlayer1cham6()
        'gain points, write points
        myRound.player1LastRoundPoints = 600
        tbPlayer1LastRoundPoints.Text = myRound.player1LastRoundPoints
        myGame.Player1.setPoints(myGame.Player1.getPoints + myRound.player1LastRoundPoints)
        myGame.Player1.lastRoundPoints = myRound.player1LastRoundPoints
        MainMenu.tbPlayer1AccumPoints.Text = myGame.Player1.getPoints()
        MainMenu.tbPlayer2AccumPoints.Text = myGame.Player2.getPoints()
        'computer is playing
        If myGame.round.computerIsPlaying Then
            Dim response As MsgBoxResult
            response = MsgBox("Well done " & myGame.Player1.getName & ", you have killed the computer. You have Total points " _
                              & myGame.Player1.getPoints & " so far. Do you wish to play again?", MsgBoxStyle.YesNo)
            If response = MsgBoxResult.Yes Then
                Me.Close()
            Else
                MainMenu.gameFinished = True
                Me.Close()
            End If
        Else
            ' update dgv with game details
            TopPlayers.DataGridView1.Rows.Add(myGame.Player2.getPoints().ToString, myGame.Player2.getName, " ")
            TopPlayers.sortTheGrid() 'sort list
            'TopPlayers.writeTheFile() write the DGV to file
            'give response, ask to play again
            pointsDisplay = myGame.Player2.getPoints
            responseToPlayerDeath(myGame.Player2, pointsDisplay)
            'zero player1 total points
            myGame.Player2.setPoints(0)
            tbPlayer2TotalPoints.Text = myGame.Player2.getPoints() 'zero player2 total points display
        End If
    End Sub

    Public Sub haveKilledOpposingPlayer2cham6()
        'gain points, write points
        myRound.player2LastRoundPoints = 600
        tbPlayer2LastRoundPoints.Text = myRound.player2LastRoundPoints
        myGame.Player2.setPoints(myGame.Player2.getPoints + myRound.player2LastRoundPoints)
        myGame.Player2.lastRoundPoints = myRound.player2LastRoundPoints
        MainMenu.tbPlayer1AccumPoints.Text = myGame.Player1.getPoints()
        MainMenu.tbPlayer2AccumPoints.Text = myGame.Player2.getPoints()
        ' update dgv with game details
        TopPlayers.DataGridView1.Rows.Add(myGame.Player2.getPoints().ToString, myGame.Player2.getName, " ")
        TopPlayers.sortTheGrid() 'sort list maybe
        'TopPlayers.writeTheFile() write the DGV to file
        'give response, ask to play again
        pointsDisplay = myGame.Player1.getPoints
        responseToPlayerDeath(myGame.Player1, pointsDisplay)
        'zero player1 total points
        myGame.Player1.setPoints(0)
        tbPlayer1TotalPoints.Text = myGame.Player1.getPoints() 'zero player1 total points display

    End Sub

    Public Sub haveKilledOpposingPlayer2cham3()
        'claim points, write to displays, and mygame
        myRound.player2LastRoundPoints = 300
        tbPlayer2LastRoundPoints.Text = myRound.player2LastRoundPoints
        myGame.Player2.setPoints(myGame.Player2.getPoints + myRound.player2LastRoundPoints)
        myGame.Player2.lastRoundPoints = myRound.player2LastRoundPoints
        MainMenu.tbPlayer1AccumPoints.Text = myGame.Player1.getPoints()
        MainMenu.tbPlayer2AccumPoints.Text = myGame.Player2.getPoints()
        ' update dgv with game details
        TopPlayers.DataGridView1.Rows.Add(myGame.Player1.getPoints().ToString, myGame.Player1.getName, " ")
        TopPlayers.sortTheGrid() 'sort list maybe
        'TopPlayers.writeTheFile() write the DGV to file
        'give response, ask to play again
        pointsDisplay = myGame.Player1.getPoints
        responseToPlayerDeath(myGame.Player1, pointsDisplay)
        'zero player1 total points
        myGame.Player1.setPoints(0)
        tbPlayer1TotalPoints.Text = myGame.Player1.getPoints() 'zero player1 total points display

    End Sub

    Public Sub haveKilledOpposingPlayer1cham3()
        'claim points, write to displays, and mygame
        myRound.player1LastRoundPoints = 300
        tbPlayer1LastRoundPoints.Text = myRound.player1LastRoundPoints
        myGame.Player1.setPoints(myGame.Player1.getPoints + myRound.player1LastRoundPoints)
        myGame.Player1.lastRoundPoints = myRound.player1LastRoundPoints
        MainMenu.tbPlayer1AccumPoints.Text = myGame.Player1.getPoints()
        MainMenu.tbPlayer2AccumPoints.Text = myGame.Player2.getPoints()
        'computer is playing
        If myGame.round.computerIsPlaying Then
            Dim response As MsgBoxResult
            response = MsgBox("Well done " & myGame.Player1.getName & ", you have killed the computer. You have Total points " _
                              & myGame.Player1.getPoints & " so far. Do you wish to play again?", MsgBoxStyle.YesNo)
            If response = MsgBoxResult.Yes Then
                Me.Close()
            Else
                MainMenu.gameFinished = True
                Me.Close()
            End If
        Else
            'update dgv with game details
            TopPlayers.DataGridView1.Rows.Add(myGame.Player2.getPoints().ToString, myGame.Player2.getName, " ")
            TopPlayers.sortTheGrid() 'sort list maybe
            'TopPlayers.writeTheFile() write the DGV to file
            'give response, ask to play again
            pointsDisplay = myGame.Player2.getPoints
            responseToPlayerDeath(myGame.Player2, pointsDisplay)
            'zero player2 total points
            myGame.Player2.setPoints(0)
            tbPlayer2TotalPoints.Text = myGame.Player2.getPoints() 'zero player2 total points display
        End If
    End Sub

    Public Sub havePassedLastTurnPlayer1()
        'not died, completed all turns, write points
        myRound.player1LastRoundPoints = 300
        tbPlayer1LastRoundPoints.Text = myRound.player1LastRoundPoints
        myGame.Player1.setPoints(myGame.Player1.getPoints + myRound.player1LastRoundPoints)
        tbPlayer1TotalPoints.Text = myGame.Player1.getPoints
        myGame.Player1.lastRoundPoints = myRound.player1LastRoundPoints
        MainMenu.tbPlayer1AccumPoints.Text = myGame.Player1.getPoints
    End Sub

    Public Sub havePassedLastTurnPlayer2()
        'not died, completed all turns, write points
        myRound.player2LastRoundPoints = 300
        tbPlayer2LastRoundPoints.Text = myRound.player2LastRoundPoints
        myGame.Player2.setPoints(myGame.Player2.getPoints + myRound.player2LastRoundPoints)
        tbPlayer2TotalPoints.Text = myGame.Player2.getPoints
        myGame.Player2.lastRoundPoints = myRound.player2LastRoundPoints
        MainMenu.tbPlayer2AccumPoints.Text = myGame.Player2.getPoints
    End Sub

    Public Sub havePassedOneTurnPlayer1()
        'have not died, add points to round and total
        myRound.player1LastRoundPoints = 100
        tbPlayer1LastRoundPoints.Text = myRound.player1LastRoundPoints
        myGame.Player1.setPoints(myGame.Player1.getPoints + myRound.player1LastRoundPoints)
        tbPlayer1TotalPoints.Text = myGame.Player1.getPoints
        myGame.Player1.lastRoundPoints = myRound.player1LastRoundPoints
        MainMenu.tbPlayer1AccumPoints.Text = myGame.Player1.getPoints
    End Sub

    Public Sub havePassedOneTurnPlayer2()
        'have not died, add points to round and total
        myRound.player2LastRoundPoints = 100
        tbPlayer2LastRoundPoints.Text = myRound.player2LastRoundPoints
        myGame.Player2.setPoints(myGame.Player2.getPoints + myRound.player2LastRoundPoints)
        tbPlayer2TotalPoints.Text = myGame.Player2.getPoints
        myGame.Player2.lastRoundPoints = myRound.player2LastRoundPoints
        MainMenu.tbPlayer2AccumPoints.Text = myGame.Player2.getPoints
    End Sub

    Public Sub haveDiedMyselfPlayer1()
        'round points 0, msg ask if play again, if y go back to menu screen, display points there
        myRound.player1LastRoundPoints = 0
        tbPlayer1LastRoundPoints.Text = myRound.player1LastRoundPoints
        MainMenu.tbPlayer1AccumPoints.Text = myGame.Player1.getPoints
        pointsDisplay = myGame.Player1.getPoints
        ' update dgv with game details
        TopPlayers.DataGridView1.Rows.Add(myGame.Player1.getPoints().ToString, myGame.Player1.getName, " ")
        TopPlayers.sortTheGrid() 'sort list maybe
        'TopPlayers.writeTheFile() write the DGV to file
        responseToPlayerDeath(myGame.Player1, pointsDisplay)
        myGame.Player1.setPoints(0) 'resets points total to zero
        tbPlayer1TotalPoints.Text = myGame.Player1.getPoints 'zero totalpoints display
    End Sub

    Public Sub responseToPlayerDeath(player As Player, pointsTotal As Integer)
        Dim response As MsgBoxResult
        response = MsgBox("I'm sorry " & player.getName & " but you are dead. Total points " & pointsTotal &
                                     " Do you wish to play again?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            Me.Close()
        Else
            MainMenu.gameFinished = True
            Me.Close()
        End If
    End Sub

    Public Sub playAgainRoutine()
        Dim responseToPlayAgain As MsgBoxResult
        responseToPlayAgain = MsgBox("Do you wish to play the game again?", MsgBoxStyle.YesNo)
        If responseToPlayAgain = MsgBoxResult.Yes Then
            Me.Close()
        Else
            MainMenu.gameFinished = True
            Me.Close()
        End If
    End Sub

    Public Sub haveDiedMyselfPlayer2()
        'round points 0, msg ask if play again, if y go back to menu screen, display points there
        myRound.player2LastRoundPoints = 0
        tbPlayer2LastRoundPoints.Text = myRound.player2LastRoundPoints
        MainMenu.tbPlayer2AccumPoints.Text = myGame.Player2.getPoints
        pointsDisplay = myGame.Player2.getPoints
        ' if computer is playing, do not record score, possibly play again
        If myGame.round.computerIsPlaying Then
            Dim responseToPlayAgain As MsgBoxResult

            responseToPlayAgain = MsgBox("I'm sorry but the computer appears to have shot itself. Do you wish to play the game again?" _
                                         , MsgBoxStyle.YesNo)
            If responseToPlayAgain = MsgBoxResult.Yes Then
                Me.Close()
            Else
                MainMenu.gameFinished = True
                Me.Close()
            End If
        Else
            ' update dgv withdetails of game
            'TopPlayers.readTheFile()
            TopPlayers.DataGridView1.Rows.Add(myGame.Player2.getPoints().ToString, myGame.Player2.getName, " ")
            TopPlayers.sortTheGrid() 'sort list
            'TopPlayers.writeTheFile() write the DGV to file
            'place in list and show, ask if wish to play again
            responseToPlayerDeath(myGame.Player2, pointsDisplay)
            myGame.Player2.setPoints(0) 'resets points total to zero
            tbPlayer2TotalPoints.Text = myGame.Player2.getPoints 'zero total points
        End If
    End Sub

    Private Sub lblPlayer2_Click(sender As Object, e As EventArgs) Handles lblPlayer2.Click

    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Image = My.Resources.gun_to_head_picture

    End Sub

    Private Sub RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RToolStripMenuItem.Click

        'Help.MdiParent = Me
        'Me.Hide()
        Help.ShowDialog()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerLoad.Tick

        TimerLoad.Stop()
        loadBullet()

    End Sub

    Private Sub TimerSpin_Tick(sender As Object, e As EventArgs) Handles TimerSpin.Tick

        TimerSpin.Stop()
        spinChamber()

    End Sub

    Private Sub TimerFireBullet_Tick(sender As Object, e As EventArgs) Handles TimerFireBullet.Tick

        TimerFireBullet.Stop()
        fireTheBullet()

    End Sub
End Class