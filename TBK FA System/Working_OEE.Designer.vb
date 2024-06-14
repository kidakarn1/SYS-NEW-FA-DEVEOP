<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Working_OEE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Working_OEE))
        Me.lbPartNo = New System.Windows.Forms.Label()
        Me.lbPartName = New System.Windows.Forms.Label()
        Me.lbLine = New System.Windows.Forms.Label()
        Me.lbShiftPlan = New System.Windows.Forms.Label()
        Me.lbShiftQty = New System.Windows.Forms.Label()
        Me.lbOverTimeAvailability = New System.Windows.Forms.Label()
        Me.lbOverTimeQuality = New System.Windows.Forms.Label()
        Me.lbOverTimePerformance = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvDetailAvailabillty = New System.Windows.Forms.ListView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CircularProgressBar2 = New CircularProgressBar.CircularProgressBar()
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.CircularProgressBar3 = New CircularProgressBar.CircularProgressBar()
        Me.CircularProgressBar4 = New CircularProgressBar.CircularProgressBar()
        Me.lbAccTarget = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.btnInfo = New System.Windows.Forms.PictureBox()
        Me.BtnStart = New System.Windows.Forms.PictureBox()
        Me.btnStop = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_new_dio = New System.Windows.Forms.Timer(Me.components)
        Me.TIME_CAL_EFF = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPortLamp = New System.IO.Ports.SerialPort(Me.components)
        Me.picStart = New System.Windows.Forms.PictureBox()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbPartNo
        '
        Me.lbPartNo.AutoSize = True
        Me.lbPartNo.BackColor = System.Drawing.Color.Transparent
        Me.lbPartNo.Font = New System.Drawing.Font("Panton Narrow-Trial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPartNo.ForeColor = System.Drawing.Color.White
        Me.lbPartNo.Location = New System.Drawing.Point(151, 24)
        Me.lbPartNo.Name = "lbPartNo"
        Me.lbPartNo.Size = New System.Drawing.Size(220, 26)
        Me.lbPartNo.TabIndex = 0
        Me.lbPartNo.Text = "XXXXXXXXXXXXXXXX"
        '
        'lbPartName
        '
        Me.lbPartName.AutoSize = True
        Me.lbPartName.BackColor = System.Drawing.Color.Transparent
        Me.lbPartName.Font = New System.Drawing.Font("Panton Narrow-Trial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbPartName.ForeColor = System.Drawing.Color.White
        Me.lbPartName.Location = New System.Drawing.Point(151, 70)
        Me.lbPartName.Name = "lbPartName"
        Me.lbPartName.Size = New System.Drawing.Size(220, 26)
        Me.lbPartName.TabIndex = 1
        Me.lbPartName.Text = "XXXXXXXXXXXXXXXX"
        '
        'lbLine
        '
        Me.lbLine.AutoSize = True
        Me.lbLine.BackColor = System.Drawing.Color.Transparent
        Me.lbLine.Font = New System.Drawing.Font("Panton Narrow-Trial ExtraBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLine.ForeColor = System.Drawing.Color.White
        Me.lbLine.Location = New System.Drawing.Point(7, 52)
        Me.lbLine.Name = "lbLine"
        Me.lbLine.Size = New System.Drawing.Size(125, 38)
        Me.lbLine.TabIndex = 2
        Me.lbLine.Text = "XXXXXX"
        '
        'lbShiftPlan
        '
        Me.lbShiftPlan.AutoSize = True
        Me.lbShiftPlan.BackColor = System.Drawing.Color.Transparent
        Me.lbShiftPlan.Font = New System.Drawing.Font("Panton Narrow-Trial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShiftPlan.ForeColor = System.Drawing.Color.White
        Me.lbShiftPlan.Location = New System.Drawing.Point(418, 25)
        Me.lbShiftPlan.Name = "lbShiftPlan"
        Me.lbShiftPlan.Size = New System.Drawing.Size(84, 25)
        Me.lbShiftPlan.TabIndex = 3
        Me.lbShiftPlan.Text = "XXXXXX"
        '
        'lbShiftQty
        '
        Me.lbShiftQty.AutoSize = True
        Me.lbShiftQty.BackColor = System.Drawing.Color.Transparent
        Me.lbShiftQty.Font = New System.Drawing.Font("Panton Narrow-Trial", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lbShiftQty.ForeColor = System.Drawing.Color.White
        Me.lbShiftQty.Location = New System.Drawing.Point(419, 69)
        Me.lbShiftQty.Name = "lbShiftQty"
        Me.lbShiftQty.Size = New System.Drawing.Size(83, 30)
        Me.lbShiftQty.TabIndex = 4
        Me.lbShiftQty.Text = "99999"
        '
        'lbOverTimeAvailability
        '
        Me.lbOverTimeAvailability.AutoSize = True
        Me.lbOverTimeAvailability.BackColor = System.Drawing.Color.Transparent
        Me.lbOverTimeAvailability.Font = New System.Drawing.Font("Panton Narrow-Trial", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lbOverTimeAvailability.ForeColor = System.Drawing.Color.Red
        Me.lbOverTimeAvailability.Location = New System.Drawing.Point(39, 163)
        Me.lbOverTimeAvailability.Name = "lbOverTimeAvailability"
        Me.lbOverTimeAvailability.Size = New System.Drawing.Size(55, 30)
        Me.lbOverTimeAvailability.TabIndex = 5
        Me.lbOverTimeAvailability.Text = "999"
        '
        'lbOverTimeQuality
        '
        Me.lbOverTimeQuality.AutoSize = True
        Me.lbOverTimeQuality.BackColor = System.Drawing.Color.Transparent
        Me.lbOverTimeQuality.Font = New System.Drawing.Font("Panton Narrow-Trial", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lbOverTimeQuality.ForeColor = System.Drawing.Color.Red
        Me.lbOverTimeQuality.Location = New System.Drawing.Point(216, 163)
        Me.lbOverTimeQuality.Name = "lbOverTimeQuality"
        Me.lbOverTimeQuality.Size = New System.Drawing.Size(55, 30)
        Me.lbOverTimeQuality.TabIndex = 6
        Me.lbOverTimeQuality.Text = "999"
        '
        'lbOverTimePerformance
        '
        Me.lbOverTimePerformance.AutoSize = True
        Me.lbOverTimePerformance.BackColor = System.Drawing.Color.Transparent
        Me.lbOverTimePerformance.Font = New System.Drawing.Font("Panton Narrow-Trial", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lbOverTimePerformance.ForeColor = System.Drawing.Color.Red
        Me.lbOverTimePerformance.Location = New System.Drawing.Point(385, 165)
        Me.lbOverTimePerformance.Name = "lbOverTimePerformance"
        Me.lbOverTimePerformance.Size = New System.Drawing.Size(55, 30)
        Me.lbOverTimePerformance.TabIndex = 7
        Me.lbOverTimePerformance.Text = "999"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Panton Narrow-Trial", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(373, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "999"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Panton Narrow-Trial", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(372, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "999"
        '
        'lvDetailAvailabillty
        '
        Me.lvDetailAvailabillty.HideSelection = False
        Me.lvDetailAvailabillty.Location = New System.Drawing.Point(9, 222)
        Me.lvDetailAvailabillty.Name = "lvDetailAvailabillty"
        Me.lvDetailAvailabillty.Size = New System.Drawing.Size(161, 73)
        Me.lvDetailAvailabillty.TabIndex = 12
        Me.lvDetailAvailabillty.UseCompatibleStateImageBehavior = False
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(185, 222)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(161, 73)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'CircularProgressBar2
        '
        Me.CircularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar2.AnimationSpeed = 500
        Me.CircularProgressBar2.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar2.Font = New System.Drawing.Font("Panton Narrow-Trial", 36.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar2.ForeColor = System.Drawing.Color.Black
        Me.CircularProgressBar2.InnerColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar2.InnerMargin = 2
        Me.CircularProgressBar2.InnerWidth = -1
        Me.CircularProgressBar2.Location = New System.Drawing.Point(26, 301)
        Me.CircularProgressBar2.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar2.Name = "CircularProgressBar2"
        Me.CircularProgressBar2.OuterColor = System.Drawing.Color.White
        Me.CircularProgressBar2.OuterMargin = -25
        Me.CircularProgressBar2.OuterWidth = 25
        Me.CircularProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.CircularProgressBar2.ProgressWidth = 25
        Me.CircularProgressBar2.SecondaryFont = New System.Drawing.Font("Panton Narrow-Trial", 36.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar2.Size = New System.Drawing.Size(121, 113)
        Me.CircularProgressBar2.StartAngle = 270
        Me.CircularProgressBar2.SubscriptColor = System.Drawing.Color.White
        Me.CircularProgressBar2.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar2.SubscriptText = ""
        Me.CircularProgressBar2.SuperscriptColor = System.Drawing.Color.White
        Me.CircularProgressBar2.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar2.SuperscriptText = ""
        Me.CircularProgressBar2.TabIndex = 4559
        Me.CircularProgressBar2.Text = "0"
        Me.CircularProgressBar2.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar2.Value = 85
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("Panton Narrow-Trial", 36.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.Black
        Me.CircularProgressBar1.InnerColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(203, 301)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.Color.White
        Me.CircularProgressBar1.OuterMargin = -25
        Me.CircularProgressBar1.OuterWidth = 25
        Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBar1.ProgressWidth = 25
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Panton Narrow-Trial", 36.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar1.Size = New System.Drawing.Size(124, 115)
        Me.CircularProgressBar1.StartAngle = 270
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.White
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar1.SubscriptText = ""
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.White
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar1.SuperscriptText = ""
        Me.CircularProgressBar1.TabIndex = 4559
        Me.CircularProgressBar1.Text = "0"
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar1.Value = 85
        '
        'CircularProgressBar3
        '
        Me.CircularProgressBar3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar3.AnimationSpeed = 500
        Me.CircularProgressBar3.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar3.Font = New System.Drawing.Font("Panton Narrow-Trial", 36.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar3.ForeColor = System.Drawing.Color.Black
        Me.CircularProgressBar3.InnerColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar3.InnerMargin = 2
        Me.CircularProgressBar3.InnerWidth = -1
        Me.CircularProgressBar3.Location = New System.Drawing.Point(390, 301)
        Me.CircularProgressBar3.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar3.Name = "CircularProgressBar3"
        Me.CircularProgressBar3.OuterColor = System.Drawing.Color.White
        Me.CircularProgressBar3.OuterMargin = -25
        Me.CircularProgressBar3.OuterWidth = 25
        Me.CircularProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBar3.ProgressWidth = 25
        Me.CircularProgressBar3.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.CircularProgressBar3.Size = New System.Drawing.Size(117, 115)
        Me.CircularProgressBar3.StartAngle = 270
        Me.CircularProgressBar3.SubscriptColor = System.Drawing.Color.White
        Me.CircularProgressBar3.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar3.SubscriptText = ""
        Me.CircularProgressBar3.SuperscriptColor = System.Drawing.Color.White
        Me.CircularProgressBar3.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar3.SuperscriptText = ""
        Me.CircularProgressBar3.TabIndex = 4561
        Me.CircularProgressBar3.Text = "0"
        Me.CircularProgressBar3.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar3.Value = 85
        '
        'CircularProgressBar4
        '
        Me.CircularProgressBar4.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar4.AnimationSpeed = 500
        Me.CircularProgressBar4.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar4.Font = New System.Drawing.Font("Panton Narrow-Trial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar4.ForeColor = System.Drawing.Color.Black
        Me.CircularProgressBar4.InnerColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar4.InnerMargin = 2
        Me.CircularProgressBar4.InnerWidth = -1
        Me.CircularProgressBar4.Location = New System.Drawing.Point(659, 282)
        Me.CircularProgressBar4.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar4.Name = "CircularProgressBar4"
        Me.CircularProgressBar4.OuterColor = System.Drawing.Color.White
        Me.CircularProgressBar4.OuterMargin = -25
        Me.CircularProgressBar4.OuterWidth = 25
        Me.CircularProgressBar4.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBar4.ProgressWidth = 25
        Me.CircularProgressBar4.SecondaryFont = New System.Drawing.Font("Panton Narrow-Trial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar4.Size = New System.Drawing.Size(138, 132)
        Me.CircularProgressBar4.StartAngle = 270
        Me.CircularProgressBar4.SubscriptColor = System.Drawing.Color.White
        Me.CircularProgressBar4.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar4.SubscriptText = ""
        Me.CircularProgressBar4.SuperscriptColor = System.Drawing.Color.White
        Me.CircularProgressBar4.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar4.SuperscriptText = ""
        Me.CircularProgressBar4.TabIndex = 4562
        Me.CircularProgressBar4.Text = "0"
        Me.CircularProgressBar4.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar4.Value = 85
        '
        'lbAccTarget
        '
        Me.lbAccTarget.AutoSize = True
        Me.lbAccTarget.BackColor = System.Drawing.Color.Transparent
        Me.lbAccTarget.Font = New System.Drawing.Font("Panton Narrow-Trial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAccTarget.ForeColor = System.Drawing.Color.Lime
        Me.lbAccTarget.Location = New System.Drawing.Point(656, 159)
        Me.lbAccTarget.Name = "lbAccTarget"
        Me.lbAccTarget.Size = New System.Drawing.Size(95, 35)
        Me.lbAccTarget.TabIndex = 4563
        Me.lbAccTarget.Text = "99999"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Panton Narrow-Trial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(658, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 35)
        Me.Label4.TabIndex = 4564
        Me.Label4.Text = "99999"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Panton Narrow-Trial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(697, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 35)
        Me.Label5.TabIndex = 4565
        Me.Label5.Text = "20"
        '
        'WebView21
        '
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Location = New System.Drawing.Point(0, 418)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(803, 184)
        Me.WebView21.TabIndex = 4568
        Me.WebView21.ZoomFactor = 1.0R
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.Location = New System.Drawing.Point(723, 1)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(80, 95)
        Me.btnMenu.TabIndex = 4569
        Me.btnMenu.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Location = New System.Drawing.Point(12, 536)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(142, 66)
        Me.btnBack.TabIndex = 4571
        Me.btnBack.TabStop = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.Location = New System.Drawing.Point(465, 535)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(163, 66)
        Me.btnInfo.TabIndex = 4572
        Me.btnInfo.TabStop = False
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.Transparent
        Me.BtnStart.Location = New System.Drawing.Point(631, 535)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(165, 66)
        Me.BtnStart.TabIndex = 4573
        Me.BtnStart.TabStop = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Coral
        Me.btnStop.Location = New System.Drawing.Point(631, 536)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(140, 66)
        Me.btnStop.TabIndex = 4574
        Me.btnStop.TabStop = False
        Me.btnStop.Visible = False
        '
        'PanelMenu
        '
        Me.PanelMenu.Location = New System.Drawing.Point(0, 522)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(803, 79)
        Me.PanelMenu.TabIndex = 4575
        '
        'TIME_CAL_EFF
        '
        Me.TIME_CAL_EFF.Interval = 1000
        '
        'picStart
        '
        Me.picStart.BackgroundImage = CType(resources.GetObject("picStart.BackgroundImage"), System.Drawing.Image)
        Me.picStart.Location = New System.Drawing.Point(0, -1)
        Me.picStart.Name = "picStart"
        Me.picStart.Size = New System.Drawing.Size(803, 603)
        Me.picStart.TabIndex = 4570
        Me.picStart.TabStop = False
        '
        'Working_OEE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.picStart)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.WebView21)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbAccTarget)
        Me.Controls.Add(Me.CircularProgressBar4)
        Me.Controls.Add(Me.CircularProgressBar3)
        Me.Controls.Add(Me.CircularProgressBar1)
        Me.Controls.Add(Me.CircularProgressBar2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lvDetailAvailabillty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbOverTimePerformance)
        Me.Controls.Add(Me.lbOverTimeQuality)
        Me.Controls.Add(Me.lbOverTimeAvailability)
        Me.Controls.Add(Me.lbShiftQty)
        Me.Controls.Add(Me.lbShiftPlan)
        Me.Controls.Add(Me.lbLine)
        Me.Controls.Add(Me.lbPartName)
        Me.Controls.Add(Me.lbPartNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Working_OEE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Working_OEE"
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbPartNo As Label
    Friend WithEvents lbPartName As Label
    Friend WithEvents lbLine As Label
    Friend WithEvents lbShiftPlan As Label
    Friend WithEvents lbShiftQty As Label
    Friend WithEvents lbOverTimeAvailability As Label
    Friend WithEvents lbOverTimeQuality As Label
    Friend WithEvents lbOverTimePerformance As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lvDetailAvailabillty As ListView
    Friend WithEvents ListView1 As ListView
    Friend WithEvents CircularProgressBar2 As CircularProgressBar.CircularProgressBar
    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents CircularProgressBar3 As CircularProgressBar.CircularProgressBar
    Friend WithEvents CircularProgressBar4 As CircularProgressBar.CircularProgressBar
    Friend WithEvents lbAccTarget As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents btnBack As PictureBox
    Friend WithEvents btnInfo As PictureBox
    Friend WithEvents BtnStart As PictureBox
    Friend WithEvents btnStop As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer_new_dio As Timer
    Friend WithEvents TIME_CAL_EFF As Timer
    Friend WithEvents SerialPortLamp As IO.Ports.SerialPort
    Friend WithEvents picStart As PictureBox
End Class
