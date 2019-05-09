Public Class costobeneficioconanualidadessimples2_problemas
    Dim C As Integer = 0

    Private Sub costobeneficioconanualidadessimples2_problemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1.Visible = False
        n2.Visible = False
        n3.Visible = False
        n4.Visible = False
        p1.Visible = False

        p2.Visible = False
        p3.Visible = False
        p4.Visible = False

        p8.Visible = False
        p5.Visible = False

        n5.Visible = False
        n7.Visible = False

        n7.Visible = False
        p6.Visible = False

        p8.Visible = False
        n7.Visible = False
        p9.Visible = False

        Button2.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C = C + 1
        If C = 1 Then
            n1.Visible = True
            n2.Visible = False
            n3.Visible = False
            n4.Visible = False
            p1.Visible = False

            p2.Visible = False
            p3.Visible = False
            p4.Visible = False

            p8.Visible = False
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = False
            Button1.Visible = True
        End If

        If C = 2 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = False
            n4.Visible = False
            p1.Visible = False

            p2.Visible = False
            p3.Visible = False
            p4.Visible = False

            p8.Visible = False
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 3 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = False
            p1.Visible = False

            p2.Visible = False
            p3.Visible = False
            p4.Visible = False

            p8.Visible = False
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 4 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = False
            p3.Visible = False
            p4.Visible = False

            p8.Visible = False
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 5 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = False
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 6 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 7 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 8 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = True
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 9 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = True
            n7.Visible = True

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 10 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = True
            n7.Visible = True

            n7.Visible = True
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 11 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = True
            n7.Visible = True

            n7.Visible = True
            p6.Visible = True

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 11 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = True
            n7.Visible = True

            n7.Visible = True
            p6.Visible = True

            p8.Visible = True
            n7.Visible = True
            p9.Visible = True

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
            n1.Visible = True
            n2.Visible = False
            n3.Visible = False
            n4.Visible = False
            p1.Visible = False

            p2.Visible = False
            p3.Visible = False
            p4.Visible = False

            p8.Visible = False
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = False
            Button1.Visible = True
        End If

        If C = 2 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = False
            n4.Visible = False
            p1.Visible = False

            p2.Visible = False
            p3.Visible = False
            p4.Visible = False

            p8.Visible = False
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 3 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = False
            p1.Visible = False

            p2.Visible = False
            p3.Visible = False
            p4.Visible = False

            p8.Visible = False
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 4 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = False
            p3.Visible = False
            p4.Visible = False

            p8.Visible = False
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 5 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = False
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 6 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = False

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 7 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = False
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 8 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = True
            n7.Visible = False

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 9 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = True
            n7.Visible = True

            n7.Visible = False
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 10 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = True
            n7.Visible = True

            n7.Visible = True
            p6.Visible = False

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 11 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = True
            n7.Visible = True

            n7.Visible = True
            p6.Visible = True

            p8.Visible = False
            n7.Visible = False
            p9.Visible = False

            Button2.Visible = True
            Button1.Visible = True
        End If

        If C = 11 Then
            n1.Visible = True
            n2.Visible = True
            n3.Visible = True
            n4.Visible = True
            p1.Visible = True

            p2.Visible = True
            p3.Visible = True
            p4.Visible = True

            p8.Visible = True
            p5.Visible = True

            n5.Visible = True
            n7.Visible = True

            n7.Visible = True
            p6.Visible = True

            p8.Visible = True
            n7.Visible = True
            p9.Visible = True

            Button2.Visible = True
            Button1.Visible = False
        End If
    End Sub
End Class