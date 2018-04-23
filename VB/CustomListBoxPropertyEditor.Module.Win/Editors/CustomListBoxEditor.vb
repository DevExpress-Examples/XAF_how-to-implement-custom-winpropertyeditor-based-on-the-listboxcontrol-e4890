Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.ExpressApp
Imports DevExpress.XtraEditors

Namespace CustomListBoxPropertyEditor.Module.Win.Editors
    <PropertyEditor(GetType(Object), False)> _
    Public Class CustomListBoxEditor
        Inherits WinPropertyEditor
        Implements IComplexViewItem

        Private theObjectSpace As IObjectSpace
        Private listBox As ListBoxControl
        Public ReadOnly Property ObjectSpace() As IObjectSpace
            Get
                Return theObjectSpace
            End Get
        End Property

        Public Sub New(ByVal objectType As Type, ByVal info As IModelMemberViewItem)
            MyBase.New(objectType, info)
        End Sub

        'Customize ListBoxControl properties in the CreateControlCore method to support Model properties, such as LookupProperty.
        Protected Overrides Function CreateControlCore() As Object
            ControlBindingProperty = "SelectedItem"
            listBox = New ListBoxControl() With {.ValueMember = Model.LookupProperty}
            If ImmediatePostData Then
                AddHandler listBox.SelectedIndexChanged, AddressOf listBox_SelectedIndexChanged
            End If
            listBox.Items.Clear()
            listBox.DataSource = ObjectSpace.CreateCollection(Model.ModelMember.Type)
            listBox.DisplayMember = Model.LookupProperty
            Return listBox
        End Function
        Private Sub listBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            TryCast(sender, ListBoxControl).DataBindings("SelectedItem").WriteValue()
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso listBox IsNot Nothing Then
                RemoveHandler listBox.SelectedIndexChanged, AddressOf listBox_SelectedIndexChanged
                listBox = Nothing
            End If
            MyBase.Dispose(disposing)
        End Sub
        Public Sub Setup(ByVal objectSpace As IObjectSpace, ByVal application As XafApplication) Implements IComplexViewItem.Setup 
            theObjectSpace = objectSpace
        End Sub
    End Class
End Namespace
