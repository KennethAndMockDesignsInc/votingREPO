<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RESULTFRM
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.imagecol = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.refreshbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.rownum = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.mcount = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.fshow = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.frownum = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MetroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MetroToggle2 = New MetroFramework.Controls.MetroToggle()
        Me.MetroToggle1 = New MetroFramework.Controls.MetroToggle()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.MGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MGRID
        '
        Me.MGRID.AllowUserToAddRows = False
        Me.MGRID.AllowUserToDeleteRows = False
        Me.MGRID.AllowUserToResizeRows = False
        Me.MGRID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MGRID.ColumnHeadersHeight = 32
        Me.MGRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imagecol})
        Me.MGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MGRID.Location = New System.Drawing.Point(162, 33)
        Me.MGRID.MultiSelect = False
        Me.MGRID.Name = "MGRID"
        Me.MGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.MGRID.RowHeadersVisible = False
        Me.MGRID.RowHeadersWidth = 30
        Me.MGRID.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.MGRID.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MGRID.RowTemplate.Height = 150
        Me.MGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MGRID.Size = New System.Drawing.Size(603, 475)
        Me.MGRID.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.MGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.MGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.MGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.MGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.MGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.MGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.MGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.MGRID.TabIndex = 558
        '
        'imagecol
        '
        Me.imagecol.HeaderText = "IMAGE"
        Me.imagecol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.imagecol.Name = "imagecol"
        Me.imagecol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.imagecol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FGRID
        '
        Me.FGRID.AllowUserToAddRows = False
        Me.FGRID.AllowUserToDeleteRows = False
        Me.FGRID.AllowUserToResizeRows = False
        Me.FGRID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FGRID.ColumnHeadersHeight = 32
        Me.FGRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1})
        Me.FGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.FGRID.Location = New System.Drawing.Point(765, 33)
        Me.FGRID.MultiSelect = False
        Me.FGRID.Name = "FGRID"
        Me.FGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.FGRID.RowHeadersVisible = False
        Me.FGRID.RowHeadersWidth = 30
        Me.FGRID.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.FGRID.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FGRID.RowTemplate.Height = 150
        Me.FGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FGRID.Size = New System.Drawing.Size(603, 475)
        Me.FGRID.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.FGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.FGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.FGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.FGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.FGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.FGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.FGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.FGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.FGRID.TabIndex = 559
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "IMAGE"
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'refreshbtn
        '
        Me.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refreshbtn.Image = Nothing
        Me.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.refreshbtn.Location = New System.Drawing.Point(66, 160)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(80, 28)
        Me.refreshbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.refreshbtn.TabIndex = 565
        Me.refreshbtn.Text = "OK"
        Me.refreshbtn.UseCustomForeColor = True
        Me.refreshbtn.UseSelectable = True
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'rownum
        '
        '
        '
        '
        Me.rownum.CustomButton.Image = Nothing
        Me.rownum.CustomButton.Location = New System.Drawing.Point(54, 2)
        Me.rownum.CustomButton.Name = ""
        Me.rownum.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.rownum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.rownum.CustomButton.TabIndex = 1
        Me.rownum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.rownum.CustomButton.UseSelectable = True
        Me.rownum.CustomButton.Visible = False
        Me.rownum.DisplayIcon = True
        Me.rownum.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.rownum.Lines = New String() {"10"}
        Me.rownum.Location = New System.Drawing.Point(66, 69)
        Me.rownum.MaxLength = 32767
        Me.rownum.Multiline = True
        Me.rownum.Name = "rownum"
        Me.rownum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.rownum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.rownum.SelectedText = ""
        Me.rownum.SelectionLength = 0
        Me.rownum.SelectionStart = 0
        Me.rownum.ShowClearButton = True
        Me.rownum.Size = New System.Drawing.Size(80, 28)
        Me.rownum.Style = MetroFramework.MetroColorStyle.Red
        Me.rownum.TabIndex = 569
        Me.rownum.Text = "10"
        Me.rownum.UseCustomForeColor = True
        Me.rownum.UseSelectable = True
        Me.rownum.WaterMark = "row number"
        Me.rownum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.rownum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(24, 69)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(36, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 570
        Me.KryptonLabel2.Values.Text = "TOP"
        '
        'mcount
        '
        '
        '
        '
        Me.mcount.CustomButton.Image = Nothing
        Me.mcount.CustomButton.Location = New System.Drawing.Point(54, 2)
        Me.mcount.CustomButton.Name = ""
        Me.mcount.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.mcount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mcount.CustomButton.TabIndex = 1
        Me.mcount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mcount.CustomButton.UseSelectable = True
        Me.mcount.CustomButton.Visible = False
        Me.mcount.DisplayIcon = True
        Me.mcount.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mcount.Lines = New String() {"1"}
        Me.mcount.Location = New System.Drawing.Point(66, 103)
        Me.mcount.MaxLength = 32767
        Me.mcount.Multiline = True
        Me.mcount.Name = "mcount"
        Me.mcount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mcount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mcount.SelectedText = ""
        Me.mcount.SelectionLength = 0
        Me.mcount.SelectionStart = 0
        Me.mcount.ShowClearButton = True
        Me.mcount.Size = New System.Drawing.Size(80, 28)
        Me.mcount.Style = MetroFramework.MetroColorStyle.Red
        Me.mcount.TabIndex = 571
        Me.mcount.Text = "1"
        Me.mcount.UseCustomForeColor = True
        Me.mcount.UseSelectable = True
        Me.mcount.WaterMark = "from and below"
        Me.mcount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mcount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(16, 103)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(44, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 572
        Me.KryptonLabel1.Values.Text = "Show"
        '
        'fshow
        '
        '
        '
        '
        Me.fshow.CustomButton.Image = Nothing
        Me.fshow.CustomButton.Location = New System.Drawing.Point(54, 2)
        Me.fshow.CustomButton.Name = ""
        Me.fshow.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.fshow.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.fshow.CustomButton.TabIndex = 1
        Me.fshow.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.fshow.CustomButton.UseSelectable = True
        Me.fshow.CustomButton.Visible = False
        Me.fshow.DisplayIcon = True
        Me.fshow.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.fshow.Lines = New String() {"1"}
        Me.fshow.Location = New System.Drawing.Point(66, 304)
        Me.fshow.MaxLength = 32767
        Me.fshow.Multiline = True
        Me.fshow.Name = "fshow"
        Me.fshow.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fshow.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.fshow.SelectedText = ""
        Me.fshow.SelectionLength = 0
        Me.fshow.SelectionStart = 0
        Me.fshow.ShowClearButton = True
        Me.fshow.Size = New System.Drawing.Size(80, 28)
        Me.fshow.Style = MetroFramework.MetroColorStyle.Red
        Me.fshow.TabIndex = 576
        Me.fshow.Text = "1"
        Me.fshow.UseCustomForeColor = True
        Me.fshow.UseSelectable = True
        Me.fshow.WaterMark = "from and below"
        Me.fshow.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.fshow.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(16, 304)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(44, 22)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 577
        Me.KryptonLabel3.Values.Text = "Show"
        '
        'frownum
        '
        '
        '
        '
        Me.frownum.CustomButton.Image = Nothing
        Me.frownum.CustomButton.Location = New System.Drawing.Point(54, 2)
        Me.frownum.CustomButton.Name = ""
        Me.frownum.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.frownum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.frownum.CustomButton.TabIndex = 1
        Me.frownum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.frownum.CustomButton.UseSelectable = True
        Me.frownum.CustomButton.Visible = False
        Me.frownum.DisplayIcon = True
        Me.frownum.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.frownum.Lines = New String() {"10"}
        Me.frownum.Location = New System.Drawing.Point(66, 270)
        Me.frownum.MaxLength = 32767
        Me.frownum.Multiline = True
        Me.frownum.Name = "frownum"
        Me.frownum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.frownum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.frownum.SelectedText = ""
        Me.frownum.SelectionLength = 0
        Me.frownum.SelectionStart = 0
        Me.frownum.ShowClearButton = True
        Me.frownum.Size = New System.Drawing.Size(80, 28)
        Me.frownum.Style = MetroFramework.MetroColorStyle.Red
        Me.frownum.TabIndex = 574
        Me.frownum.Text = "10"
        Me.frownum.UseCustomForeColor = True
        Me.frownum.UseSelectable = True
        Me.frownum.WaterMark = "row number"
        Me.frownum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.frownum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(24, 270)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(36, 22)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 575
        Me.KryptonLabel4.Values.Text = "TOP"
        '
        'MetroTextButton1
        '
        Me.MetroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTextButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTextButton1.Image = Nothing
        Me.MetroTextButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTextButton1.Location = New System.Drawing.Point(66, 361)
        Me.MetroTextButton1.Name = "MetroTextButton1"
        Me.MetroTextButton1.Size = New System.Drawing.Size(80, 28)
        Me.MetroTextButton1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTextButton1.TabIndex = 573
        Me.MetroTextButton1.Text = "OK"
        Me.MetroTextButton1.UseCustomForeColor = True
        Me.MetroTextButton1.UseSelectable = True
        Me.MetroTextButton1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.Panel1.Controls.Add(Me.KryptonLabel7)
        Me.Panel1.Controls.Add(Me.MetroToggle2)
        Me.Panel1.Controls.Add(Me.MetroToggle1)
        Me.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.fshow)
        Me.Panel1.Controls.Add(Me.refreshbtn)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.rownum)
        Me.Panel1.Controls.Add(Me.frownum)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.mcount)
        Me.Panel1.Controls.Add(Me.MetroTextButton1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 476)
        Me.Panel1.TabIndex = 578
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(43, 336)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(22, 22)
        Me.KryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 583
        Me.KryptonLabel8.Values.Text = "%"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(43, 135)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(22, 22)
        Me.KryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 582
        Me.KryptonLabel7.Values.Text = "%"
        '
        'MetroToggle2
        '
        Me.MetroToggle2.AutoSize = True
        Me.MetroToggle2.Checked = True
        Me.MetroToggle2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroToggle2.Location = New System.Drawing.Point(66, 338)
        Me.MetroToggle2.Name = "MetroToggle2"
        Me.MetroToggle2.Size = New System.Drawing.Size(80, 17)
        Me.MetroToggle2.TabIndex = 581
        Me.MetroToggle2.Text = "On"
        Me.MetroToggle2.UseSelectable = True
        '
        'MetroToggle1
        '
        Me.MetroToggle1.AutoSize = True
        Me.MetroToggle1.Checked = True
        Me.MetroToggle1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroToggle1.Location = New System.Drawing.Point(66, 137)
        Me.MetroToggle1.Name = "MetroToggle1"
        Me.MetroToggle1.Size = New System.Drawing.Size(80, 17)
        Me.MetroToggle1.TabIndex = 580
        Me.MetroToggle1.Text = "On"
        Me.MetroToggle1.UseSelectable = True
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(66, 232)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(54, 32)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.KryptonLabel6.TabIndex = 579
        Me.KryptonLabel6.Values.Text = "Miss"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(66, 31)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(43, 32)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.KryptonLabel5.TabIndex = 578
        Me.KryptonLabel5.Values.Text = "Mr."
        '
        'RESULTFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 531)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FGRID)
        Me.Controls.Add(Me.MGRID)
        Me.Name = "RESULTFRM"
        CType(Me.MGRID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents imagecol As DataGridViewImageColumn
    Friend WithEvents FGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents refreshbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents rownum As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents mcount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents fshow As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents frownum As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MetroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MetroToggle1 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroToggle2 As MetroFramework.Controls.MetroToggle
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
