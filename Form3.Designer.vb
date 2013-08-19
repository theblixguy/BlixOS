<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Blix Paint")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BlixPad")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Foxlight MIDE")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Canure")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Text to Binary")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("View system info")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System Tools", New System.Windows.Forms.TreeNode() {TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Narrator")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ease of Access", New System.Windows.Forms.TreeNode() {TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Applications", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode25, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My Computer")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My Documents")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My Pictures")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My Music")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Places", New System.Windows.Forms.TreeNode() {TreeNode29, TreeNode30, TreeNode31, TreeNode32})
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Games")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Webcam")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Handwriting Recognizer")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"My Pictures"}, 9, System.Drawing.Color.White, System.Drawing.Color.Empty, New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"My Documents"}, 8, System.Drawing.Color.White, System.Drawing.Color.Empty, New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Canure"}, 7, System.Drawing.Color.White, System.Drawing.Color.Empty, Nothing)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Recycle Bin"}, 4, System.Drawing.Color.White, System.Drawing.Color.Empty, Nothing)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Blix Paint"}, 10, System.Drawing.Color.White, System.Drawing.Color.Empty, Nothing)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RenameToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeWallpaperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PowerOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowDockbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DockbarPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowMiniPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EnableEOAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pics = New System.Windows.Forms.ToolStripMenuItem
        Me.docs = New System.Windows.Forms.ToolStripMenuItem
        Me.comp = New System.Windows.Forms.ToolStripMenuItem
        Me.bpad = New System.Windows.Forms.ToolStripMenuItem
        Me.tman = New System.Windows.Forms.ToolStripMenuItem
        Me.bpaint = New System.Windows.Forms.ToolStripMenuItem
        Me.perso = New System.Windows.Forms.ToolStripMenuItem
        Me.sinf = New System.Windows.Forms.ToolStripMenuItem
        Me.txt2bin = New System.Windows.Forms.ToolStripMenuItem
        Me.canure = New System.Windows.Forms.ToolStripMenuItem
        Me.StopShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pwr = New System.Windows.Forms.ToolStripMenuItem
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.winmode = New System.Windows.Forms.ToolStripMenuItem
        Me.wcam = New System.Windows.Forms.ToolStripMenuItem
        Me.recog = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.FontDialog2 = New System.Windows.Forms.FontDialog
        Me.KryptonContextMenu1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenu
        Me.KryptonContextMenuCheckButton1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckButton
        Me.KryptonContextMenuCheckButton2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckButton
        Me.KryptonContextMenuItems1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New UI.Glass.Panel
        Me.Clock1 = New AnalogClock.Clock
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.KryptonButton4 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel2 = New UI.Glass.Panel
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonDropButton1 = New ComponentFactory.Krypton.Toolkit.KryptonDropButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.KryptonContextMenuItems2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.KryptonButton5 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonCheckButton1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.KryptonCheckButton2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenameToolStripMenuItem, Me.RenameToolStripMenuItem1, Me.TaskManagerToolStripMenuItem, Me.ChangeWallpaperToolStripMenuItem, Me.PowerOptionsToolStripMenuItem, Me.ShowDockbarToolStripMenuItem, Me.DockbarPropertiesToolStripMenuItem, Me.ShowMiniPlayerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 180)
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Image = CType(resources.GetObject("RenameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.RenameToolStripMenuItem.Text = "Refresh Desktop"
        '
        'RenameToolStripMenuItem1
        '
        Me.RenameToolStripMenuItem1.Name = "RenameToolStripMenuItem1"
        Me.RenameToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.RenameToolStripMenuItem1.Text = "Rename"
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.Image = Global.BlixOS_Professional.My.Resources.Resources.tman
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        '
        'ChangeWallpaperToolStripMenuItem
        '
        Me.ChangeWallpaperToolStripMenuItem.Image = Global.BlixOS_Professional.My.Resources.Resources.personalize
        Me.ChangeWallpaperToolStripMenuItem.Name = "ChangeWallpaperToolStripMenuItem"
        Me.ChangeWallpaperToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ChangeWallpaperToolStripMenuItem.Text = "Change Wallpaper"
        '
        'PowerOptionsToolStripMenuItem
        '
        Me.PowerOptionsToolStripMenuItem.Image = CType(resources.GetObject("PowerOptionsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PowerOptionsToolStripMenuItem.Name = "PowerOptionsToolStripMenuItem"
        Me.PowerOptionsToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PowerOptionsToolStripMenuItem.Text = "Power Options"
        '
        'ShowDockbarToolStripMenuItem
        '
        Me.ShowDockbarToolStripMenuItem.Name = "ShowDockbarToolStripMenuItem"
        Me.ShowDockbarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ShowDockbarToolStripMenuItem.Text = "Show Dockbar"
        '
        'DockbarPropertiesToolStripMenuItem
        '
        Me.DockbarPropertiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockToolStripMenuItem, Me.UnlockToolStripMenuItem})
        Me.DockbarPropertiesToolStripMenuItem.Name = "DockbarPropertiesToolStripMenuItem"
        Me.DockbarPropertiesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DockbarPropertiesToolStripMenuItem.Text = "Dockbar Properties"
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.LockToolStripMenuItem.Text = "Lock"
        '
        'UnlockToolStripMenuItem
        '
        Me.UnlockToolStripMenuItem.Name = "UnlockToolStripMenuItem"
        Me.UnlockToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.UnlockToolStripMenuItem.Text = "Unlock"
        '
        'ShowMiniPlayerToolStripMenuItem
        '
        Me.ShowMiniPlayerToolStripMenuItem.Name = "ShowMiniPlayerToolStripMenuItem"
        Me.ShowMiniPlayerToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ShowMiniPlayerToolStripMenuItem.Text = "Show MiniPlayer"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "clipping picture.ico")
        Me.ImageList1.Images.SetKeyName(1, "folder-1-3-9.ico")
        Me.ImageList1.Images.SetKeyName(2, "idisk.ico")
        Me.ImageList1.Images.SetKeyName(3, "Pictures.ico")
        Me.ImageList1.Images.SetKeyName(4, "Trash_empty.ico")
        Me.ImageList1.Images.SetKeyName(5, "Trash_full.ico")
        Me.ImageList1.Images.SetKeyName(6, "Library.ico")
        Me.ImageList1.Images.SetKeyName(7, "browser.png")
        Me.ImageList1.Images.SetKeyName(8, "my-docs.png")
        Me.ImageList1.Images.SetKeyName(9, "my-pictures.png")
        Me.ImageList1.Images.SetKeyName(10, "paint.png")
        Me.ImageList1.Images.SetKeyName(11, "text-edit.png")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowItemReorder = True
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ToolStripMenuItem1, Me.pics, Me.docs, Me.comp, Me.bpad, Me.tman, Me.bpaint, Me.perso, Me.sinf, Me.txt2bin, Me.canure, Me.StopShutdownToolStripMenuItem, Me.pwr, Me.RunToolStripMenuItem, Me.winmode, Me.wcam, Me.recog})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 768)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1280, 32)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.StartToolStripMenuItem.Image = CType(resources.GetObject("StartToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(60, 28)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableEOAToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = Global.BlixOS_Professional.My.Resources.Resources.Folder_Front
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripMenuItem1.ToolTipText = "Show all open windows"
        Me.ToolStripMenuItem1.Visible = False
        '
        'EnableEOAToolStripMenuItem
        '
        Me.EnableEOAToolStripMenuItem.Name = "EnableEOAToolStripMenuItem"
        Me.EnableEOAToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.EnableEOAToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.EnableEOAToolStripMenuItem.Text = "Enable EOA"
        Me.EnableEOAToolStripMenuItem.Visible = False
        '
        'pics
        '
        Me.pics.ForeColor = System.Drawing.Color.Black
        Me.pics.Image = Global.BlixOS_Professional.My.Resources.Resources.my_pictures
        Me.pics.Name = "pics"
        Me.pics.Size = New System.Drawing.Size(28, 28)
        Me.pics.ToolTipText = "My Pictures"
        Me.pics.Visible = False
        '
        'docs
        '
        Me.docs.ForeColor = System.Drawing.Color.Black
        Me.docs.Image = Global.BlixOS_Professional.My.Resources.Resources.my_docs
        Me.docs.Name = "docs"
        Me.docs.Size = New System.Drawing.Size(28, 28)
        Me.docs.ToolTipText = "My Documents"
        Me.docs.Visible = False
        '
        'comp
        '
        Me.comp.ForeColor = System.Drawing.Color.Black
        Me.comp.Image = Global.BlixOS_Professional.My.Resources.Resources.MyComputer
        Me.comp.Name = "comp"
        Me.comp.Size = New System.Drawing.Size(28, 28)
        Me.comp.ToolTipText = "My Computer"
        Me.comp.Visible = False
        '
        'bpad
        '
        Me.bpad.ForeColor = System.Drawing.Color.Black
        Me.bpad.Image = Global.BlixOS_Professional.My.Resources.Resources.text_edit
        Me.bpad.Name = "bpad"
        Me.bpad.Size = New System.Drawing.Size(28, 28)
        Me.bpad.ToolTipText = "BlixPad"
        Me.bpad.Visible = False
        '
        'tman
        '
        Me.tman.ForeColor = System.Drawing.Color.Black
        Me.tman.Image = Global.BlixOS_Professional.My.Resources.Resources.tman
        Me.tman.Name = "tman"
        Me.tman.Size = New System.Drawing.Size(28, 28)
        Me.tman.ToolTipText = "Task Manager"
        Me.tman.Visible = False
        '
        'bpaint
        '
        Me.bpaint.Image = Global.BlixOS_Professional.My.Resources.Resources.paint
        Me.bpaint.Name = "bpaint"
        Me.bpaint.Size = New System.Drawing.Size(28, 28)
        Me.bpaint.ToolTipText = "Blix Paint"
        Me.bpaint.Visible = False
        '
        'perso
        '
        Me.perso.Image = Global.BlixOS_Professional.My.Resources.Resources.personalize
        Me.perso.Name = "perso"
        Me.perso.Size = New System.Drawing.Size(28, 28)
        Me.perso.ToolTipText = "Personalize"
        Me.perso.Visible = False
        '
        'sinf
        '
        Me.sinf.Image = CType(resources.GetObject("sinf.Image"), System.Drawing.Image)
        Me.sinf.Name = "sinf"
        Me.sinf.Size = New System.Drawing.Size(28, 28)
        Me.sinf.ToolTipText = "System Information"
        Me.sinf.Visible = False
        '
        'txt2bin
        '
        Me.txt2bin.Image = CType(resources.GetObject("txt2bin.Image"), System.Drawing.Image)
        Me.txt2bin.Name = "txt2bin"
        Me.txt2bin.Size = New System.Drawing.Size(28, 28)
        Me.txt2bin.ToolTipText = "Text to Binary Converter"
        Me.txt2bin.Visible = False
        '
        'canure
        '
        Me.canure.Image = CType(resources.GetObject("canure.Image"), System.Drawing.Image)
        Me.canure.Name = "canure"
        Me.canure.Size = New System.Drawing.Size(28, 28)
        Me.canure.ToolTipText = "Canure"
        Me.canure.Visible = False
        '
        'StopShutdownToolStripMenuItem
        '
        Me.StopShutdownToolStripMenuItem.Name = "StopShutdownToolStripMenuItem"
        Me.StopShutdownToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StopShutdownToolStripMenuItem.Size = New System.Drawing.Size(100, 28)
        Me.StopShutdownToolStripMenuItem.Text = "Stop Shutdown"
        Me.StopShutdownToolStripMenuItem.Visible = False
        '
        'pwr
        '
        Me.pwr.BackColor = System.Drawing.Color.Transparent
        Me.pwr.Image = CType(resources.GetObject("pwr.Image"), System.Drawing.Image)
        Me.pwr.Name = "pwr"
        Me.pwr.Size = New System.Drawing.Size(28, 28)
        Me.pwr.ToolTipText = "Power Options"
        Me.pwr.Visible = False
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(40, 28)
        Me.RunToolStripMenuItem.Text = "Run"
        Me.RunToolStripMenuItem.Visible = False
        '
        'winmode
        '
        Me.winmode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.winmode.Image = CType(resources.GetObject("winmode.Image"), System.Drawing.Image)
        Me.winmode.Name = "winmode"
        Me.winmode.Size = New System.Drawing.Size(28, 28)
        Me.winmode.Text = "Windows Mode"
        Me.winmode.Visible = False
        '
        'wcam
        '
        Me.wcam.Image = Global.BlixOS_Professional.My.Resources.Resources.webcam_icon
        Me.wcam.Name = "wcam"
        Me.wcam.Size = New System.Drawing.Size(28, 28)
        Me.wcam.Visible = False
        '
        'recog
        '
        Me.recog.Image = Global.BlixOS_Professional.My.Resources.Resources.Rename
        Me.recog.Name = "recog"
        Me.recog.Size = New System.Drawing.Size(28, 28)
        Me.recog.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'FontDialog1
        '
        Me.FontDialog1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FontDialog2
        '
        Me.FontDialog2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'KryptonContextMenu1
        '
        Me.KryptonContextMenu1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuCheckButton1, Me.KryptonContextMenuCheckButton2})
        Me.KryptonContextMenu1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black
        Me.KryptonContextMenu1.Tag = Nothing
        '
        'KryptonContextMenuCheckButton1
        '
        Me.KryptonContextMenuCheckButton1.AutoClose = True
        Me.KryptonContextMenuCheckButton1.ImageTransparentColor = System.Drawing.Color.Empty
        Me.KryptonContextMenuCheckButton1.Text = "Restart"
        '
        'KryptonContextMenuCheckButton2
        '
        Me.KryptonContextMenuCheckButton2.ImageTransparentColor = System.Drawing.Color.Empty
        Me.KryptonContextMenuCheckButton2.Text = "Hibernate"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Clock1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(1118, 44)
        Me.Panel1.MouseReflection = True
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Opacity = 50
        Me.Panel1.Radius = 5.0!
        Me.Panel1.Size = New System.Drawing.Size(150, 684)
        Me.Panel1.TabIndex = 3
        Me.Panel1.Visible = False
        '
        'Clock1
        '
        Me.Clock1.BackColor = System.Drawing.Color.Transparent
        Me.Clock1.BigMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("BigMarker90", 90.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker60", 60.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker30", 30.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker0", 0.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker330", 330.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker300", 300.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker270", 270.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker240", 240.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker210", 210.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker180", 180.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker150", 150.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker120", 120.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing)}
        Me.Clock1.CenterPoint.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.CenterPoint.RelativeRadius = 0.03!
        Me.Clock1.HourHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.HourHand.RelativeRadius = 0.65!
        Me.Clock1.HourHand.Width = 5.0!
        Me.Clock1.Location = New System.Drawing.Point(21, 35)
        Me.Clock1.MinuteHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.MinuteHand.RelativeRadius = 0.8!
        Me.Clock1.MinuteHand.Width = 5.0!
        Me.Clock1.Name = "Clock1"
        Me.Clock1.Running = False
        Me.Clock1.SecondHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.SecondHand.RelativeRadius = 0.9!
        Me.Clock1.SecondHand.Width = 1.0!
        Me.Clock1.Size = New System.Drawing.Size(110, 117)
        Me.Clock1.SmallMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("SmallMarker90", 90.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker84", 84.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker78", 78.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker72", 72.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker66", 66.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker60", 60.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker54", 54.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker48", 48.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker42", 42.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker36", 36.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker30", 30.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker24", 24.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker18", 18.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker12", 12.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker6", 6.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker0", 0.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker354", 354.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker348", 348.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker342", 342.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker336", 336.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker330", 330.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker324", 324.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker318", 318.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker312", 312.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker306", 306.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker300", 300.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker294", 294.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker288", 288.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker282", 282.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker276", 276.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker270", 270.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker264", 264.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker258", 258.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker252", 252.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker246", 246.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker240", 240.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker234", 234.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker228", 228.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker222", 222.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker216", 216.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker210", 210.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker204", 204.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker198", 198.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker192", 192.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker186", 186.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker180", 180.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker174", 174.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker168", 168.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker162", 162.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker156", 156.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker150", 150.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker144", 144.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker138", 138.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker132", 132.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker126", 126.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker120", 120.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker114", 114.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker108", 108.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker102", 102.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker96", 96.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 55.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing)}
        Me.Clock1.Symbols = New AnalogClock.Symbol() {New AnalogClock.Symbol("Symbol90", 90.0!, "12", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 0, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol60", 60.0!, "1", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 1, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol30", 30.0!, "2", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 2, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol0", 0.0!, "3", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 3, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol330", 330.0!, "4", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 4, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol300", 300.0!, "5", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 5, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol270", 270.0!, "6", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 6, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol240", 240.0!, "7", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 7, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol210", 210.0!, "8", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 8, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol180", 180.0!, "9", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 9, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol150", 150.0!, "10", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 10, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol120", 120.0!, "11", New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 11, True, True, AnalogClock.SymbolStyle.Numeric, 55.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing)}
        Me.Clock1.TabIndex = 4
        Me.Clock1.UpdateFrequency = 1
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.ProgressBar1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(12, 398)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(129, 80)
        Me.Panel4.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "100%"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 42)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(110, 13)
        Me.ProgressBar1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Power Status"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.KryptonButton4)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Location = New System.Drawing.Point(12, 186)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 185)
        Me.Panel3.TabIndex = 6
        '
        'KryptonButton4
        '
        Me.KryptonButton4.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.KryptonButton4.Location = New System.Drawing.Point(24, 140)
        Me.KryptonButton4.Name = "KryptonButton4"
        Me.KryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonButton4.Size = New System.Drawing.Size(76, 34)
        Me.KryptonButton4.TabIndex = 8
        Me.KryptonButton4.Text = "Send"
        Me.KryptonButton4.Values.ExtraText = ""
        Me.KryptonButton4.Values.Image = Nothing
        Me.KryptonButton4.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton4.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton4.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton4.Values.Text = "Send"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(3, 70)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(120, 64)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "Your message"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SMS Sender"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 21)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "Phone Number"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.TreeView1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.KryptonButton3)
        Me.Panel2.Controls.Add(Me.KryptonButton2)
        Me.Panel2.Controls.Add(Me.KryptonButton1)
        Me.Panel2.Controls.Add(Me.KryptonTextBox1)
        Me.Panel2.Controls.Add(Me.KryptonDropButton1)
        Me.Panel2.GlassColor = System.Drawing.Color.Transparent
        Me.Panel2.Location = New System.Drawing.Point(2, 319)
        Me.Panel2.MouseReflection = True
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Opacity = 0
        Me.Panel2.Radius = 5.0!
        Me.Panel2.Size = New System.Drawing.Size(0, 0)
        Me.Panel2.TabIndex = 4
        Me.Panel2.Visible = False
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList2
        Me.TreeView1.ItemHeight = 32
        Me.TreeView1.Location = New System.Drawing.Point(22, 18)
        Me.TreeView1.Name = "TreeView1"
        TreeNode19.ImageIndex = 10
        TreeNode19.Name = "Node1"
        TreeNode19.Text = "Blix Paint"
        TreeNode19.ToolTipText = "Create, edit and save drawings on your computer"
        TreeNode20.ImageIndex = 11
        TreeNode20.Name = "Node2"
        TreeNode20.Text = "BlixPad"
        TreeNode20.ToolTipText = "Create, edit or save text files on your computer"
        TreeNode21.ImageIndex = 19
        TreeNode21.Name = "Node3"
        TreeNode21.Text = "Foxlight MIDE"
        TreeNode21.ToolTipText = "Develop scripts for Foxlight"
        TreeNode22.ImageIndex = 7
        TreeNode22.Name = "Node0"
        TreeNode22.Text = "Canure"
        TreeNode22.ToolTipText = "Browse the internet"
        TreeNode23.ImageIndex = 18
        TreeNode23.Name = "Node0"
        TreeNode23.Text = "Text to Binary"
        TreeNode23.ToolTipText = "Converts text to binary and vice versa"
        TreeNode24.ImageIndex = 14
        TreeNode24.Name = "Node3"
        TreeNode24.Text = "View system info"
        TreeNode24.ToolTipText = "Shows you your system's configuration"
        TreeNode25.ImageIndex = 13
        TreeNode25.Name = "Node2"
        TreeNode25.Text = "System Tools"
        TreeNode26.ImageIndex = 21
        TreeNode26.Name = "Node2"
        TreeNode26.Text = "Narrator"
        TreeNode26.ToolTipText = "Narrates text to you"
        TreeNode27.ImageIndex = 21
        TreeNode27.Name = "Node1"
        TreeNode27.Text = "Ease of Access"
        TreeNode27.ToolTipText = "Contains tools to make you computer easier to use"
        TreeNode28.ImageIndex = 1
        TreeNode28.Name = "Node0"
        TreeNode28.Text = "Applications"
        TreeNode28.ToolTipText = "Contains BlixOS native applications"
        TreeNode29.ImageIndex = 17
        TreeNode29.Name = "Node5"
        TreeNode29.Text = "My Computer"
        TreeNode29.ToolTipText = "Manage all your data"
        TreeNode30.ImageIndex = 8
        TreeNode30.Name = "Node6"
        TreeNode30.Text = "My Documents"
        TreeNode30.ToolTipText = "Manage all your documents"
        TreeNode31.ImageIndex = 16
        TreeNode31.Name = "Node7"
        TreeNode31.Text = "My Pictures"
        TreeNode31.ToolTipText = "Manage all your pictures"
        TreeNode32.ImageIndex = 15
        TreeNode32.Name = "Node8"
        TreeNode32.Text = "My Music"
        TreeNode32.ToolTipText = "Manage all your songs and videos"
        TreeNode33.ImageIndex = 12
        TreeNode33.Name = "Node4"
        TreeNode33.Text = "Places"
        TreeNode33.ToolTipText = "View places on your computer"
        TreeNode34.ImageIndex = 0
        TreeNode34.Name = "Node9"
        TreeNode34.Text = "Games"
        TreeNode34.ToolTipText = "Play games on your computer"
        TreeNode35.ImageIndex = 23
        TreeNode35.Name = "Node0"
        TreeNode35.Text = "Webcam"
        TreeNode36.ImageIndex = 24
        TreeNode36.Name = "Node0"
        TreeNode36.Text = "Handwriting Recognizer"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode33, TreeNode34, TreeNode35, TreeNode36})
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.ShowLines = False
        Me.TreeView1.ShowNodeToolTips = True
        Me.TreeView1.ShowPlusMinus = False
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(182, 383)
        Me.TreeView1.TabIndex = 9
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "clipping picture.ico")
        Me.ImageList2.Images.SetKeyName(1, "folder-1-3-9.ico")
        Me.ImageList2.Images.SetKeyName(2, "idisk.ico")
        Me.ImageList2.Images.SetKeyName(3, "Pictures.ico")
        Me.ImageList2.Images.SetKeyName(4, "Trash_empty.ico")
        Me.ImageList2.Images.SetKeyName(5, "Trash_full.ico")
        Me.ImageList2.Images.SetKeyName(6, "Library.ico")
        Me.ImageList2.Images.SetKeyName(7, "browser.png")
        Me.ImageList2.Images.SetKeyName(8, "my-docs.png")
        Me.ImageList2.Images.SetKeyName(9, "my-pictures.png")
        Me.ImageList2.Images.SetKeyName(10, "paint.png")
        Me.ImageList2.Images.SetKeyName(11, "text-edit.png")
        Me.ImageList2.Images.SetKeyName(12, "Desktop-1-6.ico")
        Me.ImageList2.Images.SetKeyName(13, "external.ico")
        Me.ImageList2.Images.SetKeyName(14, "Get Info.ico")
        Me.ImageList2.Images.SetKeyName(15, "Music.ico")
        Me.ImageList2.Images.SetKeyName(16, "Pictures.ico")
        Me.ImageList2.Images.SetKeyName(17, "my-computer.png")
        Me.ImageList2.Images.SetKeyName(18, "text2bin.png")
        Me.ImageList2.Images.SetKeyName(19, "Smart.ico")
        Me.ImageList2.Images.SetKeyName(20, "Connect.ico")
        Me.ImageList2.Images.SetKeyName(21, "user.ico")
        Me.ImageList2.Images.SetKeyName(22, "ConnectionManager.ico")
        Me.ImageList2.Images.SetKeyName(23, "webcam-icon.png")
        Me.ImageList2.Images.SetKeyName(24, "Rename.png")
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(232, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'KryptonButton3
        '
        Me.KryptonButton3.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.KryptonButton3.Location = New System.Drawing.Point(211, 170)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.KryptonButton3.Size = New System.Drawing.Size(103, 26)
        Me.KryptonButton3.TabIndex = 7
        Me.KryptonButton3.Text = "Computer"
        Me.KryptonButton3.Values.ExtraText = ""
        Me.KryptonButton3.Values.Image = Nothing
        Me.KryptonButton3.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton3.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton3.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton3.Values.Text = "Computer"
        '
        'KryptonButton2
        '
        Me.KryptonButton2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.KryptonButton2.Location = New System.Drawing.Point(211, 128)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.KryptonButton2.Size = New System.Drawing.Size(103, 26)
        Me.KryptonButton2.TabIndex = 6
        Me.KryptonButton2.Text = "Pictures"
        Me.KryptonButton2.Values.ExtraText = ""
        Me.KryptonButton2.Values.Image = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton2.Values.Text = "Pictures"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.KryptonButton1.Location = New System.Drawing.Point(210, 87)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.KryptonButton1.Size = New System.Drawing.Size(103, 26)
        Me.KryptonButton1.TabIndex = 5
        Me.KryptonButton1.Text = "Documents"
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = "Documents"
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        Me.KryptonTextBox1.Location = New System.Drawing.Point(22, 407)
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonTextBox1.Size = New System.Drawing.Size(182, 20)
        Me.KryptonTextBox1.TabIndex = 3
        Me.KryptonTextBox1.Text = "Search"
        '
        'KryptonDropButton1
        '
        Me.KryptonDropButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.KryptonDropButton1.Location = New System.Drawing.Point(232, 406)
        Me.KryptonDropButton1.Name = "KryptonDropButton1"
        Me.KryptonDropButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonDropButton1.Size = New System.Drawing.Size(81, 24)
        Me.KryptonDropButton1.TabIndex = 2
        Me.KryptonDropButton1.Text = "Shutdown"
        Me.KryptonDropButton1.Values.ExtraText = ""
        Me.KryptonDropButton1.Values.Image = Nothing
        Me.KryptonDropButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonDropButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonDropButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonDropButton1.Values.Text = "Shutdown"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1468, 902)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(353, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView1.AllowDrop = True
        Me.ListView1.AutoArrange = False
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        ListViewItem6.ToolTipText = "View, edit, convert and save images on your computer."
        ListViewItem7.ToolTipText = "View all your common data"
        ListViewItem8.ToolTipText = "Allows you to browse the internet"
        ListViewItem9.ToolTipText = "Contains items deleted by you"
        ListViewItem10.ToolTipText = "Create, edit or save drawings on your computer"
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
        Me.ListView1.LabelEdit = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(1280, 800)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 744)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "BlixOS Professional" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Evaluation copy. Build 1215.blxfre"
        Me.Label1.Visible = False
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        '
        'Timer6
        '
        Me.Timer6.Interval = 2000
        '
        'Timer7
        '
        Me.Timer7.Interval = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1213, 769)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "16:16"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1198, 782)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "20-06-2010"
        '
        'KryptonButton5
        '
        Me.KryptonButton5.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.KryptonButton5.Location = New System.Drawing.Point(1267, 768)
        Me.KryptonButton5.Name = "KryptonButton5"
        Me.KryptonButton5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonButton5.Size = New System.Drawing.Size(13, 32)
        Me.KryptonButton5.TabIndex = 6
        Me.KryptonButton5.Values.ExtraText = ""
        Me.KryptonButton5.Values.Image = Nothing
        Me.KryptonButton5.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton5.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton5.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton5.Values.Text = ""
        '
        'KryptonCheckButton1
        '
        Me.KryptonCheckButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.KryptonCheckButton1.Location = New System.Drawing.Point(1155, 771)
        Me.KryptonCheckButton1.Name = "KryptonCheckButton1"
        Me.KryptonCheckButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.KryptonCheckButton1.Size = New System.Drawing.Size(27, 24)
        Me.KryptonCheckButton1.TabIndex = 8
        Me.KryptonCheckButton1.Text = "2"
        Me.KryptonCheckButton1.Values.ExtraText = ""
        Me.KryptonCheckButton1.Values.Image = Nothing
        Me.KryptonCheckButton1.Values.Text = "2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1185, 775)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 14)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "|"
        '
        'KryptonCheckButton2
        '
        Me.KryptonCheckButton2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.KryptonCheckButton2.Location = New System.Drawing.Point(1122, 771)
        Me.KryptonCheckButton2.Name = "KryptonCheckButton2"
        Me.KryptonCheckButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.KryptonCheckButton2.Size = New System.Drawing.Size(27, 24)
        Me.KryptonCheckButton2.TabIndex = 10
        Me.KryptonCheckButton2.Text = "1"
        Me.KryptonCheckButton2.Values.ExtraText = ""
        Me.KryptonCheckButton2.Values.Image = Nothing
        Me.KryptonCheckButton2.Values.Text = "1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.KryptonCheckButton2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.KryptonCheckButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.KryptonButton5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.ShowInTaskbar = False
        Me.Text = "Blixplorer"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RenameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pics As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents docs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents comp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopShutdownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TaskManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bpad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tman As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeWallpaperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As UI.Glass.Panel
    Friend WithEvents Clock1 As AnalogClock.Clock
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents FontDialog2 As System.Windows.Forms.FontDialog
    Friend WithEvents Panel2 As UI.Glass.Panel
    Friend WithEvents KryptonDropButton1 As ComponentFactory.Krypton.Toolkit.KryptonDropButton
    Friend WithEvents KryptonContextMenu1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents KryptonContextMenuItems1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuCheckButton1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckButton
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents bpaint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents perso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents sinf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt2bin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents canure As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EnableEOAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PowerOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pwr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonButton4 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents ShowDockbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DockbarPropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnlockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMiniPlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents winmode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonContextMenuCheckButton2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckButton
    Friend WithEvents KryptonContextMenuItems2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents wcam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents recog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer7 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KryptonButton5 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonCheckButton1 As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents KryptonCheckButton2 As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
End Class
