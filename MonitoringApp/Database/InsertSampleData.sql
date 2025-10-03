USE MonitoringDB;
GO

-- Sample logs
INSERT INTO SystemLogs (LogLevel, Message)
VALUES
('INFO', 'Aplikacja zosta³a uruchomiona.'),
('WARNING', 'Zu¿ycie pamiêci przekracza 80%.'),
('ERROR', 'Nieudana próba po³¹czenia z serwerem zewnêtrznym.'),
('INFO', 'Zadanie harmonogramu zosta³o wykonane pomyœlnie.');

-- Sample cticial alerts
INSERT INTO CriticalAlerts (Message)
VALUES
('Awaria serwera aplikacyjnego.'),
('Brak po³¹czenia z baz¹ danych.'),
('Nieudana próba logowania administratora.');