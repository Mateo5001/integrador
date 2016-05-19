CREATE TABLE [dbo].[colorDetalle] (
    [idColorDetalle]     INT        IDENTITY (1, 1) NOT NULL,
    [idColor]            INT        NOT NULL,
    [idTinta]            INT        NOT NULL,
    [cantidadPorcentaje] FLOAT (53) NOT NULL,
    CONSTRAINT [PK_colorDetalle] PRIMARY KEY CLUSTERED ([idColorDetalle] ASC),
    CONSTRAINT [FK_colorDetalle_colores] FOREIGN KEY ([idColor]) REFERENCES [dbo].[colores] ([idColor]),
    CONSTRAINT [FK_colorDetalle_tintas] FOREIGN KEY ([idTinta]) REFERENCES [dbo].[tintas] ([idTinta])
);

