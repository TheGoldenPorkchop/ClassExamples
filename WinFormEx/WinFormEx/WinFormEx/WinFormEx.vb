'Angel Nava
'Spring 2025
'RCET2265
'WindowsFormExample
'Link
Option Strict On
Option Explicit On


Public Class WinFormEx
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Me.Text = "Forms Are Cool Beans"
        Me.Text = StrReverse(Me.Text)
    End Sub
    'code goes here
End Class
