Public Class classes
    Public gc As New GlobalCodes

    Public fields() As String = {"subject",
                                "section",
                                "grade_level",
                                 "time",
                                 "day",
                                 "school_year"
             }
    Private Sub classes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim tbl As String = "SELECT* from tbl_schedule INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id INNER JOIN tbl_subject ON tbl_subject.subject_id = tbl_schedule.subject_id WHERE tbl_schedule.username = '" & Home.user_name.Text & "'"
        gc.classList(tbl, class_list, fields)
        gc.retrieve("SELECT* from tbl_schoolyear ORDER BY status ASC", "school_year", sy)
    End Sub

    Private Sub sy_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles sy.SelectedIndexChanged
        Dim tbl As String = "SELECT* from tbl_schedule INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id INNER JOIN tbl_subject ON tbl_subject.subject_id = tbl_schedule.subject_id WHERE tbl_schedule.username = '" & Home.user_name.Text & "' and tbl_schedule.school_year = '" & sy.Text & "'"
        gc.classList(tbl, class_list, fields)
    End Sub
End Class