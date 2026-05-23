USE RailwayDB;
GO

CREATE PROCEDURE dbo.SafeInsertTariff
    @SubRouteID INT,
    @TrainID INT,
    @TicketPrice INT,
    @Result BIT OUTPUT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM dbo.Tariff WHERE SubRouteID = @SubRouteID AND TrainID = @TrainID)
    BEGIN
        SET @Result = 0;
    END
    ELSE
    BEGIN
        INSERT INTO dbo.Tariff (SubRouteID, TrainID, TicketPrice)
        VALUES (@SubRouteID, @TrainID, @TicketPrice);
        
        SET @Result = 1;
    END
END;
GO

DECLARE @OutResult BIT;
EXEC dbo.SafeInsertTariff @SubRouteID = 1, @TrainID = 5, @TicketPrice = 1500, @Result = @OutResult OUTPUT;
SELECT @OutResult AS [Результат выполнения];