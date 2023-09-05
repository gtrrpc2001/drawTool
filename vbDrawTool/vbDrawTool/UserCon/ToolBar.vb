Imports vbDrawTool.ConEnum

Public Class ToolBar
    Inherits UserControl
    Implements IObserver
    Private drawButtonList As List(Of ToolStripButton) = New List(Of ToolStripButton)
    Private observer As ObserverClass = New ObserverClass("ToolBar")
    Public Sub New()
        InitializeComponent()
        drawButtonList.Add(toolStripButtonEllipse)
        drawButtonList.Add(toolStripButtonLine)
        drawButtonList.Add(toolStripButtonSelect)
        drawButtonList.Add(toolStripButtonPencil)
        drawButtonList.Add(toolStripButtonRectangle)
        SetToolBarButtonState("Select")
        MainController.Instance.Subscribe(Me)
    End Sub

    Public Sub OnNext(action As ConEnum.ObserverAction) Implements IObserver.OnNext
        Select Case action
            Case ObserverAction.Command : SetUndoRedoButton()
            Case ObserverAction.Invalidate : SetToolBarButtonState("Select")
            Case ObserverAction.Ellipse : SetToolBarButtonState("Ellipse")
            Case ObserverAction.Line : SetToolBarButtonState("Line")
            Case ObserverAction.Pencil : SetToolBarButtonState("Pencil")
            Case ObserverAction.Rectangle : SetToolBarButtonState("Rectangle")
            Case ObserverAction._Select : SetToolBarButtonState("Select")
            Case ObserverAction.FileLoad : SetToolBarButtonState("Select") : SetUndoRedoButton()
            Case ObserverAction._New : SetToolBarButtonState("Select") : SetUndoRedoButton()
        End Select

    End Sub
    Public Sub OnNext(obserber As ObserverClass) Implements IObserver.OnNext
    End Sub
    Public Sub SetUndoRedoButton()
        If MainController.Instance.command.CanUndo Then
            toolStripButtonUndo.Enabled = True
        Else
            toolStripButtonUndo.Enabled = False
        End If
        If MainController.Instance.command.CanRedo Then
            toolStripButtonRedo.Enabled = True
        Else
            toolStripButtonRedo.Enabled = False
        End If
    End Sub
    Public Sub SetToolBarButtonState(buttonName As String)
        For Each item As ToolStripButton In drawButtonList
            If item.Text = buttonName Then
                item.Enabled = False
                item.BackColor = Color.DarkGray
                MainController.Instance.DrawObjectType = GetDrawObjectType(buttonName)
            Else
                item.Enabled = True
                item.BackColor = Color.FromArgb(92, 92, 92)
            End If
        Next
    End Sub
    Private Function GetDrawObjectType(buttonName As String) As DrawObjectType
        Select Case buttonName
            Case "Select" : Return DrawObjectType._Select
            Case "Rectangle" : Return DrawObjectType.Rectangle
            Case "Line" : Return DrawObjectType.Line
            Case "Ellipse" : Return DrawObjectType.Ellipse
            Case "Pencil" : Return DrawObjectType.Pencil
        End Select
        Return DrawObjectType._Select
    End Function
    Private Sub ToolStripButton_Click(sender As Object, e As EventArgs) Handles toolStripButtonSelect.Click, toolStripButtonRectangle.Click, toolStripButtonEllipse.Click,
        toolStripButtonLine.Click, toolStripButtonPencil.Click
        SetToolBarButtonState((CType(sender, ToolStripButton)).Text)
    End Sub
    Private Sub ToolStripButtonUndo_Click(sender As Object, e As EventArgs) Handles toolStripButtonUndo.Click
        If MainController.Instance.command.CanUndo Then
            If MainController.Instance.command.Undo() Then
                MainController.Instance.Notify(ObserverAction.Invalidate)
                SetUndoRedoButton()
            End If
        End If
    End Sub
    Private Sub ToolStripButtonRedo_Click(sender As Object, e As EventArgs) Handles toolStripButtonRedo.Click
        If MainController.Instance.command.CanRedo Then
            If MainController.Instance.command.Redo() Then
                MainController.Instance.Notify(ObserverAction.Invalidate)
                SetUndoRedoButton()
            End If
        End If
    End Sub
    Private Sub ToolStripButtonNew_Click(sender As Object, e As EventArgs) Handles toolStripButtonNew.Click
        observer.Action = ObserverAction._New
        MainController.Instance.Notify(observer)
    End Sub
    Private Sub ToolStripButtonFileLoad_Click(sender As Object, e As EventArgs) Handles toolStripButtonOpen.Click
        observer.Action = ObserverAction.FileLoad
        MainController.Instance.Notify(observer)
    End Sub
    Private Sub toolStripButtonFileSave_Click(sender As Object, e As EventArgs) Handles toolStripButtonSave.Click
        observer.Action = ObserverAction.FileSave
        MainController.Instance.Notify(observer)
    End Sub
End Class
