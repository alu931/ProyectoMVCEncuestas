CREATE PROCEDURE [dbo].[EmpleadoEncuestaInsertar]
    @IdEmpleado INT,
	@FechaNacimiento VARCHAR(MAX),
	@EstadoCivil VARCHAR(150),
	@LenguajeNativo VARCHAR(150),
	@TieneHijos BIT,
	@CantidadHijos INT=NULL,
	@CantidadHijosMantiene INT=NULL,
	@Lee BIT,
	@Escribe BIT,
	@Carrera VARCHAR(250),
	@MantienePersonasAparte BIT,
	@DesMantienePersonasAparte Varchar(500),
	@IdProvincia int,
	@IdCanton int,
	@IdDistrito int
AS BEGIN

SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	INSERT INTO EmpleadoEncuesta (
	IdEmpleado,
	FechaNacimiento,
	EstadoCivil,
	LenguajeNativo,
	TieneHijos,
	CantidadHijos,
	CantidadHijosMantiene,
	Lee,
	Escribe,
	Carrera,
	MantienePersonasAparte,
	DesMantienePersonasAparte,
	IdProvincia,
	IdCanton,
	IdDistrito
	)VALUES(
	@IdEmpleado,
	@FechaNacimiento,
	@EstadoCivil,
	@LenguajeNativo,
	@TieneHijos,
	@CantidadHijos,
	@CantidadHijosMantiene,
	@Lee,
	@Escribe,
	@Carrera,
	@MantienePersonasAparte,
	@DesMantienePersonasAparte,
	@IdProvincia,
	@IdCanton,
	@IdDistrito
	)

		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH

END
