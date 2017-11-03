Public Class success

    Public gc As New GlobalCodes

    Public fields() As String = {"subject",
                              "teacher",
                                 "time",
                               "day"
                                }
    Dim tbl_studprof As String = "select * from tbl_studprof"
    Dim tbl_schedule As String = "select * from tbl_schedule"
    Dim tbl_schoolyear As String = "select* from tbl_schoolyear"
   

    Private Sub success_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        level.Text = enrollment_assign.grade_level.Text

        student.Text = Home.student.Text
        section.Text = enrollment_assign.cb_sect.Text


        Dim advisory As String = "select adviser from tbl_section where section_id = '" & enrollment_assign.sec_id.Text & "'"
        gc.retrieve_field(advisory, adviser)

        gc.retrieve_field(tbl_schoolyear & " WHERE status = '1'", sy)


        Dim finish As String = "select tbl_subject.subject, tbl_login.name, tbl_schedule.time, tbl_schedule.day from tbl_schedule INNER JOIN tbl_subject ON tbl_subject.subject_id = tbl_schedule.subject_id INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id INNER JOIN tbl_login ON tbl_login.username = tbl_schedule.username where  tbl_section.section =  '" & section.Text & "' and tbl_schedule.school_year = '" & sy.Text & "'"
        gc.populate_success(finish, success_list, fields)


        If level.Text = "K1" Or level.Text = "K2" Then

            panel_note.Visible = True

        End If



    End Sub

    Private Sub btn_submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        enrollment_assign.Dispose()
        Me.Dispose()

    End Sub

    Private Sub btn_submit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit.Click
        Me.Dispose()
        enrollment_assign.Dispose()

    End Sub


End Class