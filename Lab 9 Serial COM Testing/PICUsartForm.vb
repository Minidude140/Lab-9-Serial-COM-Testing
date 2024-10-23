'Zachary Christensen
'RCET 5th Semester Lab
'10/22/24
'Testing USART With PIC16F883
'GitHub: 

Imports System.Threading
Public Class PICUsartForm
    Dim adcHigh As Byte
    Dim adcLow As Byte
    '*****************Custom Methods******************************
    ''' <summary>
    ''' Sets the Default Combo Box Selection
    ''' </summary>
    Sub SetDefaults()
        ServoPosComboBox.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Sets Port Name, Baud, and Opens Port for Communication
    ''' </summary>
    Sub OpenCOM()
        'Set up port name and baud rate
        SerialPort1.PortName = "COM8"
        SerialPort1.BaudRate = 9600
        'open serial port for data transfer
        SerialPort1.Open()
    End Sub

    Sub SendData(txData As Byte)
        Dim data() As Byte
    End Sub


    '****************Event Handlers*************************
    Private Sub PICUsartForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
        SerialSendOffRadioButton.Checked = True
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SerialSendTimer_Tick(sender As Object, e As EventArgs) Handles SerialSendTimer.Tick
        'Create Variable For Data Storage
        Dim data(2) As Byte
        'Set Data as an ASCII $; 0x24
        data(0) = &H24
        'Send $ 
        SerialPort1.Write(data, 0, 1)
        'Wait For Response
        Thread.Sleep(1)
        'Read Acknowledge Byte
        SerialPort1.Read(data, 0, 2)
        'Confirm Acknowledge
        If data(0) = &H24 Then
            'Save ADC Data
            adcHigh = data(1)
            adcLow = data(2)
            'Set Data as ComboBox Selection
            data(0) = CByte(ServoPosComboBox.SelectedItem)
            'Send Servo Position Data
            SerialPort1.Write(data, 0, 1)
        End If

    End Sub

    Private Sub SerialSendOnRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SerialSendOnRadioButton.CheckedChanged
        If SerialSendOnRadioButton.Checked = True Then
            OpenCOM()
            SerialSendTimer.Enabled = True
        End If
    End Sub

    Private Sub SerialSendOffRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SerialSendOffRadioButton.CheckedChanged
        If SerialSendOffRadioButton.Checked = True Then
            SerialPort1.Close()
            SerialSendTimer.Enabled = False
        End If
    End Sub
End Class
