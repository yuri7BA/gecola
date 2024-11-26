-- seleciona o banco GECOLA
USE gecola;

-- cria a tabela de aeronaves (nao sao atores, nao se autenticam como usuarios do sistema)
CREATE TABLE tb_aeronaves
(
---------------------------
-- DADOS DE IDENTIFICACAO -
---------------------------
-- id (codigo de identificacao sequencial) da aeronave no sistema
id INTEGER UNIQUE NOT NULL IDENTITY(1,1),
-- toda aeronave tem matricula, tem somente 1 matricula, e no mundo todo nao ha nenhuma matricula igual a outra
matricula CHAR(5) PRIMARY KEY NOT NULL CHECK (LEN(matricula)=5 AND (LEFT(matricula,2)='PP' OR LEFT(matricula,2)='PR' OR LEFT(matricula,2)='PS' OR LEFT(matricula,2)='PT' OR LEFT(matricula,2)='PU')),
-- fotografia para facilitar a identificacao
foto VARCHAR(255) NOT NULL,
-- tipo de aeronave (importado da tabela tb_aer_tipo)
tipo CHAR(1) NOT NULL CHECK (LEN(tipo)=1),
-- nome do fabricante da aeronave
fabricante VARCHAR(30) NOT NULL CHECK (LEN(fabricante)>2 AND LEN(fabricante)<31),
-- modelo da aeronave
modelo VARCHAR(30) NOT NULL CHECK (LEN(modelo)>2 AND LEN(modelo)<31),
-- tipo de combustivel (importado da tabela tb_aer_combustivel)
combustivel CHAR(1) NOT NULL CHECK (LEN(combustivel)=1),
-- ano de fabricacao da aeronave
ano SMALLINT NOT NULL CHECK (ano>1899 AND ano<=YEAR(GETDATE())),
------------------------
-- DADOS DE CAPACIDADE -
------------------------
-- a quantidade de assentos tem de ser maior que 1 porque toda aeronave tem
-- no minimo 2 assentos (1 para o piloto e 1 para o passageiro ou copiloto),
-- mas a maior aeronave do mundo (Airbus A380) tem 855 assentos e nos
-- proximos 10 anos dificilmente surgira uma aeronave que transporte mais que
-- 2000 pessoas (pouco mais que o dobro de um A380)
assentos SMALLINT NOT NULL CHECK (assentos>1 AND assentos<2001),
-- BOW (Basic Operation Weight) = peso minimo (em kg) no qual a aeronave opera
-- BOW do menor aviao do mundo (Bumble Bee 2): 43kg. BOW do maior (Antonov An-225): 285000kg
pesomin INT NOT NULL CHECK (pesomin>39 AND pesomin<400001),
-- MTOW (Maximum TakeOff Weight) = peso maximo (em kg) no qual a aeronave opera
-- MTOW do Bumble Bee 2: 120kg. MTOW do An-225: 640000kg
pesomax INT NOT NULL CHECK (pesomax>99 AND pesomax<2000001),
-- velocidade maxima (em km/h) que a aeronave consegue atingir
-- a aeronave mais lenta do mundo (MacCready Gossamer Condor) voa a no minimo 13km/h
-- e a mais rapida (NASA X-43) voa a no maximo 11800km/m
velocidade SMALLINT NOT NULL CHECK (velocidade>9 AND velocidade<20001),
-- distancia maxima (em km) que a aeronave consegue ininterruptamente voar sem reabastecer
-- as menores aeronaves voam mais de 200NM (370km) e nenhuma voa mais de 9000NM (16700km)
autonomia SMALLINT NOT NULL CHECK (autonomia>99 AND autonomia<30001),
-- tipo de operacao para a qual a aeronave esta homologada (importado da tabela tb_aer_operacao)
operacao CHAR(1) NOT NULL CHECK (LEN(operacao)=1),
-- regra de voo na qual a aeronave esta homologada (importada da tabela tb_aer_regra)
regra CHAR(1) NOT NULL CHECK (LEN(regra)=1),
---------------------
-- DADOS DE NEGOCIO -
---------------------
-- valor da diaria de aluguel (em R$)
diaria SMALLINT NOT NULL CHECK (diaria>99 AND diaria<32001),
-- o cadastro da aeronave esta ativo (permite locacao) ou inativo no sistema (nao permite locacao)
ativo CHAR(1) NOT NULL CHECK (ativo='s' OR ativo='n')
);