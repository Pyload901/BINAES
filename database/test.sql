INSERT INTO EJEMPLAR(nombre, imagen, fecha_publicacion, disponibilidad, id_coleccion,
	id_idioma,
	id_editorial,
	id_formato) VALUES ('eJE', 'ejemplar.png', GETDATE(), 1, 2, 2, 1, 1);

INSERT INTO PALABRA_CLAVE (palabra, id_ejemplar) VALUES ('test', 1);
INSERT INTO PALABRA_CLAVE (palabra, id_ejemplar) VALUES ('ejemplos', 1);
INSERT INTO PALABRA_CLAVE (palabra, id_ejemplar) VALUES ('nuevo', 1);

INSERT INTO ETIQUETA (etiqueta, id_nombre_etiqueta, id_ejemplar) VALUES ('828282j', 1, 1);
INSERT INTO ETIQUETA (etiqueta, id_nombre_etiqueta, id_ejemplar) VALUES ('KKK2', 2, 1);

SELECT EJ.id, EJ.nombre, EJ.imagen, EJ.fecha_publicacion, SUM(EJ.stock), C.nombre, IE.idioma, ED.editorial, F.formato, NO_ET.nombre, ET.etiqueta , PC.palabra

FROM EJEMPLAR EJ 
    INNER JOIN COLECCION C 
        ON EJ.id_coleccion = C.id
    INNER JOIN IDIOMA_EJEMPLAR IE
        ON EJ.id_idioma = IE.id
    INNER JOIN EDITORIAL ED
        ON EJ.id_editorial = ED.id
    INNER JOIN FORMATO_EJEMPLAR F
        ON EJ.id_formato = F.id
    LEFT JOIN ETIQUETA ET
        ON ET.id_ejemplar = EJ.id
    INNER JOIN NOMBRE_ETIQUETA NO_ET
        ON NO_ET.id = ET.id
    LEFT JOIN PALABRA_CLAVE PC
        ON PC.id_ejemplar = EJ.id
        
GROUP BY EJ.id, EJ.nombre, EJ.imagen, EJ.fecha_publicacion, C.nombre, IE.idioma, ED.editorial, F.formato, NO_ET.nombre, ET.etiqueta , PC.palabra;




SELECT EJ.id, EJ.nombre, EJ.imagen, EJ.fecha_publicacion, C.nombre, IE.idioma, ED.editorial, F.formato 
FROM EJEMPLAR EJ 
    INNER JOIN COLECCION C 
        ON EJ.id_coleccion = C.id
    INNER JOIN IDIOMA_EJEMPLAR IE
        ON EJ.id_idioma = IE.id
    INNER JOIN EDITORIAL ED
        ON EJ.id_editorial = ED.id
    INNER JOIN FORMATO_EJEMPLAR F
        ON EJ.id_formato = F.id

SELECT A.nombre
FROM AUTOR A
    INNER JOIN AUTORXEJEMPLAR AXE
        ON AXE.id_autor = A.id
    INNER JOIN EJEMPLAR E
        ON AXE.id_ejemplar = E.id
WHERE E.id = 1;

SELECT PC.palabra
FROM PALABRA_CLAVE PC
    INNER JOIN EJEMPLAR E
        ON E.id = PC.id_ejemplar
WHERE E.id = 1;

SELECT NET.nombre, ET.etiqueta
FROM ETIQUETA ET
    INNER JOIN EJEMPLAR EJ
        ON EJ.id = ET.id_ejemplar
    INNER JOIN NOMBRE_ETIQUETA NET
        ON NET.id = ET.id_nombre_etiqueta
WHERE EJ.id = 1;

SELECT * FROM AUTORXEJEMPLAR;
INSERT INTO AUTORXEJEMPLAR VALUES (2, 1);

SELECT EJ.id, EJ.nombre, EJ.imagen, EJ.fecha_publicacion, EJ.stock, C.nombre 'coleccion', IE.idioma 'idioma', ED.editorial 'editorial', F.formato 'formato'
                                FROM EJEMPLAR EJ
                                    INNER JOIN COLECCION C
                                        ON EJ.id_coleccion = C.id
                                    INNER JOIN IDIOMA_EJEMPLAR IE
                                        ON EJ.id_idioma = IE.id
                                    INNER JOIN EDITORIAL ED
                                        ON EJ.id_editorial = ED.id
                                    INNER JOIN FORMATO_EJEMPLAR F
                                        ON EJ.id_formato = F.id WHERE EJ.nombre LIKE 'eJE';


SELECT EJ.id, EJ.nombre, EJ.imagen, EJ.fecha_publicacion, EJ.stock, C.nombre 'coleccion', IE.idioma 'idioma', ED.editorial 'editorial', F.formato 'formato', A.nombre
                                FROM EJEMPLAR EJ
                                    INNER JOIN COLECCION C
                                        ON EJ.id_coleccion = C.id
                                    INNER JOIN IDIOMA_EJEMPLAR IE
                                        ON EJ.id_idioma = IE.id
                                    INNER JOIN EDITORIAL ED
                                        ON EJ.id_editorial = ED.id
                                    INNER JOIN FORMATO_EJEMPLAR F
                                        ON EJ.id_formato = F.id
                                    INNER JOIN AUTORXEJEMPLAR AXE
                                        ON AXE.id_ejemplar = EJ.id
                                    INNER JOIN AUTOR A
                                        ON AXE.id_autor = A.id
                    WHERE A.nombre LIKE '%A%';

SELECT A.nombre 'nombre_autor', EJ.id, EJ.nombre 'nombre_ejemplar', EJ.imagen, EJ.fecha_publicacion, EJ.stock, C.nombre 'coleccion', IE.idioma 'idioma', ED.editorial 'editorial', F.formato 'formato'
                                FROM EJEMPLAR EJ
                                    INNER JOIN COLECCION C
                                        ON EJ.id_coleccion = C.id
                                    INNER JOIN IDIOMA_EJEMPLAR IE
                                        ON EJ.id_idioma = IE.id
                                    INNER JOIN EDITORIAL ED
                                        ON EJ.id_editorial = ED.id
                                    INNER JOIN FORMATO_EJEMPLAR F
                                        ON EJ.id_formato = F.id
                                    INNER JOIN AUTORXEJEMPLAR AXE
                                        ON AXE.id_ejemplar = EJ.id
                                    INNER JOIN AUTOR A
                                        ON AXE.id_autor = A.id
                                    WHERE A.nombre LIKE '%A%'

SELECT EJ.id, EJ.nombre 'nombre_ejemplar', EJ.imagen, EJ.fecha_publicacion, EJ.stock, C.nombre 'coleccion', IE.idioma 'idioma', ED.editorial 'editorial', F.formato 'formato'
                                FROM EJEMPLAR EJ
                                    INNER JOIN COLECCION C
                                        ON EJ.id_coleccion = C.id
                                    INNER JOIN IDIOMA_EJEMPLAR IE
                                        ON EJ.id_idioma = IE.id
                                    INNER JOIN EDITORIAL ED
                                        ON EJ.id_editorial = ED.id
                                    INNER JOIN FORMATO_EJEMPLAR F
                                        ON EJ.id_formato = F.id INNER JOIN AUTORXEJEMPLAR AXE
                                        ON AXE.id_ejemplar = EJ.id
                                    INNER JOIN AUTOR A
                                        ON AXE.id_autor = A.id
                                    WHERE A.nombre LIKE '%e%' AND F.formato = 'Físico'

                                    SELECT * FROM FORMATO_EJEMPLAR;
                                    
SELECT EJ.id, EJ.nombre 'nombre_ejemplar', EJ.imagen, EJ.fecha_publicacion, EJ.stock, C.nombre 'coleccion', IE.idioma 'idioma', ED.editorial 'editorial', F.formato 'formato'
FROM EJEMPLAR EJ
    INNER JOIN COLECCION C
        ON EJ.id_coleccion = C.id
    INNER JOIN IDIOMA_EJEMPLAR IE
        ON EJ.id_idioma = IE.id
    INNER JOIN EDITORIAL ED
        ON EJ.id_editorial = ED.id
    INNER JOIN FORMATO_EJEMPLAR F
        ON EJ.id_formato = F.id
    WHERE EJ.id IN (
        SELECT * FROM dbo.GET_EJEMPLARES_IN_PALABRA_CLAVE('nuevo,test')
    );
    
SELECT dbo.GET_ID('nuevo');

SELECT * FROM PALABRA_CLAVE;

SELECT P.id_ejemplar FROM PALABRA_CLAVE P
WHERE P.palabra IN(SELECT * FROM STRING_SPLIT('nuevo,test', ','));

SELECT P.id_ejemplar FROM PALABRA_CLAVE P
    WHERE P.palabra IN('nuevo', 'test');

SELECT R.id, R.fecha_reserva, R.fecha_prestamo, R.fecha_devolucion, EJ.nombre 'ejemplar', U.nombre 'usuario'
FROM RESERVA R
    INNER JOIN EJEMPLAR EJ
        ON EJ.id = R.id_ejemplar
    INNER JOIN USUARIO U
        ON U.id = R.id_usuario;
SELECT stock FROM EJEMPLAR WHERE id = 1

INSERT INTO RESERVA (fecha_reserva, fecha_prestamo, fecha_devolucion, id_ejemplar, id_usuario) VALUES (GETDATE(), GETDATE(), GETDATE(), 1, 1)


SELECT P.id, P.fecha_prestamo, P.fecha_devolucion, U.nombre 'usuario', E.nombre 'ejemplar'  FROM PRESTAMO P INNER JOIN USUARIO U ON U.id = P.id_usuario INNER JOIN EJEMPLAR E ON E.id = P.id_ejemplar;