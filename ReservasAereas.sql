CREATE DATABASE ReservasAereas
GO
USE [ReservasAereas]
GO 
CREATE TABLE DatosReserva
(
IdReserva INT IDENTITY NOT NULL PRIMARY KEY,
AeropuertoDeOrigen VARCHAR(50),
HoraSalida VARCHAR(10),
AeropuertoDeLlegada VARCHAR(50),
Aerolinea VARCHAR(40),
HoraLlegada VARCHAR(10),
NumeroVuelo INT,
TipoPasajero INT,
FechaViaje datetime
)
GO 
CREATE TABLE PrecioTP
(
IdTipoPasajero INT IDENTITY NOT NULL PRIMARY KEY,
PrecioTP INT
)
GO 
INSERT INTO PrecioTP(PrecioTP)
VALUES (50000),--ADULTO
(20000)--NINO