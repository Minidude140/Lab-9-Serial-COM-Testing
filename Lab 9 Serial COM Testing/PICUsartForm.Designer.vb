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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialSendTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SerialSendOnRadioButton = New System.Windows.Forms.RadioButton()
        Me.SerialSendOffRadioButton = New System.Windows.Forms.RadioButton()
        Me.ADCHLabel = New System.Windows.Forms.Label()
        Me.ADCLLabel = New System.Windows.Forms.Label()
        Me.ADCHResultLabel = New System.Windows.Forms.Label()
        Me.ADCLResultLabel = New System.Windows.Forms.Label()
        Me.TempResultLabel = New System.Windows.Forms.Label()
        Me.TempFLabel = New System.Windows.Forms.Label()
        Me.TempCLabel = New System.Windows.Forms.Label()
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
        Me.ServoPosComboBox.Location = New System.Drawing.Point(46, 54)
        Me.ServoPosComboBox.Name = "ServoPosComboBox"
        Me.ServoPosComboBox.Size = New System.Drawing.Size(158, 24)
        Me.ServoPosComboBox.TabIndex = 1
        '
        'ServoPosSelectLabel
        '
        Me.ServoPosSelectLabel.AutoSize = True
        Me.ServoPosSelectLabel.Location = New System.Drawing.Point(53, 34)
        Me.ServoPosSelectLabel.Name = "ServoPosSelectLabel"
        Me.ServoPosSelectLabel.Size = New System.Drawing.Size(142, 17)
        Me.ServoPosSelectLabel.TabIndex = 2
        Me.ServoPosSelectLabel.Text = "Select Servo Position"
        '
        'SerialPort1
        '
        Me.SerialPort1.ReadTimeout = 500
        Me.SerialPort1.WriteTimeout = 500
        '
        'SerialSendTimer
        '
        Me.SerialSendTimer.Interval = 500
        '
        'SerialSendOnRadioButton
        '
        Me.SerialSendOnRadioButton.AutoSize = True
        Me.SerialSendOnRadioButton.Location = New System.Drawing.Point(56, 135)
        Me.SerialSendOnRadioButton.Name = "SerialSendOnRadioButton"
        Me.SerialSendOnRadioButton.Size = New System.Drawing.Size(125, 21)
        Me.SerialSendOnRadioButton.TabIndex = 5
        Me.SerialSendOnRadioButton.TabStop = True
        Me.SerialSendOnRadioButton.Text = "Serial Send On"
        Me.SerialSendOnRadioButton.UseVisualStyleBackColor = True
        '
        'SerialSendOffRadioButton
        '
        Me.SerialSendOffRadioButton.AutoSize = True
        Me.SerialSendOffRadioButton.Location = New System.Drawing.Point(56, 162)
        Me.SerialSendOffRadioButton.Name = "SerialSendOffRadioButton"
        Me.SerialSendOffRadioButton.Size = New System.Drawing.Size(125, 21)
        Me.SerialSendOffRadioButton.TabIndex = 6
        Me.SerialSendOffRadioButton.TabStop = True
        Me.SerialSendOffRadioButton.Text = "Serial Send Off"
        Me.SerialSendOffRadioButton.UseVisualStyleBackColor = True
        '
        'ADCHLabel
        '
        Me.ADCHLabel.AutoSize = True
        Me.ADCHLabel.Location = New System.Drawing.Point(291, 76)
        Me.ADCHLabel.Name = "ADCHLabel"
        Me.ADCHLabel.Size = New System.Drawing.Size(16, 17)
        Me.ADCHLabel.TabIndex = 7
        Me.ADCHLabel.Text = "0"
        '
        'ADCLLabel
        '
        Me.ADCLLabel.AutoSize = True
        Me.ADCLLabel.Location = New System.Drawing.Point(291, 139)
        Me.ADCLLabel.Name = "ADCLLabel"
        Me.ADCLLabel.Size = New System.Drawing.Size(16, 17)
        Me.ADCLLabel.TabIndex = 8
        Me.ADCLLabel.Text = "0"
        '
        'ADCHResultLabel
        '
        Me.ADCHResultLabel.AutoSize = True
        Me.ADCHResultLabel.Location = New System.Drawing.Point(267, 48)
        Me.ADCHResultLabel.Name = "ADCHResultLabel"
        Me.ADCHResultLabel.Size = New System.Drawing.Size(101, 17)
        Me.ADCHResultLabel.TabIndex = 9
        Me.ADCHResultLabel.Text = "ADC High Byte"
        '
        'ADCLResultLabel
        '
        Me.ADCLResultLabel.AutoSize = True
        Me.ADCLResultLabel.Location = New System.Drawing.Point(271, 111)
        Me.ADCLResultLabel.Name = "ADCLResultLabel"
        Me.ADCLResultLabel.Size = New System.Drawing.Size(97, 17)
        Me.ADCLResultLabel.TabIndex = 10
        Me.ADCLResultLabel.Text = "ADC Low Byte"
        '
        'TempResultLabel
        '
        Me.TempResultLabel.AutoSize = True
        Me.TempResultLabel.Location = New System.Drawing.Point(458, 48)
        Me.TempResultLabel.Name = "TempResultLabel"
        Me.TempResultLabel.Size = New System.Drawing.Size(118, 17)
        Me.TempResultLabel.TabIndex = 11
        Me.TempResultLabel.Text = "Calculated Temp."
        '
        'TempFLabel
        '
        Me.TempFLabel.AutoSize = True
        Me.TempFLabel.Location = New System.Drawing.Point(508, 76)
        Me.TempFLabel.Name = "TempFLabel"
        Me.TempFLabel.Size = New System.Drawing.Size(30, 17)
        Me.TempFLabel.TabIndex = 12
        Me.TempFLabel.Text = "0°F"
        '
        'TempCLabel
        '
        Me.TempCLabel.AutoSize = True
        Me.TempCLabel.Location = New System.Drawing.Point(508, 111)
        Me.TempCLabel.Name = "TempCLabel"
        Me.TempCLabel.Size = New System.Drawing.Size(31, 17)
        Me.TempCLabel.TabIndex = 13
        Me.TempCLabel.Text = "0°C"
        '
        'PICUsartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TempCLabel)
        Me.Controls.Add(Me.TempFLabel)
        Me.Controls.Add(Me.TempResultLabel)
        Me.Controls.Add(Me.ADCLResultLabel)
        Me.Controls.Add(Me.ADCHResultLabel)
        Me.Controls.Add(Me.ADCLLabel)
        Me.Controls.Add(Me.ADCHLabel)
        Me.Controls.Add(Me.SerialSendOffRadioButton)
        Me.Controls.Add(Me.SerialSendOnRadioButton)
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
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents SerialSendTimer As Timer
    Friend WithEvents SerialSendOnRadioButton As RadioButton
    Friend WithEvents SerialSendOffRadioButton As RadioButton
    Friend WithEvents ADCHLabel As Label
    Friend WithEvents ADCLLabel As Label
    Friend WithEvents ADCHResultLabel As Label
    Friend WithEvents ADCLResultLabel As Label
    Friend WithEvents TempResultLabel As Label
    Friend WithEvents TempFLabel As Label
    Friend WithEvents TempCLabel As Label
End Class
