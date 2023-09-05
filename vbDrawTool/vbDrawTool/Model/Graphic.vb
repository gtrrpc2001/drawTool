<Serializable>
Public Class Graphic
    Private _grapList As List(Of DrawObject) = New List(Of DrawObject)
    Public Property GrapList As List(Of DrawObject)
        Get
            Return _grapList
        End Get
        Set(value As List(Of DrawObject))
            _grapList = value
        End Set
    End Property
    Public ReadOnly Property SelectedCount As Integer
        Get
            Dim i = 0
            For Each obj As DrawObject In GrapList
                If obj.Selected Then
                    i += 1
                End If
            Next
            Return i
        End Get
    End Property
End Class
