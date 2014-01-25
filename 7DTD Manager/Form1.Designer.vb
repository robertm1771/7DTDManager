<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.bntConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BntDisconnect = New System.Windows.Forms.Button()
        Me.TimeRead = New System.Windows.Forms.Timer(Me.components)
        Me.bntSetTime0 = New System.Windows.Forms.Button()
        Me.bntListplayers = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BntSend = New System.Windows.Forms.Button()
        Me.txtboxConsole = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.bntRun = New System.Windows.Forms.Button()
        Me.bntLoad = New System.Windows.Forms.Button()
        Me.bntSave = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BntStop = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 7)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(791, 502)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'bntConnect
        '
        Me.bntConnect.Location = New System.Drawing.Point(49, 64)
        Me.bntConnect.Name = "bntConnect"
        Me.bntConnect.Size = New System.Drawing.Size(75, 23)
        Me.bntConnect.TabIndex = 1
        Me.bntConnect.Text = "Connect"
        Me.bntConnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IP"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(49, 12)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(110, 20)
        Me.txtIP.TabIndex = 3
        Me.txtIP.Text = "76.72.160.245"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(49, 38)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(49, 20)
        Me.txtPort.TabIndex = 5
        Me.txtPort.Text = "35600"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Port"
        '
        'BntDisconnect
        '
        Me.BntDisconnect.Location = New System.Drawing.Point(49, 93)
        Me.BntDisconnect.Name = "BntDisconnect"
        Me.BntDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.BntDisconnect.TabIndex = 6
        Me.BntDisconnect.Text = "Disconnect"
        Me.BntDisconnect.UseVisualStyleBackColor = True
        '
        'TimeRead
        '
        '
        'bntSetTime0
        '
        Me.bntSetTime0.Location = New System.Drawing.Point(49, 194)
        Me.bntSetTime0.Name = "bntSetTime0"
        Me.bntSetTime0.Size = New System.Drawing.Size(75, 23)
        Me.bntSetTime0.TabIndex = 7
        Me.bntSetTime0.Text = "Set Time 0"
        Me.bntSetTime0.UseVisualStyleBackColor = True
        '
        'bntListplayers
        '
        Me.bntListplayers.Location = New System.Drawing.Point(49, 223)
        Me.bntListplayers.Name = "bntListplayers"
        Me.bntListplayers.Size = New System.Drawing.Size(75, 23)
        Me.bntListplayers.TabIndex = 8
        Me.bntListplayers.Text = "List Players"
        Me.bntListplayers.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(174, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(808, 569)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BntSend)
        Me.TabPage1.Controls.Add(Me.txtboxConsole)
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(800, 543)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Console"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BntSend
        '
        Me.BntSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BntSend.Location = New System.Drawing.Point(734, 513)
        Me.BntSend.Name = "BntSend"
        Me.BntSend.Size = New System.Drawing.Size(59, 23)
        Me.BntSend.TabIndex = 10
        Me.BntSend.Text = "Send"
        Me.BntSend.UseVisualStyleBackColor = True
        '
        'txtboxConsole
        '
        Me.txtboxConsole.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxConsole.Location = New System.Drawing.Point(6, 515)
        Me.txtboxConsole.Name = "txtboxConsole"
        Me.txtboxConsole.Size = New System.Drawing.Size(723, 20)
        Me.txtboxConsole.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BntStop)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.bntRun)
        Me.TabPage2.Controls.Add(Me.bntLoad)
        Me.TabPage2.Controls.Add(Me.bntSave)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(800, 543)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Message"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'bntRun
        '
        Me.bntRun.Location = New System.Drawing.Point(6, 514)
        Me.bntRun.Name = "bntRun"
        Me.bntRun.Size = New System.Drawing.Size(75, 23)
        Me.bntRun.TabIndex = 3
        Me.bntRun.Text = "Run"
        Me.bntRun.UseVisualStyleBackColor = True
        '
        'bntLoad
        '
        Me.bntLoad.Location = New System.Drawing.Point(719, 514)
        Me.bntLoad.Name = "bntLoad"
        Me.bntLoad.Size = New System.Drawing.Size(75, 23)
        Me.bntLoad.TabIndex = 2
        Me.bntLoad.Text = "Load"
        Me.bntLoad.UseVisualStyleBackColor = True
        '
        'bntSave
        '
        Me.bntSave.Location = New System.Drawing.Point(638, 514)
        Me.bntSave.Name = "bntSave"
        Me.bntSave.Size = New System.Drawing.Size(75, 23)
        Me.bntSave.TabIndex = 1
        Me.bntSave.Text = "Save"
        Me.bntSave.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(797, 508)
        Me.DataGridView1.TabIndex = 4
        '
        'BntStop
        '
        Me.BntStop.Location = New System.Drawing.Point(87, 514)
        Me.BntStop.Name = "BntStop"
        Me.BntStop.Size = New System.Drawing.Size(75, 23)
        Me.BntStop.TabIndex = 5
        Me.BntStop.Text = "Stop"
        Me.BntStop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 574)
        Me.Controls.Add(Me.bntListplayers)
        Me.Controls.Add(Me.bntSetTime0)
        Me.Controls.Add(Me.BntDisconnect)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bntConnect)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "7 Days to Die Server Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents bntConnect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BntDisconnect As System.Windows.Forms.Button
    Friend WithEvents TimeRead As System.Windows.Forms.Timer
    Friend WithEvents bntSetTime0 As System.Windows.Forms.Button
    Friend WithEvents bntListplayers As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BntSend As System.Windows.Forms.Button
    Friend WithEvents txtboxConsole As System.Windows.Forms.TextBox
    Friend WithEvents bntRun As System.Windows.Forms.Button
    Friend WithEvents bntLoad As System.Windows.Forms.Button
    Friend WithEvents bntSave As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BntStop As System.Windows.Forms.Button

End Class
