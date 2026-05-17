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


USE GestionHospitalariaDB;
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

--
CREATE TABLE Tbl_AtencionesPacientes (
    CodigoAtencion INT PRIMARY KEY IDENTITY(1,1),
    CodigoPaciente INT FOREIGN KEY REFERENCES Tbl_Pacientes(CodigoPaciente),
    CodigoMedico INT FOREIGN KEY REFERENCES Tbl_Medicos(CodigoMedico),
    CodigoTipoServicio INT FOREIGN KEY REFERENCES Tbl_TipoServicios(CodigoTipoServicio),
    CodigoSanatorio INT, -- 
    FechaAtencion DATE,
    CostoBase DECIMAL(10,2),
    RecargoEmergencia DECIMAL(10,2),
    TotalAtencion DECIMAL(10,2),
    Estado BIT,
    UsuarioSistema VARCHAR(50),
    FechaSistema DATE,
    HoraSistema TIME
);