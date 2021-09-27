create database AgenciaAutomotriz;

create table usuarios(
idusuarios int primary key auto_increment,
nombre varchar(50),
apellidop varchar(50),
apellidom varchar(50),
fechanacimiento varchar(50),
rfc varchar(50),
fkidaccesos varchar(50),
foreign key(fkidaccesos) references accesos(idaccesos));

create table producto(
CodigoBarras varchar(50) primary key,
nombre varchar(50),
descripcion varchar(100),
marca varchar(50));

create table herramientas(
CodigoHerramienta varchar(50) primary key,
nombre varchar(50),
medida varchar(50),
marca varchar(50),
descripcion varchar(100));

create table accesos(
idaccesos varchar(50) primary key,
lectura boolean,
estrictura boolean,
eliminacion boolean,
actualizacion boolean);

insert into accesos values
('Administrador',true,true,true,true),
('Usuarios',true,true,false,false),
('Invitado',false,false,false,false);