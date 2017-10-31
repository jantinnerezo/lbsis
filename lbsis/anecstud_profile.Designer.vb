<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class anecstud_profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(anecstud_profile))
        Me.idid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_prof = New System.Windows.Forms.DataGridView()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stud_id = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.stud_name = New System.Windows.Forms.Label()
        CType(Me.student_prof, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'idid
        '
        Me.idid.FillWeight = 101.5228!
        Me.idid.HeaderText = "id"
        Me.idid.Name = "idid"
        Me.idid.ReadOnly = True
        Me.idid.Width = 150
        '
        'student_prof
        '
        Me.student_prof.AllowUserToAddRows = False
        Me.student_prof.AllowUserToDeleteRows = False
        Me.student_prof.AllowUserToResizeColumns = False
        Me.student_prof.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.student_prof.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.student_prof.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.student_prof.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.student_prof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.student_prof.ColumnHeadersVisible = False
        Me.student_prof.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idid, Me.Lastname})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.student_prof.DefaultCellStyle = DataGridViewCellStyle6
        Me.student_prof.Dock = System.Windows.Forms.DockStyle.Fill
        Me.student_prof.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.student_prof.GridColor = System.Drawing.Color.Silver
        Me.student_prof.Location = New System.Drawing.Point(0, 51)
        Me.student_prof.Name = "student_prof"
        Me.student_prof.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.student_prof.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.student_prof.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.student_prof.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.student_prof.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.student_prof.ShowEditingIcon = False
        Me.student_prof.ShowRowErrors = False
        Me.student_prof.Size = New System.Drawing.Size(447, 519)
        Me.student_prof.TabIndex = 4
        '
        'Lastname
        '
        Me.Lastname.FillWeight = 98.47716!
        Me.Lastname.HeaderText = "Section"
        Me.Lastname.Name = "Lastname"
        Me.Lastname.ReadOnly = True
        Me.Lastname.Width = 280
        '
        'stud_id
        '
        Me.stud_id.AutoSize = True
        Me.stud_id.Location = New System.Drawing.Point(493, 9)
        Me.stud_id.Name = "stud_id"
        Me.stud_id.Size = New System.Drawing.Size(71, 25)
        Me.stud_id.TabIndex = 1
        Me.stud_id.Text = "Label2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.stud_id)
        Me.Panel1.Controls.Add(Me.stud_name)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 51)
        Me.Panel1.TabIndex = 3
        '
        'stud_name
        '
        Me.stud_name.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_name.ForeColor = System.Drawing.Color.White
        Me.stud_name.Image = CType(resources.GetObject("stud_name.Image"), System.Drawing.Image)
        Me.stud_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stud_name.Location = New System.Drawing.Point(8, 6)
        Me.stud_name.Name = "stud_name"
        Me.stud_name.Size = New System.Drawing.Size(438, 39)
        Me.stud_name.TabIndex = 0
        Me.stud_name.Text = "        Label1"
        Me.stud_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'anecstud_profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 570)
        Me.Controls.Add(Me.student_prof)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "anecstud_profile"
        Me.Text = "Lan-based Student Information System - Student_profile"
        CType(Me.student_prof, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents idid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents student_prof As System.Windows.Forms.DataGridView
    Friend WithEvents Lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stud_id As System.Windows.Forms.Label
    Friend WithEvents stud_name As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
