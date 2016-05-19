CREATE TABLE [dbo].[roles] (
    [idRole]     INT          IDENTITY (1, 1) NOT NULL,
    [nombreRole] VARCHAR (50) NOT NULL,
    [codigoRole] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED ([idRole] ASC)
);

