<Serializable>
Public Class EllipseObject
    Inherits RectangleObject
    Public Sub New()
        Me.New(0, 0, 1, 1)
    End Sub
    Public Sub New(x As Integer, y As Integer, width As Integer, height As Integer)
        MyBase.New
        Rectangle = New Rectangle(x, y, width, height)
        Initialize()
    End Sub
    Public Overrides Function Clone() As DrawObject
        Dim ellipseObject As EllipseObject = New EllipseObject
        ellipseObject.Rectangle = Me.Rectangle
        FillDrawObjectFields(ellipseObject)
        Return ellipseObject
    End Function
    Public Overrides Sub Draw(g As Graphics)
        Using pen As New Pen(DrawObject.color, DrawObject.penWidth)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            g.DrawEllipse(pen, RectangleObject.GetNormalizedRectangle(Rectangle))
            Using brush As New SolidBrush(DrawObject.backColor)
                g.FillEllipse(brush, Rectangle)
            End Using
        End Using
    End Sub
End Class
