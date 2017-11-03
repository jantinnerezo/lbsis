Public Class Anecdotal



    Public GC As New GlobalCodes ' Call GlobalCodes class
    Public a As String

    Dim tbl_teacher As String = "SELECT* from tbl_login where position = 'Teacher'" ' Database query


    ' Array of fields
    Public fields() As String = {
                          "stud_id",
                          "username",
                          "violation_id",
                          "violation",
                          "date_violation",
                          "violation_time"
                        }
    Public fields2() As String = {
                          "stud_id",
                          "username",
                          "violation_id",
                          "violation",
                          "date_violation",
                          "violation_time"
                        }





    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        onsubmit_cancel()
    End Sub
    Private Sub popup_yesno(ByVal message As String, ByVal title As String)
        Dim result As Integer = MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Me.Dispose()
        End If

    End Sub


    Private Sub onsubmit_cancel()

        Dim empty As Boolean

        Dim data() As String = {
                      violation.Text
                     }

        For x = 1 To data.Length - 1

            If data(x).ToString = "" Then

                empty = True

            Else
                empty = False

            End If

        Next

        If empty = True Then
            If submit.Focused Then
                MessageBox.Show("Please complete all fields.", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.Dispose()
            End If

        Else

            If submit.Focused Then
                insert()
            End If

            If cancel.Focused Then
                popup_yesno("Are you sure you want to cancel?", "Cancel Anecdotal")
            End If
        End If

    End Sub


    Private Sub insert()

        Dim convert_date As Date = violation_date.Value.ToLongDateString()
        Dim convert_time As Date = violation_time.Value.ToLongTimeString()
        Dim data() As String = {
                               violation_date.Text,
                               convert_time,
                               violation.Text,
                               student_id.Text,
                               Home.user_name.Text,
                               schoolyear.Text
                               }
        Dim message As String = "New violation added"

        '' Call insert_anec function from global codes
        GC.insert_anec("INSERT INTO tbl_violation (date_violation,`violation_time`,`violation`,`student_id`,`username`,`school_year`)VALUES(@date_violation,@violation_time,@violation,@student_id,@username,@school_year)", GC.anecdotalinsert_fields, data, message)
        GC.save_logs("INSERT INTO tbl_logs (`log`)VALUES(@log)", Home.user.Text & " Added Violation of " & violator_name.Text)
    End Sub

    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click
        onsubmit_cancel()
    End Sub

    Private Sub Anecdotal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        function_class()

    End Sub

    Public Sub function_class()
        '' Call retrieve function from  global codes and populate violator_teacher combo box

        '' Call populate_violation function from  global codes and populate violations datagridview
        GC.populate_studviolation("SELECT * FROM tbl_violation INNER JOIN tbl_studprof ON tbl_studprof.stud_id = tbl_violation.student_id INNER JOIN tbl_login ON tbl_login.username = tbl_violation.username WHERE tbl_violation.student_id = '" & student_id.Text & "' and tbl_violation.username = '" & Home.user_name.Text & "'", violations, fields)

        GC.retrieve("SELECT* from tbl_schoolyear ORDER BY status ASC", "school_year", sy)
        GC.retrieve_field("SELECT school_year from tbl_schoolyear WHERE status = '1'", schoolyear)
    End Sub

    Private Sub violator_teacher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' Call retrieve_field function from  global codes and get teacher name

    End Sub

    Private Sub on_select()
        Try
            update_btn.Visible = True
            submit.Visible = False

            student_id.Text = violations.SelectedRows(0).Cells(0).Value
            user_name.Text = violations.SelectedRows(0).Cells(1).Value
            violation_id.Text = violations.SelectedRows(0).Cells(2).Value
            violation.Text = violations.SelectedRows(0).Cells(3).Value



            Dim dt As Date = violations.SelectedRows(0).Cells(4).Value
            Dim t As Date = violations.SelectedRows(0).Cells(5).Value

            'MsgBox(dt.ToString("M'/'d'/'yyyy"))

            violation_date.Value = dt
            violation_time.Value = t

        Catch ex As Exception
            selected.Visible = False
        End Try
    End Sub
    Public Sub update_violations()
        Dim message As String = "Changes saved!"
        Dim empty As Boolean

        Dim convert_date As Date = violation_date.Value.ToLongDateString()
        Dim convert_time As Date = violation_time.Value.ToLongTimeString()
        Dim data() As String = {
                        student_id.Text,
                        user_name.Text,
                        violation_id.Text,
                        violation.Text,
                        convert_date,
                        convert_time
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

            Dim result As Integer = MessageBox.Show("Are you sure all the student information is correct?", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Try
                    GC.update_violation("UPDATE tbl_violation set username = '" & user_name.Text & "',violation = '" & violation.Text & "',date_violation = '" & violation_date.Text & "',violation_time = '" & convert_time & "' where violation_id = '" & violation_id.Text & "'", fields, data, message)
                    GC.save_logs("INSERT INTO tbl_logs (`log`)VALUES(@log)", Home.user.Text & " Updated Violation of " & violator_name.Text)
                Catch ex As Exception
                    MsgBox(ex)

                End Try

            End If

        End If

    End Sub

    Private Sub violations_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles violations.Click

        on_select()



    End Sub



    Private Sub violations_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles violations.MouseClick
        on_select()
    End Sub




    Private Sub btnedit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click


        update_btn.Visible = True
        submit.Visible = False

        student_id.Text = violations.SelectedRows(0).Cells(0).Value
        user_name.Text = violations.SelectedRows(0).Cells(1).Value
        violation_id.Text = violations.SelectedRows(0).Cells(2).Value
        violation.Text = violations.SelectedRows(0).Cells(3).Value



        Dim dt As Date = violations.SelectedRows(0).Cells(4).Value
        Dim t As Date = violations.SelectedRows(0).Cells(5).Value

        'MsgBox(dt.ToString("M'/'d'/'yyyy"))

        violation_date.Value = dt
        violation_time.Value = t




    End Sub

    Private Sub violations_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles violations.CellContentClick

    End Sub

    Private Sub update_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_btn.Click
        update_violations()
    End Sub


    Private Sub sy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sy.SelectedIndexChanged
        GC.populate_studviolation("SELECT tbl_studprof.stud_id, tbl_violation.username as user_name, tbl_violation.violation_id, tbl_violation.violation, tbl_violation.date_violation, tbl_violation.violation_time  FROM tbl_violation INNER JOIN tbl_login ON tbl_login.username = tbl_violation.username INNER JOIN tbl_studprof ON tbl_violation.student_id = tbl_studprof.stud_id WHERE tbl_violation.student_id = '" & student_id.Text & "' and tbl_violation.username = '" & Home.user_name.Text & "' and tbl_violation.school_year = '" & sy.Text & "'", violations, fields)
    End Sub
End Class