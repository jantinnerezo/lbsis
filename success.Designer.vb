<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class success
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(success))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.level = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adviser = New System.Windows.Forms.Label()
        Me.section = New System.Windows.Forms.Label()
        Me.student = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.list = New System.Windows.Forms.Label()
        Me.position = New System.Windows.Forms.Label()
        Me.success_list = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panel_note = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sy = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.success_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panel_note.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.list)
        Me.Panel5.Controls.Add(Me.position)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1290, 221)
        Me.Panel5.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.sy)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.level)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.adviser)
        Me.Panel1.Controls.Add(Me.section)
        Me.Panel1.Controls.Add(Me.student)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1266, 100)
        Me.Panel1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Grade Level:"
        '
        'level
        '
        Me.level.AutoSize = True
        Me.level.ForeColor = System.Drawing.Color.Black
        Me.level.Location = New System.Drawing.Point(150, 53)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(51, 25)
        Me.level.TabIndex = 14
        Me.level.Text = "level"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(472, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Section:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(472, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Adviser:"
        '
        'adviser
        '
        Me.adviser.AutoSize = True
        Me.adviser.ForeColor = System.Drawing.Color.Black
        Me.adviser.Location = New System.Drawing.Point(558, 53)
        Me.adviser.Name = "adviser"
        Me.adviser.Size = New System.Drawing.Size(80, 25)
        Me.adviser.TabIndex = 10
        Me.adviser.Text = "Adviser:"
        '
        'section
        '
        Me.section.AutoSize = True
        Me.section.ForeColor = System.Drawing.Color.Black
        Me.section.Location = New System.Drawing.Point(558, 17)
        Me.section.Name = "section"
        Me.section.Size = New System.Drawing.Size(80, 25)
        Me.section.TabIndex = 8
        Me.section.Text = "Section:"
        '
        'student
        '
        Me.student.AutoSize = True
        Me.student.ForeColor = System.Drawing.Color.Black
        Me.student.Location = New System.Drawing.Point(100, 17)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(193, 25)
        Me.student.TabIndex = 7
        Me.student.Text = "Lastname, Firstname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name:"
        '
        'list
        '
        Me.list.AutoSize = True
        Me.list.Font = New System.Drawing.Font("Sitka Display", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list.ForeColor = System.Drawing.Color.Black
        Me.list.Location = New System.Drawing.Point(427, 163)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(427, 48)
        Me.list.TabIndex = 6
        Me.list.Text = "List of Subjects and Schedule"
        Me.list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'success_list
        '
        Me.success_list.AllowUserToAddRows = False
        Me.success_list.AllowUserToDeleteRows = False
        Me.success_list.AllowUserToResizeColumns = False
        Me.success_list.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.success_list.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.success_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.success_list.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.success_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.success_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.success_list.DefaultCellStyle = DataGridViewCellStyle6
        Me.success_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.success_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.success_list.GridColor = System.Drawing.Color.Silver
        Me.success_list.Location = New System.Drawing.Point(0, 221)
        Me.success_list.Name = "success_list"
        Me.success_list.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.success_list.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.success_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.success_list.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.success_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.success_list.ShowEditingIcon = False
        Me.success_list.ShowRowErrors = False
        Me.success_list.Size = New System.Drawing.Size(1290, 490)
        Me.success_list.TabIndex = 27
        '
        'Column1
        '
        Me.Column1.HeaderText = "Subjects"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Teacher"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Day"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Time"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.panel_note)
        Me.Panel2.Controls.Add(Me.btn_submit)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Location = New System.Drawing.Point(0, 519)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1290, 192)
        Me.Panel2.TabIndex = 30
        '
        'panel_note
        '
        Me.panel_note.BackColor = System.Drawing.Color.SteelBlue
        Me.panel_note.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panel_note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_note.Controls.Add(Me.Label8)
        Me.panel_note.Controls.Add(Me.Label7)
        Me.panel_note.Controls.Add(Me.Label6)
        Me.panel_note.Controls.Add(Me.Label2)
        Me.panel_note.Location = New System.Drawing.Point(12, 30)
        Me.panel_note.Name = "panel_note"
        Me.panel_note.Size = New System.Drawing.Size(642, 135)
        Me.panel_note.TabIndex = 16
        Me.panel_note.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(87, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(489, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Every end of the month schedule of monthly celebration"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(87, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(399, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Every 15th day of the month – Monthly Exam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(87, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(410, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Every Friday – MAPEH/Character ED (CE/EPP)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Note:"
        '
        'btn_submit
        '
        Me.btn_submit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_submit.Image = CType(resources.GetObject("btn_submit.Image"), System.Drawing.Image)
        Me.btn_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_submit.Location = New System.Drawing.Point(1163, 121)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(115, 36)
        Me.btn_submit.TabIndex = 30
        Me.btn_submit.Text = "Exit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(571, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 25)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Label18"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(884, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "School Year:"
        '
        'sy
        '
        Me.sy.AutoSize = True
        Me.sy.ForeColor = System.Drawing.Color.Black
        Me.sy.Location = New System.Drawing.Point(1009, 17)
        Me.sy.Name = "sy"
        Me.sy.Size = New System.Drawing.Size(30, 25)
        Me.sy.TabIndex = 16
        Me.sy.Text = "sy"
        '
        'success
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1290, 711)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.success_list)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "success"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan-based Student Information System - Enrollment Successful"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.success_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panel_note.ResumeLayout(False)
        Me.panel_note.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents list As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents section As System.Windows.Forms.Label
    Friend WithEvents student As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents adviser As System.Windows.Forms.Label
    Friend WithEvents success_list As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents level As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents panel_note As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents sy As System.Windows.Forms.Label
End Class
