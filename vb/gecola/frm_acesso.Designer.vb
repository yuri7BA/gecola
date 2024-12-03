<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_acesso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_acesso))
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_acessar = New System.Windows.Forms.Button()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(213, 82)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(90, 25)
        Me.btn_limpar.TabIndex = 4
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'btn_acessar
        '
        Me.btn_acessar.Location = New System.Drawing.Point(103, 82)
        Me.btn_acessar.Name = "btn_acessar"
        Me.btn_acessar.Size = New System.Drawing.Size(90, 25)
        Me.btn_acessar.TabIndex = 3
        Me.btn_acessar.Text = "ACESSAR"
        Me.btn_acessar.UseVisualStyleBackColor = True
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(103, 18)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(200, 22)
        Me.txt_usuario.TabIndex = 1
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(26, 21)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(71, 16)
        Me.lbl_usuario.TabIndex = 4
        Me.lbl_usuario.Text = "USUÁRIO:"
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Location = New System.Drawing.Point(40, 55)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(57, 16)
        Me.lbl_senha.TabIndex = 5
        Me.lbl_senha.Text = "SENHA:"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(103, 52)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(200, 22)
        Me.txt_senha.TabIndex = 2
        '
        'frm_acesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(333, 119)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.btn_acessar)
        Me.Controls.Add(Me.btn_limpar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_acesso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACESSO AO GECOLA"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_acessar As Button
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_senha As Label
    Friend WithEvents txt_senha As TextBox
End Class
