<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form32
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form32))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.NeroBar1 = New NeroBar.NeroBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.KryptonListBox1 = New ComponentFactory.Krypton.Toolkit.KryptonListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.img = New System.Windows.Forms.ToolStripStatusLabel
        Me.info = New System.Windows.Forms.ToolStripStatusLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.SparklePurple
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(43, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Windows Mode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(650, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Windows Mode allows you to run all your Windows-based programs as well as games i" & _
            "nside BlixOS without a hitch. "
        '
        'KryptonButton1
        '
        Me.KryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.KryptonButton1.Location = New System.Drawing.Point(348, 74)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.KryptonButton1.Size = New System.Drawing.Size(61, 24)
        Me.KryptonButton1.TabIndex = 0
        Me.KryptonButton1.Text = "Choose . ."
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = "Choose . ."
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        Me.KryptonTextBox1.Location = New System.Drawing.Point(272, 48)
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.KryptonTextBox1.ReadOnly = True
        Me.KryptonTextBox1.Size = New System.Drawing.Size(214, 20)
        Me.KryptonTextBox1.TabIndex = 1
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.KryptonButton2)
        Me.KryptonPanel2.Controls.Add(Me.NeroBar1)
        Me.KryptonPanel2.Controls.Add(Me.Label4)
        Me.KryptonPanel2.Controls.Add(Me.KryptonListBox1)
        Me.KryptonPanel2.Controls.Add(Me.Label3)
        Me.KryptonPanel2.Controls.Add(Me.Label7)
        Me.KryptonPanel2.Controls.Add(Me.KryptonButton1)
        Me.KryptonPanel2.Controls.Add(Me.KryptonTextBox1)
        Me.KryptonPanel2.Location = New System.Drawing.Point(12, 96)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.KryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabCustom3
        Me.KryptonPanel2.Size = New System.Drawing.Size(803, 325)
        Me.KryptonPanel2.TabIndex = 17
        '
        'KryptonButton2
        '
        Me.KryptonButton2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.KryptonButton2.Location = New System.Drawing.Point(348, 276)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.KryptonButton2.Size = New System.Drawing.Size(61, 24)
        Me.KryptonButton2.TabIndex = 9
        Me.KryptonButton2.Text = "Start"
        Me.KryptonButton2.Values.ExtraText = ""
        Me.KryptonButton2.Values.Image = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton2.Values.Text = "Start"
        '
        'NeroBar1
        '
        Me.NeroBar1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NeroBar1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NeroBar1.BackColor = System.Drawing.Color.Transparent
        Me.NeroBar1.GlowMode = NeroBar.NeroBar.NeroBarGlowModes.ProgressOnly
        Me.NeroBar1.GlowPause = 200
        Me.NeroBar1.GlowSpeed = 2
        Me.NeroBar1.Location = New System.Drawing.Point(102, 253)
        Me.NeroBar1.Name = "NeroBar1"
        Me.NeroBar1.PercentageBasedOn = NeroBar.NeroBar.NeroBarPercentageCalculationModes.WholeControl
        Me.NeroBar1.Segment1Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NeroBar1.SegmentCount = NeroBar.NeroBar.NeroBarSegments.One
        Me.NeroBar1.Size = New System.Drawing.Size(590, 15)
        Me.NeroBar1.TabIndex = 8
        Me.NeroBar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(312, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Start your Application"
        '
        'KryptonListBox1
        '
        Me.KryptonListBox1.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlStandalone
        Me.KryptonListBox1.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.InputControlStandalone
        Me.KryptonListBox1.Items.AddRange(New Object() {"BlixOS Home", "BlixOS Professional", "BlixOS Ultimate"})
        Me.KryptonListBox1.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem
        Me.KryptonListBox1.Location = New System.Drawing.Point(321, 144)
        Me.KryptonListBox1.Name = "KryptonListBox1"
        Me.KryptonListBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonListBox1.Size = New System.Drawing.Size(120, 61)
        Me.KryptonListBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(298, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Select compatiblity mode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(301, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Choose your application"
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Executable File (.exe)|*.exe"
        Me.OpenFileDialog1.Title = "Select Program"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.img, Me.info})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(827, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'img
        '
        Me.img.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(0, 17)
        '
        'info
        '
        Me.info.BackColor = System.Drawing.Color.White
        Me.info.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(29, 17)
        Me.info.Text = "Idle"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form32
        '
        Me.AcceptButton = Me.KryptonButton2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(827, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.KryptonPanel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form32"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Mode"
        Me.TextExtra = ""
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NeroBar1 As NeroBar.NeroBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents KryptonListBox1 As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents img As System.Windows.Forms.ToolStripStatusLabel
End Class
