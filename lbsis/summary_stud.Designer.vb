<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class summary_stud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(summary_stud))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sy = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.violations = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.position = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.idid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_added = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.violations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(551, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 21)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "SY:"
        '
        'sy
        '
        Me.sy.FormattingEnabled = True
        Me.sy.Items.AddRange(New Object() {"K1", "K2", "1", "2", "3", "4", "5", "6"})
        Me.sy.Location = New System.Drawing.Point(596, 56)
        Me.sy.Name = "sy"
        Me.sy.Size = New System.Drawing.Size(269, 29)
        Me.sy.TabIndex = 119
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(12, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 21)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "     Violations"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'violations
        '
        Me.violations.AllowUserToAddRows = False
        Me.violations.AllowUserToDeleteRows = False
        Me.violations.AllowUserToResizeColumns = False
        Me.violations.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.violations.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.violations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.violations.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.violations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.violations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.violations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idid, Me.t_id, Me.v_id, Me.s, Me.Lastname, Me.date_added, Me.v_time})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.violations.DefaultCellStyle = DataGridViewCellStyle2
        Me.violations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.violations.GridColor = System.Drawing.Color.Silver
        Me.violations.Location = New System.Drawing.Point(12, 95)
        Me.violations.Name = "violations"
        Me.violations.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.violations.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.violations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.violations.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.violations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.violations.ShowEditingIcon = False
        Me.violations.ShowRowErrors = False
        Me.violations.Size = New System.Drawing.Size(853, 334)
        Me.violations.TabIndex = 117
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
        Me.Panel5.Size = New System.Drawing.Size(877, 50)
        Me.Panel5.TabIndex = 121
        '
        'position
        '
        Me.position.AutoSize = True
        Me.position.Location = New System.Drawing.Point(571, 30)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(66, 21)
        Me.position.TabIndex = 1
        Me.position.Text = "Label18"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Location = New System.Drawing.Point(-25, 5)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(205, 39)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Summary"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        's
        '
        Me.s.HeaderText = "Student"
        Me.s.Name = "s"
        Me.s.ReadOnly = True
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
        'summary_stud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 442)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.sy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.violations)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "summary_stud"
        Me.Text = "Lan-based Student Information System - Summary of Violations"
        CType(Me.violations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents sy As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents violations As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents idid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_added As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v_time As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
