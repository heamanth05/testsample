﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------




Imports Microsoft.VisualBasic

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), System.ServiceModel.ServiceContractAttribute(Namespace:="http://microsoft.wcf.documentation", ConfigurationName:="SampleDuplexHello", CallbackContract:=GetType(SampleDuplexHelloCallback), SessionMode:=System.ServiceModel.SessionMode.Required)> _
Public Interface SampleDuplexHello

	<System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://microsoft.wcf.documentation/SampleDuplexHello/Hello")> _
	Sub Hello(ByVal greeting As String)
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface SampleDuplexHelloCallback

	<System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://microsoft.wcf.documentation/SampleDuplexHello/Reply")> _
	Sub Reply(ByVal responseToGreeting As String)
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface SampleDuplexHelloChannel
	Inherits SampleDuplexHello, System.ServiceModel.IClientChannel
End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Partial Public Class SampleDuplexHelloClient
	Inherits System.ServiceModel.DuplexClientBase(Of SampleDuplexHello)
	Implements SampleDuplexHello

	Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext)
		MyBase.New(callbackInstance)
	End Sub

	Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String)
		MyBase.New(callbackInstance, endpointConfigurationName)
	End Sub

	Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
		MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(callbackInstance, binding, remoteAddress)
	End Sub

	Public Sub Hello(ByVal greeting As String) Implements SampleDuplexHello.Hello
		MyBase.Channel.Hello(greeting)
	End Sub
End Class
