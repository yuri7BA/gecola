<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cad_aeronave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_aeronave))
        Me.lbl_usuario_e_data = New System.Windows.Forms.Label()
        Me.gb_identificacao = New System.Windows.Forms.Panel()
        Me.txt_matricula = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.txt_fabricante = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.cmb_combustivel = New System.Windows.Forms.ComboBox()
        Me.txt_ano = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_foto = New System.Windows.Forms.Label()
        Me.pb_foto = New System.Windows.Forms.PictureBox()
        Me.lbl_ano = New System.Windows.Forms.Label()
        Me.lbl_combustivel = New System.Windows.Forms.Label()
        Me.lbl_modelo = New System.Windows.Forms.Label()
        Me.lbl_fabricante = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_identificacao = New System.Windows.Forms.Label()
        Me.cmb_operacao = New System.Windows.Forms.ComboBox()
        Me.cmb_regra = New System.Windows.Forms.ComboBox()
        Me.lbl_regra = New System.Windows.Forms.Label()
        Me.lbl_operacao = New System.Windows.Forms.Label()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_salvar_base = New System.Windows.Forms.Button()
        Me.ts_pesquisar = New System.Windows.Forms.ToolStrip()
        Me.lbl_cmb_pesquisar = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_pesquisar = New System.Windows.Forms.ToolStripComboBox()
        Me.lbl_txt_pesquisar = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_salvar_topo = New System.Windows.Forms.ToolStripButton()
        Me.gb_capacidade = New System.Windows.Forms.Panel()
        Me.lbl_diaria_rs = New System.Windows.Forms.Label()
        Me.txt_diaria = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_autonomia_km = New System.Windows.Forms.Label()
        Me.lbl_velocidade_kmh = New System.Windows.Forms.Label()
        Me.lbl_pesomax_kg = New System.Windows.Forms.Label()
        Me.lbl_pesomin_kg = New System.Windows.Forms.Label()
        Me.lbl_diaria = New System.Windows.Forms.Label()
        Me.txt_autonomia = New System.Windows.Forms.MaskedTextBox()
        Me.txt_velocidade = New System.Windows.Forms.MaskedTextBox()
        Me.txt_pesomax = New System.Windows.Forms.MaskedTextBox()
        Me.txt_pesomin = New System.Windows.Forms.MaskedTextBox()
        Me.txt_assentos = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_autonomia = New System.Windows.Forms.Label()
        Me.lbl_velocidade = New System.Windows.Forms.Label()
        Me.lbl_pesomax = New System.Windows.Forms.Label()
        Me.lbl_capacidade = New System.Windows.Forms.Label()
        Me.lbl_pesomin = New System.Windows.Forms.Label()
        Me.lbl_assentos = New System.Windows.Forms.Label()
        Me.janela_selecionar_foto = New System.Windows.Forms.OpenFileDialog()
        Me.dgv_cadastros = New System.Windows.Forms.DataGridView()
        Me.col_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_assentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_velocidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_autonomia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_operacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_regra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_diaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ativado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gb_identificacao.SuspendLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_pesquisar.SuspendLayout()
        Me.gb_capacidade.SuspendLayout()
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
        'gb_identificacao
        '
        Me.gb_identificacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gb_identificacao.Controls.Add(Me.txt_matricula)
        Me.gb_identificacao.Controls.Add(Me.cmb_tipo)
        Me.gb_identificacao.Controls.Add(Me.txt_fabricante)
        Me.gb_identificacao.Controls.Add(Me.txt_modelo)
        Me.gb_identificacao.Controls.Add(Me.cmb_combustivel)
        Me.gb_identificacao.Controls.Add(Me.txt_ano)
        Me.gb_identificacao.Controls.Add(Me.lbl_foto)
        Me.gb_identificacao.Controls.Add(Me.pb_foto)
        Me.gb_identificacao.Controls.Add(Me.lbl_ano)
        Me.gb_identificacao.Controls.Add(Me.lbl_combustivel)
        Me.gb_identificacao.Controls.Add(Me.lbl_modelo)
        Me.gb_identificacao.Controls.Add(Me.lbl_fabricante)
        Me.gb_identificacao.Controls.Add(Me.lbl_tipo)
        Me.gb_identificacao.Controls.Add(Me.lbl_matricula)
        Me.gb_identificacao.Controls.Add(Me.lbl_identificacao)
        Me.gb_identificacao.Location = New System.Drawing.Point(15, 81)
        Me.gb_identificacao.Name = "gb_identificacao"
        Me.gb_identificacao.Size = New System.Drawing.Size(865, 322)
        Me.gb_identificacao.TabIndex = 10
        '
        'txt_matricula
        '
        Me.txt_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matricula.Location = New System.Drawing.Point(104, 48)
        Me.txt_matricula.Mask = ">LL\-LLL"
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(90, 24)
        Me.txt_matricula.TabIndex = 1
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(158, 90)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(324, 24)
        Me.cmb_tipo.TabIndex = 2
        '
        'txt_fabricante
        '
        Me.txt_fabricante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fabricante.Location = New System.Drawing.Point(112, 133)
        Me.txt_fabricante.MaxLength = 30
        Me.txt_fabricante.Name = "txt_fabricante"
        Me.txt_fabricante.Size = New System.Drawing.Size(370, 22)
        Me.txt_fabricante.TabIndex = 3
        '
        'txt_modelo
        '
        Me.txt_modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_modelo.Location = New System.Drawing.Point(84, 174)
        Me.txt_modelo.MaxLength = 30
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(398, 22)
        Me.txt_modelo.TabIndex = 4
        '
        'cmb_combustivel
        '
        Me.cmb_combustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_combustivel.FormattingEnabled = True
        Me.cmb_combustivel.Location = New System.Drawing.Point(122, 215)
        Me.cmb_combustivel.Name = "cmb_combustivel"
        Me.cmb_combustivel.Size = New System.Drawing.Size(360, 24)
        Me.cmb_combustivel.TabIndex = 5
        '
        'txt_ano
        '
        Me.txt_ano.Location = New System.Drawing.Point(166, 258)
        Me.txt_ano.Mask = "0000"
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(100, 22)
        Me.txt_ano.TabIndex = 6
        '
        'lbl_foto
        '
        Me.lbl_foto.AutoSize = True
        Me.lbl_foto.Location = New System.Drawing.Point(435, 292)
        Me.lbl_foto.Name = "lbl_foto"
        Me.lbl_foto.Size = New System.Drawing.Size(47, 16)
        Me.lbl_foto.TabIndex = 21
        Me.lbl_foto.Text = "FOTO:"
        '
        'pb_foto
        '
        Me.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_foto.InitialImage = CType(resources.GetObject("pb_foto.InitialImage"), System.Drawing.Image)
        Me.pb_foto.Location = New System.Drawing.Point(488, 5)
        Me.pb_foto.Name = "pb_foto"
        Me.pb_foto.Size = New System.Drawing.Size(370, 310)
        Me.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto.TabIndex = 16
        Me.pb_foto.TabStop = False
        '
        'lbl_ano
        '
        Me.lbl_ano.AutoSize = True
        Me.lbl_ano.Location = New System.Drawing.Point(6, 261)
        Me.lbl_ano.Name = "lbl_ano"
        Me.lbl_ano.Size = New System.Drawing.Size(154, 16)
        Me.lbl_ano.TabIndex = 34
        Me.lbl_ano.Text = "*ANO DE FABRICAÇÃO:"
        '
        'lbl_combustivel
        '
        Me.lbl_combustivel.AutoSize = True
        Me.lbl_combustivel.Location = New System.Drawing.Point(6, 218)
        Me.lbl_combustivel.Name = "lbl_combustivel"
        Me.lbl_combustivel.Size = New System.Drawing.Size(110, 16)
        Me.lbl_combustivel.TabIndex = 27
        Me.lbl_combustivel.Text = "*COMBUSTÍVEL:"
        '
        'lbl_modelo
        '
        Me.lbl_modelo.AutoSize = True
        Me.lbl_modelo.Location = New System.Drawing.Point(6, 177)
        Me.lbl_modelo.Name = "lbl_modelo"
        Me.lbl_modelo.Size = New System.Drawing.Size(72, 16)
        Me.lbl_modelo.TabIndex = 25
        Me.lbl_modelo.Text = "*MODELO:"
        '
        'lbl_fabricante
        '
        Me.lbl_fabricante.AutoSize = True
        Me.lbl_fabricante.Location = New System.Drawing.Point(6, 136)
        Me.lbl_fabricante.Name = "lbl_fabricante"
        Me.lbl_fabricante.Size = New System.Drawing.Size(100, 16)
        Me.lbl_fabricante.TabIndex = 23
        Me.lbl_fabricante.Text = "*FABRICANTE:"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(6, 93)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(146, 16)
        Me.lbl_tipo.TabIndex = 20
        Me.lbl_tipo.Text = "*TIPO DE AERONAVE:"
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Location = New System.Drawing.Point(6, 53)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(92, 16)
        Me.lbl_matricula.TabIndex = 18
        Me.lbl_matricula.Text = "*MATRÍCULA:"
        '
        'lbl_identificacao
        '
        Me.lbl_identificacao.AutoSize = True
        Me.lbl_identificacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_identificacao.Location = New System.Drawing.Point(6, 0)
        Me.lbl_identificacao.Name = "lbl_identificacao"
        Me.lbl_identificacao.Size = New System.Drawing.Size(380, 32)
        Me.lbl_identificacao.TabIndex = 12
        Me.lbl_identificacao.Text = "IDENTIFICAÇÃO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(clique duplo em MATRÍCULA para limpar os campos)"
        '
        'cmb_operacao
        '
        Me.cmb_operacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_operacao.FormattingEnabled = True
        Me.cmb_operacao.Location = New System.Drawing.Point(424, 155)
        Me.cmb_operacao.Name = "cmb_operacao"
        Me.cmb_operacao.Size = New System.Drawing.Size(120, 24)
        Me.cmb_operacao.TabIndex = 12
        '
        'cmb_regra
        '
        Me.cmb_regra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_regra.FormattingEnabled = True
        Me.cmb_regra.Location = New System.Drawing.Point(204, 193)
        Me.cmb_regra.Name = "cmb_regra"
        Me.cmb_regra.Size = New System.Drawing.Size(340, 24)
        Me.cmb_regra.TabIndex = 13
        '
        'lbl_regra
        '
        Me.lbl_regra.AutoSize = True
        Me.lbl_regra.Location = New System.Drawing.Point(81, 196)
        Me.lbl_regra.Name = "lbl_regra"
        Me.lbl_regra.Size = New System.Drawing.Size(117, 16)
        Me.lbl_regra.TabIndex = 31
        Me.lbl_regra.Text = "*REGRA DE VOO:"
        '
        'lbl_operacao
        '
        Me.lbl_operacao.AutoSize = True
        Me.lbl_operacao.Location = New System.Drawing.Point(328, 158)
        Me.lbl_operacao.Name = "lbl_operacao"
        Me.lbl_operacao.Size = New System.Drawing.Size(90, 16)
        Me.lbl_operacao.TabIndex = 29
        Me.lbl_operacao.Text = "*OPERAÇÃO:"
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
        Me.btn_limpar.Location = New System.Drawing.Point(399, 258)
        Me.btn_limpar.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(150, 50)
        Me.btn_limpar.TabIndex = 16
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.btn_salvar_base.Location = New System.Drawing.Point(233, 258)
        Me.btn_salvar_base.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_salvar_base.Name = "btn_salvar_base"
        Me.btn_salvar_base.Size = New System.Drawing.Size(150, 50)
        Me.btn_salvar_base.TabIndex = 15
        Me.btn_salvar_base.Text = "SALVAR"
        Me.btn_salvar_base.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_salvar_base.UseVisualStyleBackColor = False
        '
        'ts_pesquisar
        '
        Me.ts_pesquisar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_pesquisar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ts_pesquisar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_cmb_pesquisar, Me.cmb_pesquisar, Me.lbl_txt_pesquisar, Me.txt_pesquisar, Me.ToolStripSeparator1, Me.btn_salvar_topo})
        Me.ts_pesquisar.Location = New System.Drawing.Point(0, 0)
        Me.ts_pesquisar.Name = "ts_pesquisar"
        Me.ts_pesquisar.Size = New System.Drawing.Size(1467, 31)
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
        'gb_capacidade
        '
        Me.gb_capacidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gb_capacidade.Controls.Add(Me.lbl_diaria_rs)
        Me.gb_capacidade.Controls.Add(Me.txt_diaria)
        Me.gb_capacidade.Controls.Add(Me.lbl_autonomia_km)
        Me.gb_capacidade.Controls.Add(Me.lbl_velocidade_kmh)
        Me.gb_capacidade.Controls.Add(Me.lbl_pesomax_kg)
        Me.gb_capacidade.Controls.Add(Me.lbl_pesomin_kg)
        Me.gb_capacidade.Controls.Add(Me.btn_salvar_base)
        Me.gb_capacidade.Controls.Add(Me.btn_limpar)
        Me.gb_capacidade.Controls.Add(Me.cmb_regra)
        Me.gb_capacidade.Controls.Add(Me.lbl_diaria)
        Me.gb_capacidade.Controls.Add(Me.cmb_operacao)
        Me.gb_capacidade.Controls.Add(Me.txt_autonomia)
        Me.gb_capacidade.Controls.Add(Me.txt_velocidade)
        Me.gb_capacidade.Controls.Add(Me.txt_pesomax)
        Me.gb_capacidade.Controls.Add(Me.txt_pesomin)
        Me.gb_capacidade.Controls.Add(Me.txt_assentos)
        Me.gb_capacidade.Controls.Add(Me.lbl_autonomia)
        Me.gb_capacidade.Controls.Add(Me.lbl_velocidade)
        Me.gb_capacidade.Controls.Add(Me.lbl_pesomax)
        Me.gb_capacidade.Controls.Add(Me.lbl_regra)
        Me.gb_capacidade.Controls.Add(Me.lbl_operacao)
        Me.gb_capacidade.Controls.Add(Me.lbl_capacidade)
        Me.gb_capacidade.Controls.Add(Me.lbl_pesomin)
        Me.gb_capacidade.Controls.Add(Me.lbl_assentos)
        Me.gb_capacidade.Location = New System.Drawing.Point(886, 81)
        Me.gb_capacidade.Name = "gb_capacidade"
        Me.gb_capacidade.Size = New System.Drawing.Size(564, 322)
        Me.gb_capacidade.TabIndex = 13
        '
        'lbl_diaria_rs
        '
        Me.lbl_diaria_rs.AutoSize = True
        Me.lbl_diaria_rs.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_diaria_rs.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diaria_rs.Location = New System.Drawing.Point(8, 280)
        Me.lbl_diaria_rs.Name = "lbl_diaria_rs"
        Me.lbl_diaria_rs.Size = New System.Drawing.Size(27, 16)
        Me.lbl_diaria_rs.TabIndex = 48
        Me.lbl_diaria_rs.Text = "R$ "
        '
        'txt_diaria
        '
        Me.txt_diaria.Location = New System.Drawing.Point(41, 277)
        Me.txt_diaria.Mask = "99999"
        Me.txt_diaria.Name = "txt_diaria"
        Me.txt_diaria.Size = New System.Drawing.Size(70, 22)
        Me.txt_diaria.TabIndex = 14
        '
        'lbl_autonomia_km
        '
        Me.lbl_autonomia_km.AutoSize = True
        Me.lbl_autonomia_km.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_autonomia_km.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_autonomia_km.Location = New System.Drawing.Point(255, 139)
        Me.lbl_autonomia_km.Name = "lbl_autonomia_km"
        Me.lbl_autonomia_km.Size = New System.Drawing.Size(25, 16)
        Me.lbl_autonomia_km.TabIndex = 47
        Me.lbl_autonomia_km.Text = "km"
        '
        'lbl_velocidade_kmh
        '
        Me.lbl_velocidade_kmh.AutoSize = True
        Me.lbl_velocidade_kmh.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_velocidade_kmh.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_velocidade_kmh.Location = New System.Drawing.Point(513, 110)
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
        Me.lbl_pesomax_kg.Location = New System.Drawing.Point(258, 76)
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
        Me.lbl_pesomin_kg.Location = New System.Drawing.Point(412, 29)
        Me.lbl_pesomin_kg.Name = "lbl_pesomin_kg"
        Me.lbl_pesomin_kg.Size = New System.Drawing.Size(22, 16)
        Me.lbl_pesomin_kg.TabIndex = 44
        Me.lbl_pesomin_kg.Text = "kg"
        '
        'lbl_diaria
        '
        Me.lbl_diaria.AutoSize = True
        Me.lbl_diaria.Location = New System.Drawing.Point(8, 258)
        Me.lbl_diaria.Name = "lbl_diaria"
        Me.lbl_diaria.Size = New System.Drawing.Size(131, 16)
        Me.lbl_diaria.TabIndex = 0
        Me.lbl_diaria.Text = "*PREÇO DA DIÁRIA:"
        '
        'txt_autonomia
        '
        Me.txt_autonomia.Location = New System.Drawing.Point(182, 136)
        Me.txt_autonomia.Mask = "00000"
        Me.txt_autonomia.Name = "txt_autonomia"
        Me.txt_autonomia.Size = New System.Drawing.Size(70, 22)
        Me.txt_autonomia.TabIndex = 11
        '
        'txt_velocidade
        '
        Me.txt_velocidade.Location = New System.Drawing.Point(437, 107)
        Me.txt_velocidade.Mask = "00000"
        Me.txt_velocidade.Name = "txt_velocidade"
        Me.txt_velocidade.Size = New System.Drawing.Size(70, 22)
        Me.txt_velocidade.TabIndex = 10
        '
        'txt_pesomax
        '
        Me.txt_pesomax.Location = New System.Drawing.Point(182, 73)
        Me.txt_pesomax.Mask = "0000000"
        Me.txt_pesomax.Name = "txt_pesomax"
        Me.txt_pesomax.Size = New System.Drawing.Size(70, 22)
        Me.txt_pesomax.TabIndex = 9
        '
        'txt_pesomin
        '
        Me.txt_pesomin.Location = New System.Drawing.Point(336, 26)
        Me.txt_pesomin.Mask = "000000"
        Me.txt_pesomin.Name = "txt_pesomin"
        Me.txt_pesomin.Size = New System.Drawing.Size(70, 22)
        Me.txt_pesomin.TabIndex = 8
        '
        'txt_assentos
        '
        Me.txt_assentos.Location = New System.Drawing.Point(97, 26)
        Me.txt_assentos.Mask = "0000"
        Me.txt_assentos.Name = "txt_assentos"
        Me.txt_assentos.Size = New System.Drawing.Size(60, 22)
        Me.txt_assentos.TabIndex = 7
        '
        'lbl_autonomia
        '
        Me.lbl_autonomia.AutoSize = True
        Me.lbl_autonomia.Location = New System.Drawing.Point(19, 139)
        Me.lbl_autonomia.Name = "lbl_autonomia"
        Me.lbl_autonomia.Size = New System.Drawing.Size(150, 16)
        Me.lbl_autonomia.TabIndex = 42
        Me.lbl_autonomia.Text = "*AUTONOMIA MÁXIMA:"
        '
        'lbl_velocidade
        '
        Me.lbl_velocidade.AutoSize = True
        Me.lbl_velocidade.Location = New System.Drawing.Point(275, 110)
        Me.lbl_velocidade.Name = "lbl_velocidade"
        Me.lbl_velocidade.Size = New System.Drawing.Size(154, 16)
        Me.lbl_velocidade.TabIndex = 41
        Me.lbl_velocidade.Text = "*VELOCIDADE MÁXIMA:"
        '
        'lbl_pesomax
        '
        Me.lbl_pesomax.AutoSize = True
        Me.lbl_pesomax.Location = New System.Drawing.Point(8, 76)
        Me.lbl_pesomax.Name = "lbl_pesomax"
        Me.lbl_pesomax.Size = New System.Drawing.Size(161, 16)
        Me.lbl_pesomax.TabIndex = 39
        Me.lbl_pesomax.Text = "*MTOW (PESO MÁXIMO):"
        '
        'lbl_capacidade
        '
        Me.lbl_capacidade.AutoSize = True
        Me.lbl_capacidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capacidade.Location = New System.Drawing.Point(6, 0)
        Me.lbl_capacidade.Name = "lbl_capacidade"
        Me.lbl_capacidade.Size = New System.Drawing.Size(476, 16)
        Me.lbl_capacidade.TabIndex = 12
        Me.lbl_capacidade.Text = "CAPACIDADE (clique duplo em ASSENTOS para limpar os campos)"
        '
        'lbl_pesomin
        '
        Me.lbl_pesomin.AutoSize = True
        Me.lbl_pesomin.Location = New System.Drawing.Point(179, 29)
        Me.lbl_pesomin.Name = "lbl_pesomin"
        Me.lbl_pesomin.Size = New System.Drawing.Size(146, 16)
        Me.lbl_pesomin.TabIndex = 11
        Me.lbl_pesomin.Text = "*BOW (PESO MÍNIMO):"
        '
        'lbl_assentos
        '
        Me.lbl_assentos.AutoSize = True
        Me.lbl_assentos.Location = New System.Drawing.Point(6, 29)
        Me.lbl_assentos.Name = "lbl_assentos"
        Me.lbl_assentos.Size = New System.Drawing.Size(89, 16)
        Me.lbl_assentos.TabIndex = 0
        Me.lbl_assentos.Text = "*ASSENTOS:"
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
        Me.dgv_cadastros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_numero, Me.col_matricula, Me.col_tipo, Me.col_modelo, Me.col_assentos, Me.col_velocidade, Me.col_autonomia, Me.col_operacao, Me.col_regra, Me.col_diaria, Me.col_ativado})
        Me.dgv_cadastros.Location = New System.Drawing.Point(15, 409)
        Me.dgv_cadastros.Name = "dgv_cadastros"
        Me.dgv_cadastros.RowHeadersWidth = 51
        Me.dgv_cadastros.RowTemplate.Height = 24
        Me.dgv_cadastros.Size = New System.Drawing.Size(1435, 427)
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
        Me.col_tipo.Width = 150
        '
        'col_modelo
        '
        Me.col_modelo.Frozen = True
        Me.col_modelo.HeaderText = "MODELO"
        Me.col_modelo.MinimumWidth = 6
        Me.col_modelo.Name = "col_modelo"
        Me.col_modelo.ReadOnly = True
        Me.col_modelo.Width = 140
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
        Me.col_diaria.Width = 80
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
        'frm_cad_aeronave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1467, 843)
        Me.Controls.Add(Me.dgv_cadastros)
        Me.Controls.Add(Me.gb_capacidade)
        Me.Controls.Add(Me.ts_pesquisar)
        Me.Controls.Add(Me.lbl_usuario_e_data)
        Me.Controls.Add(Me.gb_identificacao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(24, 24)
        Me.Name = "frm_cad_aeronave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CADASTRO DE AERONAVES"
        Me.gb_identificacao.ResumeLayout(False)
        Me.gb_identificacao.PerformLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_pesquisar.ResumeLayout(False)
        Me.ts_pesquisar.PerformLayout()
        Me.gb_capacidade.ResumeLayout(False)
        Me.gb_capacidade.PerformLayout()
        CType(Me.dgv_cadastros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_usuario_e_data As Label
    Friend WithEvents gb_identificacao As Panel
    Friend WithEvents btn_limpar As Button
    Friend WithEvents lbl_identificacao As Label
    Friend WithEvents ts_pesquisar As ToolStrip
    Friend WithEvents btn_salvar_topo As ToolStripButton
    Friend WithEvents lbl_txt_pesquisar As ToolStripLabel
    Friend WithEvents txt_pesquisar As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lbl_cmb_pesquisar As ToolStripLabel
    Friend WithEvents cmb_pesquisar As ToolStripComboBox
    Friend WithEvents pb_foto As PictureBox
    Friend WithEvents gb_capacidade As Panel
    Friend WithEvents lbl_capacidade As Label
    Friend WithEvents lbl_pesomin As Label
    Friend WithEvents lbl_assentos As Label
    Friend WithEvents janela_selecionar_foto As OpenFileDialog
    Friend WithEvents lbl_diaria As Label
    Friend WithEvents btn_salvar_base As Button
    Friend WithEvents dgv_cadastros As DataGridView
    Friend WithEvents txt_diaria As MaskedTextBox
    Friend WithEvents txt_matricula As MaskedTextBox
    Friend WithEvents lbl_matricula As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents lbl_foto As Label
    Friend WithEvents lbl_fabricante As Label
    Friend WithEvents txt_fabricante As TextBox
    Friend WithEvents lbl_modelo As Label
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents cmb_combustivel As ComboBox
    Friend WithEvents lbl_combustivel As Label
    Friend WithEvents cmb_operacao As ComboBox
    Friend WithEvents cmb_regra As ComboBox
    Friend WithEvents lbl_regra As Label
    Friend WithEvents lbl_operacao As Label
    Friend WithEvents lbl_ano As Label
    Friend WithEvents txt_ano As MaskedTextBox
    Friend WithEvents txt_assentos As MaskedTextBox
    Friend WithEvents txt_pesomin As MaskedTextBox
    Friend WithEvents txt_pesomax As MaskedTextBox
    Friend WithEvents lbl_pesomax As Label
    Friend WithEvents txt_velocidade As MaskedTextBox
    Friend WithEvents lbl_velocidade As Label
    Friend WithEvents lbl_autonomia As Label
    Friend WithEvents txt_autonomia As MaskedTextBox
    Friend WithEvents lbl_pesomin_kg As Label
    Friend WithEvents lbl_pesomax_kg As Label
    Friend WithEvents lbl_velocidade_kmh As Label
    Friend WithEvents lbl_autonomia_km As Label
    Friend WithEvents lbl_diaria_rs As Label
    Friend WithEvents col_numero As DataGridViewTextBoxColumn
    Friend WithEvents col_matricula As DataGridViewTextBoxColumn
    Friend WithEvents col_tipo As DataGridViewTextBoxColumn
    Friend WithEvents col_modelo As DataGridViewTextBoxColumn
    Friend WithEvents col_assentos As DataGridViewTextBoxColumn
    Friend WithEvents col_velocidade As DataGridViewTextBoxColumn
    Friend WithEvents col_autonomia As DataGridViewTextBoxColumn
    Friend WithEvents col_operacao As DataGridViewTextBoxColumn
    Friend WithEvents col_regra As DataGridViewTextBoxColumn
    Friend WithEvents col_diaria As DataGridViewTextBoxColumn
    Friend WithEvents col_ativado As DataGridViewCheckBoxColumn
End Class
