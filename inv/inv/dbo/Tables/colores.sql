CREATE TABLE [dbo].[colores] (
    [idColor]           INT          IDENTITY (1, 1) NOT NULL,
    [nombreColor]       VARCHAR (50) NOT NULL,
    [codigoColor]       VARCHAR (50) NOT NULL,
    [idUsuarioRegistra] INT          NOT NULL,
    [fechaRegistro]     DATETIME     NOT NULL,
    [inactivo]          BIT          CONSTRAINT [DF_colores_inactivo] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_colores] PRIMARY KEY CLUSTERED ([idColor] ASC),
    CONSTRAINT [FK_colores_usuarios] FOREIGN KEY ([idUsuarioRegistra]) REFERENCES [dbo].[usuarios] ([idUsuario])
);

