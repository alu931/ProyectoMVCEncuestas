CREATE PROCEDURE [dbo].[TiposIdentificacionObtener]
@IdTipoIdentificacion INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdTipoIdentificacion
		,	Descripcion
		,	Estado

	FROM dbo.TipoIndentificacion
	WHERE
	     (@IdTipoIdentificacion IS NULL OR IdTipoIdentificacion=@IdTipoIdentificacion)

END
