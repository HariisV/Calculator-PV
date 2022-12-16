Imports System.Formats
Imports System.Linq.Expressions

Public Class Form1
    Dim result As Integer
    Sub PlaySystemSound()
        My.Computer.Audio.PlaySystemSound(
        System.Media.SystemSounds.Asterisk)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Total.Text <> "0" Then
            Total.Text += "1"
        Else
            Total.Text = "1"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Total.Text <> "0" Then
            Total.Text += "2"
        Else
            Total.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Total.Text <> "0" Then
            Total.Text += "3"
        Else
            Total.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Total.Text <> "0" Then
            Total.Text += "4"
        Else
            Total.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Total.Text <> "0" Then
            Total.Text += "5"
        Else
            Total.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Total.Text <> "0" Then
            Total.Text += "6"
        Else
            Total.Text = "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Total.Text <> "0" Then
            Total.Text += "7"
        Else
            Total.Text = "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Total.Text <> "0" Then
            Total.Text += "8"
        Else
            Total.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Total.Text <> "0" Then
            Total.Text += "9"
        Else
            Total.Text = "9"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Total.Text <> "0" And Total.Text <> "0." Then
            Total.Text += "0"
        ElseIf Total.Text = "0." Then
            Total.Text = "0."
            PlaySystemSound()
        Else
            Total.Text = "0"
            PlaySystemSound()
        End If
    End Sub

    Private Sub Deleted_Click(sender As Object, e As EventArgs) Handles Deleted.Click
        Dim Temp = Total.Text.Substring(0, Total.Text.Length - 1)
        If Temp = "" Then
            Total.Text = "0"
        Else
            Total.Text = Temp
        End If
    End Sub

    Private Sub Addition_Click(sender As Object, e As EventArgs) Handles Addition.Click
        Dim last As String = Total.Text
        Dim getLast = last(last.Length - 1)

        If getLast = "," Then
            Dim Temp = Total.Text.Substring(0, Total.Text.Length - 1)
            Total.Text = Temp
        End If

        If getLast = "+" Or getLast = "-" Or getLast = "*" Or getLast = "/" Then
            Dim Temp = Total.Text.Substring(0, Total.Text.Length - 1)
            Total.Text = Temp + "+"
        Else
            Total.Text += "+"
        End If
    End Sub

    Private Sub Subtraction_Click(sender As Object, e As EventArgs) Handles Subtraction.Click
        Dim last As String = Total.Text
        Dim getLast = last(last.Length - 1)

        If getLast = "," Then
            Dim Temp = Total.Text.Substring(0, Total.Text.Length - 1)
            Total.Text = Temp
        End If

        If getLast = "+" Or getLast = "-" Or getLast = "*" Or getLast = "/" Then
            Dim Temp = Total.Text.Substring(0, Total.Text.Length - 1)
            Total.Text = Temp + "-"
        Else
            Total.Text += "-"
        End If
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click
        Dim last As String = Total.Text
        Dim getLast = last(last.Length - 1)

        If getLast = "," Then
            Dim Temp = Total.Text.Substring(0, Total.Text.Length - 1)
            Total.Text = Temp
        End If

        If getLast = "+" Or getLast = "-" Or getLast = "*" Or getLast = "/" Then
            Dim Temp = Total.Text.Substring(0, Total.Text.Length - 1)
            Total.Text = Temp + "/"
        Else
            Total.Text += "/"
        End If
    End Sub

    Private Sub Multiplication_Click(sender As Object, e As EventArgs) Handles Multiplication.Click
        Dim last As String = Total.Text
        Dim getLast = last(last.Length - 1)

        If getLast = "," Then
            Dim Temp = Total.Text.Substring(0, Total.Text.Length - 1)
            Total.Text = Temp
        End If

        If getLast = "+" Or getLast = "-" Or getLast = "*" Or getLast = "/" Then
            Dim Temp = Total.Text.Substring(0, Total.Text.Length - 1)
            Total.Text = Temp + "*"
        Else
            Total.Text += "*"
        End If
    End Sub

    Private Sub Point_Click(sender As Object, e As EventArgs) Handles Comma.Click
        Dim last As String = Total.Text
        Dim getLast = last(last.Length - 1)
        Dim titik As String = ","

        Dim Res = Total.Text.Split(New [Char]() {CChar(vbTab), "+"c, "-"c, "*"c, "/"c})
        Dim LengthRes = Res.Length() - 1
        Dim checkTitik As Integer = Res(LengthRes).IndexOf(titik)

        If checkTitik = "-1" And getLast <> "+" And getLast <> "-" And getLast <> "*" And getLast <> "/" Then
            Total.Text += ","
        Else
            PlaySystemSound()
        End If

    End Sub


    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim last As String = Total.Text

        Dim getLast = last(last.Length - 1)

        If getLast = "+" Or getLast = "-" Or getLast = "*" Or getLast = "/" Or getLast = "," Then
            Dim Temp = Total.Text.Substring(0, Total.Text.Length - 1)
            Total.Text = Temp
        End If

        If last = "0" Then
            PlaySystemSound()
        Else

            Form2.StartPosition = FormStartPosition.CenterParent
            Form2.ShowDialog()

        End If
    End Sub
End Class