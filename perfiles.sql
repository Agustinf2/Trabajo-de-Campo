create database Trabajo_Campo22
use Trabajo_Campo22

use POO_grupo2bd

 insert into Perfiles values('Admin'),('Cliente'),('Vendedor')
 insert into Articulos values ('Pulover','20','5000'),('Cardigan','10','11000'),('Cardigan Harry','10','12500'),('Cardigan Taylor','15','13000')

 insert into Perfiles values('Super admin'),('Cliente'),('Vendedor')
 insert into Articulos values ('Mayonesa','100','200'),('Salchicha','200','90'),('Coca-cola','1','250')

insert into Usuarios values('43767827','admin',ENCRYPTBYPASSPHRASE('contraseña','clave'),'Agustin','3364529381',1)
insert into Usuarios values('41767827','cliente',ENCRYPTBYPASSPHRASE('contraseña','clave'),'Joaquin','3364529371',2)
insert into Usuarios values('40767827','vendedor',ENCRYPTBYPASSPHRASE('contraseña','clave'),'Ariana','3364529361',3)


insert into Proveedores values ('1234','Pablo Saldias','12000','12')
insert into Proveedores values ('124','Pablo Paco','12000','10')
insert into Proveedores values ('123','Pablo Sone','12000','5')


 select * from Usuarios
 select * from Perfiles
 select * from Articulos
 select * from Detalle_ventas
 select * from Proveedores


 create table Proveedores(
 id_proveedor int primary key,
 nombre_prov nvarchar(60),
 saldo nvarchar (60),
 id_articulo int foreign key references Articulos(Id)
 )

 create table Orden_Compra(
 id_ordenC int primary key,
 id_proveedor int foreign key references Proveedores(id_proveedor),
 fecha_inicio date,
 fecha_fin date
 )

 create table Detalle_OrdenCom(
 Num_OrdCom int primary key,
 Cantidad int,
 id_articulo int foreign key references Articulos(id),
 Precio_Uni decimal,
 Total_Ped decimal
 )

 create table Estado_OC(
 id_ordenC int foreign key references Orden_Compra(id_ordenC),
 Estado nvarchar (60)
 )