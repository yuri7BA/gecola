-- seleciona o banco GECOLA
USE gecola;

-- cria a tabela de tipos de combustivel
CREATE TABLE tb_aer_combustivel
(
combustivel CHAR(1) PRIMARY KEY NOT NULL CHECK (LEN(combustivel)=1), 
descricao VARCHAR(40) CHECK (LEN(descricao)<41)
);

-- popula a tabela com os seguintes codigos e descricoes:
-- g = avgas (gasolina de aviacao)
-- q = Jet-A (querosene de aviacao tipo Jet-A)
-- 1 = Jet-A1 (querosene de aviacao tipo Jet-A1)
INSERT INTO tb_aer_combustivel VALUES
('g','gasolina de aviação (avgas)'),
('q','querosene de aviação (jet-a)'),
('1','querosene de aviação aditivado (jet-a1)');