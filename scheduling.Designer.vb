<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scheduling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scheduling))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.position = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.school_year = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.TextBox()
        Me.s_id = New System.Windows.Forms.Label()
        Me.selected = New System.Windows.Forms.Panel()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.sched_list = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tcher = New System.Windows.Forms.Label()
        Me.subject = New System.Windows.Forms.Label()
        Me.sect = New System.Windows.Forms.Label()
        Me.adlaw = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.selected.SuspendLayout()
        CType(Me.sched_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.position)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1184, 62)
        Me.Panel5.TabIndex = 13
        '
        'position
        '
        Me.position.AutoSize = True
        Me.position.Location = New System.Drawing.Point(523, 30)
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
        Me.Label22.Location = New System.Drawing.Point(11, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(188, 39)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "      Schedule"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.school_year)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.search)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 62)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1184, 57)
        Me.Panel4.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(-2, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 27)
        Me.Label2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(779, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "School year:"
        '
        'school_year
        '
        Me.school_year.FormattingEnabled = True
        Me.school_year.Location = New System.Drawing.Point(902, 13)
        Me.school_year.Name = "school_year"
        Me.school_year.Size = New System.Drawing.Size(269, 33)
        Me.school_year.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.Location = New System.Drawing.Point(-218, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 35)
        Me.Label20.TabIndex = 8
        '
        'search
        '
        Me.search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(45, 13)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(217, 30)
        Me.search.TabIndex = 7
        '
        's_id
        '
        Me.s_id.AutoSize = True
        Me.s_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.s_id.Location = New System.Drawing.Point(18, 9)
        Me.s_id.Name = "s_id"
        Me.s_id.Size = New System.Drawing.Size(30, 25)
        Me.s_id.TabIndex = 9
        Me.s_id.Text = "ID"
        Me.s_id.Visible = False
        '
        'selected
        '
        Me.selected.Controls.Add(Me.time)
        Me.selected.Controls.Add(Me.adlaw)
        Me.selected.Controls.Add(Me.sect)
        Me.selected.Controls.Add(Me.subject)
        Me.selected.Controls.Add(Me.tcher)
        Me.selected.Controls.Add(Me.s_id)
        Me.selected.Controls.Add(Me.btn_add)
        Me.selected.Controls.Add(Me.btn_delete)
        Me.selected.Controls.Add(Me.btn_edit)
        Me.selected.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.selected.Location = New System.Drawing.Point(0, 617)
        Me.selected.Name = "selected"
        Me.selected.Size = New System.Drawing.Size(1184, 51)
        Me.selected.TabIndex = 14
        '
        'btn_add
        '
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(1041, 9)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(131, 36)
        Me.btn_add.TabIndex = 7
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(903, 9)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(132, 36)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "     Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        Me.btn_delete.Visible = False
        '
        'btn_edit
        '
        Me.btn_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(766, 9)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(131, 36)
        Me.btn_edit.TabIndex = 3
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        Me.btn_edit.Visible = False
        '
        'sched_list
        '
        Me.sched_list.AllowUserToAddRows = False
        Me.sched_list.AllowUserToDeleteRows = False
        Me.sched_list.AllowUserToResizeColumns = False
        Me.sched_list.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.sched_list.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.sched_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.sched_list.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.sched_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sched_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column7, Me.Column3, Me.Column4, Me.Column8})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sched_list.DefaultCellStyle = DataGridViewCellStyle2
        Me.sched_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sched_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.sched_list.GridColor = System.Drawing.Color.Silver
        Me.sched_list.Location = New System.Drawing.Point(0, 119)
        Me.sched_list.Name = "sched_list"
        Me.sched_list.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sched_list.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.sched_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.sched_list.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.sched_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sched_list.ShowEditingIcon = False
        Me.sched_list.ShowRowErrors = False
        Me.sched_list.Size = New System.Drawing.Size(1184, 498)
        Me.sched_list.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "sched_id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Section"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Subject"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Teacher"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Time"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Day"
        Me.Column8.MinimumWidth = 10
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'tcher
        '
        Me.tcher.AutoSize = True
        Me.tcher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tcher.Location = New System.Drawing.Point(202, 15)
        Me.tcher.Name = "tcher"
        Me.tcher.Size = New System.Drawing.Size(30, 25)
        Me.tcher.TabIndex = 10
        Me.tcher.Text = "ID"
        Me.tcher.Visible = False
        '
        'subject
        '
        Me.subject.AutoSize = True
        Me.subject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.subject.Location = New System.Drawing.Point(327, 20)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(30, 25)
        Me.subject.TabIndex = 11
        Me.subject.Text = "ID"
        Me.subject.Visible = False
        '
        'sect
        '
        Me.sect.AutoSize = True
        Me.sect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sect.Location = New System.Drawing.Point(577, 13)
        Me.sect.Name = "sect"
        Me.sect.Size = New System.Drawing.Size(30, 25)
        Me.sect.TabIndex = 12
        Me.sect.Text = "ID"
        Me.sect.Visible = False
        '
        'adlaw
        '
        Me.adlaw.AutoSize = True
        Me.adlaw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.adlaw.Location = New System.Drawing.Point(523, 15)
        Me.adlaw.Name = "adlaw"
        Me.adlaw.Size = New System.Drawing.Size(30, 25)
        Me.adlaw.TabIndex = 13
        Me.adlaw.Text = "ID"
        Me.adlaw.Visible = False
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.time.Location = New System.Drawing.Point(460, 15)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(30, 25)
        Me.time.TabIndex = 14
        Me.time.Text = "ID"
        Me.time.Visible = False
        '
        'scheduling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 668)
        Me.Controls.Add(Me.sched_list)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.selected)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "scheduling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan-based Satudent Information System - Schedule"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.selected.ResumeLayout(False)
        Me.selected.PerformLayout()
        CType(Me.sched_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents s_id As System.Windows.Forms.Label
    Friend WithEvents selected As System.Windows.Forms.Panel
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents sched_list As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents school_year As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents subject As System.Windows.Forms.Label
    Friend WithEvents tcher As System.Windows.Forms.Label
    Friend WithEvents time As System.Windows.Forms.Label
    Friend WithEvents adlaw As System.Windows.Forms.Label
    Friend WithEvents sect As System.Windows.Forms.Label
End Class
