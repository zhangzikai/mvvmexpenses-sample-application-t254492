﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
Friend Class CommonResources

    Private Shared resourceMan As Global.System.Resources.ResourceManager

    Private Shared resourceCulture As Global.System.Globalization.CultureInfo

    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
    Friend Sub New()
        MyBase.New()
    End Sub

    '''<summary>
    '''  Returns the cached ResourceManager instance used by this class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("CommonResources", GetType(CommonResources).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property

    '''<summary>
    '''  Overrides the current thread's CurrentUICulture property for all
    '''  resource lookups using this strongly typed resource class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
        Get
            Return resourceCulture
        End Get
        Set(value As Global.System.Globalization.CultureInfo)
            resourceCulture = Value
        End Set
    End Property

    '''<summary>
    '''  Looks up a localized string similar to Confirmation.
    '''</summary>
    Friend Shared ReadOnly Property Confirmation_Caption() As String
        Get
            Return ResourceManager.GetString("Confirmation_Caption", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to Do you want to delete this {0}?.
    '''</summary>
    Friend Shared ReadOnly Property Confirmation_Delete() As String
        Get
            Return ResourceManager.GetString("Confirmation_Delete", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to Click OK to reload the entity and lose unsaved changes. Click Cancel to continue editing data..
    '''</summary>
    Friend Shared ReadOnly Property Confirmation_Reset() As String
        Get
            Return ResourceManager.GetString("Confirmation_Reset", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to Are you sure you want to reset layout? Reopen this view for the new layout to take effect..
    '''</summary>
    Friend Shared ReadOnly Property Confirmation_ResetLayout() As String
        Get
            Return ResourceManager.GetString("Confirmation_ResetLayout", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to Do you want to save changes?.
    '''</summary>
    Friend Shared ReadOnly Property Confirmation_Save() As String
        Get
            Return ResourceManager.GetString("Confirmation_Save", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to You need to save the parent {0} entity before adding a new record. Do you want to save it now?.
    '''</summary>
    Friend Shared ReadOnly Property Confirmation_SaveParent() As String
        Get
            Return ResourceManager.GetString("Confirmation_SaveParent", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to  *.
    '''</summary>
    Friend Shared ReadOnly Property Entity_Changed() As String
        Get
            Return ResourceManager.GetString("Entity_Changed", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to  (New).
    '''</summary>
    Friend Shared ReadOnly Property Entity_New() As String
        Get
            Return ResourceManager.GetString("Entity_New", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to DataService Request Error.
    '''</summary>
    Friend Shared ReadOnly Property Exception_DataServiceRequestErrorCaption() As String
        Get
            Return ResourceManager.GetString("Exception_DataServiceRequestErrorCaption", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to Update Error.
    '''</summary>
    Friend Shared ReadOnly Property Exception_UpdateErrorCaption() As String
        Get
            Return ResourceManager.GetString("Exception_UpdateErrorCaption", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to Validation Error.
    '''</summary>
    Friend Shared ReadOnly Property Exception_ValidationErrorCaption() As String
        Get
            Return ResourceManager.GetString("Exception_ValidationErrorCaption", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to Warning.
    '''</summary>
    Friend Shared ReadOnly Property Warning_Caption() As String
        Get
            Return ResourceManager.GetString("Warning_Caption", resourceCulture)
        End Get
    End Property

    '''<summary>
    '''  Looks up a localized string similar to Some fields contain invalid data. Click OK to close the page and lose unsaved changes. Press Cancel to continue editing data..
    '''</summary>
    Friend Shared ReadOnly Property Warning_SomeFieldsContainInvalidData() As String
        Get
            Return ResourceManager.GetString("Warning_SomeFieldsContainInvalidData", resourceCulture)
        End Get
    End Property
End Class
