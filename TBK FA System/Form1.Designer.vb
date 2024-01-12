<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.widthText = New System.Windows.Forms.TextBox()
        Me.HeightText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument31 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument32 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(280, 310)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(298, 158)
        Me.PrintButton.TabIndex = 0
        Me.PrintButton.Text = "Button1"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(164, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(530, 170)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'widthText
        '
        Me.widthText.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.25!)
        Me.widthText.Location = New System.Drawing.Point(164, 201)
        Me.widthText.Name = "widthText"
        Me.widthText.Size = New System.Drawing.Size(246, 62)
        Me.widthText.TabIndex = 2
        '
        'HeightText
        '
        Me.HeightText.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.25!)
        Me.HeightText.Location = New System.Drawing.Point(448, 201)
        Me.HeightText.Name = "HeightText"
        Me.HeightText.Size = New System.Drawing.Size(246, 62)
        Me.HeightText.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(667, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'PrintDocument31
        '
        '
        'PrintDocument32
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HeightText)
        Me.Controls.Add(Me.widthText)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PrintButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintButton As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents widthText As TextBox
    Friend WithEvents HeightText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument31 As Printing.PrintDocument
    Friend WithEvents PrintDocument32 As Printing.PrintDocument
End Class
