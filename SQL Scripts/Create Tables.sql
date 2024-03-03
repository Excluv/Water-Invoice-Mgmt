USE QLNuoc;


-- For Employee Form --
IF NOT EXISTS (SELECT * FROM QLNuoc.INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME='Employee')
BEGIN
	CREATE TABLE Employee(
		Emp_ID INT IDENTITY(1, 1),
		Emp_Name NVARCHAR(50),
		Emp_Gender NVARCHAR(3),
		Emp_DOB DATE,
		Emp_Address NVARCHAR(200),
		Emp_PhoneNumber INT,
		CONSTRAINT PK_Employee PRIMARY KEY (Emp_ID, Emp_Name)
	)
END;


-- For Customer Form --
IF NOT EXISTS (SELECT * FROM QLNuoc.INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME='Customer')
BEGIN
	CREATE TABLE Customer(
		Cus_ID INT IDENTITY(1, 1),
		Cus_Name NVARCHAR(50),
		Cus_Address NVARCHAR(200),
		CONSTRAINT PK_Customer PRIMARY KEY(Cus_ID, Cus_Name)
	)
END;


-- For Invoice Form --
IF NOT EXISTS (SELECT * FROM QLNuoc.INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME='Invoice')
BEGIN
	CREATE TABLE Invoice(
		Inv_ID INT IDENTITY(1, 1) PRIMARY KEY,
		Inv_Date DATE NOT NULL,
		Inv_Address NVARCHAR(200),
		Cus_Name NVARCHAR(50),
		Cus_ID INT,
		Inv_WaterUsage FLOAT,
		Inv_Cost AS Inv_WaterUsage * 19000,
		Inv_IssuedBy NVARCHAR(50),
		Inv_EmpID INT,
		CONSTRAINT FK_Customer FOREIGN KEY (Cus_ID, Cus_Name) REFERENCES Customer(Cus_ID, Cus_Name),
		CONSTRAINT FK_Employee FOREIGN KEY (Inv_EmpID, Inv_IssuedBy) REFERENCES Employee(Emp_ID, Emp_Name)
	)
END;