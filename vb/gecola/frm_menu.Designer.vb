<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.lbl_usuario_data = New System.Windows.Forms.Label()
        Me.ms_menu = New System.Windows.Forms.MenuStrip()
        Me.ts_cad = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_cad_administradores = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_cad_aeronaves = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_cad_clientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_cad_contratos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_cad_funcionarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_cad_gerentes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_cad_senha = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_rel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_rel_contratos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_rel_contratos_aeronave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_rel_contratos_cliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_rel_contratos_funcionario = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_rel_receitas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_rel_receitas_aeronave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_rel_receitas_cliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_rel_receitas_funcionario = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_usuario_data
        '
        Me.lbl_usuario_data.AutoSize = True
        Me.lbl_usuario_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario_data.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_usuario_data.Location = New System.Drawing.Point(12, 423)
        Me.lbl_usuario_data.Name = "lbl_usuario_data"
        Me.lbl_usuario_data.Size = New System.Drawing.Size(145, 18)
        Me.lbl_usuario_data.TabIndex = 9
        Me.lbl_usuario_data.Text = "USUÁRIO E DATA"
        '
        'ms_menu
        '
        Me.ms_menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ms_menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_cad, Me.ts_rel})
        Me.ms_menu.Location = New System.Drawing.Point(0, 0)
        Me.ms_menu.Name = "ms_menu"
        Me.ms_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ms_menu.Size = New System.Drawing.Size(800, 28)
        Me.ms_menu.TabIndex = 10
        Me.ms_menu.Text = "MENU"
        '
        'ts_cad
        '
        Me.ts_cad.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_cad_administradores, Me.ts_cad_aeronaves, Me.ts_cad_clientes, Me.ts_cad_contratos, Me.ts_cad_funcionarios, Me.ts_cad_gerentes, Me.ts_cad_senha})
        Me.ts_cad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ts_cad.Name = "ts_cad"
        Me.ts_cad.Size = New System.Drawing.Size(107, 24)
        Me.ts_cad.Text = "CADASTROS"
        '
        'ts_cad_administradores
        '
        Me.ts_cad_administradores.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_cad_administradores.Image = CType(resources.GetObject("ts_cad_administradores.Image"), System.Drawing.Image)
        Me.ts_cad_administradores.Name = "ts_cad_administradores"
        Me.ts_cad_administradores.Size = New System.Drawing.Size(201, 26)
        Me.ts_cad_administradores.Text = "Administradores"
        '
        'ts_cad_aeronaves
        '
        Me.ts_cad_aeronaves.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_cad_aeronaves.Image = CType(resources.GetObject("ts_cad_aeronaves.Image"), System.Drawing.Image)
        Me.ts_cad_aeronaves.Name = "ts_cad_aeronaves"
        Me.ts_cad_aeronaves.Size = New System.Drawing.Size(201, 26)
        Me.ts_cad_aeronaves.Text = "Aeronaves"
        '
        'ts_cad_clientes
        '
        Me.ts_cad_clientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_cad_clientes.Image = CType(resources.GetObject("ts_cad_clientes.Image"), System.Drawing.Image)
        Me.ts_cad_clientes.Name = "ts_cad_clientes"
        Me.ts_cad_clientes.Size = New System.Drawing.Size(201, 26)
        Me.ts_cad_clientes.Text = "Clientes"
        '
        'ts_cad_contratos
        '
        Me.ts_cad_contratos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_cad_contratos.Image = CType(resources.GetObject("ts_cad_contratos.Image"), System.Drawing.Image)
        Me.ts_cad_contratos.Name = "ts_cad_contratos"
        Me.ts_cad_contratos.Size = New System.Drawing.Size(201, 26)
        Me.ts_cad_contratos.Text = "Contratos"
        '
        'ts_cad_funcionarios
        '
        Me.ts_cad_funcionarios.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_cad_funcionarios.Image = CType(resources.GetObject("ts_cad_funcionarios.Image"), System.Drawing.Image)
        Me.ts_cad_funcionarios.Name = "ts_cad_funcionarios"
        Me.ts_cad_funcionarios.Size = New System.Drawing.Size(201, 26)
        Me.ts_cad_funcionarios.Text = "Funcionários"
        '
        'ts_cad_gerentes
        '
        Me.ts_cad_gerentes.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_cad_gerentes.Image = CType(resources.GetObject("ts_cad_gerentes.Image"), System.Drawing.Image)
        Me.ts_cad_gerentes.Name = "ts_cad_gerentes"
        Me.ts_cad_gerentes.Size = New System.Drawing.Size(201, 26)
        Me.ts_cad_gerentes.Text = "Gerentes"
        '
        'ts_cad_senha
        '
        Me.ts_cad_senha.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_cad_senha.Image = CType(resources.GetObject("ts_cad_senha.Image"), System.Drawing.Image)
        Me.ts_cad_senha.Name = "ts_cad_senha"
        Me.ts_cad_senha.Size = New System.Drawing.Size(201, 26)
        Me.ts_cad_senha.Text = "Trocar senha"
        '
        'ts_rel
        '
        Me.ts_rel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_rel_contratos, Me.ts_rel_receitas})
        Me.ts_rel.Name = "ts_rel"
        Me.ts_rel.Size = New System.Drawing.Size(106, 24)
        Me.ts_rel.Text = "RELATÓRIOS"
        '
        'ts_rel_contratos
        '
        Me.ts_rel_contratos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_rel_contratos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_rel_contratos_aeronave, Me.ts_rel_contratos_cliente, Me.ts_rel_contratos_funcionario})
        Me.ts_rel_contratos.Image = CType(resources.GetObject("ts_rel_contratos.Image"), System.Drawing.Image)
        Me.ts_rel_contratos.Name = "ts_rel_contratos"
        Me.ts_rel_contratos.Size = New System.Drawing.Size(224, 26)
        Me.ts_rel_contratos.Text = "Contratos"
        '
        'ts_rel_contratos_aeronave
        '
        Me.ts_rel_contratos_aeronave.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_rel_contratos_aeronave.Image = CType(resources.GetObject("ts_rel_contratos_aeronave.Image"), System.Drawing.Image)
        Me.ts_rel_contratos_aeronave.Name = "ts_rel_contratos_aeronave"
        Me.ts_rel_contratos_aeronave.Size = New System.Drawing.Size(194, 26)
        Me.ts_rel_contratos_aeronave.Text = "por aeronave"
        '
        'ts_rel_contratos_cliente
        '
        Me.ts_rel_contratos_cliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_rel_contratos_cliente.Image = CType(resources.GetObject("ts_rel_contratos_cliente.Image"), System.Drawing.Image)
        Me.ts_rel_contratos_cliente.Name = "ts_rel_contratos_cliente"
        Me.ts_rel_contratos_cliente.Size = New System.Drawing.Size(194, 26)
        Me.ts_rel_contratos_cliente.Text = "por cliente"
        '
        'ts_rel_contratos_funcionario
        '
        Me.ts_rel_contratos_funcionario.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_rel_contratos_funcionario.Image = CType(resources.GetObject("ts_rel_contratos_funcionario.Image"), System.Drawing.Image)
        Me.ts_rel_contratos_funcionario.Name = "ts_rel_contratos_funcionario"
        Me.ts_rel_contratos_funcionario.Size = New System.Drawing.Size(194, 26)
        Me.ts_rel_contratos_funcionario.Text = "por funcionário"
        '
        'ts_rel_receitas
        '
        Me.ts_rel_receitas.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_rel_receitas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_rel_receitas_aeronave, Me.ts_rel_receitas_cliente, Me.ts_rel_receitas_funcionario})
        Me.ts_rel_receitas.Image = CType(resources.GetObject("ts_rel_receitas.Image"), System.Drawing.Image)
        Me.ts_rel_receitas.Name = "ts_rel_receitas"
        Me.ts_rel_receitas.Size = New System.Drawing.Size(224, 26)
        Me.ts_rel_receitas.Text = "Receitas"
        '
        'ts_rel_receitas_aeronave
        '
        Me.ts_rel_receitas_aeronave.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_rel_receitas_aeronave.Image = CType(resources.GetObject("ts_rel_receitas_aeronave.Image"), System.Drawing.Image)
        Me.ts_rel_receitas_aeronave.Name = "ts_rel_receitas_aeronave"
        Me.ts_rel_receitas_aeronave.Size = New System.Drawing.Size(224, 26)
        Me.ts_rel_receitas_aeronave.Text = "por aeronave"
        '
        'ts_rel_receitas_cliente
        '
        Me.ts_rel_receitas_cliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_rel_receitas_cliente.Image = CType(resources.GetObject("ts_rel_receitas_cliente.Image"), System.Drawing.Image)
        Me.ts_rel_receitas_cliente.Name = "ts_rel_receitas_cliente"
        Me.ts_rel_receitas_cliente.Size = New System.Drawing.Size(224, 26)
        Me.ts_rel_receitas_cliente.Text = "por cliente"
        '
        'ts_rel_receitas_funcionario
        '
        Me.ts_rel_receitas_funcionario.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ts_rel_receitas_funcionario.Image = CType(resources.GetObject("ts_rel_receitas_funcionario.Image"), System.Drawing.Image)
        Me.ts_rel_receitas_funcionario.Name = "ts_rel_receitas_funcionario"
        Me.ts_rel_receitas_funcionario.Size = New System.Drawing.Size(224, 26)
        Me.ts_rel_receitas_funcionario.Text = "por funcionário"
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_usuario_data)
        Me.Controls.Add(Me.ms_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ms_menu
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU PRINCIPAL"
        Me.ms_menu.ResumeLayout(False)
        Me.ms_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_usuario_data As Label
    Friend WithEvents ms_menu As MenuStrip
    Friend WithEvents ts_cad As ToolStripMenuItem
    Friend WithEvents ts_cad_senha As ToolStripMenuItem
    Friend WithEvents ts_cad_clientes As ToolStripMenuItem
    Friend WithEvents ts_cad_contratos As ToolStripMenuItem
    Friend WithEvents ts_cad_funcionarios As ToolStripMenuItem
    Friend WithEvents ts_cad_aeronaves As ToolStripMenuItem
    Friend WithEvents ts_cad_gerentes As ToolStripMenuItem
    Friend WithEvents ts_rel As ToolStripMenuItem
    Friend WithEvents ts_rel_contratos As ToolStripMenuItem
    Friend WithEvents ts_rel_contratos_aeronave As ToolStripMenuItem
    Friend WithEvents ts_rel_contratos_cliente As ToolStripMenuItem
    Friend WithEvents ts_rel_contratos_funcionario As ToolStripMenuItem
    Friend WithEvents ts_rel_receitas As ToolStripMenuItem
    Friend WithEvents ts_rel_receitas_aeronave As ToolStripMenuItem
    Friend WithEvents ts_rel_receitas_cliente As ToolStripMenuItem
    Friend WithEvents ts_rel_receitas_funcionario As ToolStripMenuItem
    Friend WithEvents ts_cad_administradores As ToolStripMenuItem
End Class
