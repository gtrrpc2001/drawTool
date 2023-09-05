Imports System.Drawing.Drawing2D

<Serializable>
Public Class PencilObejct
    Inherits LineObject
    Private pointList As List(Of Point)
    Public Sub New()
        MyBase.New()
        pointList = New List(Of Point)()
        Initialize()
    End Sub
    Public Sub New(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        MyBase.New()
        pointList = New List(Of Point)
        pointList.Add(New Point(x1, y1))
        pointList.Add(New Point(x2, y2))
        Initialize()
    End Sub
    Public Overrides Function Clone() As DrawObject
        Dim pencilObject As PencilObejct = New PencilObejct
        For Each p As Point In Me.pointList
            pencilObject.pointList.Add(p)
        Next
        FillDrawObjectFields(pencilObject)
        Return pencilObject
    End Function
    Public Overrides Sub Draw(g As Graphics)
        Dim x1 As Integer = 0, y1 = 0, x2 = 0, y2 = 0
        g.SmoothingMode = SmoothingMode.AntiAlias
        Using pen As New Pen(DrawObject.color, DrawObject.penWidth)
            Dim enumerator As IEnumerator(Of Point) = pointList.GetEnumerator()
            If enumerator.MoveNext Then
                x1 = (CType(enumerator.Current, Point)).X
                y1 = (CType(enumerator.Current, Point)).Y
            End If
            While enumerator.MoveNext()
                x2 = (CType(enumerator.Current, Point)).X
                y2 = (CType(enumerator.Current, Point)).Y
                g.DrawLine(pen, x1, y1, x2, y2)
                x1 = x2
                y1 = y2
            End While
        End Using
    End Sub
    Public Sub AddPoint(point As Point)
        pointList.Add(point)
    End Sub
    Public Overrides Function GetHandle(handleNumber As Integer) As Point
        If handleNumber < 1 Then handleNumber = 1
        If handleNumber > pointList.Count Then handleNumber = pointList.Count
        Return (CType(pointList(handleNumber - 1), Point))
    End Function
    Public Overrides Sub MoveHandleTo(point As Point, handleNumber As Integer)
        If handleNumber < 1 Then handleNumber = 1
        If handleNumber > pointList.Count Then handleNumber = pointList.Count
        pointList(handleNumber - 1) = point
        Invalidate()
    End Sub
    Public Overrides Sub Move(deltaX As Integer, deltaY As Integer)
        Dim n As Integer = pointList.Count
        Dim point As Point
        For i = 0 To n - 1
            point = New Point((CType(pointList(i), Point)).X + deltaX, (CType(pointList(i), Point)).Y + deltaY)
            pointList(i) = point
        Next
        Invalidate()
    End Sub
    Protected Overrides Sub CreateObjects()
        If AreaPath IsNot Nothing Then Return
        AreaPath = New GraphicsPath
        Dim x1 As Integer = 0, y1 = 0, x2 = 0, y2 = 0
        Dim enumerator As IEnumerator(Of Point) = pointList.GetEnumerator
        If enumerator.MoveNext Then
            x1 = (CType(enumerator.Current, Point)).X
            y1 = (CType(enumerator.Current, Point)).Y
        End If
        While enumerator.MoveNext
            x2 = (CType(enumerator.Current, Point)).X
            y2 = (CType(enumerator.Current, Point)).Y
            AreaPath.AddLine(x1, y1, x2, y2)
            x1 = x2
            y1 = y2
        End While
        AreaPath.CloseFigure()
        AreaRegion = New Region(AreaPath)
    End Sub
    Public Overrides ReadOnly Property HandleCount As Integer
        Get
            Return pointList.Count
        End Get
    End Property
End Class
