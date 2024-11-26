-- seleciona o banco de dados GECOLA
USE GECOLA;

-- cria a tabela que vai receber os CEP importados do arquivo
-- de banco de dados Access tb_cep.accdb fornecido pelo prof Humberto
-- (foi necessario extrair esses CEP por partes, em varios arquivos XLS do Excel,
-- e depois reconstruir essas partes em uma unica tabela no SQL Server)
CREATE TABLE tb_cep
(
cep CHAR(8) PRIMARY KEY NOT NULL CHECK (LEN(cep)=8),
logradouro VARCHAR(40) NOT NULL CHECK (LEN(logradouro)<41),
cidade VARCHAR(25) NOT NULL CHECK (LEN(cidade)<26),
bairro VARCHAR(40) NOT NULL CHECK (LEN(bairro)<41),
uf CHAR(2) NOT NULL CHECK (LEN(uf)=2)
);

-- os CEP foram importados do Access por partes, via arquivos XLS, e reconstruidos
-- numa tabela tbCep de um database dbCep previamente criado. Estranhamente, todas
-- as colunas importadas eram do tipo NVARCHAR(255), mas isso foi corrigido com o
-- seguinte comando que copiou aquelas colunas de tbCep para tb_cep:
INSERT INTO gecola..tb_cep SELECT * FROM dbCep..tbCep;

-- a operacao acima deu certo porque o comprimento de cada coluna de dbCep..tbCep foi
-- previamente verificado para garantir que as colunas de gecola..tb_cep teriam
-- caracteres suficientes para receber os dados de dbCep..tbCep