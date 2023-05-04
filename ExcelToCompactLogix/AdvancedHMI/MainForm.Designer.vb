<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox_ = New System.Windows.Forms.RichTextBox()
        Me.Button_Load = New System.Windows.Forms.Button()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.TextBox_IP = New System.Windows.Forms.TextBox()
        Me.RichTextBox_Logs = New System.Windows.Forms.RichTextBox()
        Me.Button_File = New System.Windows.Forms.Button()
        Me.System_Status = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Load = New System.Windows.Forms.Button()
        Me.PLC_Track = New System.Windows.Forms.Label()
        Me.Button_Send = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label_PLC_Pos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown_RangeL = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_RangeH = New System.Windows.Forms.NumericUpDown()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.CheckBox_Range = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Auto_Load = New System.Windows.Forms.CheckBox()
        Me.Button_SetUp = New System.Windows.Forms.Button()
        Me.Label_Size = New System.Windows.Forms.Label()
        Me.CheckBox_PLC_Control = New System.Windows.Forms.CheckBox()
        Me.Button_Stop = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label_Time = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_RangeL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_RangeH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 571)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.AdvancedHMILogoBR
        Me.PictureBox1.Location = New System.Drawing.Point(424, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox_
        '
        Me.RichTextBox_.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox_.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox_.Location = New System.Drawing.Point(15, 141)
        Me.RichTextBox_.Name = "RichTextBox_"
        Me.RichTextBox_.ReadOnly = True
        Me.RichTextBox_.Size = New System.Drawing.Size(656, 195)
        Me.RichTextBox_.TabIndex = 70
        Me.RichTextBox_.Text = ""
        '
        'Button_Load
        '
        Me.Button_Load.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_Load.Location = New System.Drawing.Point(610, 417)
        Me.Button_Load.Name = "Button_Load"
        Me.Button_Load.Size = New System.Drawing.Size(61, 28)
        Me.Button_Load.TabIndex = 72
        Me.Button_Load.Text = "Load"
        Me.Button_Load.UseVisualStyleBackColor = True
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 2000
        '
        'TextBox_IP
        '
        Me.TextBox_IP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_IP.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_IP.Location = New System.Drawing.Point(15, 420)
        Me.TextBox_IP.Name = "TextBox_IP"
        Me.TextBox_IP.Size = New System.Drawing.Size(102, 25)
        Me.TextBox_IP.TabIndex = 73
        '
        'RichTextBox_Logs
        '
        Me.RichTextBox_Logs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox_Logs.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox_Logs.Location = New System.Drawing.Point(15, 358)
        Me.RichTextBox_Logs.Name = "RichTextBox_Logs"
        Me.RichTextBox_Logs.ReadOnly = True
        Me.RichTextBox_Logs.Size = New System.Drawing.Size(656, 53)
        Me.RichTextBox_Logs.TabIndex = 75
        Me.RichTextBox_Logs.Text = ""
        '
        'Button_File
        '
        Me.Button_File.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_File.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_File.Location = New System.Drawing.Point(525, 417)
        Me.Button_File.Name = "Button_File"
        Me.Button_File.Size = New System.Drawing.Size(79, 28)
        Me.Button_File.TabIndex = 76
        Me.Button_File.Text = "Select File"
        Me.Button_File.UseVisualStyleBackColor = True
        '
        'System_Status
        '
        Me.System_Status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.System_Status.AutoSize = True
        Me.System_Status.BackColor = System.Drawing.Color.Transparent
        Me.System_Status.ForeColor = System.Drawing.Color.Lime
        Me.System_Status.Location = New System.Drawing.Point(15, 9)
        Me.System_Status.Name = "System_Status"
        Me.System_Status.Size = New System.Drawing.Size(113, 18)
        Me.System_Status.TabIndex = 77
        Me.System_Status.Text = "System_Status"
        '
        'Timer1
        '
        Me.Timer1.Interval = 700
        '
        'Load
        '
        Me.Load.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Load.BackgroundImage = CType(resources.GetObject("Load.BackgroundImage"), System.Drawing.Image)
        Me.Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Load.Location = New System.Drawing.Point(127, 420)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(27, 25)
        Me.Load.TabIndex = 79
        Me.Load.UseVisualStyleBackColor = True
        '
        'PLC_Track
        '
        Me.PLC_Track.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PLC_Track.AutoSize = True
        Me.PLC_Track.BackColor = System.Drawing.Color.Transparent
        Me.PLC_Track.ForeColor = System.Drawing.Color.Lime
        Me.PLC_Track.Location = New System.Drawing.Point(15, 77)
        Me.PLC_Track.Name = "PLC_Track"
        Me.PLC_Track.Size = New System.Drawing.Size(82, 18)
        Me.PLC_Track.TabIndex = 80
        Me.PLC_Track.Text = "PLC_Step"
        '
        'Button_Send
        '
        Me.Button_Send.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_Send.BackgroundImage = CType(resources.GetObject("Button_Send.BackgroundImage"), System.Drawing.Image)
        Me.Button_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Send.Location = New System.Drawing.Point(226, 421)
        Me.Button_Send.Name = "Button_Send"
        Me.Button_Send.Size = New System.Drawing.Size(27, 25)
        Me.Button_Send.TabIndex = 81
        Me.Button_Send.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown1.Location = New System.Drawing.Point(565, 86)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(74, 26)
        Me.NumericUpDown1.TabIndex = 82
        '
        'Label_PLC_Pos
        '
        Me.Label_PLC_Pos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_PLC_Pos.AutoSize = True
        Me.Label_PLC_Pos.BackColor = System.Drawing.Color.Transparent
        Me.Label_PLC_Pos.ForeColor = System.Drawing.Color.Wheat
        Me.Label_PLC_Pos.Location = New System.Drawing.Point(562, 116)
        Me.Label_PLC_Pos.Name = "Label_PLC_Pos"
        Me.Label_PLC_Pos.Size = New System.Drawing.Size(106, 18)
        Me.Label_PLC_Pos.TabIndex = 83
        Me.Label_PLC_Pos.Text = "PLC_Position"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Tan
        Me.Label3.Location = New System.Drawing.Point(467, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 24)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Position"
        '
        'NumericUpDown_RangeL
        '
        Me.NumericUpDown_RangeL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_RangeL.Location = New System.Drawing.Point(263, 105)
        Me.NumericUpDown_RangeL.Name = "NumericUpDown_RangeL"
        Me.NumericUpDown_RangeL.Size = New System.Drawing.Size(51, 26)
        Me.NumericUpDown_RangeL.TabIndex = 88
        '
        'NumericUpDown_RangeH
        '
        Me.NumericUpDown_RangeH.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_RangeH.Location = New System.Drawing.Point(320, 105)
        Me.NumericUpDown_RangeH.Name = "NumericUpDown_RangeH"
        Me.NumericUpDown_RangeH.Size = New System.Drawing.Size(51, 26)
        Me.NumericUpDown_RangeH.TabIndex = 89
        '
        'Button_Clear
        '
        Me.Button_Clear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_Clear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Clear.Location = New System.Drawing.Point(436, 417)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(83, 28)
        Me.Button_Clear.TabIndex = 90
        Me.Button_Clear.Text = "Clear/Reset"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'CheckBox_Range
        '
        Me.CheckBox_Range.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox_Range.AutoSize = True
        Me.CheckBox_Range.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_Range.ForeColor = System.Drawing.Color.White
        Me.CheckBox_Range.Location = New System.Drawing.Point(285, 77)
        Me.CheckBox_Range.Name = "CheckBox_Range"
        Me.CheckBox_Range.Size = New System.Drawing.Size(73, 22)
        Me.CheckBox_Range.TabIndex = 92
        Me.CheckBox_Range.Text = "Range"
        Me.CheckBox_Range.UseVisualStyleBackColor = False
        '
        'CheckBox_Auto_Load
        '
        Me.CheckBox_Auto_Load.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox_Auto_Load.AutoSize = True
        Me.CheckBox_Auto_Load.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_Auto_Load.ForeColor = System.Drawing.Color.White
        Me.CheckBox_Auto_Load.Location = New System.Drawing.Point(260, 422)
        Me.CheckBox_Auto_Load.Name = "CheckBox_Auto_Load"
        Me.CheckBox_Auto_Load.Size = New System.Drawing.Size(137, 22)
        Me.CheckBox_Auto_Load.TabIndex = 93
        Me.CheckBox_Auto_Load.Text = "Automatic Load"
        Me.CheckBox_Auto_Load.UseVisualStyleBackColor = False
        '
        'Button_SetUp
        '
        Me.Button_SetUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_SetUp.BackgroundImage = CType(resources.GetObject("Button_SetUp.BackgroundImage"), System.Drawing.Image)
        Me.Button_SetUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_SetUp.Location = New System.Drawing.Point(403, 418)
        Me.Button_SetUp.Name = "Button_SetUp"
        Me.Button_SetUp.Size = New System.Drawing.Size(27, 25)
        Me.Button_SetUp.TabIndex = 94
        Me.Button_SetUp.UseVisualStyleBackColor = True
        '
        'Label_Size
        '
        Me.Label_Size.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Size.AutoSize = True
        Me.Label_Size.BackColor = System.Drawing.Color.Transparent
        Me.Label_Size.ForeColor = System.Drawing.Color.Silver
        Me.Label_Size.Location = New System.Drawing.Point(15, 107)
        Me.Label_Size.Name = "Label_Size"
        Me.Label_Size.Size = New System.Drawing.Size(39, 18)
        Me.Label_Size.TabIndex = 95
        Me.Label_Size.Text = "Size"
        '
        'CheckBox_PLC_Control
        '
        Me.CheckBox_PLC_Control.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox_PLC_Control.AutoSize = True
        Me.CheckBox_PLC_Control.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_PLC_Control.ForeColor = System.Drawing.Color.White
        Me.CheckBox_PLC_Control.Location = New System.Drawing.Point(562, 58)
        Me.CheckBox_PLC_Control.Name = "CheckBox_PLC_Control"
        Me.CheckBox_PLC_Control.Size = New System.Drawing.Size(113, 22)
        Me.CheckBox_PLC_Control.TabIndex = 96
        Me.CheckBox_PLC_Control.Text = "PLC Control"
        Me.CheckBox_PLC_Control.UseVisualStyleBackColor = False
        '
        'Button_Stop
        '
        Me.Button_Stop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_Stop.BackgroundImage = CType(resources.GetObject("Button_Stop.BackgroundImage"), System.Drawing.Image)
        Me.Button_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Stop.Location = New System.Drawing.Point(196, 421)
        Me.Button_Stop.Name = "Button_Stop"
        Me.Button_Stop.Size = New System.Drawing.Size(27, 25)
        Me.Button_Stop.TabIndex = 97
        Me.Button_Stop.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Label_Time
        '
        Me.Label_Time.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Time.AutoSize = True
        Me.Label_Time.BackColor = System.Drawing.Color.Transparent
        Me.Label_Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Time.ForeColor = System.Drawing.Color.Transparent
        Me.Label_Time.Location = New System.Drawing.Point(259, 8)
        Me.Label_Time.Name = "Label_Time"
        Me.Label_Time.Size = New System.Drawing.Size(99, 20)
        Me.Label_Time.TabIndex = 98
        Me.Label_Time.Text = "TimeStamp"
        Me.Label_Time.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 342)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(656, 10)
        Me.ProgressBar1.TabIndex = 99
        '
        'BackgroundWorker2
        '
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(687, 458)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label_Time)
        Me.Controls.Add(Me.Button_Stop)
        Me.Controls.Add(Me.CheckBox_PLC_Control)
        Me.Controls.Add(Me.Label_Size)
        Me.Controls.Add(Me.Button_SetUp)
        Me.Controls.Add(Me.CheckBox_Auto_Load)
        Me.Controls.Add(Me.CheckBox_Range)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.NumericUpDown_RangeH)
        Me.Controls.Add(Me.NumericUpDown_RangeL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_PLC_Pos)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button_Send)
        Me.Controls.Add(Me.PLC_Track)
        Me.Controls.Add(Me.Load)
        Me.Controls.Add(Me.System_Status)
        Me.Controls.Add(Me.Button_File)
        Me.Controls.Add(Me.RichTextBox_Logs)
        Me.Controls.Add(Me.TextBox_IP)
        Me.Controls.Add(Me.Button_Load)
        Me.Controls.Add(Me.RichTextBox_)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_RangeL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_RangeH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox_ As RichTextBox
    Friend WithEvents Button_Load As Button
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents TextBox_IP As TextBox
    Friend WithEvents RichTextBox_Logs As RichTextBox
    Friend WithEvents Button_File As Button
    Friend WithEvents System_Status As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Load As Button
    Friend WithEvents PLC_Track As Label
    Friend WithEvents Button_Send As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label_PLC_Pos As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown_RangeL As NumericUpDown
    Friend WithEvents NumericUpDown_RangeH As NumericUpDown
    Friend WithEvents Button_Clear As Button
    Friend WithEvents CheckBox_Range As CheckBox
    Friend WithEvents CheckBox_Auto_Load As CheckBox
    Friend WithEvents Button_SetUp As Button
    Friend WithEvents Label_Size As Label
    Friend WithEvents CheckBox_PLC_Control As CheckBox
    Friend WithEvents Button_Stop As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label_Time As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As ToolTip
End Class
