<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrolledlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(enrolledlist))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbgradelevel = New System.Windows.Forms.ComboBox()
        Me.lbgradelevel = New System.Windows.Forms.Label()
        Me.lbam = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.final_enrolled = New System.Windows.Forms.DataGridView()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Teacher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selected = New System.Windows.Forms.Panel()
        Me.studlist_id = New System.Windows.Forms.Label()
        Me.stud_id = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.Button()
        Me.student = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.stud_status = New System.Windows.Forms.Label()
        Me.sect = New System.Windows.Forms.Label()
        Me.sched = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.final_enrolled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.selected.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.cbgradelevel)
        Me.Panel5.Controls.Add(Me.lbgradelevel)
        Me.Panel5.Controls.Add(Me.lbam)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1055, 49)
        Me.Panel5.TabIndex = 3
        '
        'cbgradelevel
        '
        Me.cbgradelevel.FormattingEnabled = True
        Me.cbgradelevel.Items.AddRange(New Object() {"All", "K1", "K2", "1", "2", "3", "4", "5", "6"})
        Me.cbgradelevel.Location = New System.Drawing.Point(963, 9)
        Me.cbgradelevel.Margin = New System.Windows.Forms.Padding(4)
        Me.cbgradelevel.Name = "cbgradelevel"
        Me.cbgradelevel.Size = New System.Drawing.Size(79, 33)
        Me.cbgradelevel.TabIndex = 11
        '
        'lbgradelevel
        '
        Me.lbgradelevel.AutoSize = True
        Me.lbgradelevel.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgradelevel.ForeColor = System.Drawing.Color.White
        Me.lbgradelevel.Location = New System.Drawing.Point(861, 12)
        Me.lbgradelevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbgradelevel.Name = "lbgradelevel"
        Me.lbgradelevel.Size = New System.Drawing.Size(118, 25)
        Me.lbgradelevel.TabIndex = 10
        Me.lbgradelevel.Text = "Grade Level:"
        '
        'lbam
        '
        Me.lbam.AutoSize = True
        Me.lbam.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbam.Location = New System.Drawing.Point(1511, 78)
        Me.lbam.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbam.Name = "lbam"
        Me.lbam.Size = New System.Drawing.Size(41, 25)
        Me.lbam.TabIndex = 9
        Me.lbam.Text = "Am"
        Me.lbam.Visible = False
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Location = New System.Drawing.Point(6, 4)
        Me.Label22.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(336, 45)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Enrolled Students List"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'final_enrolled
        '
        Me.final_enrolled.AllowUserToAddRows = False
        Me.final_enrolled.AllowUserToDeleteRows = False
        Me.final_enrolled.AllowUserToResizeColumns = False
        Me.final_enrolled.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.final_enrolled.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.final_enrolled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.final_enrolled.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.final_enrolled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.final_enrolled.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Subject, Me.Teacher, Me.id, Me.Column1})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.final_enrolled.DefaultCellStyle = DataGridViewCellStyle6
        Me.final_enrolled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.final_enrolled.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.final_enrolled.GridColor = System.Drawing.Color.Silver
        Me.final_enrolled.Location = New System.Drawing.Point(0, 49)
        Me.final_enrolled.Margin = New System.Windows.Forms.Padding(6)
        Me.final_enrolled.Name = "final_enrolled"
        Me.final_enrolled.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.final_enrolled.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.final_enrolled.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.final_enrolled.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.final_enrolled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.final_enrolled.ShowEditingIcon = False
        Me.final_enrolled.ShowRowErrors = False
        Me.final_enrolled.Size = New System.Drawing.Size(1055, 506)
        Me.final_enrolled.TabIndex = 4
        '
        'Subject
        '
        Me.Subject.HeaderText = "Name"
        Me.Subject.Name = "Subject"
        Me.Subject.ReadOnly = True
        '
        'Teacher
        '
        Me.Teacher.HeaderText = "Grade Level"
        Me.Teacher.Name = "Teacher"
        Me.Teacher.ReadOnly = True
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "studlist_id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'selected
        '
        Me.selected.BackColor = System.Drawing.Color.White
        Me.selected.Controls.Add(Me.studlist_id)
        Me.selected.Controls.Add(Me.stud_id)
        Me.selected.Controls.Add(Me.delete)
        Me.selected.Controls.Add(Me.student)
        Me.selected.Controls.Add(Me.Label23)
        Me.selected.Location = New System.Drawing.Point(12, 503)
        Me.selected.Name = "selected"
        Me.selected.Size = New System.Drawing.Size(1031, 40)
        Me.selected.TabIndex = 7
        Me.selected.Visible = False
        '
        'studlist_id
        '
        Me.studlist_id.AutoSize = True
        Me.studlist_id.Location = New System.Drawing.Point(382, 6)
        Me.studlist_id.Name = "studlist_id"
        Me.studlist_id.Size = New System.Drawing.Size(28, 25)
        Me.studlist_id.TabIndex = 13
        Me.studlist_id.Text = "id"
        Me.studlist_id.Visible = False
        '
        'stud_id
        '
        Me.stud_id.AutoSize = True
        Me.stud_id.Location = New System.Drawing.Point(348, 6)
        Me.stud_id.Name = "stud_id"
        Me.stud_id.Size = New System.Drawing.Size(28, 25)
        Me.stud_id.TabIndex = 12
        Me.stud_id.Text = "id"
        Me.stud_id.Visible = False
        '
        'delete
        '
        Me.delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delete.Location = New System.Drawing.Point(455, 2)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(144, 36)
        Me.delete.TabIndex = 6
        Me.delete.Text = "   Unenroll"
        Me.delete.UseVisualStyleBackColor = True
        '
        'student
        '
        Me.student.AutoSize = True
        Me.student.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.student.Location = New System.Drawing.Point(114, 8)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(193, 25)
        Me.student.TabIndex = 2
        Me.student.Text = "Lastname, Firstname"
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label23.Location = New System.Drawing.Point(3, 2)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(139, 33)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Selected:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'stud_status
        '
        Me.stud_status.AutoSize = True
        Me.stud_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stud_status.Location = New System.Drawing.Point(174, 428)
        Me.stud_status.Name = "stud_status"
        Me.stud_status.Size = New System.Drawing.Size(118, 25)
        Me.stud_status.TabIndex = 14
        Me.stud_status.Text = "Not Enrolled"
        Me.stud_status.Visible = False
        '
        'sect
        '
        Me.sect.AutoSize = True
        Me.sect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sect.Location = New System.Drawing.Point(360, 403)
        Me.sect.Name = "sect"
        Me.sect.Size = New System.Drawing.Size(24, 25)
        Me.sect.TabIndex = 15
        Me.sect.Text = "1"
        Me.sect.Visible = False
        '
        'sched
        '
        Me.sched.AutoSize = True
        Me.sched.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sched.Location = New System.Drawing.Point(511, 403)
        Me.sched.Name = "sched"
        Me.sched.Size = New System.Drawing.Size(47, 25)
        Me.sched.TabIndex = 16
        Me.sched.Text = "N/A"
        Me.sched.Visible = False
        '
        'enrolledlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1055, 555)
        Me.Controls.Add(Me.sched)
        Me.Controls.Add(Me.sect)
        Me.Controls.Add(Me.stud_status)
        Me.Controls.Add(Me.selected)
        Me.Controls.Add(Me.final_enrolled)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "enrolledlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan-based Student Information System - Enrolled List"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.final_enrolled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.selected.ResumeLayout(False)
        Me.selected.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbam As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents final_enrolled As System.Windows.Forms.DataGridView
    Friend WithEvents cbgradelevel As System.Windows.Forms.ComboBox
    Friend WithEvents lbgradelevel As System.Windows.Forms.Label
    Friend WithEvents selected As System.Windows.Forms.Panel
    Friend WithEvents student As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents stud_id As System.Windows.Forms.Label
    Friend WithEvents stud_status As System.Windows.Forms.Label
    Friend WithEvents sect As System.Windows.Forms.Label
    Friend WithEvents sched As System.Windows.Forms.Label
    Friend WithEvents Subject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Teacher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents studlist_id As System.Windows.Forms.Label
End Class
