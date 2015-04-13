Imports System.Text

<DataContract>
Public Class OCObject
    <DataMember>
    Public ReadOnly GUID As Guid
    <DataMember>
    Public ReadOnly ParentGUID As Guid?
    <DataMember>
    Public ReadOnly ChildGUIDs As List(Of Guid)
    <DataMember>
    Public ReadOnly PropertyValues As Dictionary(Of String, List(Of OCText))

    Public Sub New(OCGUID As Guid, ParentGUID As Guid?, ChildGUIDs As List(Of Guid), PropertyValues As Dictionary(Of String, List(Of OCText)))
        Me.GUID = OCGUID
        Me.ParentGUID = ParentGUID
        If ChildGUIDs Is Nothing Then
            Me.ChildGUIDs = New List(Of Guid)
        Else
            Me.ChildGUIDs = ChildGUIDs
        End If
        If PropertyValues Is Nothing Then
            Me.PropertyValues = New Dictionary(Of String, List(Of OCText))(New Dictionary(Of String, List(Of OCText)))
        Else
            Me.PropertyValues = PropertyValues
        End If
    End Sub

    Public ReadOnly Property IsTableRoot
        Get
            Return ParentGUID Is Nothing
        End Get
    End Property

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder()

        sb.Append(Me.GetType().Name)
        sb.Append(System.Environment.NewLine)
        sb.Append("[")
        sb.Append(System.Environment.NewLine)
        sb.Append("GUID: " & GUID.ToString())

        If Not ParentGUID Is Nothing Then
            sb.Append("ParentGUID: " & ParentGUID.ToString())
            sb.Append(System.Environment.NewLine)
        End If

        If Not ChildGUIDs Is Nothing AndAlso ChildGUIDs.Count > 0 Then
            sb.Append("ChildGUIDs: ")
            sb.Append(System.Environment.NewLine)
            sb.Append("{")
            sb.Append(System.Environment.NewLine)
            For Each childGUID In ChildGUIDs
                sb.Append(childGUID.ToString())
            Next
            sb.Append("}")
            sb.Append(System.Environment.NewLine)
        End If

        If PropertyValues.Count > 0 Then
            sb.Append("Properties:")
            sb.Append(System.Environment.NewLine)
            sb.Append("{")
            sb.Append(System.Environment.NewLine)
            For Each p In PropertyValues.Keys
                Dim s = p & " - "
                For Each t In PropertyValues(p)
                    s &= "[ " & t.ToString & " ]"
                Next
                sb.Append(s)
                sb.Append(System.Environment.NewLine)
            Next
            sb.Append("}")
            sb.Append(System.Environment.NewLine)
        End If

        sb.Append("]")
        sb.Append(System.Environment.NewLine)

        Return sb.ToString
    End Function
End Class
