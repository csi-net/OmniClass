<DataContract>
Public Class OCObjectResponse
    Inherits OCResponse

    <DataMember>
    Public ReadOnly OCObject As OCObject

    Public Sub New(OCObject As OCObject)
        MyBase.New(True)
        Me.OCObject = OCObject
    End Sub

    Public Sub New(FailureReason As String)
        MyBase.New(False, FailureReason)
        Me.OCObject = Nothing
    End Sub
End Class
