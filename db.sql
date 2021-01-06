/**

    DATABASE:  videojuegos

**/

CREATE TABLE clientes(
    id int primary key identity(1,1),
    nombre varchar(55) not null,
    estatus tinyint null default 0
)

CREATE TABLE videojuegos(
    id int primary key identity(1,1),
    nombre varchar(55) not null,
    estatus tinyint null default 0
)

CREATE TABLE inventarios(
    id int primary key identity(1,1),
    videojuego_id int not null,
    existencias int not null,
    estatus tinyint null default 0,
    FOREIGN KEY (videojuego_id) REFERENCES videojuegos(id)
)

CREATE TABLE usuarios(
    id int primary key identity(1,1),
    nombre varchar(55) not null,
    nombre_real varchar(55) not null,
    pass varchar(18) not null,
    estatus tinyint null default 0
)

CREATE TABLE auditorias(
    id int primary key identity(1,1),
    fecha Date not null DEFAULT GETDATE(),
    accion varchar(100) not null,
    usuario_id int not null,
    estatus tinyint null default 0,
    FOREIGN KEY (usuario_id) REFERENCES usuarios(id)
)

CREATE TABLE rentas(
    id int primary key identity(1,1),
    fecha Date DEFAULT GETDATE(),
    usuario_id int not null,
    cliente_id int not null,
    estatus tinyint null default 0,
    total numeric(7,2) not null,
    FOREIGN KEY (usuario_id) REFERENCES usuarios(id),
    FOREIGN KEY (cliente_id) REFERENCES clientes(id)
)

CREATE TABLE rentas_detalles(
    id int primary key identity(1,1),
    renta_id int not null,
    videojuego_id int not null,
    cantidad int not null,
    importe numeric(7,2) not null,
    estatus tinyint null default 0,
    FOREIGN KEY (renta_id) REFERENCES rentas(id),
    FOREIGN KEY (videojuego_id) REFERENCES videojuegos(id)
)
