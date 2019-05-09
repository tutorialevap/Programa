Imports System.Runtime.InteropServices
Public Class Form1
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)

        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub tmOCULTAR_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR.Tick
        If Panel1.Width <= 60 Then
            Me.tmOCULTAR.Enabled = False
        Else
            Me.Panel1.Width = Panel1.Width - 20
        End If
    End Sub

    Private Sub tmMOSTRAR_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR.Tick
        If Panel1.Width >= 220 Then
            Me.tmMOSTRAR.Enabled = False
        Else
            Me.Panel1.Width = Panel1.Width + 20
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs)
        If Panel1.Width = 280 Then
            tmOCULTAR.Enabled = True
        ElseIf Panel1.Width = 60 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(New FormDashboard)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        SubmenuReportes.Visible = True
    End Sub


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        SubmenuReportes.Visible = True
    End Sub
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        AbrirFormEnPanel(New FormDashboard)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormEnPanel(New Fondologo)
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        AbrirFormEnPanel(New Instrucciones)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(New Acercade)
    End Sub

    Private Sub btnrptventa_Click(sender As Object, e As EventArgs) Handles btnrptventa.Click
        If ComboBox1.Text = "Anualidades (CAUE)" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New Anualidades_Problema)
        End If
        If ComboBox1.Text = "Tasa mínima aceptable de rendimiento " And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New tasaminimaaceptablederendiminento_problema)
        End If
        If ComboBox1.Text = "Tasa mínima aceptable de rendimiento mixta" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New tasaminimaaceptablederendimientomixta_problema)
        End If

        If ComboBox1.Text = "Interés compuesto " And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New interescompuesto_problema)
        End If
        If ComboBox1.Text = "Interés simple" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New Interessimple_problema)
        End If
        If ComboBox1.Text = "Valor futuro con interés compuesto " And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New Valorfuturoconinterescompuesto_problema)
        End If
        If ComboBox1.Text = "Valor presente con interés compuesto" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New valorpresenteconinterescompuesto_problema)
        End If
        If ComboBox1.Text = "Interés compuesto con gradiente aritmético" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New Interescompuestocongradientearitmetico_problema)
        End If
        If ComboBox1.Text = "Interés efectivo" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New interesefectivo_problema)
        End If
        If ComboBox1.Text = "Periodo de recuperación de la inversión" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New Periododerecuperaciondelainversion_problema)
        End If
        If ComboBox1.Text = "Valor presente neto (con TMAR)" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New valorpresenteneto_problema)
        End If
        If ComboBox1.Text = "Valor presente neto (con anualidad e interés)" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New valorpresentenetoconanualidad_problema)
        End If
        If ComboBox1.Text = "Valor presente neto (con anualidad perpetua)" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New valorpresentenetoconanualidadperpetua_problema)
        End If
        If ComboBox1.Text = "Tasa interna de retorno" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New tasainternaderetorno_problema)
        End If
        If ComboBox1.Text = "Punto de equilibrio en dinero" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New puntodeequilibrioendinero_problema)
        End If
        If ComboBox1.Text = "Punto de equilibrio en unidades" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New puntodeequilibrioenunidades_problema)
        End If
        If ComboBox1.Text = "Rentabilidad" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New rentabilidad_problemas)
        End If
        If ComboBox1.Text = "Inversión total inicial" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New inversiontotalinicial_problema)
        End If

        If ComboBox1.Text = "Costo-beneficio con anualidades perpetuas" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New costobeneficioconanualidadesperpetuas_problema)
        End If
        If ComboBox1.Text = "Costo-beneficio con anualidades simples" And ComboBox2.Text = "Tutorial paso a paso" Then
            AbrirFormEnPanel(New costobeneficioconanualidadessimples_problema)
        End If






        If (ComboBox1.Text = "Tasa mínima aceptable de rendimiento " And ComboBox2.Text = "Teoría") Or (ComboBox1.Text = "Tasa mínima aceptable de rendimiento mixta" And ComboBox2.Text = "Teoría") Then
            AbrirFormEnPanel(New Tasaminima_teoria)
        End If
        If (ComboBox1.Text = "Valor presente neto (con TMAR)" And ComboBox2.Text = "Teoría") Or (ComboBox1.Text = "Valor presente neto (con anualidad e interés)" And ComboBox2.Text = "Teoría") Or (ComboBox1.Text = "Valor presente neto (con anualidad perpetua)" And ComboBox2.Text = "Teoría") Then
            AbrirFormEnPanel(New Valorpresenteneto_teoria)
        End If
        If ComboBox1.Text = "Tasa interna de retorno" And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New Tasainternaderetorno_teoria)
        End If
        If ComboBox1.Text = "Interés simple" And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New interessimple_teoria)
        End If
        If ComboBox1.Text = "Interés compuesto " And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New interescompuesto_teoria)
        End If
        If ComboBox1.Text = "Valor futuro con interés compuesto " And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New valorfuturo_teoria)
        End If
        If ComboBox1.Text = "Valor presente con interés compuesto" And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New valorpresente_teoria)
        End If

        If ComboBox1.Text = "Interés compuesto con gradiente aritmético" And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New interescompuestogradientefuturo_teoria)
        End If
        If ComboBox1.Text = "Rentabilidad" And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New rentabilidad_teoria)
        End If
        If ComboBox1.Text = "Punto de equilibrio en dinero" And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New puntodeequilibrioendinero_teoria)
        End If
        If ComboBox1.Text = "Punto de equilibrio en unidades" And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New puntodeequilibrioenunidades_teoria)
        End If
        If (ComboBox1.Text = "Costo-beneficio con anualidades simples" Or ComboBox1.Text = "Costo-beneficio con anualidades perpetuas") And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New Cosstobeneficio_teoria)
        End If
        If ComboBox1.Text = "Anualidades (CAUE)" And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New Anualidades_teoria)
        End If
        If ComboBox1.Text = "Inversión total inicial" And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New inversiontotalinicia_teoria)
        End If
        If ComboBox1.Text = "Interés efectivo" And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New interesefectivo_teoria)
        End If
        If ComboBox1.Text = "Periodo de recuperación de la inversión" And ComboBox2.Text = "Teoría" Then
            AbrirFormEnPanel(New periododerecuperacion_teoria)
        End If
    End Sub
End Class
