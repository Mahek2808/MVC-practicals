CREATE PROCEDURE InsertDatainEmployees
(
	@name varchar(50)
)
As
BEGIN;

insert into Designation(Designation) Values(@name);

END;