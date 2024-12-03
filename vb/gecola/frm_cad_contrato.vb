Imports System.Runtime.ConstrainedExecution
Imports System.Runtime.InteropServices.ComTypes
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft
Public Class frm_cad_contrato
    Public foto_perfil As String = "contrato.png"

    '-------------------'
    ' FORMULÁRIO ABERTO '
    '-------------------'
    Private Sub abrir_frm_cad_contrato() Handles MyBase.Load
        MyBase.AutoSize = True
        Call limpar_campos()
        Call carregar_usuario_e_data(lbl_usuario_e_data)
        Call popular_cmb_pesquisar_quem()
        Call popular_cmb_pesquisar()
        Call popular_dgv_cadastros()
    End Sub

    '------------------'
    ' LIMPA GB_CLIENTE '
    '------------------'
    Private Sub limpar_gb_cliente() Handles btn_limpar_gb_cliente.Click
        Try
            With Me
                .txt_id.Clear()
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .txt_sobrenome.Clear()
                .pb_foto_cliente.Load(fotos_default & "cliente.png")
                Select Case meu_perfil
                    Case "f"
                        btn_cadastros_de_clientes.Enabled = True
                        btn_cadastros_de_aeronaves.Enabled = False
                    Case "g"
                        btn_cadastros_de_clientes.Enabled = False
                        btn_cadastros_de_aeronaves.Enabled = True
                    Case Else
                        btn_cadastros_de_clientes.Enabled = False
                        btn_cadastros_de_aeronaves.Enabled = False
                End Select
            End With
        Catch ex As Exception
            MsgBox("Não consegui limpar estes campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    '-------------------'
    ' LIMPA GB_AERONAVE '
    '-------------------'
    Private Sub limpar_gb_aeronave() Handles btn_limpar_gb_aeronave.Click
        Try
            With Me
                .txt_matricula.Clear()
                .txt_tipo.Clear()
                .txt_fabricante.Clear()
                .pb_foto_aeronave.Load(fotos_default & "aeronave.png")
                .txt_modelo.Clear()
                .txt_combustivel.Clear()
                .txt_ano.Clear()
                .txt_assentos.Clear()
                .txt_pesomin.Clear()
                .txt_pesomax.Clear()
                .txt_velocidade.Clear()
                .txt_autonomia.Clear()
                .txt_operacao.Clear()
                .txt_regra.Clear()
                .txt_diaria.Clear()
            End With
        Catch ex As Exception
            MsgBox("Não consegui limpar estes campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    '------------'
    ' LIMPA TUDO '
    '------------'
    Private Sub limpar_campos() Handles btn_cliente_limpar_campos.Click, btn_aeronave_limpar_campos.Click
        txt_pesquisar.Clear()
        Call limpar_gb_cliente()
        Call limpar_gb_aeronave()
        txt_diaria.Clear()
        cmb_pesquisar_quem.Select()
    End Sub

    '---------------------------'
    ' POPULA CMB_PESQUISAR_QUEM '
    '---------------------------'
    Private Sub popular_cmb_pesquisar_quem()
        Try
            With cmb_pesquisar_quem.Items
                .Add("")
                .Add("CLIENTE")
                .Add("AERONAVE")
            End With
            cmb_pesquisar_quem.SelectedIndex = 0
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    '----------------------'
    ' POPULA CMB_PESQUISAR '
    '----------------------'
    Private Sub popular_cmb_pesquisar() Handles cmb_pesquisar_quem.SelectedIndexChanged
        Dim x As Short
        Try
            With cmb_pesquisar.Items
                .Clear()
                .Add("")
                dgv_cadastros.Columns(0).Visible = True
                If cmb_pesquisar_quem.Text = "CLIENTE" Then
                    .Add("CPF")
                    .Add("NOME")
                    .Add("SOBRENOME")
                    With dgv_cadastros
                        For x = 1 To 4
                            .Columns(x).Visible = True
                        Next
                        For x = 5 To 15
                            .Columns(x).Visible = False
                        Next
                    End With
                ElseIf cmb_pesquisar_quem.Text = "AERONAVE" Then
                    .Add("TIPO")
                    .Add("FABRICANTE")
                    .Add("MODELO")
                    .Add("ASSENTOS")
                    .Add("VELOCIDADE")
                    .Add("AUTONOMIA")
                    .Add("OPERACAO")
                    .Add("REGRA")
                    .Add("DIARIA")
                    With dgv_cadastros
                        For x = 1 To 4
                            .Columns(x).Visible = False
                        Next
                        For x = 5 To 15
                            .Columns(x).Visible = True
                        Next
                    End With
                Else
                    With dgv_cadastros
                        For x = 0 To 15
                            .Columns(x).Visible = False
                        Next
                    End With
                End If
            End With
            cmb_pesquisar.SelectedIndex = 0
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    '-------------------------'
    ' POPULA O DATA GRID VIEW '
    '-------------------------'
    Private Sub popular_dgv_cadastros() Handles cmb_pesquisar.SelectedIndexChanged, txt_pesquisar.TextChanged
        Dim cont As Short
        Dim ativado As Boolean
        Try
            With dgv_cadastros
                cont = 0
                .Rows.Clear()
                If cmb_pesquisar_quem.Text = "" Or cmb_pesquisar.Text = "" Then
                    Exit Sub
                ElseIf cmb_pesquisar_quem.Text = "CLIENTE" Then
                    If txt_pesquisar.Text = "" Then
                        qry = "SELECT cpf,nome,sobrenome,ativo FROM tb_clientes
                            ORDER BY nome ASC"
                    Else
                        qry = "SELECT cpf,nome,sobrenome,ativo FROM tb_clientes
                        WHERE " & cmb_pesquisar.Text.ToLower & " LIKE '%" & txt_pesquisar.Text & "%'"
                    End If
                ElseIf cmb_pesquisar_quem.Text = "AERONAVE" Then
                    If txt_pesquisar.Text = "" Then
                        qry = "SELECT matricula,tb_aer_tipo.descricao,fabricante,modelo,assentos,velocidade,autonomia,tb_aer_operacao.descricao,tb_aer_regra.descricao,diaria,ativo
                                FROM tb_aeronaves
                                JOIN tb_aer_tipo
                                ON tb_aeronaves.tipo=tb_aer_tipo.tipo
                                JOIN tb_aer_operacao
                                ON tb_aeronaves.operacao=tb_aer_operacao.operacao
                                JOIN tb_aer_regra
                                ON tb_aeronaves.regra=tb_aer_regra.regra
                                ORDER BY matricula ASC"
                    Else
                        If cmb_pesquisar.Text = "TIPO" Or cmb_pesquisar.Text = "OPERACAO" Or cmb_pesquisar.Text = "REGRA" Then
                            qry = "SELECT matricula,tb_aer_tipo.descricao,fabricante,modelo,assentos,velocidade,autonomia,tb_aer_operacao.descricao,tb_aer_regra.descricao,diaria,ativo
                                FROM tb_aeronaves
                                JOIN tb_aer_tipo
                                ON tb_aeronaves.tipo=tb_aer_tipo.tipo
                                JOIN tb_aer_operacao
                                ON tb_aeronaves.operacao=tb_aer_operacao.operacao
                                JOIN tb_aer_regra
                                ON tb_aeronaves.regra=tb_aer_regra.regra
                                WHERE tb_aer_" & cmb_pesquisar.Text.ToLower & ".descricao LIKE '%" & txt_pesquisar.Text & "%'"
                        Else
                            qry = "SELECT matricula,tb_aer_tipo.descricao,fabricante,modelo,assentos,velocidade,autonomia,tb_aer_operacao.descricao,tb_aer_regra.descricao,diaria,ativo
                                FROM tb_aeronaves
                                JOIN tb_aer_tipo
                                ON tb_aeronaves.tipo=tb_aer_tipo.tipo
                                JOIN tb_aer_operacao
                                ON tb_aeronaves.operacao=tb_aer_operacao.operacao
                                JOIN tb_aer_regra
                                ON tb_aeronaves.regra=tb_aer_regra.regra
                                WHERE " & cmb_pesquisar.Text.ToLower & " LIKE '%" & txt_pesquisar.Text & "%'"
                        End If
                    End If
                End If
                rs = db.Execute(qry)
                If cmb_pesquisar_quem.Text = "CLIENTE" Then
                    Do While Not rs.EOF
                        cont = cont + 1
                        If rs(3).Value = "s" Then
                            ativado = True
                        Else
                            ativado = False
                        End If
                        'nº, cpf, nome, sobrenome, ativado
                        .Rows.Add(cont, rs(0).Value, rs(1).Value, rs(2).Value, ativado)
                        rs.MoveNext()
                    Loop
                ElseIf cmb_pesquisar_quem.Text = "AERONAVE" Then
                    Do While Not rs.EOF
                        cont = cont + 1
                        If rs(10).Value = "s" Then
                            ativado = True
                        Else
                            ativado = False
                        End If
                        'nº, (4 colunas vazias do cliente), matrícula, tipo, fabricante, modelo, assentos, velocidade, autonomia, operação, regra, diária, ativado
                        .Rows.Add(cont, "", "", "", False, rs(0).Value, rs(1).Value, rs(2).Value, rs(3).Value, rs(4).Value, rs(5).Value, rs(6).Value, rs(7).Value, rs(8).Value, rs(9).Value, ativado)
                        rs.MoveNext()
                    Loop
                End If
            End With
        Catch ex As Exception
            MsgBox("Algo deu errado...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Exit Sub
        End Try
    End Sub

    '---------------------------------'
    ' POPULA GB_CLIENTE E GB_AERONAVE '
    '---------------------------------'
    Private Sub alterar_ativacao() Handles dgv_cadastros.CellClick
        Dim dgvCpf, dgvMat As String
        Dim dgvAtivo, dgvAtiva As Boolean

        If Not dgv_cadastros.DisplayedColumnCount(True) > 1 Or Not dgv_cadastros.DisplayedRowCount(True) > 0 Then
            Exit Sub
        Else
            dgvCpf = dgv_cadastros.CurrentRow.Cells(1).Value
            dgvAtivo = dgv_cadastros.CurrentRow.Cells(4).Value
            dgvMat = dgv_cadastros.CurrentRow.Cells(5).Value
            dgvAtiva = dgv_cadastros.CurrentRow.Cells(15).Value

            If cmb_pesquisar_quem.Text = "CLIENTE" Then
                'traz do database as informações do cliente selecionado no DataGridView
                'e as carrega em gb_cliente caso esse cliente esteja ATIVO
                qry = "SELECT id,cpf,nome,sobrenome,foto FROM tb_clientes WHERE cpf='" & dgvCpf & "'"
                rs = db.Execute(qry)
                If dgvAtivo Then
                    txt_id.Text = rs(0).Value
                    txt_cpf.Text = rs(1).Value
                    txt_nome.Text = rs(2).Value
                    txt_sobrenome.Text = rs(3).Value
                    foto_path = rs(4).Value
                    Try
                        pb_foto_cliente.Load(foto_path)
                    Catch ex As Exception
                        pb_foto_cliente.Load(fotos_default & "cliente.png")
                    End Try
                Else
                    MsgBox("Este cliente está impedido de abrir contrato porque o cadastro dele está inativo.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERRO")
                End If
            ElseIf cmb_pesquisar_quem.Text = "AERONAVE" Then
                'traz do database as informações da aeronave selecionada no DataGridView
                'e as carrega em gb_aeronave caso essa aeronave esteja ATIVA
                qry = "SELECT matricula,tb_aer_tipo.descricao,fabricante,foto,modelo,tb_aer_combustivel.descricao,ano,assentos,pesomin,pesomax,velocidade,autonomia,tb_aer_operacao.descricao,tb_aer_regra.descricao,diaria
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
                If dgvAtiva Then
                    txt_matricula.Text = rs(0).Value
                    txt_tipo.Text = rs(1).Value
                    txt_fabricante.Text = rs(2).Value
                    foto_path = rs(3).Value
                    Try
                        pb_foto_aeronave.Load(foto_path)
                    Catch ex As Exception
                        pb_foto_aeronave.Load(fotos_default & "aeronave.png")
                    End Try
                    txt_modelo.Text = rs(4).Value
                    txt_combustivel.Text = rs(5).Value
                    txt_ano.Text = rs(6).Value
                    txt_assentos.Text = rs(7).Value
                    txt_pesomin.Text = rs(8).Value
                    txt_pesomax.Text = rs(9).Value
                    txt_velocidade.Text = rs(10).Value
                    txt_autonomia.Text = rs(11).Value
                    txt_operacao.Text = rs(12).Value
                    txt_regra.Text = rs(13).Value
                    txt_diaria.Text = rs(14).Value
                Else
                    MsgBox("Esta aeronave não pode ser alugada porque o cadastro dela está inativo.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERRO")
                End If
            End If
        End If
    End Sub

    '------------------------------'
    ' MANTÉM CADASTROS DE CLIENTES '
    '------------------------------'
    Private Sub manter_cadastros_de_clientes() Handles btn_cadastros_de_clientes.Click
        frm_cad_cliente.ShowDialog()
        Call limpar_gb_cliente()
        cmb_pesquisar.SelectedIndex = 0
    End Sub

    '-------------------------------'
    ' MANTÉM CADASTROS DE AERONAVES '
    '-------------------------------'
    Private Sub manter_cadastros_de_aeronaves() Handles btn_cadastros_de_aeronaves.Click
        frm_cad_aeronave.ShowDialog()
        Call limpar_gb_aeronave()
        cmb_pesquisar.SelectedIndex = 0
    End Sub

    '----------------'
    ' GERA CPF LIMPO '
    '----------------'
    Private Function gerar_cpf_limpo(cpf) As String
        cpf = Regex.Replace(txt_cpf.Text, "[^0-9]", "").ToString().PadLeft(11, "0")
        Return cpf
    End Function

    '----------------------------'
    ' VALIDA AS DATAS FORMATADAS '
    '----------------------------'
    Private Function datas_validas() As Boolean
        If dtp_inicio.Value < Today Then
            MsgBox("A data de início da locação não pode ser anterior a hoje.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            Return False
        ElseIf dtp_fim.Value < dtp_inicio.Value.AddHours(23) Then
            MsgBox("O último dia da locação tem de ser posterior a " & dtp_inicio.Value.Date, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            Return False
        Else
            Return True
        End If
    End Function

    '-----------------------------------'
    ' CALCULA O VALOR TOTAL DAS DIÁRIAS '
    '-----------------------------------'
    Private Function calcular_total(diaria As String, data_inicial As Date, data_final As Date) As (qd As Integer, vt As Integer)
        Dim qtd_diarias, valor_total As Integer

        qtd_diarias = DateDiff(DateInterval.Day, data_inicial, data_final)
        valor_total = CInt(diaria) * qtd_diarias
        Return (qtd_diarias, valor_total)
    End Function

    '-------------------------------------------'
    ' MOSTRA O TOTAL DE DIÁRIAS E O VALOR TOTAL '
    '-------------------------------------------'
    Private Sub mostrar_diarias_e_totais() Handles dtp_fim.Leave, btn_calcular_diarias.Click
        If datas_validas() Then
            If Regex.Replace(txt_matricula.Text, "[^A-Z]", "").ToString <> "" Then
                txt_diarias.Text = calcular_total(txt_diaria.Text, dtp_inicio.Value, dtp_fim.Value).qd
                txt_total.Text = calcular_total(txt_diaria.Text, dtp_inicio.Value, dtp_fim.Value).vt
            Else
                MsgBox("Primeiro selecione uma aeronave!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            End If
        Else
            txt_diarias.Clear()
            txt_total.Clear()
        End If
    End Sub

    '-------------------------------------'
    ' VERIFICA SE AS GB ESTÃO PREENCHIDAS '
    '-------------------------------------'
    Private Sub verificar_gbs() Handles btn_gerar_contrato.Click
        Dim resposta, aeronave As String
        Dim cliente As String
        Dim colaborador, total As Integer
        Dim diaria As Short
        Dim data_inicio, data_fim As Date
        Dim pago, rescindido As Char

        rescindido = "n"
        If txt_id.Text = "" Then
            MsgBox("Selecione um cliente contratante.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            cmb_pesquisar_quem.Select()
        Else
            cliente = gerar_cpf_limpo(txt_cpf.Text)
            aeronave = Regex.Replace(txt_matricula.Text, "[^A-Z]", "").ToString
            If aeronave = "" Then
                MsgBox("Selecione uma aeronave a ser alugada.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                cmb_pesquisar_quem.Select()
            Else
                Try
                    colaborador = meu_id
                Catch ex As Exception
                    MsgBox("Falha ao capturar o ID do colaborador.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                End Try
                If datas_validas() Then
                    Call mostrar_diarias_e_totais()
                    diaria = CShort(txt_diaria.Text)
                    data_inicio = dtp_inicio.Value
                    data_fim = dtp_fim.Value
                    'verifica se, para a aeronave selecionada, já existe ao menos 1 contrato NÃO rescindido
                    'que esteja cadastrado em todo o (ou pelo menos em parte do) período selecionado
                    qry = "SELECT contrato FROM tb_contratos WHERE aeronave='" & aeronave & "' AND rescindido='n' AND
                        (('" & data_inicio & "'>=data_inicio AND '" & data_inicio & "'<=data_fim)
                        OR ('" & data_fim & "'>=data_inicio AND '" & data_fim & "'<=data_fim)
                        OR ('" & data_inicio & "'<data_inicio AND '" & data_fim & "'>data_fim))"
                    rs = db.Execute(qry)
                    If Not rs.EOF Then
                        MsgBox("Essa aeronave já está alugada durante pelo menos uma parte do período informado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AERONAVE INDISPONÍVEL NESSE PERÍODO")
                        Exit Sub
                    Else
                        total = CInt(txt_total.Text)
                        If Not ckb_pago.Checked Then
                            resposta = MsgBox("O contrato permanecerá INATIVO (aeronave NÃO liberada) enquanto o total não for pago. O cliente realmente vai pagar depois?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ERRO")
                            If resposta = vbNo Then 'suspende a geração do contrato
                                MsgBox("Ok. Receba o pagamento do cliente e, após, retorne aqui para finalizar o preenchimento deste formulário e gerar o contrato.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CADASTRAMENTO SUSPENSO")
                                Exit Sub
                            Else 'o cliente vai pagar depois (gerar contrato inativo)
                                pago = "n"
                            End If
                        Else 'o cliente pagou (gerar contrato ativo)
                            pago = "s"
                        End If
                        qry = "INSERT INTO tb_contratos VALUES ('" & cliente & "','" & aeronave & "'," & colaborador & "," &
                        diaria & ",'" & data_inicio & "','" & data_fim & "'," & total & ",'" & pago & "','n')"
                        Try
                            db.Execute(qry)
                            MsgBox("O contrato foi cadastrado no sistema.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CONTRATO GERADO")
                        Catch ex As Exception
                            MsgBox("Não consegui cadastrar este contrato!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                        End Try
                        Try
                            qry = "SELECT contrato FROM tb_contratos WHERE cliente='" & cliente & "' AND aeronave='" &
                            aeronave & "' AND data_inicio='" & data_inicio & "' AND data_fim='" & data_fim & "'"
                            rs = db.Execute(qry)
                            MsgBox("O número deste contrato é " & rs(0).Value, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ID DO CONTRATO")
                        Catch ex As Exception
                            MsgBox("Não consegui consultar o ID desse contrato!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                        End Try
                    End If
                End If
            End If
        End If
    End Sub

    '--------------------'
    ' FORMULÁRIO FECHADO '
    '--------------------'
    Private Sub fechar_frm_cad_contrato() Handles MyBase.FormClosed
        cmb_pesquisar_quem.Items.Clear()
        cmb_pesquisar.Items.Clear()
    End Sub
End Class