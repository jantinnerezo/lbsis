Public Class section_add

    Public gc As New GlobalCodes
    Dim tbl_teacher As String = "SELECT * from tbl_login where position = 'Teacher'"


    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        add_section()

       
    End Sub



    Private Sub add_section()

        Dim message As String = "Section successfully added"
        Dim empty As Boolean


        Dim data() As String = {
            txt_section.Text,
            cb_level.Text,
            cb_adviser.Text
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

            Dim result As Integer = MessageBox.Show("Are you sure all the Section information is correct?", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then

                gc.insert("INSERT INTO tbl_section (`section`,`grade_level`,`adviser`)VALUES(@section,@grade_level,@adviser)", gc.insert_section, data, message)

                gc.save_logs("INSERT INTO tbl_logs (`log`)VALUES(@log)", Home.user.Text & " Added a section named " & txt_section.Text & " for " & cb_level.Text)
                txt_section.Text = ""
                cb_level.Text = ""
                cb_adviser.Text = ""


            End If

        End If

    End Sub

    Private Sub section_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gc.retrieve(tbl_teacher, "name", cb_adviser)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Dispose()
        section.Dispose()

        section.Show()


    End Sub

   

End Class