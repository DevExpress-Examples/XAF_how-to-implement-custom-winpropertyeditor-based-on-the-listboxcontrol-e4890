Imports CustomListBoxPropertyEditor.Module.Win.Editors
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace CustomListBoxPropertyEditor.Module.Win.DatabaseUpdate
    ' Allows you to handle a database update when the application version changes (http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic help article for more details).
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        ' Override to specify the database update code which should be performed after the database schema is updated (http://documentation.devexpress.com/#Xaf/DevExpressExpressAppUpdatingModuleUpdater_UpdateDatabaseAfterUpdateSchematopic).
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            Dim Customer As Position = ObjectSpace.FindObject(Of Position)(New BinaryOperator("Title", "Customer", BinaryOperatorType.Equal))
            If Customer Is Nothing Then
                Customer = ObjectSpace.CreateObject(Of Position)()
                Customer.Title = "Customer"
            End If
            Dim HR As Position = ObjectSpace.FindObject(Of Position)(New BinaryOperator("Title", "HR", BinaryOperatorType.Equal))
            If HR Is Nothing Then
                HR = ObjectSpace.CreateObject(Of Position)()
                HR.Title = "HR"
            End If
            Dim Manager As Position = ObjectSpace.FindObject(Of Position)(New BinaryOperator("Title", "Manager", BinaryOperatorType.Equal))
            If Manager Is Nothing Then
                Manager = ObjectSpace.CreateObject(Of Position)()
                Manager.Title = "Manager"
            End If
            Dim AlexSmith As Contact = ObjectSpace.FindObject(Of Contact)(New BinaryOperator("FirstName", "Alex", BinaryOperatorType.Equal))
            If AlexSmith Is Nothing Then
                AlexSmith = ObjectSpace.CreateObject(Of Contact)()
                AlexSmith.FirstName = "Alex"
                AlexSmith.LastName = "Smith"
                AlexSmith.Position = Manager
                AlexSmith.TitleOfCourtesy = TitleOfCourtesy.Mr
            End If

        End Sub


    End Class
End Namespace

