'Header stuff

Option Explicit On
Option Strict On

Public Class WinFormExampleForm
    Sub Clear()
        FirstTextBox.Text = ""
        LastTextBox.Text = ""
        AgeBox.Text = ""

    End Sub


    'Event Handlers **************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ' Me.Text = "Forms are Cool"
        'Me.Text = StrReverse(Me.Text)
        Me.Text = FirstTextBox.Text & " " & LastTextBox.Text
        Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles FirstTextBox.TextChanged

    End Sub
End Class
