Imports System.Runtime.Serialization
Imports System.Xml.Serialization
Imports CraftingProgression

<XmlInclude(GetType(MaterialObject))>
<XmlInclude(GetType(RecipeObject))>
<Serializable()>
Public MustInherit Class CraftingObject
    <XmlAttribute>
    Public Title As String

    <XmlAttribute>
    Public Type As String
End Class
