Public Class SettingsForm

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboTheme.Items.Add("Light")
        cboTheme.Items.Add("Dark")

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        MessageBox.Show("Settings Saved")

    End Sub

End Class
