Public Class Students

   
    Dim gc As New GlobalCodes
    Public fields() As String = {"stud_gradelevel",
                           "stud_lastname",
                           "stud_firstname",
                           "stud_middlename",
                           "stud_birthdate",
                           "stud_age",
                           "stud_gender"
                         }


    Private Sub Students_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        create_datagridview()
        gc.populate_datagridview("select* from tbl_studprof", student_list, fields)
    End Sub


    Public Sub create_datagridview()

        student_list.ColumnCount = 7

        student_list.Columns(0).Name = "Lastname"
        student_list.Columns(1).Name = "Firstname"
        student_list.Columns(2).Name = "Middlename"
        student_list.Columns(3).Name = "Birthdate"
        student_list.Columns(4).Name = "Age"
        student_list.Columns(5).Name = "Gender"
        student_list.Columns(6).Name = "Grade Level"

        student_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Public Sub populate(ByVal fields())

        For x = 0 To fields.Length - 1

            student_list.Rows.Add(fields(x))
        Next
    End Sub


    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class