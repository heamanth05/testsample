﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), System.ServiceModel.ServiceContractAttribute(Namespace:="http://microsoft.wcf.documentation", ConfigurationName:="IStatefulService", SessionMode:=System.ServiceModel.SessionMode.Required)> _
Public Interface IStatefulService

	<System.ServiceModel.OperationContractAttribute(Action:="http://microsoft.wcf.documentation/IStatefulService/GetSessionID", ReplyAction:="http://microsoft.wcf.documentation/IStatefulService/GetSessionIDResponse")> _
	Function GetSessionID() As String
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface IStatefulServiceChannel
	Inherits IStatefulService, System.ServiceModel.IClientChannel
End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Partial Public Class StatefulServiceClient
	Inherits System.ServiceModel.ClientBase(Of IStatefulService)
	Implements IStatefulService

	Public Sub New()
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String)
		MyBase.New(endpointConfigurationName)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(binding, remoteAddress)
	End Sub

	Public Function GetSessionID() As String Implements IStatefulService.GetSessionID
		Return MyBase.Channel.GetSessionID()
	End Function
End Class
