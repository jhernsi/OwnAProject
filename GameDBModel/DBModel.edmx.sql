
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/01/2015 11:41:24
-- Generated from EDMX file: D:\Demos\PROG35142-Fall\InClass-Fall2015-PROG35142\GameDBModel\DBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GameDB_Fall];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Games'
CREATE TABLE [dbo].[Games] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Platform] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Members'
CREATE TABLE [dbo].[Members] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'GameMember'
CREATE TABLE [dbo].[GameMember] (
    [Games_Id] int  NOT NULL,
    [Members_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [PK_Games]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Members'
ALTER TABLE [dbo].[Members]
ADD CONSTRAINT [PK_Members]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Games_Id], [Members_Id] in table 'GameMember'
ALTER TABLE [dbo].[GameMember]
ADD CONSTRAINT [PK_GameMember]
    PRIMARY KEY CLUSTERED ([Games_Id], [Members_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Games_Id] in table 'GameMember'
ALTER TABLE [dbo].[GameMember]
ADD CONSTRAINT [FK_GameMember_Game]
    FOREIGN KEY ([Games_Id])
    REFERENCES [dbo].[Games]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Members_Id] in table 'GameMember'
ALTER TABLE [dbo].[GameMember]
ADD CONSTRAINT [FK_GameMember_Member]
    FOREIGN KEY ([Members_Id])
    REFERENCES [dbo].[Members]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GameMember_Member'
CREATE INDEX [IX_FK_GameMember_Member]
ON [dbo].[GameMember]
    ([Members_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------