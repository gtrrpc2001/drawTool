<Serializable>
Public Class RectangleObject
    Inherits DrawObject
    Private _rectangle As Rectangle
    Public Sub New()
        Me.New(0, 0, 1, 1)
    End Sub
    Public Sub New(x As Integer, y As Integer, width As Integer, height As Integer)
        MyBase.New
        _rectangle.X = x
        _rectangle.Y = y
        _rectangle.Width = width
        _rectangle.Height = height
        Initialize()
    End Sub
    Public Overrides Function Clone() As DrawObject
        Dim rectangleObject As RectangleObject = New RectangleObject
        rectangleObject._rectangle = Me._rectangle
        FillDrawObjectFields(rectangleObject)
        Return rectangleObject
    End Function
    Public Overrides Sub Draw(g As Graphics)
        Using pen As New Pen(DrawObject.color, DrawObject.penWidth)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            g.DrawRectangle(pen, RectangleObject.GetNormalizedRectangle(Rectangle))
            Using brush As New SolidBrush(DrawObject.backColor)
                g.FillRectangle(brush, Rectangle)
            End Using
        End Using
    End Sub
    Protected Sub SetRectangle(x As Integer, y As Integer, width As Integer, height As Integer)
        _rectangle.X = x
        _rectangle.Y = y
        _rectangle.Width = width
        _rectangle.Height = height
    End Sub
    Public Overrides Function GetHandle(handleNumber As Integer) As Point
        Dim x As Integer = 0, y = 0, xCenter = 0, yCenter = 0
        xCenter = _rectangle.X + _rectangle.Width / 2
        yCenter = _rectangle.Y + _rectangle.Height / 2
        x = _rectangle.X
        y = _rectangle.Y
        Select Case handleNumber
            Case 1
                x = _rectangle.X
                y = _rectangle.Y
            Case 2
                x = xCenter
                y = _rectangle.Y
            Case 3
                x = _rectangle.Right
                y = _rectangle.Y
            Case 4
                x = _rectangle.Right
                y = yCenter
            Case 5
                x = _rectangle.Right
                y = _rectangle.Bottom
            Case 6
                x = xCenter
                y = _rectangle.Bottom
            Case 7
                x = _rectangle.X
                y = _rectangle.Bottom
            Case 8
                x = _rectangle.X
                y = yCenter
        End Select
        Return New Point(x, y)
    End Function
    Public Overrides Function HitTest(point As Point) As Integer
        If DrawObject.Selected Then
            For i = 0 To HandleCount
                If GetHandleRectangle(i).Contains(point) Then
                    Return i
                End If
            Next
        End If
        If PointInObject(point) Then
            Return 0
        End If
        Return -1
    End Function
    Protected Overrides Function PointInObject(point As Point) As Boolean
        Return _rectangle.Contains(point)
    End Function
    Public Overrides Function GetHandleCursor(handleNumber As Integer) As Cursor
        Select Case handleNumber
            Case 1
                Return Cursors.SizeNWSE
            Case 2
                Return Cursors.SizeNS
            Case 3
                Return Cursors.SizeNESW
            Case 4
                Return Cursors.SizeWE
            Case 5
                Return Cursors.SizeNWSE
            Case 6
                Return Cursors.SizeNS
            Case 7
                Return Cursors.SizeNESW
            Case 8
                Return Cursors.SizeWE
            Case Else
                Return Cursors.Default
        End Select
    End Function
    Public Overrides Sub MoveHandleTo(point As Point, handleNumber As Integer)
        Dim left = Rectangle.Left
        Dim top = Rectangle.Top
        Dim right = Rectangle.Right
        Dim bottom = Rectangle.Bottom
        Select Case handleNumber
            Case 1
                left = point.X
                top = point.Y
            Case 2
                top = point.Y
            Case 3
                right = point.X
                top = point.Y
            Case 4
                right = point.X
            Case 5
                right = point.X
                bottom = point.Y
            Case 6
                bottom = point.Y
            Case 7
                left = point.X
                bottom = point.Y
            Case 8
                left = point.X
        End Select
        SetRectangle(left, top, right - left, bottom - top)
    End Sub
    Public Overrides Function IntersectsWith(_rectangle As Rectangle) As Boolean
        Return Rectangle.IntersectsWith(_rectangle)
    End Function
    Public Overrides Sub Move(deltaX As Integer, deltaY As Integer)
        _rectangle.X += deltaX
        _rectangle.Y += deltaY
    End Sub
    Public Overrides Sub Normalize()
        _rectangle = RectangleObject.GetNormalizedRectangle(_rectangle)
    End Sub
    Public Shared Function GetNormalizedRectangle(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer) As Rectangle
        If x2 < x1 Then
            Dim tmp As Integer = x2
            x2 = x1
            x1 = tmp
        End If
        If y2 < y1 Then
            Dim tmp As Integer = y2
            y2 = y1
            y1 = tmp
        End If
        Return New Rectangle(x1, y1, x2 - x1, y2 - y1)
    End Function
    Public Shared Function GetNormalizedRectangle(p1 As Point, p2 As Point) As Rectangle
        Return GetNormalizedRectangle(p1.X, p1.Y, p2.X, p2.Y)
    End Function
    Public Shared Function GetNormalizedRectangle(r As Rectangle) As Rectangle
        Return GetNormalizedRectangle(r.X, r.Y, r.X + r.Width, r.Y + r.Height)
    End Function
    Public Overrides ReadOnly Property HandleCount As Integer
        Get
            Return 8
        End Get
    End Property
    Protected Property Rectangle As Rectangle
        Get
            Return _rectangle
        End Get
        Set(value As Rectangle)
            _rectangle = value
        End Set
    End Property
End Class
