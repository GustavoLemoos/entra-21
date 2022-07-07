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

SELECT id, nome, cpf, rg, FORMAT(data_de_nascimento, 'dd/MM/yyyy'), idade FROM pessoas;