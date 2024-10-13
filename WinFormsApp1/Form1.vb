Public Class Form1

    Private WithEvents timer As New Timer

    Public Sub New()
        InitializeComponent()
        timer.Interval = 1200
        timer.Start()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Dim form3 As New Form3
        form3.ShowDialog()

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShoes.Click
        aboutusPanel.Visible = False
        clothesPanel.Visible = False
        accessoriesPanel.Visible = False
        shoesPanel.Visible = True
        toysPanel.Visible = False
    End Sub

    Private Sub pnlRight_Paint(sender As Object, e As PaintEventArgs) Handles pnlRight.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        aboutusPanel.Visible = True
        clothesPanel.Visible = False
        accessoriesPanel.Visible = False
        shoesPanel.Visible = False
        toysPanel.Visible = False
    End Sub

    Private Sub btnClothes_Click(sender As Object, e As EventArgs) Handles btnClothes.Click
        clothesPanel.Visible = True
        aboutusPanel.Visible = False
        accessoriesPanel.Visible = False
        shoesPanel.Visible = False
        toysPanel.Visible = False
    End Sub

    Private Sub btnToys_Click(sender As Object, e As EventArgs) Handles btnToys.Click
        aboutusPanel.Visible = False
        clothesPanel.Visible = False
        accessoriesPanel.Visible = False
        shoesPanel.Visible = False
        toysPanel.Visible = True
    End Sub

    Private Sub btnAccessories_Click(sender As Object, e As EventArgs) Handles btnAccessories.Click
        aboutusPanel.Visible = False
        clothesPanel.Visible = False
        accessoriesPanel.Visible = True
        shoesPanel.Visible = False
        toysPanel.Visible = False
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Me.Hide()
        Form2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = WindowState.Minimized

    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub
End Class
