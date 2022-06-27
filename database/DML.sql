USE BINAES;
GO

INSERT INTO ROL VALUES ('ROL_00', 'Usuario');
INSERT INTO ROL VALUES ('ROL_01', 'Admin general');


INSERT INTO NOMBRE_ETIQUETA(nombre) VALUES ('ISSN');
INSERT INTO NOMBRE_ETIQUETA(nombre) VALUES ('ISBN');
INSERT INTO NOMBRE_ETIQUETA(nombre) VALUES ('DOI');


INSERT INTO IDIOMA_EJEMPLAR (idioma) VALUES ('Español');
INSERT INTO IDIOMA_EJEMPLAR (idioma) VALUES ('English');


INSERT INTO FORMATO_EJEMPLAR (formato) VALUES ('Físico');
INSERT INTO FORMATO_EJEMPLAR (formato) VALUES ('Digital');


INSERT INTO GENERO_COLECCION (genero) VALUES ('Documentary');
INSERT INTO GENERO_COLECCION (genero) VALUES ('Drama');
INSERT INTO GENERO_COLECCION (genero) VALUES ('Action');
INSERT INTO GENERO_COLECCION (genero) VALUES ('Adventure');
INSERT INTO GENERO_COLECCION (genero) VALUES ('Animation');


INSERT INTO TIPO_COLECCION (tipo) VALUES ('Educación');
INSERT INTO TIPO_COLECCION (tipo) VALUES ('Juvenil');
INSERT INTO TIPO_COLECCION (tipo) VALUES ('Niños');
INSERT INTO TIPO_COLECCION (tipo) VALUES ('Adultos');
INSERT INTO TIPO_COLECCION (tipo) VALUES ('Entretenimiento');
INSERT INTO TIPO_COLECCION (tipo) VALUES ('Revista');


INSERT INTO EDITORIAL (editorial) VALUES ('Santillana');
INSERT INTO EDITORIAL (editorial) VALUES ('ESE Ediciones');
INSERT INTO EDITORIAL (editorial) VALUES ('Edisal');
INSERT INTO EDITORIAL (editorial) VALUES ('Ocean Sur');


INSERT INTO COLECCION (nombre, id_tipo, id_genero) VALUES ('National Geographic', 1, 1);
INSERT INTO COLECCION (nombre, id_tipo, id_genero) VALUES ('Cipotes', 2, 1);
INSERT INTO COLECCION (nombre, id_tipo, id_genero) VALUES ('Vida nueva', 4, 2);
INSERT INTO COLECCION (nombre, id_tipo, id_genero) VALUES ('El dia y la noche', 5, 4);
INSERT INTO COLECCION (nombre, id_tipo, id_genero) VALUES ('Cuentos asombrosos', 3, 5);


-- INSERT INTO AUTOR (nombre) VALUES ('Malissia Siggs');
-- INSERT INTO AUTOR (nombre) VALUES ('Alta Wolverson');
-- INSERT INTO AUTOR (nombre) VALUES ('Kingsly McClelland');
-- INSERT INTO AUTOR (nombre) VALUES ('Priscella Andrasch');
-- INSERT INTO AUTOR (nombre) VALUES ('Chlo Garvie');
-- INSERT INTO AUTOR (nombre) VALUES ('Dan Candish');
-- INSERT INTO AUTOR (nombre) VALUES ('Christiana Childs');
-- INSERT INTO AUTOR (nombre) VALUES ('Janaya Georgot');
-- INSERT INTO AUTOR (nombre) VALUES ('Merwin Eaklee');
-- INSERT INTO AUTOR (nombre) VALUES ('Korie Goble');


INSERT INTO OCUPACION_USUARIO (ocupacion) VALUES ('Admin');
INSERT INTO OCUPACION_USUARIO (ocupacion) VALUES ('Quality Control Specialist');
INSERT INTO OCUPACION_USUARIO (ocupacion) VALUES ('Legal Assistant');
INSERT INTO OCUPACION_USUARIO (ocupacion) VALUES ('Chief Design Engineer');
INSERT INTO OCUPACION_USUARIO (ocupacion) VALUES ('Account Executive');
INSERT INTO OCUPACION_USUARIO (ocupacion) VALUES ('Quality Engineer');
INSERT INTO OCUPACION_USUARIO (ocupacion) VALUES ('GIS Technical Architect');
INSERT INTO OCUPACION_USUARIO (ocupacion) VALUES ('Teacher');
INSERT INTO OCUPACION_USUARIO (ocupacion) VALUES ('Electrical Engineer');
INSERT INTO OCUPACION_USUARIO (ocupacion) VALUES ('Software Engineer I');
INSERT INTO OCUPACION_USUARIO (ocupacion) VALUES ('Programmer Analyst IV');


INSERT INTO DESCRIPCION_AREA VALUES ('AR_LUD', 'Salón lúdico', 'área para juegos, creatividad y aprendizaje de los niños y niñas');
INSERT INTO DESCRIPCION_AREA VALUES ('AR_AUD', 'Auditórium', 'área para eventos grandes');
INSERT INTO DESCRIPCION_AREA VALUES ('AR_PRO', 'Sala de proyección', 'área para eventos grandes donde se necesite realizar presentaciones digitales');
INSERT INTO DESCRIPCION_AREA VALUES ('AR_COM', 'Área de computación', 'área de acceso a computadoras e internet');
INSERT INTO DESCRIPCION_AREA VALUES ('AR_INC', 'Área de promoción de inclusión', 'área para promover la inclusión de todas las personas en la sociedad');
INSERT INTO DESCRIPCION_AREA VALUES ('AR_INV', 'Sala de investigación', 'área especializada para realizar todo tipo de investigaciones');
INSERT INTO DESCRIPCION_AREA VALUES ('AR_BIB', 'Área de biblioteca', 'área para estudiar, leer y prestar ejemplares');


INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('12 HORAS', 'John Doe', 1, 'AR_LUD');

INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('12 HORAS', 'Claudius De Giorgi', 2, 'AR_LUD');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('12 HORAS', 'Elmer Kittel', 1, 'AR_AUD');

INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('12 HORAS', 'Tobias Huws', 2, 'AR_PRO');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('12 HORAS', 'Janella Lehrmann', 3, 'AR_PRO');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('12 HORAS', 'Lauretta Savoury', 4, 'AR_PRO');

INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Jeremias Franke', 1, 'AR_COM');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Derrick Salvati', 1, 'AR_COM');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Reese Pennycuick', 2, 'AR_COM');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Rob Secretan', 2, 'AR_COM');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Minny Sushams', 3, 'AR_COM');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Kristien Bree', 3, 'AR_COM');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Berget Jedrzejczak', 4, 'AR_COM');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Joy Vousden', 4, 'AR_COM');

INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('12 HORAS', 'Tadeas Havard', 1, 'AR_INC');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('12 HORAS', 'Danyelle Bligh', 1, 'AR_INC');

INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Ciro Pallas', 4, 'AR_INV');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Mei Sabbin', 4, 'AR_INV');

INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Reina Croix', 1, 'AR_BIB');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Quinton Sneden', 1, 'AR_BIB');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Petronilla Baurerich', 2, 'AR_BIB');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Clarey Manning', 2, 'AR_BIB');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Kennith Wellsman', 3, 'AR_BIB');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Martha Perassi', 3, 'AR_BIB');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Johnna Manicomb', 4, 'AR_BIB');
INSERT INTO AREA (horario_abierto, nombre_responsable, piso, id_descripcion_area) VALUES ('24 HORAS', 'Debbie Readmire', 4, 'AR_BIB');


INSERT INTO USUARIO (nombre, institucion, direccion, telefono, fotografia, email, contrasenia, id_rol, id_ocupacion) VALUES ('admin', 'Institucion', 'BINAES', 70756423, 'user.png', 'admin@gmail.com', '$2a$11$jK8uFrwOMi5l5gz99ksFaecw1oZ.dZyAZnD2RgtroeTGSx.MmZy0G', 'ROL_01', 1);

INSERT INTO EVENTO (titulo, imagen, objetivos, fecha_inicio, fecha_fin, numero_asistentes, id_area) VALUES ('mi envento', 'evento.png', 'mis objetivos',GETDATE(), GETDATE(), 10, 1);