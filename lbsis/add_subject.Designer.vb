<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_subject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_subject))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.position = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_subj = New System.Windows.Forms.TextBox()
        Me.cb_level = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.subject_id = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.form_title = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.position)
        Me.Panel5.Controls.Add(Me.form_title)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(494, 68)
        Me.Panel5.TabIndex = 10
        '
        'position
        '
        Me.position.AutoSize = True
        Me.position.Location = New System.Drawing.Point(571, 30)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(59, 17)
        Me.position.TabIndex = 1
        Me.position.Text = "Label18"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Subject:"
        '
        'txt_subj
        '
        Me.txt_subj.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_subj.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subj.Location = New System.Drawing.Point(30, 163)
        Me.txt_subj.Name = "txt_subj"
        Me.txt_subj.Size = New System.Drawing.Size(439, 30)
        Me.txt_subj.TabIndex = 23
        '
        'cb_level
        '
        Me.cb_level.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_level.FormattingEnabled = True
        Me.cb_level.Items.AddRange(New Object() {"K1", "K2", "1", "2", "3", "4", "5", "6"})
        Me.cb_level.Location = New System.Drawing.Point(30, 242)
        Me.cb_level.Name = "cb_level"
        Me.cb_level.Size = New System.Drawing.Size(439, 33)
        Me.cb_level.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Grade level:"
        '
        'subject_id
        '
        Me.subject_id.AutoSize = True
        Me.subject_id.Location = New System.Drawing.Point(323, 89)
        Me.subject_id.Name = "subject_id"
        Me.subject_id.Size = New System.Drawing.Size(51, 17)
        Me.subject_id.TabIndex = 27
        Me.subject_id.Text = "hidden"
        Me.subject_id.Visible = False
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Image = Global.lbsis.My.Resources.Resources.Edit_File_28px
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(167, 315)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(153, 35)
        Me.btn_edit.TabIndex = 28
        Me.btn_edit.Text = "  Update"
        Me.btn_edit.UseVisualStyleBackColor = True
        Me.btn_edit.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Image = Global.lbsis.My.Resources.Resources.Cancel_24px
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(326, 315)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(143, 35)
        Me.btn_cancel.TabIndex = 26
        Me.btn_cancel.Text = "  Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Image = Global.lbsis.My.Resources.Resources.Plus_24px
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(173, 315)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(147, 35)
        Me.btn_add.TabIndex = 25
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'form_title
        '
        Me.form_title.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.form_title.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.form_title.Image = CType(resources.GetObject("form_title.Image"), System.Drawing.Image)
        Me.form_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.form_title.Location = New System.Drawing.Point(12, 9)
        Me.form_title.Name = "form_title"
        Me.form_title.Size = New System.Drawing.Size(254, 39)
        Me.form_title.TabIndex = 0
        Me.form_title.Text = "    Add Subject"
        Me.form_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'add_subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 376)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.subject_id)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_subj)
        Me.Controls.Add(Me.cb_level)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "add_subject"
        Me.Text = "Add subject"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents position As System.Windows.Forms.Label
    Friend WithEvents form_title As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_subj As System.Windows.Forms.TextBox
    Friend WithEvents cb_level As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents subject_id As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
End Class
