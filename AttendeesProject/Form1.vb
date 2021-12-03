Imports MySql.Data.MySqlClient
Public Class Form1


    'Creating variables
    Dim sqlConnection As New MySqlConnection
    Dim sqlDT As New DataTable
    Dim sqlCommand As MySqlCommand = New MySqlCommand()
    Dim sqlReader As MySqlDataReader

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "administrator1"
    Dim database As String = "schoolattendance"

    Dim id As Integer
    Dim selected As Boolean


    Dim mth As Methods = New Methods()


    'Update event which gets called to update the information in the GridView
    Private Sub UpdateTable()
        sqlConnection.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database

        sqlConnection.Open()
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = "SELECT * FROM schoolattendance.attendees"
        sqlReader = sqlCommand.ExecuteReader()
        sqlDT.Load(sqlReader)
        sqlReader.Close()
        sqlConnection.Close()

        DataGridView1.DataSource = sqlDT
    End Sub

    'Load the database when app starts
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        UpdateTable()
    End Sub

    'Exit application button
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim exitDiag As DialogResult

        exitDiag = MessageBox.Show("Do you want to exit the program?", "Attendees viewer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If exitDiag = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'Push new information on the database
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        mth.InsertInfo(sqlConnection,
                       fNameBox.Text,
                       lNameBox.Text,
                       mNumberBox.Text,
                       cityBox.Text)
        UpdateTable()
        MessageBox.Show("Information Added!", "Attendees Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fNameBox.Text = ""
        lNameBox.Text = ""
        mNumberBox.Text = ""
        cityBox.Text = ""

    End Sub

    'Edit existing info in the database by recieving the ID from DataGridView1 and DataGridView2.
    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        If selected = False Then
            MessageBox.Show("Please select a Attendee from the Lists below", "Attendees Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mth.EditInfo(sqlConnection,
                     fNameBox.Text,
                     lNameBox.Text,
                     mNumberBox.Text,
                     cityBox.Text,
                     id)
        UpdateTable()
        MessageBox.Show("Information updated!", "Attendees Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fNameBox.Text = ""
        lNameBox.Text = ""
        mNumberBox.Text = ""
        cityBox.Text = ""
        selected = False
    End Sub

    'Pass data parameters for the Edit button by clicking on the left most cell in the full list
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            id = DataGridView1.SelectedRows(0).Cells(0).Value
            fNameBox.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            lNameBox.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            mNumberBox.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            cityBox.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            selected = True
        Catch ex As Exception
            MessageBox.Show("Please select the left most cell", "Attendees Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Searching for information in the database
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        DataGridView2.DataSource = mth.SearchInfo(sqlConnection,
                                                    ComboBox1.SelectedIndex,
                                                    searchBox.Text,
                                                    matchesLabel)
    End Sub

    'Pass data parameters for the Edit button by clicking on the left most cell in the search list
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            id = DataGridView2.SelectedRows(0).Cells(0).Value
            fNameBox.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            lNameBox.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            mNumberBox.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            cityBox.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            selected = True
        Catch ex As Exception
            MessageBox.Show("Please select the left most cell", "Attendees Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
