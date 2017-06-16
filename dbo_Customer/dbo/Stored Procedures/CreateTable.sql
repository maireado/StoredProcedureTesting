-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CreateTable]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	DROP TABLE IF EXISTS dbo.PurchaseOrderDetail
	CREATE TABLE dbo.PurchaseOrderDetail  
(  
    PurchaseOrderID int NOT NULL  
    ,LineNumber smallint NOT NULL  
    ,ProductID int NULL  
    ,UnitPrice money NULL  
    ,OrderQty smallint NULL  
    ,ReceivedQty float NULL  
    ,RejectedQty float NULL  
    ,DueDate datetime NULL  
);  
END
