Public Class section_edit
    Public gc As New GlobalCodes
    Dim tbl_teacher As String = "SELECT * from tbl_login where position = 'Teacher'"


    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        edit()
    End Sub



    Private Sub edit()
        Dim message As String = "Section Data successfully Upadted"
        Dim empty As Boolean

        Dim data() As String = {
                        txted_section.Text,
                        cbed_adviser.Text,
                        cbed_level.Text}






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

            Dim result As Integer = MessageBox.Show("Are you sure all the Section data is correct?", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Try
                    gc.edit_section("UPDATE tbl_section set section = '" & txted_section.Text & "', adviser = '" & cbed_adviser.Text & "', grade_level = '" & cbed_level.Text & "' where section_id = '" & section.a & "' ")

                    gc.save_logs("INSERT INTO tbl_logs (`log`)VALUES(@log)", Home.user.Text & " Updated the section named " & prev_sec.Text & " to " & txted_section.Text)


                    Me.Dispose()
                    section.Dispose()
                    section.Show()






                Catch ex As Exception
                    MsgBox(ex)

                End Try

            End If

        End If

    End Sub

    Private Sub section_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        gc.retrieve(tbl_teacher, "name", cbed_adviser)
        Dim edit As String = "SELECT * FROM tbl_section where section_id = '" & section.section_list.SelectedRows(0).Cells(0).Value & "'"
        gc.edit_section(edit)


    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Dispose()

    End Sub

    Private Sub txted_section_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txted_section.TextChanged

    End Sub
End Class