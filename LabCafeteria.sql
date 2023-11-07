CREATE DATABASE LabCafeteria;

USE master 
GO
CREATE LOGIN usrcafeteria WITH PASSWORD=N'123456789',
     DEFAULT_DATABASE=LabCafeteria,
     CHECK_EXPIRATION=OFF,
     CHECK_POLICY=ON
GO 
USE LabCafeteria
GO 
CREATE USER usrcafeteria FOR LOGIN usrcafeteria
GO 
ALTER ROLE db_owner ADD MEMBER usrcafeteria
GO

DROP TABLE Producto;
DROP TABLE Categoria;
DROP TABLE Usuario;
DROP TABLE Empleado;

CREATE TABLE Empleado(
  idEmpleado INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(20) NOT NULL,
  apellidoPaterno VARCHAR(20) NOT NULL,
  apellidoMaterno VARCHAR(20) NOT NULL,
  telefono VARCHAR(20) NOT NULL,
  direccion VARCHAR(50) NOT NULL,
  cargo VARCHAR(20) NOT NULL,
  salario FLOAT NOT NULL,
);

CREATE TABLE Usuario(
  idUsuario INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(30) NOT NULL,
  contraseña VARCHAR(30) NOT NULL,
  FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado)
);

CREATE TABLE Categoria(
  idCategoria INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(30) NOT NULL
);

CREATE TABLE Producto(
  idProducto INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCategoria INT NOT NULL,
  codigo VARCHAR(20) NOT NULL,
  nombre VARCHAR(50) NOT NULL,
  descripcion VARCHAR(500) NOT NULL,
  precio DECIMAL (5,2) NOT NULL,
  FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria)
);

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Categoria ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Categoria ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Categoria ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1;

--Procedimientos Almacenados
CREATE PROC paEmpleadoListar @parametro VARCHAR(50)
AS
  SELECT idEmpleado,nombre,apellidoPaterno,apellidoMaterno,telefono,direccion,cargo,salario
  FROM Empleado
  WHERE estado<>-1 AND nombre LIKE '%'+REPLACE(@parametro,' ','%')+'%';

CREATE PROCEDURE paProductosListar @parametro VARCHAR(50)
AS
  SELECT p.*, c.nombre AS categoria
  FROM producto AS p
  INNER JOIN categoria AS c ON p.idCategoria = c.idCategoria
  WHERE p.estado<>-1 AND p.nombre LIKE '%'+REPLACE(@parametro,' ','%')+'%';