<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrationform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registrationform))
        Me.submit_btn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.regname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.regusername = New System.Windows.Forms.TextBox()
        Me.cbposition = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.regaddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.regpassword = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'submit_btn
        '
        Me.submit_btn.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.submit_btn.Image = CType(resources.GetObject("submit_btn.Image"), System.Drawing.Image)
        Me.submit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submit_btn.Location = New System.Drawing.Point(864, 323)
        Me.submit_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.Size = New System.Drawing.Size(108, 41)
        Me.submit_btn.TabIndex = 97
        Me.submit_btn.Text = "Submit"
        Me.submit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.submit_btn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(984, 68)
        Me.Panel3.TabIndex = 98
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Franklin Gothic Medium", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Location = New System.Drawing.Point(27, 8)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(289, 51)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Registration Form"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(20, 252)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 25)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Position:"
        '
        'regname
        '
        Me.regname.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regname.Location = New System.Drawing.Point(122, 103)
        Me.regname.Margin = New System.Windows.Forms.Padding(2)
        Me.regname.Name = "regname"
        Me.regname.Size = New System.Drawing.Size(215, 30)
        Me.regname.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Name:"
        '
        'regusername
        '
        Me.regusername.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regusername.Location = New System.Drawing.Point(122, 202)
        Me.regusername.Margin = New System.Windows.Forms.Padding(2)
        Me.regusername.Name = "regusername"
        Me.regusername.Size = New System.Drawing.Size(215, 30)
        Me.regusername.TabIndex = 65
        '
        'cbposition
        '
        Me.cbposition.FormattingEnabled = True
        Me.cbposition.Items.AddRange(New Object() {"Admin", "Teacher", "Registrar"})
        Me.cbposition.Location = New System.Drawing.Point(122, 152)
        Me.cbposition.Name = "cbposition"
        Me.cbposition.Size = New System.Drawing.Size(215, 33)
        Me.cbposition.TabIndex = 100
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(12, 88)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(960, 228)
        Me.Button6.TabIndex = 101
        Me.Button6.UseVisualStyleBackColor = False
        '
        'regaddress
        '
        Me.regaddress.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regaddress.Location = New System.Drawing.Point(478, 103)
        Me.regaddress.Margin = New System.Windows.Forms.Padding(2)
        Me.regaddress.Multiline = True
        Me.regaddress.Name = "regaddress"
        Me.regaddress.Size = New System.Drawing.Size(480, 179)
        Me.regaddress.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(376, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Address:"
        '
        'regpassword
        '
        Me.regpassword.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regpassword.Location = New System.Drawing.Point(122, 247)
        Me.regpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.regpassword.Name = "regpassword"
        Me.regpassword.Size = New System.Drawing.Size(215, 30)
        Me.regpassword.TabIndex = 105
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.submit.Image = CType(resources.GetObject("submit.Image"), System.Drawing.Image)
        Me.submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submit.Location = New System.Drawing.Point(864, 323)
        Me.submit.Margin = New System.Windows.Forms.Padding(4)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(108, 41)
        Me.submit.TabIndex = 106
        Me.submit.Text = "Submit"
        Me.submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.submit.UseVisualStyleBackColor = True
        Me.submit.Visible = False
        '
        'registrationform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(984, 374)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.regpassword)
        Me.Controls.Add(Me.regaddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbposition)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.submit_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.regusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.regname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "registrationform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan-based Student Information System - Registration Form"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents submit_btn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents regname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents regusername As System.Windows.Forms.TextBox
    Friend WithEvents cbposition As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents regaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents regpassword As System.Windows.Forms.TextBox
    Friend WithEvents submit As System.Windows.Forms.Button
End Class
