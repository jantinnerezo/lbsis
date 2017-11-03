<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(verification))
        Me.pass = New System.Windows.Forms.TextBox()
        Me.submit_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(47, 57)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(238, 30)
        Me.pass.TabIndex = 0
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'submit_btn
        '
        Me.submit_btn.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_btn.Image = CType(resources.GetObject("submit_btn.Image"), System.Drawing.Image)
        Me.submit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submit_btn.Location = New System.Drawing.Point(47, 103)
        Me.submit_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.Size = New System.Drawing.Size(106, 49)
        Me.submit_btn.TabIndex = 98
        Me.submit_btn.Text = "Submit"
        Me.submit_btn.UseVisualStyleBackColor = True
        '
        'clear_btn
        '
        Me.clear_btn.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.Image = CType(resources.GetObject("clear_btn.Image"), System.Drawing.Image)
        Me.clear_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clear_btn.Location = New System.Drawing.Point(179, 103)
        Me.clear_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(106, 48)
        Me.clear_btn.TabIndex = 135
        Me.clear_btn.Text = "Cancel"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(43, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 21)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Please Enter Admin's Password:"
        '
        'verification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(335, 165)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.submit_btn)
        Me.Controls.Add(Me.pass)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "verification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents submit_btn As System.Windows.Forms.Button
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
