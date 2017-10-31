Public Class usereditform

    Public gc As New GlobalCodes


    Private Sub usereditform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim users As String = "SELECT * FROM tbl_login where name = '" & manageusers.users_list.SelectedRows(0).Cells(0).Value & "'"
        gc.edit_profileusers(users)

    End Sub



    Private Sub edit()
        Dim message As String = "User Profile successfully Upadted"
        Dim empty As Boolean

        Dim data() As String = {
                         ename.Text,
                        ecbposition.Text,
                        eaddress.Text,
                        eusername.Text,
                        epassword.Text
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
                    gc.edit_profile("UPDATE tbl_login set username = '" & eusername.Text & "',position = '" & ecbposition.Text & "',address = '" & eaddress.Text & "' , name = '" & ename.Text & "',password = '" & epassword.Text & "' where username = '" & manageusers.a & "' ")


                    Me.Dispose()
                    manageusers.Dispose()

                    manageusers.Show()





                Catch ex As Exception
                    MsgBox(ex)

                End Try

            End If

        End If

    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        edit()
 
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        Me.Dispose()


    End Sub
End Class