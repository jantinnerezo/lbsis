Public Class subject
    Public gc As New GlobalCodes
    Public a As String
    Public b As String



    Dim tbl_subject As String = "SELECT* from tbl_subject"
    Public fields() As String = {"subject_id",
                      "subject", "grade_level"}


    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click

       

        btn_delete.Visible = False
        btn_edit.Visible = False

        add_subject.Show()


       



    End Sub

    Private Sub subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        refresh_subj()

        btn_delete.Visible = False
        btn_edit.Visible = False

    End Sub
    Public Sub refresh_subj()
        Dim subject As String = "Select* from tbl_subject"
        gc.list_subject(subject, subject_list, fields)
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click

        add_subject.form_title.Text = "    Edit Subject"
        add_subject.subject_id.Text = s_id.Text
        add_subject.subject_id.Text = t_id.Text
        add_subject.txt_subj.Text = subject_name.Text
        add_subject.cb_level.Text = grade_level.Text
        add_subject.btn_add.Visible = False
        add_subject.btn_edit.Visible = True
        add_subject.Show()

    End Sub

    Private Sub subject_list_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles subject_list.MouseClick
        on_select()

    End Sub

    Private Sub on_select()
        Try


            s_id.Text = subject_list.SelectedRows(0).Cells(0).Value
            subject_name.Text = subject_list.SelectedRows(0).Cells(2).Value
            grade_level.Text = subject_list.SelectedRows(0).Cells(3).Value
            t_id.Text = subject_list.SelectedRows(0).Cells(4).Value

            btn_edit.Visible = True
            btn_delete.Visible = True


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you to delete Subject named " & subject_list.SelectedRows(0).Cells(1).Value & ", ", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            gc.delete("DELETE FROM tbl_subject where subject_id = @s_id", "@s_id", subject_list.SelectedRows(0).Cells(0).Value, "Subject successfully deleted")
            refresh_subj()
        End If

    End Sub



    Private Sub btn_section_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_section.Click

        section.Show()


        btn_delete.Visible = False
        btn_edit.Visible = False

    End Sub

    
    Private Sub search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.TextChanged

        Dim subject As String = "Select* from tbl_subject where subject like '%" & search.Text & "%' or grade_level like '%" & search.Text & "%'"
        gc.list_subject(subject, subject_list, fields)

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub glevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles glevel.SelectedIndexChanged
        Dim subject As String = "Select* from tbl_subject WHERE grade_level = '" & glevel.Text & "'"
        gc.list_subject(subject, subject_list, fields)
    End Sub
End Class