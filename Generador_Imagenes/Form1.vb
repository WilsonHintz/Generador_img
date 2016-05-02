Imports System.Drawing.Drawing2D

Public Class Form1
    Dim flag As New Bitmap(300, 300)
    Dim flagGraphics As Graphics = Graphics.FromImage(flag)
    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click

        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 255))
        Dim path As New GraphicsPath() 'creamos el camino para definir la region

        Dim rectas As PointF() = { 'creamos los puntos para definir las rectas inferiores
            New Point(x_punto1.Text, y_punto1.Text),    'punto 1
            New Point(0, 300),
            New Point(300, 300),
            New Point(x_punto3.Text, y_punto3.Text)}    'punto 3

        Dim horizonte As PointF() = { 'creamos los puntos para definir el horizonte de la tierra
            New Point(x_punto1.Text, y_punto1.Text),    'punto 1
            New Point(x_punto2.Text, y_punto2.Text),    'punto 2
            New Point(x_punto3.Text, y_punto3.Text)}    'punto 3
        scroll1.Value.

        'se dibuja la region
        path.AddLines(rectas)
        path.AddCurve(horizonte, 1.0F)

        Dim [region] As New Region(path) 'Construimos la region a partir del path
        flagGraphics.DrawPath(pen, path)                    'pintamos el perimetro de la region
        flagGraphics.SetClip(region, CombineMode.Replace)   'seteamos el clip
        flagGraphics.FillRegion(Brushes.Blue, region)      'pintamos la region
        PictureBox1.Image = flag                            'dibujamos sobre el objeto en la form
        ' flag.Save("lamao.jpg")


    End Sub
    'carga de coordenadas por defecto para pruebas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x_punto1.Text = 0
        y_punto1.Text = 100

        x_punto2.Text = 200
        y_punto2.Text = 160

        x_punto3.Text = 300
        y_punto3.Text = 200
    End Sub
    'seteo del objeto
    Public Sub CreateBitmapAtRuntime()
        PictureBox1.Size = New Size(400, 400)
        Me.Controls.Add(PictureBox1)
    End Sub
    'carga inicial del form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateBitmapAtRuntime()
        flagGraphics.Clear(Color.Black)
        PictureBox1.Image = flag
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        flagGraphics.Clear(Color.Black)
        PictureBox1.Image = flag
    End Sub
End Class
