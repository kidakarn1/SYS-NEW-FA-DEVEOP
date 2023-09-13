<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class defectHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(defectHome))
        Me.btn_back = New System.Windows.Forms.PictureBox()
        Me.btnAdjustnc = New System.Windows.Forms.PictureBox()
        Me.btnRegisternc = New System.Windows.Forms.PictureBox()
        Me.btnRegisterng = New System.Windows.Forms.PictureBox()
        Me.btnAdjustng = New System.Windows.Forms.PictureBox()
        CType(Me.btn_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdjustnc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRegisternc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRegisterng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdjustng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.Location = New System.Drawing.Point(12, 503)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(198, 98)
        Me.btn_back.TabIndex = 4565
        Me.btn_back.TabStop = False
        '
        'btnAdjustnc
        '
        Me.btnAdjustnc.BackColor = System.Drawing.Color.Transparent
        Me.btnAdjustnc.Location = New System.Drawing.Point(468, 200)
        Me.btnAdjustnc.Name = "btnAdjustnc"
        Me.btnAdjustnc.Size = New System.Drawing.Size(242, 126)
        Me.btnAdjustnc.TabIndex = 4566
        Me.btnAdjustnc.TabStop = False
        '
        'btnRegisternc
        '
        Me.btnRegisternc.BackColor = System.Drawing.Color.Transparent
        Me.btnRegisternc.Location = New System.Drawing.Point(88, 189)
        Me.btnRegisternc.Name = "btnRegisternc"
        Me.btnRegisternc.Size = New System.Drawing.Size(259, 149)
        Me.btnRegisternc.TabIndex = 4567
        Me.btnRegisternc.TabStop = False
        '
        'btnRegisterng
        '
        Me.btnRegisterng.BackColor = System.Drawing.Color.Transparent
        Me.btnRegisterng.Location = New System.Drawing.Point(88, 344)
        Me.btnRegisterng.Name = "btnRegisterng"
        Me.btnRegisterng.Size = New System.Drawing.Size(259, 153)
        Me.btnRegisterng.TabIndex = 4568
        Me.btnRegisterng.TabStop = False
        '
        'btnAdjustng
        '
        Me.btnAdjustng.BackColor = System.Drawing.Color.Transparent
        Me.btnAdjustng.Location = New System.Drawing.Point(468, 344)
        Me.btnAdjustng.Name = "btnAdjustng"
        Me.btnAdjustng.Size = New System.Drawing.Size(251, 137)
        Me.btnAdjustng.TabIndex = 4569
        Me.btnAdjustng.TabStop = False
        '
        'defectHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAdjustng)
        Me.Controls.Add(Me.btnRegisterng)
        Me.Controls.Add(Me.btnRegisternc)
        Me.Controls.Add(Me.btnAdjustnc)
        Me.Controls.Add(Me.btn_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "defectHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "g"
        CType(Me.btn_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdjustnc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRegisternc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRegisterng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdjustng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_back As PictureBox
	Friend WithEvents btnAdjustnc As PictureBox
	Friend WithEvents btnRegisternc As PictureBox
	Friend WithEvents btnRegisterng As PictureBox
	Friend WithEvents btnAdjustng As PictureBox
End Class
