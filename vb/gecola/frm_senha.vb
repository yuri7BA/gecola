Public Class frm_senha

    '-------------------'
    ' FORMULÁRIO ABERTO '
    '-------------------'
    Private Sub abrir_frm_senha() Handles MyBase.Load
        Call carregar_usuario_e_data(lbl_usuario_data)
        Call limpar_campos()
    End Sub

    '---------------------'
    ' LIMPAR O FORMULÁRIO '
    '---------------------'
    Private Sub limpar_campos() Handles btn_limpar.Click
        cb_senha_atual.Checked = False
        txt_senha_atual.Text = ""
        cb_nova_senha.Checked = False
        txt_nova_senha.Text = ""
        txt_nova_senha_repete.Text = ""
        txt_senha_atual.Select()
    End Sub

    '-----------------------------'
    ' ENTROU NO CAMPO SENHA ATUAL '
    '-----------------------------'
    Private Sub selecionar_senha_atual() Handles txt_senha_atual.Enter
        txt_senha_atual.Select()
        txt_senha_atual.SelectAll()
    End Sub

    '----------------------------'
    ' ENTROU NO CAMPO NOVA SENHA '
    '----------------------------'
    Private Sub selecionar_nova_senha() Handles txt_nova_senha.Enter
        txt_nova_senha.Select()
        txt_nova_senha.SelectAll()
    End Sub

    '-----------------------------------'
    ' ENTROU NO CAMPO NOVA SENHA REPETE '
    '-----------------------------------'
    Private Sub selecionar_nova_senha_repete() Handles txt_nova_senha_repete.Enter
        txt_nova_senha_repete.Select()
        txt_nova_senha_repete.SelectAll()
    End Sub

    '-----------------------------'
    ' VISIBILIDADE DA SENHA ATUAL '
    '-----------------------------'
    Private Sub mascarar_senha_atual() Handles cb_senha_atual.CheckedChanged
        If cb_senha_atual.Checked Then
            txt_senha_atual.PasswordChar = ""
        Else
            txt_senha_atual.PasswordChar = "*"
        End If
    End Sub

    '----------------------------'
    ' VISIBILIDADE DA NOVA SENHA '
    '----------------------------'
    Private Sub mascarar_nova_senha() Handles cb_nova_senha.CheckedChanged
        If cb_nova_senha.Checked Then
            txt_nova_senha.PasswordChar = ""
            txt_nova_senha_repete.PasswordChar = ""
        Else
            txt_nova_senha.PasswordChar = "*"
            txt_nova_senha_repete.PasswordChar = "*"
        End If
    End Sub

    '-------------------'
    ' SALVAR ALTERAÇÕES '
    '-------------------'
    Private Sub salvar() Handles btn_confirmar.Click
        If Len(txt_senha_atual.Text) < 8 Or Len(txt_senha_atual.Text) > 20 Then
            MsgBox("A senha atual deve ter de 8 a 20 caracteres.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            Call selecionar_senha_atual()
        ElseIf Len(txt_nova_senha.Text) < 8 Or Len(txt_nova_senha.Text) > 20 Then
            MsgBox("A nova senha deve ter de 8 a 20 caracteres.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            Call selecionar_nova_senha()
        ElseIf Len(txt_nova_senha_repete.Text) < 8 Or Len(txt_nova_senha_repete.Text) > 20 Then
            MsgBox("A nova senha repetida deve ter de 8 a 20 caracteres.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            Call selecionar_nova_senha_repete()
        ElseIf txt_nova_senha.Text <> txt_nova_senha_repete.Text Then
            MsgBox("A nova senha digitada não confere com a repetição dela.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERRO")
            txt_nova_senha_repete.Clear()
            txt_nova_senha.Clear()
            txt_nova_senha.Select()
        Else
            qry = "SELECT senha FROM tb_usuarios WHERE id='" & meu_id & "'"
            rs = db.Execute(qry)
            If rs.EOF Then
                MsgBox("Senha não encontrada!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO CRÍTICO")
            Else
                If txt_senha_atual.Text <> rs(0).Value Then
                    MsgBox("A senha atual não é a que você digitou.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                    txt_senha_atual.Clear()
                    txt_senha_atual.Select()
                Else
                    Try
                        qry = "UPDATE tb_usuarios SET senha='" & txt_nova_senha.Text & "' WHERE id='" & meu_id & "'"
                        rs = db.Execute(qry)
                        MsgBox("Senha alterada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "TROCA DE SENHA EFETIVADA")
                        Call limpar_campos()
                    Catch ex As Exception
                        MsgBox("Erro ao tentar salvar a nova senha no banco de dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                    End Try
                End If
            End If
        End If
    End Sub
End Class