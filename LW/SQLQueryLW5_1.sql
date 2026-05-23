CREATE FUNCTION dbo.GetTicketCountByTrain (@ParamTrainID INT)
RETURNS INT
AS
BEGIN
    DECLARE @TicketCount INT;

    SELECT @TicketCount = COUNT(*) 
    FROM dbo.Ticket 
    WHERE TrainID = @ParamTrainID;

    RETURN @TicketCount;
END;

GO

SELECT dbo.GetTicketCountByTrain(5) AS КоличествоБилетов;