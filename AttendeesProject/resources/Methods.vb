Imports MySql.Data.MySqlClient

Public Class Methods
    'Adding info into the database
    Public Sub InsertInfo(sqlConnection As MySqlConnection, fname As String, lname As String, number As String, city As String)
        'Check if the Telephone number contains characters

        Dim txtNumberArray As Array = number.ToCharArray

        For i = 0 To txtNumberArray.Length - 1
            If Char.IsLetter(txtNumberArray(i)) Then
                MessageBox.Show("Please Enter a valid phone number", "Attendees Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Next i

        'Try catch method for opening the connection to the database and inserting new info
        Try
            sqlConnection.Open()
            Dim sqlQuery As String = "INSERT into schoolattendance.attendees(atFName, atLName, atTelephone, atCity) value('" & fname & "','" & lname & "','" & Convert.ToInt32(number) & "','" & city & "')"

            Dim sqlCommand As MySqlCommand = New MySqlCommand(sqlQuery, sqlConnection)
            Dim sqlReader As MySqlDataReader = sqlCommand.ExecuteReader
            sqlConnection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Attendees Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Releasing the resources in sqlConnection and calling the update method
        Finally
            sqlConnection.Dispose()
            MessageBox.Show("Information added", "Attendees Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    'Editing existing info of the database
    Public Sub EditInfo(sqlConnection As MySqlConnection, fname As String, lname As String, number As String, city As String, id As Integer)
        sqlConnection.Open()
        Dim sqlCommand As MySqlCommand = New MySqlCommand()
        sqlCommand.Connection = sqlConnection

        'Check if the Telephone number contains characters
        Dim txtNumberArray As Array = number.ToCharArray
        For i = 0 To txtNumberArray.Length - 1
            If Char.IsLetter(txtNumberArray(i)) Then
                MessageBox.Show("Please Enter a valid phone number", "Attendees Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Next i

        With sqlCommand

            .CommandText = "UPDATE schoolattendance.attendees set atFName=@Firstname, atLName=@Lastname, atTelephone=@PhoneNumber, atCity=@City WHERE atID=@id"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@id", id)
            .Parameters.AddWithValue("@Firstname", fname)
            .Parameters.AddWithValue("@Lastname", lname)
            .Parameters.AddWithValue("@PhoneNumber", Convert.ToInt32(number))
            .Parameters.AddWithValue("@City", city)
        End With
        sqlCommand.ExecuteNonQuery()
        sqlCommand.Parameters.Clear()
        sqlConnection.Close()
    End Sub

    'Search Function with search filters
    Public Function SearchInfo(sqlConnection As MySqlConnection, index As Integer, search As String, matchesLabel As Label)
        sqlConnection.Open()
        Dim sqlDT As New DataTable
        Dim sqlCommand As MySqlCommand = New MySqlCommand()
        Dim sqlReader As MySqlDataReader

        sqlCommand.Connection = sqlConnection

        Select Case Convert.ToInt32(index)
            'Searching using ID
            Case 0
                'Check if the ID number contains characters
                Dim txtNumberArray As Array = search.ToCharArray
                For i = 0 To txtNumberArray.Length - 1
                    If Char.IsLetter(txtNumberArray(i)) Then
                        MessageBox.Show("Please Enter a valid phone number", "Attendees Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Function
                    End If
                Next i
                sqlCommand.CommandText = "Select * FROM schoolattendance.attendees WHERE atID= " & Convert.ToInt32(search)
                sqlReader = sqlCommand.ExecuteReader()
                sqlDT.Load(sqlReader)
                sqlReader.Close()
                sqlConnection.Close()
                matchesLabel.Text = sqlDT.Rows.Count.ToString
                MessageBox.Show("The search results returned " & sqlDT.Rows.Count & " matches")
                Return sqlDT
            'Searching using First Name
            Case 1
                sqlCommand.CommandText = "Select * FROM schoolattendance.attendees WHERE atFName='" & search & "'"
                sqlReader = sqlCommand.ExecuteReader()
                sqlDT.Load(sqlReader)
                matchesLabel.Text = sqlDT.Rows.Count.ToString
                MessageBox.Show("The search results returned " & sqlDT.Rows.Count & " matches")
                sqlReader.Close()
                sqlConnection.Close()
                Return sqlDT
            'Searching using Last Name
            Case 2
                sqlCommand.CommandText = "Select * FROM schoolattendance.attendees HAVING atLName='" & search & "'"
                sqlReader = sqlCommand.ExecuteReader()
                sqlDT.Load(sqlReader)
                matchesLabel.Text = sqlDT.Rows.Count.ToString
                MessageBox.Show("The search results returned " & sqlDT.Rows.Count & " matches")
                sqlReader.Close()
                sqlConnection.Close()
                Return sqlDT
            'Searching using Mobile number
            Case 3
                'Check if the Telephone number contains characters
                Dim txtNumberArray As Array = search.ToCharArray
                For i = 0 To txtNumberArray.Length - 1
                    If Char.IsLetter(txtNumberArray(i)) Then
                        MessageBox.Show("Please Enter a valid phone number", "Attendees Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Function
                    End If
                Next i
                sqlCommand.CommandText = "Select * FROM schoolattendance.attendees HAVING atTelephone=" & Convert.ToInt32(search)
                sqlReader = sqlCommand.ExecuteReader()
                sqlDT.Load(sqlReader)
                matchesLabel.Text = sqlDT.Rows.Count.ToString
                MessageBox.Show("The search results returned " & sqlDT.Rows.Count & " matches")
                sqlReader.Close()
                sqlConnection.Close()
                Return sqlDT
            'Searching using City name
            Case 4
                sqlCommand.CommandText = "Select * FROM schoolattendance.attendees HAVING atCity='" & search & "'"
                sqlReader = sqlCommand.ExecuteReader()
                sqlDT.Load(sqlReader)
                matchesLabel.Text = sqlDT.Rows.Count.ToString
                MessageBox.Show("The search results returned " & sqlDT.Rows.Count & " matches")
                sqlReader.Close()
                sqlConnection.Close()
                Return sqlDT
        End Select
    End Function
End Class
