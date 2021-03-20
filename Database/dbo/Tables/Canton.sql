CREATE TABLE [dbo].Canton
(
		IdCanton INT NOT NULL IDENTITY(1,1) 
		CONSTRAINT PK_Canton PRIMARY KEY CLUSTERED(IdCanton),
		IdProvincia INT NOT NULL 
		CONSTRAINT FK_Canton_Provincia FOREIGN KEY(IdProvincia) REFERENCES dbo.Provincia(IdProvincia),
		Descripcion VARCHAR(250),
)WITH (DATA_COMPRESSION = PAGE)
