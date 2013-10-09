Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim pop As Double
        Dim Year As Integer
        Year = 2012
        pop = 7000000000
        Do While pop > 6000000
            'While the population is over 6M keep going if it is less stop
            Year = Year - 50
            pop = pop / 2

        Loop

        MessageBox.Show("In " & Year & " the population was 6 million")

    End Sub
End Class
