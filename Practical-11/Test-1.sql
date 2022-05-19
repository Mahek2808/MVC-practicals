Insert INTO Employee(FirstName,MiddleName,LastName,DOB,MobileNumber,Address) Values('Raju','M','Makwana','1999/03/22',9988776655,'Surat-Ring-Road');
Insert INTO Employee(FirstName,MiddleName,LastName,DOB,MobileNumber,Address) Values('Keshav','M','Mahraja','1998/03/12',9008006655,'Ahmedabad-Iscon');
Insert INTO Employee(FirstName,MiddleName,LastName,DOB,MobileNumber,Address) Values('Reema','R','Kagti','1989/09/09',8899700650,'Jamnagar-Mahadev-Temple-Road');
Insert INTO Employee(FirstName,MiddleName,LastName,DOB,MobileNumber,Address) Values('Suresh','J','Nagar','1979/04/07',9256525455,'Surat-Kamrej Road');
Insert INTO Employee(FirstName,MiddleName,LastName,DOB,MobileNumber,Address) Values('Baba','K','Ranjite','1969/08/21',9876523105,'Valsad-Chikuwadi');

Update Employee set FirstName='SQLPerson' where id=1;
Update Employee set MiddleName='I' where id>0;

Delete from Employee Where id<2;

Delete From Employee;


