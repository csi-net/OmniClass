Imports System.ServiceModel
Imports System.ServiceModel.Web

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IOmniClass_Service" in both code and config file together.
<ServiceContract()>
Public Interface IOmniClass_Service

    <OperationContract()> <WebGet()>
    Function GetAllTableGuids(key As String) As OCGuidListResponse

    <OperationContract()> <WebGet()>
    Function GetOCTable(key As String, table As String, Optional version As String = Nothing) As OCObjectResponse

    <OperationContract()> <WebGet()>
    Function GetAllVersionGuids(key As String, table As String, Optional unpublished As String = Nothing) As OCGuidListResponse

    <OperationContract()> <WebGet()>
    Function GetOCVersion(key As String, version As String) As OCVersionResponse

    <OperationContract()> <WebGet()>
    Function GetAllRevisionGuids(key As String, version As String, Optional unpublished As String = Nothing) As OCGuidListResponse

    <OperationContract()> <WebGet()>
    Function GetOCObject(key As String, guid As String, Optional version As String = Nothing) As OCObjectResponse

End Interface
