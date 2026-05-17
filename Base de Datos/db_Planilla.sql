
USE GestionHospitalariaDB;
GO

CREATE TABLE Tbl_SegurosMedicos (
    CodigoSeguro INT PRIMARY KEY IDENTITY(1,1),
    NombreSeguro VARCHAR(150),
    TipoSeguro VARCHAR(50),
    PorcentajeCobertura DECIMAL(10,2),
    Telefono VARCHAR(20),
    Direccion VARCHAR(200),
    MontoMaximo DECIMAL(10,2),
    Estado BIT,
    UsuarioSistema VARCHAR(50),
    FechaSistema DATE,
    HoraSistema TIME
);

CREATE TABLE Tbl_Facturas (
    CodigoFactura INT PRIMARY KEY IDENTITY(1,1),
    CodigoAtencion INT FOREIGN KEY REFERENCES Tbl_AtencionesPacientes(CodigoAtencion),
    CodigoSeguro INT FOREIGN KEY REFERENCES Tbl_SegurosMedicos(CodigoSeguro),
    FechaFactura DATE,
    SubTotal DECIMAL(10,2),
    DescuentoSeguro DECIMAL(10,2),
    Impuesto DECIMAL(10,2),
    TotalPagar DECIMAL(10,2),
    Estado BIT,
    UsuarioSistema VARCHAR(50),
    FechaSistema DATE,
    HoraSistema TIME
);

CREATE TABLE Tbl_DetalleFacturas (
    CodigoDetalle INT PRIMARY KEY IDENTITY(1,1),
    CodigoFactura INT FOREIGN KEY REFERENCES Tbl_Facturas(CodigoFactura),
    TipoConcepto VARCHAR(50), -- Atención, Hospitalización, Laboratorio, Dieta
    CodigoReferencia INT,
    DescripcionReferencia VARCHAR(200),
    Cantidad INT,
    PrecioUnitario DECIMAL(10,2),
    SubTotal DECIMAL(10,2),
    Impuesto DECIMAL(10,2),
    TotalDetalle DECIMAL(10,2),
    Estado BIT,
    UsuarioSistema VARCHAR(50),
    FechaSistema DATE,
    HoraSistema TIME
);

CREATE TABLE Tbl_Pagos (
    CodigoPago INT PRIMARY KEY IDENTITY(1,1),
    CodigoFactura INT FOREIGN KEY REFERENCES Tbl_Facturas(CodigoFactura),
    FechaPago DATE,
    MontoFactura DECIMAL(10,2),
    MontoPagado DECIMAL(10,2),
    MetodoPago VARCHAR(50),
    Mora DECIMAL(10,2),
    Cambio DECIMAL(10,2),
    TotalCancelado DECIMAL(10,2),
    Estado BIT,
    UsuarioSistema VARCHAR(50),
    FechaSistema DATE,
    HoraSistema TIME
);
```