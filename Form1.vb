Public Class MainMenu

    Public myGame As New GameScreen
    Public gameFinished As Boolean = False


    Private Sub btn2Player_Click(sender As Object, e As EventArgs) Handles btn2Player.Click

        tbPlayer1Name.Enabled = True
        tbPlayer2Name.Enabled = True
        myGame.round.twoHumansPlaying = True
        myGame.round.computerIsPlaying = False

    End Sub

    Private Sub btnComVsPlayer_Click(sender As Object, e As EventArgs) Handles btnComVsPlayer.Click

        tbPlayer1Name.Enabled = True
        tbPlayer2Name.Text = "Computer"
        myGame.round.computerIsPlaying = True
        myGame.round.twoHumansPlaying = False

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        If tbPlayer1Name.Text <> "" Then

            myGame.Player1.setName(tbPlayer1Name.Text)
            Game.lblPlayer1.Text = tbPlayer1Name.Text
            Game.lblPlayer1Other.Text = tbPlayer1Name.Text
            If tbPlayer2Name.Text <> "" Then

                myGame.Player2.setName(tbPlayer2Name.Text)
                Game.lblPlayer2.Text = tbPlayer2Name.Text
                Game.lblPlayer2Other.Text = tbPlayer2Name.Text
                Game.initializeRound()
                Me.Hide()
                Game.ShowDialog()

                If gameFinished = True Then
                    Me.Close()
                Else
                    Me.Show()
                End If

            End If
        End If

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TopPlayers.readTheFile()
        'TopPlayers.sortTheGrid()



    End Sub
End Class

