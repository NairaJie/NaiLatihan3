Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TotalBayarHasil_Click(sender As Object, e As EventArgs) Handles TotalBayarHasil.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonProsses.Click
        JumlahHargaHasil.Text = Val(TbHargaJual.Text) * Val(TbJumlahBeli.Text)
        If Val(TbJumlahBeli.Text) > 10 Then
            DiskonHasil.Text = (10 / 100) * Val(JumlahHargaHasil.Text)
        Else
            DiskonHasil.Text = 0
        End If
        TotalBayarHasil.Text = Val(JumlahHargaHasil.Text) - Val(DiskonHasil.Text)
    End Sub

    Private Sub JumlahHargaHasil_Click(sender As Object, e As EventArgs) Handles JumlahHargaHasil.Click

    End Sub

    Private Sub DiskonHasil_Click(sender As Object, e As EventArgs) Handles DiskonHasil.Click

    End Sub
End Class