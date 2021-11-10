create database bdmassa;

create table Cliente(
Id int auto_increment primary key,
Nome varchar(50),
Ender varchar(50),
Telefone varchar(20),
CPF varchar(15)
);

select * from Cliente;

describe tabelacliente;

DROP TABLE cliente;

INSERT INTO `bdmassa`.`Cliente` (`Nome`, `Ender`, `Telefone`, `CPF`) VALUES ('Victor', 'ssdad', '21313', '46436');
