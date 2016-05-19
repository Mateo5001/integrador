CREATE TABLE [dbo].[inventariosMovimientos] (
    [idMovimiento]          INT          NOT NULL,
    [idUsuarioregistra]     INT          NOT NULL,
    [numeroMovimiento]      INT          IDENTITY (1, 1) NOT NULL,
    [fechaMovimiento]       INT          NOT NULL,
    [signoMovimiento]       INT          NOT NULL,
    [descripcionMovimiento] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_inventariosMovimientos] PRIMARY KEY CLUSTERED ([idMovimiento] ASC),
    CONSTRAINT [FK_inventariosMovimientos_usuarios] FOREIGN KEY ([idUsuarioregistra]) REFERENCES [dbo].[usuarios] ([idUsuario])
);

