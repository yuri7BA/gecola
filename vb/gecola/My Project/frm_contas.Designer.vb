<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_contas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_contas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.lbl_ativado = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.cmb_perfil = New System.Windows.Forms.ComboBox()
        Me.cmb_ativado = New System.Windows.Forms.ComboBox()
        Me.gb_dados_conta = New System.Windows.Forms.Panel()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.lbl_aviso_inserir = New System.Windows.Forms.Label()
        Me.txt_senha_repete = New System.Windows.Forms.TextBox()
        Me.lbl_senha_repete = New System.Windows.Forms.Label()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.lbl_usuario_e_data = New System.Windows.Forms.Label()
        Me.dgv_dados_conta = New System.Windows.Forms.DataGridView()
        Me.col_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ativado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lbl_aviso_editar_excluir = New System.Windows.Forms.Label()
        Me.gb_dados_conta.SuspendLayout()
        CType(Me.dgv_dados_conta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(6, 48)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(71, 16)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "USUÁRIO:"
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Location = New System.Drawing.Point(6, 96)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(57, 16)
        Me.lbl_senha.TabIndex = 1
        Me.lbl_senha.Text = "SENHA:"
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.Location = New System.Drawing.Point(301, 48)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(56, 16)
        Me.lbl_perfil.TabIndex = 2
        Me.lbl_perfil.Text = "PERFIL:"
        '
        'lbl_ativado
        '
        Me.lbl_ativado.AutoSize = True
        Me.lbl_ativado.Location = New System.Drawing.Point(490, 48)
        Me.lbl_ativado.Name = "lbl_ativado"
        Me.lbl_ativado.Size = New System.Drawing.Size(69, 16)
        Me.lbl_ativado.TabIndex = 3
        Me.lbl_ativado.Text = "ATIVADO:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(83, 45)
        Me.txt_usuario.MaxLength = 20
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(200, 22)
        Me.txt_usuario.TabIndex = 1
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(9, 120)
        Me.txt_senha.MaxLength = 20
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(200, 22)
        Me.txt_senha.TabIndex = 4
        '
        'cmb_perfil
        '
        Me.cmb_perfil.FormattingEnabled = True
        Me.cmb_perfil.Items.AddRange(New Object() {"administrador", "usuário"})
        Me.cmb_perfil.Location = New System.Drawing.Point(363, 43)
        Me.cmb_perfil.MaxDropDownItems = 3
        Me.cmb_perfil.MaxLength = 13
        Me.cmb_perfil.Name = "cmb_perfil"
        Me.cmb_perfil.Size = New System.Drawing.Size(112, 24)
        Me.cmb_perfil.TabIndex = 2
        '
        'cmb_ativado
        '
        Me.cmb_ativado.FormattingEnabled = True
        Me.cmb_ativado.Items.AddRange(New Object() {"sim", "não"})
        Me.cmb_ativado.Location = New System.Drawing.Point(565, 43)
        Me.cmb_ativado.MaxDropDownItems = 3
        Me.cmb_ativado.MaxLength = 3
        Me.cmb_ativado.Name = "cmb_ativado"
        Me.cmb_ativado.Size = New System.Drawing.Size(57, 24)
        Me.cmb_ativado.TabIndex = 3
        '
        'gb_dados_conta
        '
        Me.gb_dados_conta.Controls.Add(Me.btn_limpar)
        Me.gb_dados_conta.Controls.Add(Me.lbl_aviso_inserir)
        Me.gb_dados_conta.Controls.Add(Me.txt_senha_repete)
        Me.gb_dados_conta.Controls.Add(Me.lbl_senha_repete)
        Me.gb_dados_conta.Controls.Add(Me.btn_salvar)
        Me.gb_dados_conta.Controls.Add(Me.cmb_ativado)
        Me.gb_dados_conta.Controls.Add(Me.cmb_perfil)
        Me.gb_dados_conta.Controls.Add(Me.lbl_perfil)
        Me.gb_dados_conta.Controls.Add(Me.lbl_ativado)
        Me.gb_dados_conta.Controls.Add(Me.txt_senha)
        Me.gb_dados_conta.Controls.Add(Me.txt_usuario)
        Me.gb_dados_conta.Controls.Add(Me.lbl_usuario)
        Me.gb_dados_conta.Controls.Add(Me.lbl_senha)
        Me.gb_dados_conta.Location = New System.Drawing.Point(26, 46)
        Me.gb_dados_conta.Name = "gb_dados_conta"
        Me.gb_dados_conta.Size = New System.Drawing.Size(743, 190)
        Me.gb_dados_conta.TabIndex = 8
        '
        'btn_limpar
        '
        Me.btn_limpar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_limpar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_limpar.FlatAppearance.BorderSize = 5
        Me.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar.Image = CType(resources.GetObject("btn_limpar.Image"), System.Drawing.Image)
        Me.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_limpar.Location = New System.Drawing.Point(618, 101)
        Me.btn_limpar.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(110, 60)
        Me.btn_limpar.TabIndex = 7
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'lbl_aviso_inserir
        '
        Me.lbl_aviso_inserir.AutoSize = True
        Me.lbl_aviso_inserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aviso_inserir.Location = New System.Drawing.Point(191, 0)
        Me.lbl_aviso_inserir.Name = "lbl_aviso_inserir"
        Me.lbl_aviso_inserir.Size = New System.Drawing.Size(355, 16)
        Me.lbl_aviso_inserir.TabIndex = 12
        Me.lbl_aviso_inserir.Text = "*** SOMENTE PARA INCLUIR NOVAS CONTAS ***"
        '
        'txt_senha_repete
        '
        Me.txt_senha_repete.Location = New System.Drawing.Point(253, 120)
        Me.txt_senha_repete.MaxLength = 20
        Me.txt_senha_repete.Name = "txt_senha_repete"
        Me.txt_senha_repete.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_repete.Size = New System.Drawing.Size(200, 22)
        Me.txt_senha_repete.TabIndex = 5
        '
        'lbl_senha_repete
        '
        Me.lbl_senha_repete.AutoSize = True
        Me.lbl_senha_repete.Location = New System.Drawing.Point(250, 96)
        Me.lbl_senha_repete.Name = "lbl_senha_repete"
        Me.lbl_senha_repete.Size = New System.Drawing.Size(121, 16)
        Me.lbl_senha_repete.TabIndex = 11
        Me.lbl_senha_repete.Text = "REPITA A SENHA:"
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_salvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_salvar.FlatAppearance.BorderSize = 5
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salvar.Location = New System.Drawing.Point(493, 101)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(110, 60)
        Me.btn_salvar.TabIndex = 6
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'lbl_usuario_e_data
        '
        Me.lbl_usuario_e_data.AutoSize = True
        Me.lbl_usuario_e_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario_e_data.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_usuario_e_data.Location = New System.Drawing.Point(12, 9)
        Me.lbl_usuario_e_data.Name = "lbl_usuario_e_data"
        Me.lbl_usuario_e_data.Size = New System.Drawing.Size(145, 18)
        Me.lbl_usuario_e_data.TabIndex = 8
        Me.lbl_usuario_e_data.Text = "USUÁRIO E DATA"
        '
        'dgv_dados_conta
        '
        Me.dgv_dados_conta.AllowUserToAddRows = False
        Me.dgv_dados_conta.AllowUserToDeleteRows = False
        Me.dgv_dados_conta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_conta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_numero, Me.col_id, Me.col_usuario, Me.col_perfil, Me.col_ativado, Me.col_excluir})
        Me.dgv_dados_conta.Location = New System.Drawing.Point(26, 277)
        Me.dgv_dados_conta.Name = "dgv_dados_conta"
        Me.dgv_dados_conta.RowHeadersWidth = 51
        Me.dgv_dados_conta.RowTemplate.Height = 24
        Me.dgv_dados_conta.Size = New System.Drawing.Size(743, 262)
        Me.dgv_dados_conta.TabIndex = 9
        Me.dgv_dados_conta.TabStop = False
        '
        'col_numero
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_numero.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_numero.Frozen = True
        Me.col_numero.HeaderText = "Nº"
        Me.col_numero.MinimumWidth = 6
        Me.col_numero.Name = "col_numero"
        Me.col_numero.ReadOnly = True
        Me.col_numero.Width = 50
        '
        'col_id
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_id.Frozen = True
        Me.col_id.HeaderText = "ID"
        Me.col_id.MaxInputLength = 3
        Me.col_id.MinimumWidth = 6
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Width = 50
        '
        'col_usuario
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_usuario.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_usuario.HeaderText = "USUÁRIO"
        Me.col_usuario.MinimumWidth = 6
        Me.col_usuario.Name = "col_usuario"
        Me.col_usuario.ReadOnly = True
        Me.col_usuario.Width = 150
        '
        'col_perfil
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_perfil.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_perfil.HeaderText = "PERFIL"
        Me.col_perfil.MinimumWidth = 6
        Me.col_perfil.Name = "col_perfil"
        Me.col_perfil.ReadOnly = True
        Me.col_perfil.Width = 125
        '
        'col_ativado
        '
        Me.col_ativado.FalseValue = """n"""
        Me.col_ativado.HeaderText = "ATIVADO"
        Me.col_ativado.MinimumWidth = 6
        Me.col_ativado.Name = "col_ativado"
        Me.col_ativado.TrueValue = """s"""
        Me.col_ativado.Width = 60
        '
        'col_excluir
        '
        Me.col_excluir.HeaderText = "EXCLUIR"
        Me.col_excluir.Image = CType(resources.GetObject("col_excluir.Image"), System.Drawing.Image)
        Me.col_excluir.MinimumWidth = 6
        Me.col_excluir.Name = "col_excluir"
        Me.col_excluir.Width = 60
        '
        'lbl_aviso_editar_excluir
        '
        Me.lbl_aviso_editar_excluir.AutoSize = True
        Me.lbl_aviso_editar_excluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aviso_editar_excluir.Location = New System.Drawing.Point(186, 258)
        Me.lbl_aviso_editar_excluir.Name = "lbl_aviso_editar_excluir"
        Me.lbl_aviso_editar_excluir.Size = New System.Drawing.Size(425, 16)
        Me.lbl_aviso_editar_excluir.TabIndex = 13
        Me.lbl_aviso_editar_excluir.Text = "***  SOMENTE PARA (DES)ATIVAR E EXCLUIR CONTAS  ***"
        '
        'frm_contas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(798, 551)
        Me.Controls.Add(Me.lbl_aviso_editar_excluir)
        Me.Controls.Add(Me.dgv_dados_conta)
        Me.Controls.Add(Me.lbl_usuario_e_data)
        Me.Controls.Add(Me.gb_dados_conta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_contas"
        Me.Text = "GERENCIAMENTO DE CONTAS"
        Me.gb_dados_conta.ResumeLayout(False)
        Me.gb_dados_conta.PerformLayout()
        CType(Me.dgv_dados_conta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_senha As Label
    Friend WithEvents lbl_perfil As Label
    Friend WithEvents lbl_ativado As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents cmb_perfil As ComboBox
    Friend WithEvents cmb_ativado As ComboBox
    Friend WithEvents gb_dados_conta As Panel
    Friend WithEvents lbl_usuario_e_data As Label
    Friend WithEvents btn_salvar As Button
    Friend WithEvents lbl_senha_repete As Label
    Friend WithEvents txt_senha_repete As TextBox
    Friend WithEvents dgv_dados_conta As DataGridView
    Friend WithEvents lbl_aviso_inserir As Label
    Friend WithEvents lbl_aviso_editar_excluir As Label
    Friend WithEvents col_numero As DataGridViewTextBoxColumn
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_usuario As DataGridViewTextBoxColumn
    Friend WithEvents col_perfil As DataGridViewTextBoxColumn
    Friend WithEvents col_ativado As DataGridViewCheckBoxColumn
    Friend WithEvents col_excluir As DataGridViewImageColumn
    Friend WithEvents btn_limpar As Button
End Class
