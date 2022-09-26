Public Class MovableCanvas

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Input.MouseEventArgs)
        MyBase.OnMouseMove(e)
        If e.LeftButton = MouseButtonState.Pressed Then
            ' Package the data.
            Dim data As New DataObject
            Dim asss = Canvas.GetTop(Me)
            data.SetData("Top", Canvas.GetTop(Me))
            data.SetData("Left", Canvas.GetLeft(Me))
            data.SetData("Object", Me)

            ' Inititate the drag-and-drop operation.
            DragDrop.DoDragDrop(Me, data, DragDropEffects.Copy Or DragDropEffects.Move)

        End If
    End Sub

    Public Function GetLeft() As Double
        Return GetValue(Canvas.LeftProperty)
    End Function

    Public Function GetTop() As Double
        Return GetValue(Canvas.TopProperty)
    End Function
End Class
