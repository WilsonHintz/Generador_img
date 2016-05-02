Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Dim flag As New Bitmap(300, 300)
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 255))
        Dim flagGraphics As Graphics = Graphics.FromImage(flag)
        Dim path As New GraphicsPath() 'creamos el camino para definir la region
        Dim points As PointF() = { 'creamos los puntos para definir la region
            New Point(0, 300),
            New Point(50, 80),
            New Point(100, 20),
            New Point(150, 80),
            New Point(200, 100)}
        path.AddPolygon(points) 'Le damos al path los puntos para armarse

        Dim [region] As New Region(path) 'Construimos la region a partir del path

        flagGraphics.DrawPath(pen, path)                    'pintamos el perimetro de la region
        flagGraphics.SetClip(region, CombineMode.Replace)   'seteamos el clip
        flagGraphics.FillRegion(Brushes.Green, region)      'pintamos la region

        'flagGraphics.DrawCurve(pen, points, 1)
        'flagGraphics.DrawCurve(pen, points, 0.6F)
        'flagGraphics.DrawCurve(pen, points, 0.2F)

        PictureBox1.Image = flag
        flag.Save("lamao.jpg")

    End Sub

    Public Sub CreateBitmapAtRuntime()
        PictureBox1.Size = New Size(300, 300)
        Me.Controls.Add(PictureBox1)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateBitmapAtRuntime()
    End Sub

End Class
