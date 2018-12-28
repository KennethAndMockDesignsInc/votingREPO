<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registerFRM
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
        Me.FULLNAME = New MetroFramework.Controls.MetroTextBox()
        Me.PATH = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.metroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.savebtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.gender = New MetroFramework.Controls.MetroComboBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.tovote = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FULLNAME
        '
        '
        '
        '
        Me.FULLNAME.CustomButton.Image = Nothing
        Me.FULLNAME.CustomButton.Location = New System.Drawing.Point(262, 2)
        Me.FULLNAME.CustomButton.Name = ""
        Me.FULLNAME.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.FULLNAME.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FULLNAME.CustomButton.TabIndex = 1
        Me.FULLNAME.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FULLNAME.CustomButton.UseSelectable = True
        Me.FULLNAME.CustomButton.Visible = False
        Me.FULLNAME.DisplayIcon = True
        Me.FULLNAME.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.FULLNAME.Lines = New String(-1) {}
        Me.FULLNAME.Location = New System.Drawing.Point(120, 229)
        Me.FULLNAME.MaxLength = 32767
        Me.FULLNAME.Multiline = True
        Me.FULLNAME.Name = "FULLNAME"
        Me.FULLNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FULLNAME.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FULLNAME.SelectedText = ""
        Me.FULLNAME.SelectionLength = 0
        Me.FULLNAME.SelectionStart = 0
        Me.FULLNAME.ShowClearButton = True
        Me.FULLNAME.Size = New System.Drawing.Size(288, 28)
        Me.FULLNAME.Style = MetroFramework.MetroColorStyle.Red
        Me.FULLNAME.TabIndex = 487
        Me.FULLNAME.UseCustomForeColor = True
        Me.FULLNAME.UseSelectable = True
        Me.FULLNAME.WaterMark = "Full name"
        Me.FULLNAME.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FULLNAME.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'PATH
        '
        '
        '
        '
        Me.PATH.CustomButton.Image = Nothing
        Me.PATH.CustomButton.Location = New System.Drawing.Point(163, 2)
        Me.PATH.CustomButton.Name = ""
        Me.PATH.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.PATH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PATH.CustomButton.TabIndex = 1
        Me.PATH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PATH.CustomButton.UseSelectable = True
        Me.PATH.CustomButton.Visible = False
        Me.PATH.DisplayIcon = True
        Me.PATH.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.PATH.Lines = New String(-1) {}
        Me.PATH.Location = New System.Drawing.Point(120, 263)
        Me.PATH.MaxLength = 32767
        Me.PATH.Multiline = True
        Me.PATH.Name = "PATH"
        Me.PATH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PATH.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PATH.SelectedText = ""
        Me.PATH.SelectionLength = 0
        Me.PATH.SelectionStart = 0
        Me.PATH.ShowClearButton = True
        Me.PATH.Size = New System.Drawing.Size(189, 28)
        Me.PATH.Style = MetroFramework.MetroColorStyle.Red
        Me.PATH.TabIndex = 488
        Me.PATH.UseCustomForeColor = True
        Me.PATH.UseSelectable = True
        Me.PATH.WaterMark = "image path"
        Me.PATH.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PATH.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(16, 229)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(72, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 489
        Me.KryptonLabel1.Values.Text = "Full Name"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(16, 263)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(36, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 490
        Me.KryptonLabel2.Values.Text = "IMG"
        '
        'metroTextButton1
        '
        Me.metroTextButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.metroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.metroTextButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.metroTextButton1.Image = Nothing
        Me.metroTextButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.metroTextButton1.Location = New System.Drawing.Point(326, 263)
        Me.metroTextButton1.Name = "metroTextButton1"
        Me.metroTextButton1.Size = New System.Drawing.Size(82, 28)
        Me.metroTextButton1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.metroTextButton1.TabIndex = 491
        Me.metroTextButton1.Text = "BROWSE"
        Me.metroTextButton1.UseCustomBackColor = True
        Me.metroTextButton1.UseCustomForeColor = True
        Me.metroTextButton1.UseSelectable = True
        Me.metroTextButton1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox1.Location = New System.Drawing.Point(16, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 492
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.tovote)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.gender)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.FULLNAME)
        Me.Panel1.Controls.Add(Me.metroTextButton1)
        Me.Panel1.Controls.Add(Me.PATH)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 364)
        Me.Panel1.TabIndex = 493
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.savebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.savebtn.Image = Nothing
        Me.savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.savebtn.Location = New System.Drawing.Point(326, 433)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(82, 28)
        Me.savebtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.savebtn.TabIndex = 494
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseCustomBackColor = True
        Me.savebtn.UseCustomForeColor = True
        Me.savebtn.UseSelectable = True
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'gender
        '
        Me.gender.FormattingEnabled = True
        Me.gender.ItemHeight = 23
        Me.gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.gender.Location = New System.Drawing.Point(120, 297)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(121, 29)
        Me.gender.TabIndex = 493
        Me.gender.UseSelectable = True
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(16, 332)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(58, 22)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 494
        Me.KryptonLabel3.Values.Text = "To Vote"
        '
        'tovote
        '
        '
        '
        '
        Me.tovote.CustomButton.Image = Nothing
        Me.tovote.CustomButton.Location = New System.Drawing.Point(163, 2)
        Me.tovote.CustomButton.Name = ""
        Me.tovote.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.tovote.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tovote.CustomButton.TabIndex = 1
        Me.tovote.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tovote.CustomButton.UseSelectable = True
        Me.tovote.CustomButton.Visible = False
        Me.tovote.DisplayIcon = True
        Me.tovote.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tovote.Lines = New String(-1) {}
        Me.tovote.Location = New System.Drawing.Point(120, 332)
        Me.tovote.MaxLength = 32767
        Me.tovote.Multiline = True
        Me.tovote.Name = "tovote"
        Me.tovote.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tovote.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tovote.SelectedText = ""
        Me.tovote.SelectionLength = 0
        Me.tovote.SelectionStart = 0
        Me.tovote.ShowClearButton = True
        Me.tovote.Size = New System.Drawing.Size(189, 28)
        Me.tovote.Style = MetroFramework.MetroColorStyle.Red
        Me.tovote.TabIndex = 495
        Me.tovote.UseCustomForeColor = True
        Me.tovote.UseSelectable = True
        Me.tovote.WaterMark = "image path"
        Me.tovote.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tovote.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(16, 297)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(55, 22)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 496
        Me.KryptonLabel4.Values.Text = "Gender"
        '
        'registerFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 471)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "registerFRM"
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FULLNAME As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PATH As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents metroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents savebtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tovote As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents gender As MetroFramework.Controls.MetroComboBox
End Class
