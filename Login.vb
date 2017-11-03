Public Class Login
    Public gc As New GlobalCodes

    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click
        gc.login_user("SELECT* from tbl_login WHERE BINARY username = '" & username.Text & "' and BINARY password = '" & password.Text & "'")

    End Sub
    Private Sub username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.TextChanged
        Me.err.Visible = False
    End Sub

    Private Sub password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password.TextChanged
        Me.err.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        verification.Show()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class