Public Class enrolledlist
    Public gc As New GlobalCodes

    Public fields() As String = {"name",
                         "grade_level"}

    Dim tbl_stprof As String = "SELECT* from tbl_studprof INNER JOIN tbl_studlist ON tbl_studlist.stud_id = tbl_studprof.stud_id "


    Private Sub enrolledlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        gc.enrolled_list(tbl_stprof, final_enrolled, fields)


    End Sub


 

    Private Sub on_select()
        Try


            student.Text = final_enrolled.SelectedRows(0).Cells(0).Value
            stud_id.Text = final_enrolled.SelectedRows(0).Cells(2).Value
            studlist_id.Text = final_enrolled.SelectedRows(0).Cells(3).Value

            selected.Visible = True


        Catch ex As Exception
            selected.Visible = False
        End Try
    End Sub
   





    Private Sub cbgradelevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbgradelevel.SelectedIndexChanged
        If cbgradelevel.Text = "All" Then

            gc.enrolled_list(tbl_stprof, final_enrolled, fields)
        Else
            gc.enrolled_list(tbl_stprof & " where stud_gradelevel = '" & cbgradelevel.Text & "'", final_enrolled, fields)
        End If
    End Sub

  

    Private Sub final_enrolled_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles final_enrolled.MouseClick

        on_select()

    End Sub

    
    Private Sub final_enrolled_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles final_enrolled.CellContentClick

    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you to delete student named " & final_enrolled.SelectedRows(0).Cells(0).Value & ", " & final_enrolled.SelectedRows(0).Cells(1).Value, "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            gc.delete("DELETE FROM tbl_studlist where stud_id = @stud_id", "@stud_id", final_enrolled.SelectedRows(0).Cells(2).Value, "Student successfully deleted")
            gc.delete("DELETE FROM tbl_studlist where studlist_id = @studlist_id", "@studlist_id", final_enrolled.SelectedRows(0).Cells(3).Value, "")
            gc.enrolling("UPDATE tbl_studprof set status = '" & stud_status.Text & "', section_id = '" & sect.Text & "' where stud_id = '" & stud_id.Text & "' ")
            gc.enrolled_list(tbl_stprof, final_enrolled, fields)
            Home.function_class()


        End If
    End Sub

End Class