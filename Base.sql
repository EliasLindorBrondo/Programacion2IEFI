create database IEFIP2;
Go
USE IEFIP2;
Go
create table Articulo(
codArt varchar(3) ,
nombre varchar(100) not null,
fechaVto datetime,
NombreCategoria varchar(100) not null,
marca varchar(100) not null,
primary key (codArt)
)
Go
create table Categoria(
IdCategoria int identity primary key,
NombreCategoria varchar(100),
marca varchar(100) not null,
vigente char(1) not null
)