Imports System.Drawing.Drawing2D
<Serializable>
Public Class LineObject
    Inherits DrawObject
    Private startPoint As Point
    Private endPoint As Point
    <NonSerialized>
    Private _areaPath As GraphicsPath = Nothing
    <NonSerialized>
    Private _areaPen As Pen = Nothing
    <NonSerialized>
    Private _areaRegion As Region = Nothing
    Public Sub New()
        Me.New(0, 0, 1, 0)
    End Sub
    Public Sub New(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        MyBase.New
        startPoint.X = x1
        startPoint.Y = y1
        endPoint.X = x2
        endPoint.Y = y2
        Initialize()
    End Sub
    Public Overrides Function Clone() As DrawObject
        Dim lineObject As LineObject = New LineObject
        lineObject.startPoint = Me.startPoint
        lineObject.endPoint = Me.endPoint
        FillDrawObjectFields(lineObject)
        Return lineObject
    End Function
    Public Overrides Sub Draw(g As Graphics)
        g.SmoothingMode = SmoothingMode.AntiAlias
        Using pen As New Pen(color, penWidth)
            g.DrawLine(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y)
        End Using
    End Sub
    Public Overrides Function GetHandle(handleNumber As Integer) As Point
        If handleNumber = 1 Then
            Return startPoint
        Else
            Return endPoint
        End If
    End Function
    Public Overrides Function HitTest(point As Point) As Integer
        If Selected Then
            For i As Integer = 1 To HandleCount
                If GetHandleRectangle(i).Contains(point) Then Return i
            Next
        End If
        If PointInObject(point) Then Return 0
        Return -1
    End Function
    Protected Overrides Function PointInObject(point As Point) As Boolean
        CreateObjects
        Return areaRegion.IsVisible(point)
    End Function
    Public Overrides Function IntersectsWith(rectangle As Rectangle) As Boolean
        CreateObjects()
        Return AreaRegion.IsVisible(rectangle)
    End Function
    Public Overrides Function GetHandleCursor(handleNumber As Integer) As Cursor
        Select Case handleNumber
            Case 1
            Case 2
                Return Cursors.SizeAll
            Case Else
                Return Cursors.Default
        End Select
    End Function
    Public Overrides Sub MoveHandleTo(point As Point, handleNumber As Integer)
        If handleNumber = 1 Then
            startPoint = point
        Else
            endPoint = point
        End If
        Invalidate
    End Sub
    Public Overrides Sub Move(deltaX As Integer, deltaY As Integer)
        startPoint.X += deltaX
        startPoint.Y += deltaY
        endPoint.X += deltaX
        endPoint.Y += deltaY
        Invalidate
    End Sub
    Protected Sub Invalidate()
        If areaPath IsNot Nothing Then
            areaPath.Dispose()
            areaPath = Nothing
        End If

        If areaPen IsNot Nothing Then
            areaPen.Dispose()
            areaPen = Nothing
        End If

        If areaRegion IsNot Nothing Then
            areaRegion.Dispose()
            areaRegion = Nothing
        End If
    End Sub
    Protected Overridable Sub CreateObjects()
        If areaPath IsNot Nothing Then Return
        areaPath = New GraphicsPath()
        areaPen = New Pen(Color.Black, 7)
        areaPath.AddLine(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y)
        areaPath.Widen(areaPen)
        areaRegion = New Region(areaPath)
    End Sub
    Public Overrides ReadOnly Property HandleCount As Integer
        Get
            Return 2
        End Get
    End Property
    Protected Property AreaPath As GraphicsPath
        Get
            Return _areaPath
        End Get
        Set(value As GraphicsPath)
            _areaPath = value
        End Set
    End Property
    Protected Property AreaPen As Pen
        Get
            Return _AreaPen
        End Get
        Set(value As Pen)
            _areaPen = value
        End Set
    End Property
    Protected Property AreaRegion As Region
        Get
            Return _areaRegion
        End Get
        Set(value As Region)
            _areaRegion = value
        End Set
    End Property
End Class
