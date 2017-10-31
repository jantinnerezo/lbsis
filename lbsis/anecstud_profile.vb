Public Class anecstud_profile

    Public gc As New GlobalCodes

    Public fields() As String = {"stud_gradelevel",
                                 "section",
                                 "schedule",
                          "stud_lastname",
                          "stud_firstname",
                          "stud_middlename",
                          "stud_birthdate",
                          "stud_age",
                          "stud_gender",
                          "citizenship_id",
                          "religion_id",
                          "stud_address",
                          "stud_contactnum",
                          "stud_mothername",
                          "stud_motherocc",
                          "stud_fathername",
                          "stud_fatherocc",
                          "stud_health",
                          "stud_allergy"}



    Private Sub anecstud_profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim stud As String = "SELECT tbl_studprof.stud_gradelevel, tbl_section.section, tbl_studprof.stud_lastname, tbl_studprof.stud_firstname, tbl_studprof.stud_middlename, tbl_studprof.stud_birthdate, tbl_studprof.stud_age, tbl_studprof.stud_gender, " & _
      "tbl_citizenship.citizenship, tbl_religion.religion, tbl_studprof.stud_address, tbl_studprof.stud_contactnum, tbl_studprof.stud_mothername, tbl_studprof.stud_motherocc, tbl_studprof.stud_fathername, tbl_studprof.stud_fatherocc, " & _
      "tbl_studprof.stud_health, tbl_studprof.stud_allergy from tbl_studprof INNER JOIN tbl_citizenship ON tbl_studprof.citizenship_id = tbl_citizenship.citizenship_id " & _
      "INNER JOIN tbl_religion ON tbl_studprof.religion_id = tbl_religion.religion_id INNER JOIN tbl_section ON tbl_section.section_id = tbl_studprof.section_id WHERE tbl_studprof.stud_id = '" & Home.studentlist_teachers.SelectedRows(0).Cells(0).Value & "'"

        gc.student_profile(stud, student_prof)
    End Sub
End Class