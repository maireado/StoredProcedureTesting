CREATE PROCEDURE Customer  
    @LastName nvarchar(50),   
    @FirstName nvarchar(50)   
AS   

    SET NOCOUNT ON;  
    SELECT FirstName, LastName 
    FROM SalesLT.Customer
    WHERE FirstName = @FirstName AND LastName = @LastName  
