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

    Dim CommandsDataSet As New DataSet
    Dim CommandTable As New DataTable

    Private Sub FormLoaded(sender As Object, e As EventArgs) Handles Me.Load

        Dim FilePath As String = My.Application.Info.DirectoryPath + "\Commands.xml"

        If IO.File.Exists(FilePath) Then
            CommandsDataSet.ReadXml(FilePath)
        End If

        DataGridView1.DataSource = CommandsDataSet
        DataGridView1.DataMember = "Commands"
        DataGridView1.Columns("Command").Width = 400
        DataGridView1.Columns("Ticks").Width = 100
        DataGridView1.Columns("Enabled").Width = 100
    End Sub

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

    Private Sub BntSend_Click(sender As Object, e As EventArgs) Handles BntSend.Click

        Send(txtboxConsole.Text.ToString + vbCrLf)

    End Sub

    Private Sub txtboxConsole_TextChanged(sender As Object, ByVal e As KeyPressEventArgs) Handles txtboxConsole.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If Not txtboxConsole.Text.ToString = "" Then
                Send(txtboxConsole.Text.ToString + vbCrLf)
            End If
        End If

    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click

        Dim FilePath As String = My.Application.Info.DirectoryPath + "\Commands.xml"

        CommandsDataSet.WriteXml(FilePath)


    End Sub

    Private Sub bntLoad_Click(sender As Object, e As EventArgs) Handles bntLoad.Click

        Dim FilePath As String = My.Application.Info.DirectoryPath + "\Commands.xml"

        CommandsDataSet.Clear()
        CommandsDataSet.ReadXml(FilePath)

    End Sub

    Private Sub bntRun_Click(sender As Object, e As EventArgs) Handles bntRun.Click



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Table As New DataTable

        Table = CommandsDataSet.Tables("Commands")

        For Each Row As DataRow In Table.Rows

        Next

    End Sub
End Class
