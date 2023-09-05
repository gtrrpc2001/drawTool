Imports vbDrawTool.ConEnum

Public Interface IObservable
    Sub Notify(action As ObserverAction)
    Sub Notify(observer As ObserverClass)
    Function Subscribe(observer As IObserver) As IDisposable
    Sub Unsubscribe(observer As IObserver)
End Interface
