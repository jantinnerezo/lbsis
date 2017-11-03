<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subject
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subject))
        Me.subject_list = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade_level = New System.Windows.Forms.Label()
        Me.subject_name = New System.Windows.Forms.Label()
        Me.s_id = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.glevel = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.position = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.selected = New System.Windows.Forms.Panel()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_section = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.subject_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.selected.SuspendLayout()
        Me.SuspendLayout()
        '
        'subject_list
        '
        Me.subject_list.AllowUserToAddRows = False
        Me.subject_list.AllowUserToDeleteRows = False
        Me.subject_list.AllowUserToResizeColumns = False
        Me.subject_list.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.subject_list.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.subject_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.subject_list.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.subject_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subject_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.subject_list.DefaultCellStyle = DataGridViewCellStyle2
        Me.subject_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.subject_list.GridColor = System.Drawing.Color.Silver
        Me.subject_list.Location = New System.Drawing.Point(0, 130)
        Me.subject_list.Name = "subject_list"
        Me.subject_list.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.subject_list.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.subject_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.subject_list.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.subject_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.subject_list.ShowEditingIcon = False
        Me.subject_list.ShowRowErrors = False
        Me.subject_list.Size = New System.Drawing.Size(691, 480)
        Me.subject_list.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "Subject"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Grade level"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'grade_level
        '
        Me.grade_level.AutoSize = True
        Me.grade_level.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grade_level.Location = New System.Drawing.Point(509, 19)
        Me.grade_level.Name = "grade_level"
        Me.grade_level.Size = New System.Drawing.Size(30, 25)
        Me.grade_level.TabIndex = 12
        Me.grade_level.Text = "ID"
        Me.grade_level.Visible = False
        '
        'subject_name
        '
        Me.subject_name.AutoSize = True
        Me.subject_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.subject_name.Location = New System.Drawing.Point(473, 19)
        Me.subject_name.Name = "subject_name"
        Me.subject_name.Size = New System.Drawing.Size(30, 25)
        Me.subject_name.TabIndex = 11
        Me.subject_name.Text = "ID"
        Me.subject_name.Visible = False
        '
        's_id
        '
        Me.s_id.AutoSize = True
        Me.s_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.s_id.Location = New System.Drawing.Point(401, 19)
        Me.s_id.Name = "s_id"
        Me.s_id.Size = New System.Drawing.Size(30, 25)
        Me.s_id.TabIndex = 9
        Me.s_id.Text = "ID"
        Me.s_id.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.glevel)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.search)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(696, 56)
        Me.Panel4.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(300, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Grade level:"
        '
        'glevel
        '
        Me.glevel.FormattingEnabled = True
        Me.glevel.Items.AddRange(New Object() {"K1", "K2", "1", "2", "3", "4", "5", "6"})
        Me.glevel.Location = New System.Drawing.Point(419, 13)
        Me.glevel.Name = "glevel"
        Me.glevel.Size = New System.Drawing.Size(269, 33)
        Me.glevel.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.Location = New System.Drawing.Point(12, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 34)
        Me.Label20.TabIndex = 4
        '
        'search
        '
        Me.search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(59, 16)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(217, 30)
        Me.search.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.grade_level)
        Me.Panel5.Controls.Add(Me.subject_name)
        Me.Panel5.Controls.Add(Me.position)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.s_id)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(696, 68)
        Me.Panel5.TabIndex = 9
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
        Me.Label22.Text = "Subjects"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selected
        '
        Me.selected.Controls.Add(Me.btn_delete)
        Me.selected.Controls.Add(Me.btn_edit)
        Me.selected.Controls.Add(Me.btn_section)
        Me.selected.Controls.Add(Me.btn_add)
        Me.selected.Location = New System.Drawing.Point(12, 616)
        Me.selected.Name = "selected"
        Me.selected.Size = New System.Drawing.Size(679, 51)
        Me.selected.TabIndex = 10
        '
        'btn_add
        '
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(384, 5)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(143, 36)
        Me.btn_add.TabIndex = 7
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_section
        '
        Me.btn_section.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_section.Image = CType(resources.GetObject("btn_section.Image"), System.Drawing.Image)
        Me.btn_section.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_section.Location = New System.Drawing.Point(533, 6)
        Me.btn_section.Name = "btn_section"
        Me.btn_section.Size = New System.Drawing.Size(143, 36)
        Me.btn_section.TabIndex = 8
        Me.btn_section.Text = "Section"
        Me.btn_section.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(85, 6)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(143, 36)
        Me.btn_edit.TabIndex = 3
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(235, 6)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(143, 36)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "  Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 669)
        Me.Controls.Add(Me.subject_list)
        Me.Controls.Add(Me.selected)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "subject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan-based Satudent Information System - Subjects"
        CType(Me.subject_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.selected.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents subject_list As System.Windows.Forms.DataGridView
    Friend WithEvents s_id As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents grade_level As System.Windows.Forms.Label
    Friend WithEvents subject_name As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents glevel As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selected As System.Windows.Forms.Panel
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_section As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
End Class
