CREATE TABLE [dbo].[ubicacionesDetalle] (
    [idUbicacionDetalle] INT          IDENTITY (1, 1) NOT NULL,
    [idubicacion]        INT          NOT NULL,
    [desDetalle]         VARCHAR (20) NOT NULL,
    CONSTRAINT [PK__ubicacio__5C5998F6216BBA1D] PRIMARY KEY CLUSTERED ([idUbicacionDetalle] ASC),
    CONSTRAINT [FK_U_UD] FOREIGN KEY ([idubicacion]) REFERENCES [dbo].[ubicaciones] ([idubicacion])
);

