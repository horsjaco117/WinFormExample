'Header stuff

Option Explicit On
Option Strict On

Public Class WinFormExampleForm
    Sub SetDefaults()
        FirstTextBox.Text = ""
        LastTextBox.Text = ""
        AgeBox.Text = ""
        UpperRadioButton.Checked = True
        FirstLastRadioButton.Checked = True
        ReverseCheckBox.Checked = False
        RandomCheckBox.Checked = False
        FirstTextBox.Focus()
    End Sub

    Sub SetCase()

        If UpperRadioButton.Checked = True Then
            FirstTextBox.Text = UCase(FirstTextBox.Text)
            LastTextBox.Text = UCase(LastTextBox.Text)
        ElseIf LowerRadioButton.Checked = True Then
            FirstTextBox.Text = LCase(FirstTextBox.Text)
            LastTextBox.Text = LCase(LastTextBox.Text)
            MsgBox($"Oh no! Nothing selected!")
        End If

    End Sub

    Sub setFormat()
        'Find out how to auto select these guys
        If FirstLastRadioButton.Checked = True Then
            Me.Text = $"{FirstTextBox.Text}{LastTextBox.Text}"
        ElseIf LastFirstRadioButton.Checked = True Then
        Else
            Me.Text = LastTextBox.Text & " " & FirstTextBox.Text
            MsgBox($"Oh no! No format selected!")
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

    Function UserInputIsValid() As Boolean
        Dim valid As Boolean = True
        Dim message As String

        If IsNumeric(AgeBox.Text) = False Then
            valid = False
            AgeBox.Focus()
            message &= "Please enter a valid age." & vbNewLine
        End If


        If LastTextBox.Text = "" Then
            valid = False
            LastTextBox.Focus()
            message &= "Last name is required." & vbNewLine
        End If

        If FirstTextBox.Text = "" Then
            valid = False
            FirstTextBox.Focus()
            message &= "First name is required." & vbNewLine
        End If

        If Not valid Then
            MsgBox(message,, "User Input Fail!!!")
        End If

        Return valid
    End Function

    'Event Handlers **************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        ' Me.Text = "Forms are Cool"
        If UserInputIsValid() Then
            SetCase()
            setFormat()
            ReverseString()
            RemoveWhiteSpace()
            SetDefaults()

        End If
    End Sub

    Private Sub WinFormExampleForm_Load(sender As Object, e As EventArgs)
        SetDefaults() 'This will default and select one of the buttons
    End Sub







    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles FirstTextBox.TextChanged

    'End Sub
End Class
