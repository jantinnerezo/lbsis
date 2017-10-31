Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports MySql.Data


Public Class enrollment_assign
    Public gc As New GlobalCodes


    Dim tbl_schedule As String = "select * from tbl_schedule"
    Dim tbl_section As String = "select * from tbl_section"
    Dim tbl_studprof As String = "select * from tbl_studprof"


    Private Sub enrollment_assign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim stud As String = "SELECT * FROM tbl_studprof where stud_id = '" & Home.student_list.SelectedRows(0).Cells(0).Value & "'"


        gc.load_gradelevel(stud)



     
        stud_id.Text = Home.a







    End Sub



    Private Sub cb_sect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_sect.SelectedIndexChanged

        gc.retrieve_field(tbl_section & " WHERE section = '" & cb_sect.Text & "'", sec_id)



    End Sub



    Private Sub btn_enroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enroll.Click
        enroll_student()








    End Sub


    Public Sub enroll_student()




        Dim query As String = "SELECT * FROM `tbl_schedule` INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id WHERE tbl_schedule.section_id = '" & sec_id.Text & "' and tbl_section.grade_level = '" & grade_level.Text & "'"
        Dim count As Integer = 0

        Try
            Connected()

            Dim sqlAdapter As New MySqlDataAdapter
            Dim sqlCommand As New MySqlCommand
            Dim table As New DataTable
            Dim i As Integer

            With sqlCommand

                .CommandText = query
                .Connection = connection

            End With

            With sqlAdapter

                .SelectCommand = sqlCommand
                .Fill(table)

            End With


            count = table.Rows.Count

            If count > 0 Then




                For Each rows In table.Rows '   Loop through table rows
                    '  Count all rows in the table
                    Dim insert As String = "INSERT INTO tbl_studsubjects (`sched_id`,`student_id`,`grade_level`)VALUES('" & rows("sched_id") & "','" & stud_id.Text & "','" & grade_level.Text & "')"
                    Dim sql_command = New MySqlClient.MySqlCommand(insert, connection)
                    sql_command.ExecuteNonQuery()
                  

                Next


                Dim update As String = "UPDATE tbl_studprof SET status = 'Enrolled' WHERE stud_id = '" & stud_id.Text & "'"
                Dim sql_command2 = New MySqlClient.MySqlCommand(update, connection)

                If sql_command2.ExecuteNonQuery() > 0 Then
                    Dim update2 As String = "UPDATE tbl_studprof SET stud_gradelevel = '" & grade_level.Text & "' WHERE stud_id = '" & stud_id.Text & "'"
                    Dim sql_command3 = New MySqlClient.MySqlCommand(update2, connection)

                    If sql_command3.ExecuteNonQuery() > 0 Then


                        MessageBox.Show("Student successfully enrolled!", "Lan-based Student Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Home.function_class()
                        success.Show()

                        Me.Dispose()


                    End If

                End If
               


            
            connection.Close()
            Else
                MessageBox.Show("No schedules available in this grade level and section yet", "Lan-based Student Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


            Home.student_count.Text = count
            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub finalenroll()
        Dim message As String = "Student successfully enrolled"
        Dim empty As Boolean



        Dim data() As String = {stud_id.Text, cb_sect.Text, grade_level.Text
                               }


        For x = 1 To data.Length - 1

            If data(x).ToString = "" Then

                empty = True

            Else
                empty = False

            End If

        Next

        If empty = True Then

            MessageBox.Show("Please complete all fields!", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim result As Integer = MessageBox.Show("Are you sure to enroll this student?", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then



                gc.insert("INSERT INTO tbl_studlist (`stud_id`)VALUES(@stud_id)", gc.insert_fieldstudlist, data, message)
                gc.enrolling("UPDATE tbl_studprof set status = '" & stud_status.Text & "', section_id = '" & sec_id.Text & "' where stud_id = '" & Home.a & "' ")
                Home.function_class()
                Me.Hide()
                success.Show()

            End If

        End If





    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Dispose()
    End Sub


    Private Sub grade_level_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grade_level.SelectedIndexChanged
        Dim section As String = "select * from tbl_section where grade_level = '" & grade_level.Text & "'"
        gc.retrieve(section, "section", cb_sect)
    End Sub
End Class