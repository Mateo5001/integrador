CREATE TABLE [dbo].[ubicaciones] (
    [idubicacion]  INT          IDENTITY (1, 1) NOT NULL,
    [desUbicacion] VARCHAR (20) NOT NULL,
    [codigo]       VARCHAR (20) NOT NULL,
    CONSTRAINT [PK__ubicacio__E79A2C9129F18693] PRIMARY KEY CLUSTERED ([idubicacion] ASC)
);

