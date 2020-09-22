create database AlumnosDB
go
use AlumnosDB
go
create table Alumnos(
	id int primary key identity(1,1),
	nombre varchar(20) not null,
	matricula bigint not null unique,
	carrera varchar(20) not null
)

select * from Alumnos

