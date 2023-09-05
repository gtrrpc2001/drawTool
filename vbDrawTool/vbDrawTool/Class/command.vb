Imports vbDrawTool.ConEnum

Public Class command
    Private undoStack As Stack(Of List(Of DrawObject)) = New Stack(Of List(Of DrawObject))
    Private redostack As Stack(Of List(Of DrawObject)) = New Stack(Of List(Of DrawObject))
    Public ReadOnly Property CanUndo As Boolean
        Get
            Return undoStack.Count > 0
        End Get
    End Property
    Public ReadOnly Property CanRedo As Boolean
        Get
            Return redostack.Count > 0
        End Get
    End Property

    Public Sub AddCommand(data As List(Of DrawObject))
        undoStack.Push(dataclone(data))
        MainController.instance.Notify(ObserverAction.Command)
    End Sub
    Public Sub Clear()
        undoStack.Clear()
        redostack.Clear()
    End Sub
    Public Function Undo() As Boolean
        If CanUndo Then
            redostack.Push(DataClone(MainController.Instance.graphicModel.grapList))
            MainController.Instance.graphicModel.grapList = DataClone(undoStack.Pop())
            Return True
        Else
            Return False
        End If
    End Function
    Public Function Redo() As Boolean
        If CanRedo Then
            undoStack.Push(DataClone(MainController.Instance.graphicModel.GrapList))
            MainController.Instance.graphicModel.GrapList = DataClone(redostack.Pop())
            Return True
        Else
            Return False
        End If
    End Function

    Private Function DataClone(data As List(Of DrawObject)) As List(Of DrawObject)
        Dim clone As List(Of DrawObject) = New List(Of DrawObject)
        For Each item As DrawObject In data
            clone.Add(item.Clone)
        Next
        Return clone
    End Function
End Class
