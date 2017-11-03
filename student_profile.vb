


Public Class student_profile

    Public gc As New GlobalCodes

    Public fields() As String = {
                          "stud_id",
                          "stud_gradelevel",
                          "stud_lastname",
                          "stud_firstname",
                          "stud_middlename",
                          "stud_birthdate",
                          "stud_gender",
                          "religion",
                          "citizenship",
                          "stud_address",
                          "stud_contactnum",
                          "stud_mothername",
                          "stud_motherocc",
                          "stud_fathername",
                          "stud_fatherocc",
                          "stud_health",
                          "stud_allergy",
                          "status"}


    Public fields2() As String = {
                          "sched_id",
                          "grade_level",
                          "subject",
                          "section",
                          "name",
                          "time",
                          "day",
                          "school_year"
                        }


    Private Sub student_profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        gc.retrieve("SELECT* from tbl_schoolyear ORDER BY status ASC", "school_year", sy)
        If Home.student_list.SelectedRows(0).Cells(1).Value = "Enrolled" Then

            Dim stud As String = "Select* from tbl_studprof WHERE stud_id = '" & Home.student_list.SelectedRows(0).Cells(0).Value & "'"
            Dim history As String = "SELECT * FROM `tbl_schedule` INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id INNER JOIN tbl_subject ON tbl_subject.subject_id = tbl_schedule.subject_id INNER JOIN tbl_login ON tbl_schedule.username = tbl_login.username INNER JOIN tbl_studsubjects ON tbl_studsubjects.sched_id = tbl_schedule.sched_id WHERE tbl_studsubjects.student_id = '" & Home.student_list.SelectedRows(0).Cells(0).Value & "'"

            gc.student_profile(stud, student_prof)
            gc.populate_history(history, history_list, fields2)

        Else
            Dim stud As String = "Select* from tbl_studprof WHERE stud_id = '" & Home.student_list.SelectedRows(0).Cells(0).Value & "'"

            gc.student_profile(stud, student_prof)

        End If



    End Sub


    Private Sub sy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sy.SelectedIndexChanged
        Dim history As String = "SELECT * FROM `tbl_schedule` INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id INNER JOIN tbl_subject ON tbl_subject.subject_id = tbl_schedule.subject_id INNER JOIN tbl_login ON tbl_schedule.username = tbl_login.username INNER JOIN tbl_studsubjects ON tbl_studsubjects.sched_id = tbl_schedule.sched_id WHERE tbl_schedule.school_year = '" & sy.Text & "' and tbl_studsubjects.student_id = '" & Home.student_list.SelectedRows(0).Cells(0).Value & "'"
        gc.populate_history(history, history_list, fields2)
    End Sub
End Class