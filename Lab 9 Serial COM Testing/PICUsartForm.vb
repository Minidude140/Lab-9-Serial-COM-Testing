'Zachary Christensen
'RCET 5th Semester Lab
'10/22/24
'Testing USART With PIC16F883
'GitHub: 

Imports System.Threading
Public Class PICUsartForm
    Dim txData As Byte
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
        'Open COM Port
        OpenCOM()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SetServoPosButton_Click(sender As Object, e As EventArgs) Handles SetServoPosButton.Click
        'Create Variable For Data Storage
        Dim data(0) As Byte
        'Set Data as an ASCII $; 0x24
        data(0) = &H24
        'Send $ 
        SerialPort1.Write(data, 0, 1)
        'Wait For Response
        Thread.Sleep(100)
        'Read Acknowledge Byte
        SerialPort1.Read(data, 0, 1)
        'Confirm Acknowledge
        If data(0) = &H24 Then
            'Set Data as ComboBox Selection
            data(0) = CByte(ServoPosComboBox.SelectedItem)
            'Send Servo Position Data
            SerialPort1.Write(data, 0, 1)
        End If
    End Sub

End Class
