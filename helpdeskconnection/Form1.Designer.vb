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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Networklbl = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblOS = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ping = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.subnet = New System.Windows.Forms.Label
        Me.ipaddress = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.defaultgateway = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.mac = New System.Windows.Forms.Label
        Me.flush = New System.Windows.Forms.Button
        Me.register = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Networklbl
        '
        Me.Networklbl.AutoSize = True
        Me.Networklbl.Location = New System.Drawing.Point(12, 72)
        Me.Networklbl.Name = "Networklbl"
        Me.Networklbl.Size = New System.Drawing.Size(132, 13)
        Me.Networklbl.TabIndex = 1
        Me.Networklbl.Text = "Is your Network available?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "networkavail"
        '
        'lblOS
        '
        Me.lblOS.AutoSize = True
        Me.lblOS.Location = New System.Drawing.Point(12, 42)
        Me.lblOS.Name = "lblOS"
        Me.lblOS.Size = New System.Drawing.Size(90, 13)
        Me.lblOS.TabIndex = 3
        Me.lblOS.Text = "Operating System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "os"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Your Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(372, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Are you on the Choctaw Nation Domain?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "choctawdomain"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Are you on the Choctaw Nation Network?"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "choctawnation network"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Your IP Address(es)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Computer Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(150, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "computername"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(137, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Release IP"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(15, 325)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Renew IP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Ping Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ping
        '
        Me.ping.AutoSize = True
        Me.ping.Location = New System.Drawing.Point(185, 280)
        Me.ping.Name = "ping"
        Me.ping.Size = New System.Drawing.Size(27, 13)
        Me.ping.TabIndex = 22
        Me.ping.Text = "ping"
        Me.ping.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 408)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(520, 22)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(111, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Your Subnet Mask"
        '
        'subnet
        '
        Me.subnet.AutoSize = True
        Me.subnet.Location = New System.Drawing.Point(372, 104)
        Me.subnet.Name = "subnet"
        Me.subnet.Size = New System.Drawing.Size(13, 13)
        Me.subnet.TabIndex = 25
        Me.subnet.Text = "c"
        '
        'ipaddress
        '
        Me.ipaddress.AutoSize = True
        Me.ipaddress.Location = New System.Drawing.Point(150, 104)
        Me.ipaddress.Name = "ipaddress"
        Me.ipaddress.Size = New System.Drawing.Size(15, 13)
        Me.ipaddress.TabIndex = 26
        Me.ipaddress.Text = "ip"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(255, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Your Default Gateway"
        '
        'defaultgateway
        '
        Me.defaultgateway.AutoSize = True
        Me.defaultgateway.Location = New System.Drawing.Point(372, 147)
        Me.defaultgateway.Name = "defaultgateway"
        Me.defaultgateway.Size = New System.Drawing.Size(60, 13)
        Me.defaultgateway.TabIndex = 28
        Me.defaultgateway.Text = "defaultgate"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Your MAC Address"
        '
        'mac
        '
        Me.mac.AutoSize = True
        Me.mac.Location = New System.Drawing.Point(150, 147)
        Me.mac.Name = "mac"
        Me.mac.Size = New System.Drawing.Size(27, 13)
        Me.mac.TabIndex = 31
        Me.mac.Text = "mac"
        '
        'flush
        '
        Me.flush.Location = New System.Drawing.Point(262, 325)
        Me.flush.Name = "flush"
        Me.flush.Size = New System.Drawing.Size(75, 23)
        Me.flush.TabIndex = 32
        Me.flush.Text = "Flush DNS"
        Me.flush.UseVisualStyleBackColor = True
        '
        'register
        '
        Me.register.Location = New System.Drawing.Point(375, 325)
        Me.register.Name = "register"
        Me.register.Size = New System.Drawing.Size(90, 23)
        Me.register.TabIndex = 33
        Me.register.Text = "Register DNS"
        Me.register.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(15, 371)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Trace Route"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 430)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.register)
        Me.Controls.Add(Me.flush)
        Me.Controls.Add(Me.mac)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.defaultgateway)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ipaddress)
        Me.Controls.Add(Me.subnet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ping)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Networklbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choctaw Nation Help Desk v 1.4"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Networklbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOS As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ping As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents subnet As System.Windows.Forms.Label
    Friend WithEvents ipaddress As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents defaultgateway As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents mac As System.Windows.Forms.Label
    Friend WithEvents flush As System.Windows.Forms.Button
    Friend WithEvents register As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
