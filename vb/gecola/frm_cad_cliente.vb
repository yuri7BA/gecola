Imports System.Text.RegularExpressions
Imports Microsoft
Public Class frm_cad_cliente
    Public gbDPOk, gbEndOk, gbConOk As Boolean 'gbAutOk desativada
    'gbDPOk -> groupbox Dados Pessoais
    'gbAutOk -> groupbox Autenticação
    'gbEndOk -> groupbox Endereço
    'gbConOk -> groupbox Contato
    Public celular, cep, cpf, arroba, sexo As String
    Public foto_perfil As String = "cliente.png"

    '-------------------'
    ' FORMULÁRIO ABERTO '
    '-------------------'
    Private Sub abrir_frm_cad_cliente() Handles MyBase.Load
        sexo = ""
        gbDPOk = False
        'gbAutOk = False
        gbEndOk = False
        gbConOk = False
        MyBase.AutoSize = True
        Call limpar_campos()
        Call carregar_usuario_e_data(lbl_usuario_e_data)
        Call popular_cmb_pesquisar()
        Call popular_cmb_sexo()
        Call popular_dgv_cadastros()
    End Sub

    '----------------------'
    ' POPULA CMB_PESQUISAR '
    '----------------------'
    Private Sub popular_cmb_pesquisar()
        Try
            With cmb_pesquisar.Items
                .Add("")
                .Add("ID")
                .Add("CPF")
                .Add("NOME")
            End With
            cmb_pesquisar.SelectedIndex = 0
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    '-----------------'
    ' POPULA CMB_SEXO '
    '-----------------'
    Private Sub popular_cmb_sexo()
        Try
            With cmb_sexo.Items
                .Add("Masculino")
                .Add("Feminino")
                .Add("Intersexo")
                .Add("")
            End With
            cmb_sexo.Text = ""
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    '----------------------'
    ' LIMPA DADOS PESSOAIS '
    '----------------------'
    Private Sub limpar_gb_dados_pessoais() Handles txt_cpf.DoubleClick
        Try
            With Me
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .txt_sobrenome.Clear()
                .dtp_nascimento.Value = Now
                .cmb_sexo.Text = ""
                foto_path = fotos_default & foto_perfil
                .pb_foto.Load(foto_path)
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar o cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    ''--------------------'
    '' LIMPA AUTENTICAÇÃO '
    ''--------------------'
    'Private Sub limpar_gb_autenticacao() Handles txt_usuario.DoubleClick
    '    Try
    '        With Me
    '            .txt_usuario.Clear()
    '            .txt_senha.Clear()
    '            .txt_senha_repete.Clear()
    '        End With
    '    Catch ex As Exception
    '        MsgBox("Erro ao limpar o cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
    '    End Try
    'End Sub

    '----------------'
    ' LIMPA ENDEREÇO '
    '----------------'
    Private Sub limpar_gb_endereco() Handles txt_cep.DoubleClick
        Try
            With Me
                .txt_cep.Clear()
                .txt_logradouro.Clear()
                .txt_numero.Clear()
                .txt_complemento.Clear()
                .txt_uf.Clear()
                .txt_bairro.Clear()
                .txt_cidade.Clear()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar o cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    '---------------'
    ' LIMPA CONTATO '
    '---------------'
    Private Sub limpar_gb_contato() Handles txt_celular.DoubleClick, txt_email.DoubleClick
        Try
            With Me
                .txt_celular.Clear()
                .txt_email.Clear()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar o cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    '------------'
    ' LIMPA TUDO '
    '------------'
    Private Sub limpar_campos() Handles btn_limpar.Click
        txt_pesquisar.Clear()
        Call limpar_gb_dados_pessoais()
        'Call limpar_gb_autenticacao()
        Call limpar_gb_endereco()
        Call limpar_gb_contato()
        txt_cpf.Select()
    End Sub

    '----------------------------------------------------------'
    ' SELECIONA E CARREGA UMA FOTO NA GROUP BOX DADOS PESSOAIS '
    '----------------------------------------------------------'
    Private Sub carregar_foto() Handles pb_foto.Click, pb_foto.DoubleClick
        Try
            With janela_selecionar_foto
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\recursos\fotos\clientes"
                If txt_cpf.Text = "" Then
                    .FileName = ""
                End If
                .ShowDialog()
                foto_path = .FileName
                pb_foto.Load(foto_path)
                MsgBox("Foto carregada com sucesso.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End With
        Catch ex As Exception
            MsgBox("Não consegui carregar essa foto!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    '-------------------------'
    ' VALIDA O FORMATO DO CEP '
    '-------------------------'
    Private Function cep_completo() As Boolean
        cep = Regex.Replace(txt_cep.Text, "[^0-9]", "").ToString()
        If Len(cep) = 8 Then
            Return True
        Else
            Return False
        End If
    End Function

    '----------------'
    ' ATUALIZA O CEP '
    '----------------'
    Private Sub atualizar_cep() Handles txt_cep.Leave
        If txt_cep.Text <> "" Then
            If cep_completo() Then
                qry = "SELECT * FROM tb_cep WHERE cep='" & txt_cep.Text & "'"
                rs = db.Execute(qry)
                If rs.EOF Then
                    MsgBox("CEP inválido.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CEP NÃO ENCONTRADO")
                    txt_cep.Clear()
                    txt_cep.Select()
                Else
                    txt_logradouro.Text = rs(1).Value
                    txt_bairro.Text = rs(3).Value
                    txt_cidade.Text = rs(2).Value
                    txt_uf.Text = rs(4).Value
                End If
            Else
                MsgBox("O CEP está incompleto.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                txt_cep.Clear()
                txt_cep.Select()
            End If
        End If
    End Sub

    '-----------------'
    ' CORRIGE TXT_CPF '
    '-----------------'
    Private Sub corrigir_txt_cpf() Handles txt_cpf.Leave
        txt_cpf.Text = Regex.Replace(txt_cpf.Text, "[^0-9]", "").ToString().PadLeft(11, "0")
        cpf = Regex.Replace(txt_cpf.Text, "[^0-9]", "").ToString().PadLeft(11, "0")
    End Sub

    '-------------'
    ' VALIDA DATA '
    '-------------'
    Private Function data_permitida()
        Dim data_minima, data_selecionada As Date
        data_minima = DateSerial(Year(Today) - 18, Month(Today), DateAndTime.Day(Today))
        data_selecionada = DateSerial(Year(dtp_nascimento.Value), Month(dtp_nascimento.Value), DateAndTime.Day(dtp_nascimento.Value))
        If data_selecionada > data_minima Then
            Return False
        Else
            Return True
        End If
    End Function

    '-------------'
    ' VALIDA SEXO '
    '-------------'
    Private Sub validar_sexo() Handles cmb_sexo.SelectedIndexChanged
        sexo = cmb_sexo.Text.ToString().ToLower()
        If Len(sexo) > 0 Then
            sexo = sexo(0)
        Else
            sexo = ""
        End If
    End Sub

    '-----------------------------------------------'
    ' VERIFICA SE GB_DADOS_PESSOAIS ESTÁ PREENCHIDA '
    '-----------------------------------------------'
    Private Sub verificar_gb_dados_pessoais()
        Call corrigir_txt_cpf()
        If cpf = "" Or cpf = "00000000000" Then
            MsgBox("Preencha um CPF válido.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            txt_cpf.Select()
            txt_cpf.SelectAll()
        ElseIf Not data_permitida() Then
            MsgBox("A data de nascimento tem de ter ocorrido há pelo menos 18 anos.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            dtp_nascimento.Select()
        ElseIf txt_nome.TextLength < 3 Or txt_nome.TextLength > 20 Then
            MsgBox("Preencha um nome com 3 a 20 caracteres.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            txt_nome.Select()
            txt_nome.SelectAll()
        ElseIf txt_sobrenome.TextLength < 3 Or txt_sobrenome.TextLength > 20 Then
            MsgBox("Preencha um sobrenome com 3 a 20 caracteres.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            txt_sobrenome.Select()
            txt_sobrenome.SelectAll()
        Else
            gbDPOk = True
        End If
    End Sub

    ''----------------------------------------'
    '' MOSTRA/OCULTA OS CARACTERES DAS SENHAS '
    ''----------------------------------------'
    'Private Sub mascarar_senhas() Handles ckb_senhas.CheckedChanged
    '    If ckb_senhas.Checked Then
    '        txt_senha.PasswordChar = ""
    '        txt_senha_repete.PasswordChar = ""
    '    Else
    '        txt_senha.PasswordChar = "*"
    '        txt_senha_repete.PasswordChar = "*"
    '    End If
    'End Sub

    ''---------------------------------------------'
    '' VERIFICA SE GB_AUTENTICACAO ESTÁ PREENCHIDA '
    ''---------------------------------------------'
    'Private Sub verificar_gb_autenticacao()
    '    If gbDPOk Then
    '        gbAutOk = False
    '        If txt_usuario.TextLength < 3 Or txt_usuario.TextLength > 20 Then
    '            MsgBox("Informe um nome de usuário com 3 a 20 caracteres.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
    '            txt_usuario.Select()
    '            txt_usuario.SelectAll()
    '        ElseIf txt_senha.TextLength < 8 Or txt_senha.TextLength > 20 Then
    '            MsgBox("Informe uma senha com 8 a 20 caracteres.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
    '            txt_senha.Select()
    '            txt_senha.SelectAll()
    '        ElseIf txt_senha_repete.TextLength < 8 Or txt_senha_repete.TextLength > 20 Then
    '            MsgBox("Repita a senha com 8 a 20 caracteres.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
    '            txt_senha_repete.Select()
    '            txt_senha_repete.SelectAll()
    '        ElseIf txt_senha.Text <> txt_senha_repete.Text Then
    '            MsgBox("As senhas não conferem.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
    '            txt_senha.Clear()
    '            txt_senha_repete.Clear()
    '            txt_senha.Select()
    '        Else
    '            gbAutOk = True
    '        End If
    '    End If
    'End Sub

    '---------------------------------------------'
    ' VERIFICA SE GB_ENDERECO ESTÁ PREENCHIDA '
    '---------------------------------------------'
    Private Sub verificar_gb_endereco()
        If gbDPOk Then
            gbEndOk = False
            If cep_completo() Then
                gbEndOk = True
            Else
                MsgBox("Digite um CEP com 8 dígitos.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                txt_cep.Clear()
                txt_cep.Select()
            End If
        End If
    End Sub

    '-----------------------------------'
    ' VALIDA O FORMATO DO Nº DE CELULAR '
    '-----------------------------------'
    Private Function celular_completo() As Boolean
        celular = Regex.Replace(txt_celular.Text, "[^0-9]", "").ToString()
        If Len(celular) = 11 Then
            Return True
        Else
            Return False
        End If
    End Function

    '---------------------------'
    ' VALIDA CELULAR ATUALIZADO '
    '---------------------------'
    Private Sub celular_atualizado() Handles txt_celular.Leave
        Call celular_completo()
        If celular <> "" Then
            If Not celular_completo() Then
                MsgBox("Digite os 11 dígitos do celular.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                txt_celular.Clear()
                txt_celular.Select()
            End If
        End If
    End Sub

    '----------------------------'
    ' VALIDA O FORMATO DO E-MAIL '
    '----------------------------'
    Private Function email_completo() As Boolean
        arroba = Regex.Replace(txt_email.Text, "[^@]", "").ToString()
        If arroba = "@" Then
            Return True
        Else
            Return False
        End If
    End Function

    '----------------------------------------'
    ' VERIFICA SE GB_CONTATO ESTÁ PREENCHIDA '
    '----------------------------------------'
    Private Sub verificar_gb_contato()
        If gbEndOk Then
            gbConOk = False
            If celular_completo() Then
                gbConOk = True
            ElseIf email_completo Then
                gbConOk = True
            Else
                gbConOk = False
                MsgBox("Informe um nº de celular ou um endereço de e-mail (ou ambos).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                txt_celular.Select()
            End If
        End If
    End Sub

    '---------------------------------------------------'
    ' VERIFICA SE TODAS AS GROUPBOXES ESTÃO PREENCHIDAS '
    '---------------------------------------------------'
    Private Sub verificar_groupboxes() Handles btn_salvar_topo.Click, btn_salvar_base.Click
        Dim resposta As String
        Call verificar_gb_dados_pessoais()
        'Call verificar_gb_autenticacao()
        Call verificar_gb_endereco()
        Call verificar_gb_contato()
        If gbDPOk And gbEndOk And gbConOk Then 'todas as groupboxes ATIVAS foram devidamente preenchidas (esta parte do código NÃO troca a ativação do perfil)
            'Verifica se o CPF a ser cadastrado como cliente já está cadastrado como funcionario,
            'gerente ou administrador (ativou ou inativo):
            qry = "SELECT * FROM tb_usuarios WHERE cpf='" & cpf & "'"
            rs = db.Execute(qry)
            If Not rs.EOF Then
                MsgBox("Esse CPF não pode ser cadastrado como cliente porque pertence a um colaborador ou ex-colaborador.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            Else 'o CPF não é de colaborador nem ex-colaborador
                'Verifica se o CPF informado já está cadastrado como cliente:
                qry = "SELECT * FROM tb_clientes WHERE cpf='" & cpf & "'"
                rs = db.Execute(qry)
                If Not rs.EOF Then 'o CPF do cliente realmente já existe no banco
                    resposta = MsgBox("Esse CPF já está cadastrado como cliente. Você está tentando alterar os dados cadastrais?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ERRO")
                    If resposta = vbYes Then 'atualizar o CPF que já está cadastrado como cliente
                        qry = "UPDATE tb_clientes SET nome='" & txt_nome.Text.ToUpper & "',sobrenome='" &
                            txt_sobrenome.Text.ToUpper & "', nascimento='" & dtp_nascimento.Value.Date & "',sexo='" &
                            sexo & "',foto='" & foto_path & "',cep='" & cep & "',numero='" &
                            txt_numero.Text.ToUpper & "',complemento='" & txt_complemento.Text.ToUpper & "',celular='" &
                            celular & "',email='" & txt_email.Text.ToUpper & "' WHERE cpf='" & cpf & "'"
                        Try
                            db.Execute(qry)
                            MsgBox("Cadastro atualizado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            Call popular_dgv_cadastros()
                        Catch ex As Exception
                            MsgBox("Não consegui atualizar o cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                        End Try
                    Else
                        MsgBox("Salvamento abortado.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                        txt_cpf.Select()
                        txt_cpf.SelectAll()
                    End If
                Else 'o CPF informado ainda não existe (como cliente) no banco
                    qry = "INSERT INTO tb_clientes
                        (cpf,nome,sobrenome,nascimento,sexo,foto,ativo,cep,numero,complemento,celular,email)
                        VALUES ('" & cpf & "','" & txt_nome.Text.ToUpper & "','" & txt_sobrenome.Text.ToUpper & "','" &
                        dtp_nascimento.Value.Date & "','" & sexo & " ','" & foto_path & "','n','" & cep & "','" &
                        txt_numero.Text.ToUpper & "','" & txt_complemento.Text.ToUpper & "','" & celular & "','" & txt_email.Text.ToUpper & "')"
                    Try
                        db.Execute(qry)
                        MsgBox("Cadastro criado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Call popular_dgv_cadastros()
                    Catch ex As Exception
                        MsgBox("Não consegui criar o cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                    End Try
                End If
            End If
        End If
    End Sub

    '-------------------------'
    ' POPULA O DATA GRID VIEW '
    '-------------------------'
    Private Sub popular_dgv_cadastros() Handles txt_pesquisar.TextChanged, cmb_pesquisar.SelectedIndexChanged
        Dim cont As Short
        Dim ativado As Boolean
        Try
            With dgv_cadastros
                cont = 0
                .Rows.Clear()
                If cmb_pesquisar.Text <> "" And txt_pesquisar.Text <> "" Then
                    qry = "SELECT * FROM tb_clientes WHERE " & cmb_pesquisar.Text.ToLower & " LIKE '%" & txt_pesquisar.Text & "%'"
                Else
                    qry = "SELECT * FROM tb_clientes ORDER BY nome ASC"
                End If
                rs = db.Execute(qry)
                Do While Not rs.EOF
                    cont = cont + 1
                    If rs(7).Value = "s" Then
                        ativado = True
                    Else
                        ativado = False
                    End If
                    .Rows.Add(cont, rs(0).Value, rs(1).Value, rs(2).Value, ativado) 'nº, id, cpf, nome, ativado
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Algo deu errado...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Exit Sub
        End Try
    End Sub

    '---------------------------------------'
    ' DES/ATIVA CADASTROS VIA DGV_CADASTROS '
    '---------------------------------------'
    Private Sub alterar_ativacao() Handles dgv_cadastros.CellClick
        Dim dgvCpf, dgvNome, resposta As String
        Dim dgvAtivo, dgvAtivoClicado As Boolean
        Dim dgvId As Integer
        Dim rsAtivo As Char

        dgvId = dgv_cadastros.CurrentRow.Cells(1).Value
        dgvCpf = dgv_cadastros.CurrentRow.Cells(2).Value
        dgvNome = dgv_cadastros.CurrentRow.Cells(3).Value
        dgvAtivo = dgv_cadastros.CurrentRow.Cells(4).Value
        dgvAtivoClicado = dgv_cadastros.CurrentRow.Cells(4).Selected

        Call limpar_campos()
        qry = "SELECT * FROM tb_clientes WHERE id='" & dgvId & "' and cpf='" & dgvCpf & "'"
        rs = db.Execute(qry)
        'popula gb_dados_pessoais
        txt_cpf.Text = rs(1).Value
        txt_nome.Text = rs(2).Value
        txt_sobrenome.Text = rs(3).Value
        dtp_nascimento.Value = rs(4).Value
        Select Case rs(5).Value
            Case "m"
                cmb_sexo.Text = "Masculino"
            Case "f"
                cmb_sexo.Text = "Feminino"
            Case "i"
                cmb_sexo.Text = "Intersexo"
            Case Else
                cmb_sexo.Text = ""
        End Select
        foto_path = rs(6).Value
        Try
            pb_foto.Load(foto_path)
        Catch ex As Exception
            pb_foto.Load(fotos_default & foto_perfil)
        End Try
        'popula gb_endereco
        txt_cep.Text = rs(8).Value
        txt_numero.Text = rs(9).Value
        txt_complemento.Text = rs(10).Value
        'popula gb_contato
        txt_celular.Text = rs(11).Value
        txt_email.Text = rs(12).Value
        Call atualizar_cep()

        If dgvCpf = meu_cpf Then
            MsgBox("Você não pode alterar a ativação da sua própria conta de cliente!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERRO")
            Call popular_dgv_cadastros()
        Else 'não estou tentando alterar meu próprio cadastro de cliente
            Try
                If dgvAtivoClicado Then
                    resposta = MsgBox("Confirma alterar a ativação desta conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALTERAR?")
                    If resposta = vbYes Then
                        If dgvAtivo Then
                            rsAtivo = "n"
                        Else
                            rsAtivo = "s"
                        End If
                        qry = "UPDATE tb_clientes SET ativo='" & rsAtivo & "' WHERE id='" & dgvId & "' and cpf='" & dgvCpf & "'"
                        db.Execute(qry)
                    End If
                    Call popular_dgv_cadastros()
                End If
            Catch ex As Exception
                MsgBox("Não consegui alterar a ativação desta conta.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End If
    End Sub

    '--------------------'
    ' FORMULÁRIO FECHADO '
    '--------------------'
    Private Sub fechar_frm_cad_cliente() Handles MyBase.FormClosed
        cmb_pesquisar.Items.Clear()
        cmb_sexo.Items.Clear()
    End Sub
End Class