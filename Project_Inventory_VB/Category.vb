Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class Category
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rizah\OneDrive\Documents\db_inventoryVB.mdf;Integrated Security=True;Connect Timeout=30")

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from CategoryTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        CategoryDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            Con.Open()
            Dim query As String
            query = "insert into CategoryTbl values(" & cat_id.Text & ", '" & cat_name.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Category Berhasil Ditambahkan")
            Con.Close()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        '"" Or prodname.Text = "" Or prodqty.Text = "" Or prodprice.Text = "" Or proddesc.Text = ""
        If cat_id.Text = "" Then
            MsgBox("Data Tidak Lengkap")
        Else
            Con.Open()
            Dim sql = "update CategoryTbl set CatName=" & cat_name.Text & " where CatId=" & cat_id.Text & " "
            Dim cmd As New SqlCommand(sql, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Category berhasil di update")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If cat_id.Text = "" Then
            MsgBox("Masukan id Product bila ingin di update")
        Else
            Con.Open()
            Dim query As String
            query = "delete from CategoryTbl where cat_id= " & cat_id.Text & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Kategori Berhasil Di Hapus")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        cat_id.Text = ""
        cat_name.Text = ""
    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click
        Application.Exit()
    End Sub
End Class