<DataContract>
Public MustInherit Class OCResponse
    <DataMember>
    Public ReadOnly Success As Boolean
    <DataMember>
    Public ReadOnly FailureReason As String

    Public Sub New(Success As Boolean, Optional FailureReason As String = Nothing)
        Me.Success = Success
        Me.FailureReason = FailureReason
    End Sub
End Class
