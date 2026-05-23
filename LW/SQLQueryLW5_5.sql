USE RailwayDB;
GO

CREATE PROCEDURE dbo.SafeDeleteTicket
    @TicketID INT,
    @Result BIT OUTPUT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM dbo.Ticket WHERE TicketID = @TicketID)
    BEGIN
        DELETE FROM dbo.Ticket WHERE TicketID = @TicketID;
        SET @Result = 1;
    END
    ELSE
    BEGIN
        SET @Result = 0;
    END
END;
GO

DECLARE @OutResult BIT;
EXEC dbo.SafeDeleteTicket @TicketID = 999, @Result = @OutResult OUTPUT;
SELECT @OutResult AS [Удаление прошло?];