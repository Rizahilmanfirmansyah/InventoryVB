Imports Microsoft.Data.SqlClient

Public Class Users
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rizah\OneDrive\Documents\db_inventoryVB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True")

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from UsersTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        UsersDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            Con.Open()
            Dim query As String
            query = "insert into UsersTbl values(" & user_id.Text & ", '" & user_username.Text & "', " & user_password.Text & ", " & user_phone.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("User Berhasil Ditambahkan")
            Con.Close()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If user_id.Text = "" Then
            MsgBox("Data Tidak Lengkap")
        Else

            Con.Open()

            Dim sqlFetch = "SELECT Username, UPassword, UPhone FROM UsersTbl WHERE UId = '" & user_id.Text & "'"
            Dim cmdFetch As New SqlCommand(sqlFetch, Con)
            Dim reader As SqlDataReader = cmdFetch.ExecuteReader()

            Dim oldUsername As String = ""
            Dim oldUPhone As String = ""
            Dim oldUPassword As String = ""

            If reader.Read() Then
                oldUsername = reader("Username").ToString()
                oldUPhone = reader("UPhone").ToString()
                oldUPassword = reader("UPassword").ToString()
            End If
            reader.Close()

            Dim newUsername As String = If(user_username.Text = "", oldUsername, user_username.Text)
            Dim newUPhone As String = If(user_phone.Text = "", oldUPhone, user_phone.Text)
            Dim newUPassword As String = If(user_password.Text = "", oldUPassword, user_password.Text)

            ' Update data
            Dim sqlUpdate = "UPDATE UsersTbl SET Username = '" & newUsername & "', UPhone = '" & newUPhone & "', UPassword='" & newUPassword & "' WHERE UId = '" & user_id.Text & "'"
            Dim cmdUpdate As New SqlCommand(sqlUpdate, Con)
            cmdUpdate.ExecuteNonQuery()

            MsgBox("User berhasil diupdate")

            Con.Close()

            populate()
        End If

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If user_id.Text = "" Then
            MsgBox("Masukan id User bila ingin di update")
        Else
            Con.Open()
            Dim query As String
            query = "delete from UsersTbl where UId= " & user_id.Text & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Data User Berhasil Di Hapus")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        user_id.Text = ""
        user_password.Text = ""
        user_phone.Text = ""
        user_username.Text = ""
    End Sub
End Class