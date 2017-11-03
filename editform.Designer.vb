<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editform))
        Me.stud_birthdate = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.student_id = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.stud_contactnum = New System.Windows.Forms.TextBox()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.submit_btn = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.stud_health = New System.Windows.Forms.TextBox()
        Me.stud_allergy = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.stud_address = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.stud_mothername = New System.Windows.Forms.TextBox()
        Me.stud_fatherocc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.stud_motherocc = New System.Windows.Forms.TextBox()
        Me.stud_fathername = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.stud_gradelevel = New System.Windows.Forms.ComboBox()
        Me.stud_firstname = New System.Windows.Forms.TextBox()
        Me.stud_lastname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stud_middlename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.stud_gender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.citizenship = New System.Windows.Forms.TextBox()
        Me.religion = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'stud_birthdate
        '
        Me.stud_birthdate.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_birthdate.Location = New System.Drawing.Point(845, 114)
        Me.stud_birthdate.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_birthdate.Name = "stud_birthdate"
        Me.stud_birthdate.Size = New System.Drawing.Size(212, 30)
        Me.stud_birthdate.TabIndex = 140
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.student_id)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1100, 68)
        Me.Panel3.TabIndex = 104
        '
        'student_id
        '
        Me.student_id.AutoSize = True
        Me.student_id.Location = New System.Drawing.Point(642, 27)
        Me.student_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.student_id.Name = "student_id"
        Me.student_id.Size = New System.Drawing.Size(83, 25)
        Me.student_id.TabIndex = 49
        Me.student_id.Text = "Label18"
        Me.student_id.Visible = False
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Location = New System.Drawing.Point(17, 8)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(287, 51)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Form - Update"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(10, 117)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(232, 25)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "Parent's Contact Number:"
        '
        'stud_contactnum
        '
        Me.stud_contactnum.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_contactnum.Location = New System.Drawing.Point(246, 114)
        Me.stud_contactnum.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_contactnum.Name = "stud_contactnum"
        Me.stud_contactnum.Size = New System.Drawing.Size(155, 30)
        Me.stud_contactnum.TabIndex = 138
        '
        'clear_btn
        '
        Me.clear_btn.Image = CType(resources.GetObject("clear_btn.Image"), System.Drawing.Image)
        Me.clear_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clear_btn.Location = New System.Drawing.Point(946, 640)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(143, 38)
        Me.clear_btn.TabIndex = 137
        Me.clear_btn.Text = "Clear"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'submit_btn
        '
        Me.submit_btn.Image = CType(resources.GetObject("submit_btn.Image"), System.Drawing.Image)
        Me.submit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submit_btn.Location = New System.Drawing.Point(797, 640)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.Size = New System.Drawing.Size(143, 38)
        Me.submit_btn.TabIndex = 136
        Me.submit_btn.Text = "Submit"
        Me.submit_btn.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(11, 13)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(235, 25)
        Me.Label16.TabIndex = 132
        Me.Label16.Text = "Health Problem/s (If Any):"
        '
        'stud_health
        '
        Me.stud_health.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_health.Location = New System.Drawing.Point(15, 36)
        Me.stud_health.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_health.Multiline = True
        Me.stud_health.Name = "stud_health"
        Me.stud_health.Size = New System.Drawing.Size(468, 106)
        Me.stud_health.TabIndex = 133
        Me.stud_health.Text = "None"
        '
        'stud_allergy
        '
        Me.stud_allergy.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_allergy.Location = New System.Drawing.Point(514, 36)
        Me.stud_allergy.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_allergy.Multiline = True
        Me.stud_allergy.Name = "stud_allergy"
        Me.stud_allergy.Size = New System.Drawing.Size(543, 106)
        Me.stud_allergy.TabIndex = 135
        Me.stud_allergy.Text = "None"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(510, 13)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(140, 25)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "Allergy (If Any):"
        '
        'stud_address
        '
        Me.stud_address.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_address.Location = New System.Drawing.Point(648, 38)
        Me.stud_address.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_address.Multiline = True
        Me.stud_address.Name = "stud_address"
        Me.stud_address.Size = New System.Drawing.Size(410, 106)
        Me.stud_address.TabIndex = 123
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(644, 15)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 25)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "Address:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(10, 10)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 25)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "Mother's Name:"
        '
        'stud_mothername
        '
        Me.stud_mothername.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_mothername.Location = New System.Drawing.Point(138, 10)
        Me.stud_mothername.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_mothername.Name = "stud_mothername"
        Me.stud_mothername.Size = New System.Drawing.Size(155, 30)
        Me.stud_mothername.TabIndex = 124
        '
        'stud_fatherocc
        '
        Me.stud_fatherocc.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_fatherocc.Location = New System.Drawing.Point(468, 61)
        Me.stud_fatherocc.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_fatherocc.Name = "stud_fatherocc"
        Me.stud_fatherocc.Size = New System.Drawing.Size(155, 30)
        Me.stud_fatherocc.TabIndex = 130
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(315, 64)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(187, 25)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "Father's Occupation:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(315, 13)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(193, 25)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Mother's Occupation:"
        '
        'stud_motherocc
        '
        Me.stud_motherocc.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_motherocc.Location = New System.Drawing.Point(468, 13)
        Me.stud_motherocc.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_motherocc.Name = "stud_motherocc"
        Me.stud_motherocc.Size = New System.Drawing.Size(155, 30)
        Me.stud_motherocc.TabIndex = 126
        '
        'stud_fathername
        '
        Me.stud_fathername.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_fathername.Location = New System.Drawing.Point(138, 61)
        Me.stud_fathername.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_fathername.Name = "stud_fathername"
        Me.stud_fathername.Size = New System.Drawing.Size(155, 30)
        Me.stud_fathername.TabIndex = 128
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(9, 61)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 25)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "Father's Name:"
        '
        'stud_gradelevel
        '
        Me.stud_gradelevel.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_gradelevel.FormattingEnabled = True
        Me.stud_gradelevel.Items.AddRange(New Object() {"K1", "K2", "1", "2", "3", "4", "5", "6"})
        Me.stud_gradelevel.Location = New System.Drawing.Point(137, 14)
        Me.stud_gradelevel.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_gradelevel.Name = "stud_gradelevel"
        Me.stud_gradelevel.Size = New System.Drawing.Size(155, 33)
        Me.stud_gradelevel.TabIndex = 121
        Me.stud_gradelevel.Text = "SELECT"
        '
        'stud_firstname
        '
        Me.stud_firstname.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_firstname.Location = New System.Drawing.Point(471, 65)
        Me.stud_firstname.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_firstname.Name = "stud_firstname"
        Me.stud_firstname.Size = New System.Drawing.Size(242, 30)
        Me.stud_firstname.TabIndex = 109
        '
        'stud_lastname
        '
        Me.stud_lastname.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_lastname.Location = New System.Drawing.Point(137, 65)
        Me.stud_lastname.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_lastname.Name = "stud_lastname"
        Me.stud_lastname.Size = New System.Drawing.Size(155, 30)
        Me.stud_lastname.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(735, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Middle Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(735, 116)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Birthday: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(314, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "First Name:"
        '
        'stud_middlename
        '
        Me.stud_middlename.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_middlename.Location = New System.Drawing.Point(845, 67)
        Me.stud_middlename.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_middlename.Name = "stud_middlename"
        Me.stud_middlename.Size = New System.Drawing.Size(211, 30)
        Me.stud_middlename.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Grade Level:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(11, 119)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 25)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Gender:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Last Name:"
        '
        'stud_gender
        '
        Me.stud_gender.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_gender.FormattingEnabled = True
        Me.stud_gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.stud_gender.Location = New System.Drawing.Point(137, 116)
        Me.stud_gender.Margin = New System.Windows.Forms.Padding(2)
        Me.stud_gender.Name = "stud_gender"
        Me.stud_gender.Size = New System.Drawing.Size(155, 33)
        Me.stud_gender.TabIndex = 116
        Me.stud_gender.Text = "SELECT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(314, 119)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 25)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Citizenship:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 167)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 25)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Religion:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.citizenship)
        Me.Panel1.Controls.Add(Me.religion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.stud_birthdate)
        Me.Panel1.Controls.Add(Me.stud_gender)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.stud_middlename)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.stud_lastname)
        Me.Panel1.Controls.Add(Me.stud_firstname)
        Me.Panel1.Controls.Add(Me.stud_gradelevel)
        Me.Panel1.Location = New System.Drawing.Point(12, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 213)
        Me.Panel1.TabIndex = 145
        '
        'citizenship
        '
        Me.citizenship.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.citizenship.Location = New System.Drawing.Point(471, 114)
        Me.citizenship.Margin = New System.Windows.Forms.Padding(2)
        Me.citizenship.Name = "citizenship"
        Me.citizenship.Size = New System.Drawing.Size(242, 30)
        Me.citizenship.TabIndex = 142
        '
        'religion
        '
        Me.religion.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.religion.Location = New System.Drawing.Point(137, 162)
        Me.religion.Margin = New System.Windows.Forms.Padding(2)
        Me.religion.Name = "religion"
        Me.religion.Size = New System.Drawing.Size(489, 30)
        Me.religion.TabIndex = 141
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.stud_fathername)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.stud_motherocc)
        Me.Panel4.Controls.Add(Me.stud_contactnum)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.stud_fatherocc)
        Me.Panel4.Controls.Add(Me.stud_mothername)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.stud_address)
        Me.Panel4.Location = New System.Drawing.Point(12, 292)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1077, 167)
        Me.Panel4.TabIndex = 146
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.stud_allergy)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.stud_health)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Location = New System.Drawing.Point(12, 465)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1077, 169)
        Me.Panel5.TabIndex = 147
        '
        'editform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1100, 687)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.submit_btn)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "editform"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lan-based Student Information System - Edit Form"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents stud_birthdate As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents student_id As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents stud_contactnum As System.Windows.Forms.TextBox
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents submit_btn As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents stud_health As System.Windows.Forms.TextBox
    Friend WithEvents stud_allergy As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents stud_address As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents stud_mothername As System.Windows.Forms.TextBox
    Friend WithEvents stud_fatherocc As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents stud_motherocc As System.Windows.Forms.TextBox
    Friend WithEvents stud_fathername As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents stud_gradelevel As System.Windows.Forms.ComboBox
    Friend WithEvents stud_firstname As System.Windows.Forms.TextBox
    Friend WithEvents stud_lastname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents stud_middlename As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents stud_gender As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents religion As System.Windows.Forms.TextBox
    Friend WithEvents citizenship As System.Windows.Forms.TextBox
End Class
