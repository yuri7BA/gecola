-- seleciona o banco GECOLA
USE gecola;

-- cria a tabela de tipos de aeronave (a = aviao, h = helicoptero, c = convertiplano)
CREATE TABLE tb_aer_tipo
(
tipo CHAR(1) PRIMARY KEY NOT NULL CHECK (LEN(tipo)=1), 
descricao VARCHAR(40) CHECK (LEN(descricao)<41)
);

-- popula a tabela com os seguintes codigos e descricoes:
-- a = aviao (aeronave de asa fixa)
-- h = helicoptero (aeronave de asa rotativa)
-- c = convertiplano (aeronave de asas fixa e rotativa)
INSERT INTO tb_aer_tipo VALUES
('a','avião (asa fixa)'),
('h','helicóptero (asa rotativa)'),
('c','convertiplano (asa fixa e rotativa)');