Public Class Form4
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                BiayaKeberangkatanHasil.Text = 5000000
                BiayaAdminitrasiHasil.Text = 1000000
            Case 1
                BiayaKeberangkatanHasil.Text = 6000000
                BiayaAdminitrasiHasil.Text = 1000000
            Case 2
                BiayaKeberangkatanHasil.Text = 7000000
                BiayaAdminitrasiHasil.Text = 1000000
            Case 3
                BiayaKeberangkatanHasil.Text = 8000000
                BiayaAdminitrasiHasil.Text = 1000000
        End Select
    End Sub

    Private Sub ButtonProsses_Click(sender As Object, e As EventArgs) Handles ButtonProsses.Click
        TotalBiayaHasil.Text = Val(BiayaAdminitrasiHasil.Text) + Val(TbVisa.Text) + Val(BiayaKeberangkatanHasil.Text)
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class