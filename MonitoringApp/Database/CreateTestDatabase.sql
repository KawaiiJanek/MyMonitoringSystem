-- Creating database
CREATE DATABASE MonitoringDB;
GO

USE MonitoringDB;
GO

-- System logs database
CREATE TABLE SystemLogs (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    LogDate DATETIME NOT NULL DEFAULT GETDATE(),
    LogLevel NVARCHAR(50),
    Message NVARCHAR(MAX)
);
GO

-- Critical alerts database
CREATE TABLE CriticalAlerts (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    AlertDate DATETIME NOT NULL DEFAULT GETDATE(),
    Message NVARCHAR(MAX)
);
GO