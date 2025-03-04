'Header stuff

Option Explicit On
Option Strict On

Public Class WinFormExampleForm
    Sub SetDefaults()
        FirstTextBox.Text = ""
        LastTextBox.Text = ""
        AgeBox.Text = ""
        UpperRadioButton.Checked = True

    End Sub

    Sub SetCase()

        If UpperRadioButton.Checked = True Then
            Me.Text = UCase(FirstTextBox.Text & " " & LastTextBox.Text)
        ElseIf LowerRadioButton.Checked = True Then
            Me.Text = LCase(FirstTextBox.Text & " " & LastTextBox.Text)
        Else
            MsgBox($"Oh no! Nothing selected!")
        End If

    End Sub

    Sub setFormat()
        'Find out how to auto select these guys
        If FirstLastRadioButton.Checked = True Then
            Me.Text = FirstLastRadioButton.Text & " " & LastFirstRadioButton.Text
        ElseIf LastFirstRadioButton.Checked = True Then
            Me.Text = $"{LastFirstRadioButton.Text},{FirstLastRadioButton.Text}"
        Else
            MsgBox($"Oh no! No format selected!")
        End If
    End Sub

    'Event Handlers **************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        ' Me.Text = "Forms are Cool"
        'Me.Text = StrReverse(Me.Text)

        SetDefaults()
    End Sub

    Private Sub WinFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults() 'This will default and select one of the buttons
    End Sub







    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles FirstTextBox.TextChanged

    'End Sub
End Class
