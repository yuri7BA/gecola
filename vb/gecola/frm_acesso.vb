Public Class frm_acesso

    '-------------------'
    ' FORMULÁRIO ABERTO '
    '-------------------'
    Private Sub abrir_frm_acesso() Handles MyBase.Load, MyBase.VisibleChanged
        If conectado Then
            Call limpar_campos()
        Else
            Call conectar_banco()
            If Not conectado Then
                Close()
            End If
        End If
    End Sub

    '---------------------------------'
    ' LIMPA OS CAMPOS USUÁRIO E SENHA '
    '---------------------------------'
    Private Sub limpar_campos()
        txt_usuario.Text = ""
        txt_senha.Text = ""
        txt_usuario.Select()
    End Sub

    '-------------------------'
    ' ENTROU NO CAMPO USUÁRIO '
    '-------------------------'
    Private Sub selecionar_txt_usuario() Handles txt_usuario.Enter
        txt_usuario.SelectAll()
    End Sub

    '-------------------------'
    ' ENTROU NO CAMPO SENHA '
    '-------------------------'
    Private Sub selecionar_txt_senha() Handles txt_senha.Enter
        txt_senha.SelectAll()
    End Sub

    '-----------------------------'
    ' BOTÃO "ACESSAR" FOI CLICADO '
    '-----------------------------'
    Private Sub btn_acessar_acionado() Handles btn_acessar.Click
        Dim superior As String

        If txt_usuario.TextLength < 3 Or txt_usuario.TextLength > 20 Then
            MsgBox("Digite um nome de usuário contendo 3 a 20 caracteres!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "USUÁRIO INVÁLIDO")
            txt_usuario.Select()
        ElseIf txt_senha.TextLength < 8 Or txt_senha.TextLength > 20 Then
            MsgBox("Digite uma senha contendo 8 a 20 caracteres!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "SENHA INVÁLIDA")
            txt_senha.Select()
        Else
            qry = "SELECT * FROM tb_usuarios WHERE usuario='" & LCase(txt_usuario.Text) & "' and senha='" & txt_senha.Text & "'"
            rs = db.Execute(qry)
            If rs.EOF Then
                MsgBox("Usuário e/ou senha não confere(m)!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "CREDENCIAL INVÁLIDA")
            Else
                meu_id = rs(0).Value
                meu_cpf = rs(1).Value
                meu_usuario = rs(7).Value
                meu_perfil = rs(9).Value
                meu_ativo = rs(10).Value
                If meu_ativo = "s" Then
                    Hide()
                    frm_menu.Show()
                Else
                    Select Case meu_perfil
                        Case "f"
                            superior = "gerente"
                        Case "g", "a"
                            superior = "administrador"
                        Case Else
                            superior = "desenvolvedor"
                    End Select
                    MsgBox("Essa conta está inativa. Contate um " & superior & " para solicitar ativação.", MsgBoxStyle.Information + vbOKOnly, "ACESSO BLOQUEADO")
                End If
            End If
        End If
    End Sub

    '----------------------------'
    ' BOTÃO "LIMPAR" FOI CLICADO '
    '----------------------------'
    Private Sub btn_limpar_acionado() Handles btn_limpar.Click
        Call limpar_campos()
    End Sub

    '---------------------'
    ' FORMULÁRIO FECHANDO '
    '---------------------'
    Private Sub fechar_frm_acesso() Handles MyBase.Closing
        Call limpar_campos()
        Call desconectar_banco()
    End Sub
End Class
