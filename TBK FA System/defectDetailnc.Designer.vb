<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class defectDetailnc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(defectDetailnc))
        Me.lbType = New System.Windows.Forms.Label()
        Me.lvDefectdetails = New System.Windows.Forms.ListView()
        Me.NO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PARTNO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TYPE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CODE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DETAIL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.QTY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WI = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SEQ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pwi_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnUp = New System.Windows.Forms.PictureBox()
        Me.btnDown = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.btnOk = New System.Windows.Forms.PictureBox()
        CType(Me.btnUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbType
        '
        Me.lbType.AutoSize = True
        Me.lbType.BackColor = System.Drawing.Color.Transparent
        Me.lbType.Font = New System.Drawing.Font("Yu Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbType.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbType.Location = New System.Drawing.Point(700, 30)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(68, 45)
        Me.lbType.TabIndex = 2
        Me.lbType.Text = "XX"
        '
        'lvDefectdetails
        '
        Me.lvDefectdetails.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvDefectdetails.AllowColumnReorder = True
        Me.lvDefectdetails.AllowDrop = True
        Me.lvDefectdetails.AutoArrange = False
        Me.lvDefectdetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lvDefectdetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvDefectdetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NO, Me.PARTNO, Me.TYPE, Me.CODE, Me.DETAIL, Me.QTY, Me.WI, Me.SEQ, Me.pwi_id})
        Me.lvDefectdetails.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvDefectdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lvDefectdetails.ForeColor = System.Drawing.Color.White
        Me.lvDefectdetails.FullRowSelect = True
        Me.lvDefectdetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvDefectdetails.HideSelection = False
        Me.lvDefectdetails.Location = New System.Drawing.Point(33, 193)
        Me.lvDefectdetails.MultiSelect = False
        Me.lvDefectdetails.Name = "lvDefectdetails"
        Me.lvDefectdetails.ShowGroups = False
        Me.lvDefectdetails.Size = New System.Drawing.Size(640, 305)
        Me.lvDefectdetails.TabIndex = 37
        Me.lvDefectdetails.UseCompatibleStateImageBehavior = False
        Me.lvDefectdetails.View = System.Windows.Forms.View.Details
        '
        'NO
        '
        Me.NO.Text = "NO"
        Me.NO.Width = 52
        '
        'PARTNO
        '
        Me.PARTNO.Text = "PART NO"
        Me.PARTNO.Width = 162
        '
        'TYPE
        '
        Me.TYPE.Text = "TYPE"
        Me.TYPE.Width = 78
        '
        'CODE
        '
        Me.CODE.Text = "CODE"
        Me.CODE.Width = 83
        '
        'DETAIL
        '
        Me.DETAIL.Text = "DETAIL"
        Me.DETAIL.Width = 191
        '
        'QTY
        '
        Me.QTY.Text = "QTY"
        Me.QTY.Width = 74
        '
        'SEQ
        '
        Me.SEQ.Width = 0
        '
        'pwi_id
        '
        Me.pwi_id.Width = 0
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.Transparent
        Me.btnUp.Location = New System.Drawing.Point(682, 239)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(110, 111)
        Me.btnUp.TabIndex = 42
        Me.btnUp.TabStop = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.Transparent
        Me.btnDown.Location = New System.Drawing.Point(682, 352)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(110, 111)
        Me.btnDown.TabIndex = 43
        Me.btnDown.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Location = New System.Drawing.Point(9, 504)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 99)
        Me.btnBack.TabIndex = 44
        Me.btnBack.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Location = New System.Drawing.Point(682, 499)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(117, 99)
        Me.btnOk.TabIndex = 45
        Me.btnOk.TabStop = False
        '
        'defectDetailnc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lvDefectdetails)
        Me.Controls.Add(Me.lbType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "defectDetailnc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "defectDetailnc"
        CType(Me.btnUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbType As Label
	Friend WithEvents lvDefectdetails As ListView
	Friend WithEvents NO As ColumnHeader
	Friend WithEvents PARTNO As ColumnHeader
	Friend WithEvents TYPE As ColumnHeader
	Friend WithEvents CODE As ColumnHeader
	Friend WithEvents DETAIL As ColumnHeader
	Friend WithEvents QTY As ColumnHeader
	Friend WithEvents btnUp As PictureBox
	Friend WithEvents btnDown As PictureBox
	Friend WithEvents btnBack As PictureBox
	Friend WithEvents btnOk As PictureBox
    Friend WithEvents WI As ColumnHeader
    Friend WithEvents SEQ As ColumnHeader
    Friend WithEvents pwi_id As ColumnHeader
End Class
