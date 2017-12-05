Imports System.Text
Imports System.IO
Imports System.Xml.Serialization

Module FileSerializer

    Public Sub Serialize(ByVal DATA As RootObject, ByVal FilePath As String)
        If File.Exists(FilePath) Then
            File.Delete(FilePath)
        End If
        Dim SERIALIZER As XmlSerializer = New XmlSerializer(DATA.GetType)
        Using FILE_STREAM As FileStream = New FileStream(FilePath, FileMode.Create)
            SERIALIZER.Serialize(FILE_STREAM, DATA)
        End Using
    End Sub

    Public Function Deserialize(ByVal FilePath As String) As RootObject
        Dim DESERIALIZED_OBJECT As RootObject = New RootObject

        Dim SERIALIZED_TEXT As String = ""

        Using READER As StreamReader = New StreamReader(FilePath)
            SERIALIZED_TEXT = READER.ReadToEnd
        End Using

        Dim SERIALIZER As XmlSerializer = New XmlSerializer(DESERIALIZED_OBJECT.GetType)

        Using READER As TextReader = New StringReader(SERIALIZED_TEXT)
            DESERIALIZED_OBJECT = CType(SERIALIZER.Deserialize(READER), RootObject)
        End Using

        Return DESERIALIZED_OBJECT
    End Function
End Module
