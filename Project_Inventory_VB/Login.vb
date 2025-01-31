Imports Microsoft.Data.SqlClient

Public Class Login
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rizah\OneDrive\Documents\db_inventoryVB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If UidTb.Text = "" Then
            MsgBox("Masukan Username")
        ElseIf PassTb.Text = "" Then
            MsgBox("Masukan Password")
        Else
            Con.Open()
            Dim query = "select * from UsersTbl where Username='" & UidTb.Text & "' and Upassword='" & PassTb.Text & "' "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Username Dan Password Salah")
            Else
                Me.Hide()
                Dim home = New Home
                home.Show()
            End If
            Con.Close()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        UidTb.Text = ""
        PassTb.Text = ""
    End Sub
End Class
