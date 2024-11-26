Module main
    Public Const SERVIDOR As String = "ruindows11"
    Public Const BANCO As String = "gecola"
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public conectado As Boolean
    Public foto_path, qry, resp, meu_usuario, meu_cpf As String
    Public fotos_default As String = Application.StartupPath & "\recursos\fotos\default\"
    Public meu_id As Integer
    Public meu_ativo, meu_perfil As Char

    '-----------------------------------'
    ' CONECTA-SE AO BANCO DE DADOS '
    '-----------------------------------'
    Public Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("provider=SQLOLEDB;data source=" & SERVIDOR & ";initial catalog=" & BANCO & ";trusted_connection=yes;")
            MsgBox("Conexão bem-sucedida.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CONECTADO")
            conectado = True
        Catch ex As Exception
            MsgBox("A conexão falhou!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            conectado = False
        End Try
    End Sub

    '-----------------------------------'
    ' DESCONECTA-SE DO BANCO DE DADOS '
    '-----------------------------------'
    Public Sub desconectar_banco()
        Try
            db.Close()
            MsgBox("Desconexão bem-sucedida.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "DESCONECTADO")
            conectado = False
        Catch ex As Exception
            MsgBox("A desconexão falhou!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Stop
        End Try
    End Sub

    '--------------------------------------------------------------------'
    ' MOSTRA A DATA ATUAL EM UM CONTROLE QUE POSSUA A PROPRIEDADE "TEXT" '
    '--------------------------------------------------------------------'
    Public Sub carregar_usuario_e_data(controle)
        controle.Text = "[" & LCase(meu_usuario) & ", " & Format(Now, "d\/MM\/yyyy") & "]"
    End Sub
End Module