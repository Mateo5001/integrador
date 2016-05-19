CREATE TABLE [dbo].[inventarioMovimientosDetalle] (
    [idMovimientoDetalle] INT        IDENTITY (1, 1) NOT NULL,
    [idMovimiento]        INT        NOT NULL,
    [idTinta]             INT        NULL,
    [idColor]             INT        NULL,
    [Cantidad]            FLOAT (53) NOT NULL,
    CONSTRAINT [PK_inventarioMovimientosDetalle] PRIMARY KEY CLUSTERED ([idMovimientoDetalle] ASC),
    CONSTRAINT [FK_inventarioMovimientosDetalle_colores] FOREIGN KEY ([idColor]) REFERENCES [dbo].[colores] ([idColor]),
    CONSTRAINT [FK_inventarioMovimientosDetalle_inventariosMovimientos] FOREIGN KEY ([idMovimiento]) REFERENCES [dbo].[inventariosMovimientos] ([idMovimiento]),
    CONSTRAINT [FK_inventarioMovimientosDetalle_tintas] FOREIGN KEY ([idTinta]) REFERENCES [dbo].[tintas] ([idTinta])
);

