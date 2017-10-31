Public Class registrationform
    Public gc As New GlobalCodes


    Private Sub addstaff()
        Dim message As String = "Staff Successfully Registered"
        Dim empty As Boolean


        Dim data() As String = {regname.Text,
                               cbposition.Text,
                                regaddress.Text,
                                regusername.Text,
                                regpassword.Text}

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

          
            gc.insertstaff("INSERT INTO tbl_login (`name`,`position`,`address`,`username`,`password`)VALUES(@name,@position,@address,@username,@password)", gc.insert_staff, data, message)
            regname.Text = ""
            cbposition.Text = ""
            regaddress.Text = ""
            regusername.Text = ""
            regpassword.Text = ""

        End If


    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        Call addstaff()




    End Sub



   

    
   
    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click
        Call addstaff()
        manageusers.Dispose()
        manageusers.Show()

    End Sub
End Class