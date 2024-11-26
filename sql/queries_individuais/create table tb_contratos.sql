-- seleciona o banco de dados GECOLA
USE GECOLA;

-- cria a tabela que armazena os dados dos contratos
CREATE TABLE tb_contratos (
-- id do contrato
contrato INTEGER PRIMARY KEY NOT NULL IDENTITY(1,1),
-- id (cpf) do cliente (PK importada de tb_clientes)
cliente CHAR(11) NOT NULL,
-- id (matr�cula) da aeronave (PK importada de tb_aeronaves)
aeronave CHAR(5) NOT NULL,
-- id do funcion�rio ou gerente que cadastrou o contrato (PK importada de tb_usuarios)
colaborador INTEGER NOT NULL,
-- valor da di�ria (importado de tb_aeronaves)
diaria SMALLINT NOT NULL,
-- data de in�cio do contrato
data_inicio SMALLDATETIME NOT NULL,
-- data de t�rmino do contrato
data_fim SMALLDATETIME NOT NULL,
-- valor total da loca��o (coluna calculada/autom�tica)
-- total AS diaria * CONVERT(INTEGER,data_fim-data_inicio,0000),
--
-- valor total da loca��o (a coluna abaixo substituiu a coluna acima ap�s decis�o
-- de inserir valor calculado via form ao inv�s de sobrecarregar o DBMS com colunas calculadas)
total INTEGER NOT NULL CHECK (total>99), 
-- registra se o cliente pagou a loca��o
pago CHAR(1) NOT NULL DEFAULT 'n' CHECK (pago='s' OR pago='n'),
-- informa se o contrato est� ativo ou inativo (coluna autom�tica/calculada)
-- o contrato ser� automaticamente ativado SOMENTE se estiver pago, n�o estiver rescindido
-- e o dia atual estiver dentro do per�odo de loca��o que foi contratado
ativo AS (CASE WHEN data_fim>=GETDATE() AND GETDATE()>=data_inicio AND pago='s' AND rescindido<>'s' THEN 's' ELSE 'n' END),
-- informa se o contrato foi manualmente rescindido
rescindido CHAR(1) NOT NULL CHECK (rescindido='s' OR rescindido='n'),
);