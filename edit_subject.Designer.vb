<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_subject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_subject))
        Me.cbed_level = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbed_teacher = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_id = New System.Windows.Forms.Label()
        Me.txted_subj = New System.Windows.Forms.TextBox()
        Me.position = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbed_level
        '
        Me.cbed_level.FormattingEnabled = True
        Me.cbed_level.Items.AddRange(New Object() {"K1", "K2", "1", "2", "3", "4", "5", "6"})
        Me.cbed_level.Location = New System.Drawing.Point(122, 110)
        Me.cbed_level.Name = "cbed_level"
        Me.cbed_level.Size = New System.Drawing.Size(111, 33)
        Me.cbed_level.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Grade level:"
        '
        'cbed_teacher
        '
        Me.cbed_teacher.FormattingEnabled = True
        Me.cbed_teacher.Location = New System.Drawing.Point(122, 9)
        Me.cbed_teacher.Name = "cbed_teacher"
        Me.cbed_teacher.Size = New System.Drawing.Size(268, 33)
        Me.cbed_teacher.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Teacher:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Subject:"
        '
        't_id
        '
        Me.t_id.AutoSize = True
        Me.t_id.Location = New System.Drawing.Point(306, 110)
        Me.t_id.Name = "t_id"
        Me.t_id.Size = New System.Drawing.Size(105, 25)
        Me.t_id.TabIndex = 8
        Me.t_id.Text = "Teacher_id"
        Me.t_id.Visible = False
        '
        'txted_subj
        '
        Me.txted_subj.Location = New System.Drawing.Point(122, 58)
        Me.txted_subj.Multiline = True
        Me.txted_subj.Name = "txted_subj"
        Me.txted_subj.Size = New System.Drawing.Size(308, 33)
        Me.txted_subj.TabIndex = 3
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.t_id)
        Me.Panel1.Controls.Add(Me.cbed_level)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbed_teacher)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txted_subj)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 166)
        Me.Panel1.TabIndex = 15
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
        Me.Panel5.Size = New System.Drawing.Size(520, 68)
        Me.Panel5.TabIndex = 14
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
        Me.Label22.Text = "Subject"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = Global.lbsis.My.Resources.Resources.Cancel_24px
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(393, 246)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(115, 35)
        Me.btn_cancel.TabIndex = 17
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = Global.lbsis.My.Resources.Resources.Edit_File_28px
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(272, 246)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(115, 35)
        Me.btn_edit.TabIndex = 16
        Me.btn_edit.Text = "      Update"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'edit_subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(520, 286)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "edit_subject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan-based Student Information System - Edit Subject"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbed_level As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents cbed_teacher As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents t_id As System.Windows.Forms.Label
    Friend WithEvents txted_subj As System.Windows.Forms.TextBox
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
