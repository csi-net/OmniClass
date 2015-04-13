<DataContract>
Public Class OCGuidListResponse
    Inherits OCResponse

    <DataMember>
    Public ReadOnly GuidList As List(Of Guid)

    Public Sub New(GuidList As List(Of Guid))
        MyBase.New(True)
        Me.GuidList = GuidList
    End Sub

    Public Sub New(FailureReason As String)
        MyBase.New(False, FailureReason)
        Me.GuidList = Nothing
    End Sub

End Class
