CREATE TABLE [dbo].[menu] (
    [idMenu]         INT          IDENTITY (1, 1) NOT NULL,
    [idControladora] INT          NOT NULL,
    [metodo]         VARCHAR (50) NULL,
    CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED ([idMenu] ASC),
    CONSTRAINT [FK_menu_Controladoras] FOREIGN KEY ([idControladora]) REFERENCES [dbo].[Controladoras] ([idControladora])
);



