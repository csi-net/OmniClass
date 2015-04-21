Imports System.Text

<DataContract>
Public Class OCVersion
    <DataMember>
    Public ReadOnly GUID As Guid

    <DataMember>
    Public ReadOnly Vendor As Guid?

    <DataMember>
    Public ReadOnly ForkedFromVersion As Guid?

    <DataMember>
    Public ReadOnly TableGUID As Guid

    <DataMember>
    Public ReadOnly ReleaseStatus As OCReleaseStatus

    <DataMember>
    Public ReadOnly VersionNumber As Integer

    <DataMember>
    Public ReadOnly RevisionNumber As Integer

    <DataMember>
    Public ReadOnly VersionString As String

    <DataMember>
    Public ReadOnly PublishDate As Date?

    <DataMember>
    Public ReadOnly Published As Boolean

    Public Sub New(GUID As Guid, Vendor As Guid?, ForkedFromVersion As Guid?, TableGUID As Guid, ReleaseStatus As OCReleaseStatus, _
                   VersionNumber As Integer, RevisionNumber As Integer, VersionString As String, PublishDate As Date?, _
                   Published As Boolean)
        Me.GUID = GUID
        Me.Vendor = Vendor
        Me.ForkedFromVersion = ForkedFromVersion
        Me.TableGUID = TableGUID
        Me.ReleaseStatus = ReleaseStatus
        Me.VersionNumber = VersionNumber
        Me.RevisionNumber = RevisionNumber
        Me.VersionString = VersionString
        Me.PublishDate = PublishDate
        Me.Published = Published
    End Sub

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder()

        sb.Append(Me.GetType().Name)
        sb.Append(System.Environment.NewLine)
        sb.Append("[")
        sb.Append(System.Environment.NewLine)
        sb.Append("GUID: " & GUID.ToString())
        sb.Append(System.Environment.NewLine)
        If Not Vendor Is Nothing Then
            sb.Append("Vendor: " & Vendor.ToString())
            sb.Append(System.Environment.NewLine)
        End If
        If Not ForkedFromVersion Is Nothing Then
            sb.Append("Forked from Version: " & ForkedFromVersion.ToString())
            sb.Append(System.Environment.NewLine)
        End If
        sb.Append("Table GUID: " & TableGUID.ToString())
        sb.Append(System.Environment.NewLine)
        If Not ReleaseStatus Is Nothing Then
            sb.Append("Description: " & ReleaseStatus.ToString())
            sb.Append(System.Environment.NewLine)
        End If
        sb.Append("Version Number: " & VersionNumber.ToString())
        sb.Append(System.Environment.NewLine)
        sb.Append("Revision Number: " & RevisionNumber.ToString())
        sb.Append(System.Environment.NewLine)
        sb.Append("Version String: " & VersionString)
        sb.Append(System.Environment.NewLine)
        If Not PublishDate Is Nothing Then
            sb.Append("Publish Date" & PublishDate.ToString())
            sb.Append(System.Environment.NewLine)
        End If
        sb.Append("Published: " & Published.ToString())
        sb.Append(System.Environment.NewLine)
        sb.Append("]")
        sb.Append(System.Environment.NewLine)

        Return sb.ToString
    End Function

End Class
