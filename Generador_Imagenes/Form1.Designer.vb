<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.x_punto1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.y_punto1 = New System.Windows.Forms.TextBox()
        Me.x_punto2 = New System.Windows.Forms.TextBox()
        Me.y_punto2 = New System.Windows.Forms.TextBox()
        Me.x_punto3 = New System.Windows.Forms.TextBox()
        Me.y_punto3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.scroll1 = New System.Windows.Forms.HScrollBar()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(26, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 300)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(425, 272)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(126, 51)
        Me.btn_generar.TabIndex = 1
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'x_punto1
        '
        Me.x_punto1.Location = New System.Drawing.Point(432, 62)
        Me.x_punto1.Name = "x_punto1"
        Me.x_punto1.Size = New System.Drawing.Size(50, 20)
        Me.x_punto1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(382, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Punto 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(429, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(498, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "y"
        '
        'y_punto1
        '
        Me.y_punto1.Location = New System.Drawing.Point(501, 62)
        Me.y_punto1.Name = "y_punto1"
        Me.y_punto1.Size = New System.Drawing.Size(50, 20)
        Me.y_punto1.TabIndex = 6
        '
        'x_punto2
        '
        Me.x_punto2.Location = New System.Drawing.Point(432, 99)
        Me.x_punto2.Name = "x_punto2"
        Me.x_punto2.Size = New System.Drawing.Size(50, 20)
        Me.x_punto2.TabIndex = 7
        '
        'y_punto2
        '
        Me.y_punto2.Location = New System.Drawing.Point(501, 99)
        Me.y_punto2.Name = "y_punto2"
        Me.y_punto2.Size = New System.Drawing.Size(50, 20)
        Me.y_punto2.TabIndex = 8
        '
        'x_punto3
        '
        Me.x_punto3.Location = New System.Drawing.Point(432, 134)
        Me.x_punto3.Name = "x_punto3"
        Me.x_punto3.Size = New System.Drawing.Size(50, 20)
        Me.x_punto3.TabIndex = 9
        '
        'y_punto3
        '
        Me.y_punto3.Location = New System.Drawing.Point(501, 134)
        Me.y_punto3.Name = "y_punto3"
        Me.y_punto3.Size = New System.Drawing.Size(50, 20)
        Me.y_punto3.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(382, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Punto 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Punto 3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(453, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "default"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(453, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Fondo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'scroll1
        '
        Me.scroll1.Location = New System.Drawing.Point(9, 380)
        Me.scroll1.Maximum = 300
        Me.scroll1.Minimum = 1
        Me.scroll1.Name = "scroll1"
        Me.scroll1.Size = New System.Drawing.Size(345, 17)
        Me.scroll1.TabIndex = 15
        Me.scroll1.Value = 1
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(6, 65)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 297)
        Me.VScrollBar1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 406)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.scroll1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.y_punto3)
        Me.Controls.Add(Me.x_punto3)
        Me.Controls.Add(Me.y_punto2)
        Me.Controls.Add(Me.x_punto2)
        Me.Controls.Add(Me.y_punto1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.x_punto1)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_generar As Button
    Friend WithEvents x_punto1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents y_punto1 As TextBox
    Friend WithEvents x_punto2 As TextBox
    Friend WithEvents y_punto2 As TextBox
    Friend WithEvents x_punto3 As TextBox
    Friend WithEvents y_punto3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents scroll1 As HScrollBar
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
