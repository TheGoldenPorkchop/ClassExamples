'Angel Nava
'Spring 2025
'RCET2265
'WindowsFormExample
'Link
Option Strict On
Option Explicit On


Public Class WinFormEx

    Sub SetDefaults()
        FirstTextBox.Text = ""
        MiddleNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        AgeTextBox.Text = ""
        UpperRadioButton.Checked = True
        FirstLastRadioButton.Checked = True
    End Sub

    Sub SetCase()
        If UpperRadioButton.Checked = True Then
            Me.Text = UCase(FirstTextBox.Text & " " & LastNameTextBox.Text)
        ElseIf LowerRadioButton.Checked = True Then
            Me.Text = LCase(FirstTextBox.Text & " " & LastNameTextBox.Text)
        Else
            MsgBox($"Oh Golly Gee Willikers...Nothing is selected")
        End If

    End Sub

    Sub SetFormat()
        If FirstLastRadioButton.Checked = True Then
            Me.Text = FirstTextBox.Text & " " & LastNameTextBox.Text
        ElseIf LastFirstRadioButton.Checked = True Then
            Me.Text = LastNameTextBox.Text & ", " & FirstTextBox.Text
        Else
            MsgBox($"Oh Golly Gee Willikers...No Name Order is selected")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Me.Text = "Forms Are Cool Beans"


        'Me.Text = StrReverse(Me.Text)
        SetCase()
        SetFormat()
        SetDefaults()
    End Sub

    Private Sub WinFormEx_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    'code goes here
End Class
