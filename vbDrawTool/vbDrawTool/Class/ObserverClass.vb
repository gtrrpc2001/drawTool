Imports vbDrawTool.ConEnum
''' <summary>
''' 옵저버에게 통보를 할 때 매개변수로 사용되는 클래스.
''' 본 클래스의 목적은 ObserverName 에  따라서 처리 할지 말지를 구분하기 위해서 사용된다.
''' 예를 들어 MainView 에서 Next 가 실행 될 때, ObserverName 이 ToolBar 일 때만 ObserverAction 을 실행한다.
''' </summary>
Public Class ObserverClass
    Public Sub New(name As String)
        name = GetName(name)
    End Sub
#Region "내부함수"
    Private Function GetName(name As String) As ObserverName
        Select Case name
            Case "MainView" : Return ObserverName.MainView
            Case "ToolBar" : Return ObserverName.ToolBar
            Case "DrawBox" : Return ObserverName.DrawBox
        End Select
        Return ObserverName.MainView
    End Function
#End Region
#Region "Properties"
    Public Property Name As ObserverName
    Public Property Action As ObserverAction
#End Region

End Class
