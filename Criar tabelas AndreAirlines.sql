
CREATE DATABASE AndreAirlines
Go

Use AndreAirlines
Go


CREATE TABLE Endereco(
Id int IDENTITY(1,1) not null,
Logradouro varchar(100) not null,
Numero int not null,
Complemento varchar(50) null,
Bairro varchar(50) not null,
Localidade varchar(50) not null,
UF varchar(2) not null,
Pais varchar(20) not null,
Cep varchar(10) not null
CONSTRAINT pk_idEndereco PRIMARY KEY (Id)
)
Go

CREATE TABLE Aeronave(
Id int IDENTITY(1,1) not null,
Nome varchar(20) not null,
Capacidade int not null
CONSTRAINT pk_idAeronave PRIMARY KEY (Id)
)
Go


CREATE TABLE Passageiro(
Cpf varchar(14) not null,
Nome varchar(50) not null,
Telefone varchar(15) null,
DataNasc date not null,
Email varchar(100) null,
Endereco int null
CONSTRAINT pk_cpf PRIMARY KEY (Cpf)
CONSTRAINT fk_enderecoPassageiro FOREIGN KEY (Endereco) REFERENCES Endereco (Id)
)
Go

CREATE TABLE Aeroporto(
Sigla varchar(5) not null,
Nome varchar(100) not null,
Endereco int not null
CONSTRAINT pk_sigla PRIMARY KEY (Sigla)
CONSTRAINT fk_enderecoAeroporto FOREIGN KEY (Endereco) REFERENCES Endereco (Id)
)
Go


CREATE TABLE Voo(
Id int IDENTITY(1,1) not null,
Destino varchar(5) not null,
Origem varchar(5) not null,
Aeronave int not null,
HoraEmbarque datetime not null,
PrevDesembarque datetime not null,
Passageiro varchar(14) not null
CONSTRAINT pk_idVoo PRIMARY KEY (Id)
CONSTRAINT fk_passageiro FOREIGN KEY (Passageiro) REFERENCES Passageiro (Cpf),
CONSTRAINT fk_destino FOREIGN KEY (Destino) REFERENCES Aeroporto (Sigla),
CONSTRAINT fk_origem FOREIGN KEY (Origem) REFERENCES Aeroporto (Sigla),
CONSTRAINT fk_aeronave FOREIGN KEY (Aeronave) REFERENCES Aeronave (Id)
)
Go

