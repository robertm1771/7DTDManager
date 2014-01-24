Imports System.Net.Sockets
Imports System.Threading
Imports System.Text

Public Class Form1

    Private Const BufferSize As Integer = 256
    ' Receive buffer.
    Private buffer(BufferSize) As Byte
    ' Received data string.
    Private sb As New StringBuilder

    Private response As String = String.Empty

    ' Create a TCP/IP socket.
    Dim WithEvents Client As New SocketsClient

    Private Sub bntConnect_Click(sender As Object, e As EventArgs) Handles bntConnect.Click

        Client.Connect(txtIP.Text, Int(txtPort.Text))

        TimeRead.Enabled = True
        TimeRead.Start()

    End Sub


    Private Sub Receive(ByVal Data As Byte(), ByVal TotalBytes As Integer) Handles Client.onDataArrival

        sb.Append(Encoding.ASCII.GetString(Data, 0, TotalBytes))
        response = sb.ToString
        sb.Clear()

    End Sub 'Receive

    Private Sub Send(ByVal data As String)

        Dim byteData As Byte() = Encoding.ASCII.GetBytes(data)

        Client.SendData(byteData)
        Console.WriteLine(data)
        RichTextBox1.AppendText(data + vbLf)

    End Sub 'Send

    Private Sub TimeRead_Tick(sender As Object, e As EventArgs) Handles TimeRead.Tick

        'Receive()
        If Not response.ToString = "" Then
            RichTextBox1.AppendText(response.ToString)
            Console.WriteLine(response.ToString)
            response = String.Empty
        End If

    End Sub

    Private Sub BntDisconnect_Click(sender As Object, e As EventArgs) Handles BntDisconnect.Click

        Client.Disconnect()
        TimeRead.Stop()

    End Sub

    Private Sub bntSetTime0_Click(sender As Object, e As EventArgs) Handles bntSetTime0.Click

        Send("st 0" + vbCrLf)

    End Sub

    Private Sub bntListplayers_Click(sender As Object, e As EventArgs) Handles bntListplayers.Click

        Send("lp" + vbCrLf)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Send(txtboxConsole.Text.ToString + vbCrLf)

    End Sub

    Private Sub txtboxConsole_TextChanged(sender As Object, ByVal e As KeyPressEventArgs) Handles txtboxConsole.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If Not txtboxConsole.Text.ToString = "" Then
                Send(txtboxConsole.Text.ToString + vbCrLf)
            End If
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

End Class
