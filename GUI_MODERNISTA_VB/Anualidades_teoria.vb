﻿Public Class Anualidades_teoria
    Dim C As Integer = 0
    Private Sub Anualidades_teoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C = C + 1
        If C = 1 Then
            Label1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            Button2.Visible = True
            Button1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        C = C - 1
        If C <= 0 Then
            Button2.Visible = False
        End If

        If C = 0 Then
            Label1.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            Button2.Visible = False
            Button1.Visible = True
        End If
    End Sub
End Class