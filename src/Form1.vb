Public Class Log_logon
    Private Sub Log_logon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log_inputMail.Focus()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        validar()
    End Sub


    'limpa os campos
    Sub limpar()
        Log_inputMail.Text = ""
        Log_inputSenha.Text = ""
    End Sub
    'verifica e valida os campos
    Sub validar()
        Dim mail As String
        Dim senha As String

        mail = Log_inputMail.Text
        senha = Log_inputSenha.Text


        If mail = "leo@yahoo.com" And senha = "1234" Then
            Dim tela = New Log_loja
            tela.ShowDialog()
            limpar()
            Log_inputMail.Focus()
        Else
            MsgBox("insira um email e senha válidos!")
            limpar()
            Log_inputMail.Focus()
        End If
    End Sub


End Class
