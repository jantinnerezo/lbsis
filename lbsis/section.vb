Public Class section
    Public gc As New GlobalCodes
    Public a As String

    Dim tbl_section As String = "SELECT * from tbl_section"
    Public fields() As String = {"section_id", "section",
                      "grade_level"}




    Private Sub section_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gc.list_section(tbl_section, section_list, fields)

        btn_edit.Visible = False
        btn_delete.Visible = False

      
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        section_add.Show()
        Me.Dispose()

        btn_edit.Visible = False
        btn_delete.Visible = False

    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        a = s_id.Text
        section_edit.Show()


    End Sub

    Private Sub on_select()
        Try


            s_id.Text = section_list.SelectedRows(0).Cells(0).Value
            btn_edit.Visible = True
            btn_delete.Visible = True


        Catch ex As Exception

        End Try
    End Sub

    Private Sub section_list_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles section_list.MouseClick
        on_select()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you to delete Section named " & section_list.SelectedRows(0).Cells(1).Value & ", ", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            gc.delete("DELETE FROM tbl_section where section_id = @section_id", "@section_id", section_list.SelectedRows(0).Cells(0).Value, "Section successfully deleted")
            gc.list_section(tbl_section, section_list, fields)
        End If
    End Sub




    Private Sub search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.TextChanged
        gc.list_section(tbl_section & " where section like '%" & search.Text & "%'  or grade_level like '%" & search.Text & "%'", section_list, fields)
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub
End Class