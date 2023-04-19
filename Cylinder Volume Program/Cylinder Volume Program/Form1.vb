Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblRadius As Double
        Dim dblHeight As Double
        Dim dblVolume As Double

        Try
            dblRadius = CDbl(txtRadius.Text)
            dblHeight = CDbl(txtHeight.Text)
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter numerical values for the radius and height", "Input Error")
        End Try

        dblVolume = System.Math.PI * dblRadius ^ 2 * dblHeight
        txtVolume.Text = dblVolume
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRadius.Text = Nothing
        txtHeight.Text = Nothing
        txtVolume.Text = Nothing
    End Sub
End Class
