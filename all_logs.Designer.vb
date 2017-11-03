<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class all_logs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(all_logs))
        Me.log_list = New System.Windows.Forms.DataGridView()
        Me.idid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.position = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.log_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'log_list
        '
        Me.log_list.AllowUserToAddRows = False
        Me.log_list.AllowUserToDeleteRows = False
        Me.log_list.AllowUserToResizeColumns = False
        Me.log_list.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.log_list.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.log_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.log_list.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.log_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.log_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.log_list.ColumnHeadersVisible = False
        Me.log_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idid, Me.t_id, Me.v_id})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.log_list.DefaultCellStyle = DataGridViewCellStyle2
        Me.log_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.log_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.log_list.GridColor = System.Drawing.Color.Silver
        Me.log_list.Location = New System.Drawing.Point(0, 110)
        Me.log_list.Name = "log_list"
        Me.log_list.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.log_list.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.log_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.log_list.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.log_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.log_list.ShowEditingIcon = False
        Me.log_list.ShowRowErrors = False
        Me.log_list.Size = New System.Drawing.Size(1119, 352)
        Me.log_list.TabIndex = 5
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
        '
        'v_id
        '
        Me.v_id.HeaderText = "v_id"
        Me.v_id.Name = "v_id"
        Me.v_id.ReadOnly = True
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
        Me.Panel5.Size = New System.Drawing.Size(1119, 66)
        Me.Panel5.TabIndex = 19
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
        Me.Label22.Location = New System.Drawing.Point(12, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(205, 49)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Logs"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.Location = New System.Drawing.Point(788, -12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(145, 71)
        Me.Label20.TabIndex = 21
        '
        'search
        '
        Me.search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(888, 7)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(217, 30)
        Me.search.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.search)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1119, 44)
        Me.Panel1.TabIndex = 22
        '
        'all_logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 462)
        Me.Controls.Add(Me.log_list)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "all_logs"
        Me.Text = "all_logs"
        CType(Me.log_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents log_list As System.Windows.Forms.DataGridView
    Friend WithEvents idid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
