CREATE or ALTER PROCEDURE sp_selectEmpByFname
AS
BEGIN
	SELECT e.id,e.FirstName,e.MiddleName,e.LastName,d.Designation,e.DOB,e.MobileNumber,e.Address_,e.Salary from Employee as e,Designation as d where d.id=e.DesignationID Order by e.FirstName;
END;
