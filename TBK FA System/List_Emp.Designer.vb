﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class List_Emp
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.lb_count_emp = New System.Windows.Forms.Label()
        Me.flag_emp = New System.Windows.Forms.Label()
        Me.lb_link = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.AllowDrop = True
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListView1.Font = New System.Drawing.Font("Catamaran", 19.25!, System.Drawing.FontStyle.Bold)
        Me.ListView1.ForeColor = System.Drawing.Color.Navy
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(18, 163)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Scrollable = False
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(529, 400)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Emp CD"
        Me.ColumnHeader1.Width = 41
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name - Surname"
        Me.ColumnHeader2.Width = 351
        '
        'Timer1
        '
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(27, 467)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 26
        Me.ListBox1.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(153, 467)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 27
        Me.ListBox2.Visible = False
        '
        'lb_count_emp
        '
        Me.lb_count_emp.AutoSize = True
        Me.lb_count_emp.BackColor = System.Drawing.Color.White
        Me.lb_count_emp.Location = New System.Drawing.Point(132, 575)
        Me.lb_count_emp.Name = "lb_count_emp"
        Me.lb_count_emp.Size = New System.Drawing.Size(13, 13)
        Me.lb_count_emp.TabIndex = 28
        Me.lb_count_emp.Text = "0"
        Me.lb_count_emp.Visible = False
        '
        'flag_emp
        '
        Me.flag_emp.AutoSize = True
        Me.flag_emp.BackColor = System.Drawing.Color.White
        Me.flag_emp.Location = New System.Drawing.Point(113, 575)
        Me.flag_emp.Name = "flag_emp"
        Me.flag_emp.Size = New System.Drawing.Size(13, 13)
        Me.flag_emp.TabIndex = 29
        Me.flag_emp.Text = "0"
        Me.flag_emp.Visible = False
        '
        'lb_link
        '
        Me.lb_link.AutoSize = True
        Me.lb_link.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lb_link.Location = New System.Drawing.Point(314, 496)
        Me.lb_link.Name = "lb_link"
        Me.lb_link.Size = New System.Drawing.Size(37, 13)
        Me.lb_link.TabIndex = 30
        Me.lb_link.Text = "lb_link"
        Me.lb_link.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(643, 276)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 130)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(643, 431)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 143)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(643, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 133)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Catamaran", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(589, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 37)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(417, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(594, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 4632
        Me.Label1.Text = "Label1"
        '
        'List_Emp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BackgroundImage = Global.TBK_FA_System.My.Resources.Resources.manageEmp2
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lb_link)
        Me.Controls.Add(Me.flag_emp)
        Me.Controls.Add(Me.lb_count_emp)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "List_Emp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ำ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents lb_count_emp As Label
    Friend WithEvents flag_emp As Label
    Friend WithEvents lb_link As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
End Class
