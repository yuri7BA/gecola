<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cad_gerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_gerente))
        Me.lbl_usuario_e_data = New System.Windows.Forms.Label()
        Me.gb_dados_pessoais = New System.Windows.Forms.Panel()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.dtp_nascimento = New System.Windows.Forms.DateTimePicker()
        Me.cmb_sexo = New System.Windows.Forms.ComboBox()
        Me.txt_sobrenome = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.pb_foto = New System.Windows.Forms.PictureBox()
        Me.lbl_foto = New System.Windows.Forms.Label()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.lbl_dados_pessoais = New System.Windows.Forms.Label()
        Me.lbl_sobrenome = New System.Windows.Forms.Label()
        Me.lbl_nascimento = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_salvar_base = New System.Windows.Forms.Button()
        Me.ts_pesquisar = New System.Windows.Forms.ToolStrip()
        Me.lbl_cmb_pesquisar = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_pesquisar = New System.Windows.Forms.ToolStripComboBox()
        Me.lbl_txt_pesquisar = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_salvar_topo = New System.Windows.Forms.ToolStripButton()
        Me.gb_autenticacao = New System.Windows.Forms.Panel()
        Me.ckb_senhas = New System.Windows.Forms.CheckBox()
        Me.txt_senha_repete = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_autenticacao = New System.Windows.Forms.Label()
        Me.lbl_senha_repete = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.gb_endereco = New System.Windows.Forms.Panel()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.lbl_cidade = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.lbl_bairro = New System.Windows.Forms.Label()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.lbl_uf = New System.Windows.Forms.Label()
        Me.txt_complemento = New System.Windows.Forms.TextBox()
        Me.lbl_complemento = New System.Windows.Forms.Label()
        Me.txt_logradouro = New System.Windows.Forms.TextBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_endereco = New System.Windows.Forms.Label()
        Me.lbl_logradouro = New System.Windows.Forms.Label()
        Me.lbl_cep = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.janela_selecionar_foto = New System.Windows.Forms.OpenFileDialog()
        Me.gb_contato = New System.Windows.Forms.Panel()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_contato = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_celular = New System.Windows.Forms.Label()
        Me.dgv_cadastros = New System.Windows.Forms.DataGridView()
        Me.col_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ativado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gb_dados_pessoais.SuspendLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_pesquisar.SuspendLayout()
        Me.gb_autenticacao.SuspendLayout()
        Me.gb_endereco.SuspendLayout()
        Me.gb_contato.SuspendLayout()
        CType(Me.dgv_cadastros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_usuario_e_data
        '
        Me.lbl_usuario_e_data.AutoSize = True
        Me.lbl_usuario_e_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario_e_data.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_usuario_e_data.Location = New System.Drawing.Point(12, 46)
        Me.lbl_usuario_e_data.Name = "lbl_usuario_e_data"
        Me.lbl_usuario_e_data.Size = New System.Drawing.Size(145, 18)
        Me.lbl_usuario_e_data.TabIndex = 9
        Me.lbl_usuario_e_data.Text = "USUÁRIO E DATA"
        '
        'gb_dados_pessoais
        '
        Me.gb_dados_pessoais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gb_dados_pessoais.Controls.Add(Me.txt_cpf)
        Me.gb_dados_pessoais.Controls.Add(Me.dtp_nascimento)
        Me.gb_dados_pessoais.Controls.Add(Me.cmb_sexo)
        Me.gb_dados_pessoais.Controls.Add(Me.txt_sobrenome)
        Me.gb_dados_pessoais.Controls.Add(Me.txt_nome)
        Me.gb_dados_pessoais.Controls.Add(Me.pb_foto)
        Me.gb_dados_pessoais.Controls.Add(Me.lbl_foto)
        Me.gb_dados_pessoais.Controls.Add(Me.lbl_sexo)
        Me.gb_dados_pessoais.Controls.Add(Me.lbl_dados_pessoais)
        Me.gb_dados_pessoais.Controls.Add(Me.lbl_sobrenome)
        Me.gb_dados_pessoais.Controls.Add(Me.lbl_nascimento)
        Me.gb_dados_pessoais.Controls.Add(Me.lbl_cpf)
        Me.gb_dados_pessoais.Controls.Add(Me.lbl_nome)
        Me.gb_dados_pessoais.Location = New System.Drawing.Point(15, 81)
        Me.gb_dados_pessoais.Name = "gb_dados_pessoais"
        Me.gb_dados_pessoais.Size = New System.Drawing.Size(715, 171)
        Me.gb_dados_pessoais.TabIndex = 10
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(53, 26)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(121, 22)
        Me.txt_cpf.TabIndex = 1
        '
        'dtp_nascimento
        '
        Me.dtp_nascimento.Checked = False
        Me.dtp_nascimento.CustomFormat = ""
        Me.dtp_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_nascimento.Location = New System.Drawing.Point(388, 26)
        Me.dtp_nascimento.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dtp_nascimento.Name = "dtp_nascimento"
        Me.dtp_nascimento.Size = New System.Drawing.Size(145, 22)
        Me.dtp_nascimento.TabIndex = 2
        Me.dtp_nascimento.Value = New Date(2024, 11, 14, 0, 59, 41, 0)
        '
        'cmb_sexo
        '
        Me.cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sexo.FormattingEnabled = True
        Me.cmb_sexo.Location = New System.Drawing.Point(423, 72)
        Me.cmb_sexo.Name = "cmb_sexo"
        Me.cmb_sexo.Size = New System.Drawing.Size(110, 24)
        Me.cmb_sexo.TabIndex = 5
        '
        'txt_sobrenome
        '
        Me.txt_sobrenome.Location = New System.Drawing.Point(114, 118)
        Me.txt_sobrenome.MaxLength = 20
        Me.txt_sobrenome.Name = "txt_sobrenome"
        Me.txt_sobrenome.Size = New System.Drawing.Size(220, 22)
        Me.txt_sobrenome.TabIndex = 4
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(67, 72)
        Me.txt_nome.MaxLength = 20
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(200, 22)
        Me.txt_nome.TabIndex = 3
        '
        'pb_foto
        '
        Me.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_foto.InitialImage = CType(resources.GetObject("pb_foto.InitialImage"), System.Drawing.Image)
        Me.pb_foto.Location = New System.Drawing.Point(548, 3)
        Me.pb_foto.Name = "pb_foto"
        Me.pb_foto.Size = New System.Drawing.Size(160, 160)
        Me.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto.TabIndex = 16
        Me.pb_foto.TabStop = False
        '
        'lbl_foto
        '
        Me.lbl_foto.AutoSize = True
        Me.lbl_foto.Location = New System.Drawing.Point(486, 124)
        Me.lbl_foto.Name = "lbl_foto"
        Me.lbl_foto.Size = New System.Drawing.Size(47, 16)
        Me.lbl_foto.TabIndex = 17
        Me.lbl_foto.Text = "FOTO:"
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Location = New System.Drawing.Point(371, 75)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(46, 16)
        Me.lbl_sexo.TabIndex = 15
        Me.lbl_sexo.Text = "SEXO:"
        '
        'lbl_dados_pessoais
        '
        Me.lbl_dados_pessoais.AutoSize = True
        Me.lbl_dados_pessoais.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dados_pessoais.Location = New System.Drawing.Point(6, 0)
        Me.lbl_dados_pessoais.Name = "lbl_dados_pessoais"
        Me.lbl_dados_pessoais.Size = New System.Drawing.Size(455, 16)
        Me.lbl_dados_pessoais.TabIndex = 12
        Me.lbl_dados_pessoais.Text = "DADOS PESSOAIS (clique duplo no CPF para limpar os campos)"
        '
        'lbl_sobrenome
        '
        Me.lbl_sobrenome.AutoSize = True
        Me.lbl_sobrenome.Location = New System.Drawing.Point(6, 121)
        Me.lbl_sobrenome.Name = "lbl_sobrenome"
        Me.lbl_sobrenome.Size = New System.Drawing.Size(102, 16)
        Me.lbl_sobrenome.TabIndex = 11
        Me.lbl_sobrenome.Text = "*SOBRENOME:"
        '
        'lbl_nascimento
        '
        Me.lbl_nascimento.AutoSize = True
        Me.lbl_nascimento.Location = New System.Drawing.Point(216, 29)
        Me.lbl_nascimento.Name = "lbl_nascimento"
        Me.lbl_nascimento.Size = New System.Drawing.Size(166, 16)
        Me.lbl_nascimento.TabIndex = 3
        Me.lbl_nascimento.Text = "*DATA DE NASCIMENTO:"
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Location = New System.Drawing.Point(6, 29)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(41, 16)
        Me.lbl_cpf.TabIndex = 0
        Me.lbl_cpf.Text = "*CPF:"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Location = New System.Drawing.Point(6, 75)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(55, 16)
        Me.lbl_nome.TabIndex = 1
        Me.lbl_nome.Text = "*NOME:"
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
        Me.btn_limpar.Location = New System.Drawing.Point(588, 28)
        Me.btn_limpar.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(110, 71)
        Me.btn_limpar.TabIndex = 16
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'btn_salvar_base
        '
        Me.btn_salvar_base.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_salvar_base.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_salvar_base.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_salvar_base.FlatAppearance.BorderSize = 5
        Me.btn_salvar_base.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar_base.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar_base.Image = CType(resources.GetObject("btn_salvar_base.Image"), System.Drawing.Image)
        Me.btn_salvar_base.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salvar_base.Location = New System.Drawing.Point(467, 28)
        Me.btn_salvar_base.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_salvar_base.Name = "btn_salvar_base"
        Me.btn_salvar_base.Size = New System.Drawing.Size(110, 71)
        Me.btn_salvar_base.TabIndex = 15
        Me.btn_salvar_base.Text = "SALVAR"
        Me.btn_salvar_base.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salvar_base.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_salvar_base.UseVisualStyleBackColor = False
        '
        'ts_pesquisar
        '
        Me.ts_pesquisar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_pesquisar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ts_pesquisar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_cmb_pesquisar, Me.cmb_pesquisar, Me.lbl_txt_pesquisar, Me.txt_pesquisar, Me.ToolStripSeparator1, Me.btn_salvar_topo})
        Me.ts_pesquisar.Location = New System.Drawing.Point(0, 0)
        Me.ts_pesquisar.Name = "ts_pesquisar"
        Me.ts_pesquisar.Size = New System.Drawing.Size(745, 31)
        Me.ts_pesquisar.TabIndex = 0
        Me.ts_pesquisar.Text = "ToolStrip1"
        '
        'lbl_cmb_pesquisar
        '
        Me.lbl_cmb_pesquisar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cmb_pesquisar.Name = "lbl_cmb_pesquisar"
        Me.lbl_cmb_pesquisar.Size = New System.Drawing.Size(109, 28)
        Me.lbl_cmb_pesquisar.Text = "Pesquisar por:"
        '
        'cmb_pesquisar
        '
        Me.cmb_pesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pesquisar.Name = "cmb_pesquisar"
        Me.cmb_pesquisar.Size = New System.Drawing.Size(108, 31)
        '
        'lbl_txt_pesquisar
        '
        Me.lbl_txt_pesquisar.BackColor = System.Drawing.Color.SpringGreen
        Me.lbl_txt_pesquisar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_txt_pesquisar.Name = "lbl_txt_pesquisar"
        Me.lbl_txt_pesquisar.Size = New System.Drawing.Size(136, 28)
        Me.lbl_txt_pesquisar.Text = "Texto a pesquisar:"
        '
        'txt_pesquisar
        '
        Me.txt_pesquisar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_pesquisar.Name = "txt_pesquisar"
        Me.txt_pesquisar.Size = New System.Drawing.Size(89, 31)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'btn_salvar_topo
        '
        Me.btn_salvar_topo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_salvar_topo.Image = CType(resources.GetObject("btn_salvar_topo.Image"), System.Drawing.Image)
        Me.btn_salvar_topo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salvar_topo.Name = "btn_salvar_topo"
        Me.btn_salvar_topo.Size = New System.Drawing.Size(29, 28)
        Me.btn_salvar_topo.Text = "ToolStripButton1"
        Me.btn_salvar_topo.ToolTipText = "Salvar"
        '
        'gb_autenticacao
        '
        Me.gb_autenticacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gb_autenticacao.Controls.Add(Me.ckb_senhas)
        Me.gb_autenticacao.Controls.Add(Me.txt_senha_repete)
        Me.gb_autenticacao.Controls.Add(Me.txt_senha)
        Me.gb_autenticacao.Controls.Add(Me.txt_usuario)
        Me.gb_autenticacao.Controls.Add(Me.lbl_autenticacao)
        Me.gb_autenticacao.Controls.Add(Me.lbl_senha_repete)
        Me.gb_autenticacao.Controls.Add(Me.lbl_usuario)
        Me.gb_autenticacao.Controls.Add(Me.lbl_senha)
        Me.gb_autenticacao.Location = New System.Drawing.Point(15, 258)
        Me.gb_autenticacao.Name = "gb_autenticacao"
        Me.gb_autenticacao.Size = New System.Drawing.Size(715, 110)
        Me.gb_autenticacao.TabIndex = 12
        '
        'ckb_senhas
        '
        Me.ckb_senhas.AutoSize = True
        Me.ckb_senhas.Location = New System.Drawing.Point(423, 46)
        Me.ckb_senhas.Name = "ckb_senhas"
        Me.ckb_senhas.Size = New System.Drawing.Size(139, 20)
        Me.ckb_senhas.TabIndex = 9
        Me.ckb_senhas.Text = "Mostrar as senhas"
        Me.ckb_senhas.UseVisualStyleBackColor = True
        '
        'txt_senha_repete
        '
        Me.txt_senha_repete.Location = New System.Drawing.Point(423, 72)
        Me.txt_senha_repete.MaxLength = 20
        Me.txt_senha_repete.Name = "txt_senha_repete"
        Me.txt_senha_repete.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_repete.Size = New System.Drawing.Size(200, 22)
        Me.txt_senha_repete.TabIndex = 8
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(74, 72)
        Me.txt_senha.MaxLength = 20
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(200, 22)
        Me.txt_senha.TabIndex = 7
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(87, 26)
        Me.txt_usuario.MaxLength = 20
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(187, 22)
        Me.txt_usuario.TabIndex = 6
        '
        'lbl_autenticacao
        '
        Me.lbl_autenticacao.AutoSize = True
        Me.lbl_autenticacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_autenticacao.Location = New System.Drawing.Point(6, 0)
        Me.lbl_autenticacao.Name = "lbl_autenticacao"
        Me.lbl_autenticacao.Size = New System.Drawing.Size(462, 16)
        Me.lbl_autenticacao.TabIndex = 12
        Me.lbl_autenticacao.Text = "AUTENTICAÇÃO (clique duplo no usuário para limpar os campos)"
        '
        'lbl_senha_repete
        '
        Me.lbl_senha_repete.AutoSize = True
        Me.lbl_senha_repete.Location = New System.Drawing.Point(291, 75)
        Me.lbl_senha_repete.Name = "lbl_senha_repete"
        Me.lbl_senha_repete.Size = New System.Drawing.Size(126, 16)
        Me.lbl_senha_repete.TabIndex = 11
        Me.lbl_senha_repete.Text = "*REPITA A SENHA:"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(6, 29)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(76, 16)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "*USUÁRIO:"
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Location = New System.Drawing.Point(6, 75)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(62, 16)
        Me.lbl_senha.TabIndex = 1
        Me.lbl_senha.Text = "*SENHA:"
        '
        'gb_endereco
        '
        Me.gb_endereco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gb_endereco.Controls.Add(Me.txt_cep)
        Me.gb_endereco.Controls.Add(Me.txt_cidade)
        Me.gb_endereco.Controls.Add(Me.lbl_cidade)
        Me.gb_endereco.Controls.Add(Me.txt_bairro)
        Me.gb_endereco.Controls.Add(Me.lbl_bairro)
        Me.gb_endereco.Controls.Add(Me.txt_uf)
        Me.gb_endereco.Controls.Add(Me.lbl_uf)
        Me.gb_endereco.Controls.Add(Me.txt_complemento)
        Me.gb_endereco.Controls.Add(Me.lbl_complemento)
        Me.gb_endereco.Controls.Add(Me.txt_logradouro)
        Me.gb_endereco.Controls.Add(Me.txt_numero)
        Me.gb_endereco.Controls.Add(Me.lbl_endereco)
        Me.gb_endereco.Controls.Add(Me.lbl_logradouro)
        Me.gb_endereco.Controls.Add(Me.lbl_cep)
        Me.gb_endereco.Controls.Add(Me.lbl_numero)
        Me.gb_endereco.Location = New System.Drawing.Point(15, 374)
        Me.gb_endereco.Name = "gb_endereco"
        Me.gb_endereco.Size = New System.Drawing.Size(715, 153)
        Me.gb_endereco.TabIndex = 13
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(53, 26)
        Me.txt_cep.Mask = "99999999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(110, 22)
        Me.txt_cep.TabIndex = 10
        '
        'txt_cidade
        '
        Me.txt_cidade.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_cidade.Location = New System.Drawing.Point(408, 116)
        Me.txt_cidade.MaxLength = 20
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.ReadOnly = True
        Me.txt_cidade.Size = New System.Drawing.Size(290, 22)
        Me.txt_cidade.TabIndex = 98
        Me.txt_cidade.TabStop = False
        '
        'lbl_cidade
        '
        Me.lbl_cidade.AutoSize = True
        Me.lbl_cidade.Location = New System.Drawing.Point(342, 119)
        Me.lbl_cidade.Name = "lbl_cidade"
        Me.lbl_cidade.Size = New System.Drawing.Size(60, 16)
        Me.lbl_cidade.TabIndex = 20
        Me.lbl_cidade.Text = "CIDADE:"
        '
        'txt_bairro
        '
        Me.txt_bairro.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_bairro.Location = New System.Drawing.Point(73, 116)
        Me.txt_bairro.MaxLength = 20
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.ReadOnly = True
        Me.txt_bairro.Size = New System.Drawing.Size(250, 22)
        Me.txt_bairro.TabIndex = 97
        Me.txt_bairro.TabStop = False
        '
        'lbl_bairro
        '
        Me.lbl_bairro.AutoSize = True
        Me.lbl_bairro.Location = New System.Drawing.Point(6, 119)
        Me.lbl_bairro.Name = "lbl_bairro"
        Me.lbl_bairro.Size = New System.Drawing.Size(61, 16)
        Me.lbl_bairro.TabIndex = 18
        Me.lbl_bairro.Text = "BAIRRO:"
        '
        'txt_uf
        '
        Me.txt_uf.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_uf.Location = New System.Drawing.Point(634, 72)
        Me.txt_uf.MaxLength = 20
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.ReadOnly = True
        Me.txt_uf.Size = New System.Drawing.Size(64, 22)
        Me.txt_uf.TabIndex = 96
        Me.txt_uf.TabStop = False
        '
        'lbl_uf
        '
        Me.lbl_uf.AutoSize = True
        Me.lbl_uf.Location = New System.Drawing.Point(600, 75)
        Me.lbl_uf.Name = "lbl_uf"
        Me.lbl_uf.Size = New System.Drawing.Size(28, 16)
        Me.lbl_uf.TabIndex = 16
        Me.lbl_uf.Text = "UF:"
        '
        'txt_complemento
        '
        Me.txt_complemento.Location = New System.Drawing.Point(257, 72)
        Me.txt_complemento.MaxLength = 15
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(160, 22)
        Me.txt_complemento.TabIndex = 12
        '
        'lbl_complemento
        '
        Me.lbl_complemento.AutoSize = True
        Me.lbl_complemento.Location = New System.Drawing.Point(137, 75)
        Me.lbl_complemento.Name = "lbl_complemento"
        Me.lbl_complemento.Size = New System.Drawing.Size(114, 16)
        Me.lbl_complemento.TabIndex = 13
        Me.lbl_complemento.Text = "COMPLEMENTO:"
        '
        'txt_logradouro
        '
        Me.txt_logradouro.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_logradouro.Location = New System.Drawing.Point(281, 26)
        Me.txt_logradouro.MaxLength = 20
        Me.txt_logradouro.Name = "txt_logradouro"
        Me.txt_logradouro.ReadOnly = True
        Me.txt_logradouro.Size = New System.Drawing.Size(417, 22)
        Me.txt_logradouro.TabIndex = 95
        Me.txt_logradouro.TabStop = False
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(37, 72)
        Me.txt_numero.MaxLength = 6
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(80, 22)
        Me.txt_numero.TabIndex = 11
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_endereco.Location = New System.Drawing.Point(6, 0)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(408, 16)
        Me.lbl_endereco.TabIndex = 12
        Me.lbl_endereco.Text = "ENDEREÇO (clique duplo no CEP para limpar os campos)"
        '
        'lbl_logradouro
        '
        Me.lbl_logradouro.AutoSize = True
        Me.lbl_logradouro.Location = New System.Drawing.Point(169, 29)
        Me.lbl_logradouro.Name = "lbl_logradouro"
        Me.lbl_logradouro.Size = New System.Drawing.Size(106, 16)
        Me.lbl_logradouro.TabIndex = 11
        Me.lbl_logradouro.Text = "LOGRADOURO:"
        '
        'lbl_cep
        '
        Me.lbl_cep.AutoSize = True
        Me.lbl_cep.Location = New System.Drawing.Point(6, 29)
        Me.lbl_cep.Name = "lbl_cep"
        Me.lbl_cep.Size = New System.Drawing.Size(42, 16)
        Me.lbl_cep.TabIndex = 0
        Me.lbl_cep.Text = "*CEP:"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(6, 75)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(25, 16)
        Me.lbl_numero.TabIndex = 1
        Me.lbl_numero.Text = "Nº:"
        '
        'janela_selecionar_foto
        '
        Me.janela_selecionar_foto.FileName = "janela_selecionar_foto"
        '
        'gb_contato
        '
        Me.gb_contato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gb_contato.Controls.Add(Me.txt_celular)
        Me.gb_contato.Controls.Add(Me.txt_email)
        Me.gb_contato.Controls.Add(Me.lbl_contato)
        Me.gb_contato.Controls.Add(Me.lbl_email)
        Me.gb_contato.Controls.Add(Me.lbl_celular)
        Me.gb_contato.Controls.Add(Me.btn_salvar_base)
        Me.gb_contato.Controls.Add(Me.btn_limpar)
        Me.gb_contato.Location = New System.Drawing.Point(15, 533)
        Me.gb_contato.Name = "gb_contato"
        Me.gb_contato.Size = New System.Drawing.Size(715, 116)
        Me.gb_contato.TabIndex = 21
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(88, 31)
        Me.txt_celular.Mask = "\(99\)\ 99999\-9999"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(150, 22)
        Me.txt_celular.TabIndex = 13
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(88, 75)
        Me.txt_email.MaxLength = 40
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(300, 22)
        Me.txt_email.TabIndex = 14
        '
        'lbl_contato
        '
        Me.lbl_contato.AutoSize = True
        Me.lbl_contato.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contato.Location = New System.Drawing.Point(6, 0)
        Me.lbl_contato.Name = "lbl_contato"
        Me.lbl_contato.Size = New System.Drawing.Size(597, 16)
        Me.lbl_contato.TabIndex = 12
        Me.lbl_contato.Text = "CONTATO (preencha pelo menos 1 dos campos. Clique duplo em 1 deles os limpará)"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(29, 78)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(53, 16)
        Me.lbl_email.TabIndex = 11
        Me.lbl_email.Text = "E-MAIL:"
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.Location = New System.Drawing.Point(11, 34)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(71, 16)
        Me.lbl_celular.TabIndex = 0
        Me.lbl_celular.Text = "CELULAR:"
        '
        'dgv_cadastros
        '
        Me.dgv_cadastros.AllowUserToAddRows = False
        Me.dgv_cadastros.AllowUserToDeleteRows = False
        Me.dgv_cadastros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_cadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cadastros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_numero, Me.col_CPF, Me.col_usuario, Me.col_perfil, Me.col_ativado})
        Me.dgv_cadastros.Location = New System.Drawing.Point(15, 655)
        Me.dgv_cadastros.Name = "dgv_cadastros"
        Me.dgv_cadastros.RowHeadersWidth = 51
        Me.dgv_cadastros.RowTemplate.Height = 24
        Me.dgv_cadastros.Size = New System.Drawing.Size(715, 316)
        Me.dgv_cadastros.TabIndex = 99
        '
        'col_numero
        '
        Me.col_numero.Frozen = True
        Me.col_numero.HeaderText = "Nº"
        Me.col_numero.MinimumWidth = 6
        Me.col_numero.Name = "col_numero"
        Me.col_numero.ReadOnly = True
        Me.col_numero.Width = 40
        '
        'col_CPF
        '
        Me.col_CPF.Frozen = True
        Me.col_CPF.HeaderText = "CPF"
        Me.col_CPF.MinimumWidth = 6
        Me.col_CPF.Name = "col_CPF"
        Me.col_CPF.ReadOnly = True
        Me.col_CPF.Width = 120
        '
        'col_usuario
        '
        Me.col_usuario.Frozen = True
        Me.col_usuario.HeaderText = "USUÁRIO"
        Me.col_usuario.MinimumWidth = 6
        Me.col_usuario.Name = "col_usuario"
        Me.col_usuario.ReadOnly = True
        Me.col_usuario.Width = 160
        '
        'col_perfil
        '
        Me.col_perfil.Frozen = True
        Me.col_perfil.HeaderText = "PERFIL"
        Me.col_perfil.MinimumWidth = 6
        Me.col_perfil.Name = "col_perfil"
        Me.col_perfil.ReadOnly = True
        Me.col_perfil.Visible = False
        Me.col_perfil.Width = 70
        '
        'col_ativado
        '
        Me.col_ativado.FalseValue = """n"""
        Me.col_ativado.HeaderText = "ATIVADO"
        Me.col_ativado.MinimumWidth = 6
        Me.col_ativado.Name = "col_ativado"
        Me.col_ativado.TrueValue = """s"""
        Me.col_ativado.Width = 70
        '
        'frm_cad_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(745, 983)
        Me.Controls.Add(Me.dgv_cadastros)
        Me.Controls.Add(Me.gb_contato)
        Me.Controls.Add(Me.gb_endereco)
        Me.Controls.Add(Me.gb_autenticacao)
        Me.Controls.Add(Me.ts_pesquisar)
        Me.Controls.Add(Me.lbl_usuario_e_data)
        Me.Controls.Add(Me.gb_dados_pessoais)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cad_gerente"
        Me.Text = "CADASTRO DE GERENTES"
        Me.gb_dados_pessoais.ResumeLayout(False)
        Me.gb_dados_pessoais.PerformLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_pesquisar.ResumeLayout(False)
        Me.ts_pesquisar.PerformLayout()
        Me.gb_autenticacao.ResumeLayout(False)
        Me.gb_autenticacao.PerformLayout()
        Me.gb_endereco.ResumeLayout(False)
        Me.gb_endereco.PerformLayout()
        Me.gb_contato.ResumeLayout(False)
        Me.gb_contato.PerformLayout()
        CType(Me.dgv_cadastros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_usuario_e_data As Label
    Friend WithEvents gb_dados_pessoais As Panel
    Friend WithEvents btn_limpar As Button
    Friend WithEvents txt_sobrenome As TextBox
    Friend WithEvents lbl_sobrenome As Label
    Friend WithEvents lbl_nascimento As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_dados_pessoais As Label
    Friend WithEvents dtp_nascimento As DateTimePicker
    Friend WithEvents lbl_sexo As Label
    Friend WithEvents cmb_sexo As ComboBox
    Friend WithEvents ts_pesquisar As ToolStrip
    Friend WithEvents btn_salvar_topo As ToolStripButton
    Friend WithEvents lbl_txt_pesquisar As ToolStripLabel
    Friend WithEvents txt_pesquisar As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lbl_cmb_pesquisar As ToolStripLabel
    Friend WithEvents cmb_pesquisar As ToolStripComboBox
    Friend WithEvents pb_foto As PictureBox
    Friend WithEvents lbl_foto As Label
    Friend WithEvents gb_autenticacao As Panel
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_autenticacao As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents txt_senha_repete As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents lbl_senha_repete As Label
    Friend WithEvents lbl_senha As Label
    Friend WithEvents gb_endereco As Panel
    Friend WithEvents txt_logradouro As TextBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents lbl_endereco As Label
    Friend WithEvents lbl_logradouro As Label
    Friend WithEvents lbl_cep As Label
    Friend WithEvents lbl_numero As Label
    Friend WithEvents txt_complemento As TextBox
    Friend WithEvents lbl_complemento As Label
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents lbl_uf As Label
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents lbl_cidade As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents lbl_bairro As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents janela_selecionar_foto As OpenFileDialog
    Friend WithEvents gb_contato As Panel
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_contato As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_celular As Label
    Friend WithEvents btn_salvar_base As Button
    Friend WithEvents dgv_cadastros As DataGridView
    Friend WithEvents ckb_senhas As CheckBox
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents col_numero As DataGridViewTextBoxColumn
    Friend WithEvents col_CPF As DataGridViewTextBoxColumn
    Friend WithEvents col_usuario As DataGridViewTextBoxColumn
    Friend WithEvents col_perfil As DataGridViewTextBoxColumn
    Friend WithEvents col_ativado As DataGridViewCheckBoxColumn
End Class
