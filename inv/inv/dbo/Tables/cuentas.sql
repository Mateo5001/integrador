CREATE TABLE [dbo].[cuentas] (
    [idCuenta]  INT          IDENTITY (1, 1) NOT NULL,
    [idusuario] INT          NOT NULL,
    [Usuario]   VARCHAR (50) NOT NULL,
    [pass]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_cuentas] PRIMARY KEY CLUSTERED ([idCuenta] ASC),
    CONSTRAINT [FK_cuentas_usuarios] FOREIGN KEY ([idusuario]) REFERENCES [dbo].[usuarios] ([idUsuario])
);

