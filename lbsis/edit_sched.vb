Public Class edit_sched
    Public gc As New GlobalCodes



    Dim tbl_teacher As String = "select * from tbl_teacher"
    Dim tbl_subject As String = "select * from tbl_subject"
    Dim tbl_section As String = "select * from tbl_section"
    Dim grade As String = "select grade_level from tbl_section"
       
    Private Sub edit_sched_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim edit As String = "SELECT * FROM tbl_schedule INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id INNER JOIN tbl_subject ON tbl_subject.subject_id = tbl_schedule.subject_id where tbl_schedule.sched_id = '" & scheduling.sched_list.SelectedRows(0).Cells(0).Value & "'"
        gc.sched_edit(edit)
        s_id.Text = scheduling.a


        gc.retrieve(tbl_teacher, "name", cbedteacher)
        gc.retrieve(tbl_subject, "subject", cbed_subject)

        gc.retrieve(tbl_section, "section", cbed_section)
        gc.retrieve_field(grade & " WHERE section = '" & cbed_section.Text & "'", g)



    End Sub

  

    Private Sub cbed_section_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbed_section.SelectedIndexChanged


        gc.retrieve_field(tbl_section & " WHERE section = '" & cbed_section.Text & "'", sec_id)


        gc.retrieve_field(grade & " WHERE section = '" & cbed_section.Text & "'", g)

    End Sub

    Private Sub cbed_subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbed_subject.SelectedIndexChanged
        gc.retrieve_field(tbl_subject & " WHERE subject = '" & cbed_subject.Text & "'", sub_id)

        Dim teacher As String = "select tbl_teacher.name from  tbl_subject INNER JOIN tbl_teacher ON tbl_teacher.teacher_id = tbl_subject.teacher_id where tbl_subject.subject = '" & cbed_subject.Text & "' and tbl_subject.grade_level = '" & g.Text & "'"
        gc.retrieve(teacher, "name", cbedteacher)

      
    End Sub




    Public Sub edit()
        Dim message As String = "Schedule successfully Upadted"
        Dim empty As Boolean

        Dim data() As String = {sec_id.Text,
                                sub_id.Text,
                                cbedteacher.Text,
                                cbed_time.Text,
                            cbed_day.Text}






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

            Dim result As Integer = MessageBox.Show("Are you sure all the user information is correct?", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Try
                    gc.sched_edit("UPDATE tbl_schedule set  section_id = '" & sec_id.Text & "', subject_id = '" & sub_id.Text & "',  teacher = '" & cbedteacher.Text & "' , time = '" & cbed_time.Text & "' ,  day = '" & cbed_day.Text & "' where sched_id = '" & scheduling.a & "' ")




                    Me.Dispose()
                    scheduling.Dispose()
                    scheduling.Show()






                Catch ex As Exception
                    MsgBox(ex)

                End Try

            End If

        End If

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        checkIfExist()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Dispose()

    End Sub


    Public Sub checkIfExist()

        Dim query As String = "SELECT * FROM tbl_schedule INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id WHERE tbl_schedule.time = '" & cbed_time.Text & "' and tbl_schedule.day = '" & cbed_day.Text & "' and tbl_section.grade_level = '" & g.Text & "'"

        gc.boolean_retrieveup(query)

    End Sub

    Private Sub g_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles g.TextChanged
        Dim subjs As String = "select * from tbl_subject where grade_level = '" & g.Text & "'"
        gc.retrieve(subjs, "subject", cbed_subject)
    End Sub
End Class