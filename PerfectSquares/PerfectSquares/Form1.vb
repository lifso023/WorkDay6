﻿Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click


        Dim num As Integer = 1
        Do While num <= 10

            lstResult.Items.Add("The perfect square is: " & num ^ 2)
            num = num + 1
        Loop



    End Sub
End Class
