<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbEntradas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCine = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFuncion = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLMemoria = New System.Windows.Forms.Button()
        Me.btnLResultados = New System.Windows.Forms.Button()
        Me.btnLEntradas = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ltbEntradas = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ltbTotal = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ltbD2 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ltbD1 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ltbSubtotal = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ltbCine = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ltbFuncion = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txbEntradas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbCine)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbFuncion)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESE LOS DATOS"
        '
        'txbEntradas
        '
        Me.txbEntradas.Location = New System.Drawing.Point(6, 86)
        Me.txbEntradas.Name = "txbEntradas"
        Me.txbEntradas.Size = New System.Drawing.Size(228, 23)
        Me.txbEntradas.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingrese el número de entradas"
        '
        'cmbCine
        '
        Me.cmbCine.FormattingEnabled = True
        Me.cmbCine.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbCine.Location = New System.Drawing.Point(6, 37)
        Me.cmbCine.Name = "cmbCine"
        Me.cmbCine.Size = New System.Drawing.Size(100, 23)
        Me.cmbCine.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccione el cine"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(112, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione la función"
        '
        'cmbFuncion
        '
        Me.cmbFuncion.FormattingEnabled = True
        Me.cmbFuncion.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbFuncion.Location = New System.Drawing.Point(112, 37)
        Me.cmbFuncion.Name = "cmbFuncion"
        Me.cmbFuncion.Size = New System.Drawing.Size(119, 23)
        Me.cmbFuncion.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnLMemoria)
        Me.GroupBox2.Controls.Add(Me.btnLResultados)
        Me.GroupBox2.Controls.Add(Me.btnLEntradas)
        Me.GroupBox2.Controls.Add(Me.btnAceptar)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(263, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 118)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACCIONES"
        '
        'btnSalir
        '
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Location = New System.Drawing.Point(128, 77)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(112, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLMemoria
        '
        Me.btnLMemoria.ForeColor = System.Drawing.Color.Black
        Me.btnLMemoria.Location = New System.Drawing.Point(6, 77)
        Me.btnLMemoria.Name = "btnLMemoria"
        Me.btnLMemoria.Size = New System.Drawing.Size(116, 23)
        Me.btnLMemoria.TabIndex = 7
        Me.btnLMemoria.Text = "Limpiar memoria"
        Me.btnLMemoria.UseVisualStyleBackColor = True
        '
        'btnLResultados
        '
        Me.btnLResultados.ForeColor = System.Drawing.Color.Black
        Me.btnLResultados.Location = New System.Drawing.Point(128, 48)
        Me.btnLResultados.Name = "btnLResultados"
        Me.btnLResultados.Size = New System.Drawing.Size(112, 23)
        Me.btnLResultados.TabIndex = 6
        Me.btnLResultados.Text = "Limpiar resultados"
        Me.btnLResultados.UseVisualStyleBackColor = True
        '
        'btnLEntradas
        '
        Me.btnLEntradas.ForeColor = System.Drawing.Color.Black
        Me.btnLEntradas.Location = New System.Drawing.Point(6, 48)
        Me.btnLEntradas.Name = "btnLEntradas"
        Me.btnLEntradas.Size = New System.Drawing.Size(116, 23)
        Me.btnLEntradas.TabIndex = 5
        Me.btnLEntradas.Text = "Limpiar entradas"
        Me.btnLEntradas.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(6, 19)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(234, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.ltbEntradas)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.ltbTotal)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.ltbD2)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.ltbD1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.ltbSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.ltbCine)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ltbFuncion)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(13, 138)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(494, 209)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(126, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Entradas"
        '
        'ltbEntradas
        '
        Me.ltbEntradas.FormattingEnabled = True
        Me.ltbEntradas.ItemHeight = 15
        Me.ltbEntradas.Location = New System.Drawing.Point(126, 49)
        Me.ltbEntradas.Name = "ltbEntradas"
        Me.ltbEntradas.Size = New System.Drawing.Size(50, 154)
        Me.ltbEntradas.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(415, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "TOTAL"
        '
        'ltbTotal
        '
        Me.ltbTotal.FormattingEnabled = True
        Me.ltbTotal.ItemHeight = 15
        Me.ltbTotal.Location = New System.Drawing.Point(415, 49)
        Me.ltbTotal.Name = "ltbTotal"
        Me.ltbTotal.Size = New System.Drawing.Size(65, 154)
        Me.ltbTotal.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(337, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Descuento 2"
        '
        'ltbD2
        '
        Me.ltbD2.FormattingEnabled = True
        Me.ltbD2.ItemHeight = 15
        Me.ltbD2.Location = New System.Drawing.Point(337, 50)
        Me.ltbD2.Name = "ltbD2"
        Me.ltbD2.Size = New System.Drawing.Size(72, 154)
        Me.ltbD2.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(259, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Descuento 1"
        '
        'ltbD1
        '
        Me.ltbD1.FormattingEnabled = True
        Me.ltbD1.ItemHeight = 15
        Me.ltbD1.Location = New System.Drawing.Point(259, 49)
        Me.ltbD1.Name = "ltbD1"
        Me.ltbD1.Size = New System.Drawing.Size(72, 154)
        Me.ltbD1.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(182, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Subtotal"
        '
        'ltbSubtotal
        '
        Me.ltbSubtotal.FormattingEnabled = True
        Me.ltbSubtotal.ItemHeight = 15
        Me.ltbSubtotal.Location = New System.Drawing.Point(182, 49)
        Me.ltbSubtotal.Name = "ltbSubtotal"
        Me.ltbSubtotal.Size = New System.Drawing.Size(71, 154)
        Me.ltbSubtotal.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(70, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cine"
        '
        'ltbCine
        '
        Me.ltbCine.FormattingEnabled = True
        Me.ltbCine.ItemHeight = 15
        Me.ltbCine.Location = New System.Drawing.Point(70, 49)
        Me.ltbCine.Name = "ltbCine"
        Me.ltbCine.Size = New System.Drawing.Size(50, 154)
        Me.ltbCine.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Función"
        '
        'ltbFuncion
        '
        Me.ltbFuncion.BackColor = System.Drawing.SystemColors.Window
        Me.ltbFuncion.FormattingEnabled = True
        Me.ltbFuncion.ItemHeight = 15
        Me.ltbFuncion.Location = New System.Drawing.Point(14, 49)
        Me.ltbFuncion.Name = "ltbFuncion"
        Me.ltbFuncion.Size = New System.Drawing.Size(50, 154)
        Me.ltbFuncion.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201801585_CINE.My.Resources.Resources.Fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(511, 354)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido al Cine"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFuncion As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbEntradas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCine As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLMemoria As Button
    Friend WithEvents btnLResultados As Button
    Friend WithEvents btnLEntradas As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ltbTotal As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ltbD2 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ltbD1 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ltbSubtotal As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ltbCine As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ltbFuncion As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ltbEntradas As ListBox
End Class
