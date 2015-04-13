' Language tags use IETF's BCP 47 standard: http://www.rfc-editor.org/rfc/bcp/bcp47.txt
' The list of all valid language tags can be found here: http://www.iana.org/assignments/language-subtag-registry/language-subtag-registry

Imports System.Text

<DataContract>
Public Class OCText
    <DataMember>
    Public ReadOnly LanguageTag As String

    <DataMember>
    Public ReadOnly Text As String

    <DataMember>
    Public ReadOnly TranslationSource As String

    <DataMember>
    Public ReadOnly TranslationNotes As List(Of OCText)

    <DataMember>
    Public ReadOnly Variants As List(Of OCText)

    Public Sub New(LanguageTag As String, Text As String, Optional TranslationSource As String = Nothing, Optional TranslationNotes As List(Of OCText) = Nothing, Optional Variants As List(Of OCText) = Nothing)
        Me.LanguageTag = LanguageTag
        Me.Text = Text
        Me.TranslationSource = TranslationSource

        If TranslationNotes Is Nothing Then
            Me.TranslationNotes = New List(Of OCText)
        Else
            Me.TranslationNotes = TranslationNotes
        End If

        If Variants Is Nothing Then
            Me.Variants = New List(Of OCText)
        Else
            Me.Variants = Variants
        End If
    End Sub

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder()

        sb.Append(Me.GetType().Name)
        sb.Append(System.Environment.NewLine)
        sb.Append("[")
        sb.Append(System.Environment.NewLine)
        sb.Append("LanguageTag: " & LanguageTag)
        sb.Append(System.Environment.NewLine)
        sb.Append("Text: " & Text)
        sb.Append(System.Environment.NewLine)

        If Not TranslationSource Is Nothing Then
            sb.Append("Translation Source: " & TranslationSource)
            sb.Append(System.Environment.NewLine)
        End If

        If Not TranslationNotes Is Nothing AndAlso TranslationNotes.Count > 0 Then
            sb.Append("Translation Notes:")
            sb.Append(System.Environment.NewLine)
            For Each n In TranslationNotes
                sb.Append(n.ToString())
            Next
        End If

        If Not Variants Is Nothing AndAlso Variants.Count > 0 Then
            sb.Append("Variants:")
            sb.Append(System.Environment.NewLine)
            For Each v In Variants
                sb.Append(v.ToString())
            Next
        End If

        sb.Append("]")
        sb.Append(System.Environment.NewLine)

        Return sb.ToString
    End Function

End Class
