CREATE DATABASE TesteSegFST2
GO

USE TesteSegFST2
GO

CREATE TABLE Usuarios
(
	UsuarioId INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(50) NOT NULL
)
GO

INSERT INTO Usuarios VALUES('email@email.com', 123456)
INSERT INTO Usuarios VALUES('email2@email.com', 123456)


SELECT * FROM Usuarios

SELECT UsuarioId, Email, HASHBYTES('MD2', Senha) AS 'Senha Hash' FROM Usuarios WHERE UsuarioId = 1 
SELECT UsuarioId, Email, HASHBYTES('MD4', Senha) AS 'Senha Hash' FROM Usuarios WHERE UsuarioId = 1 
SELECT UsuarioId, Email, HASHBYTES('MD5', Senha) AS 'Senha Hash' FROM Usuarios WHERE UsuarioId = 1 
SELECT UsuarioId, Email, HASHBYTES('SHA', Senha) AS 'Senha Hash' FROM Usuarios WHERE UsuarioId = 1 
SELECT UsuarioId, Email, HASHBYTES('SHA1', Senha) AS 'Senha Hash' FROM Usuarios WHERE UsuarioId = 1 
SELECT UsuarioId, Email, HASHBYTES('SHA2_256', Senha) AS 'Senha Hash' FROM Usuarios WHERE UsuarioId = 1 
SELECT UsuarioId, Email, HASHBYTES('SHA2_512', Senha) AS 'Senha Hash' FROM Usuarios WHERE UsuarioId = 1 