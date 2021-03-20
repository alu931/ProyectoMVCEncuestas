CREATE TABLE dbo.EmpleadoEncuesta
(
	IdEmpleadoEncuesta INT NOT NULL IDENTITY(1,1) 
		CONSTRAINT PK_EmpleadoEncuesta PRIMARY KEY CLUSTERED(IdEmpleadoEncuesta),
	IdEmpleado INT NOT NULL
	CONSTRAINT FK_EmpleadoEncuesta_Empleado FOREIGN KEY(IdEmpleado) REFERENCES dbo.Empleado(IdEmpleado),
	FechaNacimiento DATE,
	EstadoCivil  VARCHAR(150) NOT NULL,
	LenguajeNativo Varchar(150) not null,
	TieneHijos BIT NOT NULL,
	CantidadHijos INT NULL,
	CantidadHijosMantiene int NULL,
	Lee bit NOT NULL,
	Escribe bit NOT NULL,
	Carrera Varchar(150) NOT NULL,
	MantienePersonasAparte bit NOT NULL,
	DesMantienePersonasAparte VARCHAR(500)NULL,
	IdProvincia INT NOT NULL
	CONSTRAINT FK_EmpleadoEncuesta_Provincia FOREIGN KEY(IdProvincia) REFERENCES dbo.Provincia(IdProvincia),
	IdCanton INT NOT NULL
	CONSTRAINT FK_EmpleadoEncuesta_Canton FOREIGN KEY(IdCanton) REFERENCES dbo.Canton(IdCanton),
	IdDistrito INT NOT NULL
	CONSTRAINT FK_EmpleadoEncuesta_Distrito FOREIGN KEY(IdDistrito) REFERENCES dbo.Distrito(IdDistrito)
)
