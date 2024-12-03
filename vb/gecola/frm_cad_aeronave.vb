Imports System.Runtime.ConstrainedExecution
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports Microsoft
Public Class frm_cad_aeronave
    'gbIdOk (groupbox Identificação OK), gbCapOk (groupbox Capacidade OK)
    Public assentosOk, autonomiaOk, diariaOk, gbIdOk, gbCapOk, pesominOk, pesomaxOk, velocidadeOk As Boolean
    'qryC (query do combustível), qryJ (query de JOIN), qryO (query da operação), qryR (query da regra), qryT (query do tipo)
    Public ano, diaria, matricula, qryC, qryJ, qryO, qryR, qryT As String
    'rsC (recordset do combustível), rsO (recordset da operação), rsR (recordset da regra), rsT (recordset do tipo)
    Public rsC, rsO, rsR, rsT As New ADODB.Recordset
    Public foto_perfil As String = "aeronave.png"

    '-------------------'
    ' FORMULÁRIO ABERTO '
    '-------------------'
    Private Sub abrir_frm_cad_aeronave() Handles MyBase.Load
        gbIdOk = False
        gbCapOk = False
        MyBase.AutoSize = True
        Call limpar_campos()
        Call carregar_usuario_e_data(lbl_usuario_e_data)
        Call popular_cmb_pesquisar()
        Call popular_cmb_tipo()
        Call popular_cmb_combustivel()
        Call popular_cmb_operacao()
        Call popular_cmb_regra()
        Call popular_dgv_cadastros()
    End Sub

    '----------------------'
    ' POPULA CMB_PESQUISAR '
    '----------------------'
    Private Sub popular_cmb_pesquisar()
        Try
            With cmb_pesquisar.Items
                .Add("")
                .Add("MATRICULA")
                .Add("TIPO")
                .Add("MODELO")
                .Add("ASSENTOS")
                .Add("VELOCIDADE")
                .Add("AUTONOMIA")
                .Add("OPERACAO")
                .Add("REGRA")
                .Add("DIARIA")
            End With
            cmb_pesquisar.SelectedIndex = 0
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    '-----------------'
    ' POPULA CMB_TIPO '
    '-----------------'
    Private Sub popular_cmb_tipo()
        Try
            cmb_tipo.Items.Add("")
            qry = "SELECT descricao FROM tb_aer_tipo"
            rs = db.Execute(qry)
            Do While Not rs.EOF
                cmb_tipo.Items.Add(UCase(rs("descricao").Value.ToString()))
                rs.MoveNext()
            Loop
            cmb_tipo.Text = ""
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    '------------------------'
    ' POPULA CMB_COMBUSTIVEL '
    '------------------------'
    Private Sub popular_cmb_combustivel()
        Try
            cmb_combustivel.Items.Add("")
            qry = "SELECT descricao FROM tb_aer_combustivel"
            rs = db.Execute(qry)
            Do While Not rs.EOF
                cmb_combustivel.Items.Add(UCase(rs("descricao").Value.ToString()))
                rs.MoveNext()
            Loop
            cmb_combustivel.Text = ""
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    '---------------------'
    ' POPULA CMB_OPERACAO '
    '---------------------'
    Private Sub popular_cmb_operacao()
        Try
            cmb_operacao.Items.Add("")
            qry = "SELECT descricao FROM tb_aer_operacao"
            rs = db.Execute(qry)
            Do While Not rs.EOF
                cmb_operacao.Items.Add(UCase(rs("descricao").Value.ToString()))
                rs.MoveNext()
            Loop
            cmb_operacao.Text = ""
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    '------------------'
    ' POPULA CMB_REGRA '
    '------------------'
    Private Sub popular_cmb_regra()
        Try
            cmb_regra.Items.Add("")
            qry = "SELECT descricao FROM tb_aer_regra"
            rs = db.Execute(qry)
            Do While Not rs.EOF
                cmb_regra.Items.Add(UCase(rs("descricao").Value.ToString()))
                rs.MoveNext()
            Loop
            cmb_regra.Text = ""
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    '---------------------'
    ' LIMPA IDENTIFICACAO '
    '---------------------'
    Private Sub limpar_gb_identificacao() Handles txt_matricula.DoubleClick
        Try
            With Me
                .txt_matricula.Clear()
                foto_path = fotos_default & foto_perfil
                .pb_foto.Load(foto_path)
                cmb_tipo.Text = ""
                txt_fabricante.Clear()
                txt_modelo.Clear()
                cmb_combustivel.Text = ""
                txt_ano.Clear()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar o cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    '------------------'
    ' LIMPA CAPACIDADE '
    '------------------'
    Private Sub limpar_gb_capacidade() Handles txt_assentos.DoubleClick
        Try
            With Me
                .txt_assentos.Clear()
                .txt_pesomin.Clear()
                .txt_pesomax.Clear()
                .txt_velocidade.Clear()
                .txt_autonomia.Clear()
                .cmb_operacao.Text = ""
                .cmb_regra.Text = ""
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
        Call limpar_gb_identificacao()
        Call limpar_gb_capacidade()
        txt_diaria.Clear()
        txt_matricula.Select()
    End Sub

    '-------------------'
    ' CORRIGE MATRÍCULA '
    '-------------------'
    Private Sub corrigir_matricula() Handles txt_matricula.Leave
        txt_matricula.Text = Regex.Replace(txt_matricula.Text, "[^A-Z]", "")
        matricula = Regex.Replace(txt_matricula.Text, "[^A-Z]", "")
        If matricula = "" Then
            txt_matricula.Clear()
            Exit Sub
        ElseIf Len(matricula) <> 5 Or (Mid(matricula, 1, 2) <> "PP" And Mid(matricula, 1, 2) <> "PR" And Mid(matricula, 1, 2) <> "PS" And Mid(matricula, 1, 2) <> "PT" And Mid(matricula, 1, 2) <> "PU") Then
            txt_matricula.Clear()
            MsgBox("A matrícula tem de ter somente 5 letras maiúsculas e as duas primeiras têm de ser PP, PR, PS, PT ou PU.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            txt_matricula.Select()
        End If
    End Sub

    '---------------------------------------------------------'
    ' SELECIONA E CARREGA UMA FOTO NA GROUP BOX IDENTIFICAÇÃO '
    '---------------------------------------------------------'
    Private Sub carregar_foto() Handles pb_foto.Click, pb_foto.DoubleClick
        Try
            With janela_selecionar_foto
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\recursos\fotos\aeronaves"
                If txt_matricula.Text = "" Then
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

    '----------------------------'
    ' VALIDA O ANO DE FABRICAÇÃO '
    '----------------------------'
    Private Sub ano_valido() Handles txt_ano.Leave
        ano = Regex.Replace(txt_ano.Text, "[^0-9]", "").ToString()
        If ano = "" Then
            txt_ano.Text = ""
            Exit Sub
        ElseIf CInt(ano) <1900 Or CInt(ano) > Year(Now) Then
            MsgBox("Informe um ano entre 1900 e " & Year(Now) & " (inclusive).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            ano = ""
            txt_ano.Text = ""
            txt_ano.Select()
        End If
    End Sub

    '----------------------------------------------'
    ' VERIFICA SE GB_IDENTIFICACAO ESTÁ PREENCHIDA '
    '----------------------------------------------'
    Private Sub verificar_gb_identificacao()
        Call corrigir_matricula()
        If Len(matricula) <> 5 Then
            MsgBox("Preencha uma matrícula válida.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            txt_matricula.Select()
            txt_matricula.SelectAll()
        ElseIf cmb_tipo.Text = "" Then
            MsgBox("Informe o tipo da aeronave.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            cmb_tipo.Select()
        ElseIf txt_fabricante.TextLength <3 Or txt_fabricante.TextLength > 30 Then
            MsgBox("Preencha um nome de fabricante com 3 a 30 caracteres.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            txt_fabricante.Select()
            txt_fabricante.SelectAll()
        ElseIf txt_modelo.TextLength <3 Or txt_modelo.TextLength > 30 Then
            MsgBox("Preencha um modelo de aeronave com 3 a 30 caracteres.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            txt_modelo.Select()
            txt_modelo.SelectAll()
        ElseIf cmb_combustivel.Text = "" Then
            MsgBox("Informe o tipo de combustível que essa aeronave utiliza.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            cmb_combustivel.Select()
        Else
            Call ano_valido()
            If ano = "" Then
                MsgBox("É necessário informar o ano de fabricação da aeronave.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                txt_ano.Select()
            Else
                gbIdOk = True
            End If
        End If
    End Sub

    '-----------------'
    ' VALIDA ASSENTOS '
    '-----------------'
    Private Sub validar_assentos() Handles txt_assentos.Leave
        Dim assentos As String
        assentos = Regex.Replace(txt_assentos.Text, "[^0-9]", "").ToString
        If assentos = "" Then
            txt_assentos.Text = ""
            assentosOk = False
            Exit Sub
        ElseIf CShort(assentos) <2 Or CShort(assentos) > 2000 Then
            MsgBox("A quantidade de assentos tem de ser um número inteiro entre 2 e 2000 (inclusive).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            assentosOk = False
            txt_assentos.Text = ""
            txt_assentos.Select()
        Else
            assentosOk = True
        End If
    End Sub

    '--------------------'
    ' VALIDA PESO MÍNIMO '
    '--------------------'
    Private Sub validar_pesomin() Handles txt_pesomin.Leave
        Dim pesomin As String
        pesomin = Regex.Replace(txt_pesomin.Text, "[^0-9]", "").ToString
        If pesomin = "" Then
            txt_pesomin.Text = ""
            pesominOk = False
            Exit Sub
        ElseIf CInt(pesomin) <40 Or CInt(pesomin) > 400000 Then
            MsgBox("O peso mínimo tem de ser um número inteiro entre 40 e 400.000 (inclusive).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            pesominOk = False
            txt_pesomin.Text = ""
            txt_pesomin.Select()
        Else
            pesominOk = True
        End If
    End Sub

    '--------------------'
    ' VALIDA PESO MÁXIMO '
    '--------------------'
    Private Sub validar_pesomax() Handles txt_pesomax.Leave
        Dim pesomax As String
        pesomax = Regex.Replace(txt_pesomax.Text, "[^0-9]", "").ToString
        If pesomax = "" Then
            txt_pesomax.Text = ""
            pesomaxOk = False
            Exit Sub
        ElseIf CInt(pesomax) <100 Or CInt(pesomax) > 2000000 Then
            MsgBox("O peso máximo tem de ser um número inteiro entre 100 e 2.000.000 (inclusive).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            pesomaxOk = False
            txt_pesomax.Text = ""
            txt_pesomax.Select()
        Else
            pesomaxOk = True
        End If
    End Sub

    '-------------------'
    ' VALIDA VELOCIDADE '
    '-------------------'
    Private Sub validar_velocidade() Handles txt_velocidade.Leave
        Dim velocidade As String
        velocidade = Regex.Replace(txt_velocidade.Text, "[^0-9]", "").ToString
        If velocidade = "" Then
            txt_velocidade.Text = ""
            velocidadeOk = False
            Exit Sub
        ElseIf CInt(velocidade) <10 Or CInt(velocidade) > 20000 Then
            MsgBox("A velocidade máxima tem de ser um número inteiro entre 10 e 20.000 (inclusive).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            velocidadeOk = False
            txt_velocidade.Text = ""
            txt_velocidade.Select()
        Else
            velocidadeOk = True
        End If
    End Sub

    '------------------'
    ' VALIDA AUTONOMIA '
    '------------------'
    Private Sub validar_autonomia() Handles txt_autonomia.Leave
        Dim autonomia As String
        autonomia = Regex.Replace(txt_autonomia.Text, "[^0-9]", "").ToString
        If autonomia = "" Then
            txt_autonomia.Text = ""
            autonomiaOk = False
            Exit Sub
        ElseIf CInt(autonomia) <100 Or CInt(autonomia) > 30000 Then
            MsgBox("A autonomia máxima tem de ser um número inteiro entre 100 e 30.000 (inclusive).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            autonomiaOk = False
            txt_autonomia.Text = ""
            txt_autonomia.Select()
        Else
            autonomiaOk = True
        End If
    End Sub

    '---------------'
    ' VALIDA DIÁRIA '
    '---------------'
    Private Sub validar_diaria() Handles txt_diaria.Leave
        diaria = Regex.Replace(txt_diaria.Text, "[^0-9,.]", "")
        If diaria = "" Then
            MsgBox("Você não informou o valor da diária.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            diariaOk = False
            txt_diaria.Text = ""
            Exit Sub
        ElseIf CInt(diaria) <100 Or CInt(diaria) > 32000 Then
            MsgBox("O valor da diária tem de ser um número inteiro entre 100 e 32.000 (inclusive).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            diariaOk = False
            txt_diaria.Text = ""
            txt_diaria.Select()
        Else
            diariaOk = True
        End If
    End Sub

    '-------------------------------------------'
    ' VERIFICA SE GB_CAPACIDADE ESTÁ PREENCHIDA '
    '-------------------------------------------'
    Private Sub verificar_gb_capacidade()
        If gbIdOk Then
            gbCapOk = False
            Call validar_assentos()
            If Not assentosOk Then
                MsgBox("Informe a quantidade de assentos da aeronave (mínimo 2, máximo 2000).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                txt_assentos.Select()
                txt_assentos.SelectAll()
            Else
                Call validar_pesomin()
                If Not pesominOk Then
                    MsgBox("Informe o peso mínimo (BOW) da aeronave (mínimo 40, máximo 400.000).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                    txt_pesomin.Select()
                    txt_pesomin.SelectAll()
                Else
                    Call validar_pesomax()
                    If Not pesomaxOk Then
                        MsgBox("Informe o peso máximo (MTOW) da aeronave (mínimo 100, máximo 2.000.000).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                        txt_pesomax.Select()
                        txt_pesomax.SelectAll()
                    Else
                        Call validar_velocidade()
                        If Not velocidadeOk Then
                            MsgBox("Informe a velocidade máxima da aeronave (mínimo 10, máximo 20.000).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                            txt_velocidade.Select()
                            txt_velocidade.SelectAll()
                        Else
                            Call validar_autonomia()
                            If Not autonomiaOk Then
                                MsgBox("Informe a autonomia máxima da aeronave (mínimo 100, máximo 30.000).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                                txt_autonomia.Select()
                                txt_autonomia.SelectAll()
                            ElseIf cmb_operacao.Text = "" Then
                                MsgBox("Informe a modalidade de operação (diurna ou noturna) para a qual a aeronave está homologada.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                                cmb_operacao.Select()
                                cmb_operacao.SelectAll()
                            ElseIf cmb_regra.Text = "" Then
                                MsgBox("Informe o tipo de regra de voo (visual, por instrumentos ou ambas) para o qual a aeronave está homologada.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                                cmb_regra.Select()
                                cmb_regra.SelectAll()
                            Else
                                gbCapOk = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    '---------------------------------------------------'
    ' VERIFICA SE TODAS AS GROUPBOXES ESTÃO PREENCHIDAS '
    '---------------------------------------------------'
    Private Sub verificar_groupboxes() Handles btn_salvar_topo.Click, btn_salvar_base.Click
        Dim resposta As String
        Call verificar_gb_identificacao()
        Call verificar_gb_capacidade()
        Call validar_diaria()

        If gbIdOk And gbCapOk And diariaOk Then 'todas as groupboxes ATIVAS foram devidamente preenchidas (esta parte do código NÃO troca a ativação da aeronave)
            'Executa as queries das tabelas auxiliares
            Try
                qryT = "SELECT tipo from tb_aer_tipo WHERE descricao='" & cmb_tipo.Text & "'"
                rsT = db.Execute(qryT)
            Catch ex As Exception
                MsgBox("Falha ao tentar buscar o código de tipo de aeronave.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
            Try
                qryC = "SELECT combustivel from tb_aer_combustivel WHERE descricao='" & cmb_combustivel.Text & "'"
                rsC = db.Execute(qryC)
            Catch ex As Exception
                MsgBox("Falha ao tentar buscar o código de tipo de combustível.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
            Try
                qryO = "SELECT operacao from tb_aer_operacao WHERE descricao='" & cmb_operacao.Text & "'"
                rsO = db.Execute(qryO)
            Catch ex As Exception
                MsgBox("Falha ao tentar buscar o código de tipo de operação da aeronave.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
            Try
                qryR = "SELECT regra from tb_aer_regra WHERE descricao='" & cmb_regra.Text & "'"
                rsR = db.Execute(qryR)
            Catch ex As Exception
                MsgBox("Falha ao tentar buscar o código de regra de voo da aeronave.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try

            'Verifica se a matrícula informada já está cadastrada:
            Try
                qry = "SELECT matricula FROM tb_aeronaves WHERE matricula='" & matricula & "'"
                rs = db.Execute(qry)
            Catch ex As Exception
                MsgBox("Falha ao tentar buscar a matrícula informada.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
            If Not rs.EOF Then 'a matrícula de aeronave realmente já existe no banco
                resposta = MsgBox("Essa matrícula de aeronave já está cadastrada. Você está tentando alterar os dados cadastrais?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ERRO")
                If resposta = vbYes Then 'atualizar a matrícula de aeronave que já está cadastrada
                    'Busca os códigos de tipo de aeronave, combustível, modalidade de operação e de regra de voo
                    Try
                        qry = "UPDATE tb_aeronaves SET matricula='" & matricula.ToUpper & "', foto='" & foto_path & "',tipo='" &
                            rsT(0).Value & "', fabricante='" & txt_fabricante.Text.ToUpper & "',modelo='" &
                            txt_modelo.Text.ToUpper & "',combustivel='" & rsC(0).Value & "',ano='" & CShort(ano) & "',assentos='" &
                            CShort(txt_assentos.Text) & "',pesomin='" & CInt(txt_pesomin.Text) & "',pesomax='" &
                            CInt(txt_pesomax.Text) & "',velocidade='" & CShort(txt_velocidade.Text) & "',autonomia='" &
                            CShort(txt_autonomia.Text) & "',operacao='" & rsO(0).Value & "',regra='" &
                            rsR(0).Value & "',diaria='" & CShort(diaria) & "' WHERE matricula='" & matricula.ToUpper & "'"
                        db.Execute(qry)
                        MsgBox("Cadastro atualizado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Call popular_dgv_cadastros()
                    Catch ex As Exception
                        MsgBox("Não consegui atualizar o cadastro dessa aeronave.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                    End Try
                Else
                    MsgBox("Salvamento abortado.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    txt_matricula.Select()
                    txt_matricula.SelectAll()
                End If
            Else 'a matrícula informada ainda não existe no banco
                Try
                    qry = "INSERT INTO tb_aeronaves
                    (matricula,foto,tipo,fabricante,modelo,combustivel,ano,assentos,pesomin,pesomax,velocidade,autonomia,operacao,regra,diaria,ativo)
                    VALUES ('" & matricula.ToUpper & "','" & foto_path & "','" & rsT(0).Value & "','" & txt_fabricante.Text.ToUpper & "','" &
                    txt_modelo.Text.ToUpper & " ','" & rsC(0).Value & "','" & CShort(ano) & "','" & CShort(txt_assentos.Text) & "','" &
                    CInt(txt_pesomin.Text) & "','" & CInt(txt_pesomax.Text) & "','" & CShort(txt_velocidade.Text) & "','" &
                    CShort(txt_autonomia.Text) & "','" & rsO(0).Value & "','" & rsR(0).Value & "','" & CShort(txt_diaria.Text) & "','n')"
                    db.Execute(qry)
                    MsgBox("Cadastro criado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Call popular_dgv_cadastros()
                Catch ex As Exception
                    MsgBox("Não consegui criar o cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                End Try
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
                    If cmb_pesquisar.Text = "TIPO" Or cmb_pesquisar.Text = "OPERACAO" Or cmb_pesquisar.Text = "REGRA" Then
                        qry = "SELECT matricula,tb_aer_tipo.descricao,modelo,assentos,velocidade,autonomia,tb_aer_operacao.descricao,tb_aer_regra.descricao,diaria,ativo
                        FROM tb_aeronaves
                        JOIN tb_aer_tipo
                        ON tb_aeronaves.tipo=tb_aer_tipo.tipo
                        JOIN tb_aer_operacao
                        ON tb_aeronaves.operacao=tb_aer_operacao.operacao
                        JOIN tb_aer_regra
                        ON tb_aeronaves.regra=tb_aer_regra.regra
                        WHERE tb_aer_" & cmb_pesquisar.Text.ToLower & ".descricao LIKE '%" & txt_pesquisar.Text & "%'"
                    Else
                        qry = "SELECT matricula,tb_aer_tipo.descricao,modelo,assentos,velocidade,autonomia,tb_aer_operacao.descricao,tb_aer_regra.descricao,diaria,ativo
                        FROM tb_aeronaves
                        JOIN tb_aer_tipo
                        ON tb_aeronaves.tipo=tb_aer_tipo.tipo
                        JOIN tb_aer_operacao
                        ON tb_aeronaves.operacao=tb_aer_operacao.operacao
                        JOIN tb_aer_regra
                        ON tb_aeronaves.regra=tb_aer_regra.regra
                        WHERE " & cmb_pesquisar.Text.ToLower & " LIKE '%" & txt_pesquisar.Text & "%'"
                    End If
                Else
                    qry = "SELECT matricula,tb_aer_tipo.descricao,modelo,assentos,velocidade,autonomia,tb_aer_operacao.descricao,tb_aer_regra.descricao,diaria,ativo
                        FROM tb_aeronaves
                        JOIN tb_aer_tipo
                        ON tb_aeronaves.tipo=tb_aer_tipo.tipo
                        JOIN tb_aer_operacao
                        ON tb_aeronaves.operacao=tb_aer_operacao.operacao
                        JOIN tb_aer_regra
                        ON tb_aeronaves.regra=tb_aer_regra.regra
                        ORDER BY matricula ASC"
                End If
                rs = db.Execute(qry)
                Do While Not rs.EOF
                    cont = cont + 1
                    If rs(9).Value = "s" Then
                        ativado = True
                    Else
                        ativado = False
                    End If
                    'nº, matrícula, tipo, modelo, assentos, velocidade, autonomia, operação, regra, diária, ativado
                    .Rows.Add(cont, rs(0).Value, rs(1).Value, rs(2).Value, rs(3).Value, rs(4).Value, rs(5).Value, rs(6).Value, rs(7).Value, rs(8).Value, ativado)
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
        Dim dgvMat, dgvTipo, dgvMod, dgvAss, dgvVel, dgvAut, dgvOpe, dgvReg, dgvDia, resposta As String
        Dim dgvAtivo, dgvAtivoClicado As Boolean
        Dim rsAtivo As Char

        dgvMat = dgv_cadastros.CurrentRow.Cells(1).Value
        dgvTipo = dgv_cadastros.CurrentRow.Cells(2).Value
        dgvMod = dgv_cadastros.CurrentRow.Cells(3).Value
        dgvAss = dgv_cadastros.CurrentRow.Cells(4).Value
        dgvVel = dgv_cadastros.CurrentRow.Cells(5).Value
        dgvAut = dgv_cadastros.CurrentRow.Cells(6).Value
        dgvOpe = dgv_cadastros.CurrentRow.Cells(7).Value
        dgvReg = dgv_cadastros.CurrentRow.Cells(8).Value
        dgvDia = dgv_cadastros.CurrentRow.Cells(9).Value
        dgvAtivo = dgv_cadastros.CurrentRow.Cells(10).Value
        dgvAtivoClicado = dgv_cadastros.CurrentRow.Cells(10).Selected

        Call limpar_campos()
        qry = "SELECT matricula,foto,tb_aer_tipo.descricao,fabricante,modelo,tb_aer_combustivel.descricao,ano,assentos,pesomin,pesomax,velocidade,autonomia,tb_aer_operacao.descricao,tb_aer_regra.descricao,diaria
            FROM tb_aeronaves
            JOIN tb_aer_tipo
            ON tb_aeronaves.tipo=tb_aer_tipo.tipo
            JOIN tb_aer_combustivel
            ON tb_aeronaves.combustivel=tb_aer_combustivel.combustivel
            JOIN tb_aer_operacao
            ON tb_aeronaves.operacao=tb_aer_operacao.operacao
            JOIN tb_aer_regra
            ON tb_aeronaves.regra=tb_aer_regra.regra
            WHERE matricula='" & dgvMat & "'"
        rs = db.Execute(qry)
        txt_matricula.Text = rs(0).Value
        foto_path = rs(1).Value
        Try
            pb_foto.Load(foto_path)
        Catch ex As Exception
            pb_foto.Load(fotos_default & foto_perfil)
        End Try
        cmb_tipo.Text = rs(2).Value
        txt_fabricante.Text = rs(3).Value
        txt_modelo.Text = rs(4).Value
        cmb_combustivel.Text = rs(5).Value
        txt_ano.Text = rs(6).Value
        txt_assentos.Text = rs(7).Value
        txt_pesomin.Text = rs(8).Value
        txt_pesomax.Text = rs(9).Value
        txt_velocidade.Text = rs(10).Value
        txt_autonomia.Text = rs(11).Value
        cmb_operacao.Text = rs(12).Value
        cmb_regra.Text = rs(13).Value
        txt_diaria.Text = rs(14).Value
        Try
            If dgvAtivoClicado Then
                resposta = MsgBox("Confirma alterar a ativação desta aeronave?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALTERAR?")
                If resposta = vbYes Then
                    If dgvAtivo Then
                        rsAtivo = "n"
                    Else
                        rsAtivo = "s"
                    End If
                    qry = "UPDATE tb_aeronaves SET ativo='" & rsAtivo & "' WHERE matricula='" & dgvMat & "'"
                    db.Execute(qry)
                End If
                Call popular_dgv_cadastros()
            End If
        Catch ex As Exception
            MsgBox("Não consegui alterar a ativação desta aeronave.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    '--------------------'
    ' FORMULÁRIO FECHADO '
    '--------------------'
    Private Sub fechar_frm_cad_aeronave() Handles MyBase.FormClosed
        cmb_pesquisar.Items.Clear()
        cmb_tipo.Items.Clear()
        cmb_combustivel.Items.Clear()
        cmb_operacao.Items.Clear()
        cmb_regra.Items.Clear()
    End Sub
End Class