Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports vbDrawTool.ConEnum

Public Class MainView
    Implements IObserver
    Private properies As PropertiesVIew
    Sub New()
        InitializeComponent()
        SetToolStripMenu()
        MainController.Instance.Subscribe(Me)
    End Sub
#Region "파일메뉴"
    Private Sub SaveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles saveToolStripMenuItem.Click
        FileSave()
    End Sub
    Private Sub FileLoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles openToolStripMenuItem.Click
        FileLoad()
    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles newToolStripMenuItem.Click
        Neww()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Me.Close()
    End Sub
#End Region
#Region "편집메뉴"
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
    Private Sub deleteAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAllToolStripMenuItem.Click
        If MainController.Instance.graphicModel.GrapList.Count > 0 Then
            MainController.Instance.command.AddCommand(MainController.Instance.graphicModel.GrapList)
            MainController.Instance.graphicModel.GrapList.Clear()
            MainController.Instance.Notify(ObserverAction.Invalidate)
        End If
    End Sub
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If MainController.Instance.command.CanUndo Then
            If MainController.Instance.command.Undo() Then
                MainController.Instance.Notify(ObserverAction.Invalidate)
                MainController.Instance.Notify(ObserverAction.Command)
            End If
        End If
    End Sub
    Private Sub redoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        If MainController.Instance.command.CanRedo Then
            If MainController.Instance.command.Redo() Then
                MainController.Instance.Notify(ObserverAction.Invalidate)
                MainController.Instance.Notify(ObserverAction.Command)
            End If
        End If
    End Sub
    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles pointerToolStripMenuItem.Click
        MainController.Instance.Notify(ObserverAction._Select)
    End Sub
    Private Sub RectangleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles rectangleToolStripMenuItem.Click
        MainController.Instance.Notify(ObserverAction.Rectangle)
    End Sub
    Private Sub EllipseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ellipseToolStripMenuItem.Click
        MainController.Instance.Notify(ObserverAction.Ellipse)
    End Sub
    Private Sub LineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles lineToolStripMenuItem.Click
        MainController.Instance.Notify(ObserverAction.Line)
    End Sub
    Private Sub PencilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles pencilToolStripMenuItem.Click
        MainController.Instance.Notify(ObserverAction.Pencil)
    End Sub
    Private Sub aboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles aboutToolStripMenuItem.Click
        MessageBox.Show("DrawTool 을 이용해 주셔서 감사합니다.")
    End Sub
#End Region
    Public Sub OnNext(action As ConEnum.ObserverAction) Implements IObserver.OnNext
        Select Case action
            Case ObserverAction.Command : SetToolStripMenu()
            Case ObserverAction.Invalidate : SetToolStripMenu()
            Case ObserverAction._Select : SetToolStripMenu()
        End Select
    End Sub

    Public Sub OnNext(obserber As ObserverClass) Implements IObserver.OnNext
        'If obserber.Name = ObserverName.ToolBar Then
        Select Case obserber.Action
            Case ObserverAction.FileLoad : FileLoad()
            Case ObserverAction.FileSave : FileSave()
            Case ObserverAction._New : Neww()
        End Select
        'End If
    End Sub
    Private Sub FileLoad()
        openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If File.Exists(openFileDialog1.FileName) Then
                Dim fs As FileStream = Nothing
                Try
                    fs = New FileStream(openFileDialog1.FileName, FileMode.Open)
                    Dim bf As New BinaryFormatter
                    Dim tmpItem As Graphic = TryCast(bf.Deserialize(fs), Graphic)
                    fs.Close()
                    If tmpItem IsNot Nothing Then
                        MainController.Instance.graphicModel.GrapList.Clear()
                        MainController.Instance.graphicModel = tmpItem
                        MainController.Instance.command.Clear()
                        SetToolStripMenu()
                        MainController.Instance.Notify(ObserverAction.FileLoad)
                    End If
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub
    Private Sub FileSave()
        saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fs As FileStream = Nothing
            Try
                fs = New FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate)
                Dim bf As BinaryFormatter = New BinaryFormatter()
                bf.Serialize(fs, MainController.Instance.graphicModel)
                fs.Close()
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub
    Private Sub Neww()
        If MessageBox.Show("새로운 그래프를 작성합니다. 작성 중인 내용은 모두 삭제됩니다.", "확인", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("작성 중인 내용을 저장 하시겠습니까?", "확인", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                FileSave()
            End If
            MainController.Instance.graphicModel.GrapList.Clear()
            MainController.Instance.command.Clear()
            MainController.Instance.Notify(ObserverAction._New)
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
    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        For Each obj As DrawObject In MainController.Instance.graphicModel.GrapList
            If obj.Selected Then
                properies = New PropertiesVIew(obj.color, obj.backColor)
                If properies.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
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
    Private Sub MainView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("프로그램을 종료 하시겠습니까?", "확인", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Return
        End If
        If MessageBox.Show("작성 중인 내용을 저장 하시겠습니까?", "확인", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            FileSave()
        End If
    End Sub
End Class
