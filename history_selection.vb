Public Class history_selection

    Public gc As New GlobalCodes
    Dim sy As String = "Select * from tbl_schoolyear"



    Private Sub history_selection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gc.retrieve(sy, "school_year", cb_sy)
    End Sub

    Private Sub btn_enroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enroll.Click

        Records.glevel.Text = grade_level.Text
        Records.sy.Text = cb_sy.Text
        Records.Show()
        Me.Hide()


    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Dispose()

    End Sub
End Class