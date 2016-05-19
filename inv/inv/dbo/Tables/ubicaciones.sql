CREATE TABLE [dbo].[ubicaciones] (
    [idubicacion]       INT          IDENTITY (1, 1) NOT NULL,
    [desUbicacion]      VARCHAR (20) NOT NULL,
    [codigo]            VARCHAR (20) NOT NULL,
    [idUsuarioCreacion] INT          NOT NULL,
    [fechaCreacion]     DATETIME     NOT NULL,
    [inactivo]          BIT          CONSTRAINT [DF_ubicaciones_inactivo] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK__ubicacio__E79A2C9129F18693] PRIMARY KEY CLUSTERED ([idubicacion] ASC),
    CONSTRAINT [FK_ubicaciones_usuarios] FOREIGN KEY ([idUsuarioCreacion]) REFERENCES [dbo].[usuarios] ([idUsuario])
);



