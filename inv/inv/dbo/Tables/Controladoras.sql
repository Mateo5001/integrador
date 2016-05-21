CREATE TABLE [dbo].[Controladoras] (
    [idControladora]          INT          IDENTITY (1, 1) NOT NULL,
    [Path]                    VARCHAR (50) NOT NULL,
    [NombreControladora]      VARCHAR (50) NOT NULL,
    [descripcionControladora] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Controladoras] PRIMARY KEY CLUSTERED ([idControladora] ASC)
);

