<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lb_ctrl_sc_flg = New System.Windows.Forms.Label()
        Me.lb_emp6 = New System.Windows.Forms.Label()
        Me.line_id = New System.Windows.Forms.Label()
        Me.lb_emp5 = New System.Windows.Forms.Label()
        Me.cavity = New System.Windows.Forms.Label()
        Me.lb_emp4 = New System.Windows.Forms.Label()
        Me.lb_dio_port = New System.Windows.Forms.Label()
        Me.lb_emp3 = New System.Windows.Forms.Label()
        Me.count_type = New System.Windows.Forms.Label()
        Me.lb_emp2 = New System.Windows.Forms.Label()
        Me.lb_printer_port = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lb_scanner_port = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lb_emp1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Timers.Timer()
        Me.menu3 = New System.Windows.Forms.Button()
        Me.menu1 = New System.Windows.Forms.Button()
        Me.menu4 = New System.Windows.Forms.Button()
        Me.menu2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Timer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 13.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(541, 551)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(251, 26)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "New FA system (V 1.7.3)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 8.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(385, 577)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(417, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Copyright © TBKK (Thailand) Company Limited. All rights reservedS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Aqua
        Me.Label4.Location = New System.Drawing.Point(86, 562)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LINE_CD"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lb_ctrl_sc_flg)
        Me.Panel1.Controls.Add(Me.lb_emp6)
        Me.Panel1.Controls.Add(Me.line_id)
        Me.Panel1.Controls.Add(Me.lb_emp5)
        Me.Panel1.Controls.Add(Me.cavity)
        Me.Panel1.Controls.Add(Me.lb_emp4)
        Me.Panel1.Controls.Add(Me.lb_dio_port)
        Me.Panel1.Controls.Add(Me.lb_emp3)
        Me.Panel1.Controls.Add(Me.count_type)
        Me.Panel1.Controls.Add(Me.lb_emp2)
        Me.Panel1.Controls.Add(Me.lb_printer_port)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.lb_scanner_port)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.lb_emp1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(21, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 137)
        Me.Panel1.TabIndex = 12
        '
        'lb_ctrl_sc_flg
        '
        Me.lb_ctrl_sc_flg.AutoSize = True
        Me.lb_ctrl_sc_flg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_ctrl_sc_flg.Location = New System.Drawing.Point(426, 112)
        Me.lb_ctrl_sc_flg.Name = "lb_ctrl_sc_flg"
        Me.lb_ctrl_sc_flg.Size = New System.Drawing.Size(27, 13)
        Me.lb_ctrl_sc_flg.TabIndex = 4629
        Me.lb_ctrl_sc_flg.Text = "emp"
        Me.lb_ctrl_sc_flg.Visible = False
        '
        'lb_emp6
        '
        Me.lb_emp6.AutoSize = True
        Me.lb_emp6.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lb_emp6.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_emp6.ForeColor = System.Drawing.Color.Silver
        Me.lb_emp6.Location = New System.Drawing.Point(564, 93)
        Me.lb_emp6.Name = "lb_emp6"
        Me.lb_emp6.Size = New System.Drawing.Size(75, 22)
        Me.lb_emp6.TabIndex = 4628
        Me.lb_emp6.Text = "KKKKK"
        Me.lb_emp6.Visible = False
        '
        'line_id
        '
        Me.line_id.AutoSize = True
        Me.line_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.line_id.Location = New System.Drawing.Point(383, 112)
        Me.line_id.Name = "line_id"
        Me.line_id.Size = New System.Drawing.Size(37, 13)
        Me.line_id.TabIndex = 26
        Me.line_id.Text = "line_id"
        Me.line_id.Visible = False
        '
        'lb_emp5
        '
        Me.lb_emp5.AutoSize = True
        Me.lb_emp5.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lb_emp5.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_emp5.ForeColor = System.Drawing.Color.Silver
        Me.lb_emp5.Location = New System.Drawing.Point(486, 93)
        Me.lb_emp5.Name = "lb_emp5"
        Me.lb_emp5.Size = New System.Drawing.Size(75, 22)
        Me.lb_emp5.TabIndex = 4627
        Me.lb_emp5.Text = "KKKKK"
        Me.lb_emp5.Visible = False
        '
        'cavity
        '
        Me.cavity.AutoSize = True
        Me.cavity.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cavity.Location = New System.Drawing.Point(342, 112)
        Me.cavity.Name = "cavity"
        Me.cavity.Size = New System.Drawing.Size(35, 13)
        Me.cavity.TabIndex = 28
        Me.cavity.Text = "cavity"
        Me.cavity.Visible = False
        '
        'lb_emp4
        '
        Me.lb_emp4.AutoSize = True
        Me.lb_emp4.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lb_emp4.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_emp4.ForeColor = System.Drawing.Color.Silver
        Me.lb_emp4.Location = New System.Drawing.Point(403, 93)
        Me.lb_emp4.Name = "lb_emp4"
        Me.lb_emp4.Size = New System.Drawing.Size(75, 22)
        Me.lb_emp4.TabIndex = 4626
        Me.lb_emp4.Text = "KKKKK"
        Me.lb_emp4.Visible = False
        '
        'lb_dio_port
        '
        Me.lb_dio_port.AutoSize = True
        Me.lb_dio_port.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_dio_port.Location = New System.Drawing.Point(211, 112)
        Me.lb_dio_port.Name = "lb_dio_port"
        Me.lb_dio_port.Size = New System.Drawing.Size(59, 13)
        Me.lb_dio_port.TabIndex = 31
        Me.lb_dio_port.Text = "lb_dio_port"
        Me.lb_dio_port.Visible = False
        '
        'lb_emp3
        '
        Me.lb_emp3.AutoSize = True
        Me.lb_emp3.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lb_emp3.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_emp3.ForeColor = System.Drawing.Color.Silver
        Me.lb_emp3.Location = New System.Drawing.Point(325, 93)
        Me.lb_emp3.Name = "lb_emp3"
        Me.lb_emp3.Size = New System.Drawing.Size(75, 22)
        Me.lb_emp3.TabIndex = 4625
        Me.lb_emp3.Text = "KKKKK"
        Me.lb_emp3.Visible = False
        '
        'count_type
        '
        Me.count_type.AutoSize = True
        Me.count_type.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.count_type.Location = New System.Drawing.Point(276, 112)
        Me.count_type.Name = "count_type"
        Me.count_type.Size = New System.Drawing.Size(60, 13)
        Me.count_type.TabIndex = 27
        Me.count_type.Text = "count_type"
        Me.count_type.Visible = False
        '
        'lb_emp2
        '
        Me.lb_emp2.AutoSize = True
        Me.lb_emp2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lb_emp2.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_emp2.ForeColor = System.Drawing.Color.Silver
        Me.lb_emp2.Location = New System.Drawing.Point(244, 93)
        Me.lb_emp2.Name = "lb_emp2"
        Me.lb_emp2.Size = New System.Drawing.Size(75, 22)
        Me.lb_emp2.TabIndex = 4624
        Me.lb_emp2.Text = "KKKKK"
        Me.lb_emp2.Visible = False
        '
        'lb_printer_port
        '
        Me.lb_printer_port.AutoSize = True
        Me.lb_printer_port.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_printer_port.Location = New System.Drawing.Point(131, 112)
        Me.lb_printer_port.Name = "lb_printer_port"
        Me.lb_printer_port.Size = New System.Drawing.Size(74, 13)
        Me.lb_printer_port.TabIndex = 30
        Me.lb_printer_port.Text = "lb_printer_port"
        Me.lb_printer_port.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(564, 22)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(60, 70)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 4623
        Me.PictureBox7.TabStop = False
        '
        'lb_scanner_port
        '
        Me.lb_scanner_port.AutoSize = True
        Me.lb_scanner_port.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_scanner_port.Location = New System.Drawing.Point(3, 73)
        Me.lb_scanner_port.Name = "lb_scanner_port"
        Me.lb_scanner_port.Size = New System.Drawing.Size(83, 13)
        Me.lb_scanner_port.TabIndex = 29
        Me.lb_scanner_port.Text = "lb_scanner_port"
        Me.lb_scanner_port.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(485, 21)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(60, 70)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 4622
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(404, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 70)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4621
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(164, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4617
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(325, 22)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(60, 70)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4620
        Me.PictureBox4.TabStop = False
        '
        'lb_emp1
        '
        Me.lb_emp1.AutoSize = True
        Me.lb_emp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lb_emp1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_emp1.ForeColor = System.Drawing.Color.Silver
        Me.lb_emp1.Location = New System.Drawing.Point(163, 93)
        Me.lb_emp1.Name = "lb_emp1"
        Me.lb_emp1.Size = New System.Drawing.Size(75, 22)
        Me.lb_emp1.TabIndex = 4618
        Me.lb_emp1.Text = "KKKKK"
        Me.lb_emp1.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(244, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 70)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4619
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(65, 534)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 28)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "PD"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 50000.0R
        Me.Timer2.SynchronizingObject = Me
        '
        'menu3
        '
        Me.menu3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.menu3.BackgroundImage = CType(resources.GetObject("menu3.BackgroundImage"), System.Drawing.Image)
        Me.menu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menu3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu3.FlatAppearance.BorderSize = 0
        Me.menu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.menu3.Location = New System.Drawing.Point(21, 399)
        Me.menu3.Name = "menu3"
        Me.menu3.Size = New System.Drawing.Size(268, 132)
        Me.menu3.TabIndex = 22
        Me.menu3.UseVisualStyleBackColor = True
        '
        'menu1
        '
        Me.menu1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.menu1.BackgroundImage = CType(resources.GetObject("menu1.BackgroundImage"), System.Drawing.Image)
        Me.menu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menu1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.menu1.FlatAppearance.BorderSize = 0
        Me.menu1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.menu1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.menu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.menu1.Location = New System.Drawing.Point(21, 140)
        Me.menu1.Name = "menu1"
        Me.menu1.Size = New System.Drawing.Size(542, 252)
        Me.menu1.TabIndex = 15
        Me.menu1.UseVisualStyleBackColor = True
        '
        'menu4
        '
        Me.menu4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.menu4.BackgroundImage = CType(resources.GetObject("menu4.BackgroundImage"), System.Drawing.Image)
        Me.menu4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menu4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu4.FlatAppearance.BorderSize = 0
        Me.menu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.menu4.Location = New System.Drawing.Point(572, 140)
        Me.menu4.Name = "menu4"
        Me.menu4.Size = New System.Drawing.Size(210, 391)
        Me.menu4.TabIndex = 14
        Me.menu4.UseVisualStyleBackColor = True
        '
        'menu2
        '
        Me.menu2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.menu2.BackgroundImage = CType(resources.GetObject("menu2.BackgroundImage"), System.Drawing.Image)
        Me.menu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menu2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu2.FlatAppearance.BorderSize = 0
        Me.menu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.menu2.Location = New System.Drawing.Point(295, 399)
        Me.menu2.Name = "menu2"
        Me.menu2.Size = New System.Drawing.Size(268, 132)
        Me.menu2.TabIndex = 16
        Me.menu2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.PictureBox8)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(1, 16)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(168, 116)
        Me.Panel5.TabIndex = 4605
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox8.Location = New System.Drawing.Point(41, 3)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(13, 10)
        Me.PictureBox8.TabIndex = 4630
        Me.PictureBox8.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(683, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4606
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(16, 562)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LINE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 534)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PD : "
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.menu3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.menu1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.menu4)
        Me.Controls.Add(Me.menu2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Timer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents menu4 As Button
    Friend WithEvents menu2 As Button
    Friend WithEvents menu1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents menu3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents line_id As Label
    Friend WithEvents count_type As Label
    Friend WithEvents cavity As Label
    Friend WithEvents Timer2 As Timers.Timer
    Friend WithEvents lb_dio_port As Label
    Friend WithEvents lb_printer_port As Label
    Friend WithEvents lb_scanner_port As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lb_emp6 As Label
    Friend WithEvents lb_emp5 As Label
    Friend WithEvents lb_emp4 As Label
    Friend WithEvents lb_emp3 As Label
    Friend WithEvents lb_emp2 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lb_emp1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lb_ctrl_sc_flg As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox8 As PictureBox
End Class
