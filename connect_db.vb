Imports MySql.Data.MySqlClient

Module Databaseconnection

    Public connection As New MySqlConnection
    Public adapter As New MySqlDataAdapter
    Public ds As New DataSet
    Public student_list As New DataGridView



    Public Sub Connected()

        Try

            If connection.State = ConnectionState.Closed Then

                student_list = Students.student_list
                Dim servername As String = "localhost"

                Dim username As String = "root"
                Dim password As String = ""
                connection.ConnectionString = "Server = " & servername & "; User id = " & username & "; Password=" & password & ";Database=lbsis_db"
                connection.Open()

            End If
        Catch ex As Exception

            MsgBox("Can't connect to server, Please verify your connection to server or" & vbNewLine & "Contact System Administrator.", vbCritical)


        End Try

    End Sub



End Module
