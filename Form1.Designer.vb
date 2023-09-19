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
        Me.btnghi = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtghiten = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnoidung = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rd1 = New System.Windows.Forms.RadioButton()
        Me.rd2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnghi
        '
        Me.btnghi.Location = New System.Drawing.Point(569, 115)
        Me.btnghi.Name = "btnghi"
        Me.btnghi.Size = New System.Drawing.Size(75, 26)
        Me.btnghi.TabIndex = 0
        Me.btnghi.Text = "Ghi File"
        Me.btnghi.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(569, 342)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 26)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rd2)
        Me.GroupBox1.Controls.Add(Me.rd1)
        Me.GroupBox1.Location = New System.Drawing.Point(214, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 56)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtghiten
        '
        Me.txtghiten.Location = New System.Drawing.Point(214, 119)
        Me.txtghiten.Multiline = True
        Me.txtghiten.Name = "txtghiten"
        Me.txtghiten.Size = New System.Drawing.Size(296, 20)
        Me.txtghiten.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ghi Dữ Liệu Xuống File"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên File"
        '
        'txtnoidung
        '
        Me.txtnoidung.Location = New System.Drawing.Point(214, 285)
        Me.txtnoidung.Multiline = True
        Me.txtnoidung.Name = "txtnoidung"
        Me.txtnoidung.Size = New System.Drawing.Size(296, 121)
        Me.txtnoidung.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nội Dung"
        '
        'rd1
        '
        Me.rd1.AutoSize = True
        Me.rd1.Location = New System.Drawing.Point(25, 20)
        Me.rd1.Name = "rd1"
        Me.rd1.Size = New System.Drawing.Size(64, 17)
        Me.rd1.TabIndex = 0
        Me.rd1.TabStop = True
        Me.rd1.Text = "Ghi Nhớ"
        Me.rd1.UseVisualStyleBackColor = True
        '
        'rd2
        '
        Me.rd2.AutoSize = True
        Me.rd2.Location = New System.Drawing.Point(192, 19)
        Me.rd2.Name = "rd2"
        Me.rd2.Size = New System.Drawing.Size(93, 17)
        Me.rd2.TabIndex = 0
        Me.rd2.TabStop = True
        Me.rd2.Text = "Ghi Thêm Vào"
        Me.rd2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnoidung)
        Me.Controls.Add(Me.txtghiten)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnghi)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnghi As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtghiten As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnoidung As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rd2 As RadioButton
    Friend WithEvents rd1 As RadioButton
End Class
