<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageusers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageusers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.users_list = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student = New System.Windows.Forms.Label()
        Me.selected = New System.Windows.Forms.Panel()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.view = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.users_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.selected.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1107, 59)
        Me.Panel3.TabIndex = 110
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Location = New System.Drawing.Point(11, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(143, 54)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "      Users"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'users_list
        '
        Me.users_list.AllowUserToAddRows = False
        Me.users_list.AllowUserToDeleteRows = False
        Me.users_list.AllowUserToResizeColumns = False
        Me.users_list.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.users_list.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.users_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.users_list.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.users_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.users_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.users_list.DefaultCellStyle = DataGridViewCellStyle2
        Me.users_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.users_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.users_list.GridColor = System.Drawing.Color.Silver
        Me.users_list.Location = New System.Drawing.Point(0, 59)
        Me.users_list.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.users_list.Name = "users_list"
        Me.users_list.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.users_list.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.users_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.users_list.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.users_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.users_list.ShowEditingIcon = False
        Me.users_list.ShowRowErrors = False
        Me.users_list.Size = New System.Drawing.Size(1107, 601)
        Me.users_list.TabIndex = 111
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Position"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Address"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 14.65593!
        Me.Column3.HeaderText = "Username"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.FillWeight = 10.15228!
        Me.Column4.HeaderText = "Password"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'student
        '
        Me.student.AutoSize = True
        Me.student.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.student.Location = New System.Drawing.Point(116, 17)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(193, 25)
        Me.student.TabIndex = 2
        Me.student.Text = "Lastname, Firstname"
        '
        'selected
        '
        Me.selected.Controls.Add(Me.btn_Add)
        Me.selected.Controls.Add(Me.btnedit)
        Me.selected.Controls.Add(Me.student)
        Me.selected.Controls.Add(Me.delete)
        Me.selected.Controls.Add(Me.Label23)
        Me.selected.Controls.Add(Me.view)
        Me.selected.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.selected.Location = New System.Drawing.Point(0, 605)
        Me.selected.Name = "selected"
        Me.selected.Size = New System.Drawing.Size(1107, 55)
        Me.selected.TabIndex = 112
        Me.selected.Visible = False
        '
        'btn_Add
        '
        Me.btn_Add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Add.Image = CType(resources.GetObject("btn_Add.Image"), System.Drawing.Image)
        Me.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Add.Location = New System.Drawing.Point(951, 10)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(144, 36)
        Me.btn_Add.TabIndex = 8
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedit.Location = New System.Drawing.Point(508, 10)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(143, 36)
        Me.btnedit.TabIndex = 7
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delete.Location = New System.Drawing.Point(806, 10)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(144, 36)
        Me.delete.TabIndex = 5
        Me.delete.Text = "     Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label23.Location = New System.Drawing.Point(3, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(139, 33)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Selected:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'view
        '
        Me.view.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.view.Image = CType(resources.GetObject("view.Image"), System.Drawing.Image)
        Me.view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.view.Location = New System.Drawing.Point(657, 10)
        Me.view.Name = "view"
        Me.view.Size = New System.Drawing.Size(143, 36)
        Me.view.TabIndex = 3
        Me.view.Text = "     View Profile"
        Me.view.UseVisualStyleBackColor = True
        '
        'manageusers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1107, 660)
        Me.Controls.Add(Me.selected)
        Me.Controls.Add(Me.users_list)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "manageusers"
        Me.Text = "Lan-based Student Information System - Manage User"
        Me.Panel3.ResumeLayout(False)
        CType(Me.users_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.selected.ResumeLayout(False)
        Me.selected.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents users_list As System.Windows.Forms.DataGridView
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents view As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents student As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents selected As System.Windows.Forms.Panel
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Add As System.Windows.Forms.Button
End Class
