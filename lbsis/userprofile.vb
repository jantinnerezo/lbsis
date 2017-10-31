Public Class userprofile
    Public gc As New GlobalCodes
    Public fields() As String = {"name", "position", "address", "username", "password"}



    Private Sub userprofile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim users As String = "SELECT * from tbl_login WHERE name = '" & manageusers.users_list.SelectedRows(0).Cells(0).Value & "'"

        gc.users_profile(users, user_prof)

    End Sub
End Class