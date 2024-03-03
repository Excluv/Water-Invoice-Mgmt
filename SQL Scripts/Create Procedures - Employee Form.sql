USE QLNuoc;
GO

------ Provide functions for Employee Form
--
-- Adds a data tuple
CREATE PROCEDURE Add_Employee
	@Emp_Name NVARCHAR(50),
	@Emp_Gender NVARCHAR(3),
	@Emp_DOB DATE,
	@Emp_Address NVARCHAR(200),
	@Emp_PhoneNumber INT
AS
	INSERT INTO Employee(Emp_Name, Emp_Gender,
						 Emp_DOB, Emp_Address, 
						 Emp_PhoneNumber)
	VALUES (@Emp_Name, @Emp_Gender,
			@Emp_DOB, @Emp_Address, 
			@Emp_PhoneNumber)
GO

-- Edits a data tuple
CREATE PROCEDURE Edit_Employee
	@Emp_ID INT,
	@Emp_Gender NVARCHAR(3),
	@Emp_DOB DATE,
	@Emp_Address NVARCHAR(200),
	@Emp_PhoneNumber INT
AS
	UPDATE Employee
	SET Emp_Gender=@Emp_Gender, Emp_DOB=@Emp_DOB, 
		Emp_Address=@Emp_Address, 
		Emp_PhoneNumber=@Emp_PhoneNumber
	WHERE Emp_ID=@Emp_ID
GO

-- Removes a data tuple
CREATE PROCEDURE Remove_Employee
	@Emp_ID INT
AS
	DELETE FROM Employee
	WHERE Emp_ID = @Emp_ID
GO

-- Selects a data tuple 
CREATE PROCEDURE Search_Employee
	@Emp_Name NVARCHAR(60)
AS
	SELECT * FROM Employee
	WHERE Emp_Name=@Emp_Name
GO

-- Displays the entire table
CREATE PROCEDURE Display_EmpList
AS
	SELECT  Emp_ID AS [Mã nhân viên],
			Emp_Name AS [Tên nhân viên],
			Emp_Gender AS [Giới tính],
			Emp_DOB AS [Ngày sinh],
			Emp_Address AS [Địa chỉ],
			Emp_PhoneNumber AS [SĐT]
	FROM Employee
GO

-- Displays one data tuple
CREATE PROCEDURE Display_OneEmp
	@Emp_ID INT
AS
	SELECT	Emp_Name AS [Tên nhân viên],
			Emp_Gender AS [Giới tính],
			Emp_DOB AS [Ngày sinh],
			Emp_Address AS [Địa chỉ],
			Emp_PhoneNumber AS [SĐT]
	FROM Employee
	WHERE Emp_ID = @Emp_ID
GO



