<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anecdotal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anecdotal))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.violator_name = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.violation_time = New System.Windows.Forms.DateTimePicker()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.user_name = New System.Windows.Forms.Label()
        Me.student_id = New System.Windows.Forms.Label()
        Me.cancel = New System.Windows.Forms.Button()
        Me.submit = New System.Windows.Forms.Button()
        Me.violation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.violation_date = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.violations = New System.Windows.Forms.DataGridView()
        Me.idid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_added = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selected = New System.Windows.Forms.Panel()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.violation_id = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.position = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.schoolyear = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sy = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.violations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.selected.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'violator_name
        '
        Me.violator_name.Location = New System.Drawing.Point(20, 46)
        Me.violator_name.Name = "violator_name"
        Me.violator_name.ReadOnly = True
        Me.violator_name.Size = New System.Drawing.Size(204, 30)
        Me.violator_name.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.violation_time)
        Me.GroupBox1.Controls.Add(Me.update_btn)
        Me.GroupBox1.Controls.Add(Me.user_name)
        Me.GroupBox1.Controls.Add(Me.student_id)
        Me.GroupBox1.Controls.Add(Me.cancel)
        Me.GroupBox1.Controls.Add(Me.submit)
        Me.GroupBox1.Controls.Add(Me.violation)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.violation_date)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.violator_name)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 429)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(18, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 25)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "      Time of Violation"
        '
        'violation_time
        '
        Me.violation_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.violation_time.Location = New System.Drawing.Point(23, 124)
        Me.violation_time.Name = "violation_time"
        Me.violation_time.Size = New System.Drawing.Size(204, 30)
        Me.violation_time.TabIndex = 139
        Me.violation_time.Value = New Date(2017, 10, 25, 15, 2, 0, 0)
        '
        'update_btn
        '
        Me.update_btn.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.Image = CType(resources.GetObject("update_btn.Image"), System.Drawing.Image)
        Me.update_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.update_btn.Location = New System.Drawing.Point(241, 375)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(115, 36)
        Me.update_btn.TabIndex = 138
        Me.update_btn.Text = "Update"
        Me.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.update_btn.UseVisualStyleBackColor = True
        Me.update_btn.Visible = False
        '
        'user_name
        '
        Me.user_name.AutoSize = True
        Me.user_name.Location = New System.Drawing.Point(122, 386)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(102, 25)
        Me.user_name.TabIndex = 12
        Me.user_name.Text = "teacher_id"
        Me.user_name.Visible = False
        '
        'student_id
        '
        Me.student_id.AutoSize = True
        Me.student_id.Location = New System.Drawing.Point(28, 386)
        Me.student_id.Name = "student_id"
        Me.student_id.Size = New System.Drawing.Size(102, 25)
        Me.student_id.TabIndex = 10
        Me.student_id.Text = "student_id"
        Me.student_id.Visible = False
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel.Location = New System.Drawing.Point(362, 375)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(116, 35)
        Me.cancel.TabIndex = 9
        Me.cancel.Text = "   Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'submit
        '
        Me.submit.Image = CType(resources.GetObject("submit.Image"), System.Drawing.Image)
        Me.submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submit.Location = New System.Drawing.Point(240, 375)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(116, 35)
        Me.submit.TabIndex = 8
        Me.submit.Text = "   Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'violation
        '
        Me.violation.Location = New System.Drawing.Point(20, 214)
        Me.violation.Multiline = True
        Me.violation.Name = "violation"
        Me.violation.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.violation.Size = New System.Drawing.Size(458, 148)
        Me.violation.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(17, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "     Violation"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'violation_date
        '
        Me.violation_date.Location = New System.Drawing.Point(272, 44)
        Me.violation_date.Name = "violation_date"
        Me.violation_date.Size = New System.Drawing.Size(204, 30)
        Me.violation_date.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(267, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "      Date of Violation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      Name of Violator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'violations
        '
        Me.violations.AllowUserToAddRows = False
        Me.violations.AllowUserToDeleteRows = False
        Me.violations.AllowUserToResizeColumns = False
        Me.violations.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.violations.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.violations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.violations.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.violations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.violations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.violations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idid, Me.t_id, Me.v_id, Me.Lastname, Me.date_added, Me.v_time})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.violations.DefaultCellStyle = DataGridViewCellStyle6
        Me.violations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.violations.GridColor = System.Drawing.Color.Silver
        Me.violations.Location = New System.Drawing.Point(513, 95)
        Me.violations.Name = "violations"
        Me.violations.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.violations.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.violations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.violations.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.violations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.violations.ShowEditingIcon = False
        Me.violations.ShowRowErrors = False
        Me.violations.Size = New System.Drawing.Size(625, 334)
        Me.violations.TabIndex = 4
        '
        'idid
        '
        Me.idid.FillWeight = 101.5228!
        Me.idid.HeaderText = "id"
        Me.idid.Name = "idid"
        Me.idid.ReadOnly = True
        Me.idid.Visible = False
        '
        't_id
        '
        Me.t_id.HeaderText = "t_id"
        Me.t_id.Name = "t_id"
        Me.t_id.ReadOnly = True
        Me.t_id.Visible = False
        '
        'v_id
        '
        Me.v_id.HeaderText = "v_id"
        Me.v_id.Name = "v_id"
        Me.v_id.ReadOnly = True
        Me.v_id.Visible = False
        '
        'Lastname
        '
        Me.Lastname.FillWeight = 98.47716!
        Me.Lastname.HeaderText = "Violation"
        Me.Lastname.Name = "Lastname"
        Me.Lastname.ReadOnly = True
        '
        'date_added
        '
        Me.date_added.HeaderText = "Date"
        Me.date_added.Name = "date_added"
        Me.date_added.ReadOnly = True
        '
        'v_time
        '
        Me.v_time.HeaderText = "Time"
        Me.v_time.Name = "v_time"
        Me.v_time.ReadOnly = True
        '
        'selected
        '
        Me.selected.Controls.Add(Me.btnedit)
        Me.selected.Controls.Add(Me.violation_id)
        Me.selected.Controls.Add(Me.Label23)
        Me.selected.Location = New System.Drawing.Point(513, 435)
        Me.selected.Name = "selected"
        Me.selected.Size = New System.Drawing.Size(625, 40)
        Me.selected.TabIndex = 113
        Me.selected.Visible = False
        '
        'btnedit
        '
        Me.btnedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedit.Location = New System.Drawing.Point(477, 0)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(143, 36)
        Me.btnedit.TabIndex = 7
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'violation_id
        '
        Me.violation_id.AutoSize = True
        Me.violation_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.violation_id.Location = New System.Drawing.Point(143, 8)
        Me.violation_id.Name = "violation_id"
        Me.violation_id.Size = New System.Drawing.Size(30, 25)
        Me.violation_id.TabIndex = 2
        Me.violation_id.Text = "ID"
        Me.violation_id.Visible = False
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label23.Location = New System.Drawing.Point(22, 3)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(139, 33)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Selected:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label23.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(508, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "     Violations"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.schoolyear)
        Me.Panel5.Controls.Add(Me.position)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1145, 51)
        Me.Panel5.TabIndex = 114
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
        Me.Label22.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Location = New System.Drawing.Point(-2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(354, 51)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Student Violation"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'schoolyear
        '
        Me.schoolyear.AutoSize = True
        Me.schoolyear.ForeColor = System.Drawing.Color.White
        Me.schoolyear.Location = New System.Drawing.Point(1016, 15)
        Me.schoolyear.Name = "schoolyear"
        Me.schoolyear.Size = New System.Drawing.Size(30, 25)
        Me.schoolyear.TabIndex = 27
        Me.schoolyear.Text = "sy"
        Me.schoolyear.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(824, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 25)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "SY:"
        '
        'sy
        '
        Me.sy.FormattingEnabled = True
        Me.sy.Items.AddRange(New Object() {"K1", "K2", "1", "2", "3", "4", "5", "6"})
        Me.sy.Location = New System.Drawing.Point(869, 56)
        Me.sy.Name = "sy"
        Me.sy.Size = New System.Drawing.Size(269, 33)
        Me.sy.TabIndex = 115
        '
        'Anecdotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 493)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.sy)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.selected)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.violations)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Anecdotal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan-based Student Information System - Anecdotal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.violations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.selected.ResumeLayout(False)
        Me.selected.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents violator_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents violation As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents violation_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents student_id As System.Windows.Forms.Label
    Friend WithEvents user_name As System.Windows.Forms.Label
    Friend WithEvents violations As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents selected As System.Windows.Forms.Panel
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents violation_id As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents update_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents violation_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents idid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_added As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v_time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents schoolyear As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents sy As System.Windows.Forms.ComboBox
End Class
