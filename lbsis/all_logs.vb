Public Class all_logs

    Public GC As New GlobalCodes ' Call GlobalCodes class
    Public fields() As String = {
                         "log_id",
                         "log",
                         "timestamp"
                       }
    Private Sub all_logs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GC.populate_logs("SELECT* from tbl_logs", log_list, fields)
    End Sub

    Private Sub search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.TextChanged
        GC.populate_logs("SELECT* from tbl_logs where log like '%" & search.Text & "%'", log_list, fields)
    End Sub
End Class