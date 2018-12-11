IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SP_IncProd_V1')
	BEGIN
		PRINT 'Dropping Procedure SP_IncProd_V1'
		DROP  Procedure  SP_IncProd_V1
	END

GO

PRINT 'Creating Procedure SP_IncProd_V1'
GO
CREATE Procedure SP_IncProd_V1
    @IDCLI INT,
	@IDPROD INT,
	@NOMEPROD VARCHAR(50)
AS
BEGIN
	INSERT INTO PRODUTO (
		IDCLI,
		IDPROD,
		NOMEPROD
	)
	VALUES (
		@IDCLI,
		@IDPROD,
		@NOMEPROD
	)
END