Public Class Round

    Public turnCount As Integer = 1
    Public currentTurnCount As Integer = 1
    Public gunChamberWithBullet As Integer
    Public chamberOnBarrelToFire As Integer
    Public bulletCount As Integer

    Public pointToOpponent As Boolean = False
    Public pointToOpponentCount As Integer
    Public pointToOpponentCounter As Integer
    Public computerPointToOpponentNumber As Integer

    Public player1LastRoundPoints As Integer
    Public player2LastRoundPoints As Integer

    Public player1Turn As Boolean = False
    Public player2Turn As Boolean = False
    Public player1Dead As Boolean = False
    Public player2Dead As Boolean = False

    Public computerIsPlaying As Boolean = False
    Public twoHumansPlaying As Boolean = False

    Public chamber1Play As Boolean = False
    Public chamber3Play As Boolean = False
    Public chamber6Play As Boolean = False

    Public random As New Random

    Public Function getGunChamberWithBullet() As Integer
        Return gunChamberWithBullet
    End Function

    Public Sub setGunChamberWithBullet()
        gunChamberWithBullet = random.Next(1, 7)
    End Sub

    Public Function getChamberOnBarrelToFire() As Integer
        Return chamberOnBarrelToFire
    End Function

    Public Sub setChamberOnBarrelToFire()
        chamberOnBarrelToFire = random.Next(1, 7)
    End Sub

    Public Sub setComputerPointToOpponentNumber()
        computerPointToOpponentNumber = random.Next(1, 4)
    End Sub
End Class
