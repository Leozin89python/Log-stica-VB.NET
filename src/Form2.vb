Public Class Log_loja

    Private Sub Log_stq_Click(sender As Object, e As EventArgs) Handles Log_stq.Click
        Dim tela = New Log_estoque
        tela.ShowDialog()
    End Sub

    Private Sub Log_logistica_Click(sender As Object, e As EventArgs) Handles Log_logistica.Click
        Dim tela = New Log_pessoal
        tela.ShowDialog()
    End Sub

    Private Sub Log_loja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class