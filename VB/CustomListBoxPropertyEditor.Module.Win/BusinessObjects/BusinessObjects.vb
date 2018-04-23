Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo

Namespace CustomListBoxPropertyEditor.Module.Win.Editors
    <DefaultClassOptions> _
    Public Class Contact
        Inherits BaseObject


        Private titleOfCourtesy_Renamed As TitleOfCourtesy
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Property TitleOfCourtesy() As TitleOfCourtesy
            Get
                Return titleOfCourtesy_Renamed
            End Get
            Set(ByVal value As TitleOfCourtesy)
                SetPropertyValue("TitleOfCourtesy", titleOfCourtesy_Renamed, value)
            End Set
        End Property

        Private firstName_Renamed As String
        Public Property FirstName() As String
            Get
                Return firstName_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("FirstName", firstName_Renamed, value)
            End Set
        End Property

        Private lastName_Renamed As String
        Public Property LastName() As String
            Get
                Return lastName_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("LastName", lastName_Renamed, value)
            End Set
        End Property

        Private position_Renamed As Position
        <ImmediatePostDataAttribute> _
        Public Property Position() As Position
            Get
                Return position_Renamed
            End Get
            Set(ByVal value As Position)
                SetPropertyValue("Position", position_Renamed, value)
            End Set
        End Property
    End Class
    Public Enum TitleOfCourtesy
        Dr
        Miss
        Mr
        Mrs
        Ms
    End Enum

    Public Class Position
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private title_Renamed As String
        Public Property Title() As String
            Get
                Return title_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Title", title_Renamed, value)
            End Set
        End Property
    End Class
End Namespace

