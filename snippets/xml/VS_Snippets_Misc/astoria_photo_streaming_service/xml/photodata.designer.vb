﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

<Assembly: EdmSchemaAttribute("1b25d1c7-387a-4fa0-8838-b45a9a710eac")>

#Region "Contexts"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
Public Partial Class PhotoDataContainer
    Inherits ObjectContext

    #Region "Constructors"

    ''' <summary>
    ''' Initializes a new PhotoDataContainer object using the connection string found in the 'PhotoDataContainer' section of the application configuration file.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=PhotoDataContainer", "PhotoDataContainer")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new PhotoDataContainer object.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "PhotoDataContainer")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new PhotoDataContainer object.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "PhotoDataContainer")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Partial Methods"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

    #Region "ObjectSet Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property PhotoInfo() As ObjectSet(Of PhotoInfo)
        Get
            If (_PhotoInfo Is Nothing) Then
                _PhotoInfo = MyBase.CreateObjectSet(Of PhotoInfo)("PhotoInfo")
            End If
            Return _PhotoInfo
        End Get
    End Property

    Private _PhotoInfo As ObjectSet(Of PhotoInfo)

    #End Region
    #Region "AddTo Methods"

    ''' <summary>
    ''' Deprecated Method for adding a new object to the PhotoInfo EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToPhotoInfo(ByVal photoInfo As PhotoInfo)
        MyBase.AddObject("PhotoInfo", photoInfo)
    End Sub

    #End Region
End Class

#End Region
#Region "Entities"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="PhotoData", Name:="PhotoInfo")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class PhotoInfo
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new PhotoInfo object.
    ''' </summary>
    ''' <param name="photoId">Initial value of the PhotoId property.</param>
    ''' <param name="fileName">Initial value of the FileName property.</param>
    ''' <param name="dateAdded">Initial value of the DateAdded property.</param>
    ''' <param name="exposure">Initial value of the Exposure property.</param>
    ''' <param name="dimensions">Initial value of the Dimensions property.</param>
    ''' <param name="dateModified">Initial value of the DateModified property.</param>
    Public Shared Function CreatePhotoInfo(photoId As Global.System.Int32, fileName As Global.System.String, dateAdded As Global.System.DateTime, exposure As Exposure, dimensions As Dimensions, dateModified As Global.System.DateTime) As PhotoInfo
        Dim photoInfo as PhotoInfo = New PhotoInfo
        photoInfo.PhotoId = photoId
        photoInfo.FileName = fileName
        photoInfo.DateAdded = dateAdded
        photoInfo.Exposure = StructuralObject.VerifyComplexObjectIsNotNull(exposure, "Exposure")
        photoInfo.Dimensions = StructuralObject.VerifyComplexObjectIsNotNull(dimensions, "Dimensions")
        photoInfo.DateModified = dateModified
        Return photoInfo
    End Function

    #End Region
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property PhotoId() As Global.System.Int32
        Get
            Return _PhotoId
        End Get
        Set
            If (_PhotoId <> Value) Then
                OnPhotoIdChanging(value)
                ReportPropertyChanging("PhotoId")
                _PhotoId = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("PhotoId")
                OnPhotoIdChanged()
            End If
        End Set
    End Property

    Private _PhotoId As Global.System.Int32
    Private Partial Sub OnPhotoIdChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnPhotoIdChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property FileName() As Global.System.String
        Get
            Return _FileName
        End Get
        Set
            OnFileNameChanging(value)
            ReportPropertyChanging("FileName")
            _FileName = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("FileName")
            OnFileNameChanged()
        End Set
    End Property

    Private _FileName As Global.System.String
    Private Partial Sub OnFileNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnFileNameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property FileSize() As Nullable(Of Global.System.Int32)
        Get
            Return _FileSize
        End Get
        Set
            OnFileSizeChanging(value)
            ReportPropertyChanging("FileSize")
            _FileSize = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("FileSize")
            OnFileSizeChanged()
        End Set
    End Property

    Private _FileSize As Nullable(Of Global.System.Int32)
    Private Partial Sub OnFileSizeChanging(value As Nullable(Of Global.System.Int32))
    End Sub

    Private Partial Sub OnFileSizeChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property DateTaken() As Nullable(Of Global.System.DateTime)
        Get
            Return _DateTaken
        End Get
        Set
            OnDateTakenChanging(value)
            ReportPropertyChanging("DateTaken")
            _DateTaken = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("DateTaken")
            OnDateTakenChanged()
        End Set
    End Property

    Private _DateTaken As Nullable(Of Global.System.DateTime)
    Private Partial Sub OnDateTakenChanging(value As Nullable(Of Global.System.DateTime))
    End Sub

    Private Partial Sub OnDateTakenChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property TakenBy() As Global.System.String
        Get
            Return _TakenBy
        End Get
        Set
            OnTakenByChanging(value)
            ReportPropertyChanging("TakenBy")
            _TakenBy = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("TakenBy")
            OnTakenByChanged()
        End Set
    End Property

    Private _TakenBy As Global.System.String
    Private Partial Sub OnTakenByChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnTakenByChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property DateAdded() As Global.System.DateTime
        Get
            Return _DateAdded
        End Get
        Set
            OnDateAddedChanging(value)
            ReportPropertyChanging("DateAdded")
            _DateAdded = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("DateAdded")
            OnDateAddedChanged()
        End Set
    End Property

    Private _DateAdded As Global.System.DateTime
    Private Partial Sub OnDateAddedChanging(value As Global.System.DateTime)
    End Sub

    Private Partial Sub OnDateAddedChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property DateModified() As Global.System.DateTime
        Get
            Return _DateModified
        End Get
        Set
            OnDateModifiedChanging(value)
            ReportPropertyChanging("DateModified")
            _DateModified = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("DateModified")
            OnDateModifiedChanged()
        End Set
    End Property

    Private _DateModified As Global.System.DateTime
    Private Partial Sub OnDateModifiedChanging(value As Global.System.DateTime)
    End Sub

    Private Partial Sub OnDateModifiedChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Comments() As Global.System.String
        Get
            Return _Comments
        End Get
        Set
            OnCommentsChanging(value)
            ReportPropertyChanging("Comments")
            _Comments = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("Comments")
            OnCommentsChanged()
        End Set
    End Property

    Private _Comments As Global.System.String
    Private Partial Sub OnCommentsChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnCommentsChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property ContentType() As Global.System.String
        Get
            Return _ContentType
        End Get
        Set
            OnContentTypeChanging(value)
            ReportPropertyChanging("ContentType")
            _ContentType = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("ContentType")
            OnContentTypeChanged()
        End Set
    End Property

    Private _ContentType As Global.System.String
    Private Partial Sub OnContentTypeChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnContentTypeChanged()
    End Sub

    #End Region
    #Region "Complex Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmComplexPropertyAttribute()>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <XmlElement(IsNullable:=True)>
    <SoapElement(IsNullable:=True)>
    <DataMemberAttribute()>
    Public Property Exposure() As Exposure
        Get
            _Exposure = GetValidValue(_Exposure, "Exposure", False, _ExposureInitialized)
            _ExposureInitialized = True
            Return _Exposure
        End Get
        Set
            OnExposureChanging(value)
            ReportPropertyChanging("Exposure")
            _Exposure = SetValidValue(_Exposure, value, "Exposure")
            _ExposureInitialized = True
            ReportPropertyChanged("Exposure")
            OnExposureChanged()
        End Set
    End Property

    Private _Exposure As Exposure

    Private _ExposureInitialized As Boolean

    Private Partial Sub OnExposureChanging(value As Exposure)
    End Sub

    Private Partial Sub OnExposureChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmComplexPropertyAttribute()>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <XmlElement(IsNullable:=True)>
    <SoapElement(IsNullable:=True)>
    <DataMemberAttribute()>
    Public Property Dimensions() As Dimensions
        Get
            _Dimensions = GetValidValue(_Dimensions, "Dimensions", False, _DimensionsInitialized)
            _DimensionsInitialized = True
            Return _Dimensions
        End Get
        Set
            OnDimensionsChanging(value)
            ReportPropertyChanging("Dimensions")
            _Dimensions = SetValidValue(_Dimensions, value, "Dimensions")
            _DimensionsInitialized = True
            ReportPropertyChanged("Dimensions")
            OnDimensionsChanged()
        End Set
    End Property

    Private _Dimensions As Dimensions

    Private _DimensionsInitialized As Boolean

    Private Partial Sub OnDimensionsChanging(value As Dimensions)
    End Sub

    Private Partial Sub OnDimensionsChanged()
    End Sub

    #End Region
End Class

#End Region
#Region "ComplexTypes"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmComplexTypeAttribute(NamespaceName:="PhotoData", Name:="Dimensions")>
<DataContractAttribute(IsReference:=True)>
<Serializable()>
Public Partial Class Dimensions
    Inherits ComplexObject
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Height() As Nullable(Of Global.System.Int16)
        Get
            Return _Height
        End Get
        Set
            OnHeightChanging(value)
            ReportPropertyChanging("Height")
            _Height = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("Height")
            OnHeightChanged()
        End Set
    End Property

    Private _Height As Nullable(Of Global.System.Int16)
    Private Partial Sub OnHeightChanging(value As Nullable(Of Global.System.Int16))
    End Sub

    Private Partial Sub OnHeightChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Width() As Nullable(Of Global.System.Int16)
        Get
            Return _Width
        End Get
        Set
            OnWidthChanging(value)
            ReportPropertyChanging("Width")
            _Width = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("Width")
            OnWidthChanged()
        End Set
    End Property

    Private _Width As Nullable(Of Global.System.Int16)
    Private Partial Sub OnWidthChanging(value As Nullable(Of Global.System.Int16))
    End Sub

    Private Partial Sub OnWidthChanged()
    End Sub

    #End Region
End Class

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmComplexTypeAttribute(NamespaceName:="PhotoData", Name:="Exposure")>
<DataContractAttribute(IsReference:=True)>
<Serializable()>
Public Partial Class Exposure
    Inherits ComplexObject
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Aperature() As Nullable(Of Global.System.Decimal)
        Get
            Return _Aperature
        End Get
        Set
            OnAperatureChanging(value)
            ReportPropertyChanging("Aperature")
            _Aperature = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("Aperature")
            OnAperatureChanged()
        End Set
    End Property

    Private _Aperature As Nullable(Of Global.System.Decimal)
    Private Partial Sub OnAperatureChanging(value As Nullable(Of Global.System.Decimal))
    End Sub

    Private Partial Sub OnAperatureChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property ShutterSpeed() As Nullable(Of Global.System.Int16)
        Get
            Return _ShutterSpeed
        End Get
        Set
            OnShutterSpeedChanging(value)
            ReportPropertyChanging("ShutterSpeed")
            _ShutterSpeed = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("ShutterSpeed")
            OnShutterSpeedChanged()
        End Set
    End Property

    Private _ShutterSpeed As Nullable(Of Global.System.Int16)
    Private Partial Sub OnShutterSpeedChanging(value As Nullable(Of Global.System.Int16))
    End Sub

    Private Partial Sub OnShutterSpeedChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property FilmSpeed() As Nullable(Of Global.System.Int16)
        Get
            Return _FilmSpeed
        End Get
        Set
            OnFilmSpeedChanging(value)
            ReportPropertyChanging("FilmSpeed")
            _FilmSpeed = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("FilmSpeed")
            OnFilmSpeedChanged()
        End Set
    End Property

    Private _FilmSpeed As Nullable(Of Global.System.Int16)
    Private Partial Sub OnFilmSpeedChanging(value As Nullable(Of Global.System.Int16))
    End Sub

    Private Partial Sub OnFilmSpeedChanged()
    End Sub

    #End Region
End Class

#End Region

