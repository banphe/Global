Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Xml.Serialization

Class MainWindow

    Public Property ContainerBoxes As New List(Of MovableCanvas)
    Public Property Directories As New List(Of FileDirectory)



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Directories.Add(New FileDirectory("File 1"))
        Directories.Add(New FileDirectory("File 2"))

        Dim canv1 As New MovableCanvas
        canv1.Background = Brushes.Azure
        Canvas.SetTop(canv1, 50)
        Canvas.SetLeft(canv1, 50)

        Dim canv2 As New MovableCanvas
        canv2.Background = Brushes.Gray
        Canvas.SetTop(canv2, 150)
        Canvas.SetLeft(canv2, 150)

        ContainerBoxes.Add(canv1)
        ContainerBoxes.Add(canv2)
        DataContext = Me
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Canvas_DragOver(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent("Object") Then
            ' These Effects values are used in the drag source's
            ' GiveFeedback event handler to determine which cursor to display.
            If e.KeyStates = DragDropKeyStates.ControlKey Then
                e.Effects = DragDropEffects.Copy
            Else
                e.Effects = DragDropEffects.Move
            End If
        End If
    End Sub

    Private Sub Canvas_Drop(sender As Object, e As DragEventArgs)
        If e.Handled = False Then
            Dim d = e.Data
            Dim newTop As Double = e.GetPosition(sender).Y
            Dim newLeft As Double = e.GetPosition(sender).X

            Dim droppedCanvas As MovableCanvas = d.GetData("Object")
            droppedCanvas.SetValue(Canvas.TopProperty, newTop)
            droppedCanvas.SetValue(Canvas.LeftProperty, newLeft)
        End If
    End Sub




    Private Function CreateMovableCanvas(left As Double, top As Double) As MovableCanvas
        Dim canv As New MovableCanvas
        canv.Background = Brushes.BlueViolet
        Canvas.SetTop(canv, top)
        Canvas.SetLeft(canv, left)
        Return canv
    End Function


    Public Sub Button_Click(sender As Button, e As RoutedEventArgs)

        Select Case sender.Name
            Case "btnAddEntity"
                Container.Children.Add(CreateMovableCanvas(50, 50))
            Case "btnLoad"
                Container.Children.Clear()
                For Each ent In GetEntityListFromFile(cmbFiles.SelectedValue)
                    Container.Children.Add(CreateMovableCanvas(ent.Left, ent.Top))
                Next
            Case "btnSave"
                SaveEntitiesToFile(cmbFiles.SelectedValue)
        End Select
    End Sub

    Private Sub SaveEntitiesToFile(filename As String)
        Dim colect As New List(Of Entity)
        Dim serializer As New XmlSerializer(colect.GetType)
        Dim writer As New StreamWriter(filename)

        For Each c As MovableCanvas In Container.Children
            colect.Add(New Entity(c.GetLeft, c.GetTop))
        Next

        serializer.Serialize(writer, colect)
        writer.Close()
    End Sub

    Private Function GetEntityListFromFile(fileName As String) As List(Of Entity)
        Dim serializer As New XmlSerializer((New List(Of Entity)).GetType)
        Dim fileStream As New FileStream(fileName, FileMode.Open)
        Return serializer.Deserialize(fileStream)
    End Function


End Class

Public Class FileDirectory
    Public Property FileName As String
    Public ReadOnly Property Directory As String
        Get
            Return Environment.CurrentDirectory & "\" & FileName & ".xml"
        End Get
    End Property

    Public Sub New(ByVal fileName As String)
        Me.FileName = fileName

    End Sub
End Class
Public Class Entity
    Public Property Top As Double
    Public Property Left As Double

    Public Sub New(ByVal leftValue As Double, ByVal topValue As Double)
        Top = topValue
        Left = leftValue
    End Sub
    Public Sub New()

    End Sub


End Class


