CREATE FUNCTION dbo.GetExpensiveTicketsList (@MinPrice INT)
RETURNS TABLE
AS
RETURN 
(
    SELECT 
        T.PassengerName AS [ФИО Пассажира],
        T.TrainID AS [Номер поезда],
        TF.TicketPrice AS [Стоимость билета]
    FROM dbo.Ticket T
    INNER JOIN dbo.Tariff TF 
        ON T.SubRouteID = TF.SubRouteID 
       AND T.TrainID = TF.TrainID
    WHERE TF.TicketPrice > @MinPrice
);
GO

SELECT * FROM dbo.GetExpensiveTicketsList(1000);