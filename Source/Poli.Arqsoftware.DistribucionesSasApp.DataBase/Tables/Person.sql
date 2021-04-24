CREATE TABLE [dbo].[Person] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [DocNumber]      INTEGER      NOT NULL UNIQUE,
    [FirstName]      VARCHAR (60) NOT NULL,
    [LastName]       VARCHAR (60) NOT NULL,
    [Enable]         BIT          NOT NULL,
    [CreatedOn]      DATETIME     NOT NULL,
    [LastModifiedOn] DATETIME     NULL,
    [LastModifiedBy] VARCHAR (64) NULL,
    [DeletedOn]      DATETIME     NULL,
    [DeletedBy]      VARCHAR (64) NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id] ASC)
);