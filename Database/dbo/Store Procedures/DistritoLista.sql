CREATE PROCEDURE [dbo].[DistritoLista]
@IdCanton INT

AS BEGIN
SET NOCOUNT ON
	SELECT 
	IdDistrito,
	Descripcion
	FROM Distrito
	WHERE IdCanton=@IdCanton

END