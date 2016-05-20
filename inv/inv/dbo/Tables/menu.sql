CREATE TABLE [dbo].[menu] (
    [idMenu]       INT          IDENTITY (1, 1) NOT NULL,
    [controladora] VARCHAR (50) NOT NULL,
    [metodo]       VARCHAR (50) NULL,
    CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED ([idMenu] ASC)
);

