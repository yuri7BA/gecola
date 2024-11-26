-- seleciona o banco de dados GECOLA
USE GECOLA;

-- cria a tabela que armazena os dados dos contratos
CREATE TABLE tb_contratos (
-- id do contrato
contrato INTEGER PRIMARY KEY NOT NULL IDENTITY(1,1),
-- id (cpf) do cliente (PK importada de tb_clientes)
cliente CHAR(11) NOT NULL,
-- id (matrícula) da aeronave (PK importada de tb_aeronaves)
aeronave CHAR(5) NOT NULL,
-- id do funcionário ou gerente que cadastrou o contrato (PK importada de tb_usuarios)
colaborador INTEGER NOT NULL,
-- valor da diária (importado de tb_aeronaves)
diaria SMALLINT NOT NULL,
-- data de início do contrato
data_inicio SMALLDATETIME NOT NULL,
-- data de término do contrato
data_fim SMALLDATETIME NOT NULL,
-- valor total da locação (coluna calculada/automática)
-- total AS diaria * CONVERT(INTEGER,data_fim-data_inicio,0000),
--
-- valor total da locação (a coluna abaixo substituiu a coluna acima após decisão
-- de inserir valor calculado via form ao invés de sobrecarregar o DBMS com colunas calculadas)
total INTEGER NOT NULL CHECK (total>99), 
-- registra se o cliente pagou a locação
pago CHAR(1) NOT NULL DEFAULT 'n' CHECK (pago='s' OR pago='n'),
-- informa se o contrato está ativo ou inativo (coluna automática/calculada)
-- o contrato será automaticamente ativado SOMENTE se estiver pago, não estiver rescindido
-- e o dia atual estiver dentro do período de locação que foi contratado
ativo AS (CASE WHEN data_fim>=GETDATE() AND GETDATE()>=data_inicio AND pago='s' AND rescindido<>'s' THEN 's' ELSE 'n' END),
-- informa se o contrato foi manualmente rescindido
rescindido CHAR(1) NOT NULL CHECK (rescindido='s' OR rescindido='n'),
);