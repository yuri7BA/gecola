<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_senha))
        Me.txt_senha_atual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_usuario_data = New System.Windows.Forms.Label()
        Me.txt_nova_senha = New System.Windows.Forms.TextBox()
        Me.txt_nova_senha_repete = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.cb_senha_atual = New System.Windows.Forms.CheckBox()
        Me.cb_nova_senha = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txt_senha_atual
        '
        Me.txt_senha_atual.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_senha_atual.Location = New System.Drawing.Point(119, 12)
        Me.txt_senha_atual.MaxLength = 20
        Me.txt_senha_atual.Name = "txt_senha_atual"
        Me.txt_senha_atual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_atual.Size = New System.Drawing.Size(196, 22)
        Me.txt_senha_atual.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SENHA ATUAL:"
        '
        'lbl_usuario_data
        '
        Me.lbl_usuario_data.AutoSize = True
        Me.lbl_usuario_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario_data.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_usuario_data.Location = New System.Drawing.Point(12, 173)
        Me.lbl_usuario_data.Name = "lbl_usuario_data"
        Me.lbl_usuario_data.Size = New System.Drawing.Size(145, 18)
        Me.lbl_usuario_data.TabIndex = 10
        Me.lbl_usuario_data.Text = "USUÁRIO E DATA"
        '
        'txt_nova_senha
        '
        Me.txt_nova_senha.Location = New System.Drawing.Point(119, 61)
        Me.txt_nova_senha.MaxLength = 20
        Me.txt_nova_senha.Name = "txt_nova_senha"
        Me.txt_nova_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nova_senha.Size = New System.Drawing.Size(196, 22)
        Me.txt_nova_senha.TabIndex = 11
        '
        'txt_nova_senha_repete
        '
        Me.txt_nova_senha_repete.Location = New System.Drawing.Point(119, 101)
        Me.txt_nova_senha_repete.MaxLength = 20
        Me.txt_nova_senha_repete.Name = "txt_nova_senha_repete"
        Me.txt_nova_senha_repete.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nova_senha_repete.Size = New System.Drawing.Size(196, 22)
        Me.txt_nova_senha_repete.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "NOVA SENHA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 32)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "REPITA A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NOVA SENHA:"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(119, 129)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(120, 25)
        Me.btn_confirmar.TabIndex = 15
        Me.btn_confirmar.Text = "CONFIRMAR"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(270, 129)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(120, 25)
        Me.btn_limpar.TabIndex = 16
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'cb_senha_atual
        '
        Me.cb_senha_atual.AutoSize = True
        Me.cb_senha_atual.Location = New System.Drawing.Point(321, 14)
        Me.cb_senha_atual.Name = "cb_senha_atual"
        Me.cb_senha_atual.Size = New System.Drawing.Size(74, 20)
        Me.cb_senha_atual.TabIndex = 17
        Me.cb_senha_atual.Text = "Mostrar"
        Me.cb_senha_atual.UseVisualStyleBackColor = True
        '
        'cb_nova_senha
        '
        Me.cb_nova_senha.AutoSize = True
        Me.cb_nova_senha.Location = New System.Drawing.Point(321, 81)
        Me.cb_nova_senha.Name = "cb_nova_senha"
        Me.cb_nova_senha.Size = New System.Drawing.Size(74, 20)
        Me.cb_nova_senha.TabIndex = 18
        Me.cb_nova_senha.Text = "Mostrar"
        Me.cb_nova_senha.UseVisualStyleBackColor = True
        '
        'frm_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 200)
        Me.Controls.Add(Me.cb_nova_senha)
        Me.Controls.Add(Me.cb_senha_atual)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nova_senha_repete)
        Me.Controls.Add(Me.txt_nova_senha)
        Me.Controls.Add(Me.lbl_usuario_data)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_senha_atual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_senha"
        Me.Text = "TROCAR A SENHA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_senha_atual As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_usuario_data As Label
    Friend WithEvents txt_nova_senha As TextBox
    Friend WithEvents txt_nova_senha_repete As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents cb_senha_atual As CheckBox
    Friend WithEvents cb_nova_senha As CheckBox
End Class
