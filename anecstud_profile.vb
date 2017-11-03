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
        Dim stud As String = "SELECT * from tbl_studprof where stud_id = '" & Home.studentlist_teachers.SelectedRows(0).Cells(0).Value & "'"

        gc.student_profile(stud, student_prof)
    End Sub
End Class