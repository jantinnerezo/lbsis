Public Class Records
    Public gc As New GlobalCodes
    Public a As String


    Public fields() As String = {"name",
                                 "grade_level",
                                 "section"
              }



    Private Sub Records_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim tbl As String = "SELECT* from tbl_studprof INNER JOIN tbl_studsubjects ON tbl_studsubjects.student_id = tbl_studprof.stud_id INNER JOIN tbl_schedule ON tbl_schedule.sched_id = tbl_studsubjects.sched_id INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id WHERE tbl_studsubjects.grade_level = '" & glevel.Text & "' and tbl_schedule.school_year = '" & sy.Text & "' ORDER BY (SELECT DISTINCT(student_id) FROM tbl_studsubjects ORDER BY student_id)"
        gc.historyList(tbl, history_list, fields)
    End Sub
End Class