-- seleciona o banco GECOLA
USE gecola;

-- cria a tabela de regras de voo (v = voo visual, i = voo por instrumentos, 2 = voo visual e por instrumentos)
CREATE TABLE tb_aer_regra
(
regra CHAR(1) PRIMARY KEY NOT NULL CHECK (LEN(regra)=1), 
descricao VARCHAR(40) CHECK (LEN(descricao)<41)
);

-- popula a tabela com os seguintes codigos e descricoes:
-- v = VFR (aeronave homologada para voo visual)
-- i = IFR (aeronave homologada para voo por instrumentos)
-- 2 = VFR e IFR (aeronave homologada para voo visual e por instrumentos)
INSERT INTO tb_aer_regra VALUES
('v','visual (vfr)'),
('i','por instrumentos (ifr)'),
('2','visual e por instrumentos (vfr e ifr)');