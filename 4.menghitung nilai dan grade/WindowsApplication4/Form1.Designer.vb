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
        Me.UH = New System.Windows.Forms.TextBox()
        Me.NT = New System.Windows.Forms.TextBox()
        Me.UTS = New System.Windows.Forms.TextBox()
        Me.UAS = New System.Windows.Forms.TextBox()
        Me.KH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GR = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UH
        '
        Me.UH.Location = New System.Drawing.Point(440, 93)
        Me.UH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UH.Name = "UH"
        Me.UH.Size = New System.Drawing.Size(89, 22)
        Me.UH.TabIndex = 0
        '
        'NT
        '
        Me.NT.Location = New System.Drawing.Point(440, 133)
        Me.NT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NT.Name = "NT"
        Me.NT.Size = New System.Drawing.Size(89, 22)
        Me.NT.TabIndex = 1
        '
        'UTS
        '
        Me.UTS.Location = New System.Drawing.Point(440, 173)
        Me.UTS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UTS.Name = "UTS"
        Me.UTS.Size = New System.Drawing.Size(89, 22)
        Me.UTS.TabIndex = 2
        '
        'UAS
        '
        Me.UAS.Location = New System.Drawing.Point(440, 209)
        Me.UAS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UAS.Name = "UAS"
        Me.UAS.Size = New System.Drawing.Size(89, 22)
        Me.UAS.TabIndex = 3
        '
        'KH
        '
        Me.KH.Location = New System.Drawing.Point(440, 251)
        Me.KH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.KH.Name = "KH"
        Me.KH.Size = New System.Drawing.Size(89, 22)
        Me.KH.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(289, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nilai UH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(289, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nilai Tugas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(289, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nilai UTS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(289, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nilai UAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(289, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Kehadiran"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(440, 299)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 34)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "="
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(289, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Grade"
        '
        'GR
        '
        Me.GR.Location = New System.Drawing.Point(368, 361)
        Me.GR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GR.Name = "GR"
        Me.GR.Size = New System.Drawing.Size(161, 22)
        Me.GR.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(798, 492)
        Me.Controls.Add(Me.GR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KH)
        Me.Controls.Add(Me.UAS)
        Me.Controls.Add(Me.UTS)
        Me.Controls.Add(Me.NT)
        Me.Controls.Add(Me.UH)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "ega"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UH As System.Windows.Forms.TextBox
    Friend WithEvents NT As System.Windows.Forms.TextBox
    Friend WithEvents UTS As System.Windows.Forms.TextBox
    Friend WithEvents UAS As System.Windows.Forms.TextBox
    Friend WithEvents KH As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GR As System.Windows.Forms.TextBox

End Class
