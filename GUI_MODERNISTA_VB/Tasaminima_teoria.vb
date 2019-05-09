Public Class Tasaminima_teoria
    Dim C As Integer = 0
    Private Sub interessimple_teoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Visible = False
        Label1.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C = C + 1
        If C = 1 Then
            Button2.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = False
        End If

        If C = 2 Then
            Button2.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            Button1.Visible = False
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        C = C - 1
        If C <= 0 Then
            Button2.Visible = False
        End If

        If C = 0 Then
            Button2.Visible = False
            Label1.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
        End If

        If C = 1 Then
            Button2.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            Button1.Visible = True
        End If

        If C = 2 Then
            Button2.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
        End If

    End Sub
End Class