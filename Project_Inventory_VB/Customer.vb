Imports Microsoft.Data.SqlClient

Public Class Customer
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rizah\OneDrive\Documents\db_inventoryVB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True")

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from CustomerTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        CustomerDATA.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            Con.Open()
            Dim query As String
            query = "insert into CustomerTbl values(" & cust_id.Text & ", '" & cust_name.Text & "', " & cust_phone.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Customer Berhasil Ditambahkan")
            Con.Close()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If cust_id.Text = "" Then
            MsgBox("Data Tidak Lengkap")
        Else
            Con.Open()

            Dim sqlFetch = "SELECT CustName, CustPhone FROM CustomerTbl WHERE CustId = '" & cust_id.Text & "'"
            Dim cmdFetch As New SqlCommand(sqlFetch, Con)
            Dim reader As SqlDataReader = cmdFetch.ExecuteReader()

            Dim oldName As String = ""
            Dim oldPhone As String = ""

            If reader.Read() Then
                oldName = reader("CustName").ToString()
                oldPhone = reader("CustPhone").ToString()
            End If
            reader.Close()

            Dim newName As String = If(cust_name.Text = "", oldName, cust_name.Text)
            Dim newPhone As String = If(cust_phone.Text = "", oldPhone, cust_phone.Text)

            Dim sqlUpdate = "UPDATE CustomerTbl SET CustName = '" & newName & "', CustPhone = '" & newPhone & "' WHERE CustId = '" & cust_id.Text & "'"
            Dim cmdUpdate As New SqlCommand(sqlUpdate, Con)
            cmdUpdate.ExecuteNonQuery()

            MsgBox("Customer berhasil diupdate")

            Con.Close()

            populate()
        End If

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If cust_id.Text = "" Then
            MsgBox("Masukan id Product bila ingin di update")
        Else
            Con.Open()
            Dim query As String
            query = "delete from CustomerTbl where CustId= " & cust_id.Text & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Customer Berhasil Di Hapus")
            Con.Close()
            populate()
        End If

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        cust_id.Text = ""
        cust_name.Text = ""
        cust_phone.Text = ""
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub
End Class