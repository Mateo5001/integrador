CREATE TABLE [dbo].[MetodosControladora] (
    [idMetodo]          INT          IDENTITY (1, 1) NOT NULL,
    [metodo]            VARCHAR (50) NOT NULL,
    [descripcionMetodo] VARCHAR (50) NOT NULL,
    [nombreMostrar]     VARCHAR (50) NOT NULL,
    [vista]             VARCHAR (50) NULL,
    [idControladora]    INT          NOT NULL,
    CONSTRAINT [PK_MetodosControladora] PRIMARY KEY CLUSTERED ([idMetodo] ASC),
    CONSTRAINT [FK_MetodosControladora_Controladoras] FOREIGN KEY ([idControladora]) REFERENCES [dbo].[Controladoras] ([idControladora])
);

