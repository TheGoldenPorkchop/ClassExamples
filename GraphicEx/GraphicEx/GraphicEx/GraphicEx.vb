'Angel Nava
'Spring 2025
'RCET2265
'Graphics Example
'link
Option Strict On
Option Explicit On


Public Class GraphicEx
    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)
        g.DrawLine(pen, 50, 50, 100, 100)

        g.Dispose()
    End Sub



    'Event Handlers
    Private Sub GraphicEx_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
    End Sub

    Private Sub GraphicEx_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"({e.X},{e.Y})"
    End Sub
End Class
