Imports Newtonsoft.Json

Public Class Value

    <JsonProperty(PropertyName:="name")>
    Private _name As String
    <JsonProperty(PropertyName:="number")>
    Private _number As Integer
    <JsonProperty(PropertyName:="isPublic")>
    Private _isPublic As Boolean

    <JsonIgnore>
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    <JsonIgnore>
    Public Property Number As Integer
        Get
            Return _number
        End Get
        Set(value As Integer)
            _number = value
        End Set
    End Property

    <JsonIgnore>
    Public Property IsPublic As Boolean
        Get
            Return _isPublic
        End Get
        Set(value As Boolean)
            _isPublic = value
        End Set
    End Property

End Class
