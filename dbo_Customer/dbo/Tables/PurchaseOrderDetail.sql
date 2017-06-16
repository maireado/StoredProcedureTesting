CREATE TABLE [dbo].[PurchaseOrderDetail] (
    [PurchaseOrderID] INT        NOT NULL,
    [LineNumber]      SMALLINT   NOT NULL,
    [ProductID]       INT        NULL,
    [UnitPrice]       MONEY      NULL,
    [OrderQty]        SMALLINT   NULL,
    [ReceivedQty]     FLOAT (53) NULL,
    [RejectedQty]     FLOAT (53) NULL,
    [DueDate]         DATETIME   NULL
);

