Public Class verification

    Public gc As New GlobalCodes


    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        gc.login_user("SELECT password from tbl_login WHERE BINARY password = '" & pass.Text & "'")





        registrationform.Show()
        registrationform.regpassword.Visible = True
        registrationform.submit_btn.Visible = True
        registrationform.submit.Visible = False

        Me.Dispose()


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass.TextChanged

    End Sub

    Private Sub verification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class