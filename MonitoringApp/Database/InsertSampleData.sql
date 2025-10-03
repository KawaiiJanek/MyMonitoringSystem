USE MonitoringDB;
GO

-- Sample logs
INSERT INTO SystemLogs (LogLevel, Message)
VALUES
('INFO', 'Aplikacja zosta�a uruchomiona.'),
('WARNING', 'Zu�ycie pami�ci przekracza 80%.'),
('ERROR', 'Nieudana pr�ba po��czenia z serwerem zewn�trznym.'),
('INFO', 'Zadanie harmonogramu zosta�o wykonane pomy�lnie.');

-- Sample cticial alerts
INSERT INTO CriticalAlerts (Message)
VALUES
('Awaria serwera aplikacyjnego.'),
('Brak po��czenia z baz� danych.'),
('Nieudana pr�ba logowania administratora.');