Public Class frm_contas
    '----------------------'
    ' ABRINDO O FORMULÁRIO '
    '----------------------'
    Private Sub abrir_frm_contas() Handles MyBase.Load
        Call carregar_usuario_e_data(lbl_usuario_e_data)
        Call limpar_gb_dados_conta()
        Call popular_dgv_dados_conta()
    End Sub

    '------------------------------------------------'
    ' LIMPA OS CONTROLES DA GROUP BOX DADOS PESSOAIS '
    '------------------------------------------------'
    Private Sub limpar_gb_dados_conta()
        Try
            With Me
                .txt_usuario.Clear()
                .cmb_perfil.Text = ""
                .cmb_ativado.Text = ""
                .txt_senha.Clear()
                .txt_senha_repete.Clear()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar o cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    '-------------------------'
    ' POPULA O DATA GRID VIEW '
    '-------------------------'
    Private Sub popular_dgv_dados_conta()
        Dim cont As Single
        Dim perfil As String
        Dim ativado As Boolean
        Try
            With dgv_dados_conta
                cont = 0
                .Rows.Clear()
                qry = "SELECT * FROM tb_logins ORDER BY usuario ASC"
                rs = db.Execute(qry)
                Do While Not rs.EOF
                    cont = cont + 1
                    If rs(3).Value = "a" Then
                        perfil = "administrador"
                    Else
                        perfil = "usuário"
                    End If
                    If rs(4).Value = "s" Then
                        ativado = True
                    Else
                        ativado = False
                    End If
                    .Rows.Add(cont, rs(0).Value, rs(1).Value, perfil, ativado) 'nº, usuário, senha, perfil, ativado
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Algo deu errado...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Exit Sub
        End Try
    End Sub

    '--------------------'
    ' VALIDA TXT_USUARIO '
    '--------------------'
    Private Sub validar_txt_usuario() Handles txt_usuario.Leave
        If txt_usuario.TextLength > 0 And (txt_usuario.TextLength < 3 Or txt_usuario.TextLength > 20) Then
            MsgBox("Digite um nome de usuário com 3 a 20 caracteres (inclusive), ou dê um clique duplo para limpar este campo.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
        End If
    End Sub

    '-------------------'
    ' LIMPA TXT_USUARIO '
    '-------------------'
    Private Sub limpar_txt_usuario() Handles txt_usuario.DoubleClick
        txt_usuario.Clear()
    End Sub

    '-------------------'
    ' VALIDA CMB_PERFIL '
    '-------------------'
    Private Sub validar_cmb_perfil() Handles cmb_perfil.Leave, cmb_perfil.SelectedValueChanged
        If Len(cmb_perfil.Text) > 0 And cmb_perfil.Text <> "administrador" And cmb_perfil.Text <> "usuário" Then
            cmb_perfil.Text = ""
            MsgBox("Selecione um perfil de conta que esteja na lista.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
        End If
    End Sub

    '--------------------'
    ' VALIDA CMB_ATIVADO '
    '--------------------'
    Private Sub validar_cmb_ativado() Handles cmb_ativado.Leave
        If Len(cmb_ativado.Text) > 0 And cmb_ativado.Text <> "sim" And cmb_ativado.Text <> "não" Then
            cmb_ativado.Text = ""
            MsgBox("Selecione um status de ativação de conta que esteja na lista.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
        End If
    End Sub

    '------------------'
    ' VALIDA TXT_SENHA '
    '------------------'
    Private Sub validar_txt_senha() Handles txt_senha.Leave
        If txt_senha.TextLength > 0 And (txt_senha.TextLength < 8 Or txt_senha.TextLength > 20) Then
            MsgBox("Digite uma senha com 8 a 20 caracteres (inclusive), ou dê um clique duplo para limpar este campo.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
        End If
    End Sub

    '-----------------'
    ' LIMPA TXT_SENHA '
    '-----------------'
    Private Sub limpar_txt_senha() Handles txt_senha.DoubleClick
        txt_senha.Clear()
    End Sub

    '-------------------------'
    ' VALIDA TXT_SENHA_REPETE '
    '-------------------------'
    Private Sub validar_txt_senha_repete() Handles txt_senha_repete.Leave
        If txt_senha_repete.TextLength > 0 And (txt_senha_repete.TextLength < 8 Or txt_senha_repete.TextLength > 20) Then
            MsgBox("Digite a mesma senha com 8 a 20 caracteres (inclusive), ou dê um clique duplo para limpar este campo.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
        End If
    End Sub

    '------------------------'
    ' LIMPA TXT_SENHA_REPETE '
    '------------------------'
    Private Sub limpar_txt_senha_repete() Handles txt_senha_repete.DoubleClick
        txt_senha_repete.Clear()
    End Sub

    '-----------------------------------------------------------------'
    ' VERIFICA SE TODOS OS CAMPOS DE GB_DADOS_CONTA ESTÃO PREENCHIDOS '
    '-----------------------------------------------------------------'
    Private Sub verificar_gb_dados_conta() Handles btn_salvar.Click
        With gb_dados_conta
            If txt_usuario.TextLength = 0 Then
                MsgBox("Preencha um nome de usuário para esta nova conta.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                txt_usuario.Select()
            Else
                qry = "SELECT * FROM tb_logins WHERE usuario='" & txt_usuario.Text & "'"
                rs = db.Execute(qry)
                If Not rs.EOF Then
                    MsgBox("Esta nova conta já existe no banco de dados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "DUPLICIDADE!")
                ElseIf cmb_perfil.Text = "" Then
                    MsgBox("Selecione um perfil para esta nova conta.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                    cmb_perfil.Select()
                ElseIf cmb_ativado.Text = "" Then
                    MsgBox("É necessário informar se esta nova conta deverá ficar ativa ou não.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                    cmb_ativado.Select()
                ElseIf txt_senha.TextLength = 0 Then
                    MsgBox("Digite uma senha para esta nova conta.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                    txt_senha.Select()
                ElseIf txt_senha_repete.TextLength = 0 Then
                    MsgBox("Repita a senha para esta nova conta.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                    txt_senha_repete.Select()
                ElseIf txt_senha.Text <> txt_senha_repete.Text Then
                    MsgBox("As senhas digitadas não conferem!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERRO")
                    txt_senha_repete.Clear()
                    txt_senha.Clear()
                    txt_senha.Select()
                Else
                    Call cadastrar_nova_conta()
                End If
            End If
        End With
    End Sub

    '-----------------------------------------'
    ' INSERE NO BANCO AS ALTERAÇÕES EFETUADAS '
    '-----------------------------------------'
    Private Sub cadastrar_nova_conta()
        Dim perfil, ativado As Char

        If cmb_perfil.Text = "administrador" Then
            perfil = "a"
        Else
            perfil = "u"
        End If
        If cmb_ativado.Text = "sim" Then
            ativado = "s"
        Else
            ativado = "n"
        End If

        qry = "INSERT INTO tb_logins VALUES ('" & txt_usuario.Text & "','" & txt_senha.Text & "','" & perfil & "','" & ativado & "')"

        Try
            db.Execute(qry)
            MsgBox("Nova conta cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "NOVA CONTA CADASTRADA")
            Call limpar_gb_dados_conta()
            Call popular_dgv_dados_conta()
        Catch ex As Exception
            MsgBox("Erro ao tentar gravar a nova conta no banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    '--------------------------'
    ' BOTÃO LIMPAR FOI CLICADO '
    '--------------------------'
    Private Sub btn_limpar_clicado() Handles btn_limpar.Click
        Call limpar_gb_dados_conta()
    End Sub

    '------------------------------------------------'
    ' DES/ATIVA/EXCLUI CADASTROS VIA DGV_DADOS_CONTA '
    '------------------------------------------------'
    Private Sub controles_dgv_dados() Handles dgv_dados_conta.CellClick
        Dim dgvId As Integer
        Dim dgvUsuario As String
        Dim dgvPerfil As String
        Dim dgvAtivo, dgvAtivoClicado, dgvExcluir As Boolean
        Dim rsAtivo As Char

        dgvId = dgv_dados_conta.CurrentRow.Cells(1).Value
        dgvUsuario = dgv_dados_conta.CurrentRow.Cells(2).Value
        dgvPerfil = dgv_dados_conta.CurrentRow.Cells(3).Value
        dgvAtivo = dgv_dados_conta.CurrentRow.Cells(4).Value
        dgvAtivoClicado = dgv_dados_conta.CurrentRow.Cells(4).Selected
        dgvExcluir = dgv_dados_conta.CurrentRow.Cells(5).Selected

        If dgvId = 1 Then
            MsgBox("Você não pode excluir nem desativar a conta master!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Call popular_dgv_dados_conta()
        ElseIf dgvId = meu_id Then
            MsgBox("Você não pode excluir nem desativar sua própria conta!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERRO")
            Call popular_dgv_dados_conta()
        Else
            Try
                qry = "SELECT * FROM tb_logins WHERE id='" & dgvId & "'"
                rs = db.Execute(qry)
                If dgvExcluir Then
                    resp = MsgBox("Confirma a exclusão da conta " & dgvUsuario & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXCLUIR CONTA?")
                    If resp = vbYes Then
                        Call excluir_dgv_dados_conta(dgvId)
                    End If
                    Call popular_dgv_dados_conta()
                ElseIf dgvAtivoClicado Then
                    resp = MsgBox("Tem certeza de que quer modificar a ativação desta conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALTERAR?")
                    If resp = vbYes Then
                        If dgvAtivo Then
                            rsAtivo = "n"
                        Else
                            rsAtivo = "s"
                        End If
                        qry = "UPDATE tb_logins SET ativado='" & rsAtivo & "' WHERE id='" & dgvId & "'"
                        rs = db.Execute(qry)
                    End If
                    Call popular_dgv_dados_conta()
                End If
            Catch ex As Exception
                MsgBox("Erro ao processar essa ação!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End If
    End Sub

    '--------------------------------------------------------'
    ' EXCLUI DO BANCO A CONTA SELECIONADA EM DGV_DADOS_CONTA '
    '--------------------------------------------------------'
    Private Sub excluir_dgv_dados_conta(userId)
        Try
            qry = "DELETE FROM tb_logins WHERE id='" & userId & "'"
            rs = db.Execute(qry)
            MsgBox("A conta ID " & userId & " foi excluída.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CADASTRO EXCLUÍDO")
        Catch ex As Exception
            MsgBox("Não consegui excluir essa conta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    '-----------------------'
    ' FECHANDO O FORMULÁRIO '
    '-----------------------'
    Private Sub fechar_frm_contas() Handles MyBase.FormClosed
        frm_login.Show()
    End Sub
End Class