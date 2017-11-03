<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userprofile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userprofile))
        Me.idid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_prof = New System.Windows.Forms.DataGridView()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stud_name = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.user_prof, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'user_prof
        '
        Me.user_prof.AllowUserToAddRows = False
        Me.user_prof.AllowUserToDeleteRows = False
        Me.user_prof.AllowUserToResizeColumns = False
        Me.user_prof.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.user_prof.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.user_prof.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.user_prof.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.user_prof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.user_prof.ColumnHeadersVisible = False
        Me.user_prof.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idid, Me.Lastname})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.user_prof.DefaultCellStyle = DataGridViewCellStyle2
        Me.user_prof.Dock = System.Windows.Forms.DockStyle.Top
        Me.user_prof.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.user_prof.GridColor = System.Drawing.Color.Silver
        Me.user_prof.Location = New System.Drawing.Point(0, 80)
        Me.user_prof.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.user_prof.Name = "user_prof"
        Me.user_prof.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.user_prof.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.user_prof.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.user_prof.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.user_prof.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.user_prof.ShowEditingIcon = False
        Me.user_prof.ShowRowErrors = False
        Me.user_prof.Size = New System.Drawing.Size(352, 554)
        Me.user_prof.TabIndex = 4
        '
        'Lastname
        '
        Me.Lastname.FillWeight = 98.47716!
        Me.Lastname.HeaderText = "Lastname"
        Me.Lastname.Name = "Lastname"
        Me.Lastname.ReadOnly = True
        Me.Lastname.Width = 280
        '
        'stud_name
        '
        Me.stud_name.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_name.ForeColor = System.Drawing.Color.White
        Me.stud_name.Image = CType(resources.GetObject("stud_name.Image"), System.Drawing.Image)
        Me.stud_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stud_name.Location = New System.Drawing.Point(11, 10)
        Me.stud_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.stud_name.Name = "stud_name"
        Me.stud_name.Size = New System.Drawing.Size(603, 61)
        Me.stud_name.TabIndex = 0
        Me.stud_name.Text = "        Label1"
        Me.stud_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.stud_name)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 80)
        Me.Panel1.TabIndex = 3
        '
        'userprofile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 380)
        Me.Controls.Add(Me.user_prof)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "userprofile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lan-based Student Information System - User Profile"
        CType(Me.user_prof, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents idid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_prof As System.Windows.Forms.DataGridView
    Friend WithEvents Lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stud_name As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
