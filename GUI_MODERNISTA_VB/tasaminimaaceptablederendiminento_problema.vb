Public Class tasaminimaaceptablederendiminento_problema
    Dim C As Integer = 0
    Private Sub tasaminimaaceptablederendiminento_problema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = True
        Label3.Visible = False
        Label4.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        Panel1.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C = C + 1
        If C = 1 Then
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = False
            Label4.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            Panel1.Visible = False
            Button2.Visible = False
        End If


        If C = 2 Then
            Button2.Visible = True
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = False
            Label4.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            Panel1.Visible = False
        End If
        If C = 3 Then
            Button2.Visible = True
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            Panel1.Visible = False
        End If
        If C = 4 Then
            Button2.Visible = True
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = False
            Panel1.Visible = False
        End If

        If C = 5 Then
            Button2.Visible = True
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            Panel1.Visible = False
        End If

        If C = 6 Then
            Button2.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            Panel1.Visible = True
            Button1.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        C = C - 1
        If C < 1 Then
            Button2.Visible = False
        End If
        If C = 1 Then
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = False
            Label4.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            Panel1.Visible = False
            Button2.Visible = False
        End If


        If C = 2 Then
            Button2.Visible = True
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = False
            Label4.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            Panel1.Visible = False
        End If
        If C = 3 Then
            Button2.Visible = True
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            Panel1.Visible = False
        End If
        If C = 4 Then
            Button2.Visible = True
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = False
            Panel1.Visible = False
        End If

        If C = 5 Then
            Button2.Visible = True
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            Panel1.Visible = False
        End If

        If C = 6 Then
            Button2.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            Panel1.Visible = True
            Button1.Visible = False
        End If

    End Sub
End Class