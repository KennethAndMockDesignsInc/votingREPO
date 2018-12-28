<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Me.myconnection = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.disconnect = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.myport = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.connect = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.myconnection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.myconnection.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.myconnection.Panel.SuspendLayout()
        Me.myconnection.SuspendLayout()
        Me.SuspendLayout()
        '
        'myconnection
        '
        Me.myconnection.Location = New System.Drawing.Point(10, 45)
        Me.myconnection.Name = "myconnection"
        '
        'myconnection.Panel
        '
        Me.myconnection.Panel.Controls.Add(Me.newbtn)
        Me.myconnection.Panel.Controls.Add(Me.ProgressBar1)
        Me.myconnection.Panel.Controls.Add(Me.disconnect)
        Me.myconnection.Panel.Controls.Add(Me.myport)
        Me.myconnection.Panel.Controls.Add(Me.ComboBox3)
        Me.myconnection.Panel.Controls.Add(Me.ComboBox2)
        Me.myconnection.Panel.Controls.Add(Me.connect)
        Me.myconnection.Panel.Controls.Add(Me.KryptonLabel4)
        Me.myconnection.Panel.Controls.Add(Me.KryptonLabel3)
        Me.myconnection.Panel.Controls.Add(Me.ComboBox1)
        Me.myconnection.Size = New System.Drawing.Size(401, 324)
        Me.myconnection.TabIndex = 60
        Me.myconnection.ValuesPrimary.Heading = "Connection"
        Me.myconnection.ValuesSecondary.Heading = ""
        '
        'disconnect
        '
        Me.disconnect.Enabled = False
        Me.disconnect.Location = New System.Drawing.Point(125, 182)
        Me.disconnect.Name = "disconnect"
        Me.disconnect.Size = New System.Drawing.Size(90, 25)
        Me.disconnect.TabIndex = 59
        Me.disconnect.Values.Text = "disconnect"
        '
        'myport
        '
        Me.myport.Location = New System.Drawing.Point(22, 88)
        Me.myport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.myport.Name = "myport"
        Me.myport.Size = New System.Drawing.Size(38, 21)
        Me.myport.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myport.TabIndex = 35
        Me.myport.Values.Text = "port"
        '
        'connect
        '
        Me.connect.Location = New System.Drawing.Point(29, 182)
        Me.connect.Name = "connect"
        Me.connect.Size = New System.Drawing.Size(90, 25)
        Me.connect.TabIndex = 58
        Me.connect.Values.Text = "connect"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(94, 152)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(38, 21)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 37
        Me.KryptonLabel4.Values.Text = "port"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(22, 152)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(64, 21)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 36
        Me.KryptonLabel3.Values.Text = "Status :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(22, 121)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(358, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'SerialPort1
        '
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(22, 47)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(358, 21)
        Me.ComboBox2.TabIndex = 63
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(22, 20)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(358, 21)
        Me.ComboBox3.TabIndex = 64
        '
        'newbtn
        '
        Me.newbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbtn.Image = Nothing
        Me.newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newbtn.Location = New System.Drawing.Point(261, 251)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(119, 24)
        Me.newbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.newbtn.TabIndex = 566
        Me.newbtn.Text = "count"
        Me.newbtn.UseCustomForeColor = True
        Me.newbtn.UseSelectable = True
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(22, 222)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(358, 23)
        Me.ProgressBar1.TabIndex = 567
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 379)
        Me.Controls.Add(Me.myconnection)
        Me.Name = "Form1"
        CType(Me.myconnection.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.myconnection.Panel.ResumeLayout(False)
        Me.myconnection.Panel.PerformLayout()
        CType(Me.myconnection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.myconnection.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents myconnection As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents disconnect As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents myport As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents connect As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents newbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
