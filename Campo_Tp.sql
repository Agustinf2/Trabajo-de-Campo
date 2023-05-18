create database POO_grupo2bd
use POO_grupo2bd

 insert into Perfiles values('Super admin'),('Cliente'),('Vendedor')
 insert into Articulos values ('Barbijos','25','200'),('Bufandas','30','900'),('Chaleco','20','2500')

insert into Usuarios values('43767827','agustin@gmail.com',ENCRYPTBYPASSPHRASE('contraseña','clave'),'Agustin','3364529379',1)
insert into Usuarios values('43767827','agusfaucetta@gmail.com',ENCRYPTBYPASSPHRASE('contraseña','clave'),'Joaquin','3364529359',2)
insert into Usuarios values('43767827','agustinfauceta@gmail.com',ENCRYPTBYPASSPHRASE('contraseña','clave'),'Juanmanuel','3364529370',3)


 select * from Usuarios
 select * from Perfiles
 select * from Articulos
 select * from Detalle_ventas
