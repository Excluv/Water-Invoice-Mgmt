USE QLNuoc
GO;

-- Provides functions for Customer Form
--
-- Adds a data tuple
CREATE PROCEDURE Add_Customer
	@Cus_Name NVARCHAR(50),
	@Cus_Address NVARCHAR(200)
AS
	INSERT INTO Customer(Cus_Name, Cus_Address)
	VALUES (@Cus_Name, @Cus_Address)
GO

-- Edits a data tuple
CREATE PROCEDURE Edit_Customer
	@Cus_ID INT,
	@Cus_Address NVARCHAR(200)
AS
	UPDATE Customer
	SET Cus_Address=@Cus_Address
	WHERE Cus_ID=@Cus_ID
GO

-- Removes a data tuple
CREATE PROCEDURE Remove_Customer
	@Cus_ID INT
AS
	DELETE FROM Customer
	WHERE Cus_ID=@Cus_ID
GO

-- Selects a data tuple
CREATE PROCEDURE Search_Customer
	@Cus_Name NVARCHAR(50)
AS
	SELECT * FROM Customer
	WHERE Cus_Name=@Cus_Name
GO

-- Displays the entire table
CREATE PROCEDURE Display_CusList
AS
	SELECT Cus_ID AS [Mã khách hàng],
		   Cus_Name AS [Tên khách hàng],
		   Cus_Address AS [Địa chỉ]
	FROM Customer
GO

-- Displays one customer
CREATE PROCEDURE Display_OneCus
	@Cus_ID INT
AS
	SELECT Cus_Name AS [Tên khách hàng],
		   Cus_Address AS [Địa chỉ]
	FROM Customer
	WHERE Cus_ID=@Cus_ID
GO