# EF Core Migration Output



    PM> Add-Migration Initial

    Microsoft.EntityFrameworkCore.Infrastructure[10403]
          Entity Framework Core 3.0.0 initialized 'MyWebsiteContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: None
    To undo this action, use Remove-Migration.


    PM> Update-Database

    Microsoft.EntityFrameworkCore.Infrastructure[10403]
          Entity Framework Core 3.0.0 initialized 'MyWebsiteContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: None
    Microsoft.EntityFrameworkCore.Database.Command[20100]
          Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='60']
          CREATE DATABASE [MyWebsite_db];
    Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='60']
    CREATE DATABASE [MyWebsite_db];
    Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='60']
    IF SERVERPROPERTY('EngineEdition') <> 5
    BEGIN
        ALTER DATABASE [MyWebsite_db] SET READ_COMMITTED_SNAPSHOT ON;
    END;
    Microsoft.EntityFrameworkCore.Database.Command[20100]
          Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='60']
          IF SERVERPROPERTY('EngineEdition') <> 5
          BEGIN
              ALTER DATABASE [MyWebsite_db] SET READ_COMMITTED_SNAPSHOT ON;
          END;
    Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
    Microsoft.EntityFrameworkCore.Database.Command[20100]
          Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
          CREATE TABLE [__EFMigrationsHistory] (
              [MigrationId] nvarchar(150) NOT NULL,
              [ProductVersion] nvarchar(32) NOT NULL,
              CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
          );
    Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
    SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
    Microsoft.EntityFrameworkCore.Database.Command[20100]
          Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
          SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
    Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
    SELECT [MigrationId], [ProductVersion]
    FROM [__EFMigrationsHistory]
    ORDER BY [MigrationId];
    Microsoft.EntityFrameworkCore.Database.Command[20100]
          Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
          SELECT [MigrationId], [ProductVersion]
          FROM [__EFMigrationsHistory]
          ORDER BY [MigrationId];
    Microsoft.EntityFrameworkCore.Migrations[20402]
          Applying migration '20191103062033_Initial'.
    Applying migration '20191103062033_Initial'.
    Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
    CREATE TABLE [WeatherForecasts] (
        [Id] nvarchar(450) NOT NULL,
        [Date] datetime2 NOT NULL,
        [TemperatureC] int NOT NULL,
        [Summary] nvarchar(max) NULL,
        CONSTRAINT [PK_WeatherForecasts] PRIMARY KEY ([Id])
    );
    Microsoft.EntityFrameworkCore.Database.Command[20100]
          Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
          CREATE TABLE [WeatherForecasts] (
              [Id] nvarchar(450) NOT NULL,
              [Date] datetime2 NOT NULL,
              [TemperatureC] int NOT NULL,
              [Summary] nvarchar(max) NULL,
              CONSTRAINT [PK_WeatherForecasts] PRIMARY KEY ([Id])
          );
    Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191103062033_Initial', N'3.0.0');
    Microsoft.EntityFrameworkCore.Database.Command[20100]
          Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
          INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
          VALUES (N'20191103062033_Initial', N'3.0.0');
    Done.

    PM> 