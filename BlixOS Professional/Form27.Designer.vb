<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form27
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form27))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonListBox1 = New ComponentFactory.Krypton.Toolkit.KryptonListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.Label2 = New System.Windows.Forms.Label
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Silver
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.KryptonListBox1)
        Me.KryptonPanel2.Controls.Add(Me.Label3)
        Me.KryptonPanel2.Controls.Add(Me.MonthCalendar1)
        Me.KryptonPanel2.Controls.Add(Me.Label2)
        Me.KryptonPanel2.Controls.Add(Me.KryptonButton1)
        Me.KryptonPanel2.Controls.Add(Me.Label7)
        Me.KryptonPanel2.Controls.Add(Me.Label10)
        Me.KryptonPanel2.Controls.Add(Me.Label11)
        Me.KryptonPanel2.Controls.Add(Me.PictureBox2)
        Me.KryptonPanel2.Location = New System.Drawing.Point(12, 12)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.KryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabCustom3
        Me.KryptonPanel2.Size = New System.Drawing.Size(831, 400)
        Me.KryptonPanel2.TabIndex = 16
        '
        'KryptonListBox1
        '
        Me.KryptonListBox1.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlStandalone
        Me.KryptonListBox1.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.InputControlStandalone
        Me.KryptonListBox1.Items.AddRange(New Object() {"(UTC -12:00) Internation Date Line West", "(UTC -11:00) Coordinated Universal Time -11", "(UTC -11:00) Samoa", "(UTC -10:00) Hawaii", "(UTC -09:00) Alaska", "(UTC -08:00) Baja Calafornia", "(UTC -08:00) Pacific Time (US && Canada)", "(UTC -07:00) Arizona", "(UTC -07:00) Chihuahua, Mazatlan, La Paz", "(UTC -07:00) Mountain Time (US && Canada)", "(UTC -06:00) Central America", "(UTC -06:00) Central Time (US && Canada)", "(UTC -06:00) Guadalajara, Monterrey, Mexico City", "(UTC -06:00) Saskatchewan", "(UTC -05:00) Bogota, Lima, Quito", "(UTC -05:00) Eastern Time (US && Canada)", "(UTC -05:00)  Indiana (East)", "(UTC -04:30) Caracas", "(UTC -04:00) Asuncian", "(UTC -04:00) Atlantic Time (Canada)", "(UTC -04:00) Cuiaba", "(UTC -04:00) Georgetown, La Paz, San Jaun, Manaus", "(UTC -04:00) Santiago", "(UTC -03:30) Newfoundland", "(UTC -03:00) Brasilia", "(UTC -03:00) Buenos Aires", "(UTC -03:00) Cayenne, Fortaleza ", "(UTC -03:00) Greenland", "(UTC -03:00) Montevideo", "(UTC -02:00) Coordinated Universal Time -02", "(UTC -02:00)  Mid-atlantic", "(UTC -01:00) Azores", "(UTC -01:00) Cape Verde Islands", "(UTC) Casablanca", "(UTC) Coordinated Universal Time", "(UTC) Dublin, Edinburg, London, Lisbon", "(UTC) Monorovia, Reykjavik", "(UTC +01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna", "(UTC +01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague", "(UTC +01:00) Brussels, Copenhagen, Madrid, Paris", "(UTC +01:00) Sarajevo, Skopje, Warsaw, Zagreb", "(UTC +01:00) West Central Africa", "(UTC +02:00) Amman", "(UTC +02:00) Athens, Bucharest, Istanbul", "(UTC +02:00) Beirut", "(UTC +02:00) Cairo", "(UTC +02:00) Damascus", "(UTC +02:00) Harare, Pretoria", "(UTC +02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius", "(UTC +02:00) Jerusalem", "(UTC +02:00) Minsk", "(UTC +02:00) Windhoek", "(UTC +03:00) Baghdad", "(UTC +03:00) Kuwait, Riyadh", "(UTC +03:00) Moscow, Volgograd, St. Petersburg", "(UTC +03:00) Nairobi", "(UTC +03:30) Tehran", "(UTC +04:00) Abu Dhabi, Muscat", "(UTC +04:00) Baku", "(UTC +04:00) Yerevan", "(UTC +04:30) Kabul", "(UTC +05:00) Ekatarinburg", "(UTC +05:00) Islamabad, Karachi", "(UTC +05:00) Tashkent", "(UTC +05:30) Chennai, Kolkata, Mumbai, New Delhi", "(UTC +05:30) Sri Jayawardenepura", "(UTC +05:45) Kathmandu", "(UTC +06:00) Astana", "(UTC +06:00) Dhaka", "(UTC +06:00) Novosibirsk", "(UTC +06:30) Yangon (Rangoon)", "(UTC +07:00) Bangkok, Hanoi, Jakarta", "(UTC +07:00) Krasnoyark", "(UTC +08:00) Beijing, Chonqing, Hong Kong, Urumuqi", "(UTC +08:00) Irkutsk", "(UTC +08:00) Kuala Lampur, Singapore", "(UTC +08:00) Perth", "(UTC +08:00) Taipei", "(UTC +08:00) Ulaanbaatar", "(UTC +09:00) Osaka, Tokyo, Sapporo", "(UTC +09:00) Seoul", "(UTC +09:00) Yakutsk", "(UTC +09:30) Adelaide", "(UTC +09:30) Darwin", "(UTC +10:00) Brisbane", "(UTC +10:00) Canberra, Melbourne, Sydney", "(UTC +10:00) Guam, Port Moresby", "(UTC +10:00) Hobart", "(UTC +10:00) Vladivostok", "(UTC +11:00) Magadan, Solomon Islands, New Celadonia", "(UTC +12:00) Auckland, Wellington", "(UTC +12:00) Coordinated Universal Time +12", "(UTC +12:00) Fiji", "(UTC +13:00) Nuku`alofa"})
        Me.KryptonListBox1.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem
        Me.KryptonListBox1.Location = New System.Drawing.Point(309, 135)
        Me.KryptonListBox1.Name = "KryptonListBox1"
        Me.KryptonListBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonListBox1.Size = New System.Drawing.Size(424, 162)
        Me.KryptonListBox1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(306, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Time Zone"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(17, 135)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(18, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "12:31:99"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.KryptonButton1.Location = New System.Drawing.Point(766, 356)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonButton1.Size = New System.Drawing.Size(60, 25)
        Me.KryptonButton1.TabIndex = 8
        Me.KryptonButton1.Text = "Next"
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = "Next"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(18, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Choose Date && Time"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(99, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Pre - Beta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(99, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 18)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "BlixOS Professional"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(499, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Localization Settings"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 0
        Me.TrackBar1.Location = New System.Drawing.Point(12, 414)
        Me.TrackBar1.Maximum = 3
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(843, 45)
        Me.TrackBar1.SmallChange = 0
        Me.TrackBar1.TabIndex = 14
        Me.TrackBar1.Value = 2
        '
        'Form27
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(851, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form27"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BlixOS Professional"
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonListBox1 As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
End Class
