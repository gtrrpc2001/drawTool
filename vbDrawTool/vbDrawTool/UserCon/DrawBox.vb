Imports vbDrawTool.ConEnum
'''<summary>
'''DrawObject를 그려주는 Class
'''</summary>
Public Class DrawBox
    Inherits UserControl
    Implements IObserver
#Region "전역변수"
    ''' <summary>
    ''' 속성 설정 폼
    ''' </summary>
    Private properies As PropertiesVIew
    ''' <summary>
    ''' 선택된 객체의 사이즈를 변경할 때 사용
    ''' </summary>
    Private resizedObject As DrawObject
    ''' <summary>
    ''' 사이즈가 변결 될 객체의 핸들 번호를 가져온다.
    ''' </summary>
    Private resizedObjectHandle As Integer
    ''' <summary>
    ''' 마우스의 시작 위치
    ''' </summary>
    Private startPoint As Point = New Point(0, 0)
    ''' <summary>
    '''  마우스의 마지막 위치
    ''' </summary>
    Private lastPoint As Point = New Point(0, 0)
    ''' <summary>
    ''' 이전의 lastPoint 를 저장한다.
    ''' </summary>
    Private oldPoint As Point
    ''' <summary>
    ''' DrawObject를 그릴수 있는 DrawBox 사이즈를 수정 할 수 있는지 여부를 저장하는 변수
    ''' </summary>
    Private allowResize As Boolean = False
    ''' <summary>
    ''' Pencil 을 그릴 때 마지막으로 그려진 Location.X 를 저장한다.
    ''' </summary>
    Private lastX As Integer
    ''' <summary>
    ''' Pencil 을 그릴 때 마지막으로 그려진 Location.Y 를 저장한다.
    ''' </summary>
    Private lastY As Integer
    ''' <summary>
    '''  Pencil 도구로 그릴 때 사용되는 PencilObject 변수
    ''' </summary>
    Private newPencil As PencilObejct
    ''' <summary>
    ''' Pencil 도구로 그릴 때 연결 점 사이의 최소 거리를 지정하는 상수
    ''' </summary>
    Private Const MinDistance As Integer = 15 * 15
#End Region
    Sub New()
        InitializeComponent()
#Region "Paint 이벤트와 관련해서 유용한 style 을 적용한다."
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.SetStyle(ControlStyles.DoubleBuffer, True)
        Me.UpdateStyles()
        Me.DoubleBuffered = True
#End Region
        MainController.Instance.Subscribe(Me)
    End Sub
    Public Sub OnNext(action As ObserverAction) Implements IObserver.OnNext
        Select Case action
            Case ObserverAction.Invalidate : Me.Invalidate(False)
            Case ObserverAction.FileLoad : Me.Invalidate(False)
            Case ObserverAction._New : Me.Invalidate(False)
        End Select
    End Sub
    Public Sub OnNext(observer As ObserverClass) Implements IObserver.OnNext
        Select Case observer.Action
            Case ObserverAction.Invalidate : Me.Invalidate(False)
            Case ObserverAction.FileLoad : Me.Invalidate(False)
            Case ObserverAction._New : Me.Invalidate(False)
        End Select
    End Sub
    Private Sub pictureBox_ReSize_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox_ReSize.MouseDown
        allowResize = True
    End Sub
    Private Sub pictureBox_ReSize_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox_ReSize.MouseMove
        If allowResize Then
            Me.Height = pictureBox_ReSize.Top + e.Y
            Me.Width = pictureBox_ReSize.Left + e.X
        End If
    End Sub
    Private Sub pictureBox_ReSize_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox_ReSize.MouseUp
        allowResize = False
    End Sub
    Private Sub UnSelectAll()
        For Each o As DrawObject In MainController.Instance.graphicModel.GrapList
            o.Selected = False
        Next
    End Sub
    Private Function AddNewDrawObject(type As DrawObjectType, location As Point) As DrawObject
        Select Case type
            Case DrawObjectType.Rectangle : Return New RectangleObject(location.X, location.Y, 1, 1)
            Case DrawObjectType.Ellipse : Return New EllipseObject(location.X, location.Y, 1, 1)
            Case DrawObjectType.Line : Return New LineObject(location.X, location.Y, location.X + 1, location.Y + 1)
            Case DrawObjectType.Pencil
                lastX = location.X
                lastY = location.Y
                newPencil = New PencilObejct(location.X, location.Y, location.X + 1, location.Y + 1)
                Return newPencil
        End Select
        Return New RectangleObject(location.X, location.Y, 1, 1)
    End Function
    Private Sub DrawBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left AndAlso MainController.Instance.DrawObjectType = DrawObjectType._Select Then
            MainController.Instance.SelectMode = SelectMode.None
            For Each ob As DrawObject In MainController.Instance.graphicModel.GrapList
                Dim handleNumber As Integer = ob.HitTest(e.Location)

                If handleNumber > 0 Then
                    MainController.Instance.SelectMode = SelectMode.Size
                    resizedObject = ob
                    resizedObjectHandle = handleNumber
                    UnSelectAll()
                    ob.Selected = True
                    Exit For
                End If
            Next
            If MainController.Instance.SelectMode = SelectMode.None Then

                For Each o As DrawObject In MainController.Instance.graphicModel.GrapList

                    If o.HitTest(e.Location) = 0 Then

                        If (Control.ModifierKeys And Keys.Control) = 0 AndAlso Not o.Selected Then
                            UnSelectAll()
                            o.Selected = True
                        ElseIf (Control.ModifierKeys And Keys.Control) <> 0 AndAlso o.Selected Then
                            o.Selected = False
                        Else
                            o.Selected = True
                        End If

                        Me.Cursor = Cursors.SizeAll
                        MainController.Instance.SelectMode = SelectMode.Move
                        Exit For
                    End If
                Next
            End If
            If MainController.Instance.SelectMode = SelectMode.None Then
                If (Control.ModifierKeys And Keys.Control) = 0 Then UnSelectAll()
                MainController.Instance.SelectMode = SelectMode.NetSelection
            End If

            lastPoint = e.Location
            startPoint = e.Location
            Me.Capture = True
            If MainController.Instance.SelectMode = SelectMode.NetSelection Then
                ControlPaint.DrawReversibleFrame(Me.RectangleToScreen(RectangleObject.GetNormalizedRectangle(startPoint, lastPoint)), Color.Black, FrameStyle.Dashed)
            End If
        ElseIf e.Button = MouseButtons.Left AndAlso Not (MainController.Instance.DrawObjectType = DrawObjectType._Select) Then
            UnSelectAll()
            MainController.Instance.command.AddCommand(MainController.Instance.graphicModel.GrapList)
            MainController.Instance.graphicModel.GrapList.Insert(0, AddNewDrawObject(MainController.Instance.DrawObjectType, e.Location))
            Me.Capture = True
        ElseIf e.Button = System.Windows.Forms.MouseButtons.Right Then
            SetToolStripMenu()
            contextMenuStrip1.Show(MousePosition)
            Return
        End If
    End Sub
    Private Sub DrawBox_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        oldPoint = lastPoint
        If e.Button = MouseButtons.Left AndAlso MainController.Instance.DrawObjectType <> DrawObjectType._Select Then

            If MainController.Instance.DrawObjectType = DrawObjectType.Pencil AndAlso newPencil IsNot Nothing Then
                Dim point As Point = New Point(e.X, e.Y)
                Dim distance As Integer = (e.X - lastX) * (e.X - lastX) + (e.Y - lastY) * (e.Y - lastY)

                If distance < MinDistance Then
                    newPencil.MoveHandleTo(point, newPencil.HandleCount)
                Else
                    newPencil.AddPoint(e.Location)
                    lastX = e.X
                    lastY = e.Y
                End If
            Else
                MainController.Instance.graphicModel.GrapList(0).MoveHandleTo(e.Location, 5)
            End If

            Me.Invalidate(False)
            Return
        ElseIf e.Button = MouseButtons.Left AndAlso MainController.Instance.DrawObjectType = DrawObjectType._Select Then
            Dim distanceX As Integer = e.X - lastPoint.X
            Dim distanceY As Integer = e.Y - lastPoint.Y
            lastPoint = e.Location

            If MainController.Instance.SelectMode = SelectMode.Size Then

                If resizedObject IsNot Nothing Then
                    resizedObject.MoveHandleTo(e.Location, resizedObjectHandle)
                    Me.Invalidate(False)
                    Return
                End If
            End If

            If MainController.Instance.SelectMode = SelectMode.Move Then

                For Each o As DrawObject In MainController.Instance.graphicModel.GrapList

                    If o.Selected Then
                        o.Move(distanceX, distanceY)
                    End If
                Next

                Me.Cursor = Cursors.SizeAll
                Me.Invalidate(False)
                Return
            End If

            If MainController.Instance.SelectMode = SelectMode.NetSelection Then
                ControlPaint.DrawReversibleFrame(Me.RectangleToScreen(RectangleObject.GetNormalizedRectangle(startPoint, oldPoint)), Color.Black, FrameStyle.Dashed)
                ControlPaint.DrawReversibleFrame(Me.RectangleToScreen(RectangleObject.GetNormalizedRectangle(startPoint, e.Location)), Color.Black, FrameStyle.Dashed)
                Return
            End If
        ElseIf e.Button = System.Windows.Forms.MouseButtons.None AndAlso MainController.Instance.DrawObjectType = DrawObjectType._Select Then
            For Each ob As DrawObject In MainController.Instance.graphicModel.GrapList
                Cursor = ob.GetHandleCursor(ob.HitTest(e.Location))
                Return
            Next
        End If
    End Sub
    Private Sub DrawBox_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left AndAlso Not (MainController.Instance.DrawObjectType = DrawObjectType._Select) Then
            MainController.Instance.SelectMode = SelectMode.None
            MainController.Instance.graphicModel.GrapList(0).Normalize()
            newPencil = Nothing
            MainController.Instance.Notify(ObserverAction.Pencil)
        Else
            If MainController.Instance.SelectMode = SelectMode.NetSelection Then
                ControlPaint.DrawReversibleFrame(Me.RectangleToScreen(RectangleObject.GetNormalizedRectangle(startPoint, lastPoint)), Color.Black, FrameStyle.Dashed)
                UnSelectAll()
                Dim rec As Rectangle = RectangleObject.GetNormalizedRectangle(startPoint, lastPoint)

                For Each o As DrawObject In MainController.Instance.graphicModel.GrapList
                    If o.IntersectsWith(rec) Then o.Selected = True
                Next

                MainController.Instance.SelectMode = SelectMode.None
            End If

            If resizedObject IsNot Nothing Then
                resizedObject.Normalize()
                resizedObject = Nothing
            End If
            Me.Invalidate(False)
        End If
    End Sub
    Private Sub DrawBox_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Me.Paint
        If MainController.Instance.graphicModel.GrapList.Count > 0 Then
            Using brush As SolidBrush = New SolidBrush(Color.FromArgb(255, 255, 255))

                For Each ob As DrawObject In MainController.Instance.graphicModel.GrapList
                    ob.Draw(e.Graphics)
                    If ob.Selected = True Then
                        ob.DrawPointer(e.Graphics)
                    End If
                Next
            End Using
        End If
    End Sub
    Private Sub SetToolStripMenu()
        If MainController.Instance.command.CanUndo Then
            UndoToolStripMenuItem.Enabled = True
        Else
            UndoToolStripMenuItem.Enabled = False
        End If

        If MainController.Instance.command.CanRedo Then
            RedoToolStripMenuItem.Enabled = True
        Else
            RedoToolStripMenuItem.Enabled = False
        End If

        If MainController.Instance.graphicModel.SelectedCount = 1 Then
            PropertiesToolStripMenuItem.Enabled = True
        Else
            PropertiesToolStripMenuItem.Enabled = False
        End If
    End Sub
    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        For Each item As DrawObject In MainController.Instance.graphicModel.GrapList
            item.Selected = True
        Next
        MainController.Instance.Notify(ObserverAction.Invalidate)
    End Sub
    Private Sub UnselectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnselectAllToolStripMenuItem.Click
        For Each item As DrawObject In MainController.Instance.graphicModel.GrapList
            item.Selected = False
        Next
        MainController.Instance.Notify(ObserverAction.Invalidate)
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        For i = 0 To MainController.Instance.graphicModel.GrapList.Count - 1
            If MainController.Instance.graphicModel.GrapList(i).Selected Then
                MainController.Instance.command.AddCommand(MainController.Instance.graphicModel.GrapList)
                MainController.Instance.graphicModel.GrapList.RemoveAt(i)
                MainController.Instance.Notify(ObserverAction.Invalidate)
            End If
        Next
    End Sub
    Private Sub DeleteAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAllToolStripMenuItem.Click
        If MainController.Instance.graphicModel.GrapList.Count > 0 Then
            MainController.Instance.command.AddCommand(MainController.Instance.graphicModel.GrapList)
            MainController.Instance.graphicModel.GrapList.Clear()
            MainController.Instance.Notify(ObserverAction.Invalidate)
        End If
    End Sub
    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        For Each obj As DrawObject In MainController.Instance.graphicModel.GrapList
            If obj.Selected Then
                properies = New PropertiesVIew(obj.color, obj.backColor)
                If (properies.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                    obj.color = properies.Color
                    obj.backColor = properies.BackGroundColor
                    obj.penWidth = properies.PenWidth
                    MainController.Instance.Notify(ObserverAction.Invalidate)
                End If
                properies.Dispose()
                Exit Sub
            End If
        Next
    End Sub
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If MainController.Instance.command.CanUndo Then
            If MainController.Instance.command.Undo() Then
                MainController.Instance.Notify(ObserverAction.Invalidate)
                MainController.Instance.Notify(ObserverAction.Command)
            End If
        End If
    End Sub
    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        If MainController.Instance.command.CanRedo Then
            If MainController.Instance.command.Redo() Then
                MainController.Instance.Notify(ObserverAction.Invalidate)
                MainController.Instance.Notify(ObserverAction.Command)
            End If
        End If
    End Sub
End Class
