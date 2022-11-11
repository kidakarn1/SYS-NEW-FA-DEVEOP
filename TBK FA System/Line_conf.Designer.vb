<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Line_conf
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Line_conf))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.delay_sec = New System.Windows.Forms.ComboBox()
        Me.delay = New System.Windows.Forms.Label()
        Me.ComboBox_master_device = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DIO_PORT = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.printer = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.scanner = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.type_counter = New System.Windows.Forms.ComboBox()
        Me.combo_cavity = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.menu3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(644, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(172, 122)
        Me.Panel3.TabIndex = 27
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(23, 39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 28)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(-2, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(102, 100)
        Me.Panel2.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 25.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Aqua
        Me.Label4.Location = New System.Drawing.Point(97, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(438, 48)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "LINE CONFIGURATION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.delay_sec)
        Me.Panel1.Controls.Add(Me.delay)
        Me.Panel1.Controls.Add(Me.ComboBox_master_device)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DIO_PORT)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.printer)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.scanner)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.type_counter)
        Me.Panel1.Controls.Add(Me.combo_cavity)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(13, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 346)
        Me.Panel1.TabIndex = 30
        '
        'delay_sec
        '
        Me.delay_sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.delay_sec.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.delay_sec.FormattingEnabled = True
        Me.delay_sec.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.delay_sec.Location = New System.Drawing.Point(221, 294)
        Me.delay_sec.Name = "delay_sec"
        Me.delay_sec.Size = New System.Drawing.Size(138, 36)
        Me.delay_sec.TabIndex = 43
        '
        'delay
        '
        Me.delay.AutoSize = True
        Me.delay.Font = New System.Drawing.Font("Arial Black", 17.0!)
        Me.delay.ForeColor = System.Drawing.Color.MintCream
        Me.delay.Location = New System.Drawing.Point(86, 293)
        Me.delay.Name = "delay"
        Me.delay.Size = New System.Drawing.Size(115, 32)
        Me.delay.TabIndex = 40
        Me.delay.Text = "DELAY :"
        '
        'ComboBox_master_device
        '
        Me.ComboBox_master_device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_master_device.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.ComboBox_master_device.FormattingEnabled = True
        Me.ComboBox_master_device.Items.AddRange(New Object() {"DIO000", "DIO001", "DIO002", "DIO003", "DIO004", "DIO005", "DIO006", "DIO007", "DIO008", "DIO009"})
        Me.ComboBox_master_device.Location = New System.Drawing.Point(578, 162)
        Me.ComboBox_master_device.Name = "ComboBox_master_device"
        Me.ComboBox_master_device.Size = New System.Drawing.Size(188, 36)
        Me.ComboBox_master_device.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 17.0!)
        Me.Label8.ForeColor = System.Drawing.Color.MintCream
        Me.Label8.Location = New System.Drawing.Point(446, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 32)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "DEVICE :"
        '
        'DIO_PORT
        '
        Me.DIO_PORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DIO_PORT.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.DIO_PORT.FormattingEnabled = True
        Me.DIO_PORT.Items.AddRange(New Object() {"DIO000", "DIO001", "DIO002", "DIO003", "DIO004", "DIO005", "DIO006", "DIO007", "DIO008", "DIO009"})
        Me.DIO_PORT.Location = New System.Drawing.Point(576, 231)
        Me.DIO_PORT.Name = "DIO_PORT"
        Me.DIO_PORT.Size = New System.Drawing.Size(188, 36)
        Me.DIO_PORT.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 17.0!)
        Me.Label7.ForeColor = System.Drawing.Color.MintCream
        Me.Label7.Location = New System.Drawing.Point(404, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 32)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "DIO / PORT :"
        '
        'printer
        '
        Me.printer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.printer.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.printer.FormattingEnabled = True
        Me.printer.Items.AddRange(New Object() {"USB", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        Me.printer.Location = New System.Drawing.Point(578, 93)
        Me.printer.Name = "printer"
        Me.printer.Size = New System.Drawing.Size(188, 36)
        Me.printer.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 17.0!)
        Me.Label6.ForeColor = System.Drawing.Color.MintCream
        Me.Label6.Location = New System.Drawing.Point(418, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 32)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "SCANNER :"
        '
        'scanner
        '
        Me.scanner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.scanner.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.scanner.FormattingEnabled = True
        Me.scanner.Items.AddRange(New Object() {"USB", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        Me.scanner.Location = New System.Drawing.Point(580, 24)
        Me.scanner.Name = "scanner"
        Me.scanner.Size = New System.Drawing.Size(188, 36)
        Me.scanner.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 17.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(428, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 32)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "PRINTER :"
        '
        'type_counter
        '
        Me.type_counter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.type_counter.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.type_counter.FormattingEnabled = True
        Me.type_counter.Items.AddRange(New Object() {"BUTTON", "TOUCH", "AUTO"})
        Me.type_counter.Location = New System.Drawing.Point(221, 162)
        Me.type_counter.Name = "type_counter"
        Me.type_counter.Size = New System.Drawing.Size(138, 36)
        Me.type_counter.TabIndex = 24
        '
        'combo_cavity
        '
        Me.combo_cavity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_cavity.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.combo_cavity.FormattingEnabled = True
        Me.combo_cavity.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.combo_cavity.Location = New System.Drawing.Point(221, 233)
        Me.combo_cavity.Name = "combo_cavity"
        Me.combo_cavity.Size = New System.Drawing.Size(138, 36)
        Me.combo_cavity.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 17.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MintCream
        Me.Label2.Location = New System.Drawing.Point(83, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 32)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "CAVITY :"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"K1PL00", "K1PD01", "K1PD02", "K1PD03", "K1PD04", "K1PD05", "K1PD07", "K2PD06", "K2PL00", "K1PE00", "K2PE00"})
        Me.ComboBox3.Location = New System.Drawing.Point(221, 25)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(138, 36)
        Me.ComboBox3.TabIndex = 21
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(221, 93)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(138, 36)
        Me.ComboBox2.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Black", 17.0!)
        Me.Label11.ForeColor = System.Drawing.Color.MintCream
        Me.Label11.Location = New System.Drawing.Point(52, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 32)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "COUNTER :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 17.0!)
        Me.Label9.ForeColor = System.Drawing.Color.MintCream
        Me.Label9.Location = New System.Drawing.Point(39, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 32)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "LINE CODE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 17.0!)
        Me.Label5.ForeColor = System.Drawing.Color.MintCream
        Me.Label5.Location = New System.Drawing.Point(1, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DEPARTMENT :"
        '
        'Timer2
        '
        '
        'menu3
        '
        Me.menu3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.menu3.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.menu3.BackgroundImage = CType(resources.GetObject("menu3.BackgroundImage"), System.Drawing.Image)
        Me.menu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menu3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu3.FlatAppearance.BorderSize = 0
        Me.menu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.menu3.Location = New System.Drawing.Point(14, 479)
        Me.menu3.Name = "menu3"
        Me.menu3.Size = New System.Drawing.Size(133, 115)
        Me.menu3.TabIndex = 31
        Me.menu3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(488, 491)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 100)
        Me.Button4.TabIndex = 20
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(641, 491)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 100)
        Me.Button3.TabIndex = 19
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Coral
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(170, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 115)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "SET TAG PRINT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Line_conf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.menu3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Line_conf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Line_conf"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents menu3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Public WithEvents combo_cavity As ComboBox
    Friend WithEvents Label2 As Label
    Public WithEvents type_counter As ComboBox
    Friend WithEvents DIO_PORT As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents printer As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents scanner As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox_master_device As ComboBox
    Friend WithEvents Label8 As Label
    Public WithEvents delay_sec As ComboBox
    Friend WithEvents delay As Label
End Class
