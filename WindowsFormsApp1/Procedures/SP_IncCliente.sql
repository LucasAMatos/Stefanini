IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SP_IncCLiente_V1')
	BEGIN
		PRINT 'Dropping Procedure SP_IncCLiente_V1'
		DROP  Procedure  SP_IncCLiente_V1
	END

GO

PRINT 'Creating Procedure SP_IncCLiente_V1'
GO
CREATE Procedure SP_IncCLiente_V1
    @NOME VARCHAR(25),
	@SOBRENOME VARCHAR (65),
	@DTNASC SMALLDATETIME,
	@SEXO CHAR(1),
	@EMAIL VARCHAR(100),
	@ATIVO BIT
AS
BEGIN
	INSERT INTO CLIENTE (
		NOME,
		SOBRENOME,
		DTNASC,
		SEXO,
		EMAIL,
		ATIVO
	)
	VALUES (
		@NOME,
		@SOBRENOME,
		@DTNASC,
		@SEXO,
		@EMAIL,
		@ATIVO
	)
END