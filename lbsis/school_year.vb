Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports MySql.Data
Public Class school_year
    Public gc As New GlobalCodes
    Private Sub school_year_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        school_year_list()
    End Sub



    Private Sub add_sy()

        Dim message As String = "New school year successfully added!"
        Dim empty As Boolean
        Dim status As Integer = 1

        Dim data() As String = {
            sy.Text,
            status
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

            Dim result As Integer = MessageBox.Show("Are you sure all the school year information is correct?", "Submit dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then


                gc.insert("INSERT INTO tbl_schoolyear (`school_year`,`status`)VALUES(@school_year,@status)", gc.insert_sy, data, message)

            End If

        End If

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        gc.check_status()
        add_sy()
    End Sub

    Public Sub school_year_list()

        sy_list.Items.Clear()

        Dim query As String = "SELECT* from tbl_schoolyear ORDER BY status ASC"

        Try
            Connected()

            Dim sqlAdapter As New MySqlDataAdapter
            Dim sqlCommand As New MySqlCommand
            Dim table As New DataTable
            Dim i As Integer

            With sqlCommand

                .CommandText = query
                .Connection = connection

            End With

            With sqlAdapter

                .SelectCommand = sqlCommand
                .Fill(table)

            End With


            For Each rows In table.Rows
                With sy_list
                    .Items.Add(rows("school_year"))
                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            ''MsgBox(ex)
            Console.Write(ex)

        End Try

    End Sub
End Class