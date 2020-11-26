<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Log_logon
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Log_inputMail = New System.Windows.Forms.TextBox()
        Me.Log_inputSenha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Log_inputMail
        '
        Me.Log_inputMail.Location = New System.Drawing.Point(302, 82)
        Me.Log_inputMail.Name = "Log_inputMail"
        Me.Log_inputMail.Size = New System.Drawing.Size(219, 20)
        Me.Log_inputMail.TabIndex = 0
        '
        'Log_inputSenha
        '
        Me.Log_inputSenha.Location = New System.Drawing.Point(302, 121)
        Me.Log_inputSenha.Name = "Log_inputSenha"
        Me.Log_inputSenha.Size = New System.Drawing.Size(219, 20)
        Me.Log_inputSenha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(299, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(299, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Senha"
        '
        'Button
        '
        Me.Button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button.ForeColor = System.Drawing.Color.DarkRed
        Me.Button.Location = New System.Drawing.Point(302, 162)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(219, 44)
        Me.Button.TabIndex = 4
        Me.Button.Text = "Login"
        Me.Button.UseVisualStyleBackColor = False
        '
        'Log_logon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 262)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Log_inputSenha)
        Me.Controls.Add(Me.Log_inputMail)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Log_logon"
        Me.Text = "Logística"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Log_inputMail As TextBox
    Friend WithEvents Log_inputSenha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button As Button
End Class
