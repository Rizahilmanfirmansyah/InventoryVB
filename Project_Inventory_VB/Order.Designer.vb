<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order))
        Label1 = New Label()
        Label2 = New Label()
        BillDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        custid = New ComboBox()
        CustNameTb = New TextBox()
        OrderId = New TextBox()
        QtyTb = New TextBox()
        Label8 = New Label()
        Amtbl = New Label()
        Label10 = New Label()
        OrderDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Label11 = New Label()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        ProdNameTb = New TextBox()
        Label12 = New Label()
        PnameCb = New ComboBox()
        Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        CType(BillDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(OrderDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label1.ForeColor = Color.LightSeaGreen
        Label1.Location = New Point(284, 18)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(373, 28)
        Label1.TabIndex = 0
        Label1.Text = "Inventory Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.LightSeaGreen
        Label2.Location = New Point(403, 50)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 23)
        Label2.TabIndex = 1
        Label2.Text = "Manage Orders"
        ' 
        ' BillDGV
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        BillDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        BillDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        BillDGV.ColumnHeadersHeight = 18
        BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        BillDGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column4, Column3, Column5})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = Color.LightSeaGreen
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        BillDGV.DefaultCellStyle = DataGridViewCellStyle3
        BillDGV.GridColor = Color.LightSeaGreen
        BillDGV.Location = New Point(403, 143)
        BillDGV.Margin = New Padding(4)
        BillDGV.Name = "BillDGV"
        BillDGV.RowHeadersVisible = False
        BillDGV.Size = New Size(475, 244)
        BillDGV.TabIndex = 2
        BillDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        BillDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        BillDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        BillDGV.ThemeStyle.BackColor = Color.White
        BillDGV.ThemeStyle.GridColor = Color.LightSeaGreen
        BillDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        BillDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        BillDGV.ThemeStyle.HeaderStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        BillDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White
        BillDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        BillDGV.ThemeStyle.HeaderStyle.Height = 18
        BillDGV.ThemeStyle.ReadOnly = False
        BillDGV.ThemeStyle.RowsStyle.BackColor = Color.White
        BillDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        BillDGV.ThemeStyle.RowsStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        BillDGV.ThemeStyle.RowsStyle.ForeColor = Color.LightSeaGreen
        BillDGV.ThemeStyle.RowsStyle.Height = 25
        BillDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        BillDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Id"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Product"
        Column2.Name = "Column2"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Price"
        Column4.Name = "Column4"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Quantity"
        Column3.Name = "Column3"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Total"
        Column5.Name = "Column5"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.LightSeaGreen
        Label3.Location = New Point(42, 147)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 19)
        Label3.TabIndex = 3
        Label3.Text = "Order Id"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.LightSeaGreen
        Label4.Location = New Point(42, 189)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 19)
        Label4.TabIndex = 4
        Label4.Text = "Customer Id"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.LightSeaGreen
        Label5.Location = New Point(42, 235)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 19)
        Label5.TabIndex = 5
        Label5.Text = "Customer Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label6.ForeColor = Color.LightSeaGreen
        Label6.Location = New Point(42, 318)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 19)
        Label6.TabIndex = 6
        Label6.Text = "Product Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label7.ForeColor = Color.LightSeaGreen
        Label7.Location = New Point(42, 368)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 19)
        Label7.TabIndex = 7
        Label7.Text = "Quantity"
        ' 
        ' custid
        ' 
        custid.FormattingEnabled = True
        custid.Location = New Point(199, 189)
        custid.Name = "custid"
        custid.Size = New Size(175, 24)
        custid.TabIndex = 9
        ' 
        ' CustNameTb
        ' 
        CustNameTb.Location = New Point(198, 235)
        CustNameTb.Name = "CustNameTb"
        CustNameTb.Size = New Size(176, 23)
        CustNameTb.TabIndex = 10
        ' 
        ' OrderId
        ' 
        OrderId.Location = New Point(199, 143)
        OrderId.Name = "OrderId"
        OrderId.Size = New Size(175, 23)
        OrderId.TabIndex = 11
        ' 
        ' QtyTb
        ' 
        QtyTb.Location = New Point(198, 365)
        QtyTb.Name = "QtyTb"
        QtyTb.Size = New Size(176, 23)
        QtyTb.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label8.Location = New Point(626, 104)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 19)
        Label8.TabIndex = 14
        Label8.Text = "Tagihan"
        ' 
        ' Amtbl
        ' 
        Amtbl.AutoSize = True
        Amtbl.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Amtbl.Location = New Point(626, 391)
        Amtbl.Name = "Amtbl"
        Amtbl.Size = New Size(68, 19)
        Amtbl.TabIndex = 15
        Amtbl.Text = "Jumlah"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.LightSeaGreen
        Label10.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(403, 447)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 23)
        Label10.TabIndex = 16
        Label10.Text = "Product List"
        ' 
        ' OrderDGV
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        OrderDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        OrderDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        OrderDGV.ColumnHeadersHeight = 18
        OrderDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = Color.LightSeaGreen
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        OrderDGV.DefaultCellStyle = DataGridViewCellStyle6
        OrderDGV.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        OrderDGV.Location = New Point(42, 496)
        OrderDGV.Name = "OrderDGV"
        OrderDGV.RowHeadersVisible = False
        OrderDGV.Size = New Size(836, 169)
        OrderDGV.TabIndex = 19
        OrderDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        OrderDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        OrderDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        OrderDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        OrderDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        OrderDGV.ThemeStyle.BackColor = Color.White
        OrderDGV.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        OrderDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        OrderDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        OrderDGV.ThemeStyle.HeaderStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        OrderDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White
        OrderDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        OrderDGV.ThemeStyle.HeaderStyle.Height = 18
        OrderDGV.ThemeStyle.ReadOnly = False
        OrderDGV.ThemeStyle.RowsStyle.BackColor = Color.White
        OrderDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        OrderDGV.ThemeStyle.RowsStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        OrderDGV.ThemeStyle.RowsStyle.ForeColor = Color.LightSeaGreen
        OrderDGV.ThemeStyle.RowsStyle.Height = 25
        OrderDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        OrderDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.LightSeaGreen
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(420, 678)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(77, 25)
        Guna2Button1.TabIndex = 20
        Guna2Button1.Text = "Home"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(872, 9)
        Label11.Name = "Label11"
        Label11.Size = New Size(28, 28)
        Label11.TabIndex = 21
        Label11.Text = "X"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges3
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.LightSeaGreen
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(231, 420)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button2.Size = New Size(88, 25)
        Guna2Button2.TabIndex = 22
        Guna2Button2.Text = "Add To Bill"
        ' 
        ' ProdNameTb
        ' 
        ProdNameTb.Enabled = False
        ProdNameTb.Location = New Point(199, 318)
        ProdNameTb.Name = "ProdNameTb"
        ProdNameTb.Size = New Size(175, 23)
        ProdNameTb.TabIndex = 23
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label12.Location = New Point(42, 282)
        Label12.Name = "Label12"
        Label12.Size = New Size(87, 19)
        Label12.TabIndex = 24
        Label12.Text = "Product Id"
        ' 
        ' PnameCb
        ' 
        PnameCb.FormattingEnabled = True
        PnameCb.Location = New Point(199, 282)
        PnameCb.Name = "PnameCb"
        PnameCb.Size = New Size(175, 24)
        PnameCb.TabIndex = 25
        ' 
        ' Guna2Button4
        ' 
        Guna2Button4.CustomizableEdges = CustomizableEdges5
        Guna2Button4.DisabledState.BorderColor = Color.DarkGray
        Guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button4.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button4.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button4.FillColor = Color.LightSeaGreen
        Guna2Button4.Font = New Font("Segoe UI", 9F)
        Guna2Button4.ForeColor = Color.White
        Guna2Button4.Location = New Point(747, 419)
        Guna2Button4.Name = "Guna2Button4"
        Guna2Button4.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button4.Size = New Size(81, 26)
        Guna2Button4.TabIndex = 27
        Guna2Button4.Text = "Print"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Order
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 727)
        Controls.Add(Guna2Button4)
        Controls.Add(PnameCb)
        Controls.Add(Label12)
        Controls.Add(ProdNameTb)
        Controls.Add(Guna2Button2)
        Controls.Add(Label11)
        Controls.Add(Guna2Button1)
        Controls.Add(OrderDGV)
        Controls.Add(Label10)
        Controls.Add(Amtbl)
        Controls.Add(Label8)
        Controls.Add(QtyTb)
        Controls.Add(OrderId)
        Controls.Add(CustNameTb)
        Controls.Add(custid)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(BillDGV)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        ForeColor = Color.LightSeaGreen
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Order"
        Text = "Order"
        CType(BillDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(OrderDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BillDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents custid As ComboBox
    Friend WithEvents CustNameTb As TextBox
    Friend WithEvents OrderId As TextBox
    Friend WithEvents QtyTb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Amtbl As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents OrderDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProdNameCb As ComboBox
    Friend WithEvents ProdNameTb As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PnameCb As ComboBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
