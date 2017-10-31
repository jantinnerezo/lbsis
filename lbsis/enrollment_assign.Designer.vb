<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrollment_assign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(enrollment_assign))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.stud_status = New System.Windows.Forms.Label()
        Me.position = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cb_sect = New System.Windows.Forms.ComboBox()
        Me.sec_id = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.grade_level = New System.Windows.Forms.ComboBox()
        Me.btn_enroll = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_glevel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stud_id = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.stud_status)
        Me.Panel5.Controls.Add(Me.position)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(387, 54)
        Me.Panel5.TabIndex = 21
        '
        'stud_status
        '
        Me.stud_status.AutoSize = True
        Me.stud_status.Location = New System.Drawing.Point(186, 19)
        Me.stud_status.Name = "stud_status"
        Me.stud_status.Size = New System.Drawing.Size(83, 25)
        Me.stud_status.TabIndex = 6
        Me.stud_status.Text = "Enrolled"
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
        Me.Label22.Text = "Enroll"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_sect
        '
        Me.cb_sect.FormattingEnabled = True
        Me.cb_sect.Location = New System.Drawing.Point(18, 179)
        Me.cb_sect.Name = "cb_sect"
        Me.cb_sect.Size = New System.Drawing.Size(329, 33)
        Me.cb_sect.TabIndex = 4
        '
        'sec_id
        '
        Me.sec_id.AutoSize = True
        Me.sec_id.Location = New System.Drawing.Point(207, 57)
        Me.sec_id.Name = "sec_id"
        Me.sec_id.Size = New System.Drawing.Size(66, 25)
        Me.sec_id.TabIndex = 20
        Me.sec_id.Text = "sec_id"
        Me.sec_id.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.grade_level)
        Me.Panel1.Controls.Add(Me.btn_enroll)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cb_glevel)
        Me.Panel1.Controls.Add(Me.cb_sect)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 306)
        Me.Panel1.TabIndex = 19
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = Global.lbsis.My.Resources.Resources.Cancel_24px
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(178, 238)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(169, 35)
        Me.btn_cancel.TabIndex = 24
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'grade_level
        '
        Me.grade_level.FormattingEnabled = True
        Me.grade_level.Items.AddRange(New Object() {"K1", "K2", "1", "2", "3", "4", "5", "6"})
        Me.grade_level.Location = New System.Drawing.Point(18, 98)
        Me.grade_level.Name = "grade_level"
        Me.grade_level.Size = New System.Drawing.Size(329, 33)
        Me.grade_level.TabIndex = 28
        '
        'btn_enroll
        '
        Me.btn_enroll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_enroll.Image = CType(resources.GetObject("btn_enroll.Image"), System.Drawing.Image)
        Me.btn_enroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enroll.Location = New System.Drawing.Point(18, 238)
        Me.btn_enroll.Name = "btn_enroll"
        Me.btn_enroll.Size = New System.Drawing.Size(152, 36)
        Me.btn_enroll.TabIndex = 23
        Me.btn_enroll.Text = "Enroll"
        Me.btn_enroll.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Update Grade Level:"
        '
        'cb_glevel
        '
        Me.cb_glevel.AutoSize = True
        Me.cb_glevel.Location = New System.Drawing.Point(189, 23)
        Me.cb_glevel.Name = "cb_glevel"
        Me.cb_glevel.Size = New System.Drawing.Size(71, 25)
        Me.cb_glevel.TabIndex = 26
        Me.cb_glevel.Text = "Label5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Current Grade level:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Section:"
        '
        'stud_id
        '
        Me.stud_id.AutoSize = True
        Me.stud_id.Location = New System.Drawing.Point(272, 57)
        Me.stud_id.Name = "stud_id"
        Me.stud_id.Size = New System.Drawing.Size(75, 25)
        Me.stud_id.TabIndex = 25
        Me.stud_id.Text = "stud_id"
        Me.stud_id.Visible = False
        '
        'enrollment_assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 395)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stud_id)
        Me.Controls.Add(Me.sec_id)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "enrollment_assign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan-based Student Information System - Enrollment"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cb_sect As System.Windows.Forms.ComboBox
    Friend WithEvents sec_id As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_enroll As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents stud_id As System.Windows.Forms.Label
    Friend WithEvents stud_status As System.Windows.Forms.Label
    Friend WithEvents cb_glevel As System.Windows.Forms.Label
    Friend WithEvents grade_level As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
