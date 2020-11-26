<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Log_loja
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
        Me.Log_stq = New System.Windows.Forms.Button()
        Me.Log_logistica = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Log_stq
        '
        Me.Log_stq.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Log_stq.ForeColor = System.Drawing.Color.DarkRed
        Me.Log_stq.Location = New System.Drawing.Point(231, 118)
        Me.Log_stq.Name = "Log_stq"
        Me.Log_stq.Size = New System.Drawing.Size(326, 69)
        Me.Log_stq.TabIndex = 0
        Me.Log_stq.Text = "Estoque"
        Me.Log_stq.UseVisualStyleBackColor = False
        '
        'Log_logistica
        '
        Me.Log_logistica.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Log_logistica.ForeColor = System.Drawing.Color.DarkRed
        Me.Log_logistica.Location = New System.Drawing.Point(231, 229)
        Me.Log_logistica.Name = "Log_logistica"
        Me.Log_logistica.Size = New System.Drawing.Size(326, 69)
        Me.Log_logistica.TabIndex = 2
        Me.Log_logistica.Text = "Pessoal"
        Me.Log_logistica.UseVisualStyleBackColor = False
        '
        'Log_loja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Log_logistica)
        Me.Controls.Add(Me.Log_stq)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Log_loja"
        Me.Text = "Loja"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Log_stq As Button
    Friend WithEvents Log_logistica As Button
End Class
