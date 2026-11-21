PRAGMA foreign_keys = ON;

-- CATEGORIAS

INSERT INTO categoria (nombre, descripcion)
VALUES
('Vasos', 'Vasos desechables'),
('Platos', 'Platos desechables'),
('Contenedores', 'Contenedores para alimentos'),
('Portacomidas', 'Portacomidas desechables'),
('Cubiertos', 'Cubiertos desechables'),
('Bolsas', 'Bolsas y empaques');


-- SUBCATEGORIAS

INSERT INTO subcategoria (id_categoria, nombre)
VALUES
(1, 'Vasos transparentes'),
(1, 'Vasos tintados'),
(1, 'Vasos de cartón'),

(2, 'Platos plásticos'),
(2, 'Platos de cartón'),

(3, 'Contenedores plásticos'),
(3, 'Contenedores de icopor'),

(4, 'Portacomidas plásticos'),
(4, 'Portacomidas de icopor'),

(5, 'Cucharas'),
(5, 'Tenedores'),
(5, 'Cuchillos'),

(6, 'Bolsas plásticas'),
(6, 'Bolsas de papel');


-- MARCAS

INSERT INTO marca (nombre)
VALUES
('Genérica'),
('Marca XYZ');


-- PRODUCTOS

INSERT INTO producto (
    id_subcategoria,
    id_marca,
    codigo,
    nombre,
    descripcion,
    color,
    material,
    capacidad,
    unidad_capacidad
)
VALUES
(
    1,
    2,
    'VAS-TR-07',
    'Vaso transparente 7 oz',
    'Vaso plástico transparente de 7 onzas',
    'Transparente',
    'Plástico',
    7,
    'oz'
);


-- PRESENTACIONES

INSERT INTO presentacion (
    id_producto,
    nombre,
    tipo,
    cantidad_unidades,
    costo,
    precio_venta
)
VALUES
(
    1,
    'Unidad',
    'UNIDAD',
    1,
    100,
    150
),
(
    1,
    'Paquete x50',
    'PAQUETE',
    50,
    5000,
    7000
);


-- INVENTARIO

INSERT INTO inventario (
    id_presentacion,
    cantidad,
    stock_minimo,
    stock_maximo
)
VALUES
(
    1,
    0,
    10,
    100
),
(
    2,
    10,
    2,
    30
);