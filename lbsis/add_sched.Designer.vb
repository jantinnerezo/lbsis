<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_sched
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_sched))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.position = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_day = New System.Windows.Forms.ComboBox()
        Me.cb_time = New System.Windows.Forms.TextBox()
        Me.cbteacher = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_time = New System.Windows.Forms.Label()
        Me.cb_subject = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_section = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sub_id = New System.Windows.Forms.Label()
        Me.sec_id = New System.Windows.Forms.Label()
        Me.g = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.schoolyear = New System.Windows.Forms.Label()
        Me.user_name = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel5.Size = New System.Drawing.Size(725, 55)
        Me.Panel5.TabIndex = 18
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cb_day)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.cb_time)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.cbteacher)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_time)
        Me.Panel1.Controls.Add(Me.cb_subject)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cb_section)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 266)
        Me.Panel1.TabIndex = 19
        '
        'cb_day
        '
        Me.cb_day.FormattingEnabled = True
        Me.cb_day.Items.AddRange(New Object() {"MWF", "TTH", "M - F"})
        Me.cb_day.Location = New System.Drawing.Point(368, 134)
        Me.cb_day.Name = "cb_day"
        Me.cb_day.Size = New System.Drawing.Size(308, 33)
        Me.cb_day.TabIndex = 22
        '
        'cb_time
        '
        Me.cb_time.Location = New System.Drawing.Point(373, 45)
        Me.cb_time.Name = "cb_time"
        Me.cb_time.Size = New System.Drawing.Size(303, 30)
        Me.cb_time.TabIndex = 21
        '
        'cbteacher
        '
        Me.cbteacher.FormattingEnabled = True
        Me.cbteacher.Location = New System.Drawing.Point(19, 210)
        Me.cbteacher.Name = "cbteacher"
        Me.cbteacher.Size = New System.Drawing.Size(308, 33)
        Me.cbteacher.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 25)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Teacher:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Day:"
        '
        'txt_time
        '
        Me.txt_time.AutoSize = True
        Me.txt_time.Location = New System.Drawing.Point(363, 15)
        Me.txt_time.Name = "txt_time"
        Me.txt_time.Size = New System.Drawing.Size(58, 25)
        Me.txt_time.TabIndex = 13
        Me.txt_time.Text = "Time:"
        '
        'cb_subject
        '
        Me.cb_subject.FormattingEnabled = True
        Me.cb_subject.Location = New System.Drawing.Point(19, 134)
        Me.cb_subject.Name = "cb_subject"
        Me.cb_subject.Size = New System.Drawing.Size(308, 33)
        Me.cb_subject.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Subject:"
        '
        'cb_section
        '
        Me.cb_section.FormattingEnabled = True
        Me.cb_section.Location = New System.Drawing.Point(19, 45)
        Me.cb_section.Name = "cb_section"
        Me.cb_section.Size = New System.Drawing.Size(308, 33)
        Me.cb_section.TabIndex = 10
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
        'sub_id
        '
        Me.sub_id.AutoSize = True
        Me.sub_id.Location = New System.Drawing.Point(440, 336)
        Me.sub_id.Name = "sub_id"
        Me.sub_id.Size = New System.Drawing.Size(99, 25)
        Me.sub_id.TabIndex = 9
        Me.sub_id.Text = "subject_id"
        Me.sub_id.Visible = False
        '
        'sec_id
        '
        Me.sec_id.AutoSize = True
        Me.sec_id.Location = New System.Drawing.Point(595, 336)
        Me.sec_id.Name = "sec_id"
        Me.sec_id.Size = New System.Drawing.Size(99, 25)
        Me.sec_id.TabIndex = 8
        Me.sec_id.Text = "section_id"
        Me.sec_id.Visible = False
        '
        'g
        '
        Me.g.AutoSize = True
        Me.g.Location = New System.Drawing.Point(293, 336)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(61, 25)
        Me.g.TabIndex = 22
        Me.g.Text = "glevel"
        Me.g.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = Global.lbsis.My.Resources.Resources.Cancel_24px
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(526, 210)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(150, 35)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Image = Global.lbsis.My.Resources.Resources.Plus_24px
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(368, 208)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(148, 35)
        Me.btn_add.TabIndex = 20
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
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
        Me.Label22.Text = "Schedule"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(440, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "School year:"
        '
        'schoolyear
        '
        Me.schoolyear.AutoSize = True
        Me.schoolyear.ForeColor = System.Drawing.Color.White
        Me.schoolyear.Location = New System.Drawing.Point(563, 19)
        Me.schoolyear.Name = "schoolyear"
        Me.schoolyear.Size = New System.Drawing.Size(30, 25)
        Me.schoolyear.TabIndex = 25
        Me.schoolyear.Text = "sy"
        '
        'user_name
        '
        Me.user_name.AutoSize = True
        Me.user_name.Location = New System.Drawing.Point(180, 336)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(98, 25)
        Me.user_name.TabIndex = 23
        Me.user_name.Text = "username"
        Me.user_name.Visible = False
        '
        'add_sched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 356)
        Me.Controls.Add(Me.user_name)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sec_id)
        Me.Controls.Add(Me.sub_id)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "add_sched"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan-based Student Information System - Add Schedule"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents sec_id As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sub_id As System.Windows.Forms.Label
    Friend WithEvents cb_section As System.Windows.Forms.ComboBox
    Friend WithEvents cb_subject As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_time As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbteacher As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents g As System.Windows.Forms.Label
    Friend WithEvents cb_time As System.Windows.Forms.TextBox
    Friend WithEvents cb_day As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents schoolyear As System.Windows.Forms.Label
    Friend WithEvents user_name As System.Windows.Forms.Label
End Class
