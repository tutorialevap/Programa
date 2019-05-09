<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SubmenuReportes = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btnrptventa = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.tmOCULTAR = New System.Windows.Forms.Timer(Me.components)
        Me.tmMOSTRAR = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.SubmenuReportes.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.Plum
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(1150, 18)
        Me.PanelCabecera.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.button1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.button5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.SubmenuReportes)
        Me.Panel1.Controls.Add(Me.button3)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 582)
        Me.Panel1.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Plum
        Me.Panel6.Location = New System.Drawing.Point(0, 275)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(8, 30)
        Me.Panel6.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Plum
        Me.Panel3.Location = New System.Drawing.Point(0, 337)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(8, 30)
        Me.Panel3.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Plum
        Me.Panel2.Location = New System.Drawing.Point(0, 206)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(8, 30)
        Me.Panel2.TabIndex = 2
        '
        'SubmenuReportes
        '
        Me.SubmenuReportes.Controls.Add(Me.Panel4)
        Me.SubmenuReportes.Controls.Add(Me.ComboBox2)
        Me.SubmenuReportes.Controls.Add(Me.btnrptventa)
        Me.SubmenuReportes.Controls.Add(Me.Panel5)
        Me.SubmenuReportes.Controls.Add(Me.ComboBox1)
        Me.SubmenuReportes.Controls.Add(Me.panel9)
        Me.SubmenuReportes.Location = New System.Drawing.Point(14, 386)
        Me.SubmenuReportes.Name = "SubmenuReportes"
        Me.SubmenuReportes.Size = New System.Drawing.Size(247, 124)
        Me.SubmenuReportes.TabIndex = 16
        Me.SubmenuReportes.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Plum
        Me.Panel4.Location = New System.Drawing.Point(0, 31)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 24)
        Me.Panel4.TabIndex = 18
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Teoría", "Tutorial paso a paso"})
        Me.ComboBox2.Location = New System.Drawing.Point(10, 31)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(227, 21)
        Me.ComboBox2.TabIndex = 0
        Me.ComboBox2.Text = "Selecciona el tipo de estudio"
        '
        'btnrptventa
        '
        Me.btnrptventa.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnrptventa.FlatAppearance.BorderSize = 0
        Me.btnrptventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnrptventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrptventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrptventa.ForeColor = System.Drawing.Color.White
        Me.btnrptventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrptventa.Location = New System.Drawing.Point(118, 73)
        Me.btnrptventa.Name = "btnrptventa"
        Me.btnrptventa.Size = New System.Drawing.Size(95, 28)
        Me.btnrptventa.TabIndex = 17
        Me.btnrptventa.Text = "Comenzar"
        Me.btnrptventa.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Plum
        Me.Panel5.Location = New System.Drawing.Point(112, 76)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 24)
        Me.Panel5.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Inversión total inicial", "Anualidades (CAUE)", "Costo-beneficio con anualidades simples", "Costo-beneficio con anualidades perpetuas", "Punto de equilibrio en dinero", "Punto de equilibrio en unidades", "Rentabilidad", "Tasa mínima aceptable de rendimiento ", "Tasa mínima aceptable de rendimiento mixta", "Valor presente neto (con TMAR)", "Valor presente neto (con anualidad e interés)", "Valor presente neto (con anualidad perpetua)", "Tasa interna de retorno", "Interés simple", "Interés compuesto ", "Valor futuro con interés compuesto ", "Valor presente con interés compuesto", "Interés compuesto con gradiente aritmético", "Interés efectivo", "Periodo de recuperación de la inversión"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 2)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Selecciona el tema"
        '
        'panel9
        '
        Me.panel9.BackColor = System.Drawing.Color.Plum
        Me.panel9.Location = New System.Drawing.Point(0, 0)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(5, 24)
        Me.panel9.TabIndex = 17
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Plum
        Me.Panel10.Location = New System.Drawing.Point(0, 145)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(8, 30)
        Me.Panel10.TabIndex = 1
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelContenedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(268, 18)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(882, 582)
        Me.PanelContenedor.TabIndex = 2
        '
        'tmOCULTAR
        '
        '
        'tmMOSTRAR
        '
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(15, 275)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(249, 39)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Acerca del equipo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(14, 337)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(247, 30)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Temas CENEVAL"
        Me.button1.UseVisualStyleBackColor = False
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.White
        Me.button5.Image = CType(resources.GetObject("button5.Image"), System.Drawing.Image)
        Me.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button5.Location = New System.Drawing.Point(14, 206)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(247, 32)
        Me.button5.TabIndex = 10
        Me.button5.Text = "Instrucciones"
        Me.button5.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.White
        Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.Location = New System.Drawing.Point(14, 149)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(247, 28)
        Me.button3.TabIndex = 6
        Me.button3.Text = "Introducción"
        Me.button3.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.GUI_MODERNISTA_VB.My.Resources.Resources.logoevap
        Me.PictureBox5.Location = New System.Drawing.Point(15, 19)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(241, 92)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 600)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutorial Ceneval"
        Me.Panel1.ResumeLayout(False)
        Me.SubmenuReportes.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelCabecera As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents tmOCULTAR As System.Windows.Forms.Timer
    Friend WithEvents tmMOSTRAR As System.Windows.Forms.Timer
    Private WithEvents SubmenuReportes As Panel
    Private WithEvents panel9 As Panel
    Friend WithEvents Panel3 As Panel
    Private WithEvents button5 As Button
    Friend WithEvents Panel2 As Panel
    Private WithEvents button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Private WithEvents button1 As Button
    Private WithEvents btnrptventa As Button
    Private WithEvents Panel5 As Panel
    Private WithEvents Panel4 As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel6 As Panel
    Private WithEvents Button2 As Button
End Class
