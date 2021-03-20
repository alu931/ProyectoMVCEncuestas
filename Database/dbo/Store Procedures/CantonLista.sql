CREATE PROCEDURE [dbo].CantonLista
@IdProvincia INT

AS
BEGIN
SET NOCOUNT ON

	SELECT
	IdCanton,
	Descripcion
	FROM Canton
	WHERE IdProvincia=@IdProvincia

END