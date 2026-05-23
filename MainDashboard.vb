Public Class MainDashboard

    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.IsMdiContainer = True

        lblProducts.Text = "150"
        lblSales.Text = "₱25,000"
        lblOrders.Text = "320"

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        MessageBox.Show("Dashboard Home")

    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click

        Dim frm As New ProductsForm()

        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        Dim frm As New ReceiptViewerForm()

        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        Dim frm As New SettingsForm()

        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Application.Exit()

    End Sub

End Class
