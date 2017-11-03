Public Class add_sched
    Public gc As New GlobalCodes
    Dim tbl_section As String = "select * from tbl_section"
    Dim tbl_subject As String = "select * from tbl_subject"
    Dim tbl_schoolyear As String = "select* from tbl_schoolyear"
    Dim tbl_teacher As String = "select * from tbl_login WHERE position = 'Teacher'"
    Dim grade As String = "select grade_level from tbl_section"
   
    Private Sub add_sched_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gc.retrieve(tbl_section, "section", cb_section)
        gc.retrieve(tbl_teacher, "name", cbteacher)
        gc.retrieve_field(tbl_schoolyear & " WHERE status = '1'", schoolyear)
    End Sub

    Private Sub cb_section_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_section.SelectedIndexChanged
        gc.retrieve_field(tbl_section & " WHERE section = '" & cb_section.Text & "'", sec_id)
        gc.retrieve_field(grade & " WHERE section = '" & cb_section.Text & "'", g)

       
    End Sub

    Private Sub cb_subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_subject.SelectedIndexChanged
      
        gc.retrieve_field(tbl_subject & " WHERE subject = '" & cb_subject.Text & "'", sub_id)

        Dim teacher As String = "select tbl_teacher.name from  tbl_subject INNER JOIN tbl_teacher ON tbl_teacher.teacher_id = tbl_subject.teacher_id where tbl_subject.subject = '" & cb_subject.Text & "' and tbl_subject.grade_level = '" & g.Text & "'"
        gc.retrieve(teacher, "name", cbteacher)

    End Sub

   


 

    Public Sub add_schedule()

        Dim message As String = "Schedule successfully added"
        Dim empty As Boolean





        Dim data() As String = {
            sec_id.Text,
            sub_id.Text,
            user_name.Text,
            cb_time.Text,
            cb_day.Text,
            schoolyear.Text
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

            Dim result As Integer = MessageBox.Show("Are you sure all the Schedule information is correct?", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then


                gc.insert("INSERT INTO tbl_schedule (`section_id`,`subject_id`,`username`,`time`,`day`,`school_year`)VALUES(@section_id,@subject_id,@username,@time,@day,@school_year)", gc.insert_schedule, data, message)
                gc.save_logs("INSERT INTO tbl_logs (`log`)VALUES(@log)", Home.user.Text & " Added new Schedule")



                cb_section.Text = ""
                cbteacher.Text = ""
                cb_subject.Text = ""
                cb_time.Text = ""

                cb_day.Text = ""



            End If

        End If

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click


        checkIfExist()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Dispose()


        scheduling.Show()



    End Sub

    Private Sub g_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles g.TextChanged
        Dim subjs As String = "select * from tbl_subject where grade_level = '" & g.Text & "'"
        gc.retrieve(subjs, "subject", cb_subject)
    End Sub


    Public Sub checkIfExist()

        Dim query As String = "SELECT * FROM `tbl_schedule` INNER JOIN tbl_section ON tbl_section.section_id = tbl_schedule.section_id INNER JOIN tbl_subject ON tbl_subject.subject_id = tbl_schedule.subject_id  WHERE tbl_subject.subject = '" & cb_subject.Text & "' and tbl_section.section = '" & cb_section.Text & "' and tbl_schedule.time = '" & cb_time.Text & "' and tbl_schedule.day = '" & cb_day.Text & "' and tbl_section.grade_level = '" & g.Text & "' and tbl_schedule.school_year = '" & schoolyear.Text & "'"
        gc.boolean_retrieve(query)
        gc.save_logs("INSERT INTO tbl_logs (`log`)VALUES(@log)", Home.user.Text & " Added a schedule " & " for section " & cb_section.Text)


    End Sub

  
    Private Sub cbteacher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbteacher.SelectedIndexChanged
        Dim query As String = "select username from tbl_login where name = '" & cbteacher.Text & "'"
        gc.retrieve_field(query, user_name)
    End Sub
End Class