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
        ReverseCheckBox.Checked = False
        WhiteSpaceCheckBox.Checked = False
        RandomCheckBox.Checked = False
        FirstTextBox.Focus()

    End Sub

    Sub SetCase()
        If UpperRadioButton.Checked = True Then
            FirstTextBox.Text = UCase(FirstTextBox.Text)
            LastNameTextBox.Text = UCase(LastNameTextBox.Text)
        ElseIf LowerRadioButton.Checked = True Then
            FirstTextBox.Text = LCase(FirstTextBox.Text)
            LastNameTextBox.Text = LCase(LastNameTextBox.Text)
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

    Sub ReverseString()
        If ReverseCheckBox.Checked Then
            Me.Text = StrReverse(Me.Text)
        End If
    End Sub

    Sub RemoveWhiteSpace()
        If WhiteSpaceCheckBox.Checked Then
            Me.Text = Replace(Me.Text, " ", "")
        End If
    End Sub

    Sub RandomString()
        'code goes here eventually
    End Sub

    Function UserInputIsValid() As Boolean
        Dim valid As Boolean
        Dim message As String
        'Dim age As Integer
        'age = CInt(AgeTextBox.Text)

        If IsNumeric(AgeTextBox.Text) = False Then
            valid = False
            message &= "The Age Input is not a number" & vbNewLine
        End If
        If AgeTextBox.Text = "" Then
            valid = False
            message &= "Age is required" & vbNewLine
            AgeTextBox.Focus()
        End If
        If LastNameTextBox.Text = "" Then
            valid = False
            message &= "Last Name is required" & vbNewLine
            LastNameTextBox.Focus()
        End If
        If FirstTextBox.Text = "" Then
            valid = False
            message &= "First Name is required" & vbNewLine
            FirstTextBox.Focus()
        End If

        'If age < 18 Then
        'valid = False
        'MsgBox($"You aren't old enough")
        'FirstTextBox.Focus()
        'End If


        If Not valid Then
            MsgBox(message, MsgBoxStyle.Critical, "Empty Fields")
        End If
        Return valid
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Me.Text = "Forms Are Cool Beans"

        If UserInputIsValid() Then
            SetCase()
            SetFormat()
            ReverseString()
            RemoveWhiteSpace()
            SetDefaults()
        End If
    End Sub

    Private Sub WinFormEx_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub



    'code goes here
End Class
