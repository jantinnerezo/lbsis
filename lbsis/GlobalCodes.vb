Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports MySql.Data

Public Class GlobalCodes

  



    Public username As String ' User username declaration
    Public password As String ' User password declaration

    ' Array students fields declaration
    Public fields() As String = {
                            "stud_id",
                            "stud_gradelevel",
                           "stud_lastname",
                           "stud_firstname",
                           "stud_middlename",
                           "stud_birthdate",
                           "stud_gender",
                           "citizenship",
                           "religion",
                           "stud_address",
                           "stud_contactnum",
                           "stud_mothername",
                           "stud_motherocc",
                           "stud_fathername",
                           "stud_fatherocc",
                           "stud_health",
                           "stud_allergy"}

    Public fields2() As String = {
                         "stud_id",
                         "username",
                         "violation_id",
                         "violation",
                         "date_violation",
                         "violation_time"
    }

    Public log_fields() As String = {
                       "log"
                     }

    ' Array students fields declaration for student profile
    Public fields_profile() As String = {
                        "Student ID",
                        "Grade Level",
                         "Lastname",
                         "Firstname",
                         "Middlename",
                         "Birthdate",
                         "Gender",
                         "Citizenship",
                         "Religion",
                         "Address",
                         "Contact number",
                         "Mother name",
                         "Occupation",
                         "Father name",
                         "Occupation",
                         "Health",
                         "Allergy",
                         "Status"
}

    Public fields_profileusers() As String = {"Name",
                         "Position",
                         "Address",
                         "Username",
                         "Password"
                        }


    ' Array students fields declaration for inserting students data
    Public insert_fields() As String = {"@stud_id", "@status", "@stud_gradelevel",
                      "@stud_lastname",
                      "@stud_firstname",
                      "@stud_middlename",
                      "@stud_birthdate",
                      "@stud_gender",
                      "@citizenship",
                      "@religion",
                      "@stud_address",
                      "@stud_contactnum",
                      "@stud_mothername",
                      "@stud_motherocc",
                      "@stud_fathername",
                      "@stud_fatherocc",
                      "@stud_health",
                      "@stud_allergy"}


    ' Array staff fields declaration for inserting staff data
    Public insert_staff() As String = {"@name", "@position", "@address",
                     "@username",
                     "@password"}
    Public insert_subject() As String = {"@subject", "@grade_level"}
    Public insert_section() As String = {"@section", "@grade_level"}
    Public insert_schedule() As String = {"@section_id", "@subject_id", "@username", "@time", "@day", "@school_year"}
    Public insert_sy() As String = {"@school_year", "@status"}

    Public insert_fieldstudlist() As String = {"@stud_id"}

    Public anecdotalfields() As String = {"name_teacher", "date_violation", "violation", "student_id", "teacher_id"}

    Public anecdotalinsert_fields() As String = {"@date_violation", "@violation_time", "@violation", "@student_id", "@username", "@school_year"}



    '   Function: retrieve - this function populates a combo box
    '   Number of parameters: 3
    '   Parameter 1: query - Database query ex.(SELECT* from table)
    '   Parameter 2: field - Specify database table field
    '   Parameter 3: combo - Target combo box name should passed in this parameter

    Public Sub retrieve(ByVal query As String, ByVal field As String, ByVal combo As ComboBox)

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

            combo.Items.Clear()
            For i = 0 To table.Rows.Count - 1

                With combo

                    .Items.Add(table.Rows(i).Item(field)) ' Populate the target combo box

                End With


            Next
            connection.Close()
        Catch ex As Exception

            Console.Write(ex)
            connection.Close()

        End Try

    End Sub


    '   Function: retrieve_field - Get single field from database table
    '   Number of parameters: 2
    '   Parameter 1: query - Database query that get a single field from database table without the all sign * (ex. SELECT field from table)
    '   Parameter 2: text - Target components like Labels, TextBoxes etc.
    Public Sub retrieve_field(ByVal query As String, ByVal text As Label)

        Try
            Connected()
            Dim sqlAdapter As New MySqlDataAdapter
            Dim sqlCommand As New MySqlCommand
            Dim table As New DataTable
            '' Dim i As Integer

            With sqlCommand

                .CommandText = query
                .Connection = connection

            End With

            With sqlAdapter

                .SelectCommand = sqlCommand
                .Fill(table)

            End With

            If table.Rows.Count > 0 Then
                text.Text = table.Rows(0).Item(0)
            End If
            connection.Close()
        Catch ex As Exception
            Console.Write(ex)
            connection.Close()

        End Try


    End Sub

    '   Function: Login - this function will check users username and password to the database
    '   Number of parameters: 1
    '   Parameter 1: query - Database query ex.(SELECT* from table where username = 'username' and password = 'username')
    Public Sub login_user(ByVal query As String)

        Try
            Connected()
            Dim sqlAdapter As New MySqlDataAdapter
            Dim sqlCommand As New MySqlCommand
            Dim table As New DataTable


            With sqlCommand

                .CommandText = query
                .Connection = connection

            End With

            With sqlAdapter

                .SelectCommand = sqlCommand
                .Fill(table)

            End With



            If table.Rows.Count > 0 Then ' If username and password is valid

                '   The user is a administrator 
                If table.Rows(0).Item("position") = "Admin" Then
                    username = table.Rows(0).Item("name")
                    Home.user.Text = username
                    Home.registrar_menu.Visible = False
                    Home.admin_menu.Visible = True
                    Home.teacher_menu.Visible = False
                    Home.user_name.Text = table.Rows(0).Item("username")
                    Home.position.Text = table.Rows(0).Item("position")
                    Login.Dispose()
                    Home.Show()


                    '   The user is a teacher
                ElseIf table.Rows(0).Item("position") = "Teacher" Then

                    Home.registrar_menu.Visible = False
                    Home.admin_menu.Visible = False
                    Home.teacher_menu.Visible = True
                    username = table.Rows(0).Item("name")
                    Home.user_name.Text = table.Rows(0).Item("username")
                    Home.position.Text = table.Rows(0).Item("position")
                    Home.user.Text = username
                    Login.Dispose()
                    Home.Show()

                    '   The user is a registrar
                Else

                    username = table.Rows(0).Item("name")
                    Home.registrar_menu.Visible = True
                    Home.admin_menu.Visible = False
                    Home.teacher_menu.Visible = False
                    Home.user_name.Text = table.Rows(0).Item("username")
                    Home.position.Text = table.Rows(0).Item("position")
                    Login.Dispose()
                    Home.Show()


                End If


                '====================== LOGS INSERTION ===============================
                ' Ibutang ni sya gard every insert and update sa ubos
                save_logs("INSERT INTO tbl_logs (`log`)VALUES(@log)", username & " logged in to the system")

            Else '' If username and password is invalid then show the error message

                Login.err.Visible = True

            End If
            connection.Close()


        Catch ex As Exception

            Console.Write(ex)
            connection.Close()

        End Try

    End Sub



    Public Sub check_status()

      
            Dim q As String = "UPDATE tbl_schoolyear SET STATUS = 0"

                Dim sql_command = New MySqlClient.MySqlCommand(q, connection)
                Try
                    Connected()

                    If sql_command.ExecuteNonQuery() > 0 Then

                    End If
                    connection.Close()
                Catch ex As Exception

                End Try
  
    End Sub


    '   Function: populate_datagridview - this function populates the rows and columns of datagridview
    '   Number of parameters: 3
    '   Parameter 1: query - Database query ex.(SELECT* from table)
    '   Parameter 2: datagridview - The target datagridview name
    '   Parameter 3: fields - Datagridview field or column names
    Public Sub populate_datagridview(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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


            For Each rows In table.Rows '   Loop through table rows
                count = table.Rows.Count '  Count all rows in the table
                With datagridview

                  

                    datagridview.Rows.Add(rows("stud_id"), rows("status"), "Grade " & rows("stud_gradelevel"), rows("stud_lastname"), rows("stud_firstname"), rows("stud_middlename"), rows("stud_birthdate"), rows("stud_gender"))


                End With
            Next
            Home.student_count.Text = count
            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub


    Public Sub populate_logs(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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


            For Each rows In table.Rows '   Loop through table rows
                count = table.Rows.Count '  Count all rows in the table
                With datagridview



                    datagridview.Rows.Add(rows("log_id"), rows("log"), rows("timestamp"))


                End With
            Next
            Home.student_count.Text = count
            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub
    Public Sub populate_sched(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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


            For Each rows In table.Rows '   Loop through table rows
                count = table.Rows.Count '  Count all rows in the table
                With datagridview



                    datagridview.Rows.Add(rows("sched_id"), rows("section"), rows("subject"), rows("name"), rows("time"), rows("day"))


                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub

    Public Sub populate_success(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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


            For Each rows In table.Rows '   Loop through table rows
                count = table.Rows.Count '  Count all rows in the table
                With datagridview



                    datagridview.Rows.Add(rows("subject"), rows("name"), rows("day"), rows("time"))


                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub


    Public Sub historyList(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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


            For Each rows In table.Rows '   Loop through table rows
                count = table.Rows.Count '  Count all rows in the table
                With datagridview


                    Dim n As String = rows("stud_firstname") & " " & rows("stud_lastname")
                    datagridview.Rows.Add(n, rows("grade_level"), rows("section"))


                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub



    Public Sub classList(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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


            For Each rows In table.Rows '   Loop through table rows
                count = table.Rows.Count '  Count all rows in the table
                With datagridview



                    datagridview.Rows.Add(rows("subject"), rows("section"), rows("grade_level"), rows("time"), rows("day"), rows("school_year"))


                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub



    Public Sub populate_teachers(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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


            For Each rows In table.Rows '   Loop through table rows
                count = table.Rows.Count '  Count all rows in the table
                With datagridview

                    datagridview.Rows.Add(rows("username"), rows("name"))

                End With
            Next

            connection.Close()

        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub

   


    '   Function: populate_violation - this function populate the rows and columns of datagridview
    '   Number of parameters: 3
    '   Parameter 1: query - Database query ex.(SELECT* from table)
    '   Parameter 2: datagridview - The target datagridview name
    '   Parameter 3: fields - Datagridview field or column names
    Public Sub populate_violation(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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
                count = table.Rows.Count
                With datagridview
                    datagridview.Rows.Add(rows("stud_id"), rows("username"), rows("violation_id"), rows("stud_firstname") & " " & rows("stud_lastname"), rows("violation"), rows("date_violation"), rows("violation_time"))
                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            ''MsgBox(ex)
            Console.Write(ex)

        End Try

    End Sub



    Public Sub populate_history(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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
                count = table.Rows.Count
                With datagridview
                    datagridview.Rows.Add(rows("sched_id"), rows("section"), rows("subject"), rows("name"), rows("time"), rows("day"), rows("school_year"))
                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            ''MsgBox(ex)
            Console.Write(ex)

        End Try

    End Sub

    '   Function: populate_users - this function populate the rows and columns of datagridview
    '   Number of parameters: 3
    '   Parameter 1: query - Database query ex.(SELECT* from table)
    '   Parameter 2: datagridview - The target datagridview name
    '   Parameter 3: fields - Datagridview field or column names

    Public Sub populate_users(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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
                count = table.Rows.Count
                With datagridview
                    datagridview.Rows.Add(rows("name"), rows("position"), rows("address"), rows("username"), rows("password"))
                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            ''MsgBox(ex)
            Console.Write(ex)

        End Try

    End Sub


    '   Function: insert - this function adds new record to the database table
    '   Number of parameters: 4
    '   Parameter 1: query - Database query ex.(Insert into table)
    '   Parameter 2: fields - Database table fields to be inserted
    '   Parameter 3: data - The data to be inserted
    '   Parameter 3: message - Message after inserting the data

    Public Sub insert(ByVal query As String, ByVal fields() As Object, ByVal data() As Object, ByVal message As String)

        Dim sql_command = New MySqlClient.MySqlCommand(query, connection)

        For x = 0 To fields.Length - 1 '    Loop through the fields and insert the data

            sql_command.Parameters.AddWithValue(fields(x), data(x))

        Next

        Try
            Connected()

            If sql_command.ExecuteNonQuery() > 0 Then ' If insertion is successful

                MessageBox.Show(message, "Lan-based Student Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.clear_fields()
                Home.function_class()
                scheduling.loadup()

                Anecdotal.Dispose()
                school_year.Dispose()

            Else
                MessageBox.Show("Error!", "Lan-based Student Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection.Close()
        Catch ex As Exception

            MessageBox.Show("School year already exist", "Lan-based Student Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Console.Write(ex)
        End Try



    End Sub


    Public Sub save_logs(ByVal query As String, ByVal data As String)

        Dim sql_command = New MySqlClient.MySqlCommand(query, connection)


        Try
            Connected()
            sql_command.Parameters.AddWithValue("@log", data)
            sql_command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception


        End Try



    End Sub

    ' Same details with the function: insert

    Public Sub insert_anec(ByVal query As String, ByVal fields() As Object, ByVal data() As Object, ByVal message As String)

        Dim sql_command = New MySqlClient.MySqlCommand(query, connection)

        For x = 0 To fields.Length - 1

            sql_command.Parameters.AddWithValue(fields(x), data(x))

        Next

        Try
            Connected()

            If sql_command.ExecuteNonQuery() > 0 Then

                MessageBox.Show(message, "Lan-based Student Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


                Anecdotal.Dispose()

            Else

            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex)
            Console.Write(ex)
        End Try



    End Sub
    '   Function: update - this function updates the record from a database table
    '   Number of parameters: 4
    '   Parameter 1: query - Database query ex.(Update table set)
    '   Parameter 2: fields - Database table fields to be updated
    '   Parameter 3: data - New data to update
    '   Parameter 3: message - Message after updating the data
    Public Sub update(ByVal query As String, ByVal fields() As Object, ByVal data() As Object, ByVal message As String)

        Dim sql_command = New MySqlClient.MySqlCommand(query, connection)

        For x = 0 To fields.Length - 1

            sql_command.Parameters.AddWithValue(fields(x), data(x))

        Next

        Try
            Connected()

            If sql_command.ExecuteNonQuery() > 0 Then
                MessageBox.Show(message, "Lan-based Student Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.clear_fields()
                Home.function_class()
                editform.student_id.Text = data(0)
               

                Anecdotal.Dispose()
            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            Console.Write(ex)
        End Try



    End Sub


    ' Same details with the function: insert
    Public Sub insertstaff(ByVal query As String, ByVal fields() As Object, ByVal data() As Object, ByVal message As String)

        Dim sql_command = New MySqlClient.MySqlCommand(query, connection)

        For x = 0 To fields.Length - 1

            sql_command.Parameters.AddWithValue(fields(x), data(x))

        Next

        Try
            Connected()

            If sql_command.ExecuteNonQuery() > 0 Then
                MessageBox.Show(message, "Lan-based Student Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            Console.Write(ex)
        End Try



    End Sub

    '   Function: delete - this function deletes a record from a database table
    '   Number of parameters: 4
    '   Parameter 1: query - Database query ex.(delete from table where id = id)
    '   Parameter 2: fields - Database table field to be call
    '   Parameter 3: data - Datable table row id data
    '   Parameter 3: message - Message after deleting the data
    Public Sub delete(ByVal query As String, ByVal field As String, ByVal data As String, ByVal message As String)

        Dim sql_command = New MySqlClient.MySqlCommand(query, connection)
        sql_command.Parameters.AddWithValue(field, data)

        Try
            Connected()

            If sql_command.ExecuteNonQuery() > 0 Then
                MessageBox.Show(message, "Lan-based Student Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.function_class()


            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            Console.Write(ex)
        End Try



    End Sub


    ' Same details with function: populate_datagridview
    Public Sub student_profile(ByVal query As String, ByVal datagridview As DataGridView)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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
                count = table.Rows.Count

                For x = 0 To fields.Length - 1
                    With datagridview

                        datagridview.Rows.Add(fields_profile(x), rows(x))


                    End With
                Next
            Next
            Home.student_count.Text = count
            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub


    ' Same details with function: populate_datagridview
    Public Sub tempstudent_profile(ByVal query As String, ByVal datagridview As DataGridView)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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
                count = table.Rows.Count

                For x = 0 To fields.Length - 1
                    With datagridview

                        datagridview.Rows.Add(fields_profile(x), rows(x))


                    End With
                Next
            Next
            Home.student_count.Text = count
            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub


    ' Same details with function: populate_datagridview
    Public Sub users_profile(ByVal query As String, ByVal datagridview As DataGridView)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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
                count = table.Rows.Count

                For x = 0 To fields.Length - 1
                    With datagridview

                        datagridview.Rows.Add(fields_profileusers(x), rows(x))


                    End With
                Next
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub

    '   Function: edit_profile - This will pass the data to form labels
    '   Number of parameters: 1
    '   Parameter 1: query - Database query ex.(select* from table where id = id)
   
    Public Sub edit_profile(ByVal query As String)


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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

            If table.Rows.Count > 0 Then

              
                editform.stud_lastname.Text = table.Rows(0).Item("stud_lastname")
                editform.stud_firstname.Text = table.Rows(0).Item("stud_firstname")
                editform.stud_middlename.Text = table.Rows(0).Item("stud_middlename")
                editform.stud_birthdate.Text = table.Rows(0).Item("stud_birthdate")
                editform.stud_gender.Text = table.Rows(0).Item("stud_gender")
                editform.stud_citizenship.Text = table.Rows(0).Item("citizenship")
                editform.stud_religion.Text = table.Rows(0).Item("religion")
                editform.stud_address.Text = table.Rows(0).Item("stud_address")
                editform.stud_contactnum.Text = table.Rows(0).Item("stud_contactnum")
                editform.stud_mothername.Text = table.Rows(0).Item("stud_mothername")
                editform.stud_motherocc.Text = table.Rows(0).Item("stud_motherocc")
                editform.stud_fathername.Text = table.Rows(0).Item("stud_fathername")
                editform.stud_fatherocc.Text = table.Rows(0).Item("stud_fatherocc")
                editform.stud_health.Text = table.Rows(0).Item("stud_health")
                editform.stud_allergy.Text = table.Rows(0).Item("stud_allergy")
                editform.stud_gradelevel.Text = table.Rows(0).Item("stud_gradelevel")
                editform.student_id.Text = table.Rows(0).Item("stud_id")
                editform.citizenship_id.Text = table.Rows(0).Item("citizenship_id")
                editform.religion_id.Text = table.Rows(0).Item("religion_id")
              


            End If

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub

    Public Sub load_gradelevel(ByVal query As String)


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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

            If table.Rows.Count > 0 Then


                enrollment_assign.cb_glevel.Text = table.Rows(0).Item("stud_gradelevel")




            End If

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub
    Public Sub enroll_assign(ByVal query As String)


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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

            If table.Rows.Count > 0 Then


                enrollment_assign.cb_glevel.Text = table.Rows(0).Item("grade_level")
                enrollment_assign.cb_sect.Text = table.Rows(0).Item("section")

                enrollment_assign.stud_status.Text = table.Rows(0).Item("status")





            End If

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub

    Public Sub subject_edit(ByVal query As String)


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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

            If table.Rows.Count > 0 Then



                edit_subject.t_id.Text = table.Rows(0).Item("teacher_id")
                edit_subject.txted_subj.Text = table.Rows(0).Item("subject")
                edit_subject.cbed_level.Text = table.Rows(0).Item("grade_level")


            End If

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub
    Public Sub sched_edit(ByVal query As String)


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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

            If table.Rows.Count > 0 Then


                edit_sched.cbed_section.Text = table.Rows(0).Item("section")
                edit_sched.cbed_subject.Text = table.Rows(0).Item("subject")
                edit_sched.cbedteacher.Text = table.Rows(0).Item("teacher")
                edit_sched.cbed_time.Text = table.Rows(0).Item("time")
                edit_sched.cbed_day.Text = table.Rows(0).Item("day")
                edit_sched.sec_id.Text = table.Rows(0).Item("section_id")
                edit_sched.sub_id.Text = table.Rows(0).Item("subject_id")
                


               

              


            End If

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub

    Public Sub edit_section(ByVal query As String)


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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

            If table.Rows.Count > 0 Then


                section_edit.txted_section.Text = table.Rows(0).Item("section")
                section_edit.cbed_adviser.Text = table.Rows(0).Item("adviser")
                section_edit.cbed_level.Text = table.Rows(0).Item("grade_level")


            End If

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub

    '   Function: edit_profile - This will pass the data to form labels
    '   Number of parameters: 1
    '   Parameter 1: query - Database query ex.(select* from table where id = id)

    Public Sub enrolling(ByVal query As String)


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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

            If table.Rows.Count > 0 Then


                enrollment_assign.stud_status.Text = table.Rows(0).Item("status")
                enrollment_assign.cb_sect.Text = table.Rows(0).Item("section")



            End If

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub


    '   Function: edit_profile - This will pass the data to form labels
    '   Number of parameters: 1
    '   Parameter 1: query - Database query ex.(select* from table where name = name)

    Public Sub edit_profileusers(ByVal query As String)


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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

            If table.Rows.Count > 0 Then

                usereditform.ename.Text = table.Rows(0).Item("name")
                usereditform.ecbposition.Text = table.Rows(0).Item("position")
                usereditform.eaddress.Text = table.Rows(0).Item("address")
                usereditform.eusername.Text = table.Rows(0).Item("username")
                usereditform.epassword.Text = table.Rows(0).Item("password")

            End If

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub
   


    ' Same details with function: populate_datagridview
    Public Sub schedule_list(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0

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
                count = table.Rows.Count
                With datagridview


                    datagridview.Rows.Add(rows("subject"), rows("name"), rows("time"))


                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub


    ' Auto increment ID function
    Public Sub auto_id(ByVal query As String, ByVal label As Label)

        Connected()
        Dim cmd As New MySqlCommand
        cmd.Connection = connection
        Dim number As Integer
        cmd.CommandText = query

        If IsDBNull(cmd.ExecuteScalar) Then

            number = 1
            label.Text = number
        Else

            number = cmd.ExecuteScalar + 1
            label.Text = number

        End If
        cmd.Dispose()
        connection.Close()
        connection.Dispose()

    End Sub

    ' Same details with function: populate_datagridview
    Public Sub enrolled_list(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0
        Dim name As String


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
                count = table.Rows.Count
                With datagridview

                    name = rows("stud_lastname") & ", " & rows("stud_firstname")

                    datagridview.Rows.Add(name, rows("stud_gradelevel"), rows("stud_id"), rows("studlist_id"))


                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub

    ' Same details with function: populate_datagridview
    Public Sub list_subject(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0



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
                count = table.Rows.Count
                With datagridview



                    datagridview.Rows.Add(rows("subject_id"), rows("subject"), rows("grade_level"))


                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub

    ' Same details with function: populate_datagridview
    Public Sub list_section(ByVal query As String, ByVal datagridview As DataGridView, ByVal fields() As Object)

        datagridview.Rows.Clear()


        Dim col As Integer = fields.Length
        Dim count As Integer = 0



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
                count = table.Rows.Count
                With datagridview



                    datagridview.Rows.Add(rows("section_id"), rows("section"), rows("grade_level"))


                End With
            Next

            connection.Close()
        Catch ex As Exception

            connection.Close()
            Console.Write(ex)

        End Try

    End Sub


    Public Sub update_violation(ByVal query As String, ByVal fields() As Object, ByVal data() As Object, ByVal message As String)

        Dim sql_command = New MySqlClient.MySqlCommand(query, connection)

        For x = 0 To fields2.Length - 1

            sql_command.Parameters.AddWithValue(fields(x), data(x))

        Next

        Try
            Connected()

            If sql_command.ExecuteNonQuery() > 0 Then
                MessageBox.Show(message, "Lan-based Student Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Anecdotal.function_class()
                Anecdotal.violation.Text = ""
                Anecdotal.update_btn.Visible = False
                Anecdotal.submit.Visible = True

            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            Console.Write(ex)
            MsgBox(ex)
        End Try



    End Sub


    Public Sub boolean_retrieve(ByVal query As String)

        Try
            Connected()
            Dim sqlAdapter As New MySqlDataAdapter
            Dim sqlCommand As New MySqlCommand
            Dim table As New DataTable


            '' Dim i As Integer

            With sqlCommand

                .CommandText = query
                .Connection = connection

            End With

            With sqlAdapter

                .SelectCommand = sqlCommand
                .Fill(table)

            End With

            If table.Rows.Count > 0 Then

                MessageBox.Show("Can't add Schedule!", "Please assign another schedule.", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                add_sched.add_schedule()
            End If
            connection.Close()
        Catch ex As Exception
            Console.Write(ex)
            connection.Close()

        End Try


    End Sub


    Public Sub boolean_retrieveup(ByVal query As String)

        Try
            Connected()
            Dim sqlAdapter As New MySqlDataAdapter
            Dim sqlCommand As New MySqlCommand
            Dim table As New DataTable


            '' Dim i As Integer

            With sqlCommand

                .CommandText = query
                .Connection = connection

            End With

            With sqlAdapter

                .SelectCommand = sqlCommand
                .Fill(table)

            End With

            If table.Rows.Count > 0 Then
                MessageBox.Show("Can't add Schedule!", "Please assign another schedule.", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                edit_sched.edit()
            End If
            connection.Close()
        Catch ex As Exception
            Console.Write(ex)
            connection.Close()

        End Try


    End Sub





End Class
