CREATE DATABASE pro_3camadas;
USE pro_3camadas;

CREATE TABLE tbl_usuario
(
    nome      varchar(40),
    telefone  varchar(20),
    rua       varchar(40),
    numero    int not null,
    bairro    varchar(30),
    cidade    varchar(30),
    estado    varchar(25),
    Pais      varchar(30),
    cpf       int not null primary key,
    rg        int not null,
    data_nascimento date not null,
    country   varchar(40),
    email     varchar(30),
    senha     int not null
);

create table tbl_dados
(
    id   	  INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    mabf      VARCHAR(100),
    m12       varchar(15),
    f11       varchar(15)
);
