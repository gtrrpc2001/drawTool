Imports vbDrawTool.ConEnum

Public NotInheritable Class MainController
    Implements IObservable
    Private Shared _instance As MainController = Nothing
    Private _graphicModel As Graphic = New Graphic
    Private Shared ReadOnly padlock As Object = New Object
    Private listener As List(Of IObserver) = New List(Of IObserver)
    Private _command As command = New command
    Private _lastUsedPenWidth As Integer = 1
    Private _lastUsedColor As Color = Color.Black
    Private _lastUsedBackColor As Color = Color.White
    Sub New()

    End Sub
    Public Shared ReadOnly Property Instance As MainController
        Get
            If _instance Is Nothing Then
                SyncLock padlock
                    If _instance Is Nothing Then
                        _instance = New MainController()
                    End If
                End SyncLock
            End If
            Return _instance
        End Get
    End Property
    Public Sub Notify(action As ObserverAction) Implements IObservable.Notify
        For Each item As IObserver In listener
            item.OnNext(action)
        Next
    End Sub
    Public Sub Notify(observer As ObserverClass) Implements IObservable.Notify
        For Each item As IObserver In listener
            item.OnNext(observer)
        Next
    End Sub
    Public Function Subscribe(observer As IObserver) As IDisposable Implements IObservable.Subscribe
        listener.Add(observer)
        Return TryCast(listener, IDisposable)
    End Function
    Public Sub Unsubscribe(observer As IObserver) Implements IObservable.Unsubscribe
        listener.Remove(observer)
    End Sub
    Public Property LastUsedPenWidth As Integer
        Get
            Return _lastUsedPenWidth
        End Get
        Set(value As Integer)
            _lastUsedPenWidth = value
        End Set
    End Property
    Public Property LastUesdBackgoroundColor As Color
        Get
            Return _lastUsedBackColor
        End Get
        Set(value As Color)
            _lastUsedBackColor = value
        End Set
    End Property
    Public Property LastUsedColor As Color
        Get
            Return _lastUsedColor
        End Get
        Set(value As Color)
            _lastUsedColor = value
        End Set
    End Property
    Public Property command As command
        Get
            Return _command
        End Get
        Set(value As command)
            _command = value
        End Set
    End Property
    Public Property graphicModel As Graphic
        Get
            Return _graphicModel
        End Get
        Set(value As Graphic)
            _graphicModel = value
        End Set
    End Property
    Public Property DrawObjectType As DrawObjectType
    Public Property SelectMode As SelectMode
End Class
