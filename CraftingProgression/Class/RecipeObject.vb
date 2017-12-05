Imports System.Runtime.Serialization
Imports System.Text
Imports System.Xml.Serialization

<XmlInclude(GetType(CraftingObject))>
<XmlInclude(GetType(MaterialObject))>
<XmlInclude(GetType(RecipeObject))>
<Serializable()>
Public Class RecipeObject
    Inherits CraftingObject
    <XmlArray>
    Public Recipes As List(Of RecipeObject)

    <XmlArray>
    Public Materials As List(Of MaterialObject)
End Class
