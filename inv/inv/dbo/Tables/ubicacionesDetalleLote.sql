CREATE TABLE [dbo].[ubicacionesDetalleLote] (
    [idLote]             INT          IDENTITY (1, 1) NOT NULL,
    [idTinta]            INT          NULL,
    [idColor]            INT          NULL,
    [cantidad]           FLOAT (53)   NOT NULL,
    [idUbicacionDetalle] INT          NOT NULL,
    [codigoLote]         VARCHAR (50) NOT NULL,
    [idUsuarioCreacion]  INT          NOT NULL,
    CONSTRAINT [PK_ubicacionesDetalleLote] PRIMARY KEY CLUSTERED ([idLote] ASC),
    CONSTRAINT [FK_ubicacionesDetalleLote_colores] FOREIGN KEY ([idColor]) REFERENCES [dbo].[colores] ([idColor]),
    CONSTRAINT [FK_ubicacionesDetalleLote_tintas] FOREIGN KEY ([idTinta]) REFERENCES [dbo].[tintas] ([idTinta]),
    CONSTRAINT [FK_ubicacionesDetalleLote_ubicacionesDetalle] FOREIGN KEY ([idUbicacionDetalle]) REFERENCES [dbo].[ubicacionesDetalle] ([idUbicacionDetalle]),
    CONSTRAINT [FK_ubicacionesDetalleLote_usuarios] FOREIGN KEY ([idUsuarioCreacion]) REFERENCES [dbo].[usuarios] ([idUsuario])
);

