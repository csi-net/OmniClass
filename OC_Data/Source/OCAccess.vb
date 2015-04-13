Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.ServiceModel.Web

Public Class OCAccess
    Private VendorKey As Guid

    Public Sub New(VendorKey As Guid)
        Me.VendorKey = VendorKey
    End Sub

    Public Function GetAllTableGuids() As OCGuidListResponse
        Using cf As New ChannelFactory(Of IOmniClass_Service)(New WebHttpBinding(), "http://ocservice.csinet.org/OmniClass_Service.svc")
            cf.Endpoint.EndpointBehaviors.Add(New WebHttpBehavior())
            Dim channel = cf.CreateChannel()
            Return channel.GetAllTableGuids(VendorKey.ToString)
        End Using
    End Function

    Public Function GetOCTable(TableGuid As Guid, Optional VersionGuid As Guid? = Nothing) As OCObjectResponse
        Using cf As New ChannelFactory(Of IOmniClass_Service)(New WebHttpBinding(), "http://ocservice.csinet.org/OmniClass_Service.svc")
            cf.Endpoint.EndpointBehaviors.Add(New WebHttpBehavior())
            Dim channel = cf.CreateChannel()

            Dim VersionGuidString As String = Nothing
            If Not VersionGuid Is Nothing Then VersionGuidString = VersionGuid.ToString

            Return channel.GetOCTable(VendorKey.ToString, TableGuid.ToString, VersionGuidString)
        End Using
    End Function

    Public Function GetAllVersionGuids(TableGuid As Guid, Optional includeUnpublished As Boolean = False) As OCGuidListResponse
        Using cf As New ChannelFactory(Of IOmniClass_Service)(New WebHttpBinding(), "http://ocservice.csinet.org/OmniClass_Service.svc")
            cf.Endpoint.EndpointBehaviors.Add(New WebHttpBehavior())
            Dim channel = cf.CreateChannel()

            Dim includeUnpublishedString As String = Nothing
            If includeUnpublished Then includeUnpublishedString = "true"

            Return channel.GetAllVersionGuids(VendorKey.ToString, TableGuid.ToString, includeUnpublishedString)
        End Using
    End Function

    Public Function GetOCVersion(VersionGuid As Guid) As OCVersionResponse
        Using cf As New ChannelFactory(Of IOmniClass_Service)(New WebHttpBinding(), "http://ocservice.csinet.org/OmniClass_Service.svc")
            cf.Endpoint.EndpointBehaviors.Add(New WebHttpBehavior())
            Dim channel = cf.CreateChannel()
            Return channel.GetOCVersion(VendorKey.ToString, VersionGuid.ToString)
        End Using
    End Function

    Public Function GetAllRevisionGuids(VersionGuid As Guid, Optional includeUnpublished As Boolean = False) As OCGuidListResponse
        Using cf As New ChannelFactory(Of IOmniClass_Service)(New WebHttpBinding(), "http://ocservice.csinet.org/OmniClass_Service.svc")
            cf.Endpoint.EndpointBehaviors.Add(New WebHttpBehavior())
            Dim channel = cf.CreateChannel()

            Dim includeUnpublishedString As String = Nothing
            If includeUnpublished Then includeUnpublishedString = "true"

            Return channel.GetAllRevisionGuids(VendorKey.ToString, VersionGuid.ToString, includeUnpublishedString)
        End Using
    End Function

    Public Function GetOCObject(ObjectGuid As Guid, Optional VersionGuid As Guid? = Nothing) As OCObjectResponse
        Using cf As New ChannelFactory(Of IOmniClass_Service)(New WebHttpBinding(), "http://ocservice.csinet.org/OmniClass_Service.svc")
            cf.Endpoint.EndpointBehaviors.Add(New WebHttpBehavior())
            Dim channel = cf.CreateChannel()

            Dim VersionGuidString As String = Nothing
            If Not VersionGuid Is Nothing Then VersionGuidString = VersionGuid.ToString

            Return channel.GetOCObject(VendorKey.ToString, ObjectGuid.ToString, VersionGuidString)
        End Using
    End Function
End Class
