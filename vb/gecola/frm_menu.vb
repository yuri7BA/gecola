Public Class frm_menu

    '-------------------'
    ' FORMULÁRIO ABERTO '
    '-------------------'
    Private Sub abrir_frm_menu() Handles MyBase.Load
        Call carregar_usuario_e_data(lbl_usuario_data)
        Call bloquear_controles(meu_perfil)
    End Sub

    '----------------------------------------------'
    ' BLOQUEIA CONTROLES SEGUNDO PERFIL DO USUARIO '
    '----------------------------------------------'
    Private Sub bloquear_controles(perfil)
        Select Case perfil
            Case "a"
                ts_cad_clientes.Enabled = False
                ts_cad_contratos.Enabled = False
                ts_cad_funcionarios.Enabled = False
                ts_cad_aeronaves.Enabled = False
                ts_rel_contratos.Enabled = False
            Case "g"
                ts_cad_clientes.Enabled = False
                ts_cad_gerentes.Enabled = False
                ts_cad_administradores.Enabled = False
                ts_rel_receitas.Enabled = False
            Case "f"
                ts_cad_funcionarios.Enabled = False
                ts_cad_aeronaves.Enabled = False
                ts_cad_gerentes.Enabled = False
                ts_cad_administradores.Enabled = False
                ts_rel.Enabled = False
            Case Else
                ts_cad_senha.Enabled = False
                ts_cad_clientes.Enabled = False
                ts_cad_contratos.Enabled = False
                ts_cad_funcionarios.Enabled = False
                ts_cad_aeronaves.Enabled = False
                ts_cad_gerentes.Enabled = False
                ts_cad_administradores.Enabled = False
        End Select
    End Sub

    '--------------'
    ' TROCAR SENHA '
    '--------------'
    Private Sub mostrar_frm_senha() Handles ts_cad_senha.Click
        frm_senha.ShowDialog()
    End Sub

    '-------------------'
    ' CADASTRAR CLIENTE '
    '-------------------'
    Private Sub cadastrar_cliente() Handles ts_cad_clientes.Click
        frm_cad_cliente.ShowDialog()
    End Sub

    '--------------------'
    ' CADASTRAR CONTRATO '
    '--------------------'
    Private Sub cadastrar_contrato() Handles ts_cad_contratos.Click
        frm_cad_contrato.ShowDialog()
    End Sub

    '-----------------------'
    ' CADASTRAR FUNCIONÁRIO '
    '-----------------------'
    Private Sub cadastrar_funcionario() Handles ts_cad_funcionarios.Click
        frm_cad_funcionario.ShowDialog()
    End Sub

    '--------------------'
    ' CADASTRAR AERONAVE '
    '--------------------'
    Private Sub cadastrar_aeronave() Handles ts_cad_aeronaves.Click
        frm_cad_aeronave.ShowDialog()
    End Sub

    '-------------------'
    ' CADASTRAR GERENTE '
    '-------------------'
    Private Sub cadastrar_gerente() Handles ts_cad_gerentes.Click
        frm_cad_gerente.ShowDialog()
    End Sub

    '-------------------------'
    ' CADASTRAR ADMINISTRADOR '
    '-------------------------'
    Private Sub cadastrar_admin() Handles ts_cad_administradores.Click
        frm_cad_admin.ShowDialog()
    End Sub

    '--------------------'
    ' FORMULÁRIO FECHADO '
    '--------------------'
    Private Sub fechar_frm_menu() Handles MyBase.FormClosed
        frm_acesso.Show()
    End Sub
End Class