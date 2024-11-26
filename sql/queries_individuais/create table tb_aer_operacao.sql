-- seleciona o banco GECOLA
USE gecola;

-- cria a tabela de modalidade de operacao (d = diurna, n = noturna)
-- obs.: se a aeronave opera noturno, isso significa que ela tambem opera diurno
CREATE TABLE tb_aer_operacao
(
operacao CHAR(1) PRIMARY KEY NOT NULL CHECK (LEN(operacao)=1), 
descricao VARCHAR(10) CHECK (LEN(descricao)<11)
);

-- popula a tabela com os seguintes codigos e descricoes:
-- d = operacao diurna (a aeronave pode operar somentr entre o nascer e por do sol)
-- n = operacao noturna (a aeronave pode operar tanto de dia quanto de noite)
INSERT INTO tb_aer_operacao VALUES
('d','diurna'),
('n','noturna');