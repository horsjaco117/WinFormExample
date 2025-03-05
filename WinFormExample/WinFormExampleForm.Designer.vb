<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WinFormExampleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.FirstTextBox = New System.Windows.Forms.TextBox()
        Me.LastTextBox = New System.Windows.Forms.TextBox()
        Me.LastLabel = New System.Windows.Forms.Label()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.UpperRadioButton = New System.Windows.Forms.RadioButton()
        Me.LowerRadioButton = New System.Windows.Forms.RadioButton()
        Me.FirstLastRadioButton = New System.Windows.Forms.RadioButton()
        Me.LastFirstRadioButton = New System.Windows.Forms.RadioButton()
        Me.CaseGroupBox = New System.Windows.Forms.GroupBox()
        Me.FormatGroupBox = New System.Windows.Forms.GroupBox()
        Me.ReverseCheckBox = New System.Windows.Forms.CheckBox()
        Me.WhiteSpaceCheckBox = New System.Windows.Forms.CheckBox()
        Me.RandomCheckBox = New System.Windows.Forms.CheckBox()
        Me.CaseGroupBox.SuspendLayout()
        Me.FormatGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(650, 518)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(172, 151)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(472, 518)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(172, 151)
        Me.UpdateButton.TabIndex = 9
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(12, 75)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(86, 20)
        Me.FirstNameLabel.TabIndex = 2
        Me.FirstNameLabel.Text = "First Name"
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(107, 69)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(329, 26)
        Me.FirstTextBox.TabIndex = 0
        '
        'LastTextBox
        '
        Me.LastTextBox.Location = New System.Drawing.Point(107, 119)
        Me.LastTextBox.Name = "LastTextBox"
        Me.LastTextBox.Size = New System.Drawing.Size(329, 26)
        Me.LastTextBox.TabIndex = 1
        '
        'LastLabel
        '
        Me.LastLabel.AutoSize = True
        Me.LastLabel.Location = New System.Drawing.Point(12, 125)
        Me.LastLabel.Name = "LastLabel"
        Me.LastLabel.Size = New System.Drawing.Size(86, 20)
        Me.LastLabel.TabIndex = 4
        Me.LastLabel.Text = "Last Name"
        '
        'AgeBox
        '
        Me.AgeBox.Location = New System.Drawing.Point(107, 171)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(74, 26)
        Me.AgeBox.TabIndex = 2
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(60, 177)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 6
        Me.AgeLabel.Text = "Age"
        '
        'UpperRadioButton
        '
        Me.UpperRadioButton.AutoSize = True
        Me.UpperRadioButton.Location = New System.Drawing.Point(43, 38)
        Me.UpperRadioButton.Name = "UpperRadioButton"
        Me.UpperRadioButton.Size = New System.Drawing.Size(119, 24)
        Me.UpperRadioButton.TabIndex = 11
        Me.UpperRadioButton.TabStop = True
        Me.UpperRadioButton.Text = "Upper Case"
        Me.UpperRadioButton.UseVisualStyleBackColor = True
        '
        'LowerRadioButton
        '
        Me.LowerRadioButton.AutoSize = True
        Me.LowerRadioButton.Location = New System.Drawing.Point(43, 79)
        Me.LowerRadioButton.Name = "LowerRadioButton"
        Me.LowerRadioButton.Size = New System.Drawing.Size(118, 24)
        Me.LowerRadioButton.TabIndex = 12
        Me.LowerRadioButton.TabStop = True
        Me.LowerRadioButton.Text = "Lower Case"
        Me.LowerRadioButton.UseVisualStyleBackColor = True
        '
        'FirstLastRadioButton
        '
        Me.FirstLastRadioButton.AutoSize = True
        Me.FirstLastRadioButton.Location = New System.Drawing.Point(43, 37)
        Me.FirstLastRadioButton.Name = "FirstLastRadioButton"
        Me.FirstLastRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.FirstLastRadioButton.TabIndex = 13
        Me.FirstLastRadioButton.TabStop = True
        Me.FirstLastRadioButton.Text = "First, Last"
        Me.FirstLastRadioButton.UseVisualStyleBackColor = True
        '
        'LastFirstRadioButton
        '
        Me.LastFirstRadioButton.AutoSize = True
        Me.LastFirstRadioButton.Location = New System.Drawing.Point(43, 76)
        Me.LastFirstRadioButton.Name = "LastFirstRadioButton"
        Me.LastFirstRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.LastFirstRadioButton.TabIndex = 14
        Me.LastFirstRadioButton.TabStop = True
        Me.LastFirstRadioButton.Text = "Last, First"
        Me.LastFirstRadioButton.UseVisualStyleBackColor = True
        '
        'CaseGroupBox
        '
        Me.CaseGroupBox.Controls.Add(Me.UpperRadioButton)
        Me.CaseGroupBox.Controls.Add(Me.LowerRadioButton)
        Me.CaseGroupBox.Location = New System.Drawing.Point(64, 219)
        Me.CaseGroupBox.Name = "CaseGroupBox"
        Me.CaseGroupBox.Size = New System.Drawing.Size(252, 154)
        Me.CaseGroupBox.TabIndex = 15
        Me.CaseGroupBox.TabStop = False
        Me.CaseGroupBox.Text = "Case"
        '
        'FormatGroupBox
        '
        Me.FormatGroupBox.Controls.Add(Me.FirstLastRadioButton)
        Me.FormatGroupBox.Controls.Add(Me.LastFirstRadioButton)
        Me.FormatGroupBox.Location = New System.Drawing.Point(339, 219)
        Me.FormatGroupBox.Name = "FormatGroupBox"
        Me.FormatGroupBox.Size = New System.Drawing.Size(245, 154)
        Me.FormatGroupBox.TabIndex = 16
        Me.FormatGroupBox.TabStop = False
        Me.FormatGroupBox.Text = "Format"
        '
        'ReverseCheckBox
        '
        Me.ReverseCheckBox.AutoSize = True
        Me.ReverseCheckBox.Location = New System.Drawing.Point(107, 405)
        Me.ReverseCheckBox.Name = "ReverseCheckBox"
        Me.ReverseCheckBox.Size = New System.Drawing.Size(94, 24)
        Me.ReverseCheckBox.TabIndex = 17
        Me.ReverseCheckBox.Text = "Reverse"
        Me.ReverseCheckBox.UseVisualStyleBackColor = True
        '
        'WhiteSpaceCheckBox
        '
        Me.WhiteSpaceCheckBox.AutoSize = True
        Me.WhiteSpaceCheckBox.Location = New System.Drawing.Point(107, 436)
        Me.WhiteSpaceCheckBox.Name = "WhiteSpaceCheckBox"
        Me.WhiteSpaceCheckBox.Size = New System.Drawing.Size(122, 24)
        Me.WhiteSpaceCheckBox.TabIndex = 18
        Me.WhiteSpaceCheckBox.Text = "WhiteSpace"
        Me.WhiteSpaceCheckBox.UseVisualStyleBackColor = True
        '
        'RandomCheckBox
        '
        Me.RandomCheckBox.AutoSize = True
        Me.RandomCheckBox.Location = New System.Drawing.Point(107, 467)
        Me.RandomCheckBox.Name = "RandomCheckBox"
        Me.RandomCheckBox.Size = New System.Drawing.Size(96, 24)
        Me.RandomCheckBox.TabIndex = 19
        Me.RandomCheckBox.Text = "Random"
        Me.RandomCheckBox.UseVisualStyleBackColor = True
        '
        'WinFormExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 681)
        Me.Controls.Add(Me.RandomCheckBox)
        Me.Controls.Add(Me.WhiteSpaceCheckBox)
        Me.Controls.Add(Me.ReverseCheckBox)
        Me.Controls.Add(Me.FormatGroupBox)
        Me.Controls.Add(Me.CaseGroupBox)
        Me.Controls.Add(Me.AgeBox)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.LastTextBox)
        Me.Controls.Add(Me.LastLabel)
        Me.Controls.Add(Me.FirstTextBox)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "WinFormExampleForm"
        Me.Text = "Windows Form Example"
        Me.CaseGroupBox.ResumeLayout(False)
        Me.CaseGroupBox.PerformLayout()
        Me.FormatGroupBox.ResumeLayout(False)
        Me.FormatGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents FirstTextBox As TextBox
    Friend WithEvents LastTextBox As TextBox
    Friend WithEvents LastLabel As Label
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents UpperRadioButton As RadioButton
    Friend WithEvents LowerRadioButton As RadioButton
    Friend WithEvents FirstLastRadioButton As RadioButton
    Friend WithEvents LastFirstRadioButton As RadioButton
    Friend WithEvents CaseGroupBox As GroupBox
    Friend WithEvents FormatGroupBox As GroupBox
    Friend WithEvents ReverseCheckBox As CheckBox
    Friend WithEvents WhiteSpaceCheckBox As CheckBox
    Friend WithEvents RandomCheckBox As CheckBox
End Class
