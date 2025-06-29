USE [DN 4.0];

GO
CREATE PROCEDURE sp_EmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;

EXEC sp_EmployeeCountByDepartment @DepartmentID = 2;
