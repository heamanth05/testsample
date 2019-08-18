﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1414
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

' 
' This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.1414.
' 


Imports Microsoft.VisualBasic
Imports System.Diagnostics
Imports System.Web.Services
Imports System.ComponentModel
Imports System.Web.Services.Protocols

Imports System.Xml.Serialization

Namespace BindtoContentService.com.microsoft.msdn.services


	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1414"), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Web.Services.WebServiceBindingAttribute(Name:="ContentServiceBinding", Namespace:="urn:msdn-com:public-content-syndication"), System.Xml.Serialization.XmlIncludeAttribute(GetType(requestedDocument())), System.Xml.Serialization.XmlIncludeAttribute(GetType(primary())), System.Xml.Serialization.XmlIncludeAttribute(GetType(image())), System.Xml.Serialization.XmlIncludeAttribute(GetType(common())), System.Xml.Serialization.XmlIncludeAttribute(GetType(feature()))>
	Partial Public Class ContentService
		Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

		Private appIdValueField As appId

		Private GetContentOperationCompleted As System.Threading.SendOrPostCallback

		Private GetNavigationPathsOperationCompleted As System.Threading.SendOrPostCallback

		Private useDefaultCredentialsSetExplicitly As Boolean

		''' <remarks/>
		Public Sub New()
			Me.Url = My.Settings.Default.BindtoContentService_com_microsoft_msdn_services_ContentService
			If (Me.IsLocalFileSystemWebService(Me.Url) = True) Then
				Me.UseDefaultCredentials = True
				Me.useDefaultCredentialsSetExplicitly = False
			Else
				Me.useDefaultCredentialsSetExplicitly = True
			End If
		End Sub

		Public Property appIdValue() As appId
			Get
				Return Me.appIdValueField
			End Get
			Set(ByVal value As appId)
				Me.appIdValueField = value
			End Set
		End Property

		Public Shadows Property Url() As String
			Get
				Return MyBase.Url
			End Get
			Set(ByVal value As String)
				If (((Me.IsLocalFileSystemWebService(MyBase.Url) = True) AndAlso (Me.useDefaultCredentialsSetExplicitly = False)) AndAlso (Me.IsLocalFileSystemWebService(value) = False)) Then
					MyBase.UseDefaultCredentials = False
				End If
				MyBase.Url = value
			End Set
		End Property

		Public Shadows Property UseDefaultCredentials() As Boolean
			Get
				Return MyBase.UseDefaultCredentials
			End Get
			Set(ByVal value As Boolean)
				MyBase.UseDefaultCredentials = value
				Me.useDefaultCredentialsSetExplicitly = True
			End Set
		End Property

		''' <remarks/>
		Public Event GetContentCompleted As GetContentCompletedEventHandler

		''' <remarks/>
		Public Event GetNavigationPathsCompleted As GetNavigationPathsCompletedEventHandler

		''' <remarks/>
		<System.Web.Services.Protocols.SoapHeaderAttribute("appIdValue"), System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:msdn-com:public-content-syndication/GetContent", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare)>
		Public Function GetContent(<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:msdn-com:public-content-syndication")> ByVal getContentRequest As getContentRequest) As <System.Xml.Serialization.XmlElementAttribute("getContentResponse", Namespace:="urn:msdn-com:public-content-syndication")> getContentResponse
			Dim results() As Object = Me.Invoke("GetContent", New Object() { getContentRequest})
			Return (CType(results(0), getContentResponse))
		End Function

		''' <remarks/>
		Public Sub GetContentAsync(ByVal getContentRequest As getContentRequest)
			Me.GetContentAsync(getContentRequest, Nothing)
		End Sub

		''' <remarks/>
		Public Sub GetContentAsync(ByVal getContentRequest As getContentRequest, ByVal userState As Object)
			If (Me.GetContentOperationCompleted Is Nothing) Then
				Me.GetContentOperationCompleted = New System.Threading.SendOrPostCallback(AddressOf Me.OnGetContentOperationCompleted)
			End If
			Me.InvokeAsync("GetContent", New Object() { getContentRequest}, Me.GetContentOperationCompleted, userState)
		End Sub

		Private Sub OnGetContentOperationCompleted(ByVal arg As Object)
			If (Me.GetContentCompletedEvent IsNot Nothing) Then
				Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = (CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs))
				RaiseEvent GetContentCompleted(Me, New GetContentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
			End If
		End Sub

		''' <remarks/>
		<System.Web.Services.Protocols.SoapHeaderAttribute("appIdValue"), System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:msdn-com:public-content-syndication/GetNavigationPaths", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare)>
		Public Function GetNavigationPaths(<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:msdn-com:public-content-syndication")> ByVal getNavigationPathsRequest As getNavigationPathsRequest) As <System.Xml.Serialization.XmlElementAttribute("getNavigationPathsResponse", Namespace:="urn:msdn-com:public-content-syndication")> getNavigationPathsResponse
			Dim results() As Object = Me.Invoke("GetNavigationPaths", New Object() { getNavigationPathsRequest})
			Return (CType(results(0), getNavigationPathsResponse))
		End Function

		''' <remarks/>
		Public Sub GetNavigationPathsAsync(ByVal getNavigationPathsRequest As getNavigationPathsRequest)
			Me.GetNavigationPathsAsync(getNavigationPathsRequest, Nothing)
		End Sub

		''' <remarks/>
		Public Sub GetNavigationPathsAsync(ByVal getNavigationPathsRequest As getNavigationPathsRequest, ByVal userState As Object)
			If (Me.GetNavigationPathsOperationCompleted Is Nothing) Then
				Me.GetNavigationPathsOperationCompleted = New System.Threading.SendOrPostCallback(AddressOf Me.OnGetNavigationPathsOperationCompleted)
			End If
			Me.InvokeAsync("GetNavigationPaths", New Object() { getNavigationPathsRequest}, Me.GetNavigationPathsOperationCompleted, userState)
		End Sub

		Private Sub OnGetNavigationPathsOperationCompleted(ByVal arg As Object)
			If (Me.GetNavigationPathsCompletedEvent IsNot Nothing) Then
				Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = (CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs))
				RaiseEvent GetNavigationPathsCompleted(Me, New GetNavigationPathsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
			End If
		End Sub

		''' <remarks/>
		Public Shadows Sub CancelAsync(ByVal userState As Object)
			MyBase.CancelAsync(userState)
		End Sub

		Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
			If ((url Is Nothing) OrElse (url = String.Empty)) Then
				Return False
			End If
			Dim wsUri As New System.Uri(url)
			If ((wsUri.Port >= 1024) AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
				Return True
			End If
			Return False
		End Function
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(Namespace:="urn:msdn-com:public-content-syndication/2006/09/common"), System.Xml.Serialization.XmlRootAttribute(Namespace:="urn:msdn-com:public-content-syndication/2006/09/common", IsNullable:=False)>
	Partial Public Class appId
		Inherits System.Web.Services.Protocols.SoapHeader

		Private valueField As String

		''' <remarks/>
		Public Property value() As String
			Get
				Return Me.valueField
			End Get
			Set(ByVal value As String)
				Me.valueField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(Namespace:="urn:msdn-com:public-content-syndication")>
	Partial Public Class navigationPathNode

		Private titleField As String

		Private isPhantomField As Boolean

		Private isPhantomFieldSpecified As Boolean

		Private navigationNodeKeyField As navigationKey

		Private contentNodeKeyField As navigationKey

		''' <remarks/>
		Public Property title() As String
			Get
				Return Me.titleField
			End Get
			Set(ByVal value As String)
				Me.titleField = value
			End Set
		End Property

		''' <remarks/>
		Public Property isPhantom() As Boolean
			Get
				Return Me.isPhantomField
			End Get
			Set(ByVal value As Boolean)
				Me.isPhantomField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlIgnoreAttribute()>
		Public Property isPhantomSpecified() As Boolean
			Get
				Return Me.isPhantomFieldSpecified
			End Get
			Set(ByVal value As Boolean)
				Me.isPhantomFieldSpecified = value
			End Set
		End Property

		''' <remarks/>
		Public Property navigationNodeKey() As navigationKey
			Get
				Return Me.navigationNodeKeyField
			End Get
			Set(ByVal value As navigationKey)
				Me.navigationNodeKeyField = value
			End Set
		End Property

		''' <remarks/>
		Public Property contentNodeKey() As navigationKey
			Get
				Return Me.contentNodeKeyField
			End Get
			Set(ByVal value As navigationKey)
				Me.contentNodeKeyField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(Namespace:="urn:msdn-com:public-content-syndication")>
	Partial Public Class navigationKey

		Private contentIdField As String

		Private localeField As String

		Private versionField As String

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property contentId() As String
			Get
				Return Me.contentIdField
			End Get
			Set(ByVal value As String)
				Me.contentIdField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property locale() As String
			Get
				Return Me.localeField
			End Get
			Set(ByVal value As String)
				Me.localeField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property version() As String
			Get
				Return Me.versionField
			End Get
			Set(ByVal value As String)
				Me.versionField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(Namespace:="urn:msdn-com:public-content-syndication")>
	Partial Public Class navigationPath

		Private navigationPathNodesField() As navigationPathNode

		''' <remarks/>
		<System.Xml.Serialization.XmlArrayItemAttribute(IsNullable:=False)>
		Public Property navigationPathNodes() As navigationPathNode()
			Get
				Return Me.navigationPathNodesField
			End Get
			Set(ByVal value As navigationPathNode())
				Me.navigationPathNodesField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(Namespace:="urn:msdn-com:public-content-syndication")>
	Partial Public Class availableVersionAndLocale

		Private localeField As String

		Private versionField As String

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property locale() As String
			Get
				Return Me.localeField
			End Get
			Set(ByVal value As String)
				Me.localeField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property version() As String
			Get
				Return Me.versionField
			End Get
			Set(ByVal value As String)
				Me.versionField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(Namespace:="urn:msdn-com:public-content-syndication")>
	Partial Public Class requestedDocument

		Private selectorField As String

		Private typeField As documentTypes

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute()>
		Public Property selector() As String
			Get
				Return Me.selectorField
			End Get
			Set(ByVal value As String)
				Me.selectorField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute()>
		Public Property type() As documentTypes
			Get
				Return Me.typeField
			End Get
			Set(ByVal value As documentTypes)
				Me.typeField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Xml.Serialization.XmlTypeAttribute(Namespace:="urn:msdn-com:public-content-syndication")>
	Public Enum documentTypes

		''' <remarks/>
		primary

		''' <remarks/>
		common

		''' <remarks/>
		image

		''' <remarks/>
		feature
	End Enum

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, Namespace:="urn:mtpg-com:mtps/2004/1/primary")>
	Partial Public Class primary

		Private anyField As System.Xml.XmlElement

		Private primaryFormatField As String

		Private locationField As String

		''' <remarks/>
		<System.Xml.Serialization.XmlAnyElementAttribute()>
		Public Property Any() As System.Xml.XmlElement
			Get
				Return Me.anyField
			End Get
			Set(ByVal value As System.Xml.XmlElement)
				Me.anyField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace:="urn:mtpg-com:mtps/2004/1/primary/category")>
		Public Property primaryFormat() As String
			Get
				Return Me.primaryFormatField
			End Get
			Set(ByVal value As String)
				Me.primaryFormatField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute()>
		Public Property location() As String
			Get
				Return Me.locationField
			End Get
			Set(ByVal value As String)
				Me.locationField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, Namespace:="urn:mtpg-com:mtps/2004/1/image")>
	Partial Public Class image

		Private nameField As String

		Private imageFormatField As String

		Private locationField As String

		Private valueField() As Byte

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute()>
		Public Property name() As String
			Get
				Return Me.nameField
			End Get
			Set(ByVal value As String)
				Me.nameField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace:="urn:mtpg-com:mtps/2004/1/image/category")>
		Public Property imageFormat() As String
			Get
				Return Me.imageFormatField
			End Get
			Set(ByVal value As String)
				Me.imageFormatField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute()>
		Public Property location() As String
			Get
				Return Me.locationField
			End Get
			Set(ByVal value As String)
				Me.locationField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlTextAttribute(DataType:="base64Binary")>
		Public Property Value() As Byte()
			Get
				Return Me.valueField
			End Get
			Set(ByVal value As Byte())
				Me.valueField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, Namespace:="urn:mtpg-com:mtps/2004/1/common")>
	Partial Public Class common

		Private anyField() As System.Xml.XmlElement

		Private commonFormatField As String

		Private locationField As String

		''' <remarks/>
		<System.Xml.Serialization.XmlAnyElementAttribute()>
		Public Property Any() As System.Xml.XmlElement()
			Get
				Return Me.anyField
			End Get
			Set(ByVal value As System.Xml.XmlElement())
				Me.anyField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace:="urn:mtpg-com:mtps/2004/1/common/category")>
		Public Property commonFormat() As String
			Get
				Return Me.commonFormatField
			End Get
			Set(ByVal value As String)
				Me.commonFormatField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute()>
		Public Property location() As String
			Get
				Return Me.locationField
			End Get
			Set(ByVal value As String)
				Me.locationField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, Namespace:="urn:mtpg-com:mtps/2004/1/feature")>
	Partial Public Class feature

		Private anyField() As System.Xml.XmlElement

		Private featureFormatField As String

		Private locationField As String

		''' <remarks/>
		<System.Xml.Serialization.XmlAnyElementAttribute()>
		Public Property Any() As System.Xml.XmlElement()
			Get
				Return Me.anyField
			End Get
			Set(ByVal value As System.Xml.XmlElement())
				Me.anyField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace:="urn:mtpg-com:mtps/2004/1/feature/category")>
		Public Property featureFormat() As String
			Get
				Return Me.featureFormatField
			End Get
			Set(ByVal value As String)
				Me.featureFormatField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute()>
		Public Property location() As String
			Get
				Return Me.locationField
			End Get
			Set(ByVal value As String)
				Me.locationField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, Namespace:="urn:msdn-com:public-content-syndication")>
	Partial Public Class getContentRequest

		Private contentIdentifierField As String

		Private localeField As String

		Private versionField As String

		Private requestedDocumentsField() As requestedDocument

		''' <remarks/>
		Public Property contentIdentifier() As String
			Get
				Return Me.contentIdentifierField
			End Get
			Set(ByVal value As String)
				Me.contentIdentifierField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property locale() As String
			Get
				Return Me.localeField
			End Get
			Set(ByVal value As String)
				Me.localeField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property version() As String
			Get
				Return Me.versionField
			End Get
			Set(ByVal value As String)
				Me.versionField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlArrayItemAttribute(IsNullable:=False)>
		Public Property requestedDocuments() As requestedDocument()
			Get
				Return Me.requestedDocumentsField
			End Get
			Set(ByVal value As requestedDocument())
				Me.requestedDocumentsField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, Namespace:="urn:msdn-com:public-content-syndication")>
	Partial Public Class getContentResponse

		Private contentIdField As String

		Private contentGuidField As String

		Private contentAliasField As String

		Private localeField As String

		Private versionField As String

		Private availableVersionsAndLocalesField() As availableVersionAndLocale

		Private primaryDocumentsField() As primary

		Private imageDocumentsField() As image

		Private commonDocumentsField() As common

		Private featureDocumentsField() As feature

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property contentId() As String
			Get
				Return Me.contentIdField
			End Get
			Set(ByVal value As String)
				Me.contentIdField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property contentGuid() As String
			Get
				Return Me.contentGuidField
			End Get
			Set(ByVal value As String)
				Me.contentGuidField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property contentAlias() As String
			Get
				Return Me.contentAliasField
			End Get
			Set(ByVal value As String)
				Me.contentAliasField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property locale() As String
			Get
				Return Me.localeField
			End Get
			Set(ByVal value As String)
				Me.localeField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlElementAttribute(Namespace:="urn:mtpg-com:mtps/2004/1/key")>
		Public Property version() As String
			Get
				Return Me.versionField
			End Get
			Set(ByVal value As String)
				Me.versionField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlArrayItemAttribute(IsNullable:=False)>
		Public Property availableVersionsAndLocales() As availableVersionAndLocale()
			Get
				Return Me.availableVersionsAndLocalesField
			End Get
			Set(ByVal value As availableVersionAndLocale())
				Me.availableVersionsAndLocalesField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlArrayItemAttribute("primary", Namespace:="urn:mtpg-com:mtps/2004/1/primary", IsNullable:=False)>
		Public Property primaryDocuments() As primary()
			Get
				Return Me.primaryDocumentsField
			End Get
			Set(ByVal value As primary())
				Me.primaryDocumentsField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlArrayItemAttribute("image", Namespace:="urn:mtpg-com:mtps/2004/1/image", IsNullable:=False)>
		Public Property imageDocuments() As image()
			Get
				Return Me.imageDocumentsField
			End Get
			Set(ByVal value As image())
				Me.imageDocumentsField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlArrayItemAttribute("common", Namespace:="urn:mtpg-com:mtps/2004/1/common", IsNullable:=False)>
		Public Property commonDocuments() As common()
			Get
				Return Me.commonDocumentsField
			End Get
			Set(ByVal value As common())
				Me.commonDocumentsField = value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlArrayItemAttribute("feature", Namespace:="urn:mtpg-com:mtps/2004/1/feature", IsNullable:=False)>
		Public Property featureDocuments() As feature()
			Get
				Return Me.featureDocumentsField
			End Get
			Set(ByVal value As feature())
				Me.featureDocumentsField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, Namespace:="urn:msdn-com:public-content-syndication")>
	Partial Public Class getNavigationPathsRequest

		Private rootField As navigationKey

		Private targetField As navigationKey

		''' <remarks/>
		Public Property root() As navigationKey
			Get
				Return Me.rootField
			End Get
			Set(ByVal value As navigationKey)
				Me.rootField = value
			End Set
		End Property

		''' <remarks/>
		Public Property target() As navigationKey
			Get
				Return Me.targetField
			End Get
			Set(ByVal value As navigationKey)
				Me.targetField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1414"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, Namespace:="urn:msdn-com:public-content-syndication")>
	Partial Public Class getNavigationPathsResponse

		Private navigationPathsField() As navigationPath

		''' <remarks/>
		<System.Xml.Serialization.XmlArrayItemAttribute(IsNullable:=False)>
		Public Property navigationPaths() As navigationPath()
			Get
				Return Me.navigationPathsField
			End Get
			Set(ByVal value As navigationPath())
				Me.navigationPathsField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1414")>
	Public Delegate Sub GetContentCompletedEventHandler(ByVal sender As Object, ByVal e As GetContentCompletedEventArgs)

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1414"), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code")>
	Partial Public Class GetContentCompletedEventArgs
		Inherits System.ComponentModel.AsyncCompletedEventArgs

		Private results() As Object

		Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
			MyBase.New(exception, cancelled, userState)
			Me.results = results
		End Sub

		''' <remarks/>
		Public ReadOnly Property Result() As getContentResponse
			Get
				Me.RaiseExceptionIfNecessary()
				Return (CType(Me.results(0), getContentResponse))
			End Get
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1414")>
	Public Delegate Sub GetNavigationPathsCompletedEventHandler(ByVal sender As Object, ByVal e As GetNavigationPathsCompletedEventArgs)

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1414"), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code")>
	Partial Public Class GetNavigationPathsCompletedEventArgs
		Inherits System.ComponentModel.AsyncCompletedEventArgs

		Private results() As Object

		Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
			MyBase.New(exception, cancelled, userState)
			Me.results = results
		End Sub

		''' <remarks/>
		Public ReadOnly Property Result() As getNavigationPathsResponse
			Get
				Me.RaiseExceptionIfNecessary()
				Return (CType(Me.results(0), getNavigationPathsResponse))
			End Get
		End Property
	End Class
End Namespace
