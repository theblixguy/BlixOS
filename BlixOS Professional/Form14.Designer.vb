<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.components = New System.ComponentModel.Container
        Me.TextEditor1 = New Storm.TextEditor.TextEditor
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextEditor1
        '
        Me.TextEditor1.ActiveView = Storm.TextEditor.Editor.ActiveView.BottomRight
        Me.TextEditor1.AutomaticLanguageDetection = True
        Me.TextEditor1.BracketBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TextEditor1.BracketBold = False
        Me.TextEditor1.BracketBorderColor = System.Drawing.Color.Transparent
        Me.TextEditor1.BracketItalic = False
        Me.TextEditor1.BracketStrikethrough = False
        Me.TextEditor1.BracketUnderline = False
        Me.TextEditor1.BreakpointBackColor = System.Drawing.Color.DarkRed
        Me.TextEditor1.BreakpointForeColor = System.Drawing.Color.White
        Me.TextEditor1.CollapsedBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextEditor1.CopyAsRTF = True
        Me.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.None
        Me.TextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextEditor1.EOLMarkerColor = System.Drawing.Color.ForestGreen
        Me.TextEditor1.ExpansionBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TextEditor1.ExpansionSymbolColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextEditor1.FileName = ""
        Me.TextEditor1.FontName = "Consolas"
        Me.TextEditor1.GutterMarginColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextEditor1.GutterMarginWidth = 15
        Me.TextEditor1.HighlightActiveLine = False
        Me.TextEditor1.HighlightedLineColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TextEditor1.InactiveSelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextEditor1.InactiveSelectionBorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TextEditor1.KeepTabs = False
        Me.TextEditor1.LineNumberBackColor = System.Drawing.SystemColors.Window
        Me.TextEditor1.LineNumberBorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TextEditor1.LineNumberForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TextEditor1.Location = New System.Drawing.Point(0, 24)
        Me.TextEditor1.LockCursorUpdate = False
        Me.TextEditor1.Name = "TextEditor1"
        Me.TextEditor1.RowHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TextEditor1.RowPadding = 0
        Me.TextEditor1.Saved = False
        Me.TextEditor1.ScopeBackColor = System.Drawing.Color.Transparent
        Me.TextEditor1.ScopeIndicatorColor = System.Drawing.Color.Transparent
        Me.TextEditor1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEditor1.SelectionBorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEditor1.ShowEOLMarker = False
        Me.TextEditor1.ShowGutterMargin = True
        Me.TextEditor1.ShowLineNumbers = True
        Me.TextEditor1.ShowScopeIndicator = True
        Me.TextEditor1.ShowWhitespace = False
        Me.TextEditor1.Size = New System.Drawing.Size(811, 537)
        Me.TextEditor1.SmoothScroll = True
        Me.TextEditor1.SplitView = True
        Me.TextEditor1.SplitViewHorizontalEdgeDistance = -5
        Me.TextEditor1.SplitViewVerticalEdgeDistance = -5
        Me.TextEditor1.TabGuideColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TextEditor1.TabIndex = 0
        Me.TextEditor1.TabSpaces = 4
        Me.TextEditor1.UseDottedMarginBorder = False
        Me.TextEditor1.WhitespaceColor = System.Drawing.SystemColors.ControlDark
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(811, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadToolStripMenuItem.Text = "Load . ."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "FoxScript file (.fxi)|*.fxi"
        Me.OpenFileDialog1.Title = "Open script"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "FoxScript file (.fxi)|*.fxi"
        Me.SaveFileDialog1.Title = "Save script"
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 561)
        Me.Controls.Add(Me.TextEditor1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form14"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Foxlight MIDE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextEditor1 As Storm.TextEditor.TextEditor
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
