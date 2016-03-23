Imports System
Imports System.ComponentModel

Imports System.IO


Public Class TopPlayers

    Dim direction As ListSortDirection
    Dim myColumn As DataGridViewColumn

    Dim path As String = "\\telmar\Users\cp020\Desktop\RRplayersTop20.txt"

    Public Sub sortTheGrid()

        direction = System.ComponentModel.ListSortDirection.Descending
        ' myColumn =
        DataGridView1.Sort(DataGridView1.Columns("Score"), direction)

    End Sub

    Public Sub readTheFile()

        Dim wholeLineRead() As String
        Dim Line As String

        Try
            Dim fileread As StreamReader
            fileread = New StreamReader(path)

            Do Until fileread.EndOfStream
                Line = fileread.ReadLine
                wholeLineRead = Line.Split("|")
                DataGridView1.Rows.Add(wholeLineRead(0), wholeLineRead(1), wholeLineRead(2))

            Loop

            fileread.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub writeTheFile()

        Dim Line As String

        Try

            Dim fileWrite As StreamWriter
            fileWrite = New StreamWriter(path)

            Dim count As Integer = DataGridView1.RowCount

            For number = 0 To (count - 2)
                Line = (DataGridView1.Rows(number).Cells(0).Value & "|" & DataGridView1.Rows(number).Cells(1).Value & "|" _
                        & DataGridView1.Rows(number).Cells(2).Value)
                fileWrite.WriteLine(Line)
            Next

            fileWrite.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TopPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        readTheFile()
        sortTheGrid()
    End Sub

    Private Sub btnReturnMainMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMainMenu.Click

        Me.Hide()
        MainMenu.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class