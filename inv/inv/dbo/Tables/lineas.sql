CREATE TABLE [dbo].[lineas] (
    [idLinea]           INT          IDENTITY (1, 1) NOT NULL,
    [nombreLinea]       VARCHAR (50) NOT NULL,
    [codigoLinea]       VARCHAR (50) NOT NULL,
    [idUsuarioCreacion] INT          NOT NULL,
    [fechaCreacion]     DATETIME     NOT NULL,
    CONSTRAINT [PK_lineas] PRIMARY KEY CLUSTERED ([idLinea] ASC),
    CONSTRAINT [FK_lineas_usuarios] FOREIGN KEY ([idUsuarioCreacion]) REFERENCES [dbo].[usuarios] ([idUsuario])
);

