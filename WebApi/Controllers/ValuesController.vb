Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class ValuesController
    Inherits ApiController

    ' GET api/values
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/values/5
    Public Function GetValue(ByVal id As Integer) As HttpResponseMessage
        Dim value = New Value()
        value.Name = "valor" + id.ToString
        value.Number = id
        value.IsPublic = id < 10
        Return Request.CreateResponse(HttpStatusCode.OK, value)
    End Function

    ' POST api/values/add/{increment}
    ' body: value
    <Route("api/values/add/{increment}")>
    <HttpPost>
    Public Function AddIncrement(ByVal increment As Integer, <FromBody()> ByVal value As Value) As HttpResponseMessage
        value.Name = "My name" + increment.ToString()
        value.Number += increment
        value.IsPublic = Not value.IsPublic
        Return Request.CreateResponse(HttpStatusCode.OK, value)
    End Function

    ' POST api/values
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/values/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
