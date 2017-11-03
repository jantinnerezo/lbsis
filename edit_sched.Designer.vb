<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_sched
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_sched))
        Me.cbed_day = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sec_id = New System.Windows.Forms.Label()
        Me.cbedteacher = New System.Windows.Forms.ComboBox()
        Me.sub_id = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.position = New System.Windows.Forms.Label()
        Me.cbed_subject = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.schoolyear = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbed_time = New System.Windows.Forms.TextBox()
        Me.txt_time = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbed_section = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.s_id = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.g = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbed_day
        '
        Me.cbed_day.FormattingEnabled = True
        Me.cbed_day.Items.AddRange(New Object() {"MWF", "TTH", "M - F"})
        Me.cbed_day.Location = New System.Drawing.Point(603, 79)
        Me.cbed_day.Name = "cbed_day"
        Me.cbed_day.Size = New System.Drawing.Size(308, 33)
        Me.cbed_day.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(487, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Day:"
        '
        'sec_id
        '
        Me.sec_id.AutoSize = True
        Me.sec_id.Location = New System.Drawing.Point(440, 258)
        Me.sec_id.Name = "sec_id"
        Me.sec_id.Size = New System.Drawing.Size(99, 25)
        Me.sec_id.TabIndex = 23
        Me.sec_id.Text = "section_id"
        Me.sec_id.Visible = False
        '
        'cbedteacher
        '
        Me.cbedteacher.FormattingEnabled = True
        Me.cbedteacher.Location = New System.Drawing.Point(138, 132)
        Me.cbedteacher.Name = "cbedteacher"
        Me.cbedteacher.Size = New System.Drawing.Size(308, 33)
        Me.cbedteacher.TabIndex = 20
        '
        'sub_id
        '
        Me.sub_id.AutoSize = True
        Me.sub_id.Location = New System.Drawing.Point(440, 283)
        Me.sub_id.Name = "sub_id"
        Me.sub_id.Size = New System.Drawing.Size(99, 25)
        Me.sub_id.TabIndex = 24
        Me.sub_id.Text = "subject_id"
        Me.sub_id.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 25)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Teacher:"
        '
        'position
        '
        Me.position.AutoSize = True
        Me.position.Location = New System.Drawing.Point(571, 30)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(83, 25)
        Me.position.TabIndex = 1
        Me.position.Text = "Label18"
        '
        'cbed_subject
        '
        Me.cbed_subject.FormattingEnabled = True
        Me.cbed_subject.Location = New System.Drawing.Point(138, 79)
        Me.cbed_subject.Name = "cbed_subject"
        Me.cbed_subject.Size = New System.Drawing.Size(308, 33)
        Me.cbed_subject.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.schoolyear)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.position)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(948, 68)
        Me.Panel5.TabIndex = 25
        '
        'schoolyear
        '
        Me.schoolyear.AutoSize = True
        Me.schoolyear.ForeColor = System.Drawing.Color.White
        Me.schoolyear.Location = New System.Drawing.Point(734, 23)
        Me.schoolyear.Name = "schoolyear"
        Me.schoolyear.Size = New System.Drawing.Size(30, 25)
        Me.schoolyear.TabIndex = 27
        Me.schoolyear.Text = "sy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(611, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "School year:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Location = New System.Drawing.Point(12, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(205, 39)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "      Schedule"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbed_time)
        Me.Panel1.Controls.Add(Me.cbedteacher)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cbed_day)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_time)
        Me.Panel1.Controls.Add(Me.cbed_subject)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbed_section)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 181)
        Me.Panel1.TabIndex = 26
        '
        'cbed_time
        '
        Me.cbed_time.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbed_time.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbed_time.Location = New System.Drawing.Point(603, 15)
        Me.cbed_time.Name = "cbed_time"
        Me.cbed_time.Size = New System.Drawing.Size(308, 30)
        Me.cbed_time.TabIndex = 21
        '
        'txt_time
        '
        Me.txt_time.AutoSize = True
        Me.txt_time.Location = New System.Drawing.Point(479, 15)
        Me.txt_time.Name = "txt_time"
        Me.txt_time.Size = New System.Drawing.Size(58, 25)
        Me.txt_time.TabIndex = 13
        Me.txt_time.Text = "Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Subject:"
        '
        'cbed_section
        '
        Me.cbed_section.FormattingEnabled = True
        Me.cbed_section.Location = New System.Drawing.Point(138, 15)
        Me.cbed_section.Name = "cbed_section"
        Me.cbed_section.Size = New System.Drawing.Size(308, 33)
        Me.cbed_section.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Section:"
        '
        's_id
        '
        Me.s_id.AutoSize = True
        Me.s_id.Location = New System.Drawing.Point(311, 261)
        Me.s_id.Name = "s_id"
        Me.s_id.Size = New System.Drawing.Size(47, 25)
        Me.s_id.TabIndex = 29
        Me.s_id.Text = "s_id"
        Me.s_id.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = Global.lbsis.My.Resources.Resources.Cancel_24px
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(825, 261)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(115, 35)
        Me.btn_cancel.TabIndex = 28
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Image = Global.lbsis.My.Resources.Resources.Edit_File_28px
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(704, 261)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(115, 35)
        Me.btn_add.TabIndex = 27
        Me.btn_add.Text = "    Update"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'g
        '
        Me.g.AutoSize = True
        Me.g.Location = New System.Drawing.Point(27, 266)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(22, 25)
        Me.g.TabIndex = 30
        Me.g.Text = "g"
        Me.g.Visible = False
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Location = New System.Drawing.Point(164, 261)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(71, 25)
        Me.username.TabIndex = 31
        Me.username.Text = "Label2"
        Me.username.Visible = False
        '
        'edit_sched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 305)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.s_id)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.sec_id)
        Me.Controls.Add(Me.sub_id)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "edit_sched"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan-based Student Information System - Edit Schedule"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbed_day As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents sec_id As System.Windows.Forms.Label
    Friend WithEvents cbedteacher As System.Windows.Forms.ComboBox
    Friend WithEvents sub_id As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents cbed_subject As System.Windows.Forms.ComboBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_time As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbed_section As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents s_id As System.Windows.Forms.Label
    Friend WithEvents cbed_time As System.Windows.Forms.TextBox
    Friend WithEvents g As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents schoolyear As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
