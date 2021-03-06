--PROYECTO BINAES
drop database BINAES;
CREATE DATABASE BINAES;

USE BINAES;

CREATE TABLE EJEMPLAR(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(100) NOT NULL,
	imagen VARCHAR(100) NOT NULL,
	autor VARCHAR(50) NOT NULL,
	fecha_publicacion DATE NOT NULL,
	disponibilidad BIT NOT NULL,
	id_coleccion INT NOT NULL,
	id_idioma INT NULL,
	id_editorial INT NOT NULL,
	id_formato INT NOT NULL
);

CREATE TABLE EDITORIAL(
	id INT PRIMARY KEY IDENTITY,
	editorial VARCHAR(50) NOT NULL
);

CREATE TABLE FORMATO_EJEMPLAR(
	id INT PRIMARY KEY IDENTITY,
	formato VARCHAR(10) NOT NULL
);

CREATE TABLE IDIOMA_EJEMPLAR(
	id INT PRIMARY KEY IDENTITY,
	idioma VARCHAR(20) NOT NULL
);

CREATE TABLE NOMBRE_ETIQUETA(
	id INT PRIMARY KEY IDENTITY,
	nombre CHAR(4) NOT NULL
);

CREATE TABLE ETIQUETA(
	id INT PRIMARY KEY IDENTITY,
	etiqueta VARCHAR(11) NOT NULL,
	id_nombre_etiqueta INT NULL,
	id_ejemplar INT NOT NULL
);

CREATE TABLE GENERO_COLECCION(
	id INT PRIMARY KEY IDENTITY,
	genero VARCHAR(20) NOT NULL
);

CREATE TABLE TIPO_COLECCION(
	id INT PRIMARY KEY IDENTITY,
	tipo VARCHAR(30) NOT NULL
);

CREATE TABLE COLECCION(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50) NOT NULL,
	id_tipo INT NULL,
	id_genero INT NULL
);

-- CREATE TABLE AUTOR(
-- 	id INT PRIMARY KEY IDENTITY,
-- 	nombre VARCHAR(50) NOT NULL
-- );

-- CREATE TABLE AUTORXEJEMPLAR(
--     id_autor INT NOT NULL,
--     id_ejemplar INT NOT NULL
-- );

CREATE TABLE PALABRA_CLAVE(
	id INT PRIMARY KEY IDENTITY,
	palabra VARCHAR(20) NOT NULL,
	id_ejemplar INT NOT NULL
);

CREATE TABLE RESERVA(
	id INT PRIMARY KEY IDENTITY,
	fecha_reserva DATETIME NOT NULL 
				  DEFAULT GETDATE(),
	fecha_prestamo DATETIME NULL,
	fecha_devolucion DATETIME NULL,
	id_ejemplar INT NULL,
	id_usuario INT NULL
);

CREATE TABLE PRESTAMO(
	id INT PRIMARY KEY IDENTITY,
	fecha_prestamo DATETIME NOT NULL
				   DEFAULT GETDATE(),
	fecha_devolucion DATETIME NULL,
	id_ejemplar INT NULL,
	id_usuario INT NULL 
);

CREATE TABLE ROL(
	id CHAR(6) PRIMARY KEY,
    rol VARCHAR(25) NOT NULL
);

CREATE TABLE OCUPACION_USUARIO(
	id INT PRIMARY KEY IDENTITY,
	ocupacion VARCHAR(30) NOT NULL
);

CREATE TABLE USUARIO(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50) NOT NULL,
	institucion VARCHAR(50) NOT NULL,
	direccion VARCHAR(255) NOT NULL,
	telefono CHAR(9) 
					 NOT NULL	
					 UNIQUE
					 CHECK(telefono LIKE '[2|6|7][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	fotografia VARCHAR(100) NOT NULL DEFAULT 'user.png',
	email VARCHAR(50) 
					   NOT NULL
					   UNIQUE
					   CHECK(email LIKE '%@%.%'),							
	contrasenia VARCHAR(100) NULL,
	id_rol CHAR(6) NOT NULL DEFAULT 'ROL_00',
	id_ocupacion INT NULL
);

CREATE TABLE DESCRIPCION_AREA (
	id CHAR(6) PRIMARY KEY,
	nombre VARCHAR(40) NOT NULL,
	descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE AREA(
	id INT PRIMARY KEY IDENTITY,
	horario_abierto VARCHAR(20) NOT NULL,
	nombre_responsable VARCHAR(50) NOT NULL,
	piso INT NOT NULL,
	id_descripcion_area CHAR(6) NOT NULL
);

CREATE TABLE INGRESO(
	id INT PRIMARY KEY IDENTITY,
	fecha_entrada DATETIME NOT NULL,
	fecha_salida DATETIME NULL,
	id_area INT NOT NULL,
	id_usuario INT NULL
);

CREATE TABLE EVENTO(
	id INT PRIMARY KEY IDENTITY,
	titulo VARCHAR(50) NOT NULL,
    imagen VARCHAR(100) NOT NULL,
    objetivos TEXT NOT NULL,
	fecha_inicio DATETIME NOT NULL,
	fecha_fin DATETIME NOT NULL,
	numero_asistentes INT NOT NULL,
	id_area INT NULL
);

-- CREATE TABLE OBJETIVO_EVENTO(
-- 	id INT PRIMARY KEY IDENTITY,
-- 	objetivo VARCHAR(150) NOT NULL,
-- 	id_evento INT NOT NULL
-- );
GO

--Creacion de llaves foraneas

ALTER TABLE ETIQUETA
ADD CONSTRAINT fk_etiqueta_ejemplar
FOREIGN KEY (id_ejemplar) REFERENCES EJEMPLAR(id)
ON DELETE CASCADE;

ALTER TABLE ETIQUETA 
ADD CONSTRAINT fk_etiqueta_nombre_etiqueta 
FOREIGN KEY (id_nombre_etiqueta) REFERENCES NOMBRE_ETIQUETA(id)
ON DELETE SET NULL;

ALTER TABLE COLECCION 
ADD CONSTRAINT fk_coleccion_genero 
FOREIGN KEY (id_genero) REFERENCES GENERO_COLECCION(id)
ON DELETE SET NULL;

ALTER TABLE COLECCION 
ADD CONSTRAINT fk_coleccion_tipo 
FOREIGN KEY (id_tipo) REFERENCES TIPO_COLECCION(id)
ON DELETE SET NULL;

ALTER TABLE EJEMPLAR 
ADD CONSTRAINT fk_ejemplar_coleccion 
FOREIGN KEY (id_coleccion) REFERENCES COLECCION (id)
ON DELETE CASCADE;

ALTER TABLE EJEMPLAR 
ADD CONSTRAINT fk_ejemplar_idioma 
FOREIGN KEY (id_idioma) REFERENCES IDIOMA_EJEMPLAR(id)
ON DELETE SET NULL;

ALTER TABLE EJEMPLAR 
ADD CONSTRAINT fk_ejemplar_editorial 
FOREIGN KEY (id_editorial) REFERENCES EDITORIAL (id)
ON DELETE CASCADE;

ALTER TABLE EJEMPLAR 
ADD CONSTRAINT fk_ejemplar_formato_ejemplar 
FOREIGN KEY (id_formato) REFERENCES FORMATO_EJEMPLAR (id)
ON DELETE CASCADE;

ALTER TABLE PRESTAMO 
ADD CONSTRAINT fk_ejemplar_prestamo 
FOREIGN KEY (id_ejemplar) REFERENCES EJEMPLAR (id)
ON DELETE SET NULL;

ALTER TABLE PRESTAMO 
ADD CONSTRAINT fk_usuario_prestamo 
FOREIGN KEY (id_usuario) REFERENCES USUARIO(id)
ON DELETE SET NULL;

-- ALTER TABLE AUTORXEJEMPLAR 
-- ADD CONSTRAINT pk_autorxejemplar 
-- PRIMARY KEY (id_autor, id_ejemplar);

-- ALTER TABLE AUTORXEJEMPLAR 
-- ADD CONSTRAINT fk_autorxejemplar_ejemplar 
-- FOREIGN KEY (id_ejemplar) REFERENCES EJEMPLAR(id)
-- ON DELETE CASCADE;

-- ALTER TABLE AUTORXEJEMPLAR 
-- ADD CONSTRAINT fk_autorxejemplar_autor 
-- FOREIGN KEY (id_autor) REFERENCES AUTOR(id)
-- ON DELETE NO ACTION;

ALTER TABLE PALABRA_CLAVE 
ADD CONSTRAINT fk_palabra_clave_ejemplar 
FOREIGN KEY (id_ejemplar) REFERENCES EJEMPLAR(id)
ON DELETE CASCADE;

ALTER TABLE RESERVA 
ADD CONSTRAINT fk_reserva_ejemplar 
FOREIGN KEY (id_ejemplar) REFERENCES EJEMPLAR(id)
ON DELETE SET NULL;

ALTER TABLE RESERVA 
ADD CONSTRAINT fk_reserva_usuario 
FOREIGN KEY (id_usuario) REFERENCES USUARIO(id)
ON DELETE SET NULL;

ALTER TABLE USUARIO 
ADD CONSTRAINT fk_usuario_rol 
FOREIGN KEY (id_rol) REFERENCES ROL(id)
ON DELETE SET DEFAULT;

ALTER TABLE USUARIO 
ADD CONSTRAINT fk_usuario_ocupacion 
FOREIGN KEY (id_ocupacion) REFERENCES OCUPACION_USUARIO(id)
ON DELETE SET NULL;

ALTER TABLE INGRESO 
ADD CONSTRAINT fk_ingreso_area 
FOREIGN KEY (id_area) REFERENCES AREA(id)
ON DELETE NO ACTION;

ALTER TABLE INGRESO 
ADD CONSTRAINT fk_ingreso_usuario 
FOREIGN KEY (id_usuario) REFERENCES USUARIO(id)
ON DELETE SET NULL;

ALTER TABLE EVENTO 
ADD CONSTRAINT fk_evento_area 
FOREIGN KEY (id_area) REFERENCES AREA(id)
ON DELETE SET NULL;

-- ALTER TABLE OBJETIVO_EVENTO 
-- ADD CONSTRAINT fk_objetivo_evento_evento 
-- FOREIGN KEY (id_evento) REFERENCES EVENTO(id)
-- ON DELETE CASCADE;

ALTER TABLE AREA
ADD CONSTRAINT fk_area_descripcion_area
FOREIGN KEY (id_descripcion_area) REFERENCES DESCRIPCION_AREA(id)
ON DELETE CASCADE; 
GO


SELECT * FROM ROL;
SELECT * FROM USUARIO;
SELECT * FROM COLECCION; 
SELECT * FROM TIPO_COLECCION;

@nombre = ""

UPDATE USUARIO SET nombre = @nombre, institucion = @institucion, direccion = @direccion, telefono = @telefono, fotografia = @fotografia, email = @email, id_rol = @id_rol, id_ocupacion = @id_ocupacion

SELECT c.id, c.nombre 'nombre', tc.tipo 'tipo', tc.id 'id_tipo',gc.genero 'genero', gc.id 'id_genero' FROM 
                    COLECCION c
                    INNER JOIN TIPO_COLECCION tc
                        ON c.id_tipo = tc.id
                    INNER JOIN GENERO_COLECCION gc
                        ON c.id_genero = gc.id 

SELECT * FROM GENERO_COLECCION;
