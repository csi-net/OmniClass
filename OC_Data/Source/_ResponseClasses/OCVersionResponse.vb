<DataContract>
Public Class OCVersionResponse
    Inherits OCResponse

    <DataMember>
    Public ReadOnly OCVersion As OCVersion

    Public Sub New(OCVersion As OCVersion)
        MyBase.New(True)
        Me.OCVersion = OCVersion
    End Sub

    Public Sub New(FailureReason As String)
        MyBase.New(False, FailureReason)
        Me.OCVersion = Nothing
    End Sub

End Class
