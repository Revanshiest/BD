-- CREATE DATABASE RailwayDB;
-- GO
-- USE RailwayDB;
-- GO

-- 1. Таблица тарифов (создается первой, так как не имеет внешних ключей)
CREATE TABLE dbo.Tariff (
    SubRouteID INT NOT NULL,
    TrainID INT NOT NULL,
    TicketPrice INT NOT NULL,
    CONSTRAINT PK_Tariff PRIMARY KEY (SubRouteID, TrainID)
);
GO

-- 2. Таблица билетов (зависит от составного ключа таблицы Tariff)
CREATE TABLE dbo.Ticket (
    TicketID INT NOT NULL,
    PassengerName NVARCHAR(100) NOT NULL, -- На скриншоте nullability скрыто, но для ФИО обычно используется NOT NULL
    SubRouteID INT NOT NULL,
    TrainID INT NOT NULL,
    DepartureDate DATETIME NOT NULL,
    CONSTRAINT PK_Ticket PRIMARY KEY (TicketID),
    CONSTRAINT FK_Ticket_Tariff FOREIGN KEY (SubRouteID, TrainID) 
        REFERENCES dbo.Tariff (SubRouteID, TrainID)
);
GO

-- 3. Таблица багажа (создается последней, так как зависит от Ticket)
CREATE TABLE dbo.Baggage (
    TagID INT NOT NULL,
    TicketID INT NOT NULL,
    Weight DECIMAL(5,2) NULL, -- Позволяет оставлять поле пустым, если багажа нет
    CONSTRAINT PK_Baggage PRIMARY KEY (TagID),
    CONSTRAINT FK_Baggage_Ticket FOREIGN KEY (TicketID) 
        REFERENCES dbo.Ticket (TicketID)
        ON DELETE CASCADE -- Опционально: автоматически удалит багаж при удалении билета
);
GO


INSERT INTO Ticket (TicketID, PassengerName, SubRouteID, TrainID, DepartureDate)
VALUES
(7001, 'Петров А.С.', 1, 2, '2026-06-15 08:30:00'),
(7002, 'Сидоров В.П.', 1, 3, '2026-06-15 09:00:00'),
(7003, 'Иванова Е.К.', 2, 1, '2026-06-15 09:30:00'),
(7004, 'Кузнецов М.Л.', 2, 2, '2026-06-15 10:00:00'),
(7005, 'Смирнова А.В.', 3, 1, '2026-06-15 10:30:00'),
(7006, 'Волков С.Р.', 1, 1, '2026-06-15 11:00:00'),
(7007, 'Морозова Н.Д.', 2, 3, '2026-06-15 11:30:00'),
(7008, 'Григорьев И.П.', 3, 2, '2026-06-15 12:00:00'),
(7009, 'Козлов А.С.', 3, 3, '2026-06-15 12:30:00'),
(7010, 'Лебедева Е.В.', 4, 1, '2026-06-15 13:00:00'),
(7011, 'Новиков В.Л.', 4, 3, '2026-06-15 13:30:00'),
(7012, 'Соловьев С.К.', 4, 5, '2026-06-15 14:00:00'),
(7013, 'Михайлова А.П.', 5, 2, '2026-06-15 14:30:00'),
(7014, 'Федоров И.В.', 5, 4, '2026-06-15 15:00:00'),
(7015, 'Григорьева Н.С.', 5, 5, '2026-06-15 15:30:00'),
(7016, 'Кузнецова М.Л.', 5, 5, '2026-06-15 15:30:00'),
(7017, 'Смирнов А.В.', 5, 5, '2026-06-15 15:30:00'),
(7018, 'Волкова С.Р.', 5, 5, '2026-06-15 15:30:00'),
(7019, 'Морозов Н.Д.', 5, 5, '2026-06-15 15:30:00'),
(7020, 'Григорьев И.П.', 5, 5, '2026-06-15 15:30:00');

GO

INSERT INTO Baggage (TagID, TicketID, Weight)
VALUES
(1001, 7001, 12.5),
(1002, 7001, 5.0),
(1003, 7002, 22.4);

GO

SELECT
    T.TicketID AS [Номер билета],
    T.PassengerName AS [ФИО Пассажира],
    T.TrainID AS [Номер поезда],
    T.SubRouteID AS [Номер подмаршрута],
    Tr.TicketPrice AS [Цена билета],
    T.DepartureDate AS [Дата отправления]
FROM Ticket T
INNER JOIN Tariff Tr
    ON T.SubRouteID = Tr.SubRouteID
    AND T.TrainID = Tr.TrainID;

GO

SELECT PassengerName AS [Пассажир], TrainID AS [Поезд], 'Первая группа (Поезд 1)' AS [Категория]
FROM Ticket
WHERE TrainID = 1

UNION

SELECT PassengerName AS [Пассажир], TrainID AS [Поезд], 'Вторая группа (Поезд 2)' AS [Категория]
FROM Ticket
WHERE TrainID = 2;

GO

SELECT
    TrainID AS [Номер поезда],
    ISNULL([1], 0) AS [Маршрут 1 (руб)],
    ISNULL([2], 0) AS [Маршрут 2 (руб)],
    ISNULL([3], 0) AS [Маршрут 3 (руб)],
    ISNULL([4], 0) AS [Маршрут 4 (руб)],
    ISNULL([5], 0) AS [Маршрут 5 (руб)]
FROM
(
    SELECT T.TrainID, T.SubRouteID, Tr.TicketPrice
    FROM Ticket T
    INNER JOIN Tariff Tr 
        ON T.SubRouteID = Tr.SubRouteID 
        AND T.TrainID = Tr.TrainID
) AS SourceData
PIVOT
(
    SUM(TicketPrice)
    FOR SubRouteID IN ([1], [2], [3], [4], [5])
) AS PivotTable;

GO

CREATE TABLE #PassengerStats (
    PassengerName NVARCHAR(100),
    TrainID INT,
    Status NVARCHAR(50)
);

INSERT INTO #PassengerStats (PassengerName, TrainID, Status)
SELECT PassengerName, TrainID, 'Обычный'
FROM Ticket;

UPDATE #PassengerStats
SET Status = 'VIP пассажир'
WHERE TrainID = 5;

SELECT * FROM #PassengerStats;

DROP TABLE #PassengerStats;

GO

DECLARE @StartDate DATETIME;
DECLARE @EndDate DATETIME;

SET @StartDate = '2026-05-15 08:00:00';
SET @EndDate = '2026-05-15 11:00:00';

SELECT TicketID, PassengerName, TrainID, DepartureDate
FROM Ticket
WHERE DepartureDate BETWEEN @StartDate AND @EndDate;

GO