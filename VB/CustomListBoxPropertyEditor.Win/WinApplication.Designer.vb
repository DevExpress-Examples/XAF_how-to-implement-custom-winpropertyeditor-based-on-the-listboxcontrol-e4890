Namespace CustomListBoxPropertyEditor.Win
    Partial Public Class CustomListBoxPropertyEditorWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
            Me.customListBoxPropertyEditorWindowsFormsModule1 = New CustomListBoxPropertyEditor.Module.Win.CustomListBoxPropertyEditorWindowsFormsModule()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlConnection1
            ' 
            Me.sqlConnection1.ConnectionString = "Integrated Security=SSPI;Pooling=false;Data Source=.\SQLEXPRESS;Initial Catalog=C" & "ustomListBoxPropertyEditor"
            Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
            ' 
            ' CustomListBoxPropertyEditorWindowsFormsApplication
            ' 
            Me.ApplicationName = "CustomListBoxPropertyEditor"
            Me.Connection = Me.sqlConnection1
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.customListBoxPropertyEditorWindowsFormsModule1)
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private sqlConnection1 As System.Data.SqlClient.SqlConnection
        Private customListBoxPropertyEditorWindowsFormsModule1 As CustomListBoxPropertyEditor.Module.Win.CustomListBoxPropertyEditorWindowsFormsModule
    End Class
End Namespace
