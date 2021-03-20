CREATE PROCEDURE EmpleadoEncuestaObtener

AS BEGIN
SET NOCOUNT ON
					SELECT 
					EE.IdEmpleadoEncuesta,
					FechaNacimiento=CONVERT(VARCHAR,EE.FechaNacimiento,103),
					EE.EstadoCivil,
					EE.LenguajeNativo,
					EE.TieneHijos,
					EE.CantidadHijos,
					EE.CantidadHijosMantiene,
					EE.Lee,
					EE.Escribe,
					EE.Carrera,
					EE.MantienePersonasAparte,
					EE.DesMantienePersonasAparte,

					EE.IdEmpleado,
					E.NombreEmpleado,

					EE.IdProvincia,
					P.Descripcion,

					EE.IdCanton,
					C.Descripcion,

					EE.IdDistrito,
					D.Descripcion

					FROM EmpleadoEncuesta EE
					INNER JOIN Empleado E
						ON E.IdEmpleado=EE.IdEmpleado
					INNER JOIN Provincia P
						ON P.IdProvincia=EE.IdProvincia
					INNER JOIN Canton C
						ON C.IdCanton=EE.IdCanton
						AND P.IdProvincia=P.IdProvincia
					INNER JOIN Distrito D
						ON	D.IdDistrito=EE.IdDistrito
						AND D.IdCanton=C.IdCanton


END