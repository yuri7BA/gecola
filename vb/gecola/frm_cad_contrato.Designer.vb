<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cad_contrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_contrato))
        Me.lbl_usuario_e_data = New System.Windows.Forms.Label()
        Me.txt_fabricante = New System.Windows.Forms.TextBox()
        Me.lbl_foto = New System.Windows.Forms.Label()
        Me.pb_foto_aeronave = New System.Windows.Forms.PictureBox()
        Me.lbl_ano = New System.Windows.Forms.Label()
        Me.lbl_combustivel = New System.Windows.Forms.Label()
        Me.lbl_modelo = New System.Windows.Forms.Label()
        Me.lbl_fabricante = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.btn_limpar_gb_cliente = New System.Windows.Forms.Button()
        Me.btn_cadastros_de_clientes = New System.Windows.Forms.Button()
        Me.ts_pesquisar = New System.Windows.Forms.ToolStrip()
        Me.lbl_pesquisar_quem = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_pesquisar_quem = New System.Windows.Forms.ToolStripComboBox()
        Me.lbl_cmb_pesquisar = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_pesquisar = New System.Windows.Forms.ToolStripComboBox()
        Me.lbl_txt_pesquisar = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_salvar_topo = New System.Windows.Forms.ToolStripButton()
        Me.gb_cliente = New System.Windows.Forms.Panel()
        Me.btn_cliente_limpar_campos = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pb_foto_cliente = New System.Windows.Forms.PictureBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sobrenome = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_sobrenome = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.janela_selecionar_foto = New System.Windows.Forms.OpenFileDialog()
        Me.dgv_cadastros = New System.Windows.Forms.DataGridView()
        Me.col_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sobrenome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ativo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fabricante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_assentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_velocidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_autonomia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_operacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_regra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_diaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ativa = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gb_aeronave = New System.Windows.Forms.Panel()
        Me.btn_cadastros_de_aeronaves = New System.Windows.Forms.Button()
        Me.btn_aeronave_limpar_campos = New System.Windows.Forms.Button()
        Me.txt_diaria = New System.Windows.Forms.TextBox()
        Me.txt_operacao = New System.Windows.Forms.TextBox()
        Me.txt_regra = New System.Windows.Forms.TextBox()
        Me.txt_autonomia = New System.Windows.Forms.TextBox()
        Me.txt_assentos = New System.Windows.Forms.TextBox()
        Me.txt_velocidade = New System.Windows.Forms.TextBox()
        Me.txt_pesomin = New System.Windows.Forms.TextBox()
        Me.txt_pesomax = New System.Windows.Forms.TextBox()
        Me.txt_ano = New System.Windows.Forms.TextBox()
        Me.txt_combustivel = New System.Windows.Forms.TextBox()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.txt_matricula = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_diaria_rs = New System.Windows.Forms.Label()
        Me.lbl_autonomia_km = New System.Windows.Forms.Label()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.lbl_velocidade_kmh = New System.Windows.Forms.Label()
        Me.lbl_pesomax_kg = New System.Windows.Forms.Label()
        Me.lbl_pesomin_kg = New System.Windows.Forms.Label()
        Me.btn_limpar_gb_aeronave = New System.Windows.Forms.Button()
        Me.lbl_diaria = New System.Windows.Forms.Label()
        Me.lbl_autonomia = New System.Windows.Forms.Label()
        Me.lbl_velocidade = New System.Windows.Forms.Label()
        Me.lbl_pesomax = New System.Windows.Forms.Label()
        Me.lbl_regra = New System.Windows.Forms.Label()
        Me.lbl_operacao = New System.Windows.Forms.Label()
        Me.lbl_aeronave = New System.Windows.Forms.Label()
        Me.lbl_pesomin = New System.Windows.Forms.Label()
        Me.lbl_assentos = New System.Windows.Forms.Label()
        Me.gb_financeiro = New System.Windows.Forms.Panel()
        Me.btn_calcular_diarias = New System.Windows.Forms.Button()
        Me.txt_diarias = New System.Windows.Forms.TextBox()
        Me.lbl_diarias = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_total_rs = New System.Windows.Forms.Label()
        Me.dtp_fim = New System.Windows.Forms.DateTimePicker()
        Me.dtp_inicio = New System.Windows.Forms.DateTimePicker()
        Me.ckb_pago = New System.Windows.Forms.CheckBox()
        Me.btn_gerar_contrato = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_fim = New System.Windows.Forms.Label()
        Me.lbl_financeiro = New System.Windows.Forms.Label()
        Me.lbl_inicio = New System.Windows.Forms.Label()
        CType(Me.pb_foto_aeronave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_pesquisar.SuspendLayout()
        Me.gb_cliente.SuspendLayout()
        CType(Me.pb_foto_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_cadastros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_aeronave.SuspendLayout()
        Me.gb_financeiro.SuspendLayout()
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
        'txt_fabricante
        '
        Me.txt_fabricante.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_fabricante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fabricante.Location = New System.Drawing.Point(462, 48)
        Me.txt_fabricante.MaxLength = 30
        Me.txt_fabricante.Name = "txt_fabricante"
        Me.txt_fabricante.ReadOnly = True
        Me.txt_fabricante.Size = New System.Drawing.Size(370, 22)
        Me.txt_fabricante.TabIndex = 3
        Me.txt_fabricante.TabStop = False
        '
        'lbl_foto
        '
        Me.lbl_foto.AutoSize = True
        Me.lbl_foto.Location = New System.Drawing.Point(1005, 282)
        Me.lbl_foto.Name = "lbl_foto"
        Me.lbl_foto.Size = New System.Drawing.Size(47, 16)
        Me.lbl_foto.TabIndex = 21
        Me.lbl_foto.Text = "FOTO:"
        '
        'pb_foto_aeronave
        '
        Me.pb_foto_aeronave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_foto_aeronave.InitialImage = CType(resources.GetObject("pb_foto_aeronave.InitialImage"), System.Drawing.Image)
        Me.pb_foto_aeronave.Location = New System.Drawing.Point(1058, 3)
        Me.pb_foto_aeronave.Name = "pb_foto_aeronave"
        Me.pb_foto_aeronave.Size = New System.Drawing.Size(370, 310)
        Me.pb_foto_aeronave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto_aeronave.TabIndex = 16
        Me.pb_foto_aeronave.TabStop = False
        '
        'lbl_ano
        '
        Me.lbl_ano.AutoSize = True
        Me.lbl_ano.Location = New System.Drawing.Point(806, 88)
        Me.lbl_ano.Name = "lbl_ano"
        Me.lbl_ano.Size = New System.Drawing.Size(149, 16)
        Me.lbl_ano.TabIndex = 34
        Me.lbl_ano.Text = "ANO DE FABRICAÇÃO:"
        '
        'lbl_combustivel
        '
        Me.lbl_combustivel.AutoSize = True
        Me.lbl_combustivel.Location = New System.Drawing.Point(425, 88)
        Me.lbl_combustivel.Name = "lbl_combustivel"
        Me.lbl_combustivel.Size = New System.Drawing.Size(105, 16)
        Me.lbl_combustivel.TabIndex = 27
        Me.lbl_combustivel.Text = "COMBUSTÍVEL:"
        '
        'lbl_modelo
        '
        Me.lbl_modelo.AutoSize = True
        Me.lbl_modelo.Location = New System.Drawing.Point(6, 88)
        Me.lbl_modelo.Name = "lbl_modelo"
        Me.lbl_modelo.Size = New System.Drawing.Size(67, 16)
        Me.lbl_modelo.TabIndex = 25
        Me.lbl_modelo.Text = "MODELO:"
        '
        'lbl_fabricante
        '
        Me.lbl_fabricante.AutoSize = True
        Me.lbl_fabricante.Location = New System.Drawing.Point(459, 27)
        Me.lbl_fabricante.Name = "lbl_fabricante"
        Me.lbl_fabricante.Size = New System.Drawing.Size(95, 16)
        Me.lbl_fabricante.TabIndex = 23
        Me.lbl_fabricante.Text = "FABRICANTE:"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(116, 27)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(141, 16)
        Me.lbl_tipo.TabIndex = 20
        Me.lbl_tipo.Text = "TIPO DE AERONAVE:"
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Location = New System.Drawing.Point(6, 27)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(87, 16)
        Me.lbl_matricula.TabIndex = 18
        Me.lbl_matricula.Text = "MATRÍCULA:"
        '
        'btn_limpar_gb_cliente
        '
        Me.btn_limpar_gb_cliente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_limpar_gb_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_limpar_gb_cliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_limpar_gb_cliente.FlatAppearance.BorderSize = 5
        Me.btn_limpar_gb_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpar_gb_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar_gb_cliente.Image = CType(resources.GetObject("btn_limpar_gb_cliente.Image"), System.Drawing.Image)
        Me.btn_limpar_gb_cliente.Location = New System.Drawing.Point(10, 97)
        Me.btn_limpar_gb_cliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_limpar_gb_cliente.Name = "btn_limpar_gb_cliente"
        Me.btn_limpar_gb_cliente.Size = New System.Drawing.Size(150, 50)
        Me.btn_limpar_gb_cliente.TabIndex = 1
        Me.btn_limpar_gb_cliente.Text = "LIMPAR"
        Me.btn_limpar_gb_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_limpar_gb_cliente.UseVisualStyleBackColor = False
        '
        'btn_cadastros_de_clientes
        '
        Me.btn_cadastros_de_clientes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_cadastros_de_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cadastros_de_clientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_cadastros_de_clientes.FlatAppearance.BorderSize = 5
        Me.btn_cadastros_de_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastros_de_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastros_de_clientes.Image = CType(resources.GetObject("btn_cadastros_de_clientes.Image"), System.Drawing.Image)
        Me.btn_cadastros_de_clientes.Location = New System.Drawing.Point(173, 97)
        Me.btn_cadastros_de_clientes.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_cadastros_de_clientes.Name = "btn_cadastros_de_clientes"
        Me.btn_cadastros_de_clientes.Size = New System.Drawing.Size(300, 50)
        Me.btn_cadastros_de_clientes.TabIndex = 98
        Me.btn_cadastros_de_clientes.TabStop = False
        Me.btn_cadastros_de_clientes.Text = "CADASTROS DE CLIENTES"
        Me.btn_cadastros_de_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cadastros_de_clientes.UseVisualStyleBackColor = False
        '
        'ts_pesquisar
        '
        Me.ts_pesquisar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_pesquisar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ts_pesquisar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_pesquisar_quem, Me.cmb_pesquisar_quem, Me.lbl_cmb_pesquisar, Me.cmb_pesquisar, Me.lbl_txt_pesquisar, Me.txt_pesquisar, Me.ToolStripSeparator1, Me.btn_salvar_topo})
        Me.ts_pesquisar.Location = New System.Drawing.Point(0, 0)
        Me.ts_pesquisar.Name = "ts_pesquisar"
        Me.ts_pesquisar.Size = New System.Drawing.Size(1466, 31)
        Me.ts_pesquisar.TabIndex = 0
        Me.ts_pesquisar.Text = "ToolStrip1"
        '
        'lbl_pesquisar_quem
        '
        Me.lbl_pesquisar_quem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pesquisar_quem.Name = "lbl_pesquisar_quem"
        Me.lbl_pesquisar_quem.Size = New System.Drawing.Size(76, 28)
        Me.lbl_pesquisar_quem.Text = "Pesquisar"
        '
        'cmb_pesquisar_quem
        '
        Me.cmb_pesquisar_quem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pesquisar_quem.Name = "cmb_pesquisar_quem"
        Me.cmb_pesquisar_quem.Size = New System.Drawing.Size(180, 31)
        '
        'lbl_cmb_pesquisar
        '
        Me.lbl_cmb_pesquisar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cmb_pesquisar.Name = "lbl_cmb_pesquisar"
        Me.lbl_cmb_pesquisar.Size = New System.Drawing.Size(33, 28)
        Me.lbl_cmb_pesquisar.Text = "por"
        '
        'cmb_pesquisar
        '
        Me.cmb_pesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pesquisar.Name = "cmb_pesquisar"
        Me.cmb_pesquisar.Size = New System.Drawing.Size(180, 31)
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
        Me.txt_pesquisar.Size = New System.Drawing.Size(150, 31)
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
        'gb_cliente
        '
        Me.gb_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gb_cliente.Controls.Add(Me.btn_cliente_limpar_campos)
        Me.gb_cliente.Controls.Add(Me.Label12)
        Me.gb_cliente.Controls.Add(Me.pb_foto_cliente)
        Me.gb_cliente.Controls.Add(Me.txt_cpf)
        Me.gb_cliente.Controls.Add(Me.txt_sobrenome)
        Me.gb_cliente.Controls.Add(Me.txt_nome)
        Me.gb_cliente.Controls.Add(Me.lbl_sobrenome)
        Me.gb_cliente.Controls.Add(Me.lbl_cpf)
        Me.gb_cliente.Controls.Add(Me.lbl_nome)
        Me.gb_cliente.Controls.Add(Me.txt_id)
        Me.gb_cliente.Controls.Add(Me.btn_cadastros_de_clientes)
        Me.gb_cliente.Controls.Add(Me.btn_limpar_gb_cliente)
        Me.gb_cliente.Controls.Add(Me.lbl_cliente)
        Me.gb_cliente.Controls.Add(Me.lbl_id)
        Me.gb_cliente.Location = New System.Drawing.Point(15, 81)
        Me.gb_cliente.Name = "gb_cliente"
        Me.gb_cliente.Size = New System.Drawing.Size(1435, 170)
        Me.gb_cliente.TabIndex = 13
        '
        'btn_cliente_limpar_campos
        '
        Me.btn_cliente_limpar_campos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_cliente_limpar_campos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cliente_limpar_campos.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_cliente_limpar_campos.FlatAppearance.BorderSize = 5
        Me.btn_cliente_limpar_campos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cliente_limpar_campos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cliente_limpar_campos.Image = CType(resources.GetObject("btn_cliente_limpar_campos.Image"), System.Drawing.Image)
        Me.btn_cliente_limpar_campos.Location = New System.Drawing.Point(791, 97)
        Me.btn_cliente_limpar_campos.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_cliente_limpar_campos.Name = "btn_cliente_limpar_campos"
        Me.btn_cliente_limpar_campos.Size = New System.Drawing.Size(179, 50)
        Me.btn_cliente_limpar_campos.TabIndex = 2
        Me.btn_cliente_limpar_campos.Text = "LIMPAR TUDO"
        Me.btn_cliente_limpar_campos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cliente_limpar_campos.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1215, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 103
        Me.Label12.Text = "FOTO:"
        '
        'pb_foto_cliente
        '
        Me.pb_foto_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_foto_cliente.InitialImage = CType(resources.GetObject("pb_foto_cliente.InitialImage"), System.Drawing.Image)
        Me.pb_foto_cliente.Location = New System.Drawing.Point(1268, 3)
        Me.pb_foto_cliente.Name = "pb_foto_cliente"
        Me.pb_foto_cliente.Size = New System.Drawing.Size(160, 160)
        Me.pb_foto_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto_cliente.TabIndex = 100
        Me.pb_foto_cliente.TabStop = False
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(263, 26)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.ReadOnly = True
        Me.txt_cpf.Size = New System.Drawing.Size(200, 26)
        Me.txt_cpf.TabIndex = 98
        Me.txt_cpf.TabStop = False
        '
        'txt_sobrenome
        '
        Me.txt_sobrenome.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_sobrenome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sobrenome.Location = New System.Drawing.Point(916, 26)
        Me.txt_sobrenome.MaxLength = 20
        Me.txt_sobrenome.Name = "txt_sobrenome"
        Me.txt_sobrenome.ReadOnly = True
        Me.txt_sobrenome.Size = New System.Drawing.Size(300, 26)
        Me.txt_sobrenome.TabIndex = 101
        Me.txt_sobrenome.TabStop = False
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(558, 26)
        Me.txt_nome.MaxLength = 20
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.ReadOnly = True
        Me.txt_nome.Size = New System.Drawing.Size(200, 26)
        Me.txt_nome.TabIndex = 100
        Me.txt_nome.TabStop = False
        '
        'lbl_sobrenome
        '
        Me.lbl_sobrenome.AutoSize = True
        Me.lbl_sobrenome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sobrenome.Location = New System.Drawing.Point(787, 29)
        Me.lbl_sobrenome.Name = "lbl_sobrenome"
        Me.lbl_sobrenome.Size = New System.Drawing.Size(123, 20)
        Me.lbl_sobrenome.TabIndex = 102
        Me.lbl_sobrenome.Text = "SOBRENOME:"
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(210, 29)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(47, 20)
        Me.lbl_cpf.TabIndex = 97
        Me.lbl_cpf.Text = "CPF:"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(488, 29)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(64, 20)
        Me.lbl_nome.TabIndex = 99
        Me.lbl_nome.Text = "NOME:"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(35, 26)
        Me.txt_id.MaxLength = 20
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(140, 26)
        Me.txt_id.TabIndex = 96
        Me.txt_id.TabStop = False
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.Location = New System.Drawing.Point(6, 0)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(153, 16)
        Me.lbl_cliente.TabIndex = 12
        Me.lbl_cliente.Text = "DADOS DO CLIENTE"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(6, 29)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(31, 20)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "ID:"
        '
        'janela_selecionar_foto
        '
        Me.janela_selecionar_foto.FileName = "janela_selecionar_foto"
        '
        'dgv_cadastros
        '
        Me.dgv_cadastros.AllowUserToAddRows = False
        Me.dgv_cadastros.AllowUserToDeleteRows = False
        Me.dgv_cadastros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_cadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cadastros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_numero, Me.col_cpf, Me.col_nome, Me.col_sobrenome, Me.col_ativo, Me.col_matricula, Me.col_tipo, Me.col_fabricante, Me.col_modelo, Me.col_assentos, Me.col_velocidade, Me.col_autonomia, Me.col_operacao, Me.col_regra, Me.col_diaria, Me.col_ativa})
        Me.dgv_cadastros.Location = New System.Drawing.Point(15, 678)
        Me.dgv_cadastros.Name = "dgv_cadastros"
        Me.dgv_cadastros.RowHeadersWidth = 51
        Me.dgv_cadastros.RowTemplate.Height = 26
        Me.dgv_cadastros.Size = New System.Drawing.Size(1435, 365)
        Me.dgv_cadastros.TabIndex = 10
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
        'col_cpf
        '
        Me.col_cpf.Frozen = True
        Me.col_cpf.HeaderText = "CPF"
        Me.col_cpf.MinimumWidth = 6
        Me.col_cpf.Name = "col_cpf"
        Me.col_cpf.ReadOnly = True
        Me.col_cpf.Width = 125
        '
        'col_nome
        '
        Me.col_nome.Frozen = True
        Me.col_nome.HeaderText = "NOME"
        Me.col_nome.MinimumWidth = 6
        Me.col_nome.Name = "col_nome"
        Me.col_nome.ReadOnly = True
        Me.col_nome.Width = 125
        '
        'col_sobrenome
        '
        Me.col_sobrenome.Frozen = True
        Me.col_sobrenome.HeaderText = "SOBRENOME"
        Me.col_sobrenome.MinimumWidth = 6
        Me.col_sobrenome.Name = "col_sobrenome"
        Me.col_sobrenome.ReadOnly = True
        Me.col_sobrenome.Width = 125
        '
        'col_ativo
        '
        Me.col_ativo.FalseValue = """n"""
        Me.col_ativo.Frozen = True
        Me.col_ativo.HeaderText = "ATIVO"
        Me.col_ativo.MinimumWidth = 6
        Me.col_ativo.Name = "col_ativo"
        Me.col_ativo.ReadOnly = True
        Me.col_ativo.TrueValue = """s"""
        Me.col_ativo.Width = 70
        '
        'col_matricula
        '
        Me.col_matricula.Frozen = True
        Me.col_matricula.HeaderText = "MATRÍCULA"
        Me.col_matricula.MinimumWidth = 6
        Me.col_matricula.Name = "col_matricula"
        Me.col_matricula.ReadOnly = True
        Me.col_matricula.Width = 80
        '
        'col_tipo
        '
        Me.col_tipo.Frozen = True
        Me.col_tipo.HeaderText = "TIPO"
        Me.col_tipo.MinimumWidth = 6
        Me.col_tipo.Name = "col_tipo"
        Me.col_tipo.ReadOnly = True
        Me.col_tipo.Width = 140
        '
        'col_fabricante
        '
        Me.col_fabricante.Frozen = True
        Me.col_fabricante.HeaderText = "FABRICANTE"
        Me.col_fabricante.MinimumWidth = 6
        Me.col_fabricante.Name = "col_fabricante"
        Me.col_fabricante.ReadOnly = True
        Me.col_fabricante.Width = 110
        '
        'col_modelo
        '
        Me.col_modelo.Frozen = True
        Me.col_modelo.HeaderText = "MODELO"
        Me.col_modelo.MinimumWidth = 6
        Me.col_modelo.Name = "col_modelo"
        Me.col_modelo.ReadOnly = True
        Me.col_modelo.Width = 80
        '
        'col_assentos
        '
        Me.col_assentos.Frozen = True
        Me.col_assentos.HeaderText = "ASSENTOS"
        Me.col_assentos.MinimumWidth = 6
        Me.col_assentos.Name = "col_assentos"
        Me.col_assentos.ReadOnly = True
        Me.col_assentos.Width = 70
        '
        'col_velocidade
        '
        Me.col_velocidade.Frozen = True
        Me.col_velocidade.HeaderText = "VELOCIDADE"
        Me.col_velocidade.MinimumWidth = 6
        Me.col_velocidade.Name = "col_velocidade"
        Me.col_velocidade.ReadOnly = True
        Me.col_velocidade.Width = 80
        '
        'col_autonomia
        '
        Me.col_autonomia.Frozen = True
        Me.col_autonomia.HeaderText = "AUTONOMIA"
        Me.col_autonomia.MinimumWidth = 6
        Me.col_autonomia.Name = "col_autonomia"
        Me.col_autonomia.ReadOnly = True
        Me.col_autonomia.Width = 80
        '
        'col_operacao
        '
        Me.col_operacao.Frozen = True
        Me.col_operacao.HeaderText = "OPERAÇÃO"
        Me.col_operacao.MinimumWidth = 6
        Me.col_operacao.Name = "col_operacao"
        Me.col_operacao.ReadOnly = True
        Me.col_operacao.Width = 80
        '
        'col_regra
        '
        Me.col_regra.Frozen = True
        Me.col_regra.HeaderText = "REGRA"
        Me.col_regra.MinimumWidth = 6
        Me.col_regra.Name = "col_regra"
        Me.col_regra.ReadOnly = True
        Me.col_regra.Width = 145
        '
        'col_diaria
        '
        Me.col_diaria.Frozen = True
        Me.col_diaria.HeaderText = "DIÁRIA"
        Me.col_diaria.MinimumWidth = 6
        Me.col_diaria.Name = "col_diaria"
        Me.col_diaria.ReadOnly = True
        Me.col_diaria.Width = 50
        '
        'col_ativa
        '
        Me.col_ativa.FalseValue = """n"""
        Me.col_ativa.Frozen = True
        Me.col_ativa.HeaderText = "ATIVA"
        Me.col_ativa.MinimumWidth = 6
        Me.col_ativa.Name = "col_ativa"
        Me.col_ativa.ReadOnly = True
        Me.col_ativa.TrueValue = """s"""
        Me.col_ativa.Width = 70
        '
        'gb_aeronave
        '
        Me.gb_aeronave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gb_aeronave.Controls.Add(Me.btn_cadastros_de_aeronaves)
        Me.gb_aeronave.Controls.Add(Me.btn_aeronave_limpar_campos)
        Me.gb_aeronave.Controls.Add(Me.lbl_foto)
        Me.gb_aeronave.Controls.Add(Me.txt_diaria)
        Me.gb_aeronave.Controls.Add(Me.txt_operacao)
        Me.gb_aeronave.Controls.Add(Me.txt_regra)
        Me.gb_aeronave.Controls.Add(Me.txt_autonomia)
        Me.gb_aeronave.Controls.Add(Me.txt_assentos)
        Me.gb_aeronave.Controls.Add(Me.txt_velocidade)
        Me.gb_aeronave.Controls.Add(Me.txt_pesomin)
        Me.gb_aeronave.Controls.Add(Me.txt_pesomax)
        Me.gb_aeronave.Controls.Add(Me.txt_ano)
        Me.gb_aeronave.Controls.Add(Me.txt_combustivel)
        Me.gb_aeronave.Controls.Add(Me.txt_tipo)
        Me.gb_aeronave.Controls.Add(Me.lbl_ano)
        Me.gb_aeronave.Controls.Add(Me.txt_matricula)
        Me.gb_aeronave.Controls.Add(Me.lbl_diaria_rs)
        Me.gb_aeronave.Controls.Add(Me.txt_fabricante)
        Me.gb_aeronave.Controls.Add(Me.lbl_autonomia_km)
        Me.gb_aeronave.Controls.Add(Me.txt_modelo)
        Me.gb_aeronave.Controls.Add(Me.lbl_velocidade_kmh)
        Me.gb_aeronave.Controls.Add(Me.lbl_pesomax_kg)
        Me.gb_aeronave.Controls.Add(Me.lbl_pesomin_kg)
        Me.gb_aeronave.Controls.Add(Me.pb_foto_aeronave)
        Me.gb_aeronave.Controls.Add(Me.lbl_combustivel)
        Me.gb_aeronave.Controls.Add(Me.lbl_modelo)
        Me.gb_aeronave.Controls.Add(Me.btn_limpar_gb_aeronave)
        Me.gb_aeronave.Controls.Add(Me.lbl_fabricante)
        Me.gb_aeronave.Controls.Add(Me.lbl_tipo)
        Me.gb_aeronave.Controls.Add(Me.lbl_diaria)
        Me.gb_aeronave.Controls.Add(Me.lbl_matricula)
        Me.gb_aeronave.Controls.Add(Me.lbl_autonomia)
        Me.gb_aeronave.Controls.Add(Me.lbl_velocidade)
        Me.gb_aeronave.Controls.Add(Me.lbl_pesomax)
        Me.gb_aeronave.Controls.Add(Me.lbl_regra)
        Me.gb_aeronave.Controls.Add(Me.lbl_operacao)
        Me.gb_aeronave.Controls.Add(Me.lbl_aeronave)
        Me.gb_aeronave.Controls.Add(Me.lbl_pesomin)
        Me.gb_aeronave.Controls.Add(Me.lbl_assentos)
        Me.gb_aeronave.Location = New System.Drawing.Point(15, 257)
        Me.gb_aeronave.Name = "gb_aeronave"
        Me.gb_aeronave.Size = New System.Drawing.Size(1435, 322)
        Me.gb_aeronave.TabIndex = 49
        '
        'btn_cadastros_de_aeronaves
        '
        Me.btn_cadastros_de_aeronaves.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_cadastros_de_aeronaves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cadastros_de_aeronaves.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_cadastros_de_aeronaves.FlatAppearance.BorderSize = 5
        Me.btn_cadastros_de_aeronaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastros_de_aeronaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastros_de_aeronaves.Image = CType(resources.GetObject("btn_cadastros_de_aeronaves.Image"), System.Drawing.Image)
        Me.btn_cadastros_de_aeronaves.Location = New System.Drawing.Point(173, 264)
        Me.btn_cadastros_de_aeronaves.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_cadastros_de_aeronaves.Name = "btn_cadastros_de_aeronaves"
        Me.btn_cadastros_de_aeronaves.Size = New System.Drawing.Size(300, 50)
        Me.btn_cadastros_de_aeronaves.TabIndex = 99
        Me.btn_cadastros_de_aeronaves.TabStop = False
        Me.btn_cadastros_de_aeronaves.Text = "CADASTROS DE AERONAVES"
        Me.btn_cadastros_de_aeronaves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cadastros_de_aeronaves.UseVisualStyleBackColor = False
        '
        'btn_aeronave_limpar_campos
        '
        Me.btn_aeronave_limpar_campos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_aeronave_limpar_campos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_aeronave_limpar_campos.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_aeronave_limpar_campos.FlatAppearance.BorderSize = 5
        Me.btn_aeronave_limpar_campos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aeronave_limpar_campos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aeronave_limpar_campos.Image = CType(resources.GetObject("btn_aeronave_limpar_campos.Image"), System.Drawing.Image)
        Me.btn_aeronave_limpar_campos.Location = New System.Drawing.Point(791, 264)
        Me.btn_aeronave_limpar_campos.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_aeronave_limpar_campos.Name = "btn_aeronave_limpar_campos"
        Me.btn_aeronave_limpar_campos.Size = New System.Drawing.Size(179, 50)
        Me.btn_aeronave_limpar_campos.TabIndex = 4
        Me.btn_aeronave_limpar_campos.Text = "LIMPAR TUDO"
        Me.btn_aeronave_limpar_campos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_aeronave_limpar_campos.UseVisualStyleBackColor = False
        '
        'txt_diaria
        '
        Me.txt_diaria.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_diaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_diaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_diaria.Location = New System.Drawing.Point(428, 225)
        Me.txt_diaria.MaxLength = 30
        Me.txt_diaria.Name = "txt_diaria"
        Me.txt_diaria.ReadOnly = True
        Me.txt_diaria.Size = New System.Drawing.Size(80, 22)
        Me.txt_diaria.TabIndex = 114
        Me.txt_diaria.TabStop = False
        '
        'txt_operacao
        '
        Me.txt_operacao.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_operacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_operacao.Location = New System.Drawing.Point(791, 166)
        Me.txt_operacao.MaxLength = 30
        Me.txt_operacao.Name = "txt_operacao"
        Me.txt_operacao.ReadOnly = True
        Me.txt_operacao.Size = New System.Drawing.Size(120, 22)
        Me.txt_operacao.TabIndex = 113
        Me.txt_operacao.TabStop = False
        '
        'txt_regra
        '
        Me.txt_regra.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_regra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_regra.Location = New System.Drawing.Point(9, 225)
        Me.txt_regra.MaxLength = 30
        Me.txt_regra.Name = "txt_regra"
        Me.txt_regra.ReadOnly = True
        Me.txt_regra.Size = New System.Drawing.Size(340, 22)
        Me.txt_regra.TabIndex = 112
        Me.txt_regra.TabStop = False
        '
        'txt_autonomia
        '
        Me.txt_autonomia.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_autonomia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_autonomia.Location = New System.Drawing.Point(625, 166)
        Me.txt_autonomia.MaxLength = 30
        Me.txt_autonomia.Name = "txt_autonomia"
        Me.txt_autonomia.ReadOnly = True
        Me.txt_autonomia.Size = New System.Drawing.Size(70, 22)
        Me.txt_autonomia.TabIndex = 111
        Me.txt_autonomia.TabStop = False
        '
        'txt_assentos
        '
        Me.txt_assentos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_assentos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_assentos.Location = New System.Drawing.Point(9, 166)
        Me.txt_assentos.MaxLength = 30
        Me.txt_assentos.Name = "txt_assentos"
        Me.txt_assentos.ReadOnly = True
        Me.txt_assentos.Size = New System.Drawing.Size(70, 22)
        Me.txt_assentos.TabIndex = 110
        Me.txt_assentos.TabStop = False
        '
        'txt_velocidade
        '
        Me.txt_velocidade.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_velocidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_velocidade.Location = New System.Drawing.Point(445, 166)
        Me.txt_velocidade.MaxLength = 30
        Me.txt_velocidade.Name = "txt_velocidade"
        Me.txt_velocidade.ReadOnly = True
        Me.txt_velocidade.Size = New System.Drawing.Size(70, 22)
        Me.txt_velocidade.TabIndex = 109
        Me.txt_velocidade.TabStop = False
        '
        'txt_pesomin
        '
        Me.txt_pesomin.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_pesomin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pesomin.Location = New System.Drawing.Point(110, 166)
        Me.txt_pesomin.MaxLength = 30
        Me.txt_pesomin.Name = "txt_pesomin"
        Me.txt_pesomin.ReadOnly = True
        Me.txt_pesomin.Size = New System.Drawing.Size(70, 22)
        Me.txt_pesomin.TabIndex = 108
        Me.txt_pesomin.TabStop = False
        '
        'txt_pesomax
        '
        Me.txt_pesomax.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_pesomax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pesomax.Location = New System.Drawing.Point(267, 166)
        Me.txt_pesomax.MaxLength = 30
        Me.txt_pesomax.Name = "txt_pesomax"
        Me.txt_pesomax.ReadOnly = True
        Me.txt_pesomax.Size = New System.Drawing.Size(70, 22)
        Me.txt_pesomax.TabIndex = 107
        Me.txt_pesomax.TabStop = False
        '
        'txt_ano
        '
        Me.txt_ano.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_ano.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ano.Location = New System.Drawing.Point(809, 107)
        Me.txt_ano.MaxLength = 30
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.ReadOnly = True
        Me.txt_ano.Size = New System.Drawing.Size(100, 22)
        Me.txt_ano.TabIndex = 106
        Me.txt_ano.TabStop = False
        '
        'txt_combustivel
        '
        Me.txt_combustivel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_combustivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_combustivel.Location = New System.Drawing.Point(428, 107)
        Me.txt_combustivel.MaxLength = 30
        Me.txt_combustivel.Name = "txt_combustivel"
        Me.txt_combustivel.ReadOnly = True
        Me.txt_combustivel.Size = New System.Drawing.Size(360, 22)
        Me.txt_combustivel.TabIndex = 105
        Me.txt_combustivel.TabStop = False
        '
        'txt_tipo
        '
        Me.txt_tipo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_tipo.Location = New System.Drawing.Point(119, 48)
        Me.txt_tipo.MaxLength = 20
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.ReadOnly = True
        Me.txt_tipo.Size = New System.Drawing.Size(324, 22)
        Me.txt_tipo.TabIndex = 104
        Me.txt_tipo.TabStop = False
        '
        'txt_matricula
        '
        Me.txt_matricula.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matricula.Location = New System.Drawing.Point(9, 46)
        Me.txt_matricula.Mask = ">LL\-LLL"
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.ReadOnly = True
        Me.txt_matricula.Size = New System.Drawing.Size(90, 24)
        Me.txt_matricula.TabIndex = 1
        Me.txt_matricula.TabStop = False
        '
        'lbl_diaria_rs
        '
        Me.lbl_diaria_rs.AutoSize = True
        Me.lbl_diaria_rs.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_diaria_rs.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diaria_rs.Location = New System.Drawing.Point(393, 228)
        Me.lbl_diaria_rs.Name = "lbl_diaria_rs"
        Me.lbl_diaria_rs.Size = New System.Drawing.Size(30, 16)
        Me.lbl_diaria_rs.TabIndex = 48
        Me.lbl_diaria_rs.Text = "R$ "
        '
        'lbl_autonomia_km
        '
        Me.lbl_autonomia_km.AutoSize = True
        Me.lbl_autonomia_km.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_autonomia_km.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_autonomia_km.Location = New System.Drawing.Point(701, 169)
        Me.lbl_autonomia_km.Name = "lbl_autonomia_km"
        Me.lbl_autonomia_km.Size = New System.Drawing.Size(25, 16)
        Me.lbl_autonomia_km.TabIndex = 47
        Me.lbl_autonomia_km.Text = "km"
        '
        'txt_modelo
        '
        Me.txt_modelo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_modelo.Location = New System.Drawing.Point(9, 107)
        Me.txt_modelo.MaxLength = 30
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.ReadOnly = True
        Me.txt_modelo.Size = New System.Drawing.Size(398, 22)
        Me.txt_modelo.TabIndex = 4
        Me.txt_modelo.TabStop = False
        '
        'lbl_velocidade_kmh
        '
        Me.lbl_velocidade_kmh.AutoSize = True
        Me.lbl_velocidade_kmh.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_velocidade_kmh.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_velocidade_kmh.Location = New System.Drawing.Point(521, 169)
        Me.lbl_velocidade_kmh.Name = "lbl_velocidade_kmh"
        Me.lbl_velocidade_kmh.Size = New System.Drawing.Size(36, 16)
        Me.lbl_velocidade_kmh.TabIndex = 46
        Me.lbl_velocidade_kmh.Text = "km/h"
        '
        'lbl_pesomax_kg
        '
        Me.lbl_pesomax_kg.AutoSize = True
        Me.lbl_pesomax_kg.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_pesomax_kg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pesomax_kg.Location = New System.Drawing.Point(343, 169)
        Me.lbl_pesomax_kg.Name = "lbl_pesomax_kg"
        Me.lbl_pesomax_kg.Size = New System.Drawing.Size(22, 16)
        Me.lbl_pesomax_kg.TabIndex = 45
        Me.lbl_pesomax_kg.Text = "kg"
        '
        'lbl_pesomin_kg
        '
        Me.lbl_pesomin_kg.AutoSize = True
        Me.lbl_pesomin_kg.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_pesomin_kg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pesomin_kg.Location = New System.Drawing.Point(186, 169)
        Me.lbl_pesomin_kg.Name = "lbl_pesomin_kg"
        Me.lbl_pesomin_kg.Size = New System.Drawing.Size(22, 16)
        Me.lbl_pesomin_kg.TabIndex = 44
        Me.lbl_pesomin_kg.Text = "kg"
        '
        'btn_limpar_gb_aeronave
        '
        Me.btn_limpar_gb_aeronave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_limpar_gb_aeronave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_limpar_gb_aeronave.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_limpar_gb_aeronave.FlatAppearance.BorderSize = 5
        Me.btn_limpar_gb_aeronave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpar_gb_aeronave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar_gb_aeronave.Image = CType(resources.GetObject("btn_limpar_gb_aeronave.Image"), System.Drawing.Image)
        Me.btn_limpar_gb_aeronave.Location = New System.Drawing.Point(10, 264)
        Me.btn_limpar_gb_aeronave.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_limpar_gb_aeronave.Name = "btn_limpar_gb_aeronave"
        Me.btn_limpar_gb_aeronave.Size = New System.Drawing.Size(150, 50)
        Me.btn_limpar_gb_aeronave.TabIndex = 3
        Me.btn_limpar_gb_aeronave.Text = "LIMPAR"
        Me.btn_limpar_gb_aeronave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_limpar_gb_aeronave.UseVisualStyleBackColor = False
        '
        'lbl_diaria
        '
        Me.lbl_diaria.AutoSize = True
        Me.lbl_diaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diaria.Location = New System.Drawing.Point(389, 206)
        Me.lbl_diaria.Name = "lbl_diaria"
        Me.lbl_diaria.Size = New System.Drawing.Size(142, 16)
        Me.lbl_diaria.TabIndex = 0
        Me.lbl_diaria.Text = "PREÇO DA DIÁRIA:"
        '
        'lbl_autonomia
        '
        Me.lbl_autonomia.AutoSize = True
        Me.lbl_autonomia.Location = New System.Drawing.Point(622, 147)
        Me.lbl_autonomia.Name = "lbl_autonomia"
        Me.lbl_autonomia.Size = New System.Drawing.Size(145, 16)
        Me.lbl_autonomia.TabIndex = 42
        Me.lbl_autonomia.Text = "AUTONOMIA MÁXIMA:"
        '
        'lbl_velocidade
        '
        Me.lbl_velocidade.AutoSize = True
        Me.lbl_velocidade.Location = New System.Drawing.Point(442, 147)
        Me.lbl_velocidade.Name = "lbl_velocidade"
        Me.lbl_velocidade.Size = New System.Drawing.Size(149, 16)
        Me.lbl_velocidade.TabIndex = 41
        Me.lbl_velocidade.Text = "VELOCIDADE MÁXIMA:"
        '
        'lbl_pesomax
        '
        Me.lbl_pesomax.AutoSize = True
        Me.lbl_pesomax.Location = New System.Drawing.Point(264, 147)
        Me.lbl_pesomax.Name = "lbl_pesomax"
        Me.lbl_pesomax.Size = New System.Drawing.Size(156, 16)
        Me.lbl_pesomax.TabIndex = 39
        Me.lbl_pesomax.Text = "MTOW (PESO MÁXIMO):"
        '
        'lbl_regra
        '
        Me.lbl_regra.AutoSize = True
        Me.lbl_regra.Location = New System.Drawing.Point(6, 206)
        Me.lbl_regra.Name = "lbl_regra"
        Me.lbl_regra.Size = New System.Drawing.Size(112, 16)
        Me.lbl_regra.TabIndex = 31
        Me.lbl_regra.Text = "REGRA DE VOO:"
        '
        'lbl_operacao
        '
        Me.lbl_operacao.AutoSize = True
        Me.lbl_operacao.Location = New System.Drawing.Point(788, 147)
        Me.lbl_operacao.Name = "lbl_operacao"
        Me.lbl_operacao.Size = New System.Drawing.Size(85, 16)
        Me.lbl_operacao.TabIndex = 29
        Me.lbl_operacao.Text = "OPERAÇÃO:"
        '
        'lbl_aeronave
        '
        Me.lbl_aeronave.AutoSize = True
        Me.lbl_aeronave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aeronave.Location = New System.Drawing.Point(6, 0)
        Me.lbl_aeronave.Name = "lbl_aeronave"
        Me.lbl_aeronave.Size = New System.Drawing.Size(172, 16)
        Me.lbl_aeronave.TabIndex = 12
        Me.lbl_aeronave.Text = "DADOS DA AERONAVE"
        '
        'lbl_pesomin
        '
        Me.lbl_pesomin.AutoSize = True
        Me.lbl_pesomin.Location = New System.Drawing.Point(108, 147)
        Me.lbl_pesomin.Name = "lbl_pesomin"
        Me.lbl_pesomin.Size = New System.Drawing.Size(141, 16)
        Me.lbl_pesomin.TabIndex = 11
        Me.lbl_pesomin.Text = "BOW (PESO MÍNIMO):"
        '
        'lbl_assentos
        '
        Me.lbl_assentos.AutoSize = True
        Me.lbl_assentos.Location = New System.Drawing.Point(6, 147)
        Me.lbl_assentos.Name = "lbl_assentos"
        Me.lbl_assentos.Size = New System.Drawing.Size(84, 16)
        Me.lbl_assentos.TabIndex = 0
        Me.lbl_assentos.Text = "ASSENTOS:"
        '
        'gb_financeiro
        '
        Me.gb_financeiro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gb_financeiro.Controls.Add(Me.btn_calcular_diarias)
        Me.gb_financeiro.Controls.Add(Me.txt_diarias)
        Me.gb_financeiro.Controls.Add(Me.lbl_diarias)
        Me.gb_financeiro.Controls.Add(Me.txt_total)
        Me.gb_financeiro.Controls.Add(Me.lbl_total_rs)
        Me.gb_financeiro.Controls.Add(Me.dtp_fim)
        Me.gb_financeiro.Controls.Add(Me.dtp_inicio)
        Me.gb_financeiro.Controls.Add(Me.ckb_pago)
        Me.gb_financeiro.Controls.Add(Me.btn_gerar_contrato)
        Me.gb_financeiro.Controls.Add(Me.lbl_total)
        Me.gb_financeiro.Controls.Add(Me.lbl_fim)
        Me.gb_financeiro.Controls.Add(Me.lbl_financeiro)
        Me.gb_financeiro.Controls.Add(Me.lbl_inicio)
        Me.gb_financeiro.Location = New System.Drawing.Point(15, 585)
        Me.gb_financeiro.Name = "gb_financeiro"
        Me.gb_financeiro.Size = New System.Drawing.Size(1435, 87)
        Me.gb_financeiro.TabIndex = 105
        '
        'btn_calcular_diarias
        '
        Me.btn_calcular_diarias.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_calcular_diarias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_calcular_diarias.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_calcular_diarias.FlatAppearance.BorderSize = 5
        Me.btn_calcular_diarias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calcular_diarias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular_diarias.Image = CType(resources.GetObject("btn_calcular_diarias.Image"), System.Drawing.Image)
        Me.btn_calcular_diarias.Location = New System.Drawing.Point(452, 24)
        Me.btn_calcular_diarias.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_calcular_diarias.Name = "btn_calcular_diarias"
        Me.btn_calcular_diarias.Size = New System.Drawing.Size(230, 50)
        Me.btn_calcular_diarias.TabIndex = 7
        Me.btn_calcular_diarias.Text = " CALCULAR DIÁRIAS"
        Me.btn_calcular_diarias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_calcular_diarias.UseVisualStyleBackColor = False
        '
        'txt_diarias
        '
        Me.txt_diarias.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_diarias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_diarias.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_diarias.Location = New System.Drawing.Point(730, 52)
        Me.txt_diarias.MaxLength = 30
        Me.txt_diarias.Name = "txt_diarias"
        Me.txt_diarias.ReadOnly = True
        Me.txt_diarias.Size = New System.Drawing.Size(102, 22)
        Me.txt_diarias.TabIndex = 119
        Me.txt_diarias.TabStop = False
        '
        'lbl_diarias
        '
        Me.lbl_diarias.AutoSize = True
        Me.lbl_diarias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diarias.Location = New System.Drawing.Point(727, 28)
        Me.lbl_diarias.Name = "lbl_diarias"
        Me.lbl_diarias.Size = New System.Drawing.Size(68, 17)
        Me.lbl_diarias.TabIndex = 100
        Me.lbl_diarias.Text = "DIÁRIAS"
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(892, 52)
        Me.txt_total.MaxLength = 30
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(160, 22)
        Me.txt_total.TabIndex = 116
        Me.txt_total.TabStop = False
        '
        'lbl_total_rs
        '
        Me.lbl_total_rs.AutoSize = True
        Me.lbl_total_rs.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_total_rs.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_rs.Location = New System.Drawing.Point(856, 55)
        Me.lbl_total_rs.Name = "lbl_total_rs"
        Me.lbl_total_rs.Size = New System.Drawing.Size(30, 16)
        Me.lbl_total_rs.TabIndex = 115
        Me.lbl_total_rs.Text = "R$ "
        '
        'dtp_fim
        '
        Me.dtp_fim.Checked = False
        Me.dtp_fim.CustomFormat = ""
        Me.dtp_fim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fim.Location = New System.Drawing.Point(239, 50)
        Me.dtp_fim.MinDate = New Date(2024, 11, 11, 0, 0, 0, 0)
        Me.dtp_fim.Name = "dtp_fim"
        Me.dtp_fim.Size = New System.Drawing.Size(145, 22)
        Me.dtp_fim.TabIndex = 6
        Me.dtp_fim.Value = New Date(2024, 11, 23, 21, 53, 57, 0)
        '
        'dtp_inicio
        '
        Me.dtp_inicio.Checked = False
        Me.dtp_inicio.CustomFormat = ""
        Me.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_inicio.Location = New System.Drawing.Point(10, 50)
        Me.dtp_inicio.MinDate = New Date(2024, 11, 11, 0, 0, 0, 0)
        Me.dtp_inicio.Name = "dtp_inicio"
        Me.dtp_inicio.Size = New System.Drawing.Size(145, 22)
        Me.dtp_inicio.TabIndex = 5
        Me.dtp_inicio.Value = New Date(2024, 11, 23, 0, 0, 0, 0)
        '
        'ckb_pago
        '
        Me.ckb_pago.AutoSize = True
        Me.ckb_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckb_pago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckb_pago.Location = New System.Drawing.Point(1058, 53)
        Me.ckb_pago.Name = "ckb_pago"
        Me.ckb_pago.Size = New System.Drawing.Size(80, 21)
        Me.ckb_pago.TabIndex = 8
        Me.ckb_pago.Text = "*PAGO"
        Me.ckb_pago.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ckb_pago.UseVisualStyleBackColor = True
        '
        'btn_gerar_contrato
        '
        Me.btn_gerar_contrato.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_gerar_contrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_gerar_contrato.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_gerar_contrato.FlatAppearance.BorderSize = 5
        Me.btn_gerar_contrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gerar_contrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerar_contrato.Image = CType(resources.GetObject("btn_gerar_contrato.Image"), System.Drawing.Image)
        Me.btn_gerar_contrato.Location = New System.Drawing.Point(1179, 14)
        Me.btn_gerar_contrato.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_gerar_contrato.Name = "btn_gerar_contrato"
        Me.btn_gerar_contrato.Size = New System.Drawing.Size(240, 60)
        Me.btn_gerar_contrato.TabIndex = 9
        Me.btn_gerar_contrato.Text = "   GERAR CONTRATO"
        Me.btn_gerar_contrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_gerar_contrato.UseVisualStyleBackColor = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(852, 28)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(132, 17)
        Me.lbl_total.TabIndex = 102
        Me.lbl_total.Text = "TOTAL A PAGAR"
        '
        'lbl_fim
        '
        Me.lbl_fim.AutoSize = True
        Me.lbl_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fim.Location = New System.Drawing.Point(236, 28)
        Me.lbl_fim.Name = "lbl_fim"
        Me.lbl_fim.Size = New System.Drawing.Size(184, 17)
        Me.lbl_fim.TabIndex = 99
        Me.lbl_fim.Text = "*ÚLTIMO DIA DA LOCAÇÃO"
        '
        'lbl_financeiro
        '
        Me.lbl_financeiro.AutoSize = True
        Me.lbl_financeiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_financeiro.Location = New System.Drawing.Point(6, 0)
        Me.lbl_financeiro.Name = "lbl_financeiro"
        Me.lbl_financeiro.Size = New System.Drawing.Size(165, 16)
        Me.lbl_financeiro.TabIndex = 12
        Me.lbl_financeiro.Text = "DADOS FINANCEIROS"
        '
        'lbl_inicio
        '
        Me.lbl_inicio.AutoSize = True
        Me.lbl_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inicio.Location = New System.Drawing.Point(6, 28)
        Me.lbl_inicio.Name = "lbl_inicio"
        Me.lbl_inicio.Size = New System.Drawing.Size(198, 17)
        Me.lbl_inicio.TabIndex = 0
        Me.lbl_inicio.Text = "*PRIMEIRO DIA DA LOCAÇÃO"
        '
        'frm_cad_contrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1466, 1055)
        Me.Controls.Add(Me.gb_financeiro)
        Me.Controls.Add(Me.gb_aeronave)
        Me.Controls.Add(Me.dgv_cadastros)
        Me.Controls.Add(Me.gb_cliente)
        Me.Controls.Add(Me.ts_pesquisar)
        Me.Controls.Add(Me.lbl_usuario_e_data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(24, 24)
        Me.Name = "frm_cad_contrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CADASTRO DE CONTRATOS"
        CType(Me.pb_foto_aeronave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_pesquisar.ResumeLayout(False)
        Me.ts_pesquisar.PerformLayout()
        Me.gb_cliente.ResumeLayout(False)
        Me.gb_cliente.PerformLayout()
        CType(Me.pb_foto_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_cadastros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_aeronave.ResumeLayout(False)
        Me.gb_aeronave.PerformLayout()
        Me.gb_financeiro.ResumeLayout(False)
        Me.gb_financeiro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_usuario_e_data As Label
    Friend WithEvents btn_limpar_gb_cliente As Button
    Friend WithEvents ts_pesquisar As ToolStrip
    Friend WithEvents btn_salvar_topo As ToolStripButton
    Friend WithEvents lbl_txt_pesquisar As ToolStripLabel
    Friend WithEvents txt_pesquisar As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lbl_cmb_pesquisar As ToolStripLabel
    Friend WithEvents cmb_pesquisar As ToolStripComboBox
    Friend WithEvents pb_foto_aeronave As PictureBox
    Friend WithEvents gb_cliente As Panel
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents janela_selecionar_foto As OpenFileDialog
    Friend WithEvents btn_cadastros_de_clientes As Button
    Friend WithEvents dgv_cadastros As DataGridView
    Friend WithEvents lbl_matricula As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents lbl_foto As Label
    Friend WithEvents lbl_fabricante As Label
    Friend WithEvents txt_fabricante As TextBox
    Friend WithEvents lbl_modelo As Label
    Friend WithEvents lbl_combustivel As Label
    Friend WithEvents lbl_ano As Label
    Friend WithEvents cmb_pesquisar_quem As ToolStripComboBox
    Friend WithEvents lbl_pesquisar_quem As ToolStripLabel
    Friend WithEvents gb_aeronave As Panel
    Friend WithEvents lbl_diaria_rs As Label
    Friend WithEvents lbl_autonomia_km As Label
    Friend WithEvents lbl_velocidade_kmh As Label
    Friend WithEvents lbl_pesomax_kg As Label
    Friend WithEvents lbl_pesomin_kg As Label
    Friend WithEvents btn_limpar_gb_aeronave As Button
    Friend WithEvents lbl_diaria As Label
    Friend WithEvents lbl_autonomia As Label
    Friend WithEvents lbl_velocidade As Label
    Friend WithEvents lbl_pesomax As Label
    Friend WithEvents lbl_regra As Label
    Friend WithEvents lbl_operacao As Label
    Friend WithEvents lbl_aeronave As Label
    Friend WithEvents lbl_pesomin As Label
    Friend WithEvents lbl_assentos As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_sobrenome As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_sobrenome As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents pb_foto_cliente As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents txt_matricula As MaskedTextBox
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents txt_combustivel As TextBox
    Friend WithEvents txt_pesomax As TextBox
    Friend WithEvents txt_ano As TextBox
    Friend WithEvents txt_pesomin As TextBox
    Friend WithEvents txt_autonomia As TextBox
    Friend WithEvents txt_assentos As TextBox
    Friend WithEvents txt_velocidade As TextBox
    Friend WithEvents txt_operacao As TextBox
    Friend WithEvents txt_regra As TextBox
    Friend WithEvents txt_diaria As TextBox
    Friend WithEvents col_numero As DataGridViewTextBoxColumn
    Friend WithEvents col_cpf As DataGridViewTextBoxColumn
    Friend WithEvents col_nome As DataGridViewTextBoxColumn
    Friend WithEvents col_sobrenome As DataGridViewTextBoxColumn
    Friend WithEvents col_ativo As DataGridViewCheckBoxColumn
    Friend WithEvents col_matricula As DataGridViewTextBoxColumn
    Friend WithEvents col_tipo As DataGridViewTextBoxColumn
    Friend WithEvents col_fabricante As DataGridViewTextBoxColumn
    Friend WithEvents col_modelo As DataGridViewTextBoxColumn
    Friend WithEvents col_assentos As DataGridViewTextBoxColumn
    Friend WithEvents col_velocidade As DataGridViewTextBoxColumn
    Friend WithEvents col_autonomia As DataGridViewTextBoxColumn
    Friend WithEvents col_operacao As DataGridViewTextBoxColumn
    Friend WithEvents col_regra As DataGridViewTextBoxColumn
    Friend WithEvents col_diaria As DataGridViewTextBoxColumn
    Friend WithEvents col_ativa As DataGridViewCheckBoxColumn
    Friend WithEvents btn_cliente_limpar_campos As Button
    Friend WithEvents btn_aeronave_limpar_campos As Button
    Friend WithEvents gb_financeiro As Panel
    Friend WithEvents btn_gerar_contrato As Button
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_fim As Label
    Friend WithEvents lbl_financeiro As Label
    Friend WithEvents lbl_inicio As Label
    Friend WithEvents dtp_inicio As DateTimePicker
    Friend WithEvents dtp_fim As DateTimePicker
    Friend WithEvents txt_total As TextBox
    Friend WithEvents lbl_total_rs As Label
    Friend WithEvents ckb_pago As CheckBox
    Friend WithEvents txt_diarias As TextBox
    Friend WithEvents lbl_diarias As Label
    Friend WithEvents btn_calcular_diarias As Button
    Friend WithEvents btn_cadastros_de_aeronaves As Button
End Class
