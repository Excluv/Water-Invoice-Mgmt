USE QLNuoc
GO

-- Provides functions for Invoice Form
--
-- Adds a data tuple
CREATE PROCEDURE Add_Invoice
	@Inv_Date DATE,
	@Inv_Address NVARCHAR(200),
	@Cus_Name NVARCHAR(50),
	@Cus_ID INT,
	@Inv_WaterUsage FLOAT,
	@Inv_IssuedBy NVARCHAR(50),
	@Inv_EmpID INT
AS
	INSERT INTO Invoice(Inv_Date, Inv_Address,
						Cus_Name, Cus_ID,
						Inv_WaterUsage, Inv_IssuedBy,
						Inv_EmpID)
	VALUES (@Inv_Date, @Inv_Address,
			@Cus_Name, @Cus_ID,
			@Inv_WaterUsage, @Inv_IssuedBy,
			@Inv_EmpID)
GO

-- Edits a data tuple
CREATE PROCEDURE Edit_Invoice
	@Inv_ID INT,
	@Inv_Date DATE,
	@Inv_Address NVARCHAR(200),
	@Inv_WaterUsage FLOAT
AS
	UPDATE Invoice
	SET Inv_Date=@Inv_Date,
		Inv_Address=@Inv_Address,
		Inv_WaterUsage=@Inv_WaterUsage
	WHERE Inv_ID=@Inv_ID
GO

-- Removes a data tuple
CREATE PROCEDURE Remove_Invoice
	@Inv_ID INT
AS
	DELETE FROM Invoice
	WHERE Inv_ID=@Inv_ID
GO

-- Searches for a data tuple by inv_date
CREATE PROCEDURE Search_Invoice_ByDate
	@Inv_Date DATE
AS
	SELECT Inv_ID AS [Mã hoá đơn],
		   Inv_Date AS [Ngày lập],
		   Inv_Address AS [Địa chỉ],
		   Cus_Name AS [Tên khách hàng],
		   Cus_ID AS [Mã khách hàng],
		   Inv_WaterUsage AS [Lượng nước sử dụng],
		   Inv_Cost AS [Thành tiền],
		   Inv_IssuedBy AS [Người lập],
		   Inv_EmpID AS [Mã nhân viên]
	FROM Invoice
	WHERE Inv_Date=@Inv_Date
GO

-- Searches for a data tuple by cus_name
CREATE PROCEDURE Search_Invoice_ByCustomer
	@Cus_Name NVARCHAR(50)
AS
	SELECT Inv_ID AS [Mã hoá đơn],
		   Inv_Date AS [Ngày lập],
		   Inv_Address AS [Địa chỉ],
		   Cus_Name AS [Tên khách hàng],
		   Cus_ID AS [Mã khách hàng],
		   Inv_WaterUsage AS [Lượng nước sử dụng],
		   Inv_Cost AS [Thành tiền],
		   Inv_IssuedBy AS [Người lập],
		   Inv_EmpID AS [Mã nhân viên]
	FROM Invoice
	WHERE Cus_Name=@Cus_Name
GO

-- Searches for a data tuple by inv_issuedby
CREATE PROCEDURE Search_Invoice_ByEmployee
	@Inv_IssuedBy NVARCHAR(50)
AS
	SELECT Inv_ID AS [Mã hoá đơn],
		   Inv_Date AS [Ngày lập],
		   Inv_Address AS [Địa chỉ],
		   Cus_Name AS [Tên khách hàng],
		   Cus_ID AS [Mã khách hàng],
		   Inv_WaterUsage AS [Lượng nước sử dụng],
		   Inv_Cost AS [Thành tiền],
		   Inv_IssuedBy AS [Người lập],
		   Inv_EmpID AS [Mã nhân viên]
	FROM Invoice
	WHERE Inv_IssuedBy=@Inv_IssuedBy
GO

-- Displays the entire table
CREATE PROCEDURE Display_InvList
AS
	SELECT Inv_ID AS [Mã hoá đơn],
		   Inv_Date AS [Ngày lập],
		   Inv_Address AS [Địa chỉ],
		   Cus_Name AS [Tên khách hàng],
		   Cus_ID AS [Mã khách hàng],
		   Inv_WaterUsage AS [Lượng nước sử dụng],
		   Inv_Cost AS [Thành tiền],
		   Inv_IssuedBy AS [Người lập],
		   Inv_EmpID AS [Mã nhân viên]
	FROM Invoice
GO

-- Displays the entire table
CREATE PROCEDURE Display_OneInv
	@Inv_ID INT
AS
	SELECT Inv_Date AS [Ngày lập],
		   Inv_Address AS [Địa chỉ],
		   Cus_Name AS [Tên khách hàng],
		   Cus_ID AS [Mã khách hàng],
		   Inv_WaterUsage AS [Lượng nước sử dụng],
		   Inv_Cost AS [Thành tiền],
		   Inv_IssuedBy AS [Người lập],
		   Inv_EmpID AS [Mã nhân viên]
	FROM Invoice
	WHERE Inv_ID=@Inv_ID
GO

-- Input lookup and checking - Customer Info
CREATE PROCEDURE Customer_Check
	@Cus_ID INT,
	@Cus_Name NVARCHAR(50)
AS
	SELECT * FROM Customer
	WHERE Cus_ID=@Cus_ID AND Cus_Name=@Cus_Name
GO

-- Input lookup and checking - Employee Info
CREATE PROCEDURE Employee_Check
	@Emp_ID INT,
	@Emp_Name NVARCHAR(50)
AS
	SELECT * FROM Employee
	WHERE Emp_ID=@Emp_ID AND Emp_Name=@Emp_Name
GO