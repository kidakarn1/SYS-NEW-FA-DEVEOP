<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFA))
        Me.pic_StartProd = New System.Windows.Forms.PictureBox()
        Me.pic_Admin = New System.Windows.Forms.PictureBox()
        Me.pic_config = New System.Windows.Forms.PictureBox()
        Me.pic_shutdown = New System.Windows.Forms.PictureBox()
        Me.pic_addWorker = New System.Windows.Forms.PictureBox()
        Me.pic_Showworker = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pic_StartProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Admin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_config, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_shutdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_addWorker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Showworker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pic_StartProd
        '
        Me.pic_StartProd.BackColor = System.Drawing.Color.Transparent
        Me.pic_StartProd.Location = New System.Drawing.Point(13, 156)
        Me.pic_StartProd.Name = "pic_StartProd"
        Me.pic_StartProd.Size = New System.Drawing.Size(561, 238)
        Me.pic_StartProd.TabIndex = 0
        Me.pic_StartProd.TabStop = False
        '
        'pic_Admin
        '
        Me.pic_Admin.BackColor = System.Drawing.Color.Transparent
        Me.pic_Admin.Location = New System.Drawing.Point(8, 398)
        Me.pic_Admin.Name = "pic_Admin"
        Me.pic_Admin.Size = New System.Drawing.Size(283, 177)
        Me.pic_Admin.TabIndex = 1
        Me.pic_Admin.TabStop = False
        '
        'pic_config
        '
        Me.pic_config.BackColor = System.Drawing.Color.Transparent
        Me.pic_config.Location = New System.Drawing.Point(294, 399)
        Me.pic_config.Name = "pic_config"
        Me.pic_config.Size = New System.Drawing.Size(283, 177)
        Me.pic_config.TabIndex = 2
        Me.pic_config.TabStop = False
        '
        'pic_shutdown
        '
        Me.pic_shutdown.BackColor = System.Drawing.Color.Transparent
        Me.pic_shutdown.Location = New System.Drawing.Point(579, 155)
        Me.pic_shutdown.Name = "pic_shutdown"
        Me.pic_shutdown.Size = New System.Drawing.Size(217, 421)
        Me.pic_shutdown.TabIndex = 3
        Me.pic_shutdown.TabStop = False
        '
        'pic_addWorker
        '
        Me.pic_addWorker.BackColor = System.Drawing.Color.Transparent
        Me.pic_addWorker.Location = New System.Drawing.Point(657, 10)
        Me.pic_addWorker.Name = "pic_addWorker"
        Me.pic_addWorker.Size = New System.Drawing.Size(131, 114)
        Me.pic_addWorker.TabIndex = 4
        Me.pic_addWorker.TabStop = False
        '
        'pic_Showworker
        '
        Me.pic_Showworker.BackColor = System.Drawing.Color.Transparent
        Me.pic_Showworker.Location = New System.Drawing.Point(8, 10)
        Me.pic_Showworker.Name = "pic_Showworker"
        Me.pic_Showworker.Size = New System.Drawing.Size(125, 84)
        Me.pic_Showworker.TabIndex = 5
        Me.pic_Showworker.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(233, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 98)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "XXXXXX"
        '
        'MainFA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pic_Showworker)
        Me.Controls.Add(Me.pic_addWorker)
        Me.Controls.Add(Me.pic_shutdown)
        Me.Controls.Add(Me.pic_config)
        Me.Controls.Add(Me.pic_Admin)
        Me.Controls.Add(Me.pic_StartProd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainFA"
        Me.Text = "MainFA"
        CType(Me.pic_StartProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Admin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_config, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_shutdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_addWorker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Showworker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic_StartProd As PictureBox
    Friend WithEvents pic_Admin As PictureBox
    Friend WithEvents pic_config As PictureBox
    Friend WithEvents pic_shutdown As PictureBox
    Friend WithEvents pic_addWorker As PictureBox
    Friend WithEvents pic_Showworker As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
