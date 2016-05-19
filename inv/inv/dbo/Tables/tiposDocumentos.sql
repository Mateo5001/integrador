CREATE TABLE [dbo].[tiposDocumentos] (
    [idTipoDocumento]     INT          IDENTITY (1, 1) NOT NULL,
    [codigoTipoDocumento] VARCHAR (50) NOT NULL,
    [nombreTipoDocuemnto] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tiposDocumentos] PRIMARY KEY CLUSTERED ([idTipoDocumento] ASC)
);

