Public Class Periododerecuperaciondelainversion_problema
    Dim C As Integer = 0
    Private Sub Periododerecuperaciondelainversion_problema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label3.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label4.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        Panel1.Visible = False
        Button2.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C = C + 1
        If C = 1 Then
            Label1.Visible = True
            Label3.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label4.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = False
            Button1.Visible = True
        End If

        If C = 2 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = False
            Label6.Visible = False
            Label4.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 3 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = False
            Label4.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 4 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = False
            Label4.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 5 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = False
            Label4.Visible = True
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 6 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = False
            Label4.Visible = True
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 7 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label4.Visible = True
            Label7.Visible = True
            Label8.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 8 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label4.Visible = True
            Label7.Visible = True
            Label8.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 9 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label4.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = True
            Panel1.Visible = True
            Button2.Visible = True
            Button1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        C = C - 1
        If C < 1 Then
            Button2.Visible = False
        End If
        If C = 1 Then
            Label1.Visible = True
            Label3.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label4.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = False
            Button1.Visible = True
        End If

        If C = 2 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = False
            Label6.Visible = False
            Label4.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 3 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = False
            Label4.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 4 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = False
            Label4.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 5 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = False
            Label4.Visible = True
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 6 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = False
            Label4.Visible = True
            Label7.Visible = False
            Label8.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 7 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label4.Visible = True
            Label7.Visible = True
            Label8.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 8 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label4.Visible = True
            Label7.Visible = True
            Label8.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = False
            Panel1.Visible = False
            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 9 Then
            Label1.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label4.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = True
            Panel1.Visible = True
            Button2.Visible = True
            Button1.Visible = False
        End If
    End Sub
End Class