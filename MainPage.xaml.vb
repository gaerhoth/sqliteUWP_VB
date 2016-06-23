Imports SQLite.Net
Imports SQLite.Net.Platform.WinRT
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Runtime.InteropServices.WindowsRuntime
Imports Windows.ApplicationModel
Imports Windows.ApplicationModel.Activation
Imports Windows.Foundation
Imports Windows.Foundation.Collections
Imports Windows.Storage
Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Controls
Imports Windows.UI.Xaml.Controls.Primitives
Imports Windows.UI.Xaml.Data
Imports Windows.UI.Xaml.Input
Imports Windows.UI.Xaml.Media
Imports Windows.UI.Xaml.Navigation



'Namespace UWPSQLiteDemo

'    ''' <summary>
'    ''' An empty page that can be used on its own or navigated to within a Frame.
'    ''' </summary>

'    Partial Public NotInheritable Class MainPage
'        Inherits Page
'        Private ruta As String
'        Private conn As SQLite.Net.SQLiteConnection

'        Public Sub New()

'            ruta = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite")
'            conn = New SQLite.Net.SQLiteConnection(New SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), ruta)
'            conn.CreateTable(Of Customer)()
'        End Sub

'        Private Sub Retrieve_Click(sender As Object, e As RoutedEventArgs)
'            Dim query = conn.Table(Of Customer)()
'            Dim id As String = ""
'            Dim name As String = ""
'            Dim age As String = ""

'            For Each message As var In query
'                id = (id & Convert.ToString(" ")) + message.Id
'                name = (name & Convert.ToString(" ")) + message.Name
'                age = (age & Convert.ToString(" ")) + message.Age
'            Next

'            MainPage.textBlock2.Text = Convert.ToString((Convert.ToString((Convert.ToString("ID: ") & id) + vbLf & "Name: ") & name) + vbLf & "Age: ") & age
'        End Sub

'        Private Sub Add_Click(sender As Object, e As RoutedEventArgs)

'            Dim s = conn.Insert(New Customer() With {
'                .Name = TextBox.Text,
'                .Age = txt1.Text
'            })

'        End Sub
'    End Class

'    Public Class Customer
'        <PrimaryKey, AutoIncrement>
'        Public Property Id() As Integer
'            Get
'                Return m_Id
'            End Get
'            Set
'                m_Id = Value
'            End Set
'        End Property
'        Private m_Id As Integer
'        Public Property Name() As String
'            Get
'                Return m_Name
'            End Get
'            Set
'                m_Name = Value
'            End Set
'        End Property
'        Private m_Name As String
'        Public Property Age() As String
'            Get
'                Return m_Age
'            End Get
'            Set
'                m_Age = Value
'            End Set
'        End Property
'        Private m_Age As String
'    End Class

'End Namespace




Public NotInheritable Class MainPage
    Inherits Page
    Private ruta As String
    Private conn As SQLite.Net.SQLiteConnection

    Public Sub New()
        Me.InitializeComponent()
        ' ruta = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite")

        ruta = Path.Combine(ApplicationData.Current.LocalFolder.Path, "ddbb.sqlite")
        conn = New SQLite.Net.SQLiteConnection(New SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), ruta)
        conn.CreateTable(Of Customer)()
    End Sub

    Private Sub Retrieve_Click(sender As Object, e As RoutedEventArgs)
        Dim query = conn.Table(Of Customer)()
        Dim id As String = ""
        Dim name As String = ""
        Dim age As String = ""

        For Each message In query
            id = (id & Convert.ToString(" ")) + message.Id
            name = (name & Convert.ToString(" ")) + message.Name
            age = (age & Convert.ToString(" ")) + message.Age
        Next

        textBlock2.Text = Convert.ToString((Convert.ToString((Convert.ToString("ID: ") & id) + vbLf & "Name: ") & name) + vbLf & "Age: ") & age
    End Sub

    Private Sub Add_Click(sender As Object, e As RoutedEventArgs)

        Dim s = conn.Insert(New Customer() With {
                .Name = tb1.Text,
                .Age = txt1.Text
            })

        ' conn.Execute("INSERT INTO CUSTOMER...")

    End Sub
End Class

Public Class Customer
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set
            m_Id = Value
        End Set
    End Property
    Private m_Id As Integer
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set
            m_Name = Value
        End Set
    End Property
    Private m_Name As String
    Public Property Age() As String
        Get
            Return m_Age
        End Get
        Set
            m_Age = Value
        End Set
    End Property
    Private m_Age As String
End Class




'End Class


