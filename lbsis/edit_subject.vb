Public Class edit_subject

    Public gc As New GlobalCodes
    Dim tbl_teacher As String = "select * from tbl_teacher"





    Private Sub edit()
        Dim message As String = "Subject Data successfully Updated"
        Dim empty As Boolean

        Dim data() As String = {t_id.Text,
                                txted_subj.Text,
                                cbed_level.Text
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

            Dim result As Integer = MessageBox.Show("Are you sure all the user information is correct?", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Try
                    gc.subject_edit("UPDATE tbl_subject set  teacher_id = '" & t_id.Text & "', subject = '" & txted_subj.Text & "', grade_level = '" & cbed_level.Text & "'  where subject_id = '" & subject.a & "' ")




                    Me.Dispose()
                    subject.Dispose()
                    subject.Show()






                Catch ex As Exception
                    MsgBox(ex)

                End Try

            End If

        End If

    End Sub

    Private Sub edit_subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim edit As String = "SELECT * FROM tbl_subject where subject_id = '" & subject.subject_list.SelectedRows(0).Cells(0).Value & "'"
        gc.subject_edit(edit)


        gc.retrieve(tbl_teacher, "name", cbed_teacher)
        cbed_teacher.Text = subject.t_id.Text




    End Sub


    Private Sub cbed_teacher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbed_teacher.SelectedIndexChanged
        gc.retrieve_field(tbl_teacher & " WHERE name = '" & cbed_teacher.Text & "'", t_id)
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        edit()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Dispose()

    End Sub



End Class