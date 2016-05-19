CREATE TABLE [dbo].[tintas] (
    [idTinta]           INT          IDENTITY (1, 1) NOT NULL,
    [nombreTinta]       VARCHAR (50) NOT NULL,
    [codigoTinta]       VARCHAR (50) NOT NULL,
    [idLinea]           INT          NOT NULL,
    [idUsuarioCreacion] INT          NOT NULL,
    [fechaCreacion]     DATETIME     NOT NULL,
    [inactivo]          BIT          CONSTRAINT [DF_tintas_inactivo] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tintas] PRIMARY KEY CLUSTERED ([idTinta] ASC),
    CONSTRAINT [FK_tintas_lineas] FOREIGN KEY ([idLinea]) REFERENCES [dbo].[lineas] ([idLinea]),
    CONSTRAINT [FK_tintas_usuarios] FOREIGN KEY ([idUsuarioCreacion]) REFERENCES [dbo].[usuarios] ([idUsuario])
);

