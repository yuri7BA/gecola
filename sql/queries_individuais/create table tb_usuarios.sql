-- seleciona o banco GECOLA
USE gecola;

-- cria a tabela de atores humanos que se autenticam como usuarios do sistema
CREATE TABLE tb_usuarios
(
-- chave primaria do usuario
id INTEGER PRIMARY KEY NOT NULL IDENTITY(1,1),
-- cpf nao pode ser chave primaria porque se (por exemplo) um funcionario
-- for promovido a gerente, o perfil funcionario sera desativado (nao excluido,
-- para nao se perder o historico de atuacao desse funcionario no sistema)
-- e um novo perfil gerente sera criado e ativado com um cpf igual
-- o cpf devera ter exatamente 11 digitos
cpf CHAR(11) NOT NULL CHECK (LEN(cpf)=11),
-- o nome do usuario devera ter no minimo 3 e no maximo 20 caracteres
nome VARCHAR(20) NOT NULL CHECK (LEN(nome)>2 AND LEN(nome)<21),
-- o sobrenome do usuario devera ter no minimo 3 e no maximo 20 caracteres
sobrenome VARCHAR(20) NOT NULL CHECK (LEN(sobrenome)>2 AND LEN(sobrenome)<21),
-- a data de nascimento nao pode ser posterior a data atual
nascimento DATE NOT NULL CHECK (nascimento<=GETDATE()),
-- nao precisa informar o sexo, mas, se informar, tem de ser masculino, feminino ou intersexo
sexo CHAR(1) CHECK (sexo='m' OR sexo='f' OR sexo='i' OR sexo=''),
-- fotografia para facilitar a identificacao biometrica
foto VARCHAR(255) NOT NULL,
-- o nome de usuario usado pelo ator para autenticacao (login) no sistema
-- devera ser unico na tabela e ter no minimo 3 e no maximo 20 caracteres
usuario VARCHAR(20) NOT NULL UNIQUE CHECK (LEN(usuario)>2 AND LEN(usuario)<21),
-- tem de informar a senha do usuario e ela devera ter no minimo 8 e no maximo 20 caracteres
senha VARCHAR(20) NOT NULL CHECK (LEN(senha)>7 AND LEN(senha)<21),
-- o perfil do usuario tem de ser ou a(dministrador) ou g(erente) ou f(uncionario)
perfil CHAR(1) NOT NULL CHECK (perfil='a' OR perfil='g' OR perfil='f'),
-- o perfil do usuario tem de estar ou ativo ou inativo
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