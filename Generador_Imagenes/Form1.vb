Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Dim flag As New Bitmap(400, 300)
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 255))
        Dim flagGraphics As Graphics = Graphics.FromImage(flag)
        Dim path As New GraphicsPath() 'creamos el camino para definir la region

        Dim rectas As PointF() = { 'creamos los puntos para definir las rectas inferiores
            New Point(0, 110),
            New Point(0, 300),
            New Point(300, 300),
            New Point(300, 200)}

        Dim horizonte As PointF() = { 'creamos los puntos para definir el horizonte de la tierra
            New Point(0, 110),
            New Point(200, 110),
            New Point(300, 200)}

        'path.AddPolygon(points) 'Le damos al path los puntos para armarse
        path.AddLines(rectas)
        path.AddCurve(horizonte, 1.0F)

        Dim [region] As New Region(path) 'Construimos la region a partir del path

        flagGraphics.DrawPath(pen, path)                    'pintamos el perimetro de la region
        flagGraphics.SetClip(region, CombineMode.Replace)   'seteamos el clip
        flagGraphics.FillRegion(Brushes.Green, region)      'pintamos la region
        PictureBox1.Image = flag                            'dibujamos sobre el objeto en la form
        ' flag.Save("lamao.jpg")

    End Sub

    Public Sub CreateBitmapAtRuntime()
        PictureBox1.Size = New Size(400, 400)
        Me.Controls.Add(PictureBox1)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateBitmapAtRuntime()
    End Sub

End Class
