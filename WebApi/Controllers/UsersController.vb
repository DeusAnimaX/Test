Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Namespace Controllers
    Public Class UsersController
        Inherits ApiController

        ' GET: api/Users
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Users/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Users
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' GET api/Users/login/{nick}/{pass}
        <Route("api/Users/login/{nick}/{pass}")>
        <HttpGet>
        Public Function loginAdmin(ByVal nick As String, ByVal pass As String) As HttpResponseMessage
            Dim user = New User()
            user.Username = nick
            user.Password = pass
            user.Age = nick.Length
            user.IsAdmin = nick.Equals(pass)
            Return Request.CreateResponse(HttpStatusCode.OK, user)
        End Function

        ' PUT: api/Users/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Users/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace