Public Class manageusers

    Public GC As New GlobalCodes ' Call GlobalCodes class
    Public a As String


    Public fields() As String = {"name", "position", "address", "username", "password"
                       }

    Dim tbl_users As String = "SELECT* from tbl_login"



    Private Sub manageusers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        GC.populate_users(tbl_users, users_list, fields)

        Home.function_class()


    End Sub

    Private Sub on_select()
        Try
            student.Text = users_list.SelectedRows(0).Cells(3).Value & ""
            selected.Visible = True

        Catch ex As Exception
            selected.Visible = False
        End Try
    End Sub


    Private Sub users_list_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles users_list.MouseClick


        on_select()
    End Sub

   
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click


        a = student.Text

        usereditform.Show()
        Me.Hide()



    End Sub

   
    Private Sub view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view.Click
        userprofile.stud_name.Text = "      " & users_list.SelectedRows(0).Cells(0).Value & ""
        userprofile.ShowDialog()
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you to delete student named " & users_list.SelectedRows(0).Cells(1).Value & ", " & users_list.SelectedRows(0).Cells(2).Value, "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            GC.delete("DELETE FROM tbl_login where name = @name", "@name", users_list.SelectedRows(0).Cells(0).Value, "User successfully deleted")

            

            GC.populate_users(tbl_users, users_list, fields)





        End If


    End Sub

   
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        registrationform.Show()
        Me.Dispose()

        registrationform.submit_btn.Visible = False
        registrationform.submit.Visible = True


    End Sub


    Private Sub btn_Add_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        registrationform.Show()

        registrationform.submit_btn.Visible = False
        registrationform.submit.Visible = True

    End Sub
End Class