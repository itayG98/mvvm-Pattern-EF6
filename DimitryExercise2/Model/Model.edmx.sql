
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/20/2022 12:00:29
-- Generated from EDMX file: D:\סלע\Entity Framwork\DimitryExercise2\DimitryExercise2\DimitryExercise2\Model\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DimitryExercise2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TeacherStudent_Teacher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherStudent] DROP CONSTRAINT [FK_TeacherStudent_Teacher];
GO
IF OBJECT_ID(N'[dbo].[FK_TeacherStudent_Student]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherStudent] DROP CONSTRAINT [FK_TeacherStudent_Student];
GO
IF OBJECT_ID(N'[dbo].[FK_Teacher_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People_Teacher] DROP CONSTRAINT [FK_Teacher_inherits_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_Student_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People_Student] DROP CONSTRAINT [FK_Student_inherits_Person];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[People_Teacher]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People_Teacher];
GO
IF OBJECT_ID(N'[dbo].[People_Student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People_Student];
GO
IF OBJECT_ID(N'[dbo].[TeacherStudent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeacherStudent];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL
);
GO

-- Creating table 'People_Teacher'
CREATE TABLE [dbo].[People_Teacher] (
    [Courses] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'People_Student'
CREATE TABLE [dbo].[People_Student] (
    [Grade] float  NOT NULL,
    [Courses] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'TeacherStudent'
CREATE TABLE [dbo].[TeacherStudent] (
    [Teacher_Id] int  NOT NULL,
    [Students_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People_Teacher'
ALTER TABLE [dbo].[People_Teacher]
ADD CONSTRAINT [PK_People_Teacher]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People_Student'
ALTER TABLE [dbo].[People_Student]
ADD CONSTRAINT [PK_People_Student]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Teacher_Id], [Students_Id] in table 'TeacherStudent'
ALTER TABLE [dbo].[TeacherStudent]
ADD CONSTRAINT [PK_TeacherStudent]
    PRIMARY KEY CLUSTERED ([Teacher_Id], [Students_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Teacher_Id] in table 'TeacherStudent'
ALTER TABLE [dbo].[TeacherStudent]
ADD CONSTRAINT [FK_TeacherStudent_Teacher]
    FOREIGN KEY ([Teacher_Id])
    REFERENCES [dbo].[People_Teacher]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Students_Id] in table 'TeacherStudent'
ALTER TABLE [dbo].[TeacherStudent]
ADD CONSTRAINT [FK_TeacherStudent_Student]
    FOREIGN KEY ([Students_Id])
    REFERENCES [dbo].[People_Student]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeacherStudent_Student'
CREATE INDEX [IX_FK_TeacherStudent_Student]
ON [dbo].[TeacherStudent]
    ([Students_Id]);
GO

-- Creating foreign key on [Id] in table 'People_Teacher'
ALTER TABLE [dbo].[People_Teacher]
ADD CONSTRAINT [FK_Teacher_inherits_Person]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'People_Student'
ALTER TABLE [dbo].[People_Student]
ADD CONSTRAINT [FK_Student_inherits_Person]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------