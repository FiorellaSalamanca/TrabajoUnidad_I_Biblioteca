--Crear Base de Datos
CREATE DATABASE db_Biblioteca
GO
USE db_Biblioteca
GO
--crear tablas
CREATE TABLE tbl_persona
(
	cod_persona int IDENTITY NOT NULL PRIMARY KEY,
	dni_persona varchar(8) NOT NULL,
	nomb_persona varchar(250) NOT NULL,
	apel_persona varchar(250) NOT NULL,
	sexo_persona char(1) NOT NULL,
	email_persona varchar(250) NULL,
	tel_persona varchar(15) NULL,
	foto_persona varchar(250) NULL,
	estado_persona varchar(10) NOT NULL	
)
GO
CREATE TABLE tbl_tipo_usuario
(
	id_tipo int IDENTITY NOT NULL PRIMARY KEY,
	desc_tipo varchar(250) NOT NULL
)
GO
CREATE TABLE tbl_usuario ---
(
	id_usuario int IDENTITY NOT NULL PRIMARY KEY,
	cod_persona int NOT NULL,
	nomb_usuario varchar(50) NOT NULL,
	pass_usuario varchar(100) NOT NULL,
	id_tipo int NOT NULL,
	estado_usuario varchar(10) NOT NULL,
	FOREIGN KEY (cod_persona) REFERENCES tbl_persona (cod_persona),
	FOREIGN KEY (id_tipo) REFERENCES tbl_tipo_usuario (id_tipo)
)
GO
CREATE TABLE tbl_autor
(
	id_autor int IDENTITY NOT NULL PRIMARY KEY, 
	nom_autor varchar(250) NOT NULL,
	apel_autor varchar(250) NOT NULL
)
GO
CREATE TABLE tbl_editorial
(
	id_editorial int IDENTITY NOT NULL PRIMARY KEY,
	nomb_editorial varchar(250) NOT NULL,
	dir_editorial varchar(550),
	tel_editorial varchar(15)
)
GO
CREATE TABLE tbl_edicion
(
	id_edicion int IDENTITY NOT NULL PRIMARY KEY,
	num_edicion varchar(250) NOT NULL,
	num_ISBN varchar(350) NOT NULL,
	año_publicacion varchar(5)
)
GO
CREATE TABLE tbl_categoria
(
	id_categoria int IDENTITY NOT NULL PRIMARY KEY,
	nomb_categoria varchar(250) NOT NULL
)
GO
CREATE TABLE tbl_libro ---
(
	id_libro int IDENTITY NOT NULL PRIMARY KEY,
	id_autor int NOT NULL,
	id_editorial int NOT NULL,
	id_edicion int NOT NULL,
	id_categoria int NOT NULL,
	tit_libro varchar(350) NOT NULL,
	subtit_libro varchar (250),
	estado_libro varchar(15) NOT NULL,
	idioma_libro varchar(50),
	num_pag_libro int,
	num_ejemplares int NOT NULL,
	FOREIGN KEY (id_autor) REFERENCES tbl_autor(id_autor),
	FOREIGN KEY (id_editorial) REFERENCES tbl_editorial(id_editorial),
	FOREIGN KEY (id_edicion) REFERENCES tbl_edicion(id_edicion),
	FOREIGN KEY (id_categoria) REFERENCES tbl_categoria(id_categoria)
)
GO
CREATE TABLE tbl_ejemplar ---
(
	cod_ejemplar int NOT NULL identity PRIMARY KEY,
	id_libro int NOT NULL,
	estado_ejemplar varchar(100) NOT NULL,
	conserv_ejemplar varchar(100) NOT NULL,
	ciclo varchar(20) NOT NULL,
	Fecha_Adquirido date NOT NULL,
	Fecha_Registrado date NOT NULL
	FOREIGN KEY (id_libro) REFERENCES tbl_libro(id_libro)
)
GO
CREATE TABLE tbl_favorito ---
(
	cod_favoritos int NOT NULL identity PRIMARY KEY, 
	id_usuario int NOT NULL,
	cod_ejemplar int NOT NULL, 
	FOREIGN KEY (id_usuario) REFERENCES tbl_usuario(id_usuario),
	FOREIGN KEY (cod_ejemplar) REFERENCES tbl_ejemplar(cod_ejemplar)
)
GO
CREATE TABLE tbl_reserva ---
(
	cod_reserva int NOT NULL identity PRIMARY KEY,
	id_usuario int NOT NULL,
	cod_ejemplar int NOT NULL, 
	fecha_reserva date NOT NULL,	
	periodo_reserva int NOT NULL,
	FOREIGN KEY (id_usuario) REFERENCES tbl_usuario(id_usuario),
	FOREIGN KEY (cod_ejemplar) REFERENCES tbl_ejemplar(cod_ejemplar)
)
GO
CREATE TABLE tbl_prestamo --
(
	cod_prestamo int NOT NULL identity PRIMARY KEY,
	cod_reserva int NOT NULL,
	fecha_prestamo date NOT NULL,	
	fecha_entrega date NOT NULL,	
	FOREIGN KEY (cod_reserva) REFERENCES tbl_reserva(cod_reserva)
)
GO
CREATE TABLE tbl_historial---
(
	cod_historial int NOT NULL identity PRIMARY KEY,	
	cod_prestamo int NOT NULL,
	cod_reserva int NOT NULL,
	id_usuario int NOT NULL,
	cod_ejemplar int NOT NULL,
	fecha date NOT NULL,
	FOREIGN KEY (cod_prestamo) REFERENCES tbl_prestamo(cod_prestamo),
	FOREIGN KEY (cod_reserva) REFERENCES tbl_reserva(cod_reserva),
	FOREIGN KEY (id_usuario) REFERENCES tbl_usuario(id_usuario),
	FOREIGN KEY (cod_ejemplar) REFERENCES tbl_ejemplar(cod_ejemplar)
)
GO
CREATE TABLE tbl_ranking---
(
	cod_ranking int NOT NULL identity PRIMARY KEY,
	cod_ejemplar int NOT NULL,
	num_prestamo int NOT NULL,
	num_puesto int NOT NULL,
	FOREIGN KEY (cod_ejemplar) REFERENCES tbl_ejemplar(cod_ejemplar)
)
GO