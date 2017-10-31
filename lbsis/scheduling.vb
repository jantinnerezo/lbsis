Public Class scheduling
    Public gc As New GlobalCodes
    Public a As String

    Dim sched As String = "select * from tbl_schedule"
    Public fields() As String = {"sched_id",
                                "section_id",
                                "subject_id",
                                 "grade_level",
                                 "name",
                                 "time",
                                 "day"}

    Dim tbl_studprof As String = "SELECT* from tbl_studprof"
    Dim schedule As String = "select tbl_schedule.sched_id, tbl_section.section, tbl_subject.subject, tbl_login.name, tbl_schedule.time, tbl_schedule.day from tbl_schedule INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id INNER JOIN tbl_subject ON tbl_subject.subject_id = tbl_schedule.subject_id INNER JOIN tbl_login ON tbl_login.username = tbl_schedule.username"




    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        add_sched.Show()



    End Sub

    Private Sub schedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gc.retrieve("SELECT* from tbl_schoolyear ORDER BY status ASC", "school_year", school_year)
        loadup()
    End Sub
    Public Sub loadup()
        gc.populate_sched(schedule, sched_list, fields)
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click

        a = s_id.Text

        edit_sched.Show()

    End Sub

    Private Sub on_select()
        Try






            s_id.Text = sched_list.SelectedRows(0).Cells(0).Value

            btn_edit.Visible = True
            btn_delete.Visible = True









        Catch ex As Exception

        End Try
    End Sub

    Private Sub sched_list_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sched_list.MouseClick
        on_select()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you to delete Schedule of Section " & sched_list.SelectedRows(0).Cells(1).Value & ", ", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            gc.delete("DELETE FROM tbl_schedule where sched_id = @s_id", "@s_id", sched_list.SelectedRows(0).Cells(0).Value, "Schedule successfully deleted")
            gc.populate_sched(schedule, sched_list, fields)
        End If

    End Sub

  


    Private Sub search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.TextChanged
        Dim schedule As String = "select tbl_schedule.sched_id, tbl_section.section, tbl_subject.subject, tbl_login.name, tbl_schedule.time, tbl_schedule.day from tbl_schedule INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id INNER JOIN tbl_subject ON tbl_subject.subject_id = tbl_schedule.subject_id INNER JOIN tbl_login ON tbl_login.username = tbl_schedule.username where tbl_schedule.sched_id like '%" & search.Text & "%' or tbl_section.section like '%" & search.Text & "%' or tbl_subject.subject like '%" & search.Text & "%'or tbl_login.name like '%" & search.Text & "%'or tbl_schedule.time like '%" & search.Text & "%'or tbl_schedule.day like '%" & search.Text & "%'"
        gc.populate_sched(schedule, sched_list, fields)
    End Sub

   

    
    Private Sub school_year_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles school_year.SelectedIndexChanged
        Dim schedule As String = "select tbl_schedule.sched_id, tbl_section.section, tbl_subject.subject, tbl_login.name, tbl_schedule.time, tbl_schedule.day from tbl_schedule INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id INNER JOIN tbl_subject ON tbl_subject.subject_id = tbl_schedule.subject_id INNER JOIN tbl_login ON tbl_login.username = tbl_schedule.username where tbl_schedule.school_year = '" & school_year.Text & "'"
        gc.populate_sched(schedule, sched_list, fields)
    End Sub

    Private Sub sched_list_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles sched_list.CellContentClick

    End Sub
End Class