DROP PROCEDURE [dbo].[SP_TraerData]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TraerData]
@AeropuertoDeOrigen varchar(50) = null,
@AeropuertoDeLlegada varchar(50) = null,
@Aerolinea varchar(50) = null
AS
BEGIN
IF @AeropuertoDeOrigen IS NOT NULL
BEGIN
SELECT * FROM DatosReserva
WHERE AeropuertoDeOrigen = @AeropuertoDeOrigen
END
IF @AeropuertoDeLlegada IS NOT NULL
BEGIN 
SELECT * FROM DatosReserva
WHERE AeropuertoDeLlegada = @AeropuertoDeLlegada
END 
IF @Aerolinea IS NOT NULL
BEGIN 
SELECT * FROM DatosReserva
WHERE Aerolinea = @Aerolinea
END 
END
GO


