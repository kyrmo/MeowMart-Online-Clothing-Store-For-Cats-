<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.c1286c6da79cd4b091e7283bc2daeec0
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatAppearance.BorderSize = 0
        Button1.Location = New Point(12, 111)
        Button1.Name = "Button1"
        Button1.Size = New Size(346, 298)
        Button1.TabIndex = 0
        Button1.Text = " "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.FlatAppearance.BorderSize = 0
        Button2.Location = New Point(10, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(232, 200)
        Button2.TabIndex = 1
        Button2.Text = " "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.MenuBar
        TextBox1.Font = New Font("Segoe UI Black", 50.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        TextBox1.Location = New Point(50, 1)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(673, 104)
        TextBox1.TabIndex = 2
        TextBox1.Text = "VIRUS DETECTED !"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(364, 127)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 276)
        Panel1.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.DarkGray
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Segoe UI", 30F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(10, 209)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(384, 62)
        TextBox3.TabIndex = 3
        TextBox3.Text = "+1 (800)-466-3337"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.DarkGray
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Ravie", 14.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(247, 15)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(176, 210)
        TextBox2.TabIndex = 2
        TextBox2.Text = "Please contact cat support to remove your malware"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
