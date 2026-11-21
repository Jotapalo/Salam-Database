PRAGMA foreign_keys = ON;

-- =========================================================
-- CATEGORIA
-- =========================================================

CREATE TABLE IF NOT EXISTS categoria (
    id_categoria INTEGER PRIMARY KEY AUTOINCREMENT,
    nombre TEXT NOT NULL UNIQUE,
    descripcion TEXT
);


-- =========================================================
-- SUBCATEGORIA
-- =========================================================

CREATE TABLE IF NOT EXISTS subcategoria (
    id_subcategoria INTEGER PRIMARY KEY AUTOINCREMENT,
    id_categoria INTEGER NOT NULL,
    nombre TEXT NOT NULL,
    descripcion TEXT,

    FOREIGN KEY (id_categoria)
        REFERENCES categoria(id_categoria),

    UNIQUE (id_categoria, nombre)
);


-- =========================================================
-- MARCA
-- =========================================================

CREATE TABLE IF NOT EXISTS marca (
    id_marca INTEGER PRIMARY KEY AUTOINCREMENT,
    nombre TEXT NOT NULL UNIQUE,
    descripcion TEXT,
    estado INTEGER NOT NULL DEFAULT 1
);


-- =========================================================
-- PRODUCTO
-- =========================================================

CREATE TABLE IF NOT EXISTS producto (
    id_producto INTEGER PRIMARY KEY AUTOINCREMENT,

    id_subcategoria INTEGER NOT NULL,
    id_marca INTEGER,

    codigo TEXT UNIQUE,
    nombre TEXT NOT NULL,
    descripcion TEXT,

    color TEXT,
    material TEXT,

    capacidad REAL,
    unidad_capacidad TEXT,

    estado INTEGER NOT NULL DEFAULT 1,

    FOREIGN KEY (id_subcategoria)
        REFERENCES subcategoria(id_subcategoria),

    FOREIGN KEY (id_marca)
        REFERENCES marca(id_marca)
);


-- =========================================================
-- PRESENTACION
-- =========================================================

CREATE TABLE IF NOT EXISTS presentacion (
    id_presentacion INTEGER PRIMARY KEY AUTOINCREMENT,

    id_producto INTEGER NOT NULL,

    nombre TEXT NOT NULL,

    tipo TEXT NOT NULL,

    cantidad_unidades INTEGER NOT NULL,

    costo REAL NOT NULL DEFAULT 0,
    precio_venta REAL NOT NULL DEFAULT 0,

    codigo_barras TEXT,

    estado INTEGER NOT NULL DEFAULT 1,

    FOREIGN KEY (id_producto)
        REFERENCES producto(id_producto),

    CHECK (cantidad_unidades > 0),
    CHECK (costo >= 0),
    CHECK (precio_venta >= 0),

    UNIQUE (id_producto, nombre)
);


-- =========================================================
-- INVENTARIO
-- =========================================================

CREATE TABLE IF NOT EXISTS inventario (
    id_inventario INTEGER PRIMARY KEY AUTOINCREMENT,

    id_presentacion INTEGER NOT NULL UNIQUE,

    cantidad INTEGER NOT NULL DEFAULT 0,

    stock_minimo INTEGER NOT NULL DEFAULT 0,
    stock_maximo INTEGER,

    ubicacion TEXT,

    FOREIGN KEY (id_presentacion)
        REFERENCES presentacion(id_presentacion),

    CHECK (cantidad >= 0),
    CHECK (stock_minimo >= 0),
    CHECK (
        stock_maximo IS NULL
        OR stock_maximo >= stock_minimo
    )
);


-- =========================================================
-- MOVIMIENTOS DE INVENTARIO
-- =========================================================

CREATE TABLE IF NOT EXISTS movimiento_inventario (
    id_movimiento INTEGER PRIMARY KEY AUTOINCREMENT,

    id_presentacion INTEGER NOT NULL,

    tipo_movimiento TEXT NOT NULL,

    cantidad INTEGER NOT NULL,

    fecha TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,

    motivo TEXT,
    observacion TEXT,

    FOREIGN KEY (id_presentacion)
        REFERENCES presentacion(id_presentacion),

    CHECK (cantidad > 0),

    CHECK (
        tipo_movimiento IN (
            'COMPRA',
            'VENTA',
            'AJUSTE_ENTRADA',
            'AJUSTE_SALIDA',
            'DEVOLUCION',
            'APERTURA_PAQUETE'
        )
    )
);


-- =========================================================
-- PROVEEDOR
-- =========================================================

CREATE TABLE IF NOT EXISTS proveedor (
    id_proveedor INTEGER PRIMARY KEY AUTOINCREMENT,

    nombre TEXT NOT NULL,

    nit TEXT,
    telefono TEXT,
    direccion TEXT,
    email TEXT,

    contacto TEXT,

    estado INTEGER NOT NULL DEFAULT 1
    tipo_documento	TEXT NOT NULL DEFAULT 'NIT',

	CHECK("tipo_documento" IN ('CC', 'NIT'))
);


-- =========================================================
-- COMPRA
-- =========================================================

CREATE TABLE IF NOT EXISTS compra (
    id_compra INTEGER PRIMARY KEY AUTOINCREMENT,

    id_proveedor INTEGER NOT NULL,

    fecha TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,

    subtotal REAL NOT NULL DEFAULT 0,
    descuento REAL NOT NULL DEFAULT 0,
    impuesto REAL NOT NULL DEFAULT 0,
    total REAL NOT NULL DEFAULT 0,

    estado TEXT NOT NULL DEFAULT 'COMPLETADA',

    FOREIGN KEY (id_proveedor)
        REFERENCES proveedor(id_proveedor),

    CHECK (subtotal >= 0),
    CHECK (descuento >= 0),
    CHECK (impuesto >= 0),
    CHECK (total >= 0)
);


-- =========================================================
-- DETALLE COMPRA
-- =========================================================

CREATE TABLE IF NOT EXISTS detalle_compra (
    id_detalle_compra INTEGER PRIMARY KEY AUTOINCREMENT,

    id_compra INTEGER NOT NULL,
    id_presentacion INTEGER NOT NULL,

    cantidad INTEGER NOT NULL,

    costo_unitario REAL NOT NULL,

    subtotal REAL NOT NULL,

    FOREIGN KEY (id_compra)
        REFERENCES compra(id_compra),

    FOREIGN KEY (id_presentacion)
        REFERENCES presentacion(id_presentacion),

    CHECK (cantidad > 0),
    CHECK (costo_unitario >= 0),
    CHECK (subtotal >= 0)
);


-- =========================================================
-- CLIENTE
-- =========================================================

CREATE TABLE IF NOT EXISTS cliente (
    id_cliente INTEGER PRIMARY KEY AUTOINCREMENT,

    nombre TEXT NOT NULL,

    documento	TEXT NOT NULL UNIQUE,
    telefono TEXT,
    direccion TEXT,
    email TEXT,

    tipo_cliente TEXT NOT NULL DEFAULT 'CONSUMIDOR_FINAL',

    estado INTEGER NOT NULL DEFAULT 1,

    CHECK (
        tipo_cliente IN (
            'CONSUMIDOR_FINAL',
            'NEGOCIO',
            'RESTAURANTE',
            'REVENDEDOR'
        )
    )
);


-- =========================================================
-- VENTA
-- =========================================================

CREATE TABLE IF NOT EXISTS venta (
    id_venta INTEGER PRIMARY KEY AUTOINCREMENT,

    id_cliente INTEGER,

    fecha TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,

    subtotal REAL NOT NULL DEFAULT 0,
    descuento REAL NOT NULL DEFAULT 0,
    impuesto REAL NOT NULL DEFAULT 0,
    total REAL NOT NULL DEFAULT 0,

    metodo_pago TEXT,

    estado TEXT NOT NULL DEFAULT 'COMPLETADA',

    FOREIGN KEY (id_cliente)
        REFERENCES cliente(id_cliente),

    CHECK (subtotal >= 0),
    CHECK (descuento >= 0),
    CHECK (impuesto >= 0),
    CHECK (total >= 0)
);


-- =========================================================
-- DETALLE VENTA
-- =========================================================

CREATE TABLE IF NOT EXISTS detalle_venta (
    id_detalle_venta INTEGER PRIMARY KEY AUTOINCREMENT,

    id_venta INTEGER NOT NULL,
    id_presentacion INTEGER NOT NULL,

    cantidad INTEGER NOT NULL,

    precio_unitario REAL NOT NULL,

    descuento REAL NOT NULL DEFAULT 0,

    subtotal REAL NOT NULL,

    FOREIGN KEY (id_venta)
        REFERENCES venta(id_venta),

    FOREIGN KEY (id_presentacion)
        REFERENCES presentacion(id_presentacion),

    CHECK (cantidad > 0),
    CHECK (precio_unitario >= 0),
    CHECK (descuento >= 0),
    CHECK (subtotal >= 0)
);


-- =========================================================
-- USUARIOS DEL SISTEMA
-- =========================================================

CREATE TABLE IF NOT EXISTS usuarios_sistema (
    id_usuario INTEGER PRIMARY KEY AUTOINCREMENT,
    nombre TEXT NOT NULL,
    usuario TEXT NOT NULL UNIQUE,
    contrasena TEXT NOT NULL,
    rol TEXT NOT NULL DEFAULT 'VENDEDOR',
    estado INTEGER NOT NULL DEFAULT 1,
    CHECK (
        rol IN (
            'ADMINISTRADOR',
            'VENDEDOR'
        )
    )
);