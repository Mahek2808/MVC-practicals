
--  query to count the number of records by designation name
select count(Designation) from Designation;

-- query to display First Name, Middle Name, Last Name & Designation name
select e.FirstName,e.MiddleName,e.LastName,d.Designation from Employee as e,Designation as d where d.id=e.DesignationID;

-- Printing all the colum in a Employee View
select * from emp_view;

EXEC InsertDesignation 'HR';

--Query that returns only those Designation which have more than 1 Employee
SELECT D.Designation FROM Designation D WHERE (SELECT COUNT(*)FROM Employee E WHERE E.DesignationID = D.id) > 1

-- nonclustered index on DesignationID of Employee Table
Create nonclustered index Xdesignation on Employee([DesignationID] DESC)

-- Employee Having Highest Salary
SELECT FirstName,LastName,DOB,Salary,MAX(Salary) from Employee;