<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PICUsartForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ServoPosComboBox = New System.Windows.Forms.ComboBox()
        Me.ServoPosSelectLabel = New System.Windows.Forms.Label()
        Me.SetServoPosButton = New System.Windows.Forms.Button()
        Me.TestLabel = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(654, 379)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(134, 59)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ServoPosComboBox
        '
        Me.ServoPosComboBox.FormattingEnabled = True
        Me.ServoPosComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.ServoPosComboBox.Location = New System.Drawing.Point(520, 141)
        Me.ServoPosComboBox.Name = "ServoPosComboBox"
        Me.ServoPosComboBox.Size = New System.Drawing.Size(158, 24)
        Me.ServoPosComboBox.TabIndex = 1
        '
        'ServoPosSelectLabel
        '
        Me.ServoPosSelectLabel.AutoSize = True
        Me.ServoPosSelectLabel.Location = New System.Drawing.Point(527, 121)
        Me.ServoPosSelectLabel.Name = "ServoPosSelectLabel"
        Me.ServoPosSelectLabel.Size = New System.Drawing.Size(142, 17)
        Me.ServoPosSelectLabel.TabIndex = 2
        Me.ServoPosSelectLabel.Text = "Select Servo Position"
        '
        'SetServoPosButton
        '
        Me.SetServoPosButton.Location = New System.Drawing.Point(521, 186)
        Me.SetServoPosButton.Name = "SetServoPosButton"
        Me.SetServoPosButton.Size = New System.Drawing.Size(156, 54)
        Me.SetServoPosButton.TabIndex = 3
        Me.SetServoPosButton.Text = "Send Servo Data"
        Me.SetServoPosButton.UseVisualStyleBackColor = True
        '
        'TestLabel
        '
        Me.TestLabel.AutoSize = True
        Me.TestLabel.Location = New System.Drawing.Point(573, 279)
        Me.TestLabel.Name = "TestLabel"
        Me.TestLabel.Size = New System.Drawing.Size(51, 17)
        Me.TestLabel.TabIndex = 4
        Me.TestLabel.Text = "Label1"
        '
        'PICUsartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TestLabel)
        Me.Controls.Add(Me.SetServoPosButton)
        Me.Controls.Add(Me.ServoPosSelectLabel)
        Me.Controls.Add(Me.ServoPosComboBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "PICUsartForm"
        Me.Text = "USART PIC COM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents ServoPosComboBox As ComboBox
    Friend WithEvents ServoPosSelectLabel As Label
    Friend WithEvents SetServoPosButton As Button
    Friend WithEvents TestLabel As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
