Imports System.Runtime.Serialization
Imports System.Xml.Serialization

<XmlInclude(GetType(CraftingObject))>
<XmlInclude(GetType(MaterialObject))>
<XmlInclude(GetType(RecipeObject))>
<Serializable()>
Public Class MaterialObject
    Inherits CraftingObject

    <XmlAttribute>
    Public AmountOwned As Integer

    <XmlAttribute>
    Public AmountNeeded As Integer
End Class
