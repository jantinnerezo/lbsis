Public Class summary_stud
    Public GC As New GlobalCodes ' Call GlobalCodes class
    Public fields() As String = {
                          "stud_id",
                          "username",
                          "violation_id",
                          "student",
                          "violation",
                          "date_violation",
                          "violation_time"
                        }
    Private Sub summary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GC.retrieve("SELECT* from tbl_schoolyear ORDER BY status ASC", "school_year", sy)
        GC.populate_violation("SELECT * FROM `tbl_violation` INNER JOIN tbl_studprof ON tbl_studprof.stud_id = tbl_violation.student_id INNER JOIN tbl_login ON tbl_login.username = tbl_violation.username", violations, fields)
    End Sub

    Private Sub sy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sy.SelectedIndexChanged
        GC.populate_violation("SELECT * FROM `tbl_violation` INNER JOIN tbl_studprof ON tbl_studprof.stud_id = tbl_violation.student_id INNER JOIN tbl_login ON tbl_login.username = tbl_violation.username WHERE tbl_violation.school_year = '" & sy.Text & "'", violations, fields)
    End Sub
End Class