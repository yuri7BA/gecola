-- seleciona o banco GECOLA
USE gecola;

-- cria a tabela de clientes (nao sao atores, nao se autenticam como usuarios do sistema)
CREATE TABLE tb_clientes
(
-- id do cliente
id INTEGER UNIQUE NOT NULL IDENTITY(1,1),
-- cpf chave primaria do cliente
cpf CHAR(11) PRIMARY KEY NOT NULL CHECK (LEN(cpf)=11),
-- o nome do cliente devera ter no minimo 3 e no maximo 20 caracteres
nome VARCHAR(20) NOT NULL CHECK (LEN(nome)>2 AND LEN(nome)<21),
-- o sobrenome do cliente devera ter no minimo 3 e no maximo 20 caracteres
sobrenome VARCHAR(20) NOT NULL CHECK (LEN(sobrenome)>2 AND LEN(sobrenome)<21),
-- a data de nascimento nao pode ser posterior a data atual
nascimento DATE NOT NULL CHECK (nascimento<=GETDATE()),
-- nao precisa informar o sexo, mas, se informar, tem de ser masculino, feminino ou intersexo
sexo CHAR(1) CHECK (sexo='m' OR sexo='f' OR sexo='i' OR sexo=''),
-- fotografia para facilitar a identificacao biometrica
foto VARCHAR(255) NOT NULL,
-- o cliente tem de estar ou ativo ou inativo
ativo CHAR(1) NOT NULL CHECK (ativo='s' OR ativo='n'),
-- tem de informar um cep e esse cep tem de ter exatamente 8 caracteres
cep CHAR(8) NOT NULL CHECK (LEN(cep)=8),
-- nao precisa informar numero de endereco, mas, se informar, tem de ter no maximo 6 caracteres
numero VARCHAR(6) CHECK (LEN(numero)<7),
-- nao precisa informar complemento, mas, se informar, tem de ter no maximo 15 caracteres
complemento VARCHAR(15) CHECK (LEN(complemento)<16),
-- nao precisa informar numero de celular, mas, se informar, tem de ter exatamente 11 caracteres
celular CHAR(11) CHECK (celular='' OR LEN(celular)=11),
-- nao precisa informar email, mas, se informar, tem de ter no maximo 40 caracteres
email VARCHAR(40) CHECK (LEN(email)<41),
);