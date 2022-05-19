Insert INTO Employee(FirstName,MiddleName,LastName,DOB,MobileNumber,Address,Salary) Values('Raju','M','Makwana','1999/03/22',9988776655,'Surat-Ring-Road',50000);
Insert INTO Employee(FirstName,MiddleName,LastName,DOB,MobileNumber,Address,Salary) Values('Keshav','M','Mahraja','1998/03/12',9008006655,'Ahmedabad-Iscon',20000);
Insert INTO Employee(FirstName,MiddleName,LastName,DOB,MobileNumber,Address,Salary) Values('Reema','R','Kagti','1989/09/09',8899700650,'Jamnagar-Mahadev-Temple-Road',30000);
Insert INTO Employee(FirstName,MiddleName,LastName,DOB,MobileNumber,Address,Salary) Values('Suresh','J','Nagar','1979/04/07',9256525455,'Surat-Kamrej Road',350000);
Insert INTO Employee(FirstName,MiddleName,LastName,DOB,MobileNumber,Address,Salary) Values('Baba','K','Ranjite','1969/08/21',9876523105,'Valsad-Chikuwadi',450000);

Select sum(Salary) from Employee;

Select * From Employee where DOB<'2000/01/01';

Select count(MiddleName) From Employee where MiddleName=null;

