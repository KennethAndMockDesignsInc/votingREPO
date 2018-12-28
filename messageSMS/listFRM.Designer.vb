<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listFRM
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.imagecol = New System.Windows.Forms.DataGridViewImageColumn()
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.refreshbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton2 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRID
        '
        Me.GRID.AllowUserToAddRows = False
        Me.GRID.AllowUserToDeleteRows = False
        Me.GRID.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRID.ColumnHeadersHeight = 32
        Me.GRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imagecol})
        Me.GRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID.Location = New System.Drawing.Point(23, 128)
        Me.GRID.MultiSelect = False
        Me.GRID.Name = "GRID"
        Me.GRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.GRID.RowHeadersWidth = 30
        Me.GRID.RowTemplate.Height = 100
        Me.GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID.Size = New System.Drawing.Size(724, 331)
        Me.GRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.GRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.GRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.GRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.GRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.GRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.GRID.TabIndex = 557
        '
        'imagecol
        '
        Me.imagecol.HeaderText = "IMAGE"
        Me.imagecol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.imagecol.Name = "imagecol"
        Me.imagecol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.imagecol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'newbtn
        '
        Me.newbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbtn.Image = Nothing
        Me.newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newbtn.Location = New System.Drawing.Point(148, 98)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(119, 24)
        Me.newbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.newbtn.TabIndex = 565
        Me.newbtn.Text = "new"
        Me.newbtn.UseCustomForeColor = True
        Me.newbtn.UseSelectable = True
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refreshbtn.Image = Nothing
        Me.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.refreshbtn.Location = New System.Drawing.Point(23, 98)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(119, 24)
        Me.refreshbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.refreshbtn.TabIndex = 564
        Me.refreshbtn.Text = "refresh"
        Me.refreshbtn.UseCustomForeColor = True
        Me.refreshbtn.UseSelectable = True
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'MetroTextButton1
        '
        Me.MetroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTextButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTextButton1.Image = Nothing
        Me.MetroTextButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTextButton1.Location = New System.Drawing.Point(273, 98)
        Me.MetroTextButton1.Name = "MetroTextButton1"
        Me.MetroTextButton1.Size = New System.Drawing.Size(119, 24)
        Me.MetroTextButton1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTextButton1.TabIndex = 566
        Me.MetroTextButton1.Text = "update"
        Me.MetroTextButton1.UseCustomForeColor = True
        Me.MetroTextButton1.UseSelectable = True
        Me.MetroTextButton1.UseVisualStyleBackColor = True
        '
        'MetroTextButton2
        '
        Me.MetroTextButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTextButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTextButton2.Image = Nothing
        Me.MetroTextButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTextButton2.Location = New System.Drawing.Point(398, 98)
        Me.MetroTextButton2.Name = "MetroTextButton2"
        Me.MetroTextButton2.Size = New System.Drawing.Size(119, 24)
        Me.MetroTextButton2.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTextButton2.TabIndex = 567
        Me.MetroTextButton2.Text = "delete"
        Me.MetroTextButton2.UseCustomForeColor = True
        Me.MetroTextButton2.UseSelectable = True
        Me.MetroTextButton2.UseVisualStyleBackColor = True
        '
        'listFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 482)
        Me.Controls.Add(Me.MetroTextButton2)
        Me.Controls.Add(Me.MetroTextButton1)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.GRID)
        Me.Name = "listFRM"
        Me.Text = "BEST 80s look"
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents newbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents refreshbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents imagecol As DataGridViewImageColumn
    Friend WithEvents MetroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroTextButton2 As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
