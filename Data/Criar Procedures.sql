use AndreAirlines
go

CREATE or ALTER PROCEDURE IncluirPassageiro

@CPF varchar(14),
@Nome varchar(50), 
@Telefone varchar(15),
@DataNasc date,
@Email varchar(100)
AS
BEGIN
DECLARE
	@Id int;
SELECT @Id = MAX(Id) From Endereco
	INSERT INTO Passageiro
	
	VALUES (@CPF,@Nome,@Telefone,@DataNasc,@Email,@Id)
END
Go



CREATE or ALTER PROCEDURE IncluirEnderecoCompleto
@Logradouro varchar(100),
@Numero int,
@Complemento varchar(50),
@Bairro varchar(50),
@Localidade varchar(50),
@UF varchar(2),
@Pais varchar(20),
@Cep varchar(10)
AS
BEGIN
	INSERT INTO Endereco (Logradouro, Numero, Complemento,Bairro,Localidade,UF,Pais,cep)
	VALUES (@Logradouro, @Numero, @Complemento,@Bairro,@Localidade,@UF,@Pais,@Cep)
END
Go


CREATE or ALTER PROCEDURE IncluirEnderecoSemComplemento
@Logradouro varchar(100),
@Numero int,
@Bairro varchar(50),
@Localidade varchar(50),
@UF varchar(2),
@Pais varchar(20),
@Cep varchar(10)
AS
BEGIN
	INSERT INTO Endereco (Logradouro, Numero, Bairro,Localidade,UF,Pais,cep)
	VALUES (@Logradouro, @Numero, @Bairro,@Localidade,@UF,@Pais,@Cep)
END
Go



