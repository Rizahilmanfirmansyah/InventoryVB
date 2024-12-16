Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Product
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rizah\OneDrive\Documents\db_inventoryVB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles prodprice.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProdDGV.CellContentClick

    End Sub

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from ProductTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ProdDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            Con.Open()
            Dim query As String
            query = "insert into ProductTbl values(" & prodid.Text & ", '" & prodname.Text & "', " & prodqty.Text & ", " & prodprice.Text & ", '" & proddesc.Text & "', '" & prodcat.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Product Berhasil Ditambahkan")
            Con.Close()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
        End Try
    End Sub

    Private Sub FillCategory()
        Con.Open()
        Dim Sql = "select * from CategoryTbl"
        Dim cmd As New SqlCommand(Sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        prodcat.DataSource = Tbl
        prodcat.DisplayMember = "CatName"
        prodcat.ValueMember = "CatName"
        Con.Close()
    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        FillCategory()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If prodid.Text = "" Then
            MsgBox("Masukan Product bila ingin di update")
        Else
            Con.Open()
            Dim query As String
            query = "delete from ProductTbl where ProdId= " & prodid.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Product Berhasil Di Hapus")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        prodid.Text = ""
        prodname.Text = ""
        prodqty.Text = ""
        prodprice.Text = ""
        proddesc.Text = ""
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        '"" Or prodname.Text = "" Or prodqty.Text = "" Or prodprice.Text = "" Or proddesc.Text = ""
        If prodid.Text = "" Then
            MsgBox("Data Tidak Lengkap")
        Else
            Con.Open()

            Dim sqlFetch = "SELECT ProdName, ProdQty, ProdPrice, ProdDesc FROM ProductTbl WHERE ProdId = '" & prodid.Text & "'"
            Dim cmdFetch As New SqlCommand(sqlFetch, Con)
            Dim reader As SqlDataReader = cmdFetch.ExecuteReader()

            Dim oldProdName As String = ""
            Dim oldProdQty As String = ""
            Dim oldProdPrice As String = ""
            Dim oldProdDesc As String = ""

            If reader.Read() Then
                oldProdName = reader("ProdName").ToString()
                oldProdQty = reader("ProdQty").ToString()
                oldProdPrice = reader("ProdPrice").ToString()
                oldProdDesc = reader("ProdDesc").ToString()
            End If
            reader.Close()

            Dim newProdName As String = If(prodname.Text = "", oldProdName, prodname.Text)
            Dim newProdQty As String = If(prodqty.Text = "", oldProdQty, prodqty.Text)
            Dim newProdPrice As String = If(prodprice.Text = "", oldProdPrice, prodprice.Text)
            Dim newProdDesc As String = If(proddesc.Text = "", oldProdDesc, proddesc.Text)


            Dim sqlUpdate = "UPDATE ProductTbl SET ProdName = '" & newProdName & "', ProdQty = '" & newProdQty & "', ProdPrice='" & newProdPrice & "', ProdDesc='" & newProdDesc & "' WHERE ProdId = '" & prodid.Text & "'"
            Dim cmdUpdate As New SqlCommand(sqlUpdate, Con)
            cmdUpdate.ExecuteNonQuery()

            MsgBox("Customer berhasil diupdate")

            Con.Close()

            populate()
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()
    End Sub
End Class