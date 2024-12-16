Imports Microsoft.Data.SqlClient

Public Class Order
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rizah\OneDrive\Documents\db_inventoryVB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub FillProduct()
        Con.Open()
        Dim Sql = "select * from ProductTbl"
        Dim cmd As New SqlCommand(Sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        PnameCb.DataSource = Tbl
        PnameCb.DisplayMember = "ProdId"
        PnameCb.ValueMember = "ProdId"
        Con.Close()
    End Sub

    Private Sub FillCustomer()
        Con.Open()
        Dim Sql = "select * from CustomerTbl"
        Dim cmd As New SqlCommand(Sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        custid.DataSource = Tbl
        custid.DisplayMember = "CustId"
        custid.ValueMember = "CustId"
        Con.Close()
    End Sub

    Private Sub FetchName()
        Con.Open()
        Dim query = "select * from customerTbl where CustId=" & custid.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            CustNameTb.Text = reader(1).ToString()
        End While
        Con.Close()
    End Sub

    Dim prodname As String
    Dim prodprice As Integer
    Dim AvailprodQty As Integer

    Private Sub FetchData()
        Con.Open()
        Dim query = "select * from productTbl where ProdId=" & PnameCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            'CustNameTb.Text = reader(2).ToString()
            prodname = reader(1).ToString()
            prodprice = Convert.ToUInt32(reader(3).ToString())
            AvailprodQty = Convert.ToUInt32(reader(2).ToString())
            ProdNameTb.Text = prodname
        End While
        Con.Close()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillProduct()
        FillCustomer()
        populate()
    End Sub

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from OrderTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        OrderDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Dim newQty
    Private Sub Updateprod()
        newQty = AvailprodQty - Convert.ToInt32(QtyTb.Text)
        Con.Open()
        Dim sql = "update ProductTbl set ProdQty=" & newQty & " where ProdId = " & PnameCb.SelectedItem.ToString() & ""
        Dim cmd As New SqlCommand(sql, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
    End Sub

    Dim Grtot = 0, i = 0, Total = 0
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If QtyTb.Text = "" Then
            MsgBox("Masukan Jumlah Produk ! ")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1
            Total = prodprice * Convert.ToInt32(QtyTb.Text)
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = ProdNameTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = prodprice
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = QtyTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = Total
            Grtot = Grtot + Total
            Amtbl.Text = Grtot
        End If
    End Sub

    Private Sub custid_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles custid.SelectionChangeCommitted
        FetchName()
    End Sub

    Private Sub PnameCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PnameCb.SelectionChangeCommitted
        FetchData()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        If CustNameTb.Text = "" Or OrderId.Text = "" Then
            MsgBox("Masukan Nama Customer Dan Id Order Dengan Benar !")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "insert into OrderTbl values(" & OrderId.Text & ", '" & custid.SelectedValue.ToString & "', '" & CustNameTb.Text & "', " & Amtbl.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Order Berhasil Ditambahkan")
                Con.Close()
                populate()
            Catch ex As Exception
                MsgBox(ex.Message)
                Con.Close()
            End Try

        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("********INVENTORYKU********", New Font("Century Gothic", 24), Brushes.BlueViolet, 250, 40)
        e.Graphics.DrawString("********YOUR ORDER********", New Font("Century Gothic", 16), Brushes.BlueViolet, 250, 80)
        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 110, 110)
        InsertOrder()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub InsertOrder()
        If CustNameTb.Text = "" Or OrderId.Text = "" Then
            MsgBox("Masukan Nama Customer Dan Id Order Dengan Benar !")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "insert into OrderTbl values(" & OrderId.Text & ", '" & custid.SelectedValue.ToString() & "', '" & CustNameTb.Text & "', " & Amtbl.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Order Berhasil Ditambahkan")
                Con.Close()
                populate()
            Catch ex As Exception
                MsgBox(ex.Message)
                Con.Close()
            End Try

        End If

    End Sub
End Class