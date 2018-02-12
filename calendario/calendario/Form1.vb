Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFECHA.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnCAPTURA_Click(sender As Object, e As EventArgs) Handles btnCAPTURA.Click
        txtFECHA.Text = calendarioDate.Value
        txtRango.Text = MonthCalendar1.SelectionStart.ToString
        txtiNicio.Text = MonthCalendar1.SelectionStart.Date
        txtFIN.Text = MonthCalendar1.SelectionRange.End
    End Sub
End Class
