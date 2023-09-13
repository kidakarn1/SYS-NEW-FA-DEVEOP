<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StopMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBreakTime = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.TimerLossBT = New System.Windows.Forms.Timer(Me.components)
        Me.PanelShowLoss = New System.Windows.Forms.Panel()
        Me.test_time_loss_time = New System.Windows.Forms.Label()
        Me.lbLossCode = New System.Windows.Forms.Label()
        Me.lbEndCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbStartCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelShowLoss.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBreakTime
        '
        Me.btnBreakTime.BackColor = System.Drawing.Color.OrangeRed
        Me.btnBreakTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 48.0!)
        Me.btnBreakTime.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBreakTime.Location = New System.Drawing.Point(49, 259)
        Me.btnBreakTime.Name = "btnBreakTime"
        Me.btnBreakTime.Size = New System.Drawing.Size(546, 201)
        Me.btnBreakTime.TabIndex = 8
        Me.btnBreakTime.Text = "Break Time"
        Me.btnBreakTime.UseVisualStyleBackColor = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnContinue.Font = New System.Drawing.Font("Arial Rounded MT Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnContinue.Location = New System.Drawing.Point(48, 25)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(546, 201)
        Me.btnContinue.TabIndex = 7
        Me.btnContinue.Text = "Continue Work"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'TimerLossBT
        '
        '
        'PanelShowLoss
        '
        Me.PanelShowLoss.Controls.Add(Me.test_time_loss_time)
        Me.PanelShowLoss.Controls.Add(Me.lbLossCode)
        Me.PanelShowLoss.Controls.Add(Me.lbEndCount)
        Me.PanelShowLoss.Controls.Add(Me.Label4)
        Me.PanelShowLoss.Controls.Add(Me.lbStartCount)
        Me.PanelShowLoss.Controls.Add(Me.Label3)
        Me.PanelShowLoss.Controls.Add(Me.Label2)
        Me.PanelShowLoss.Controls.Add(Me.Label1)
        Me.PanelShowLoss.Location = New System.Drawing.Point(33, 245)
        Me.PanelShowLoss.Name = "PanelShowLoss"
        Me.PanelShowLoss.Size = New System.Drawing.Size(589, 226)
        Me.PanelShowLoss.TabIndex = 9
        Me.PanelShowLoss.Visible = False
        '
        'test_time_loss_time
        '
        Me.test_time_loss_time.AutoSize = True
        Me.test_time_loss_time.BackColor = System.Drawing.Color.Black
        Me.test_time_loss_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.test_time_loss_time.ForeColor = System.Drawing.Color.White
        Me.test_time_loss_time.Location = New System.Drawing.Point(395, 67)
        Me.test_time_loss_time.Name = "test_time_loss_time"
        Me.test_time_loss_time.Size = New System.Drawing.Size(180, 25)
        Me.test_time_loss_time.TabIndex = 13
        Me.test_time_loss_time.Text = "XXXXXXXXXXXX"
        Me.test_time_loss_time.Visible = False
        '
        'lbLossCode
        '
        Me.lbLossCode.AutoSize = True
        Me.lbLossCode.BackColor = System.Drawing.Color.Black
        Me.lbLossCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLossCode.ForeColor = System.Drawing.Color.White
        Me.lbLossCode.Location = New System.Drawing.Point(182, 67)
        Me.lbLossCode.Name = "lbLossCode"
        Me.lbLossCode.Size = New System.Drawing.Size(82, 25)
        Me.lbLossCode.TabIndex = 12
        Me.lbLossCode.Text = "XXXXX"
        '
        'lbEndCount
        '
        Me.lbEndCount.AutoSize = True
        Me.lbEndCount.BackColor = System.Drawing.Color.Black
        Me.lbEndCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEndCount.ForeColor = System.Drawing.Color.White
        Me.lbEndCount.Location = New System.Drawing.Point(374, 180)
        Me.lbEndCount.Name = "lbEndCount"
        Me.lbEndCount.Size = New System.Drawing.Size(55, 25)
        Me.lbEndCount.TabIndex = 11
        Me.lbEndCount.Text = "H:i:s"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "LOSS CODE : "
        '
        'lbStartCount
        '
        Me.lbStartCount.AutoSize = True
        Me.lbStartCount.BackColor = System.Drawing.Color.Black
        Me.lbStartCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStartCount.ForeColor = System.Drawing.Color.White
        Me.lbStartCount.Location = New System.Drawing.Point(374, 124)
        Me.lbStartCount.Name = "lbStartCount"
        Me.lbStartCount.Size = New System.Drawing.Size(55, 25)
        Me.lbStartCount.TabIndex = 9
        Me.lbStartCount.Text = "H:i:s"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(348, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "START BREAK TIME COUNTING : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(62, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(473, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "BREAK TIME - LOSS COUNTING AUTOMATICS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "END BREAK TIME COUNTING : "
        '
        'StopMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(654, 497)
        Me.Controls.Add(Me.PanelShowLoss)
        Me.Controls.Add(Me.btnBreakTime)
        Me.Controls.Add(Me.btnContinue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StopMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StopMenu"
        Me.PanelShowLoss.ResumeLayout(False)
        Me.PanelShowLoss.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBreakTime As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents TimerLossBT As Timer
    Friend WithEvents PanelShowLoss As Panel
    Friend WithEvents test_time_loss_time As Label
    Friend WithEvents lbLossCode As Label
    Friend WithEvents lbEndCount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbStartCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
