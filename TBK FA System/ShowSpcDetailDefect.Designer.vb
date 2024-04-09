<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShowSpcDetailDefect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowSpcDetailDefect))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lvFG = New System.Windows.Forms.ListView()
        Me.lvCp = New System.Windows.Forms.ListView()
        Me.wi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partNO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.defectCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.wis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partNos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.defectCodes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.types = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qtys = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(12, 509)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 79)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lvFG
        '
        Me.lvFG.HideSelection = False
        Me.lvFG.Location = New System.Drawing.Point(25, 166)
        Me.lvFG.Name = "lvFG"
        Me.lvFG.Size = New System.Drawing.Size(679, 120)
        Me.lvFG.TabIndex = 1
        Me.lvFG.UseCompatibleStateImageBehavior = False
        '
        'lvCp
        '
        Me.lvCp.AllowColumnReorder = True
        Me.lvCp.AllowDrop = True
        Me.lvCp.AutoArrange = False
        Me.lvCp.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lvCp.BackgroundImageTiled = True
        Me.lvCp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvCp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.wi, Me.partNO, Me.defectCode, Me.type, Me.qty})
        Me.lvCp.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvCp.Font = New System.Drawing.Font("Catamaran", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCp.ForeColor = System.Drawing.Color.Black
        Me.lvCp.FullRowSelect = True
        Me.lvCp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvCp.HideSelection = False
        Me.lvCp.HoverSelection = True
        Me.lvCp.Location = New System.Drawing.Point(25, 375)
        Me.lvCp.MultiSelect = False
        Me.lvCp.Name = "lvCp"
        Me.lvCp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lvCp.ShowGroups = False
        Me.lvCp.Size = New System.Drawing.Size(679, 119)
        Me.lvCp.TabIndex = 65
        Me.lvCp.UseCompatibleStateImageBehavior = False
        Me.lvCp.View = System.Windows.Forms.View.Details
        '
        'wi
        '
        Me.wi.Text = "wi"
        Me.wi.Width = 83
        '
        'partNO
        '
        Me.partNO.Text = "CD"
        Me.partNO.Width = 109
        '
        'defectCode
        '
        Me.defectCode.Text = "Detail_TH"
        Me.defectCode.Width = 495
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.wis, Me.partNos, Me.defectCodes, Me.types, Me.qtys})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(25, 166)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(679, 120)
        Me.ListView1.TabIndex = 66
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ShowSpcDetailDefect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lvCp)
        Me.Controls.Add(Me.lvFG)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ShowSpcDetailDefect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShowSpcDetailDefect"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lvFG As ListView
    Friend WithEvents lvCp As ListView
    Friend WithEvents wi As ColumnHeader
    Friend WithEvents partNO As ColumnHeader
    Friend WithEvents defectCode As ColumnHeader
    Friend WithEvents type As ColumnHeader
    Friend WithEvents qty As ColumnHeader
    Friend WithEvents ListView1 As ListView
    Friend WithEvents wis As ColumnHeader
    Friend WithEvents partNos As ColumnHeader
    Friend WithEvents defectCodes As ColumnHeader
    Friend WithEvents types As ColumnHeader
    Friend WithEvents qtys As ColumnHeader
End Class
