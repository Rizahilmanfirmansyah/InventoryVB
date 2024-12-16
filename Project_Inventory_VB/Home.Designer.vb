<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Panel2 = New Panel()
        Label8 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSeaGreen
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = SystemColors.ControlDark
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(891, 100)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(371, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 28)
        Label1.TabIndex = 0
        Label1.Text = "Main Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label2.ForeColor = Color.LightSeaGreen
        Label2.Location = New Point(261, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(373, 28)
        Label2.TabIndex = 1
        Label2.Text = "Selamat Datang Di InventoryKu"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label3.ForeColor = Color.LightSeaGreen
        Label3.Location = New Point(113, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 28)
        Label3.TabIndex = 2
        Label3.Text = "Product"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label4.ForeColor = Color.LightSeaGreen
        Label4.Location = New Point(676, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 28)
        Label4.TabIndex = 3
        Label4.Text = "Customers"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label5.ForeColor = Color.LightSeaGreen
        Label5.Location = New Point(124, 359)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 28)
        Label5.TabIndex = 4
        Label5.Text = "Users"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label6.ForeColor = Color.LightSeaGreen
        Label6.Location = New Point(693, 359)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 28)
        Label6.TabIndex = 5
        Label6.Text = "Orders"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(113, 223)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 72)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label7.ForeColor = Color.LightSeaGreen
        Label7.Location = New Point(398, 245)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 28)
        Label7.TabIndex = 7
        Label7.Text = "Categories"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(418, 286)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 68)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(693, 223)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(100, 72)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(113, 400)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(100, 80)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(693, 400)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(100, 80)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightSeaGreen
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 522)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(891, 18)
        Panel2.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(851, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(28, 28)
        Label8.TabIndex = 1
        Label8.Text = "X"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(891, 540)
        Controls.Add(Panel2)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Home"
        Text = "Home"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel2 As Panel
End Class
