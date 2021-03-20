CREATE PROCEDURE [dbo].ProvinciaLista
	
AS BEGIN
SET NOCOUNT ON

SELECT
IdProvincia,
Descripcion

FROM Provincia

END