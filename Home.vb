Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports MySql.Data
Public Class Home
    Public gc As New GlobalCodes
    Public a As String


    Public fields() As String = {"stud_id",
                                 "section",
                                 "stud_gradelevel",
                                 "stud_lastname",
                                 "stud_firstname",
                                 "stud_middlename",
                                 "stud_birthdate",
                                 "stud_gender"
                        }

    Dim tbl_studprof As String = "SELECT* from tbl_studprof"
    Dim tbl_religion As String = "SELECT* from tbl_religion"
    Dim tbl_citizenship As String = "SELECT* from tbl_citizenship"



    Public Sub function_class()

        gc.auto_id("SELECT MAX(stud_id) from tbl_studprof", student_id)


        ' gc.populate_datagridview(tbl_studprof, student_list, fields)
        Dim enrolled As String = "Enrolled"

        Dim tbl_enrolled As String = "select * from tbl_studprof"
        gc.populate_datagridview(tbl_enrolled, studentlist_teachers, fields)
        gc.populate_datagridview(tbl_enrolled, student_list, fields)


        Me.enroll_btn.BackColor = Color.Gainsboro
    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        function_class()





    End Sub

   






    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clear_fields()
    End Sub

    Public Sub clear_fields()

        stud_lastname.Text = ""
        stud_firstname.Text = ""
        stud_middlename.Text = ""
        stud_gender.Text = "SELECT"
        citizenship.Text = ""
        religion.Text = ""
        stud_address.Text = ""
        stud_contactnum.Text = ""
        stud_mothername.Text = ""
        stud_motherocc.Text = ""
        stud_fathername.Text = ""
        stud_fatherocc.Text = ""
        stud_health.Text = "None"
        stud_allergy.Text = "None"
        stud_birthdate.Text = ""
    End Sub

    Private Sub enroll()
        Dim message As String = "Student Profile successfully added"
        Dim empty As Boolean





        Dim data() As String = {
                            student_id.Text,
                            status.Text,
                             "0",
                            stud_lastname.Text,
                            stud_firstname.Text,
                            stud_middlename.Text,
                            stud_birthdate.Text,
                            stud_gender.Text,
                            citizenship.Text,
                            religion.Text,
                         stud_address.Text,
                         stud_contactnum.Text,
                         stud_mothername.Text,
                         stud_motherocc.Text,
                         stud_fathername.Text,
                         stud_fatherocc.Text,
                         stud_health.Text,
                         stud_allergy.Text}

        For x = 1 To data.Length - 1

            If data(x).ToString = "" Then

                empty = True

            Else
                empty = False

            End If

        Next

        If empty = True Then


            MessageBox.Show("Please complete all fields!", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf stud_birthdate.Text = "--Month/Day/Year--" Then
            MessageBox.Show("Please complete all fields!", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf stud_gender.Text = "SELECT" Then
            MessageBox.Show("Please complete all fields!", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)




        Else

            Dim result As Integer = MessageBox.Show("Are you sure all the student information is correct?", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then


                gc.insert("INSERT INTO tbl_studprof (`stud_id`,`status`,`stud_gradelevel`,`stud_lastname`,`stud_firstname`,`stud_middlename`,`stud_birthdate`,`stud_gender`,`citizenship`,`religion`,`stud_address`,`stud_contactnum`,`stud_mothername`,`stud_motherocc`,`stud_fathername`,`stud_fatherocc`,`stud_health`,`stud_allergy`)VALUES(@stud_id,@status,@stud_gradelevel,@stud_lastname,@stud_firstname,@stud_middlename,@stud_birthdate,@stud_gender,@citizenship,@religion,@stud_address,@stud_contactnum,@stud_mothername,@stud_motherocc,@stud_fathername,@stud_fatherocc,@stud_health,@stud_allergy)", gc.insert_fields, data, message)
                gc.save_logs("INSERT INTO tbl_logs (`log`)VALUES(@log)", user.Text & " added a new Student")
            End If

        End If

    End Sub



    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        Call clear_fields()

    End Sub



    Private Sub enroll_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enroll_btn.Click


        Me.enroll_container.Visible = True
        Me.student_container.Visible = False
        Me.enroll_btn.BackColor = Color.Gainsboro
        Me.stud_btn.BackColor = Color.White
        enrolledlist.Hide()

    End Sub

    Private Sub students_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stud_btn.Click
        Me.enroll_container.Visible = False
        Me.student_container.Visible = True
        Me.enroll_btn.BackColor = Color.White
        Me.stud_btn.BackColor = Color.Gainsboro
        enrolledlist.Hide()

    End Sub
    Private Sub student_list_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles student_list.MouseClick
        on_select()



    End Sub

    Private Sub grade_level_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grade_level.SelectedIndexChanged
        If grade_level.Text = "All" Then
            gc.populate_datagridview(tbl_studprof, student_list, fields)

        ElseIf grade_level.Text = "Not Enrolled" Then
            Dim not_enrolled As String = "SELECT * FROM tbl_studprof where status = '" & "Not Enrolled" & "'"

            gc.populate_datagridview(not_enrolled, student_list, fields)


        Else
            gc.populate_datagridview(tbl_studprof & " where stud_gradelevel = '" & grade_level.Text & "'", student_list, fields)
        End If

    End Sub

    Private Sub on_select()
        Try
            Dim tbl_teacher As String = "select * from tbl_login WHERE position = 'Teacher'"

          
            If position.Text = "Teacher" Then

                btn_enroll.Visible = False
                unenroll.Visible = False

            ElseIf position.Text = "Admin" Then
                btn_enroll.Visible = False
                unenroll.Visible = False

            ElseIf student_list.SelectedRows(0).Cells(1).Value = "Enrolled" Then
                btn_enroll.Visible = False
                unenroll.Visible = True
            Else
                btn_enroll.Visible = True
                unenroll.Visible = False
            End If


            student.Text = student_list.SelectedRows(0).Cells(3).Value & "," & student_list.SelectedRows(0).Cells(4).Value & " " & student_list.SelectedRows(0).Cells(5).Value


            stud_id.Text = student_list.SelectedRows(0).Cells(0).Value
            stud_status.Text = stud_prevstat.Text

            selected.Visible = True


        Catch ex As Exception
            selected.Visible = False
        End Try
    End Sub

    Private Sub on_selectEnrolledstud()
        Try



            student.Text = studentlist_teachers.SelectedRows(0).Cells(3).Value & "," & studentlist_teachers.SelectedRows(0).Cells(4).Value & " " & studentlist_teachers.SelectedRows(0).Cells(5).Value


            stud_id.Text = studentlist_teachers.SelectedRows(0).Cells(0).Value
            stud_status.Text = stud_prevstat.Text

            selected.Visible = True






        Catch ex As Exception
            selected.Visible = False
        End Try
    End Sub



    Private Sub search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.TextChanged

        If grade_level.Text = "All" Then
            gc.populate_datagridview(tbl_studprof & " where stud_lastname like '%" & search.Text & "%' or stud_firstname like '%" & search.Text & "%' or stud_middlename like '%" & search.Text & "%'", student_list, fields)
        Else
            gc.populate_datagridview(tbl_studprof & " where (stud_lastname like '%" & search.Text & "%' or stud_firstname like '%" & search.Text & "%' or stud_middlename like '%" & search.Text & "%') and stud_gradelevel = '" & grade_level.Text & "'", student_list, fields)
        End If

    End Sub

    Private Sub anecdotal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anecdotal_btn.Click
        Try



            Anecdotal.student_id.Text = studentlist_teachers.SelectedRows(0).Cells(0).Value
            Anecdotal.violator_name.Text = studentlist_teachers.SelectedRows(0).Cells(3).Value & ", " & studentlist_teachers.SelectedRows(0).Cells(4).Value
            Anecdotal.user_name.Text = user.Text
            Anecdotal.ShowDialog()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        If student_list.SelectedRows(0).Cells(2).Value = "Enrolled" Then

            MessageBox.Show("Cannot Delete Enrolled Student!", "Submit dialog", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

            Dim result As Integer = MessageBox.Show("Are you sure you to delete student named " & student_list.SelectedRows(0).Cells(3).Value & ", " & student_list.SelectedRows(0).Cells(4).Value, "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                gc.delete("DELETE FROM tbl_studprof where stud_id = @stud_id", "@stud_id", student_list.SelectedRows(0).Cells(0).Value, "Student successfully deleted")

            End If
        End If

    End Sub

    Private Sub view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view.Click
        student_profile.stud_name.Text = "      " & student_list.SelectedRows(0).Cells(4).Value & ", " & student_list.SelectedRows(0).Cells(5).Value & ""
        student_profile.ShowDialog()
        gc.save_logs("INSERT INTO tbl_logs (`log`)VALUES(@log)", user.Text & " Viewed the profile of " & student.Text)
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        enrolledlist.Show()

    End Sub


    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        editform.ShowDialog()




    End Sub



    Private Sub btn_manage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_manage.Click
        manageusers.ShowDialog()

    End Sub




    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        Me.Dispose()
        gc.save_logs("INSERT INTO tbl_logs (`log`)VALUES(@log)", Me.user.Text & " logged out")
        Login.Show()

    End Sub


    Private Sub btn_enroll_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enroll.Click


        If student_list.SelectedRows(0).Cells(1).Value = "Enrolled" Then

            MessageBox.Show("This student is already Enrolled!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            a = stud_id.Text

            enrollment_assign.Show()


        End If


    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        enroll()


    End Sub



    Private Sub btn_addsub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addsub.Click
        subject.Show()

    End Sub



    Private Sub btn_scheduling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_scheduling.Click
        scheduling.Show()

    End Sub

    Private Sub studentlist_teachers_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles studentlist_teachers.MouseClick
        on_selectEnrolledstud()
    End Sub


    Private Sub anec_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        anecstud_profile.stud_name.Text = "      " & student_list.SelectedRows(0).Cells(4).Value & ", " & student_list.SelectedRows(0).Cells(5).Value & ""
        anecstud_profile.ShowDialog()
    End Sub

    Private Sub studentlist_teachers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles studentlist_teachers.CellContentClick

    End Sub

    Private Sub sy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sy.Click
        school_year.ShowDialog()

    End Sub

    Private Sub summary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles summary.Click
        summary_stud.ShowDialog()

    End Sub


    Private Sub logs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logs.Click
        all_logs.ShowDialog()

    End Sub

    Private Sub unenroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unenroll.Click

        Connected()

        Dim update As String = "UPDATE tbl_studprof SET status = 'Not enrolled' WHERE stud_id = '" & stud_id.Text & "'"
        Dim sql_command2 = New MySqlClient.MySqlCommand(update, connection)

        If sql_command2.ExecuteNonQuery() > 0 Then


            MessageBox.Show("Student successfully unenrolled!", "Lan-based Student Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.function_class()
            gc.save_logs("INSERT INTO tbl_logs (`log`)VALUES(@log)", user.Text & " Unenrolled student named" &student.text)



        End If
    End Sub

    Private Sub history_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles history_btn.Click
        history_selection.Show()

    End Sub

    Private Sub pos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Dim enrolled As String = "SELECT * FROM tbl_studprof where status = '" & "Enrolled" & "'"
        gc.populate_datagridview(enrolled, student_list, fields)
        gc.populate_datagridview(enrolled, studentlist_teachers, fields)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Dim enrolled As String = "SELECT * FROM tbl_studprof where status = '" & "Not Enrolled" & "'"
        gc.populate_datagridview(enrolled, student_list, fields)
        gc.populate_datagridview(enrolled, studentlist_teachers, fields)
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Me.enroll_container.Visible = False
        Me.student_container.Visible = True
        Me.enroll_btn.BackColor = Color.White
        Me.Button9.BackColor = Color.Gainsboro
        enrolledlist.Hide()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        scheduling.Show()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        subject.Show()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click

        Me.enroll_container.Visible = False
        Me.student_container.Visible = True
        Me.enroll_btn.BackColor = Color.White
        Me.Button10.BackColor = Color.Gainsboro
        enrolledlist.Hide()

    End Sub

    Private Sub my_class_Click(sender As System.Object, e As System.EventArgs) Handles my_class.Click
        classes.ShowDialog()

    End Sub

  

End Class

