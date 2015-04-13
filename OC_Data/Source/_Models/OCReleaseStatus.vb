Imports System.Text

<DataContract>
Public Class OCReleaseStatus
    <DataMember>
    Public ReadOnly GUID As Guid

    <DataMember>
    Public ReadOnly FullName As OCText

    <DataMember>
    Public ReadOnly Abbreviation As OCText

    <DataMember>
    Public ReadOnly Description As OCText

    Public Sub New(GUID As Guid, FullName As OCText, Abbreviation As OCText, Description As OCText)
        Me.GUID = GUID
        Me.FullName = FullName
        Me.Abbreviation = Abbreviation
        Me.Description = Description
    End Sub

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder()

        sb.Append(Me.GetType().Name)
        sb.Append(System.Environment.NewLine)
        sb.Append("[")
        sb.Append(System.Environment.NewLine)
        sb.Append("GUID: " & GUID.ToString())
        sb.Append(System.Environment.NewLine)
        If Not FullName Is Nothing Then
            sb.Append("FullName: " & FullName.ToString())
            sb.Append(System.Environment.NewLine)
        End If
        If Not Abbreviation Is Nothing Then
            sb.Append("Abbreviation: " & Abbreviation.ToString())
            sb.Append(System.Environment.NewLine)
        End If
        If Not Description Is Nothing Then
            sb.Append("Description: " & Description.ToString())
            sb.Append(System.Environment.NewLine)
        End If
        sb.Append("]")
        sb.Append(System.Environment.NewLine)

        Return sb.ToString
    End Function

End Class
