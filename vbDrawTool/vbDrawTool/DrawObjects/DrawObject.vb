<Serializable>
Public MustInherit Class DrawObject
    Private Shared _selected As Boolean
    Private Shared _color As Color
    Private Shared _backColor As Color
    Private Shared _penWidth As Integer
#Region "properties"
    Public Shared Property Selected As Boolean
        Get
            Return _selected
        End Get
        Set(value As Boolean)
            _selected = value
        End Set
    End Property
    Public Shared Property color As Color
        Get
            Return _color
        End Get
        Set(value As Color)
            _color = value
        End Set
    End Property
    Public Shared Property backColor As Color
        Get
            Return _backColor
        End Get
        Set(value As Color)
            _backColor = value
        End Set
    End Property
    Public Shared Property penWidth As Integer
        Get
            Return _penWidth
        End Get
        Set(value As Integer)
            _penWidth = value
        End Set
    End Property
    Public Overridable ReadOnly Property HandleCount As Integer
        Get
            Return 0
        End Get
    End Property
#End Region
#Region "가상함수"
    ''' <summary>
    ''' DrawObject 복사 함수
    ''' </summary>
    ''' <returns></returns>
    Public MustOverride Function Clone() As DrawObject
    ''' <summary>
    ''' DrawObject 그리기 함수
    ''' </summary>
    ''' <param name="g"></param>
    Public Overridable Sub Draw(ByVal g As Graphics)
    End Sub
    ''' <summary>
    ''' 핸들 넘버의 위치를 반환한다.
    ''' </summary>
    ''' <param name="handleNumber"></param>
    ''' <returns></returns>
    Public Overridable Function GetHandle(handleNumber As Integer) As Point
        Return New Point(0, 0)
    End Function
    ''' <summary>
    ''' 핸들의 Rectangle 을 반환한다.
    ''' </summary>
    ''' <param name="handleNumber"></param>
    ''' <returns></returns>
    Public Overridable Function GetHandleRectangle(handleNumber As Integer) As Rectangle
        Dim point As Point = GetHandle(handleNumber)
        Return New Rectangle(point.X - 3, point.Y - 3, 7, 7)
    End Function
    ''' <summary>
    ''' DrawObject 가 선택되었을때 표시를 해주는 Pointer 를 그린다
    ''' </summary>
    ''' <param name="g"></param>
    Public Overridable Sub DrawPointer(g As Graphics)
        If Not Selected Then Return
        Using brush As SolidBrush = New SolidBrush(Color.Black)
            For i = 1 To HandleCount
                g.FillRectangle(brush, GetHandleRectangle(i))
            Next
        End Using
    End Sub
    ''' <summary>
    ''' 마우스가 클릭된 위치가 DrawObject를 포함하는지 알려준다
    ''' -1 - no hit
    '''  0 - hit anywhere
    '''  1 - handle number
    '''  </summary>
    ''' <param name="point"></param>
    ''' <returns></returns>
    Public Overridable Function HitTest(point As Point) As Integer
        Return -1
    End Function
    ''' <summary>
    ''' 마우스의 위치가 DrawObject 내에 있는지 알려준다.
    ''' </summary>
    ''' <param name="point"></param>
    ''' <returns></returns>
    Protected Overridable Function PointInObject(point As Point) As Boolean
        Return False
    End Function
    ''' <summary>
    ''' Pointer 의 HandleNumber 에 따라서 마우스 커서를 반환한다.
    ''' </summary>
    ''' <returns></returns>
    Public Overridable Function GetHandleCursor(handleNumber As Integer) As Cursor
        Return Cursors.Default
    End Function
    ''' <summary>
    ''' DrawObject가 rectangle 에 포함되는지 알려준다.
    ''' </summary>
    ''' <returns></returns>
    Public Overridable Function IntersectsWith(rectangle As Rectangle) As Boolean
        Return False
    End Function
    ''' <summary>
    ''' DrawObject 의 위치를 이동한다.
    ''' </summary>
    ''' <param name="deltaX"></param>
    ''' <param name="deltaY"></param>
    Public Overridable Sub Move(deltaX As Integer, deltaY As Integer)

    End Sub
    ''' <summary>
    ''' DrawObject 의 사이즈를 변경한다.
    ''' </summary>
    ''' <param name="point"></param>
    ''' <param name="handleNumber"></param>
    Public Overridable Sub MoveHandleTo(point As Point, handleNumber As Integer)
    End Sub
    ''' <summary>
    ''' DrawObject 를 새로 그리거나, 사이즈를 변경이 끝났을 때 호출된다.
    ''' </summary>
    Public Overridable Sub Normalize()
    End Sub
#End Region
#Region "내부함수"
    ''' <summary>
    ''' DrawObject 초기화
    ''' </summary>
    Protected Sub Initialize()
        Me.Selected = True
        color = MainController.instance.LastUsedColor
        backColor = MainController.instance.LastUesdBackgoroundColor
        penWidth = MainController.instance.LastUsedPenWidth
    End Sub
    ''' <summary>
    ''' DrawObject 를 복사 할 때, 속성들을 복사해준다.
    ''' </summary>
    ''' <param name="drawObject"></param>
    Protected Sub FillDrawObjectFields(drawObject As DrawObject)
        drawObject.Selected = Me.Selected
        drawObject.color = Me.color
        drawObject.backColor = Me.backColor
        drawObject.penWidth = Me.penWidth
    End Sub
#End Region
End Class
