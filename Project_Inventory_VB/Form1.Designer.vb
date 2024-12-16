<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Label3 = New Label()
        Label2 = New Label()
        Guna2CircleProgressBar1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(197, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 30)
        Label1.TabIndex = 0
        Label1.Text = "InventoryKu"
        ' 
        ' Guna2CircleProgressBar1
        ' 
        Guna2CircleProgressBar1.Controls.Add(Label3)
        Guna2CircleProgressBar1.FillColor = Color.FromArgb(CByte(200), CByte(213), CByte(218), CByte(223))
        Guna2CircleProgressBar1.FillThickness = 10
        Guna2CircleProgressBar1.Font = New Font("Segoe UI", 12.0F)
        Guna2CircleProgressBar1.ForeColor = Color.White
        Guna2CircleProgressBar1.Location = New Point(207, 57)
        Guna2CircleProgressBar1.Minimum = 0
        Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleProgressBar1.Size = New Size(132, 132)
        Guna2CircleProgressBar1.TabIndex = 1
        Guna2CircleProgressBar1.Text = "Guna2CircleProgressBar1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label3.Location = New Point(56, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 28)
        Label3.TabIndex = 3
        Label3.Text = "%"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(223, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 21)
        Label2.TabIndex = 2
        Label2.Text = "Kelompok 1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(530, 239)
        Controls.Add(Label2)
        Controls.Add(Guna2CircleProgressBar1)
        Controls.Add(Label1)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Guna2CircleProgressBar1.ResumeLayout(False)
        Guna2CircleProgressBar1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
