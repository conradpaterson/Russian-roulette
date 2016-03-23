Public Class Player

    Private name As String
    Private totalPoints As Integer = 0
    Public lastRoundPoints As Integer = 0
    Private remark As String

    Public Sub setName(theName As String)
        name = theName
    End Sub

    Public Function getName() As String
        Return name
    End Function

    Public Sub setPoints(thePoints As Integer)
        totalPoints = thePoints
    End Sub

    Public Function getPoints() As Integer
        Return totalPoints
    End Function

    Public Sub setRemark(theRemark As String)
        remark = theRemark
    End Sub

End Class
