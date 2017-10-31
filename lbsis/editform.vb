Public Class editform
    Public gc As New GlobalCodes
    Dim tbl_religion As String = "SELECT* from tbl_religion"
    Dim tbl_citizenship As String = "SELECT* from tbl_citizenship"


    Private Sub editform_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub editform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim stud As String = "SELECT * FROM tbl_studprof INNER JOIN tbl_citizenship ON tbl_citizenship.citizenship_id = tbl_studprof.citizenship_id INNER JOIN tbl_religion ON tbl_religion.religion_id = tbl_studprof.religion_id where tbl_studprof.stud_id = '" & Home.student_list.SelectedRows(0).Cells(0).Value & "'"


        gc.edit_profile(stud)



        gc.retrieve(tbl_religion, "religion", stud_religion)
        gc.retrieve(tbl_citizenship, "citizenship", stud_citizenship)
    End Sub

    Private Sub edit()

        Dim empty As Boolean

        Dim data() As String = {
                        student_id.Text,
                          stud_gradelevel.Text,
                         stud_lastname.Text,
                         stud_firstname.Text,
                         stud_middlename.Text,
                         stud_birthdate.Text,
                         stud_age.Text,
                         stud_gender.Text,
                         citizenship_id.Text,
                        religion_id.Text,
                         stud_address.Text,
                         stud_contactnum.Text,
                         stud_mothername.Text,
                         stud_motherocc.Text,
                         stud_fathername.Text,
                         stud_fatherocc.Text,
                         stud_health.Text,
                         stud_allergy.Text}






        For x = 1 To data.Length - 1

            If data(x).ToString = "" Then

                empty = True

            Else
                empty = False

            End If

        Next

        If empty = True Then

            MessageBox.Show("Please complete all fields!", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf stud_gradelevel.Text = "SELECT" Then


            MessageBox.Show("Please complete all fields!", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf stud_birthdate.Text = "--Month/Day/Year--" Then
            MessageBox.Show("Please complete all fields!", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf stud_citizenship.Text = "SELECT" Then
            MessageBox.Show("Please complete all fields!", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf stud_citizenship.Text = "SELECT" Then

            MessageBox.Show("Please complete all fields!", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf stud_religion.Text = "SELECT" Then
            MessageBox.Show("Please complete all fields!", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf stud_gender.Text = "SELECT" Then
            MessageBox.Show("Please complete all fields!", "Complete all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)



        Else

            Dim result As Integer = MessageBox.Show("Are you sure all the student information is correct?", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Try
                    gc.edit_profile("UPDATE tbl_studprof set stud_id = '" & student_id.Text & "', stud_gradelevel = '" & stud_gradelevel.Text & "',stud_lastname = '" & stud_lastname.Text & "' ,stud_firstname = '" & stud_firstname.Text & "',stud_middlename = '" & stud_middlename.Text & "',stud_birthdate = '" & stud_birthdate.Text & "',stud_age = '" & stud_age.Text & "',stud_gender = '" & stud_gender.Text & "',citizenship_id = '" & citizenship_id.Text & "',religion_id = '" & religion_id.Text & "',stud_address = '" & stud_address.Text & "',stud_contactnum = '" & stud_contactnum.Text & "',stud_mothername= '" & stud_mothername.Text & "',stud_motherocc = '" & stud_motherocc.Text & "',stud_fathername = '" & stud_fathername.Text & "',stud_fatherocc = '" & stud_fatherocc.Text & "',stud_health = '" & stud_health.Text & "',stud_allergy = '" & stud_allergy.Text & "' where stud_id = '" & student_id.Text & "' ")
                    MsgBox("Student Profile Successfully Updated!", MessageBoxIcon.Information)


                    Home.function_class()
                    Me.Dispose()



                Catch ex As Exception
                    MsgBox(ex)

                End Try

            End If

        End If

    End Sub


    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Home.Show()

    End Sub

    Private Sub edit_religion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gc.retrieve_field(tbl_religion & " WHERE religion = '" & stud_religion.Text & "'", religion_id)
    End Sub



    Private Sub submit_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        edit()
    End Sub

    Private Sub stud_religion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stud_religion.SelectedIndexChanged
        gc.retrieve_field(tbl_citizenship & " WHERE citizenship = '" & stud_citizenship.Text & "'", citizenship_id)
    End Sub

    Private Sub clear_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        Me.Dispose()

    End Sub
End Class