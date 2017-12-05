Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Xml.Serialization


<XmlInclude(GetType(CraftingObject))>
<XmlInclude(GetType(MaterialObject))>
<XmlInclude(GetType(RecipeObject))>
<Serializable()>
Public Class RootObject
    <XmlAttribute>
    Public Title As String

    <XmlElement>
    Public Data As RecipeObject
End Class
