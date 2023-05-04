<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Set_Up
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Set_Up))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_Intervals = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Excel_AW_col = New System.Windows.Forms.TextBox()
        Me.TextBox_Excel_WW_col = New System.Windows.Forms.TextBox()
        Me.TextBox_Excel_DW_col = New System.Windows.Forms.TextBox()
        Me.TextBox_Excel_Barcode_col = New System.Windows.Forms.TextBox()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.RichTextBox_Set_Up_Logs = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown_Intervals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_Intervals)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_Excel_AW_col)
        Me.GroupBox1.Controls.Add(Me.TextBox_Excel_WW_col)
        Me.GroupBox1.Controls.Add(Me.TextBox_Excel_DW_col)
        Me.GroupBox1.Controls.Add(Me.TextBox_Excel_Barcode_col)
        Me.GroupBox1.Controls.Add(Me.Button_Save)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'NumericUpDown_Intervals
        '
        Me.NumericUpDown_Intervals.Location = New System.Drawing.Point(196, 20)
        Me.NumericUpDown_Intervals.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDown_Intervals.Minimum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown_Intervals.Name = "NumericUpDown_Intervals"
        Me.NumericUpDown_Intervals.Size = New System.Drawing.Size(58, 20)
        Me.NumericUpDown_Intervals.TabIndex = 105
        Me.NumericUpDown_Intervals.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Time interval"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "AW_col"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "WW_col"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "DW_col"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Barcode_col"
        '
        'TextBox_Excel_AW_col
        '
        Me.TextBox_Excel_AW_col.Location = New System.Drawing.Point(77, 99)
        Me.TextBox_Excel_AW_col.Name = "TextBox_Excel_AW_col"
        Me.TextBox_Excel_AW_col.Size = New System.Drawing.Size(42, 20)
        Me.TextBox_Excel_AW_col.TabIndex = 99
        '
        'TextBox_Excel_WW_col
        '
        Me.TextBox_Excel_WW_col.Location = New System.Drawing.Point(77, 71)
        Me.TextBox_Excel_WW_col.Name = "TextBox_Excel_WW_col"
        Me.TextBox_Excel_WW_col.Size = New System.Drawing.Size(42, 20)
        Me.TextBox_Excel_WW_col.TabIndex = 98
        '
        'TextBox_Excel_DW_col
        '
        Me.TextBox_Excel_DW_col.Location = New System.Drawing.Point(77, 45)
        Me.TextBox_Excel_DW_col.Name = "TextBox_Excel_DW_col"
        Me.TextBox_Excel_DW_col.Size = New System.Drawing.Size(42, 20)
        Me.TextBox_Excel_DW_col.TabIndex = 97
        '
        'TextBox_Excel_Barcode_col
        '
        Me.TextBox_Excel_Barcode_col.Location = New System.Drawing.Point(77, 19)
        Me.TextBox_Excel_Barcode_col.Name = "TextBox_Excel_Barcode_col"
        Me.TextBox_Excel_Barcode_col.Size = New System.Drawing.Size(42, 20)
        Me.TextBox_Excel_Barcode_col.TabIndex = 96
        '
        'Button_Save
        '
        Me.Button_Save.BackgroundImage = CType(resources.GetObject("Button_Save.BackgroundImage"), System.Drawing.Image)
        Me.Button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Save.Location = New System.Drawing.Point(227, 108)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(27, 25)
        Me.Button_Save.TabIndex = 95
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'RichTextBox_Set_Up_Logs
        '
        Me.RichTextBox_Set_Up_Logs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox_Set_Up_Logs.Location = New System.Drawing.Point(12, 163)
        Me.RichTextBox_Set_Up_Logs.Name = "RichTextBox_Set_Up_Logs"
        Me.RichTextBox_Set_Up_Logs.ReadOnly = True
        Me.RichTextBox_Set_Up_Logs.Size = New System.Drawing.Size(260, 44)
        Me.RichTextBox_Set_Up_Logs.TabIndex = 0
        Me.RichTextBox_Set_Up_Logs.Text = ""
        '
        'Form_Set_Up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 213)
        Me.Controls.Add(Me.RichTextBox_Set_Up_Logs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Form_Set_Up"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown_Intervals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBox_Set_Up_Logs As RichTextBox
    Friend WithEvents Button_Save As Button
    Friend WithEvents TextBox_Excel_Barcode_col As TextBox
    Friend WithEvents TextBox_Excel_DW_col As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Excel_AW_col As TextBox
    Friend WithEvents TextBox_Excel_WW_col As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown_Intervals As NumericUpDown
End Class
