Imports Newtonsoft.Json

Public Class User

    <JsonProperty(PropertyName:="age")>
    Private _age As Integer
    <JsonProperty(PropertyName:="username")>
    Private _username As String
    <JsonProperty(PropertyName:="password")>
    Private _password As String
    <JsonProperty(PropertyName:="isAdmin")>
    Private _isAdmin As Boolean

    <JsonIgnore>
    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    <JsonIgnore>
    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    <JsonIgnore>
    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property IsAdmin As Boolean
        Get
            Return _isAdmin
        End Get
        Set(value As Boolean)
            _isAdmin = value
        End Set
    End Property
End Class
