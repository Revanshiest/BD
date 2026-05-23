CREATE FUNCTION dbo.GetAveragePriceByTrain (@ParamTrainID INT)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @AvgPrice DECIMAL(10,2);

    SELECT @AvgPrice = AVG(CAST(TicketPrice AS DECIMAL(10,2))) 
    FROM dbo.Tariff 
    WHERE TrainID = @ParamTrainID;

    RETURN ISNULL(@AvgPrice, 0.00);
END;
GO
SELECT dbo.GetAveragePriceByTrain(1) AS [Средняя цена билета];
GO