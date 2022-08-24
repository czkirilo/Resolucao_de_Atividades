--DDL
CREATE DATABASE RpgBDFST2
GO

USE RpgBDFST2
GO

CREATE TABLE Usuarios(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(255) NOT NULL
)
GO

CREATE TABLE Classes(
	IdClasse INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(100) UNIQUE NOT NULL,
	Descricao VARCHAR(255)
)
GO

CREATE TABLE Personagens(
	IdPersongem INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(30) UNIQUE NOT NULL,
	IdUsuario INT UNIQUE FOREIGN KEY REFERENCES Usuarios(IdUsuario),
	IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse)
)
GO

CREATE TABLE Habilidades(
	IdHabilidade INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(100) UNIQUE NOT NULL,
	Descricao VARCHAR(255)
)
GO

CREATE TABLE ClasseHabilidade(
	IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse),
	IdHabilidade INT FOREIGN KEY REFERENCES Habilidades(IdHabilidade)
)
GO


--DML
INSERT INTO Usuarios (Senha, Email) VALUES(123456, 'email@email.com')
INSERT INTO Classes VALUES ('Barbaro', 'Descrição da classe Barbaro')
INSERT INTO Habilidades VALUES ('Lança Mortal', 'Descrição da Lança Mortal'), ('Escudo Supremo', 'Descrição do Escudo Sepremo')
INSERT INTO Personagens VALUES ('DeuBug', 1, 1)
INSERT INTO ClasseHabilidade VALUES (1, 1), (1, 2)

INSERT INTO Usuarios VALUES ('eamil2@email.com', 123456)
INSERT INTO Classes VALUES ('Monge', 'Descrção da classe Monge')
INSERT INTO Habilidades VALUES ('Recuperar Vida', 'Descrção da Recuperar Vida')
INSERT INTO Personagens VALUES ('BitBug', 2, 2)
INSERT INTO ClasseHabilidade VALUES (2, 2), (2, 3)

UPDATE Usuarios
SET Senha = 123456
WHERE IdUsuario = 1 


--DQL
SELECT * FROM Usuarios
SELECT Senha, Email FROM Usuarios
SELECT * FROM Classes
SELECT * FROM Habilidades
SELECT * FROM Personagens
SELECT * FROM ClasseHabilidade

--Selecionando tudo
SELECT * FROM Personagens
INNER JOIN Classes
ON Personagens.IdClasse = Classes.IdClasse

--Especificando as colunas
SELECT Personagens.Nome, Classes.Nome, Classes.Descricao FROM Personagens
INNER JOIN Classes
ON Personagens.IdClasse = Classes.IdClasse

--Abreviando o nome das tabelas e dando nome a coluna
SELECT P.Nome, C.Nome 'Classe', C.Descricao FROM Personagens P
JOIN Classes C
ON P.IdClasse = C.IdClasse




--EXEMPLO JOIN's
CREATE DATABASE ExemploJoin

USE ExemploJoin

CREATE TABLE NomeA(
	Nome VARCHAR(50) NOT NULL
)

CREATE TABLE NomeB(
	Nome VARCHAR(50) NOT NULL
)

INSERT INTO NomeA VALUES ('Fernanda'), ('Maria'), ('Luiz'), ('Caique')
INSERT INTO NomeB VALUES ('Luiz'), ('Caique'), ('Odirlei'), ('Jessica')


SELECT * FROM NomeA
JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
LEFT JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
RIGHT JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
FULL OUTER JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT NomeA.Nome 'Nome A', NomeB.Nome 'Nome B' FROM NomeA
FULL OUTER JOIN NomeB
ON NomeA.Nome = NomeB.Nome
WHERE NomeA.Nome IS NULL OR NomeB.Nome IS NULL