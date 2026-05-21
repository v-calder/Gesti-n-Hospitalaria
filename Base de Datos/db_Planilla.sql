CREATE DATABASE GestionHospitalariaDB;
GO
USE GestionHospitalariaDB;
GO

-- Tablas de Seguridad
CREATE TABLE Tbl_Roles (
    CodigoRol INT PRIMARY KEY IDENTITY(1,1),
    NombreRol VARCHAR(50) NOT NULL,
    Estado BIT DEFAULT 1
);

CREATE TABLE Tbl_Usuarios (
    CodigoUsuario INT PRIMARY KEY IDENTITY(1,1),
    NombreUsuario VARCHAR(50) UNIQUE NOT NULL,
    Contrasena VARCHAR(255) NOT NULL,
    CodigoRol INT FOREIGN KEY REFERENCES Tbl_Roles(CodigoRol),
    Estado BIT DEFAULT 1
);

-- Insertar roles
INSERT INTO Tbl_Roles (NombreRol) VALUES ('Administrador'), ('Medico'), ('Recepcionista');

GO

CREATE TABLE Tbl_Pacientes (
    CodigoPaciente INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Dpi BIGINT,
    FechaNacimiento DATE,
    Genero VARCHAR(20),
    Telefono VARCHAR(20),
    Direccion VARCHAR(200),
    Edad INT,
    Estado BIT,
    UsuarioSistema VARCHAR(50),
    FechaSistema DATE,
    HoraSistema TIME
);

CREATE TABLE Tbl_Medicos (
    CodigoMedico INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Especialidad VARCHAR(100),
    Telefono VARCHAR(20),
    Correo VARCHAR(100),
    HonorarioBase DECIMAL(10,2),
    AniosExperiencia INT,
    BonoExperiencia DECIMAL(10,2),
    Estado BIT,
    UsuarioSistema VARCHAR(50),
    FechaSistema DATE,
    HoraSistema TIME
);

CREATE TABLE Tbl_TipoServicios (
    CodigoTipoServicio INT PRIMARY KEY IDENTITY(1,1),
    NombreServicio VARCHAR(100),
    TarifaBase DECIMAL(10,2),
    AplicaEmergencia BIT,
    AplicaHospitalizacion BIT,
    AplicaLaboratorio BIT,
    NivelComplejidad VARCHAR(50),
    RecargoBase DECIMAL(10,2),
    Estado BIT,
    UsuarioSistema VARCHAR(50),
    FechaSistema DATE,
    HoraSistema TIME
);

-- Esta tabla une a los 3 integrantes, pero la gestiona el Integrante 1
CREATE TABLE Tbl_AtencionesPacientes (
    CodigoAtencion INT PRIMARY KEY IDENTITY(1,1),
    CodigoPaciente INT FOREIGN KEY REFERENCES Tbl_Pacientes(CodigoPaciente),
    CodigoMedico INT FOREIGN KEY REFERENCES Tbl_Medicos(CodigoMedico),
    CodigoTipoServicio INT FOREIGN KEY REFERENCES Tbl_TipoServicios(CodigoTipoServicio),
    CodigoSanatorio INT, -- La FK se crea después de que el Int. 2 cree su tabla
    FechaAtencion DATE,
    CostoBase DECIMAL(10,2),
    RecargoEmergencia DECIMAL(10,2),
    TotalAtencion DECIMAL(10,2),
    Estado BIT,
    UsuarioSistema VARCHAR(50),
    FechaSistema DATE,
    HoraSistema TIME
);


-- ====================================================================
-- INSERTAR USUARIOS DE PRUEBA PARA LOS INTEGRANTES DEL GRUPO
-- ====================================================================

-- 1. Victor Calderon - Rol: Administrador (CodigoRol = 1)
INSERT INTO Tbl_Usuarios (NombreUsuario, Contrasena, CodigoRol, Estado)
VALUES ('Victor Calderon', 'admin123', 1, 1);

-- 2. Carlos Alvarez - Rol: Medico (CodigoRol = 2)
INSERT INTO Tbl_Usuarios (NombreUsuario, Contrasena, CodigoRol, Estado)
VALUES ('Carlos Alvarez', 'medico123', 2, 1);

-- 3. Hansel Anavisca - Rol: Recepcionista (CodigoRol = 3)
INSERT INTO Tbl_Usuarios (NombreUsuario, Contrasena, CodigoRol, Estado)
VALUES ('Hansel Anavisca', 'recep123', 3, 1);
GO

-- Verificar que los datos se hayan guardado correctamente con sus respectivos roles
SELECT 
    U.CodigoUsuario, 
    U.NombreUsuario, 
    U.Contrasena, 
    R.NombreRol, 
    U.Estado
FROM Tbl_Usuarios U
INNER JOIN Tbl_Roles R ON U.CodigoRol = R.CodigoRol;
