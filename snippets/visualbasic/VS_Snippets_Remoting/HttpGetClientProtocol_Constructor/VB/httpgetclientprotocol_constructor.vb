﻿' System.Web.Services.Protocols.HttpGetClientProtocol.HttpGetClientProtocol

' The following example demonstrates 'Constructor' of 'HttpGetClientProtocol' class
' A variable of type 'HttpGetClientProtocol' is used to set proxy information ,
' client credentials and Url on the proxy class.

' 
' The following example is a proxy class generated by the Wsdl.exe 
' utility for the Math Web service. The proxy class derives from 
' HttpGetClientProtocol, which derives from the abstract 
' HttpSimpleClientProtocol class.

'Public Class MyMath
'    Inherits System.Web.Services.Protocols.HttpGetClientProtocol
'    
'    <System.Diagnostics.DebuggerStepThroughAttribute()>  _
'    Public Sub New()
'        MyBase.New
'        Me.Url = "http://localhost/Mymath.Vb.asmx"
'    End Sub
'    
'    <System.Diagnostics.DebuggerStepThroughAttribute(), _
'        System.Web.Services.Protocols.HttpMethodAttribute( _
'        GetType(System.Web.Services.Protocols.XmlReturnReader), _
'        GetType(System.Web.Services.Protocols.UrlParameterWriter))> _
'    Public Function Add(ByVal num1 As String, ByVal num2 As String) As _
'        <System.Xml.Serialization.XmlRootAttribute("int", _
'        [Namespace]:="http://tempuri.org/", IsNullable:=false)> Integer
'
'        Return CType(Me.Invoke("Add", (Me.Url + "/Add"), _
'            New Object() {num1, num2}),Integer)
'    End Function
'    
'    <System.Diagnostics.DebuggerStepThroughAttribute()>  _
'    Public Function BeginAdd(ByVal num1 As String, ByVal num2 As String, _
'        ByVal callback As System.AsyncCallback, ByVal asyncState As Object) _
'        As System.IAsyncResult
'
'        Return Me.BeginInvoke("Add", (Me.Url + "/Add"), _
'            New Object() {num1, num2}, callback, asyncState)
'    End Function
'    
'    <System.Diagnostics.DebuggerStepThroughAttribute()>  _
'    Public Function EndAdd(ByVal asyncResult As System.IAsyncResult) As Integer
'        Return CType(Me.EndInvoke(asyncResult),Integer)
'    End Function
'End Class


Imports System.Net
Imports System.Web.Services.Protocols
Imports System.Web.Services
Imports MyMath

Public Class Math
    Inherits HttpGetClientProtocol
end Class

Public Class HttpGetClientProtocolClass
    Public Shared Sub Main()
' <Snippet1>
        ' Math is a proxy class derived from HttpGetClientProtocol.
        Dim myHttpGetClientProtocol As New Math()

        ' Obtain password from a secure store.
        Dim SecurelyStoredPassword As String = String.Empty

        ' Set the client-side credentials using the Credentials property.
        Dim credentials = _
            New NetworkCredential("Joe", "mydomain", SecurelyStoredPassword)
        myHttpGetClientProtocol.Credentials = credentials

        ' Allow the server to redirect the request.
        myHttpGetClientProtocol.AllowAutoRedirect = True
        Console.WriteLine("Auto redirect is: " _
            & myHttpGetClientProtocol.AllowAutoRedirect)
' </Snippet1>
    End Sub 'Main
End Class 'HttpGetClientProtocolClass


