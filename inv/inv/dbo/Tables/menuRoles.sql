CREATE TABLE [dbo].[menuRoles] (
    [idMenuRole] INT IDENTITY (1, 1) NOT NULL,
    [idRole]     INT NOT NULL,
    [idMenu]     INT NOT NULL,
    CONSTRAINT [PK_menuRoles] PRIMARY KEY CLUSTERED ([idMenuRole] ASC),
    CONSTRAINT [FK_menuRoles_menu] FOREIGN KEY ([idMenu]) REFERENCES [dbo].[menu] ([idMenu]),
    CONSTRAINT [FK_menuRoles_roles] FOREIGN KEY ([idRole]) REFERENCES [dbo].[roles] ([idRole])
);

