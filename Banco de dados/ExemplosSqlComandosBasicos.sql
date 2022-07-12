CREATE TABLE trabalhos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR(100),
	subtitulo VARCHAR(50), -- armazenar até 50 caracteres
	descricao TEXT, -- armazenar textos grandes
	data_publicacao DATETIME2, -- data e hora
	tipo VARCHAR(15)
	);

INSERT INTO trabalhos (titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('A melhor pizza do mundo', 'Como degustar uma pizza de calabresa', 'Grande descrição aqui', '1994-06-04', 'Receita');

INSERT INTO trabalhos (titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Clean code', 'Como trabalhar melhor no seu dia a dia', 'utilizar var no lugar de tipo primitivos, Identar seu código,
	utilizar constantes', '2000-03-20', 'Leitura técnica');

INSERT INTO trabalhos (titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Pudim com ovo', 'Aprenda o que não fazer na sua vida', 'Jogue o pudim no lixo e faça um ovo', '2022-07-06', 'Receita');

INSERT INTO trabalhos (titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Estrutura de dados', 'como sofrer sem saber, porém é necessário', 'Importante para aprender fifo, lifo, listas encadeadas',
	'1998-05-11', 'Leitura técnica');

INSERT INTO trabalhos (titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Strogonoff de frango', 'a vitória da batata palha', 'Compre frango e batata palha, jogue na panela, acenda o fogo,
	espera 5 minutinhos e ta plonto o sorvetinho', '2000-09-10', 'Receita');

SELECT id, titulo, subtitulo, descricao, data_publicacao, tipo
	FROM trabalhos;

SELECT CONCAT(titulo, ' - ', subtitulo) AS 'Título completo'
	FROM trabalhos;

-- Consultar a descrição limitando a quantidade de caracteres
SELECT 
	titulo AS 'Título',
	CONCAT(SUBSTRING(descricao, 0, 20), '...') AS 'Descrição'
	FROM trabalhos;

-- 
SELECT id, titulo, data_publicacao 
	FROM trabalhos
	WHERE 
		YEAR(data_publicacao) >= 1990 AND 
		YEAR(data_publicacao) <= 2010;

-- Consultar data publicação formato BR
-- BR, dia/mes/ano
SELECT 
	id,
	titulo,
	CONCAT(
		DAY(data_publicacao), '/',
		MONTH(data_publicacao), '/',
		YEAR(data_publicacao))
	FROM trabalhos;

-- Consultar a data da publicação no padrão BR, utilizando função para isso
SELECT id, titulo, FORMAT(data_publicacao, 'dd/MM/yyyy')
	FROM trabalhos;


-- Limitar a consulta para dois registros
SELECT TOP (2) id, titulo FROM trabalhos;

-- Apresentar o código, nome, preço, se está favoritado, filtrando por Placa mãe ou placa de vídeo em ordem decrescente do preço
-- SELECT TOP(20) id, nome, preco, favoritado
-- FROM produtos
-- WHERE categoria = 'Placa mãe' OR 'Placa de vídeo'
-- ORDER BY preco DESC;

-- Consulta com paginação apresentando 2 registros da página 1
SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 0 ROWS FETCH NEXT 2 ROWS ONLY;

	-- Consulta com paginação apresentando 2 registros da página 2
SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 2 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação apresentando 2 registros da página 3
SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 4 ROWS FETCH NEXT 2 ROWS ONLY;

-- Exercício 01
CREATE TABLE pessoas(
	id INTEGER IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100),
	cpf VARCHAR(14),
	rg VARCHAR(12),
	data_de_nascimento DATETIME2,
	idade int
);

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Erick Bryan Enrico Vieira', '699.734.958-70', 
	'90.745.276-0', '1989-05-28', 29);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Samuel Ruan Dias', '802.790.194-40', 
	'55.318.691-7', '02-08-1988', 30);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Fábio Benjamin Souza', '522.445.349-60', 
	'54.715.232-2', '1970-03-22', 48);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Elias Miguel Aparicio', '293.928.821-65', 
	'12.680.444-8', '1986-06-07', 32);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Alexandre Gustavo Cardoso', '617.408.878-24', 
	'8.888.574-4', '2003-04-15', 15);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Kauê Lucca Duarte', '943.163.990-47', 
	'46.977.509-9', '1965-06-15', 53);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Marcos Bryan Guilherme Mendes', '955.129.235-95', 
	'84.050.077-4', '2015-02-06', 3);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Benedito Pedro Carlos da Mota', '510.505.472-50', 
	'43.588.124-3', '1981-04-19', 37);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Luís Igor Barbosa ', '370.570.311-06', 
	'40.651.407-0', '2013-05-06', 5);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('José Heitor Ramos', '675.624.925-81', 
	'83.962.258-2', '1965-04-11', 53);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Lucca Tiago Galvão', '788.124.508-57', 
	'3.293.335-6', '1977-06-17', 41);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Tiago Edson Oliveira', '389.969.352-39', 
	'8.198.446-9', '1977-06-09', 41);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Enrico Julio Fábio Martins', '529.078.166-83', 
	'99.886.242-3', '2017-03-11', 1);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Oliver Victor Benjamin da Mota', '798.556.805-02', 
	'5.103.578-9', '1985-03-27', 33);
INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade) VALUES ('Bryan Caio Lopes', '213.217.201-30', 
	'12.949.454-9', '1970-06-18', 48);

SELECT id, nome, cpf, rg, FORMAT(data_de_nascimento, 'dd/MM/yyyy'), idade FROM pessoas;

-- Exercício 02
CREATE TABLE enderecos(
	id INT IDENTITY(1,1) PRIMARY KEY,
	estado VARCHAR(2),
	cidade VARCHAR(140),
	bairro VARCHAR(120),
	cep VARCHAR(10),
	logradouro VARCHAR(250),
	numero INT,
	complemento TEXT
);

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('AC', 'Rio Branco', 'Ayrton Senna',
	'69.911-866', 'Estrada Deputado José Rui da Silveira Lino', 282, 'Casa');
INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('SC', 'Biguaçu', 'Fundos', 
	'88.161-400', '', 995, '');
INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('MG', 'Santa Luzia', 'Padre Miguel',
	'33.082-050', 'Rua Buenos Aires', 371, 'Apartamento');
INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('BA', '', 'São Tomé de Paripe',
	'40.800-361', 'Travessa Luís Hage', 685, '');
INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('MG', 'Ipatinga', 'Vila Celeste',
	'', 'Rua Antônio Boaventura Batista', 645, '');
INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('RS', 'Passo Fundo', 'Nenê Graeff',
	'99.030-250', '', 154, '');
INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('AM', 'Manaus', 'Petrópolis',
	'69.079-300', 'Rua Coronel Ferreira Sobrinho', 264, 'Fundos');
INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('TO', 'Gurupi', 'Muniz Santana',
	'77.402-130', 'Rua Adelmo Aires Negri', 794, '');
INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('AC', '', 'Preventório',
	'', 'Beco da Ligação II', 212, 'Bloco B');
INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('AP', 'Santana', 'Comercial',
	'68.925-073', 'Rua Calçoene', 648, '');
INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('PB', 'Cabedelo', 'Camalaú',
	'58.103-052', 'Rua Siqueira Campos', 249, '');

UPDATE enderecos SET logradouro='Julio Teodoro Martins', complemento='Casa' WHERE cep='88.161-400';
UPDATE enderecos SET cidade='Salvador', complemento='Casa' WHERE cep='40.800-361';
UPDATE enderecos SET cep='35.162-484', complemento='Casa' WHERE bairro='Vila Celeste';
UPDATE enderecos SET logradouro='Itu', complemento='Casa' WHERE cep='99.030-250';
UPDATE enderecos SET complemento='Casa' WHERE cep='77.402-130';
UPDATE enderecos SET cidade='Rio Branco', cep='69.900-162' WHERE bairro='Preventório';
UPDATE enderecos SET complemento='Casa' WHERE cep='68.925-073';
UPDATE enderecos SET complemento='Casa' WHERE cep='58.103-052';

select * from enderecos;

-- Exercício 03
CREATE TABLE champions(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100),
	descricao VARCHAR(50),
	habilidade1 VARCHAR(30),
	habilidade2 VARCHAR(30),
	habilidade3 VARCHAR(30),
	habilidade4 VARCHAR(30),
	habilidade5 VARCHAR(30),
);

INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Katarina', 'a Lâmina Sinistra', 'Voracidade', 'Lâmina Saltitante',
	'Preparação', 'Shunpo', 'Lótus da Morte');
INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Yasuo', '', 'Estilo do Errante', 'Tempestade de Aço',
	'Parede de Vento', 'Espada Ágil', 'Último Suspiro');
INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Master Yi', 'o Espadachim Wuju', 'Ataque Duplo', '',
	'', '', '');
INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Vayne', 'a Caçadora Noturna', 'Caçadora Noturna', 'Rolamento',
	'Dardos de Prata', 'Condenar', 'Hora Final');
INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Lee Sin', 'o Monge Cego', 'Agitação', 'Onda Sônica  Ataque Ressonante',
	'Proteger  Vontade de Ferro', 'Tempestade , Mutilar', '');
INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Vi', 'a Defensora de Piltover', 'Blindagem', '',
	'Pancada Certeira', 'Força Excessiva', 'Saque e Enterrada');
INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Diana', 'o Escárnio da Lua', 'Espada de Prata Lunar', 'Golpe Crescente',
	'Cascata Lívida', 'Colapso Minguante', 'Zênite Lunar');
INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Annie', 'a Criança Sombria', 'Piromania', 'Desintegrar',
	'Incinerar', 'Escudo Fundido', 'Invocar: Tibbers');
INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5)
	VALUES ('Aatrox', '', 'Poço de Sangue', 'Voo Sombrio',
	'Sede de Sangue Preço em Sangue', 'Lâminas da Aflição', 'Massacre');

UPDATE champions SET descricao='o Imperdoável' WHERE nome='Yasuo';
UPDATE champions SET habilidade2='Ataque Alpha', habilidade3='Meditar', habilidade4='Estilo Wuju', habilidade5='Highlander' WHERE nome='Master Yi';
UPDATE champions SET habilidade5='Fúria do Dragão' WHERE nome='Lee Sin';
UPDATE champions SET habilidade2='Quebra-cofres' WHERE nome='Vi';
UPDATE champions SET descricao='a Espada Darkin' WHERE nome='Aatrox';

DROP TABLE champions;
SELECT * FROM champions;

-- Exemplo aula 11/07

CREATE TABLE pecas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(60),
	tipo INTEGER,
	preco_unitario DECIMAL(6,2)
);

CREATE TABLE clientes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(60),
	cpf varchar(20)
);

CREATE TABLE enderecos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_cliente INTEGER NOT NULL,
	cep VARCHAR(30) NOT NULL,
	estado VARCHAR(20) NOT NULL,
	cidade VARCHAR(30) NOT NULL,
	bairro VARCHAR(30) NOT NULL,
	logradouro VARCHAR(40) NOT NULL,
	numero VARCHAR(20) NOT NULL,
	decricao TEXT,
	FOREIGN KEY (id_cliente) REFERENCES clientes(id)
);

CREATE TABLE pedidos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_cliente INTEGER NOT NULL,
	status TINYINT NOT NULL, -- 0 - 255
	data_criacao DATETIME2 NOT NULL,
	data_compra DATETIME2,
	data_efetivacao_compra DATETIME2,
	
);
CREATE TABLE pedidos_pecas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_peca INTEGER,
	id_pedido INTEGER,

	quantidade SMALLINT,
	FOREIGN KEY (id_pedido) REFERENCES pedidos(id),
	FOREIGN KEY (id_peca) REFERENCES pecas(id)
);

-- Tipos de peças
-- 1 - SSD
-- 2 - Placa Vídeo
-- 3 - Placa Mãe
-- 4 - Fonte
-- 5 - Memória RAM

INSERT INTO pecas (nome, tipo, preco_unitario) VALUES
('SSD 200 GB', 1, 200),
('SSD 200 M2', 1, 420.39),
('RTX 2000 TI', 2, 9999.99),
('GTX 1060', 2, 1500),
('16GB DDR5 4800GHZ', 5, 800),
('16GB DDR4 3200GHZ', 5, 350);

INSERT INTO clientes(nome, cpf) VALUES
('Claudio', '070.355.489-73'),
('Cry', '032.599.364-69'),
('Juliana', '123.456.789-123');

INSERT INTO enderecos(id_cliente, estado, cidade, bairro, cep, logradouro, numero) VALUES 
(1, 'SC', 'Blumenau', 'Velha', '89037-301', 'Rua Divinopolis', 222), 
(2, 'SC', 'Blumenau', 'Velha Grande', '89032-235', 'Morro da Edite', 35), 
(3, 'SC', 'Blumenau', 'Judity', 'Sem cep', 'Rua da Kellen', 23);

SELECT * FROM pecas;
SELECT * FROM clientes;
SELECT * FROM enderecos;

SELECT
	c.nome,
	c.cpf,
	CONCAT(
		e.estado, ' - ',
		e.cidade, ' - ',
		e.bairro, ' - ',
		e.logradouro, ' - ',
		e.numero) AS 'Endereço Completo'
	FROM clientes AS c
	INNER JOIN enderecos AS e ON (e.id_cliente = c.id);

SELECT 
	c.nome,
	e.bairro,
	e.logradouro
	FROM enderecos AS e
	INNER JOIN clientes AS c ON (e.id_clientes = e.id_cliente)
	WHERE e.bairro  LIKE '%Velha%';

-- Status do pedido
-- 0 - Carrinho
-- 1 - Aguardando pagamento
-- 2 - Pagamento efetuado
-- 3 - Entrega realizada
INSERT INTO pedidos (id_cliente, status, data_criacao) VALUES
(1, 0, GETDATE()),
((SELECT id FROM clientes WHERE nome = 'Cry'), 0, GETDATE());

SELECT 
	FORMAT(p.data_criacao, 'dd/MM/yyyy'),
	CASE
		WHEN [status] = 0 THEN 'Carrinho'
		WHEN [status] = 1 THEN 'Aguardando pagamento'
		WHEN [status] = 2 THEN 'Pagamento efetuado'
		ELSE 'Entrega realizada'
	END AS 'Status pedido',
		c.nome
	FROM pedidos AS p
	INNER JOIN clientes AS c ON (p.id_cliente = c.id);