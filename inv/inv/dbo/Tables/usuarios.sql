CREATE TABLE [dbo].[usuarios] (
    [idUsuario]       INT          IDENTITY (1, 1) NOT NULL,
    [idTipoDocumento] INT          NOT NULL,
    [identificacion]  VARCHAR (50) NOT NULL,
    [nombrePrimero]   VARCHAR (50) NOT NULL,
    [nombreSegundo]   VARCHAR (50) NULL,
    [apellidoPrimero] VARCHAR (50) NOT NULL,
    [apellidoSegundo] VARCHAR (50) NULL,
    [idRole]          INT          NOT NULL,
    CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED ([idUsuario] ASC),
    CONSTRAINT [FK_usuarios_roles] FOREIGN KEY ([idRole]) REFERENCES [dbo].[roles] ([idRole]),
    CONSTRAINT [FK_usuarios_tiposDocumentos] FOREIGN KEY ([idTipoDocumento]) REFERENCES [dbo].[tiposDocumentos] ([idTipoDocumento])
);

