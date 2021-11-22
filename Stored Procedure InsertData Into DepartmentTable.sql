CREATE PROC usp_InsertIntoDept(@DeptName nvarchar(50),@DeptGroupName nvarchar(50),@DeptModifiedDate datetime)
AS
BEGIN
BEGIN TRY
IF @DeptName IS NOT NULL
BEGIN
IF @DeptGroupName IS NOT NULL
BEGIN
IF @DeptModifiedDate IS NOT NULL
BEGIN
INSERT INTO HumanResources.Department(Name,GroupName,ModifiedDate) VALUES(@DeptName,@DeptGroupName,@DeptModifiedDate)
RETURN 1
END
Else
RETURN -3
END
ELSE
RETURN -2
END
RETURN -1
END TRY
BEGIN CATCH
RETURN -99
END CATCH
END